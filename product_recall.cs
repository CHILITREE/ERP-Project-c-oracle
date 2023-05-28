using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static DBP_오전반_7조_김동희_나이키슈즈_관리시스템_장동휘__안기백__이선우_.Num2;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types; //***

namespace DBP_오전반_7조_김동희_나이키슈즈_관리시스템_장동휘__안기백__이선우_
{
    public partial class product_recall : Form
    {
        DBClass dbc = new DBClass(); //*****DBClass 객체
        public product_recall()
        {
            InitializeComponent();
            dbc.DB_ObjCreate(); //*****
            dbc.DB_Open();//*****
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            MAIN main = new MAIN();
            main.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("텍스트 상자에 모든 데이터 입력하셨으면 추가합니다!");
                // DS.Clear();//*

                //  DBAdapter.Fill(DS, "EMPLOYEE");//*

                dbc.ProductTable = dbc.DS.Tables["PRODUCT_RACALL"];//*
                DataRow newRow = dbc.ProductTable.NewRow();
                newRow["s_number"] = textBox1.Text;
                newRow["r_reason"] = textBox4.Text;
                newRow["r_date"] = textBox2.Text;
                newRow["r_amount"] = textBox3.Text;

                dbc.ProductTable.Rows.Add(newRow);
                dbc.DBAdapter.Update(dbc.DS, "PRODUCT_RACALL");
                dbc.DS.AcceptChanges();//*
                                       //ClearTextBoxes();  //*
                DBGrid.DataSource = dbc.DS.Tables["PRODUCT_RACALL"].DefaultView;    // E_info NIKE 쪽으로 이동해야하는데 그 부분 추가적 수정해야함
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }

            /*num[a].S_NUMBER = textBox1.Text;
            num[a].R_REASON = textBox4.Text;
            num[a].R_DATE = textBox2.Text;
            num[a].R_AMOUNT = textBox3.Text;
            a++;
            this.Close();
            MAIN employee = new MAIN();
            employee.Show();*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
              string connectionString = "User Id=hong1; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
                OracleConnection myConnection = new OracleConnection(connectionString);
            string commandString = "select  s_number, r_reason, r_date, r_amount from PRODUCT_RACALL"; //, 뭔지 확인해야함 Register R where P.ID=R.ID";
            OracleCommand myCommand = new OracleCommand();
                myCommand.Connection = myConnection;
                myCommand.CommandText = commandString;
                myConnection.Open(); //
                OracleDataReader MR;
                 MR = myCommand.ExecuteReader();
                 while (MR.Read())
        {
              ListViewItem item = new ListViewItem(MR[0].ToString());
                item.SubItems.Add(MR[0].ToString());
                item.SubItems.Add(MR[1].ToString());
             item.SubItems.Add(MR[2].ToString());
             item.SubItems.Add(MR[3].ToString());
             listView1.Items.Add(item);
         }
              MR.Close();
              myConnection.Close();
        }
    }
}
