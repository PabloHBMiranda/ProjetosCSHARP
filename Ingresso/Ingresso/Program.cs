using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingresso
{
    class global
    {
        //total de ingressos
        private static int totaling = 0;
        public static int Totaling { get => totaling; set => totaling = value; }
        //fim

        
        //cadeiras
        private static int[] vingadores;
        private static int[] corra;
        private static int[] queen;
        private static int[] formes;
        public static int[] Vingadores { get => vingadores; set => vingadores = value; }
        public static int[] Corra { get => corra; set => corra = value; }
        public static int[] Queen { get => queen; set => queen = value; }
        public static int[] Formes { get => formes; set => formes = value; }
        //fim


        //Nome da pessoa logada
        private static string loginG;
        internal static string LoginG { get => loginG; set => loginG = value; }
        //fim nome da pessoa logada


        //logado ou não
        public static bool logado = false;
        //fim


        //listas de dados
        private static List<String> email = new List<String>();
        private static List<String> senha = new List<String>();
        private static List<String> nome = new List<String>();

        internal static List<string> Email { get => email; set => email = value; }
        internal static List<string> Senha { get => senha; set => senha = value; }
        public static List<string> Nome { get => nome; set => nome = value; }
        //fim


        //valor ingresso
        private static double valoring = 0;
        public static double Valoring { get => valoring; set => valoring = value; }
        //fim

        //qual filme?
        public static int filme_escolhido;
        //fim
    }
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
