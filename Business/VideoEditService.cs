using Core.Models;
using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class VideoEditService
    {
        public class VideoEditorService
        {
            private readonly FfmpegService _ffmpegService = new();

            public void EditVideo(VideoEditOptionsConfiguration options)
            {
                string args = _ffmpegService.GenerateCommand(options);
                _ffmpegService.RunFfmpegCommand(args);
            }
        }
    }
}
