namespace WinFormsApp2
{
    partial class keyauth
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
            KeyBox = new TextBox();
            login = new Button();
            KeyLabel = new Label();
            CloseLabel = new Label();
            StartClient = new Button();
            SuspendLayout();
            // 
            // KeyBox
            // 
            KeyBox.BackColor = Color.FromArgb(61, 84, 120);
            KeyBox.BorderStyle = BorderStyle.None;
            KeyBox.Location = new Point(151, 131);
            KeyBox.Name = "KeyBox";
            KeyBox.Size = new Size(200, 16);
            KeyBox.TabIndex = 0;
            KeyBox.TextChanged += textBox1_TextChanged;
            // 
            // login
            // 
            login.BackColor = Color.FromArgb(61, 84, 120);
            login.FlatStyle = FlatStyle.Flat;
            login.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login.ForeColor = Color.White;
            login.Location = new Point(46, 194);
            login.Name = "login";
            login.Size = new Size(169, 34);
            login.TabIndex = 1;
            login.Text = "Login";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // KeyLabel
            // 
            KeyLabel.AutoSize = true;
            KeyLabel.Location = new Point(116, 131);
            KeyLabel.Name = "KeyLabel";
            KeyLabel.Size = new Size(29, 15);
            KeyLabel.TabIndex = 2;
            KeyLabel.Text = "Key:";
            KeyLabel.Click += label1_Click;
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
            // StartClient
            // 
            StartClient.BackColor = Color.FromArgb(61, 84, 120);
            StartClient.FlatStyle = FlatStyle.Flat;
            StartClient.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartClient.ForeColor = Color.White;
            StartClient.Location = new Point(268, 194);
            StartClient.Name = "StartClient";
            StartClient.Size = new Size(169, 34);
            StartClient.TabIndex = 5;
            StartClient.Text = "Start Client";
            StartClient.UseVisualStyleBackColor = false;
            StartClient.Click += button2_Click;
            // 
            // keyauth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 29, 38);
            ClientSize = new Size(471, 363);
            Controls.Add(StartClient);
            Controls.Add(CloseLabel);
            Controls.Add(KeyLabel);
            Controls.Add(login);
            Controls.Add(KeyBox);
            Cursor = Cursors.Cross;
            ForeColor = Color.FromArgb(172, 172, 173);
            FormBorderStyle = FormBorderStyle.None;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "keyauth";
            ShowIcon = false;
            ShowInTaskbar = false;
            TopMost = true;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox KeyBox;
        private Button login;
        private Label KeyLabel;
        private Label CloseLabel;
        private Button StartClient;
    }
}
