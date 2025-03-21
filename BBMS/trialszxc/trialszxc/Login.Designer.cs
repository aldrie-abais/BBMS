namespace trialszxc
{
    partial class Login
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
            loginSidePanel = new Panel();
            pictureBox1 = new PictureBox();
            loginButton = new Krypton.Toolkit.KryptonButton();
            passwordTextBox = new Krypton.Toolkit.KryptonTextBox();
            usernameTextBox = new Krypton.Toolkit.KryptonTextBox();
            logInLabel = new Label();
            upperPanel = new Panel();
            backgroundIMGPanel = new Panel();
            upperRightPanel = new Panel();
            minimizeButton = new Button();
            closeButton = new Button();
            loginSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            backgroundIMGPanel.SuspendLayout();
            upperRightPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginSidePanel
            // 
            loginSidePanel.BackColor = Color.White;
            loginSidePanel.Controls.Add(pictureBox1);
            loginSidePanel.Controls.Add(loginButton);
            loginSidePanel.Controls.Add(passwordTextBox);
            loginSidePanel.Controls.Add(usernameTextBox);
            loginSidePanel.Controls.Add(logInLabel);
            loginSidePanel.Controls.Add(upperPanel);
            loginSidePanel.Dock = DockStyle.Left;
            loginSidePanel.Location = new Point(0, 0);
            loginSidePanel.Name = "loginSidePanel";
            loginSidePanel.Size = new Size(401, 861);
            loginSidePanel.TabIndex = 60;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ucmedLogo;
            pictureBox1.Location = new Point(112, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 31;
            pictureBox1.TabStop = false;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(152, 648);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(90, 25);
            loginButton.TabIndex = 3;
            loginButton.Values.DropDownArrowColor = Color.Empty;
            loginButton.Values.Text = "login";
            // 
            // passwordTextBox
            // 
            passwordTextBox.AlwaysActive = false;
            passwordTextBox.Location = new Point(66, 337);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '●';
            passwordTextBox.Size = new Size(271, 46);
            passwordTextBox.StateActive.Border.Color1 = SystemColors.ControlLight;
            passwordTextBox.StateActive.Border.Color2 = SystemColors.ControlLight;
            passwordTextBox.StateActive.Border.Rounding = 5F;
            passwordTextBox.StateActive.Border.Width = 1;
            passwordTextBox.StateCommon.Back.Color1 = SystemColors.ControlLight;
            passwordTextBox.StateCommon.Border.Color1 = SystemColors.ControlLight;
            passwordTextBox.StateCommon.Border.Color2 = SystemColors.ControlLight;
            passwordTextBox.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            passwordTextBox.StateCommon.Border.Rounding = 5F;
            passwordTextBox.StateCommon.Border.Width = 1;
            passwordTextBox.StateCommon.Content.Color1 = Color.FromArgb(130, 130, 130);
            passwordTextBox.StateCommon.Content.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordTextBox.StateCommon.Content.Padding = new Padding(10);
            passwordTextBox.TabIndex = 2;
            passwordTextBox.Text = "PASSWORD";
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // usernameTextBox
            // 
            usernameTextBox.AlwaysActive = false;
            usernameTextBox.Location = new Point(66, 271);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(271, 46);
            usernameTextBox.StateActive.Border.Color1 = SystemColors.ControlLight;
            usernameTextBox.StateActive.Border.Color2 = SystemColors.ControlLight;
            usernameTextBox.StateActive.Border.Rounding = 5F;
            usernameTextBox.StateActive.Border.Width = 1;
            usernameTextBox.StateCommon.Back.Color1 = SystemColors.ControlLight;
            usernameTextBox.StateCommon.Border.Color1 = SystemColors.ControlLight;
            usernameTextBox.StateCommon.Border.Color2 = SystemColors.ControlLight;
            usernameTextBox.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            usernameTextBox.StateCommon.Border.Rounding = 5F;
            usernameTextBox.StateCommon.Border.Width = 1;
            usernameTextBox.StateCommon.Content.Color1 = Color.FromArgb(130, 130, 130);
            usernameTextBox.StateCommon.Content.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameTextBox.StateCommon.Content.Padding = new Padding(10);
            usernameTextBox.TabIndex = 1;
            usernameTextBox.Text = "USERNAME";
            // 
            // logInLabel
            // 
            logInLabel.AutoSize = true;
            logInLabel.Font = new Font("Yu Gothic UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logInLabel.Location = new Point(152, 196);
            logInLabel.Name = "logInLabel";
            logInLabel.Size = new Size(90, 40);
            logInLabel.TabIndex = 13;
            logInLabel.Text = "Login";
            // 
            // upperPanel
            // 
            upperPanel.BackColor = Color.Transparent;
            upperPanel.Location = new Point(0, 0);
            upperPanel.Name = "upperPanel";
            upperPanel.Size = new Size(504, 24);
            upperPanel.TabIndex = 30;
            upperPanel.MouseDown += upperPanel_MouseDown;
            upperPanel.MouseMove += upperPanel_MouseMove;
            // 
            // backgroundIMGPanel
            // 
            backgroundIMGPanel.BackColor = Color.White;
            backgroundIMGPanel.BackgroundImage = Properties.Resources.ucmedbldg;
            backgroundIMGPanel.BackgroundImageLayout = ImageLayout.Stretch;
            backgroundIMGPanel.Controls.Add(upperRightPanel);
            backgroundIMGPanel.Dock = DockStyle.Fill;
            backgroundIMGPanel.Location = new Point(401, 0);
            backgroundIMGPanel.Name = "backgroundIMGPanel";
            backgroundIMGPanel.Size = new Size(1131, 861);
            backgroundIMGPanel.TabIndex = 50;
            // 
            // upperRightPanel
            // 
            upperRightPanel.BackColor = Color.Transparent;
            upperRightPanel.Controls.Add(minimizeButton);
            upperRightPanel.Controls.Add(closeButton);
            upperRightPanel.Dock = DockStyle.Top;
            upperRightPanel.Location = new Point(0, 0);
            upperRightPanel.Name = "upperRightPanel";
            upperRightPanel.Size = new Size(1131, 24);
            upperRightPanel.TabIndex = 31;
            upperRightPanel.MouseDown += upperRightPanel_MouseDown;
            upperRightPanel.MouseMove += upperRightPanel_MouseMove;
            // 
            // minimizeButton
            // 
            minimizeButton.BackColor = Color.Transparent;
            minimizeButton.BackgroundImageLayout = ImageLayout.Zoom;
            minimizeButton.Cursor = Cursors.Hand;
            minimizeButton.FlatAppearance.BorderColor = Color.White;
            minimizeButton.FlatAppearance.BorderSize = 0;
            minimizeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(182, 182, 182);
            minimizeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(182, 182, 182);
            minimizeButton.FlatStyle = FlatStyle.Flat;
            minimizeButton.Image = Properties.Resources.minimizeButton_Default;
            minimizeButton.Location = new Point(1061, 0);
            minimizeButton.Margin = new Padding(3, 3, 3, 0);
            minimizeButton.Name = "minimizeButton";
            minimizeButton.Padding = new Padding(3);
            minimizeButton.Size = new Size(36, 24);
            minimizeButton.TabIndex = 15;
            minimizeButton.UseVisualStyleBackColor = false;
            minimizeButton.Click += minimizeButton_Click;
            minimizeButton.MouseEnter += minimizeButton_MouseEnter;
            minimizeButton.MouseLeave += minimizeButton_MouseLeave;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.Transparent;
            closeButton.BackgroundImageLayout = ImageLayout.Zoom;
            closeButton.Cursor = Cursors.Hand;
            closeButton.FlatAppearance.BorderColor = Color.White;
            closeButton.FlatAppearance.BorderSize = 0;
            closeButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            closeButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            closeButton.FlatStyle = FlatStyle.Flat;
            closeButton.Image = Properties.Resources.closeButton_Default;
            closeButton.Location = new Point(1094, 0);
            closeButton.Margin = new Padding(3, 3, 3, 0);
            closeButton.Name = "closeButton";
            closeButton.Padding = new Padding(3);
            closeButton.Size = new Size(36, 24);
            closeButton.TabIndex = 20;
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            closeButton.MouseEnter += closeButton_MouseEnter;
            closeButton.MouseLeave += closeButton_MouseLeave;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1532, 861);
            Controls.Add(backgroundIMGPanel);
            Controls.Add(loginSidePanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            loginSidePanel.ResumeLayout(false);
            loginSidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            backgroundIMGPanel.ResumeLayout(false);
            upperRightPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel loginSidePanel;
        private Panel backgroundIMGPanel;
        private Panel upperPanel;
        private Panel upperRightPanel;
        private Button closeButton;
        private Button minimizeButton;
        private Label logInLabel;
        private Krypton.Toolkit.KryptonTextBox usernameTextBox;
        private Krypton.Toolkit.KryptonTextBox passwordTextBox;
        private Krypton.Toolkit.KryptonButton loginButton;
        private PictureBox pictureBox1;
    }
}
