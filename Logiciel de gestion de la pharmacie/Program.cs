namespace Logiciel_de_gestion_de_la_pharmacie
{
    internal static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
            Application.Run(new Menu());


        }
    }
}