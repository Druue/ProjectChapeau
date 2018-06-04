using System;
using System.Windows.Forms;

namespace ProjectChapeau
{
    public partial class Payment_Form : Form
    {
        public int panelWidth = 1400;
        public int panelHeight = 600;

        public Payment_Form()
        {
            InitializeComponent();
        }

        private void Payment_Form_Load(object sender, EventArgs e)
        {
            payMethod1.Appearance = Appearance.Button;
            payMethod2.Appearance = Appearance.Button;
            payMethod3.Appearance = Appearance.Button;
        }
    }
}
