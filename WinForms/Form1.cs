namespace WinForms;

public partial class Form1 : Form
{
    static string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Assets", "closeIcon.png");

    public Form1()
    {
        InitializeComponent();
        btnPathSource.Image = Image.FromFile(imagePath);
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
}
