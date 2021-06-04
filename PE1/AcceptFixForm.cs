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
    public partial class AcceptFixForm : Form
    {
        public static Context MainContext { get; set; }
        public AcceptFixForm()
        {
            InitializeComponent();
            MainContext = new Context();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AcceptFixForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MainContext.Bugs.ToList();
        }

        private void button1_Click(object sender, EventArgs e)//ДА
        {
            Context c = new Context();
            c.SaveChanges();
            MessageBox.Show("Saved");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)//НЕТ
        {
            MessageBox.Show("Cancelled");
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
