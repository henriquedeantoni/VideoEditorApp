using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Core.Models;

namespace Infrastructure;

public class FfmpegService
{
    // ----------------------------
    // GROUP 1: VIDEO DATA READING
    // ----------------------------

    /// <summary>
    /// Get total video duration in TimeSpan.
    /// </summary>
    public TimeSpan? GetVideoDuration(string videoPath)
    {
        var process = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = "ffprobe",
                Arguments = $"-v error -show_entries format=duration -of default=noprint_wrappers=1:nokey=1 \"{videoPath}\"",
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
            }
        };

        process.Start();
        string output = process.StandardOutput.ReadToEnd();
        process.WaitForExit();

        return double.TryParse(output.Trim(), System.Globalization.CultureInfo.InvariantCulture, out double seconds)
            ? TimeSpan.FromSeconds(seconds)
            : null;
    }

    /// <summary>
    /// Get a Width and video Hight.
    /// </summary>
    public (int Width, int Height) GetVideoDimensions(string videoPath)
    {
        var process = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = "ffprobe",
                Arguments = $"-v error -select_streams v:0 -show_entries stream=width,height -of csv=s=x:p=0 \"{videoPath}\"",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            }
        };

        process.Start();
        string output = process.StandardOutput.ReadToEnd();
        process.WaitForExit();

        if (!string.IsNullOrWhiteSpace(output))
        {
            var parts = output.Trim().Split('x');
            if (parts.Length == 2 &&
                int.TryParse(parts[0], out int width) &&
                int.TryParse(parts[1], out int height))
            {
                return (width, height);
            }
        }

        throw new Exception("Video dimensions information not available.");
    }

    // ----------------------------
    // GRUPO 2: VIDEO PROCCESS
    // ----------------------------

    /// <summary>
    /// Write a FFmpeg command string based in video options.
    /// </summary>
    public string GenerateCommand(VideoEditOptionsConfiguration options)
    {
        var filters = BuildFilterList(options);
        string filterString = filters.Count > 0 ? $" -vf \"{string.Join(",", filters)}\"" : string.Empty;

        return $"-i \"{options.InputPath}\" -ss {options.StartTime} -to {options.EndTime} {filterString} -y \"{options.OutputPath}\"";
    }

    /// <summary>
    /// Execute FFmpeg command written.
    /// </summary>
    public void RunFfmpegCommand(string arguments)
    {
        var process = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = "ffmpeg",
                Arguments = arguments,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
            }
        };

        process.Start();

        string output = process.StandardOutput.ReadToEnd();
        string error = process.StandardError.ReadToEnd();

        process.WaitForExit();

        if (process.ExitCode != 0)
        {
            throw new Exception($"FFmpeg exited with code {process.ExitCode}: {error}");
        }
    }

    /// <summary>
    /// Entire proccess: build command and execute FFmpeg.
    /// </summary>
    public void ProcessVideo(VideoEditOptionsConfiguration options)
    {
        string command = GenerateCommand(options);
        RunFfmpegCommand(command);
    }

    // ----------------------------
    // GRUPO 3: PRIVATE UTILITARIES
    // ----------------------------

    /// <summary>
    /// Build the list FFmpeg filter.
    /// </summary>
    private List<string> BuildFilterList(VideoEditOptionsConfiguration options)
    {
        var filters = new List<string>();

        if (options.MirrorHorizontal) filters.Add("hflip");
        if (options.MirrorVertical) filters.Add("vflip");

        if (options.RotationAngle != 0)
        {
            float angle = options.RotationAngle * (float)Math.PI / 180f;
            filters.Add($"rotate={angle}:ow=rotw({angle}):oh=roth({angle}):c=black@0");
        }

        if (options.CropXStart.HasValue && options.CropXEnd.HasValue &&
            options.CropYStart.HasValue && options.CropYEnd.HasValue)
        {
            int width = options.CropXEnd.Value - options.CropXStart.Value;
            int height = options.CropYEnd.Value - options.CropYStart.Value;
            filters.Add($"crop={width}:{height}:{options.CropXStart}:{options.CropYStart}");
        }

        return filters;
    }
}
