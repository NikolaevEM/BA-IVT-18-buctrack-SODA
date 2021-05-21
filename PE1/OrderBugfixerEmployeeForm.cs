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
        public static Context MainContext { get; set; }
        public OrderBugfixerEmployeeForm()
        {
            InitializeComponent();
            MainContext = new Context();
        }

        private void OrderBugfixerEmployeeForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MainContext.PositionEmployees.ToList();
        }
    }
}
