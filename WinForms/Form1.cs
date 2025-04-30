using Infrastructure;
using System.IO;

namespace WinForms;

public partial class Form1 : Form
{
    private int maxMinutesLimit;
    private int maxSecondsLimit;
    private int minMinutesLimit = 0;
    private int minSecondsLimit = 0;

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

        // Evento de mudança da ScrollBar
        hScrollBarAngle.Scroll += hScrollBarAngle_Scroll;

        // Evento de mudança no TextBox
        txtAngle.TextChanged += txtAngle_TextChanged;
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
                int remainingSeconds = duration.Value.Seconds;

                txtStartMinutes.Text = "0";
                txtStartSeconds.Text = "0";

                txtEndMinutes.Text = totalMinutes.ToString();
                txtEndSeconds.Text = remainingSeconds.ToString();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erro to get video duration info: " + ex.Message);
        }

        try
        {
            var (width, height) = FfmpegService.GetVideoDimensions(videoPath);

            txtInitialX.Text = "0";
            txtFinalX.Text = width.ToString();
            lblStartY.Text = "0";
            lblEndY.Text = height.ToString();
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

    private void hScrollBarAngle_Scroll(object sender, ScrollEventArgs e)
    {
        txtAngle.Text = hScrollBarAngle.Value.ToString();
    }

    #endregion

}
