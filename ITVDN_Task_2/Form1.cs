using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITVDN_Task_2
{
    public partial class Form1 : Form
    {
        private readonly Model1Container db = new Model1Container();
        private readonly BindingList<MyRow> data;
        public Form1()
        {
            data = new BindingList<MyRow>();
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            db.MyTableSet.Add(new MyTable() { Text = richTextBox1.Text });
            db.SaveChanges();

            data.Clear();

            foreach (var item in db.MyTableSet)
            {
                data.Add(new MyRow(item.Id, item.Text));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(var item in db.MyTableSet)
            {
                data.Add(new MyRow(item.Id, item.Text));
            }

            dataGridView1.DataSource = data;

            dataGridView1.Columns[1].Width = 300;
        }
    }

    class MyRow
    {
        public MyRow(int id, string text)
        {
            Id = id;
            Text = text;
        }

        public Int32 Id { get; set; }
        public String Text { get; set; }


    }
}
