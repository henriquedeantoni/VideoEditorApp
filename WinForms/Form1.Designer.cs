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
            txtInput = new TextBox();
            txtOutput = new TextBox();
            txtStart = new TextBox();
            txtEnd = new TextBox();
            gbxPath = new GroupBox();
            gbxCutTime = new GroupBox();
            gbxMirror = new GroupBox();
            chkMirrorH = new CheckBox();
            chkMirrorV = new CheckBox();
            gbxAngle = new GroupBox();
            txtAngle = new TextBox();
            gbxCutScreen = new GroupBox();
            txtInitialX = new TextBox();
            txtFinalX = new TextBox();
            txtInitialY = new TextBox();
            txtFinalY = new TextBox();
            gbxPath.SuspendLayout();
            gbxCutTime.SuspendLayout();
            gbxMirror.SuspendLayout();
            gbxAngle.SuspendLayout();
            gbxCutScreen.SuspendLayout();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(24, 36);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(100, 23);
            txtInput.TabIndex = 0;
            // 
            // txtOutput
            // 
            txtOutput.Location = new Point(152, 36);
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
            gbxPath.Controls.Add(txtInput);
            gbxPath.Controls.Add(txtOutput);
            gbxPath.Location = new Point(12, 12);
            gbxPath.Name = "gbxPath";
            gbxPath.Size = new Size(276, 100);
            gbxPath.TabIndex = 4;
            gbxPath.TabStop = false;
            gbxPath.Text = "Path";
            // 
            // gbxCutTime
            // 
            gbxCutTime.Controls.Add(txtStart);
            gbxCutTime.Controls.Add(txtEnd);
            gbxCutTime.Location = new Point(307, 12);
            gbxCutTime.Name = "gbxCutTime";
            gbxCutTime.Size = new Size(271, 100);
            gbxCutTime.TabIndex = 5;
            gbxCutTime.TabStop = false;
            gbxCutTime.Text = "Cut Time";
            // 
            // gbxMirror
            // 
            gbxMirror.Controls.Add(chkMirrorV);
            gbxMirror.Controls.Add(chkMirrorH);
            gbxMirror.Location = new Point(13, 136);
            gbxMirror.Name = "gbxMirror";
            gbxMirror.Size = new Size(200, 100);
            gbxMirror.TabIndex = 6;
            gbxMirror.TabStop = false;
            gbxMirror.Text = "Mirror";
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
            // gbxAngle
            // 
            gbxAngle.Controls.Add(txtAngle);
            gbxAngle.Location = new Point(250, 136);
            gbxAngle.Name = "gbxAngle";
            gbxAngle.Size = new Size(200, 100);
            gbxAngle.TabIndex = 7;
            gbxAngle.TabStop = false;
            gbxAngle.Text = "Angle Alignment";
            // 
            // txtAngle
            // 
            txtAngle.Location = new Point(21, 30);
            txtAngle.Name = "txtAngle";
            txtAngle.Size = new Size(100, 23);
            txtAngle.TabIndex = 0;
            // 
            // gbxCutScreen
            // 
            gbxCutScreen.Controls.Add(txtInitialY);
            gbxCutScreen.Controls.Add(txtFinalY);
            gbxCutScreen.Controls.Add(txtInitialX);
            gbxCutScreen.Controls.Add(txtFinalX);
            gbxCutScreen.Location = new Point(12, 251);
            gbxCutScreen.Name = "gbxCutScreen";
            gbxCutScreen.Size = new Size(276, 134);
            gbxCutScreen.TabIndex = 8;
            gbxCutScreen.TabStop = false;
            gbxCutScreen.Text = "Cut Screen ( X - Y)";
            // 
            // txtInitialX
            // 
            txtInitialX.Location = new Point(24, 36);
            txtInitialX.Name = "txtInitialX";
            txtInitialX.Size = new Size(100, 23);
            txtInitialX.TabIndex = 0;
            // 
            // txtFinalX
            // 
            txtFinalX.Location = new Point(152, 36);
            txtFinalX.Name = "txtFinalX";
            txtFinalX.Size = new Size(100, 23);
            txtFinalX.TabIndex = 1;
            // 
            // txtInitialY
            // 
            txtInitialY.Location = new Point(24, 86);
            txtInitialY.Name = "txtInitialY";
            txtInitialY.Size = new Size(100, 23);
            txtInitialY.TabIndex = 2;
            // 
            // txtFinalY
            // 
            txtFinalY.Location = new Point(152, 86);
            txtFinalY.Name = "txtFinalY";
            txtFinalY.Size = new Size(100, 23);
            txtFinalY.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 450);
            Controls.Add(gbxCutScreen);
            Controls.Add(gbxAngle);
            Controls.Add(gbxMirror);
            Controls.Add(gbxCutTime);
            Controls.Add(gbxPath);
            Name = "Form1";
            Text = "Form1";
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
            ResumeLayout(false);
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
    }
}
