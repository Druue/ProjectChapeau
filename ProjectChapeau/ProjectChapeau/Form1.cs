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

        private void Form1_Load(object sender, EventArgs e)
        { }

        private void InitializeComponent()
        { 
            Panel login_panel = new Panel();
            login_panel.Name = "loginPanel";
            login_panel.Size = new Size(panelWidth, panelHeight);
            login_panel.TabIndex = 0;
            login_panel.Location = new System.Drawing.Point(0, 0);
            login_panel.BackColor = Color.Orange;
            //login_panel.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath
              //  (System.Environment.SpecialFolder.Personal) + @"\Image.gif");

            
            //this allows the panel to get the size of the Form, even when resized by the user
            login_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left)
            | AnchorStyles.Right)));
            login_panel.AutoSize = true;

            //adding the login_panel to the Controls in the Form
            login_panel.Controls.Clear();
            Controls.Add(login_panel);

            login_panel.Controls.Add(ChapeauUI.);


            //LOGIN BUTTON 
            Button button_login = new Button();
            int loginButtonWidth = 160;
            int loginButtonHeight = 30;

            button_login.Text = "Log in to begin";
            button_login.Width = loginButtonWidth;
            button_login.Height = loginButtonHeight;
            button_login.ForeColor = Color.White;
            button_login.Font = new Font("Arial", 10, FontStyle.Bold);
            button_login.FlatStyle = FlatStyle.Flat;
            button_login.FlatAppearance.BorderColor = Color.White;
            button_login.FlatAppearance.BorderSize = 1;

            button_login.Location = new Point((login_panel.Width / 2 - loginButtonWidth), login_panel.Height / 2);
            button_login.Click += new System.EventHandler(button_login_Click);            
            login_panel.Controls.Add(button_login);

        }
      

        void button_login_Click(object sender,EventArgs e)
        {
            Panel manager_panel = new Panel();
            manager_panel.Name = "managerPanel";
            manager_panel.Size = new Size(panelWidth, panelHeight);
            manager_panel.TabIndex = 0;
            manager_panel.Location = new System.Drawing.Point(0, 0);
            manager_panel.BackColor = Color.Orange;
            //login_panel.BackgroundImage = Image.FromFile(System.Environment.GetFolderPath
            //  (System.Environment.SpecialFolder.Personal) + @"\Image.gif");


            //this allows the panel to get the size of the Form, even when resized by the user
            manager_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left)
            | AnchorStyles.Right)));
            manager_panel.AutoSize = true;

            //adding the login_panel to the Controls in the Form
            Controls.Add(manager_panel);

            //button for overview menu
            Button button_menu = new Button();
            int menuButtonWidth = 160;
            int menuButtonHeight = 30;

            button_menu.Text = "Menu";
            button_menu.Width = menuButtonWidth;
            button_menu.Height = menuButtonHeight;
            button_menu.ForeColor = Color.White;
            button_menu.Font = new Font("Arial", 10, FontStyle.Bold);
            button_menu.FlatStyle = FlatStyle.Flat;
            button_menu.FlatAppearance.BorderColor = Color.White;
            button_menu.FlatAppearance.BorderSize = 1;

            button_menu.Location = new Point((manager_panel.Width / 5 - menuButtonWidth), manager_panel.Height / 3);
            manager_panel.Controls.Add(button_menu);
        }

        private void login_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
