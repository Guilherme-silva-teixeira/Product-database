using System;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace main
{
    struct dados
    {
        int total;
        String name;
        String tipo;
        float valor;
        float estq;
        String end;
    }

    class sistema
    {
        public int total;
        public String[] nome;
        public String[] tipo;
        public float[] valor;
        public float[] estq;
        public String[] end;

        public void Opc()
        {
            sistema Sys = new sistema();
            Sys.total = 0;
            Sys.nome = new string[100];
            Sys.tipo = new string[100];
            Sys.valor = new float[100];
            Sys.estq = new float[100];
            Sys.end = new string[100];

            int endLoop = 0;
            int op;

            while (endLoop == 0)
            {
                Console.WriteLine("===== CADASTRAR PRODUTO =====");
                Console.WriteLine("|");
                Console.WriteLine("| Digite a opção: ");
                Console.WriteLine("|");
                Console.WriteLine("| 1- Cadastrar produto:");
                Console.WriteLine("|");
                Console.WriteLine("| 2- Editar Produto: ");
                op = Console.Read();
            }
        }
    }

    class main
    {
        public static void Main(string[] args)
        {
            sistema Sys = new sistema();
            Sys.Opc();
        }
    }
}
