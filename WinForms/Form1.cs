using Core.Models;
using Infrastructure;
using System.IO;

namespace WinForms;

public partial class Form1 : Form
{
    private int minMinutesLimit = 0;
    private int minSecondsLimit = 0;
    private int maxMinutesLimit;
    private int maxSecondsLimit;

    private VideoEditOptionsConfiguration EditOptions;

    static string imagePathDestinity = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "closeIcon.png");
    static string imagePathSource = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "openIcon.png");

    public string DocumentsPath { get; } = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);


    public Form1()
    {
        InitializeComponent();
        btnPathSource.Image = Image.FromFile(imagePathSource);
        btnPathSource.Text = "";
        btnPathSource.Size = new Size(32, 32);
        btnPathSource.FlatStyle = FlatStyle.Flat;

        btnPathDestination.Image = Image.FromFile(imagePathDestinity);
        btnPathDestination.Text = "";
        btnPathDestination.Size = new Size(32, 32);
        btnPathDestination.FlatStyle = FlatStyle.Flat;

        txtStartMinutes.Text = "0";
        txtStartSeconds.Text = "0";
        txtEndMinutes.Text = "0";
        txtEndSeconds.Text = "0";

        txtAngle.Text = hScrollBarAngle.Value.ToString();
        txtStartMinutes.Text = vScrollBarStartMin.Value.ToString();
        txtStartSeconds.Text = vScrollBarStartSec.Value.ToString();
        txtEndMinutes.Text = vScrollBarEndMin.Value.ToString();
        txtEndSeconds.Text = vScrollBarEndSec.Value.ToString();

        // change event on ScrollBars
        hScrollBarAngle.Scroll += hScrollBarAngle_Scroll;
        vScrollBarStartMin.Scroll += vScrollBarStartMin_Scroll;
        vScrollBarStartSec.Scroll += vScrollBarStartSec_Scroll;
        vScrollBarEndMin.Scroll += vScrollBarEndMin_Scroll;
        vScrollBarEndSec.Scroll += vScrollBarEndSec_Scroll;

        // change event on TextBoxes
        txtAngle.TextChanged += txtAngle_TextChanged;
        txtStartMinutes.TextChanged += txtStartMinutes_TextChanged;
        txtStartSeconds.TextChanged += txtStartSeconds_TextChanged;
        txtEndMinutes.TextChanged += txtEndMinutes_TextChanged;
        txtEndSeconds.TextChanged += txtEndSeconds_TextChanged;
    }


    public void LoadVideoValues(string videoPath)
    {
        FfmpegService ffmpegService = new FfmpegService();

        try
        {
            var duration = ffmpegService.GetVideoDuration(videoPath);
            if (duration.HasValue)
            {
                int totalMinutes = (int)duration.Value.TotalMinutes;
                int remainingSeconds = (int)duration.Value.TotalSeconds-(int)totalMinutes*60;

                txtStartMinutes.Text = "0";
                txtStartSeconds.Text = "0";

                txtEndMinutes.Text = totalMinutes.ToString();
                txtEndSeconds.Text = remainingSeconds.ToString();

                vScrollBarStartMin.Minimum = 0;
                vScrollBarStartMin.Maximum = totalMinutes - 1;
                vScrollBarStartSec.Minimum = 0;
                vScrollBarStartSec.Maximum = 59;
                vScrollBarEndMin.Minimum = 0;
                vScrollBarEndMin.Maximum = totalMinutes;
                vScrollBarEndSec.Minimum = 0;
                vScrollBarEndSec.Maximum = 60;

                //minMinutesLimit = int.Parse(txtStartMinutes.Text);
                //minSecondsLimit = int.Parse(txtStartMinutes.Text);
                //maxMinutesLimit = int.Parse(txtEndMinutes.Text);
                //maxSecondsLimit = int.Parse(txtEndSeconds.Text);

            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro to get video duration info: " + ex.Message);
        }

        try
        {

            var (width, height) = ffmpegService.GetVideoDimensions(videoPath);


            txtInitialX.Text = "0";
            txtFinalX.Text = width.ToString();
            txtInitialY.Text = "0";
            txtFinalY.Text = height.ToString();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro to get video dimensions info: " + ex.Message);
        }

    }


    #region
    private void btnPathSource_Click(object sender, EventArgs e)
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.InitialDirectory = DocumentsPath;
            openFileDialog.Filter = "Video Files|*.mp4;*.avi;*.mov;*.wmv;*.mkv;*.flv;*.mpeg;*.mpg|All Files|*.*";
            openFileDialog.Title = "Select a video file";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtInput.Text = openFileDialog.FileName;
                axWindowsMediaPlayer1.URL = openFileDialog.FileName;
                LoadVideoValues(openFileDialog.FileName);

            }
        }

    }

    private void btnPathDestination_Click(object sender, EventArgs e)
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.InitialDirectory = DocumentsPath;
            openFileDialog.Filter = "Video Files|*.mp4;*.avi;*.mov;*.wmv;*.mkv;*.flv;*.mpeg;*.mpg|All Files|*.*";
            openFileDialog.Title = "Select a video file";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtInput.Text = openFileDialog.FileName + txtSufix.Text;
            }
        }
    }

    private void txtAngle_TextChanged(object sender, EventArgs e)
    {
        if (int.TryParse(txtAngle.Text, out int angle))
        {
            if (angle >= hScrollBarAngle.Minimum && angle <= hScrollBarAngle.Maximum)
            {
                hScrollBarAngle.Value = angle;
            }
        }
    }
    private void txtStartMinutes_TextChanged(object sender, EventArgs e)
    {
        if(int.TryParse(txtStartMinutes.Text, out int startMinutes))
        {
            if(startMinutes >= vScrollBarStartMin.Minimum && startMinutes <= vScrollBarStartMin.Maximum)
            {
                vScrollBarStartMin.Value = startMinutes;
            }
        }
    }

    private void txtStartSeconds_TextChanged(object sender, EventArgs e)
    {
        if(int.TryParse(txtStartSeconds.Text, out int startSeconds))
        {
            if(startSeconds >= vScrollBarStartSec.Minimum && startSeconds <= vScrollBarStartSec.Maximum)
            {
                vScrollBarStartSec.Value = startSeconds;
            }
        }
    }

    private void txtEndMinutes_TextChanged(object sender, EventArgs e)
    {
        if(int.TryParse(txtEndMinutes.Text, out int endMinutes))
        {
            if(endMinutes >= vScrollBarEndMin.Minimum && endMinutes <= vScrollBarEndMin.Maximum)
            {
                vScrollBarEndMin.Value = endMinutes;
            }
        }
    }

    private void txtEndSeconds_TextChanged(object sender, EventArgs e)
    {
        if(int.TryParse(txtEndSeconds.Text, out int endSeconds))
        {
            if(endSeconds >= vScrollBarEndSec.Minimum && endSeconds <= vScrollBarEndSec.Maximum)
            {
                vScrollBarEndSec.Value = endSeconds;
            }
        }
    }



    private void hScrollBarAngle_Scroll(object sender, ScrollEventArgs e)
    {
        txtAngle.Text = hScrollBarAngle.Value.ToString();
    }
    private void vScrollBarStartMin_Scroll(object sender, ScrollEventArgs e)
    {
        txtStartMinutes.Text = vScrollBarStartMin.Value.ToString();
    }
    private void vScrollBarStartSec_Scroll(object sender, ScrollEventArgs e)
    {
        txtStartSeconds.Text = vScrollBarStartSec.Value.ToString();
    }
    private void vScrollBarEndMin_Scroll(object sender, ScrollEventArgs e)
    {
        txtEndMinutes.Text = vScrollBarEndMin.Value.ToString();
    }
    private void vScrollBarEndSec_Scroll(object sender, ScrollEventArgs e)
    {
        txtEndSeconds.Text = vScrollBarEndSec.Value.ToString();
    }

    #endregion

    private void btnProcess_Click(object sender, EventArgs e)
    {
        SaveValues();
        ProcessVideo();
    }

    public void SaveValues()
    {
        try
        {
            EditOptions = new VideoEditOptionsConfiguration(
            inputPath: txtInput.Text,
            outputPath: txtInput.Text + txtSufix.Text,
            startMinutes: int.TryParse(txtStartMinutes.Text, out int startMinutesParsed) ? startMinutesParsed : 0,
            startSeconds: int.TryParse(txtStartSeconds.Text, out int startSecondsParsed) ? startSecondsParsed : 0,
            endMinutes: int.TryParse(txtEndMinutes.Text, out int endMinutesParsed) ? endMinutesParsed : 0,
            endSeconds: int.TryParse(txtEndSeconds.Text, out int endSecondsParsed) ? endSecondsParsed : 0,
            startTime: new TimeSpan(0, startMinutesParsed, startSecondsParsed),
            endTime: new TimeSpan(0, endMinutesParsed, endSecondsParsed),
            totalMilliseconds: endMinutesParsed * 60 * 1000 + endSecondsParsed * 1000 - startMinutesParsed * 60 * 1000 - startSecondsParsed * 1000,
            mirrorHorizontal: chkMirrorH.Checked,
            mirrorVertical: chkMirrorV.Checked,
            rotationAngle: float.TryParse(txtAngle.Text, out float angle) ? angle : 0f,
            cropXStart: int.TryParse(txtInitialX.Text, out int cropXStartParsed) ? cropXStartParsed : (int?)null,
            cropXEnd: int.TryParse(txtFinalX.Text, out int cropXEndParsed) ? cropXEndParsed : (int?)null,
            cropYStart: int.TryParse(lblStartY.Text, out int cropYStartParsed) ? cropYStartParsed : (int?)null,
            cropYEnd: int.TryParse(lblEndY.Text, out int cropYEndParsed) ? cropYEndParsed : (int?)null
            );

            MessageBox.Show("Values saved with success!");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error on saving values: " + ex.Message);
        }
    }

    public void ProcessVideo()
    {
        if (EditOptions == null)
        {
            MessageBox.Show("Edit options not set. Please save values before processing.");
            return;
        }

        try
        {
            var ffmpegService = new FfmpegService();
            ffmpegService.ProcessVideo(EditOptions);

            MessageBox.Show("Video processed successfully!");
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error during video processing: " + ex.Message);
        }
    }


}
