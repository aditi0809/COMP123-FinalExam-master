using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{

    /* Name = Aditi Kapoor 
     * Student id no = 301108498
     * modify Date = 21/08/2020
     Last Edited 20-08-2020/
     */
    public static class Program
    {
        public static SplashForm splashform;
        public static GenerateNameForm generateNameForm;
        public static AbilityGeneratorForm AbilityGenerator;
        public static Character character = new Character();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // instantiate splashform,generateNameForm ,AbilityGenerator objects
            splashform = new SplashForm();
            generateNameForm = new GenerateNameForm();
            AbilityGenerator = new AbilityGeneratorForm();
            Application.Run(splashform);
     


        }
    }
}
