using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyBank
{
    static class Calculate
    {
        static double Calc(int time, double percent, bool month)
        {
            double money = 1;
            if (month)
            {
                for (int i = 0; i < time; i++)
                {
                    money=money*percent*0.01;
                }
            }
            else
            {
                for(int i = 0; i < time; i+=12)
                {
                    money = money * percent * 0.01;
                }
            }
            return (money);
        }
    }
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
            Application.Run(new LoginForm());
        }
    }
}
