using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models;

public class VideoEditOptionsConfiguration
{
    public string InputPath { get; set; } = string.Empty;
    public string OutputPath { get; set; } = string.Empty;

    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }

    public bool MirrorHorizontal { get; set; }
    public bool MirrorVertical { get; set; }

    public float RotationAngle { get; set; } // Degrees clockwise

    public int? CropXStart { get; set; }
    public int? CropXEnd { get; set; }
    public int? CropYStart { get; set; }
    public int? CropYEnd { get; set; }
}
