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
        set { _inputPath = InputPath; } 
    }
    public string OutputPath
    {
        get { return _outputPath; } 
        set { _outputPath = OutputPath; }
    }
    public int StartMinutes
    {
        get { return _startMinutes; }
        set { _startMinutes = StartMinutes; }
    }
    public int StartSeconds
    {
        get { return _startSeconds; }
        set { _startSeconds = StartSeconds; }
    }
    public int EndMinutes
    {
        get { return _endMinutes; }
        set { _endMinutes = EndMinutes; }
    }
    public int EndSeconds
    {
        get { return _endSeconds; }
        set { _endSeconds = EndSeconds; }
    }
    

    public TimeSpan StartTime 
    {
        get { return _startTime; } 
        set { _startTime = StartTime; }
    }
    public TimeSpan EndTime
    {
        get { return _endTime; }
        set { _endTime = EndTime; }
    }

    public bool MirrorHorizontal 
    { 
        get { return _mirrorHorizontal; } 
        set { _mirrorHorizontal = MirrorHorizontal; }
    }
    public bool MirrorVertical 
    { 
        get { return _mirrorVertical; } 
        set { _mirrorVertical = MirrorVertical; }
    }

    public float RotationAngle // Degrees clockwise
    {
        get { return _rotationAngle; }
        set { _rotationAngle = RotationAngle; }
    }

    public int? CropXStart
    { 
        get { return _cropXStart; }
        set { _cropXStart = CropXEnd; }
    }
    public int? CropXEnd 
    { 
        get { return _cropXEnd; }
        set { _cropXEnd = CropXStart;}
    }
    public int? CropYStart
    { 
        get { return _cropYStart; }
        set { _cropYStart = CropYStart; }
    }
    public int? CropYEnd 
    { 
        get { return _cropYEnd; }
        set {  _cropYEnd = CropYEnd;} 
    }
}
