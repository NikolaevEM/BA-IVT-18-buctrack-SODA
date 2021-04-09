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
    public partial class BugForm : Form
    {
        public BugForm()
        {
            InitializeComponent();
        }

        public Context context1 = new Context();

        private void BugForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context1.BugTypes.ToList();
        }
    }
}
