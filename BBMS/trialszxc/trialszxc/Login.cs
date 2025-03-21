using System.Runtime.InteropServices;
using Krypton.Toolkit;

namespace trialszxc
{
    public partial class Login : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect,
        int nRightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse

        );
        public Login()
        {
            InitializeComponent();
            this.Load += Login_Load;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void Login_Load(object? sender, EventArgs e)
        {
            // MessageBox.Show("Arise!");
            usernameTextBox.Enter += usernameTextBox_Enter;
            usernameTextBox.Leave += usernameTextBox_Leave;
            passwordTextBox.Enter += passwordTextBox_Enter;
            passwordTextBox.Leave += passwordTextBox_Leave;
        }

        // For movable form (Header was removed)
        Point lastPoint;
        private void upperPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void upperPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void upperRightPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void upperRightPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        // Customized System Controls/Buttons
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.Image = Properties.Resources.closeButton_White;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.Image = Properties.Resources.closeButton_Default;
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void minimizeButton_MouseEnter(object sender, EventArgs e)
        {
            minimizeButton.Image = Properties.Resources.minimizeButton_White;
        }

        private void minimizeButton_MouseLeave(object sender, EventArgs e)
        {
            minimizeButton.Image = Properties.Resources.minimizeButton_Default;
        }

        // Customized TextBox
        private void usernameTextBox_Enter(object? sender, EventArgs e)
        {
            usernameTextBox.StateActive.Border.Color1 = Color.Black;
            usernameTextBox.StateActive.Border.Color2 = Color.Black;
            usernameTextBox.StateActive.Border.Width = 1;

            if (usernameTextBox.Text == "USERNAME")
            {
                usernameTextBox.Text = "";
                usernameTextBox.StateActive.Content.Color1 = Color.Black;
                usernameTextBox.StateCommon.Content.Font = new Font("Yu Gothic", 9F, FontStyle.Regular);
                usernameTextBox.StateCommon.Back.Color1 = Color.White;
            }
        }

        private void usernameTextBox_Leave(object? sender, EventArgs e)
        {
            usernameTextBox.StateActive.Border.Color1 = Color.FromArgb(227,227,227);
            usernameTextBox.StateActive.Border.Color2 = Color.FromArgb(227, 227, 227);
            usernameTextBox.StateActive.Border.Width = 1;

            if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
            {
                usernameTextBox.Text = "USERNAME";
                usernameTextBox.StateCommon.Content.Font = new Font("Yu Gothic", 9F, FontStyle.Bold);
                usernameTextBox.StateActive.Content.Color1 = Color.FromArgb(130, 130, 130);
                usernameTextBox.StateCommon.Back.Color1 = Color.FromArgb(227, 227, 227);
            }

        }

        private void passwordTextBox_Enter(object? sender, EventArgs e)
        {
            passwordTextBox.StateActive.Border.Color1 = Color.Black;
            passwordTextBox.StateActive.Border.Color2 = Color.Black;
            passwordTextBox.StateActive.Border.Width = 1;

            if (passwordTextBox.Text == "PASSWORD")
            {
                passwordTextBox.Text = "";
                passwordTextBox.StateActive.Content.Color1 = Color.Black;
                passwordTextBox.StateCommon.Content.Font = new Font("Yu Gothic", 9F, FontStyle.Regular);
                passwordTextBox.StateCommon.Back.Color1 = Color.White;
            }
        }

        private void passwordTextBox_Leave(object? sender, EventArgs e)
        {
            passwordTextBox.StateActive.Border.Color1 = Color.FromArgb(227, 227, 227);
            passwordTextBox.StateActive.Border.Color2 = Color.FromArgb(227, 227, 227);
            passwordTextBox.StateActive.Border.Width = 1;

            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                passwordTextBox.Text = "PASSWORD";
                passwordTextBox.StateCommon.Content.Font = new Font("Yu Gothic", 9F, FontStyle.Bold);
                passwordTextBox.StateActive.Content.Color1 = Color.FromArgb(130, 130, 130);
                passwordTextBox.StateCommon.Back.Color1 = Color.FromArgb(227, 227, 227);
            }

        }
    }
}
