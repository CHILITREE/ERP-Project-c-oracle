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
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types; //***

namespace DBP_오전반_7조_김동희_나이키슈즈_관리시스템_장동휘__안기백__이선우_
{
    public partial class EMPLOYEE1 : Form
    {
        DBClass dbc = new DBClass(); //*****DBClass 객체
        public EMPLOYEE1()
        {
            InitializeComponent();
            dbc.DB_ObjCreate(); //*****
            dbc.DB_Open();//*****
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MAIN main = new MAIN();
            main.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
             try
             {
                 // DS.Clear();
                 // DBAdapter.Fill(DS, "EMPLOYEE");


                 dbc.ProductTable = dbc.DS.Tables["product"];//*
                 DataColumn[] PrimaryKey = new DataColumn[1];
                 PrimaryKey[0] = dbc.ProductTable.Columns["e_id"];
                 dbc.ProductTable.PrimaryKey = PrimaryKey;

                 DataRow currRow = dbc.ProductTable.Rows.Find(dbc.SelectedRowIndex);
                 currRow.Delete();

                 dbc.DBAdapter.Update(dbc.DS.GetChanges(DataRowState.Deleted), "product");
                 DBGrid.DataSource = dbc.DS.Tables["product"].DefaultView;
             }
             catch (DataException DE)
             {
                 MessageBox.Show(DE.Message);
             }
             catch (Exception DE)
             {
                 MessageBox.Show(DE.Message);
             } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            EMPLOYEE2 employee_input = new EMPLOYEE2();
            employee_input.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
              string connectionString = "User Id=system; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe) ) );";
                 OracleConnection myConnection = new OracleConnection(connectionString);
                  string commandString = "select e_id, e_name, e_judge, e_pay, e_hiredate, e_firedate from employee"; //, 뭔지 확인해야함 Register R where P.ID=R.ID ";
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
                 item.SubItems.Add(MR[4].ToString());
                 item.SubItems.Add(MR[5].ToString());
            
                  E_INFO.Items.Add(item);
              }
                  MR.Close();
                  myConnection.Close(); 
        }
    }
}
