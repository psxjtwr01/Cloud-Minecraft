namespace WinFormsApp2
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
            CloseLabel = new Label();
            labelversion = new Label();
            streamproof = new CheckBox();
            WinRename = new CheckBox();
            gamerMode = new CheckBox();
            SuspendLayout();
            // 
            // CloseLabel
            // 
            CloseLabel.AutoSize = true;
            CloseLabel.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CloseLabel.Location = new Point(439, 9);
            CloseLabel.Name = "CloseLabel";
            CloseLabel.Size = new Size(20, 21);
            CloseLabel.TabIndex = 3;
            CloseLabel.Text = "X";
            CloseLabel.Click += label2_Click;
            // 
            // labelversion
            // 
            labelversion.AutoSize = true;
            labelversion.Location = new Point(12, 14);
            labelversion.Name = "labelversion";
            labelversion.Size = new Size(45, 15);
            labelversion.TabIndex = 4;
            labelversion.Text = "version";
            labelversion.Click += labelversion_Click;
            // 
            // streamproof
            // 
            streamproof.AutoSize = true;
            streamproof.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            streamproof.Location = new Point(29, 70);
            streamproof.Name = "streamproof";
            streamproof.Size = new Size(198, 24);
            streamproof.TabIndex = 5;
            streamproof.Text = "Stream Proofer (only obs)";
            streamproof.UseVisualStyleBackColor = true;
            streamproof.CheckedChanged += streamproof_CheckedChanged;
            // 
            // WinRename
            // 
            WinRename.AutoSize = true;
            WinRename.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            WinRename.Location = new Point(250, 70);
            WinRename.Name = "WinRename";
            WinRename.Size = new Size(141, 24);
            WinRename.TabIndex = 6;
            WinRename.Text = "Window Rename";
            WinRename.UseVisualStyleBackColor = true;
            WinRename.CheckedChanged += WinRename_CheckedChanged;
            // 
            // checkBox1
            // 
            gamerMode.AutoSize = true;
            gamerMode.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gamerMode.Location = new Point(29, 125);
            gamerMode.Name = "checkBox1";
            gamerMode.Size = new Size(115, 24);
            gamerMode.TabIndex = 7;
            gamerMode.Text = "Gamer Mode";
            gamerMode.UseVisualStyleBackColor = true;
            gamerMode.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 29, 38);
            ClientSize = new Size(471, 363);
            Controls.Add(gamerMode);
            Controls.Add(WinRename);
            Controls.Add(streamproof);
            Controls.Add(labelversion);
            Controls.Add(CloseLabel);
            Cursor = Cursors.Cross;
            ForeColor = Color.FromArgb(172, 172, 173);
            FormBorderStyle = FormBorderStyle.None;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            ShowInTaskbar = false;
            TopMost = true;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label CloseLabel;
        private Label labelversion;
        private CheckBox streamproof;
        private CheckBox WinRename;
        private CheckBox gamerMode;
    }
}
