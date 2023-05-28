using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static DBP_오전반_7조_김동희_나이키슈즈_관리시스템_장동휘__안기백__이선우_.Num;

namespace DBP_오전반_7조_김동희_나이키슈즈_관리시스템_장동휘__안기백__이선우_
{
    public partial class EMPLOYEE2 : Form
    {
        DBClass dbc = new DBClass(); //*****DBClass 객체
        public EMPLOYEE2()
        {
            InitializeComponent();
            dbc.DB_ObjCreate(); //*****
            dbc.DB_Open();//*****
        }

        private void button1_Click(object sender, EventArgs e)
        {
             try
             {
                 MessageBox.Show("텍스트 상자에 모든 데이터 입력하셨으면 추가합니다!");
                 // DS.Clear();//*

                 //  DBAdapter.Fill(DS, "EMPLOYEE");//*

                 dbc.ProductTable = dbc.DS.Tables["employee"];//*
                 DataRow newRow = dbc.ProductTable.NewRow();
                 newRow["e_name"] = textBox1.Text;
                newRow["e_hiredate"] = textBox9.Text + "년" + textBox14.Text + "월" + textBox15.Text + "일";
                newRow["e_pay"] = textBox3.Text;
                newRow["e_judge"] = textBox4.Text;
                newRow["e_id"] = textBox8.Text;
                newRow["Birthday"] = textBox2.Text;
                newRow["e_id"] = textBox8.Text;

                dbc.ProductTable.Rows.Add(newRow);
                 dbc.DBAdapter.Update(dbc.DS, "product");
                 dbc.DS.AcceptChanges();//*
                 //ClearTextBoxes();  //*
                 DBGrid.DataSource = dbc.DS.Tables["product"].DefaultView;    // E_info NIKE 쪽으로 이동해야하는데 그 부분 추가적 수정해야함
            }
             catch (DataException DE)
             {
                 MessageBox.Show(DE.Message);
             }
             catch (Exception DE)
             {
                 MessageBox.Show(DE.Message);
             } 


            // 위에껄로 수정해야함

           /* DateTime dt = DateTime.Now;
            int i = Int32.Parse(textBox9.Text);
            num[a] = new Personal();
            i = dt.Year - i;
            num[a].E_NAME = textBox1.Text;
            num[a].Year = i.ToString();
            num[a].E_HIREDATE = textBox9.Text + "년" + textBox14.Text + "월" + textBox15.Text + "일";
            num[a].Birthday = textBox2.Text;
            num[a].E_PAY = textBox3.Text;
            num[a].E_JUDGE = textBox4.Text;
            num[a].Charge = textBox16.Text;
            num[a].Contact = textBox5.Text + "-" + textBox11.Text + "-" + textBox12.Text;
            num[a].Address = textBox7.Text;
            num[a].Education = textBox17.Text;
            num[a].Qualification = textBox18.Text;
            num[a].E_ID = textBox8.Text;
            a++;
            this.Close();
            EMPLOYEE1 employee = new EMPLOYEE1();
            employee.Show();*/
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            EMPLOYEE1 employee = new EMPLOYEE1();
            employee.Show();
        }
    }
}
