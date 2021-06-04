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
    public partial class RestoreFixForm : Form
    {
        int selected;
        public static Bug Bug { get; set; }
        public RestoreFixForm()
        {
            InitializeComponent();
        }

        private void RestoreFixForm_Load(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Restore(selected);
            Context c = new Context();
            Fix f = new Fix();
            f.BugId = Bug.BugId;
            Bug.StatusBugId = 1;
            MessageBox.Show("Restored!");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = Convert.ToInt32(comboBox1.SelectedValue);
        }

        public void Restore(int selected)
        {

        }
    }
}
