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
    public partial class SolutionForm : Form
    { 
        public static Bug Bug { get; set; }

        public SolutionForm()
        {
            InitializeComponent();
        }

        private void SolutionForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fix f = new Fix();
            Context c = new Context();
            AcceptFixForm acceptfixform = new AcceptFixForm();
            f.BugId = Bug.BugId;//Заполнить Базу ошибок
            //f.BugId = 1;
            f.Description = textBox1.Text;
            f.EmployeeId = 1;//change to current user
            f.Date = DateTime.Now;
            f.Rank = 1;
            c.Fixes.Add(f);
            c.SaveChanges();//как это работает и почему не робит? 
            acceptfixform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //return;
            this.Close();
        }
    }
}
