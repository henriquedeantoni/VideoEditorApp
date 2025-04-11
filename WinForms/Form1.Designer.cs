﻿namespace WinForms
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
            txtStart = new TextBox();
            txtEnd = new TextBox();
            gbxPath = new GroupBox();
            btnPathDestination = new Button();
            btnPathSource = new Button();
            label1 = new Label();
            lblDestination = new Label();
            lblSource = new Label();
            textBox1 = new TextBox();
            gbxCutTime = new GroupBox();
            lblEndTime = new Label();
            lblStartTime = new Label();
            gbxMirror = new GroupBox();
            chkMirrorV = new CheckBox();
            chkMirrorH = new CheckBox();
            gbxAngle = new GroupBox();
            hScrollBar1 = new HScrollBar();
            lblAngle = new Label();
            txtAngle = new TextBox();
            gbxCutScreen = new GroupBox();
            txtInitialY = new TextBox();
            txtFinalY = new TextBox();
            txtInitialX = new TextBox();
            txtFinalX = new TextBox();
            btnProcess = new Button();
            groupBox1 = new GroupBox();
            chkOriginalAudio = new CheckBox();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            label3 = new Label();
            lblHorizontalX = new Label();
            lblStartX = new Label();
            lblEndX = new Label();
            lblStartY = new Label();
            lblEndY = new Label();
            label2 = new Label();
            gbxPath.SuspendLayout();
            gbxCutTime.SuspendLayout();
            gbxMirror.SuspendLayout();
            gbxAngle.SuspendLayout();
            gbxCutScreen.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
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
            // txtStart
            // 
            txtStart.Location = new Point(15, 36);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(100, 23);
            txtStart.TabIndex = 2;
            // 
            // txtEnd
            // 
            txtEnd.Location = new Point(137, 36);
            txtEnd.Name = "txtEnd";
            txtEnd.Size = new Size(100, 23);
            txtEnd.TabIndex = 3;
            // 
            // gbxPath
            // 
            gbxPath.Controls.Add(btnPathDestination);
            gbxPath.Controls.Add(btnPathSource);
            gbxPath.Controls.Add(label1);
            gbxPath.Controls.Add(lblDestination);
            gbxPath.Controls.Add(lblSource);
            gbxPath.Controls.Add(textBox1);
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
            // 
            // btnPathSource
            // 
            btnPathSource.Location = new Point(116, 36);
            btnPathSource.Name = "btnPathSource";
            btnPathSource.Size = new Size(50, 23);
            btnPathSource.TabIndex = 13;
            btnPathSource.Text = "button1";
            btnPathSource.UseVisualStyleBackColor = true;
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
            lblSource.Click += lblSource_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(172, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // gbxCutTime
            // 
            gbxCutTime.Controls.Add(lblEndTime);
            gbxCutTime.Controls.Add(lblStartTime);
            gbxCutTime.Controls.Add(txtStart);
            gbxCutTime.Controls.Add(txtEnd);
            gbxCutTime.Location = new Point(389, 12);
            gbxCutTime.Name = "gbxCutTime";
            gbxCutTime.Size = new Size(271, 119);
            gbxCutTime.TabIndex = 5;
            gbxCutTime.TabStop = false;
            gbxCutTime.Text = "Cut Time";
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
            gbxAngle.Controls.Add(hScrollBar1);
            gbxAngle.Controls.Add(lblAngle);
            gbxAngle.Controls.Add(txtAngle);
            gbxAngle.Location = new Point(252, 145);
            gbxAngle.Name = "gbxAngle";
            gbxAngle.Size = new Size(170, 100);
            gbxAngle.TabIndex = 7;
            gbxAngle.TabStop = false;
            gbxAngle.Text = "Angle Alignment";
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(22, 66);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(124, 25);
            hScrollBar1.TabIndex = 10;
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
            btnProcess.Location = new Point(444, 415);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(128, 23);
            btnProcess.TabIndex = 9;
            btnProcess.Text = "Process Changes";
            btnProcess.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkOriginalAudio);
            groupBox1.Location = new Point(258, 266);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(164, 146);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Audio Config";
            // 
            // chkOriginalAudio
            // 
            chkOriginalAudio.AutoSize = true;
            chkOriginalAudio.Location = new Point(16, 33);
            chkOriginalAudio.Name = "chkOriginalAudio";
            chkOriginalAudio.Size = new Size(132, 19);
            chkOriginalAudio.TabIndex = 9;
            chkOriginalAudio.Text = "Keep Original Audio";
            chkOriginalAudio.UseVisualStyleBackColor = true;
            chkOriginalAudio.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(509, 162);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(210, 208);
            axWindowsMediaPlayer1.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(351, 218);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 12;
            label3.Text = "Source:";
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
            // lblStartX
            // 
            lblStartX.AutoSize = true;
            lblStartX.Location = new Point(17, 37);
            lblStartX.Name = "lblStartX";
            lblStartX.Size = new Size(41, 15);
            lblStartX.TabIndex = 13;
            lblStartX.Text = "Start X";
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
            // lblStartY
            // 
            lblStartY.AutoSize = true;
            lblStartY.Location = new Point(17, 95);
            lblStartY.Name = "lblStartY";
            lblStartY.Size = new Size(37, 15);
            lblStartY.TabIndex = 15;
            lblStartY.Text = "End Y";
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 80);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 14;
            label2.Text = "Vertical Y";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(749, 450);
            Controls.Add(label3);
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
            Load += Form1_Load;
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private TextBox txtOutput;
        private TextBox txtStart;
        private TextBox txtEnd;
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
        private TextBox textBox1;
        private Button btnProcess;
        private Label label1;
        private Label lblDestination;
        private Label lblSource;
        private Label lblStartTime;
        private Label lblEndTime;
        private HScrollBar hScrollBar1;
        private Label lblAngle;
        private GroupBox groupBox1;
        private CheckBox chkOriginalAudio;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Button btnPathDestination;
        private Button btnPathSource;
        private Label label3;
        private Label lblHorizontalX;
        private Label lblStartX;
        private Label lblEndY;
        private Label lblStartY;
        private Label lblEndX;
        private Label label2;
    }
}
