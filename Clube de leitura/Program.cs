using System;


namespace Clube_de_leitura
{
    internal class Program
    {

        public static Caixa[] caixas = new Caixa[5];
        public static int numeroCaixas = 0;

        public static Revista[] revistas = new Revista[5];
        public static int numeroRevistas = 0;

        public static Amigo[] teuzinhos = new Amigo[5];
        public static int numeroTeu = 0;

        public static Emprestimo[] emprestimos = new Emprestimo[1000];
        public static int numeroEmprestimo = 0;

        static void Main(string[] args)
        {
            PopularCaixas();
            Menu();
        }

        public static void Menu()
        {
            Console.WriteLine("Digite 1 para cadastrar revistas:" +
                "\nDigite 2 para visualizar as revistas: " +
                "\nDigite 3 para cadastrar amigos: " +
                "\nDigite 4 para fazer emprestimos: " +
                "\nDigite 5 para visualizar os emprestimos: ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1: CadastrarRevista();
                    break;

                case 2:MostrarRevistas();
                    break;

                case 3:CadastrarTeuzinho();
                    break;

                case 4:CadastrarEmprestimo();
                    break;

                case 5:MostrarEmprestimos();
                    break;

            }

        }


        public static void PopularCaixas()
        {
            string cor = "azul";
            string etiqueta = "terror";
            string numero = "1";

            caixas[0] = new Caixa(cor, etiqueta, numero);

            cor = "vermelho";
            etiqueta = "suspense";
            numero = "2";

            caixas[1] = new Caixa(cor, etiqueta, numero);

            cor = "amarela";
            etiqueta = "aventura";
            numero = "3";

            caixas[2] = new Caixa(cor, etiqueta, numero);

            cor = "preta";
            etiqueta = "crime";
            numero = "4";

            caixas[3] = new Caixa(cor, etiqueta, numero);

            cor = "marrom";
            etiqueta = "romance";
            numero = "5";

            caixas[4] = new Caixa(cor, etiqueta, numero);
        }

        public static void MostrarCaixas()
        {
            for (int i = 0; i < caixas.Length; i++)
            {
                Console.WriteLine(caixas[i]);
            }
        }

        public static void MostrarRevistas()
        {
            for (int i = 0; i < revistas.Length; i++)
            {
                Console.WriteLine(revistas[i]);
            }
        }

        public static void CadastrarRevista()
        {
            Console.WriteLine("Digite o nome da revista: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o tipo de edição: ");
            string tipoedicao = Console.ReadLine();

            Console.WriteLine("Digite a edição: ");
            string edicao = Console.ReadLine();

            Console.WriteLine("Digite o ano: ");
            string ano = Console.ReadLine();
            Console.WriteLine("");

            MostrarCaixas();

            Console.WriteLine("\nDigite em qual caixa a revista esta guardada(1-5): ");
            int indiceCaixa = Convert.ToInt32(Console.ReadLine());

            Caixa caixa = caixas[indiceCaixa - 1];


            revistas[numeroRevistas++] = new Revista(nome, tipoedicao, edicao, ano, caixa);
        }

        public static void CadastrarTeuzinho()
        {
            Console.WriteLine("Digite o nome do teu: ");
            string teu = Console.ReadLine();

            Console.WriteLine("Digite o nome dos pais do teuzinho: ");
            string paisTeu = Console.ReadLine();

            Console.WriteLine("Digite o telefone do teu: ");
            string teulefone = Console.ReadLine();

            Console.WriteLine("Digite o endereço do teu: ");
            string endereco = Console.ReadLine();

            teuzinhos[numeroTeu++] = new Amigo(teu, paisTeu, teulefone, endereco);

        }
        public static void MostrarTeus()
        {
            for (int i = 0; i < teuzinhos.Length; i++)
            {
                Console.WriteLine(teuzinhos[i]);
            }
        }

        public static void CadastrarEmprestimo()
        {
            MostrarTeus();
            Console.WriteLine("Digite o numero do amigo que deseja: ");
            int IndiceAmigo = Convert.ToInt32(Console.ReadLine());

            Amigo amigo = teuzinhos[IndiceAmigo - 1];

            MostrarRevistas();
            Console.WriteLine("Digite o numero da revista que deseja: ");
            int IndiceRevista = Convert.ToInt32(Console.ReadLine());

            Revista revista = revistas[IndiceRevista - 1];

            Console.WriteLine("Digite a data de emprestimo: ");
            DateTime DataEmprestimo = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Digite a data de devolução: ");
            DateTime DataDevolucao = Convert.ToDateTime(Console.ReadLine());

            emprestimos[numeroEmprestimo++] = new Emprestimo(amigo, revista, DataEmprestimo, DataDevolucao);
        }

        public static void MostrarEmprestimos()
        {
            for (int i = 0; i < emprestimos.Length; i++)
            {
                Console.WriteLine(emprestimos[i]);
            }
        }
    }
}
