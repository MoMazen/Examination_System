using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_System
{

    internal static class Program
    {

        public static ITIDBProjectEntities dbEntity = new ITIDBProjectEntities();
        public static LoginProcedure_Result userData = null;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Splash());
            Application.Exit();
        }
    }
}
