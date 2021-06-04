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
    public partial class OrderBugfixerGroupEmployeeForm : Form
    {
        int a,b;
        public static Context MainContext { get; set; }

        public OrderBugfixerGroupEmployeeForm()
        {
            InitializeComponent();
        }

        private void OrderBugfixerGroupEmployeeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {//Bug ID
            b = Convert.ToInt32(comboBox2.SelectedValue);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {//Employee ID
            a = Convert.ToInt32(comboBox1.SelectedValue);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Context c = new Context();
            Bug bug = new Bug();
            Employee emp = new Employee();
            //f.BugId = Bug.BugId;
            bug.BugId = b;
            emp.EmployeeId = a;
            bug.EmployeeId = emp.EmployeeId;
            MessageBox.Show("Сделано");
        }
    }
}
