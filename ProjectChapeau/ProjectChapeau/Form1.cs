using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectChapeau
{


    public partial class Form1 : Form
    {
        public int panelWidth = 1400; //please use these sizes for the form
        public int panelHeight = 600;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //filled in by Machelle
        {

            //this.Form1_Load.login_panel.clear();
            //this.login_panel = new Panel();
            //login_panel.Name = "loginPanel";
            login_panel.Size = new Size(panelWidth, panelHeight);
            login_panel.TabIndex = 0;
            login_panel.Location = new Point(0, 0);
            login_panel.BackColor = Color.Orange;


            //this allows the panel to get the size of the Form, even when resized by the user
            login_panel.Anchor = (((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left)
            | AnchorStyles.Right);
            login_panel.AutoSize = true;

            //adding the login_panel to the Controls in the Form
            Controls.Add(login_panel);


            //LOGIN TO BEGIN BUTTON 
            Button button_login_to_begin = new Button();
            int loginButtonWidth = 160;
            int loginButtonHeight = 30;

            button_login_to_begin.Text = "Log in to begin";
            button_login_to_begin.Width = loginButtonWidth;
            button_login_to_begin.Height = loginButtonHeight;
            button_login_to_begin.ForeColor = Color.White;
            button_login_to_begin.Font = new Font("Arial", 10, FontStyle.Bold);
            button_login_to_begin.FlatStyle = FlatStyle.Flat;
            button_login_to_begin.FlatAppearance.BorderColor = Color.White;
            button_login_to_begin.FlatAppearance.BorderSize = 1;

            button_login_to_begin.Click += new EventHandler(button_login_to_begin_Click);



            button_login_to_begin.Location = new Point((login_panel.Width / 2 - loginButtonWidth), login_panel.Height / 2);
            login_panel.Controls.Add(button_login_to_begin);


        }

        public void button_login_to_begin_Click(object sender, EventArgs e) //Made by Machelle
        {
            int loginButtonWidth = 160;
            int loginButtonHeight = 30;

            login_panel.Controls.Clear();

            login_panel.BackColor = Color.Beige;

            //this allows the panel to get the size of the Form, even when resized by the user
            login_panel.Anchor = (((AnchorStyles.Top | AnchorStyles.Bottom)
                    | AnchorStyles.Left)
            | AnchorStyles.Right);
            login_panel.AutoSize = true;

            //adding the login_panel to the Controls in the Form
            Controls.Add(login_panel);


            //-----------------------------------------------------------------------------------------GROUPBOX FOR LOGIN CONTROLS ---------------------------------------------------------------------------------------------------------------------

            GroupBox login_controls_grpbox = new GroupBox();
            login_controls_grpbox.Location = new System.Drawing.Point(100, 100);
            login_controls_grpbox.Size = new Size(login_panel.Width / 3, login_panel.Height / 3);

            login_controls_grpbox.AutoSize = true;
            login_panel.Controls.Add(login_controls_grpbox);


            //TEXTBOX FOR ENTERING USERNAME
            TextBox txtbox_username = new TextBox();
            txtbox_username.Name = "usernamebox";
            txtbox_username.Width = loginButtonWidth;
            txtbox_username.Height = loginButtonHeight;
            txtbox_username.ForeColor = Color.Black;
            txtbox_username.Font = new Font("Arial", 10, FontStyle.Bold);
            txtbox_username.Location = new Point((login_controls_grpbox.Width / 2 - loginButtonWidth), login_controls_grpbox.Height / 2);

            login_controls_grpbox.Controls.Add(txtbox_username);

            //TEXTBOX FOR ENTERING PASSWORD
            TextBox txtbox_password = new TextBox();
            txtbox_password.Name = "passwordbox";
            txtbox_password.Width = loginButtonWidth;
            txtbox_password.Height = loginButtonHeight;
            txtbox_password.ForeColor = Color.Black;
            txtbox_password.Font = new Font("Arial", 10, FontStyle.Bold);
            txtbox_password.Location = new Point((login_controls_grpbox.Width / 2 - loginButtonWidth), login_controls_grpbox.Height / 2 + txtbox_username.Height);

            login_controls_grpbox.Controls.Add(txtbox_password);


            string username = txtbox_username.Text;
            string password = txtbox_password.Text;

            //Login after filling in user information BUTTON 
            Button button_login = new Button();


            button_login.Text = "Log in";
            button_login.Width = loginButtonWidth;
            button_login.Height = loginButtonHeight;
            button_login.ForeColor = Color.White;
            button_login.Font = new Font("Arial", 10, FontStyle.Bold);
            button_login.FlatStyle = FlatStyle.Flat;
            button_login.FlatAppearance.BorderColor = Color.White;
            button_login.FlatAppearance.BorderSize = 1;

            button_login.Click += new EventHandler(button_login_Click);

            button_login.Location = new Point((login_controls_grpbox.Width / 2), login_controls_grpbox.Height / 2);
            login_controls_grpbox.Controls.Add(button_login);


            // --------------------------------------------------------------------------END OF GROUPBOX CONTROLS FOR LOGGING IN -----------------------------------------------------------------------------------------------------------------------------------
        }

        protected void button_login_Click(object sender, EventArgs e)
        {

        }
    }
}
