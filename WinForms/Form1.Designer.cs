namespace WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtInput = new TextBox();
            txtOutput = new TextBox();
            txtStartMinutes = new TextBox();
            gbxPath = new GroupBox();
            btnPathDestination = new Button();
            btnPathSource = new Button();
            label1 = new Label();
            lblDestination = new Label();
            lblSource = new Label();
            txtSufix = new TextBox();
            gbxCutTime = new GroupBox();
            lblEndSeconds = new Label();
            lblEndMinutes = new Label();
            lblStartSeconds = new Label();
            lblStartMinutes = new Label();
            vScrollBarEndSec = new VScrollBar();
            txtEndSeconds = new TextBox();
            vScrollBarEndMin = new VScrollBar();
            txtEndMinutes = new TextBox();
            vScrollBarStartSec = new VScrollBar();
            txtStartSeconds = new TextBox();
            vScrollBarStartMin = new VScrollBar();
            lblEndTime = new Label();
            lblStartTime = new Label();
            gbxMirror = new GroupBox();
            chkMirrorV = new CheckBox();
            chkMirrorH = new CheckBox();
            gbxAngle = new GroupBox();
            hScrollBarAngle = new HScrollBar();
            lblAngle = new Label();
            txtAngle = new TextBox();
            gbxCutScreen = new GroupBox();
            label2 = new Label();
            lblEndY = new Label();
            lblStartY = new Label();
            lblEndX = new Label();
            lblStartX = new Label();
            lblHorizontalX = new Label();
            txtInitialY = new TextBox();
            txtFinalY = new TextBox();
            txtInitialX = new TextBox();
            txtFinalX = new TextBox();
            btnProcess = new Button();
            groupBox1 = new GroupBox();
            chkOriginalAudio = new CheckBox();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            lblTotalMsec = new Label();
            gpbVideoInfo = new GroupBox();
            lblTotalMillisec = new Label();
            gbxPath.SuspendLayout();
            gbxCutTime.SuspendLayout();
            gbxMirror.SuspendLayout();
            gbxAngle.SuspendLayout();
            gbxCutScreen.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            gpbVideoInfo.SuspendLayout();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(6, 36);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(100, 23);
            txtInput.TabIndex = 0;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(172, 36);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(100, 23);
            txtOutput.TabIndex = 1;
            // 
            // txtStartMinutes
            // 
            txtStartMinutes.Location = new Point(15, 53);
            txtStartMinutes.Name = "txtStartMinutes";
            txtStartMinutes.Size = new Size(34, 23);
            txtStartMinutes.TabIndex = 2;
            // 
            // gbxPath
            // 
            gbxPath.Controls.Add(btnPathDestination);
            gbxPath.Controls.Add(btnPathSource);
            gbxPath.Controls.Add(label1);
            gbxPath.Controls.Add(lblDestination);
            gbxPath.Controls.Add(lblSource);
            gbxPath.Controls.Add(txtSufix);
            gbxPath.Controls.Add(txtInput);
            gbxPath.Controls.Add(txtOutput);
            gbxPath.Location = new Point(12, 12);
            gbxPath.Name = "gbxPath";
            gbxPath.Size = new Size(362, 119);
            gbxPath.TabIndex = 4;
            gbxPath.TabStop = false;
            gbxPath.Text = "Path";
            // 
            // btnPathDestination
            // 
            btnPathDestination.Location = new Point(281, 36);
            btnPathDestination.Name = "btnPathDestination";
            btnPathDestination.Size = new Size(44, 23);
            btnPathDestination.TabIndex = 14;
            btnPathDestination.Text = "button2";
            btnPathDestination.UseVisualStyleBackColor = true;
            btnPathDestination.Click += btnPathDestination_Click;
            // 
            // btnPathSource
            // 
            btnPathSource.Location = new Point(116, 36);
            btnPathSource.Name = "btnPathSource";
            btnPathSource.Size = new Size(50, 23);
            btnPathSource.TabIndex = 13;
            btnPathSource.Text = "button1";
            btnPathSource.UseVisualStyleBackColor = true;
            btnPathSource.Click += btnPathSource_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(172, 62);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 12;
            label1.Text = "Sufix:";
            // 
            // lblDestination
            // 
            lblDestination.AutoSize = true;
            lblDestination.Location = new Point(172, 19);
            lblDestination.Name = "lblDestination";
            lblDestination.Size = new Size(70, 15);
            lblDestination.TabIndex = 11;
            lblDestination.Text = "Destination:";
            // 
            // lblSource
            // 
            lblSource.AutoSize = true;
            lblSource.Location = new Point(6, 19);
            lblSource.Name = "lblSource";
            lblSource.Size = new Size(46, 15);
            lblSource.TabIndex = 10;
            lblSource.Text = "Source:";
            // 
            // txtSufix
            // 
            txtSufix.Location = new Point(172, 80);
            txtSufix.Name = "txtSufix";
            txtSufix.Size = new Size(100, 23);
            txtSufix.TabIndex = 2;
            // 
            // gbxCutTime
            // 
            gbxCutTime.Controls.Add(lblEndSeconds);
            gbxCutTime.Controls.Add(lblEndMinutes);
            gbxCutTime.Controls.Add(lblStartSeconds);
            gbxCutTime.Controls.Add(lblStartMinutes);
            gbxCutTime.Controls.Add(vScrollBarEndSec);
            gbxCutTime.Controls.Add(txtEndSeconds);
            gbxCutTime.Controls.Add(vScrollBarEndMin);
            gbxCutTime.Controls.Add(txtEndMinutes);
            gbxCutTime.Controls.Add(vScrollBarStartSec);
            gbxCutTime.Controls.Add(txtStartSeconds);
            gbxCutTime.Controls.Add(vScrollBarStartMin);
            gbxCutTime.Controls.Add(lblEndTime);
            gbxCutTime.Controls.Add(lblStartTime);
            gbxCutTime.Controls.Add(txtStartMinutes);
            gbxCutTime.Location = new Point(389, 12);
            gbxCutTime.Name = "gbxCutTime";
            gbxCutTime.Size = new Size(224, 119);
            gbxCutTime.TabIndex = 5;
            gbxCutTime.TabStop = false;
            gbxCutTime.Text = "Cut Time";
            // 
            // lblEndSeconds
            // 
            lblEndSeconds.AutoSize = true;
            lblEndSeconds.Location = new Point(180, 36);
            lblEndSeconds.Name = "lblEndSeconds";
            lblEndSeconds.Size = new Size(27, 15);
            lblEndSeconds.TabIndex = 23;
            lblEndSeconds.Text = "sec.";
            // 
            // lblEndMinutes
            // 
            lblEndMinutes.AutoSize = true;
            lblEndMinutes.Location = new Point(128, 35);
            lblEndMinutes.Name = "lblEndMinutes";
            lblEndMinutes.Size = new Size(31, 15);
            lblEndMinutes.TabIndex = 23;
            lblEndMinutes.Text = "Min.";
            // 
            // lblStartSeconds
            // 
            lblStartSeconds.AutoSize = true;
            lblStartSeconds.Location = new Point(67, 34);
            lblStartSeconds.Name = "lblStartSeconds";
            lblStartSeconds.Size = new Size(27, 15);
            lblStartSeconds.TabIndex = 22;
            lblStartSeconds.Text = "sec.";
            // 
            // lblStartMinutes
            // 
            lblStartMinutes.AutoSize = true;
            lblStartMinutes.Location = new Point(15, 34);
            lblStartMinutes.Name = "lblStartMinutes";
            lblStartMinutes.Size = new Size(31, 15);
            lblStartMinutes.TabIndex = 21;
            lblStartMinutes.Text = "Min.";
            // 
            // vScrollBarEndSec
            // 
            vScrollBarEndSec.Location = new Point(180, 80);
            vScrollBarEndSec.Name = "vScrollBarEndSec";
            vScrollBarEndSec.Size = new Size(34, 31);
            vScrollBarEndSec.TabIndex = 20;
            // 
            // txtEndSeconds
            // 
            txtEndSeconds.Location = new Point(180, 53);
            txtEndSeconds.Name = "txtEndSeconds";
            txtEndSeconds.Size = new Size(34, 23);
            txtEndSeconds.TabIndex = 19;
            // 
            // vScrollBarEndMin
            // 
            vScrollBarEndMin.Location = new Point(128, 79);
            vScrollBarEndMin.Name = "vScrollBarEndMin";
            vScrollBarEndMin.Size = new Size(34, 31);
            vScrollBarEndMin.TabIndex = 18;
            // 
            // txtEndMinutes
            // 
            txtEndMinutes.Location = new Point(128, 53);
            txtEndMinutes.Name = "txtEndMinutes";
            txtEndMinutes.Size = new Size(34, 23);
            txtEndMinutes.TabIndex = 17;
            // 
            // vScrollBarStartSec
            // 
            vScrollBarStartSec.Location = new Point(67, 80);
            vScrollBarStartSec.Name = "vScrollBarStartSec";
            vScrollBarStartSec.Size = new Size(34, 31);
            vScrollBarStartSec.TabIndex = 16;
            // 
            // txtStartSeconds
            // 
            txtStartSeconds.Location = new Point(67, 53);
            txtStartSeconds.Name = "txtStartSeconds";
            txtStartSeconds.Size = new Size(34, 23);
            txtStartSeconds.TabIndex = 15;
            // 
            // vScrollBarStartMin
            // 
            vScrollBarStartMin.Location = new Point(15, 79);
            vScrollBarStartMin.Name = "vScrollBarStartMin";
            vScrollBarStartMin.Size = new Size(34, 31);
            vScrollBarStartMin.TabIndex = 14;
            // 
            // lblEndTime
            // 
            lblEndTime.AutoSize = true;
            lblEndTime.Location = new Point(137, 18);
            lblEndTime.Name = "lblEndTime";
            lblEndTime.Size = new Size(59, 15);
            lblEndTime.TabIndex = 13;
            lblEndTime.Text = "End Time:";
            // 
            // lblStartTime
            // 
            lblStartTime.AutoSize = true;
            lblStartTime.Location = new Point(15, 18);
            lblStartTime.Name = "lblStartTime";
            lblStartTime.Size = new Size(63, 15);
            lblStartTime.TabIndex = 12;
            lblStartTime.Text = "Start Time:";
            // 
            // gbxMirror
            // 
            gbxMirror.Controls.Add(chkMirrorV);
            gbxMirror.Controls.Add(chkMirrorH);
            gbxMirror.Location = new Point(12, 145);
            gbxMirror.Name = "gbxMirror";
            gbxMirror.Size = new Size(200, 100);
            gbxMirror.TabIndex = 6;
            gbxMirror.TabStop = false;
            gbxMirror.Text = "Mirror";
            // 
            // chkMirrorV
            // 
            chkMirrorV.AutoSize = true;
            chkMirrorV.Location = new Point(23, 58);
            chkMirrorV.Name = "chkMirrorV";
            chkMirrorV.Size = new Size(100, 19);
            chkMirrorV.TabIndex = 7;
            chkMirrorV.Text = "Vertical Mirror";
            chkMirrorV.UseVisualStyleBackColor = true;
            // 
            // chkMirrorH
            // 
            chkMirrorH.AutoSize = true;
            chkMirrorH.Location = new Point(23, 33);
            chkMirrorH.Name = "chkMirrorH";
            chkMirrorH.Size = new Size(117, 19);
            chkMirrorH.TabIndex = 7;
            chkMirrorH.Text = "Horizontal Mirror";
            chkMirrorH.UseVisualStyleBackColor = true;
            // 
            // gbxAngle
            // 
            gbxAngle.Controls.Add(hScrollBarAngle);
            gbxAngle.Controls.Add(lblAngle);
            gbxAngle.Controls.Add(txtAngle);
            gbxAngle.Location = new Point(637, 23);
            gbxAngle.Name = "gbxAngle";
            gbxAngle.Size = new Size(170, 100);
            gbxAngle.TabIndex = 7;
            gbxAngle.TabStop = false;
            gbxAngle.Text = "Angle Alignment";
            // 
            // hScrollBarAngle
            // 
            hScrollBarAngle.Location = new Point(22, 66);
            hScrollBarAngle.Maximum = 90;
            hScrollBarAngle.Minimum = -90;
            hScrollBarAngle.Name = "hScrollBarAngle";
            hScrollBarAngle.Size = new Size(124, 25);
            hScrollBarAngle.TabIndex = 10;
            hScrollBarAngle.Scroll += hScrollBarAngle_Scroll;
            // 
            // lblAngle
            // 
            lblAngle.AutoSize = true;
            lblAngle.Location = new Point(22, 19);
            lblAngle.Name = "lblAngle";
            lblAngle.Size = new Size(86, 15);
            lblAngle.TabIndex = 13;
            lblAngle.Text = "Angle Rotation";
            // 
            // txtAngle
            // 
            txtAngle.Location = new Point(22, 37);
            txtAngle.Name = "txtAngle";
            txtAngle.Size = new Size(124, 23);
            txtAngle.TabIndex = 0;
            txtAngle.TextChanged += txtAngle_TextChanged;
            // 
            // gbxCutScreen
            // 
            gbxCutScreen.Controls.Add(label2);
            gbxCutScreen.Controls.Add(lblEndY);
            gbxCutScreen.Controls.Add(lblStartY);
            gbxCutScreen.Controls.Add(lblEndX);
            gbxCutScreen.Controls.Add(lblStartX);
            gbxCutScreen.Controls.Add(lblHorizontalX);
            gbxCutScreen.Controls.Add(txtInitialY);
            gbxCutScreen.Controls.Add(txtFinalY);
            gbxCutScreen.Controls.Add(txtInitialX);
            gbxCutScreen.Controls.Add(txtFinalX);
            gbxCutScreen.Location = new Point(12, 266);
            gbxCutScreen.Name = "gbxCutScreen";
            gbxCutScreen.Size = new Size(224, 172);
            gbxCutScreen.TabIndex = 8;
            gbxCutScreen.TabStop = false;
            gbxCutScreen.Text = "Cut Screen ( X - Y)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 80);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 14;
            label2.Text = "Vertical Y";
            // 
            // lblEndY
            // 
            lblEndY.AutoSize = true;
            lblEndY.Location = new Point(117, 95);
            lblEndY.Name = "lblEndY";
            lblEndY.Size = new Size(37, 15);
            lblEndY.TabIndex = 16;
            lblEndY.Text = "End Y";
            // 
            // lblStartY
            // 
            lblStartY.AutoSize = true;
            lblStartY.Location = new Point(17, 95);
            lblStartY.Name = "lblStartY";
            lblStartY.Size = new Size(37, 15);
            lblStartY.TabIndex = 15;
            lblStartY.Text = "End Y";
            // 
            // lblEndX
            // 
            lblEndX.AutoSize = true;
            lblEndX.Location = new Point(117, 37);
            lblEndX.Name = "lblEndX";
            lblEndX.Size = new Size(37, 15);
            lblEndX.TabIndex = 14;
            lblEndX.Text = "End X";
            // 
            // lblStartX
            // 
            lblStartX.AutoSize = true;
            lblStartX.Location = new Point(17, 37);
            lblStartX.Name = "lblStartX";
            lblStartX.Size = new Size(41, 15);
            lblStartX.TabIndex = 13;
            lblStartX.Text = "Start X";
            // 
            // lblHorizontalX
            // 
            lblHorizontalX.AutoSize = true;
            lblHorizontalX.Location = new Point(17, 19);
            lblHorizontalX.Name = "lblHorizontalX";
            lblHorizontalX.Size = new Size(72, 15);
            lblHorizontalX.TabIndex = 13;
            lblHorizontalX.Text = "Horizontal X";
            // 
            // txtInitialY
            // 
            txtInitialY.Location = new Point(17, 113);
            txtInitialY.Name = "txtInitialY";
            txtInitialY.Size = new Size(81, 23);
            txtInitialY.TabIndex = 2;
            // 
            // txtFinalY
            // 
            txtFinalY.Location = new Point(117, 113);
            txtFinalY.Name = "txtFinalY";
            txtFinalY.Size = new Size(84, 23);
            txtFinalY.TabIndex = 3;
            // 
            // txtInitialX
            // 
            txtInitialX.Location = new Point(17, 54);
            txtInitialX.Name = "txtInitialX";
            txtInitialX.Size = new Size(81, 23);
            txtInitialX.TabIndex = 0;
            // 
            // txtFinalX
            // 
            txtFinalX.Location = new Point(117, 54);
            txtFinalX.Name = "txtFinalX";
            txtFinalX.Size = new Size(84, 23);
            txtFinalX.TabIndex = 1;
            // 
            // btnProcess
            // 
            btnProcess.Location = new Point(886, 657);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(128, 23);
            btnProcess.TabIndex = 9;
            btnProcess.Text = "Process Changes";
            btnProcess.UseVisualStyleBackColor = true;
            btnProcess.Click += btnProcess_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkOriginalAudio);
            groupBox1.Location = new Point(18, 454);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(164, 67);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Audio Config";
            // 
            // chkOriginalAudio
            // 
            chkOriginalAudio.AutoSize = true;
            chkOriginalAudio.Checked = true;
            chkOriginalAudio.CheckState = CheckState.Checked;
            chkOriginalAudio.Location = new Point(6, 31);
            chkOriginalAudio.Name = "chkOriginalAudio";
            chkOriginalAudio.Size = new Size(132, 19);
            chkOriginalAudio.TabIndex = 9;
            chkOriginalAudio.Text = "Keep Original Audio";
            chkOriginalAudio.UseVisualStyleBackColor = true;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(312, 155);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(584, 456);
            axWindowsMediaPlayer1.TabIndex = 11;
            // 
            // lblTotalMsec
            // 
            lblTotalMsec.AutoSize = true;
            lblTotalMsec.Location = new Point(9, 29);
            lblTotalMsec.Name = "lblTotalMsec";
            lblTotalMsec.Size = new Size(110, 15);
            lblTotalMsec.TabIndex = 12;
            lblTotalMsec.Text = "Total Milliseconds:  ";
            // 
            // gpbVideoInfo
            // 
            gpbVideoInfo.Controls.Add(lblTotalMillisec);
            gpbVideoInfo.Controls.Add(lblTotalMsec);
            gpbVideoInfo.Location = new Point(20, 538);
            gpbVideoInfo.Name = "gpbVideoInfo";
            gpbVideoInfo.Size = new Size(264, 124);
            gpbVideoInfo.TabIndex = 13;
            gpbVideoInfo.TabStop = false;
            gpbVideoInfo.Text = "Video Info";
            // 
            // lblTotalMillisec
            // 
            lblTotalMillisec.AutoSize = true;
            lblTotalMillisec.Location = new Point(109, 29);
            lblTotalMillisec.Name = "lblTotalMillisec";
            lblTotalMillisec.Size = new Size(35, 15);
            lblTotalMillisec.TabIndex = 13;
            lblTotalMillisec.Text = "msec";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 692);
            Controls.Add(gpbVideoInfo);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(groupBox1);
            Controls.Add(btnProcess);
            Controls.Add(gbxCutScreen);
            Controls.Add(gbxAngle);
            Controls.Add(gbxMirror);
            Controls.Add(gbxCutTime);
            Controls.Add(gbxPath);
            Name = "Form1";
            Text = "Main Editor";
            gbxPath.ResumeLayout(false);
            gbxPath.PerformLayout();
            gbxCutTime.ResumeLayout(false);
            gbxCutTime.PerformLayout();
            gbxMirror.ResumeLayout(false);
            gbxMirror.PerformLayout();
            gbxAngle.ResumeLayout(false);
            gbxAngle.PerformLayout();
            gbxCutScreen.ResumeLayout(false);
            gbxCutScreen.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            gpbVideoInfo.ResumeLayout(false);
            gpbVideoInfo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtInput;
        private TextBox txtOutput;
        private TextBox txtStartMinutes;
        private GroupBox gbxPath;
        private GroupBox gbxCutTime;
        private GroupBox gbxMirror;
        private CheckBox chkMirrorV;
        private CheckBox chkMirrorH;
        private GroupBox gbxAngle;
        private TextBox txtAngle;
        private GroupBox gbxCutScreen;
        private TextBox txtInitialY;
        private TextBox txtFinalY;
        private TextBox txtInitialX;
        private TextBox txtFinalX;
        private TextBox txtSufix;
        private Button btnProcess;
        private Label label1;
        private Label lblDestination;
        private Label lblSource;
        private Label lblStartTime;
        private Label lblEndTime;
        private HScrollBar hScrollBarAngle;
        private Label lblAngle;
        private GroupBox groupBox1;
        private CheckBox chkOriginalAudio;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Button btnPathDestination;
        private Button btnPathSource;
        private Label lblHorizontalX;
        private Label lblStartX;
        private Label lblEndY;
        private Label lblStartY;
        private Label lblEndX;
        private Label label2;
        private VScrollBar vScrollBarStartMin;
        private VScrollBar vScrollBarEndSec;
        private TextBox txtEndSeconds;
        private VScrollBar vScrollBarEndMin;
        private TextBox txtEndMinutes;
        private VScrollBar vScrollBarStartSec;
        private TextBox txtStartSeconds;
        private Label lblEndSeconds;
        private Label lblEndMinutes;
        private Label lblStartSeconds;
        private Label lblStartMinutes;
        private Label lblTotalMsec;
        private GroupBox gpbVideoInfo;
        private Label lblTotalMillisec;
    }
}
