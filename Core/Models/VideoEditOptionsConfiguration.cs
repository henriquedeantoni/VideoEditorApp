using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models;

public class VideoEditOptionsConfiguration
{
    private string _inputPath = string.Empty;
    private string _outputPath = string.Empty;
    private int _startMinutes;
    private int _startSeconds;
    private int _endMinutes;
    private int _endSeconds;
    private TimeSpan _startTime;
    private TimeSpan _endTime;
    private bool _mirrorHorizontal;
    private bool _mirrorVertical;
    private float _rotationAngle;
    private int? _cropXStart;
    private int? _cropXEnd;
    private int? _cropYStart;
    private int? _cropYEnd;

    public string InputPath 
    {
        get { return _inputPath; }
        set { _inputPath = value; } 
    }
    public string OutputPath
    {
        get { return _outputPath; } 
        set { _outputPath = value; }
    }
    public int StartMinutes
    {
        get { return _startMinutes; }
        set { _startMinutes = value; }
    }
    public int StartSeconds
    {
        get { return _startSeconds; }
        set { _startSeconds = value; }
    }
    public int EndMinutes
    {
        get { return _endMinutes; }
        set { _endMinutes = value; }
    }
    public int EndSeconds
    {
        get { return _endSeconds; }
        set { _endSeconds = value; }
    }
    

    public TimeSpan StartTime 
    {
        get { return _startTime; } 
        set { _startTime = value; }
    }
    public TimeSpan EndTime
    {
        get { return _endTime; }
        set { _endTime = value; }
    }

    public bool MirrorHorizontal 
    { 
        get { return _mirrorHorizontal; } 
        set { _mirrorHorizontal = value; }
    }
    public bool MirrorVertical 
    { 
        get { return _mirrorVertical; } 
        set { _mirrorVertical = value; }
    }

    public float RotationAngle // Degrees clockwise
    {
        get { return _rotationAngle; }
        set { _rotationAngle = value; }
    }

    public int? CropXStart
    { 
        get { return _cropXStart; }
        set { _cropXStart = value; }
    }
    public int? CropXEnd 
    { 
        get { return _cropXEnd; }
        set { _cropXEnd = value; }
    }
    public int? CropYStart
    { 
        get { return _cropYStart; }
        set { _cropYStart = value; }
    }
    public int? CropYEnd 
    { 
        get { return _cropYEnd; }
        set {  _cropYEnd = value; } 
    }

    public VideoEditOptionsConfiguration(string inputPath, string outputPath, int startMinutes, int startSeconds, int endMinutes, int endSeconds, TimeSpan startTime, TimeSpan endTime, bool mirrorHorizontal, bool mirrorVertical, float rotationAngle, int? cropXStart, int? cropXEnd, int? cropYStart, int? cropYEnd)
    {
        InputPath = inputPath;
        OutputPath = outputPath;
        StartMinutes = startMinutes;
        StartSeconds = startSeconds;
        EndMinutes = endMinutes;
        EndSeconds = endSeconds;
        StartTime = MinutesSecondsToTimeSpan(startMinutes, startSeconds);
        EndTime = MinutesSecondsToTimeSpan(endMinutes, endSeconds); ;
        MirrorHorizontal = mirrorHorizontal;
        MirrorVertical = mirrorVertical;
        RotationAngle = rotationAngle;
        CropXStart = cropXStart;
        CropXEnd = cropXEnd;
        CropYStart = cropYStart;
        CropYEnd = cropYEnd;
    }

    private TimeSpan MinutesSecondsToTimeSpan(int minutes, int seconds)
    {
        return new TimeSpan(0, minutes, seconds);
    }
}
