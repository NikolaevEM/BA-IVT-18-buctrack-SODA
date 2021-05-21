using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE1
{
    public partial class FixBugForm : Form
    {
        public static Context MainContext { get; set; }
        public FixBugForm()
        {
            InitializeComponent();
            MainContext = new Context();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FixBugForm_Load(object sender, EventArgs e)
        {
            //DataTable table = new DataTable();

            //table.Columns.Add("id", typeof(int));
            //table.Columns.Add("BugType", typeof(BugType));
            //table.Columns.Add("Description", typeof(string));
            //table.Columns.Add("LastFixedDate", typeof(DateTime));
            //table.Columns.Add("AddedDate", typeof(DateTime));
            //table.Columns.Add("Status", typeof(StatusBug));


            //table.Rows.Add(1);
            //table.Rows.Add(2);
            //table.Rows.Add(3);
            //table.Rows.Add(4);
            //table.Rows.Add(5);
            //table.Rows.Add(6);
            //table.Rows.Add(7);
            //table.Rows.Add(8);

            //dataGridView1.DataSource = ;
            dataGridView1.DataSource = MainContext.Bugs.ToList();
        }

        private void FixBugForm_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
