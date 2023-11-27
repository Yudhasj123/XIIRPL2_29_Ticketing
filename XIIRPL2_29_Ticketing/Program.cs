using XIIRPL2_29_Ticketing.MasterForm;

namespace XIIRPL2_29_Ticketing
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //FrmLogin frmLogin = new FrmLogin();
            //frmLogin.Show();
            /*FrmMasterBandara bandara = new FrmMasterBandara();
            bandara.Show();*/

            /* FrmMasterMaskapai maskapai = new FrmMasterMaskapai();
             maskapai.Show();*/

            FrmKodePromo kodePromo = new FrmKodePromo();
            kodePromo.Show();
            Application.Run();
        }
    }
}