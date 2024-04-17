namespace prueba_de_plano_ejesXY
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
            Application.Run(new Form1());
            Console.WriteLine("Hola mundo");

        }

        public static double Suma(int a1, double a2) => (a1 + a2);
        public static double Suma(double a1, int a2) => (a1 - a2);
    }
}