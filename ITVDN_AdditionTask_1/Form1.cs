using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITVDN_AdditionTask_1
{
    public partial class Form1 : Form
    {
        private readonly MyDatabaseEntities db = new MyDatabaseEntities();
        private readonly BindingList<MyRow> data;
        public Form1()
        {
            data = new BindingList<MyRow>();
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            db.MyTable.Add(new MyTable() { FName = textBox1.Text, LName = textBox2.Text });
            db.SaveChanges();

            data.Clear();

            foreach (var item in db.MyTable)
            {
                data.Add(new MyRow(item.Id, item.FName, item.LName));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var column_Id = new DataGridViewColumn();
            //column_Id.HeaderText = "ID";
            //column_Id.Width = 30;
            //column_Id.Frozen = true;
            //column_Id.ReadOnly = true;
            //column_Id.CellTemplate = new DataGridViewTextBoxCell();

            //var column_FName = new DataGridViewColumn();
            //column_FName.HeaderText = "First Name";
            //column_FName.Width = 200;
            //column_FName.Frozen = true;
            //column_FName.ReadOnly = true;
            //column_FName.CellTemplate = new DataGridViewTextBoxCell();

            //var column_LName = new DataGridViewColumn();
            //column_LName.HeaderText = "Last Name";
            //column_LName.Width = 200;
            //column_LName.Frozen = true;
            //column_LName.ReadOnly = true;
            //column_LName.CellTemplate = new DataGridViewTextBoxCell();

            //dataGridView1.Columns.Add(column_Id);
            //dataGridView1.Columns.Add(column_FName);
            //dataGridView1.Columns.Add(column_LName);

            foreach (var item in db.MyTable)//.Select((MyTable table) => new { Id = table.Id, FName = table.FName, LName = table.LName }))
            {
                data.Add(new MyRow(item.Id, item.FName, item.LName));
            }
            dataGridView1.DataSource = data;
        }
    }

    class MyRow
    {
        public MyRow(int iD, string fName, string lName)
        {
            ID = iD;
            FName = fName;
            LName = lName;
        }

        public Int32 ID { get; set; }
        public String FName { get; set; }
        public String LName { get; set; }
    }
}
