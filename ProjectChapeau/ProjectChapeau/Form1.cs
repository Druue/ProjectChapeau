﻿using System;
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
        {
            Panel login_panel = new Panel();
            login_panel.Name = "loginPanel";
            login_panel.Size = new Size(panelWidth, panelHeight);
            login_panel.TabIndex = 0;
            login_panel.Location = new System.Drawing.Point(0, 0);
            login_panel.BackColor = Color.Orange;

            //this allows the panel to get the size of the Form, even when resized by the user
            login_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((AnchorStyles.Top | AnchorStyles.Bottom)
            | AnchorStyles.Left)
            | AnchorStyles.Right)));
            login_panel.AutoSize = true;

            //adding the login_panel to the Controls in the Form
            Controls.Add(login_panel);


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
            login_panel.Controls.Add(button_login);


        }
    }
}
