using Sunny.UI;
namespace NeteaseCloudMusic
{
    public partial class LoginForm : UIForm
    {
        private UITextBox accText;
        private UITextBox pwdText;
        private UILabel accLab;
        private UIButton Login;
        private UILabel pwdLab;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.accText = new Sunny.UI.UITextBox();
            this.pwdText = new Sunny.UI.UITextBox();
            this.accLab = new Sunny.UI.UILabel();
            this.pwdLab = new Sunny.UI.UILabel();
            this.Login = new Sunny.UI.UIButton();
            this.SuspendLayout();
            // 
            // accText
            // 
            this.accText.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accText.Location = new System.Drawing.Point(132, 97);
            this.accText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.accText.MinimumSize = new System.Drawing.Size(1, 16);
            this.accText.Name = "accText";
            this.accText.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.accText.ShowText = false;
            this.accText.Size = new System.Drawing.Size(150, 29);
            this.accText.Style = Sunny.UI.UIStyle.Custom;
            this.accText.TabIndex = 0;
            this.accText.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.accText.Watermark = "";
            this.accText.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.accText.TextChanged += new System.EventHandler(this.uiTextBox1_TextChanged);
            // 
            // pwdText
            // 
            this.pwdText.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pwdText.Location = new System.Drawing.Point(132, 152);
            this.pwdText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pwdText.MinimumSize = new System.Drawing.Size(1, 16);
            this.pwdText.Name = "pwdText";
            this.pwdText.ShowText = false;
            this.pwdText.Size = new System.Drawing.Size(150, 29);
            this.pwdText.Style = Sunny.UI.UIStyle.Custom;
            this.pwdText.TabIndex = 1;
            this.pwdText.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.pwdText.Watermark = "";
            this.pwdText.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.pwdText.TextChanged += new System.EventHandler(this.uiTextBox2_TextChanged);
            // 
            // accLab
            // 
            this.accLab.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accLab.Location = new System.Drawing.Point(25, 103);
            this.accLab.Name = "accLab";
            this.accLab.Size = new System.Drawing.Size(100, 23);
            this.accLab.Style = Sunny.UI.UIStyle.Custom;
            this.accLab.TabIndex = 2;
            this.accLab.Text = "ÕË»§£º";
            this.accLab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accLab.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // pwdLab
            // 
            this.pwdLab.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pwdLab.Location = new System.Drawing.Point(25, 158);
            this.pwdLab.Name = "pwdLab";
            this.pwdLab.Size = new System.Drawing.Size(100, 23);
            this.pwdLab.Style = Sunny.UI.UIStyle.Custom;
            this.pwdLab.TabIndex = 3;
            this.pwdLab.Text = "ÃÜÂë£º";
            this.pwdLab.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pwdLab.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Î¢ÈíÑÅºÚ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Login.Location = new System.Drawing.Point(132, 241);
            this.Login.MinimumSize = new System.Drawing.Size(1, 1);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(100, 35);
            this.Login.Style = Sunny.UI.UIStyle.Custom;
            this.Login.TabIndex = 4;
            this.Login.Text = "µÇÂ¼";
            this.Login.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(460, 319);
            this.ControlBoxFillHoverColor = System.Drawing.Color.Black;
            this.Controls.Add(this.Login);
            this.Controls.Add(this.pwdLab);
            this.Controls.Add(this.accLab);
            this.Controls.Add(this.pwdText);
            this.Controls.Add(this.accText);
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(2, 36, 2, 2);
            this.RectColor = System.Drawing.SystemColors.ActiveBorder;
            this.ShowDragStretch = true;
            this.ShowRadius = false;
            this.Style = Sunny.UI.UIStyle.Custom;
            this.Text = "NCMusic";
            this.TitleColor = System.Drawing.Color.DodgerBlue;
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 480);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void uiTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            if (accLab.Text == "123" && pwdLab.Text == "123")
            {

            }else
            {
                
            }
        }
    }
}