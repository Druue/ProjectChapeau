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
    public partial class EmployeeOverview : Form
    {
        public EmployeeOverview()
        {
            InitializeComponent();
        }

        private void EmployeeOverview_Load(object sender, EventArgs e)
        {
            ChapeauUI.Manager.showEmployees();

        }

        private void Employee_listview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
