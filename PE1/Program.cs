using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using System.Windows.Forms;

namespace PE1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormLogin());
            //Application.Run(new BugForm());
            //Application.Run(new Form2());
            //Application.Run(new Form3());
            //Application.Run(new Form4());
            //Application.Run(new BugForm()); //выбрать из списка багов
            //Application.Run(new ChooseFixForm());
            //Application.Run(new AcceptFixForm()); //подтверждение исправления бага //ПРИНЯТЬ РЕШЕНИЕ + ОТКЛОНИТЬ РЕШЕНИЕ
            Application.Run(new RestoreFixForm()); //восстановить решение
            //Application.Run(new OrderBugfixerGroupEmployeeForm());
            //Application.Run(new OrderBugfixerEmployeeForm());
        }
    }
}
