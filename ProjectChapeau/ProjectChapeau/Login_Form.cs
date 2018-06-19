using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chapeau_Model;
using Chapeau_Logic;

namespace ProjectChapeau
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }


        private void btn_login_to_begin_Click(object sender, EventArgs e)
        {
            btn_login_to_begin.Visible = false;
            login_panel.Visible = true;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
              string username = txtbox_username.Text;
              string password = txtbox_password.Text;


            LoginLogic logic = new LoginLogic();

            ChapeauModel.Employee employee = logic.LoginCheck(username, password);

            if (employee == null)
            {
                MessageBox.Show("Please enter a valid username and/or password");
                txtbox_password.Text = string.Empty;
            }
            else
            {
                switch(employee.Role)
                {
                    case JobRole.Bar:

                        KitchenBarForm BarForm = new KitchenBarForm();
                        BarForm.Show();
                        break;

                    case JobRole.Kitchen:

                        KitchenBarForm kitchenForm = new KitchenBarForm();
                        kitchenForm.Show();
                        break;

                    case JobRole.Manager:

                        MessageBox.Show("Manager login successfull");
                        break;

                    case JobRole.Wait:

                        this.Hide();
                        RestaurantOverview_Form restaurantform = new RestaurantOverview_Form(employee);
                        restaurantform.Show();
                        break;
                } 
            }
        }
    }
}
