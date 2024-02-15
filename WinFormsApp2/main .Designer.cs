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
            components = new System.ComponentModel.Container();
            CloseLabel = new Label();
            labelversion = new Label();
            streamproof = new CheckBox();
            WinRename = new CheckBox();
            LClicker = new Label();
            CPSvalue = new Label();
            leftcps = new TrackBar();
            AutoClicker = new System.Windows.Forms.Timer(components);
            checkboxToggle = new CheckBox();
            Random = new System.Windows.Forms.Timer(components);
            randomTrack = new TrackBar();
            label1 = new Label();
            awot = new CheckBox();
            TABS = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)leftcps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)randomTrack).BeginInit();
            TABS.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
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
            labelversion.Location = new Point(6, 9);
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
            streamproof.Location = new Point(130, 39);
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
            WinRename.Location = new Point(130, 9);
            WinRename.Name = "WinRename";
            WinRename.Size = new Size(141, 24);
            WinRename.TabIndex = 6;
            WinRename.Text = "Window Rename";
            WinRename.UseVisualStyleBackColor = true;
            WinRename.CheckedChanged += WinRename_CheckedChanged;
            // 
            // LClicker
            // 
            LClicker.AutoSize = true;
            LClicker.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LClicker.Location = new Point(6, 3);
            LClicker.Name = "LClicker";
            LClicker.Size = new Size(87, 21);
            LClicker.TabIndex = 8;
            LClicker.Text = "Left Clicker";
            // 
            // CPSvalue
            // 
            CPSvalue.AutoSize = true;
            CPSvalue.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CPSvalue.Location = new Point(129, 27);
            CPSvalue.Name = "CPSvalue";
            CPSvalue.Size = new Size(25, 20);
            CPSvalue.TabIndex = 10;
            CPSvalue.Text = "10";
            CPSvalue.Click += CPSvalue_Click;
            // 
            // leftcps
            // 
            leftcps.Location = new Point(6, 27);
            leftcps.Maximum = 20;
            leftcps.Minimum = 6;
            leftcps.Name = "leftcps";
            leftcps.Size = new Size(104, 45);
            leftcps.TabIndex = 9;
            leftcps.TickStyle = TickStyle.None;
            leftcps.Value = 10;
            leftcps.Scroll += leftcps_Scroll;
            // 
            // AutoClicker
            // 
            AutoClicker.Tick += AutoClicker_Tick;
            // 
            // checkboxToggle
            // 
            checkboxToggle.AutoSize = true;
            checkboxToggle.Location = new Point(3, 78);
            checkboxToggle.Name = "checkboxToggle";
            checkboxToggle.Size = new Size(123, 19);
            checkboxToggle.TabIndex = 11;
            checkboxToggle.Text = "Left Clicker Toggle";
            checkboxToggle.UseVisualStyleBackColor = true;
            checkboxToggle.CheckedChanged += checkboxToggle_CheckedChanged;
            // 
            // Random
            // 
            Random.Interval = 150;
            Random.Tick += Random_Tick;
            // 
            // randomTrack
            // 
            randomTrack.Location = new Point(183, 306);
            randomTrack.Maximum = 30;
            randomTrack.Name = "randomTrack";
            randomTrack.Size = new Size(104, 45);
            randomTrack.TabIndex = 12;
            randomTrack.Value = 10;
            randomTrack.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 24);
            label1.Name = "label1";
            label1.Size = new Size(224, 21);
            label1.TabIndex = 13;
            label1.Text = "Right Clicker (COMING SOON)";
            label1.Click += label1_Click;
            // 
            // awot
            // 
            awot.AutoSize = true;
            awot.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            awot.Location = new Point(130, 69);
            awot.Name = "awot";
            awot.Size = new Size(126, 24);
            awot.TabIndex = 14;
            awot.Text = "Always On Top";
            awot.UseVisualStyleBackColor = true;
            awot.CheckedChanged += awot_CheckedChanged;
            // 
            // TABS
            // 
            TABS.Controls.Add(tabPage1);
            TABS.Controls.Add(tabPage2);
            TABS.Controls.Add(tabPage3);
            TABS.Location = new Point(2, 27);
            TABS.Name = "TABS";
            TABS.SelectedIndex = 0;
            TABS.Size = new Size(468, 324);
            TABS.SizeMode = TabSizeMode.Fixed;
            TABS.TabIndex = 15;
            TABS.SelectedIndexChanged += TABS_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(28, 29, 38);
            tabPage1.Controls.Add(LClicker);
            tabPage1.Controls.Add(leftcps);
            tabPage1.Controls.Add(checkboxToggle);
            tabPage1.Controls.Add(CPSvalue);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(460, 296);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Left Clicker";
            tabPage1.ToolTipText = "Left clicker options";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(28, 29, 38);
            tabPage2.Controls.Add(label1);
            tabPage2.ForeColor = Color.FromArgb(172, 172, 173);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(460, 296);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Right clicker";
            tabPage2.ToolTipText = "Right Clicker Options";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(28, 29, 38);
            tabPage3.Controls.Add(WinRename);
            tabPage3.Controls.Add(awot);
            tabPage3.Controls.Add(streamproof);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(460, 296);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Misc";
            tabPage3.ToolTipText = "The misc options of cloud";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 29, 38);
            ClientSize = new Size(471, 363);
            Controls.Add(TABS);
            Controls.Add(randomTrack);
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
            ((System.ComponentModel.ISupportInitialize)leftcps).EndInit();
            ((System.ComponentModel.ISupportInitialize)randomTrack).EndInit();
            TABS.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label CloseLabel;
        private Label labelversion;
        private CheckBox streamproof;
        private CheckBox WinRename;
        private Label LClicker;
        private Label CPSvalue;
        private TrackBar leftcps;
        private System.Windows.Forms.Timer AutoClicker;
        private CheckBox checkboxToggle;
        private System.Windows.Forms.Timer Random;
        private TrackBar randomTrack;
        private Label label1;
        private CheckBox awot;
        private TabControl TABS;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
    }
}
