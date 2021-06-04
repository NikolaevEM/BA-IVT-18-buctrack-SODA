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
    public partial class OrderBugfixerEmployeeForm : Form
    {
        int a, b;
        public static Context MainContext { get; set; }
        public OrderBugfixerEmployeeForm()
        {
            InitializeComponent();
            MainContext = new Context();
        }

        private void OrderBugfixerEmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            a = Convert.ToInt32(comboBox1.SelectedValue);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            b = Convert.ToInt32(comboBox2.SelectedValue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Context c = new Context();
            Bug bug = new Bug();
            Employee emp = new Employee();
            bug.BugId = b;
            emp.EmployeeId = a;
            bug.EmployeeId = emp.EmployeeId;
            MessageBox.Show("Сделано");
        }
    }
}
