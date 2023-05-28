using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBP_오전반_7조_김동희_나이키슈즈_관리시스템_장동휘__안기백__이선우_
{
    public partial class MAIN : Form
    {
        DBClass dbc = new DBClass(); //*****DBClass 객체
       // int a = 0;
        public MAIN()
        {
            InitializeComponent();
            dbc.DB_ObjCreate(); //*****
            dbc.DB_Open();//*****
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            EMPLOYEE1 employee = new EMPLOYEE1();
            employee.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            product_sales employee = new product_sales();
            employee.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            product_recall employee = new product_recall();
            employee.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            member employee = new member();
            employee.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            payment employee = new payment();
            employee.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            PRODUCT employee = new PRODUCT();
            employee.Show();
        }
    }
}
