namespace WinForms;

public partial class Form1 : Form
{
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

        txtAngle.Text = hScrollBarAngle.Value.ToString();

        // Evento de mudança da ScrollBar
        hScrollBarAngle.Scroll += hScrollBarAngle_Scroll;

        // Evento de mudança no TextBox
        txtAngle.TextChanged += txtAngle_TextChanged;
    }

    private void checkBox2_CheckedChanged(object sender, EventArgs e)
    {

    }

    private void lblSource_Click(object sender, EventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {

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
        if(int.TryParse(txtAngle.Text, out int angle))
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
