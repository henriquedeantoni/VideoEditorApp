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
    public string GenerateCommand(VideoEditOptionsConfiguration options)
    {
        var filters = new List<string>();

        if (options.MirrorHorizontal) filters.Add("hflip");
        if (options.MirrorVertical) filters.Add("vflip");

        if (options.RotationAngle != 0)
        {
            float angle = options.RotationAngle * (float)Math.PI / 180f;
            filters.Add($"rotate={angle}:ow=rotw({angle}):oh=roth({angle}):c=black@0");
        }

        if (options.CropXStart.HasValue && options.CropXEnd.HasValue && options.CropYStart.HasValue && options.CropYEnd.HasValue)
        {
            int width = options.CropXEnd.Value - options.CropXStart.Value;
            int height = options.CropYEnd.Value - options.CropYStart.Value;
            filters.Add($"crop={width}:{height}:{options.CropXStart}:{options.CropYStart}");
        }

        string filterString = filters.Count > 0 ? $" -vf \"{string.Join(",", filters)}\"" : string.Empty;

        return $"-i \"{options.InputPath}\" -ss {options.StartTime} -to {options.EndTime} {filterString} -y \"{options.OutputPath}\"";
    }

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
        process.WaitForExit();
    }

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

        if(double.TryParse(output.Trim(), System.Globalization.CultureInfo.InvariantCulture, out double seconds))
        {
            return TimeSpan.FromSeconds(seconds);
        }

        return null;
    }
}
