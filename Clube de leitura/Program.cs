using System;


namespace Clube_de_leitura
{
    internal class Program
    {

        public static Caixa[] caixas = new Caixa[5];
        public static int numeroCaixas = 0;

        public static Categoria[] categorias = new Categoria[3];
        public static int numeroCategoria = 0;

        public static Revista[] revistas = new Revista[1000];
        public static int numeroRevistas = 0;

        public static Amigo[] teuzinhos = new Amigo[1000];
        public static int numeroTeu = 0;

        public static Emprestimo[] emprestimos = new Emprestimo[1000];
        public static int numeroEmprestimo = 0;

        public static Reserva[] reservas = new Reserva[1000];
        public static int numeroReserva = 0;


        static void Main(string[] args)
        {
            PopularCategorias();
            PopularCaixas();
            Menu();
        }

        public static void Menu()
        {
            int opcao = 0;

            while (opcao != 8)
            {
                Console.WriteLine("Digite 1 para cadastrar revistas:" +
                "\nDigite 2 para visualizar as revistas: " +
                "\nDigite 3 para cadastrar amigos: " +
                "\nDigite 4 para fazer emprestimos: " +
                "\nDigite 5 para visualizar os emprestimos: " +
                "\nDigite 6 para fazer reservas: " +
                "\nDigite 7 para visualizar as revervas e fazer emprestimos: " +
                "\nDigite 8 para Sair: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        CadastrarRevista();
                        break;

                    case 2:
                        MostrarRevistas();
                        break;

                    case 3:
                        CadastrarTeuzinho();
                        break;

                    case 4:
                        CadastrarEmprestimo();
                        break;


                    case 5:
                        MostrarEmprestimos();
                        break;

                    case 6:
                        CadastrarReserva();
                        break;

                    case 7:
                        MostrarReservasFazerEmprestimos();
                        break;

                    case 8:
                        break;

                    default:
                        Console.WriteLine("opção Invalida");
                        break;
                }

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

        public static void PopularCategorias()
        {
            string Nome = "Novidade";
            double DiasEmpretimo = 7;


            categorias[0] = new Categoria(Nome, DiasEmpretimo);

            Nome = "Usado";
            DiasEmpretimo = 20;


            categorias[1] = new Categoria(Nome, DiasEmpretimo);

            Nome = "Raro";
            DiasEmpretimo = 3;


            categorias[2] = new Categoria(Nome, DiasEmpretimo);
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
                if (revistas[i] != null)
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

            Console.WriteLine("Digite o numero da categoria: ");
            numeroCategoria = Convert.ToInt32(Console.ReadLine());

            Categoria categoria = categorias[numeroCategoria - 1];

            MostrarCaixas();

            Console.WriteLine("\nDigite em qual caixa a revista esta guardada(1-5): ");
            int indiceCaixa = Convert.ToInt32(Console.ReadLine());

            Caixa caixa = caixas[indiceCaixa - 1];


            revistas[numeroRevistas++] = new Revista(nome, tipoedicao, edicao, ano, categoria, caixa);
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
                if (teuzinhos[i] != null)
                    Console.WriteLine(teuzinhos[i]);
            }
        }

        public static void CadastrarEmprestimo()
        {
            MostrarTeus();
            Console.WriteLine("Digite o numero do amigo que deseja: ");
            int IndiceAmigo = Convert.ToInt32(Console.ReadLine()) - 1;

            Amigo amigo = teuzinhos[IndiceAmigo];

            if (teuzinhos[IndiceAmigo].JaTemEmprestimo == true)
            {
                Console.WriteLine("você ja tem um emprestimo");
                return;
            }
            teuzinhos[IndiceAmigo].JaTemEmprestimo = true;

            MostrarRevistas();
            Console.WriteLine("Digite o numero da revista que deseja: ");
            int IndiceRevista = Convert.ToInt32(Console.ReadLine()) - 1;

            Revista revista = revistas[IndiceRevista];

            if (revistas[IndiceRevista].JaFoiEmprestada == true)
            {
                Console.WriteLine("A revista ja foi emprestada");
                return;
            }

            revistas[IndiceRevista].JaFoiEmprestada = true;

            Console.WriteLine($"Data de emprestimo: {DateTime.Now}");

            DateTime DataDevolucao = DateTime.Now.AddDays(revistas[IndiceRevista].Categoria.DiasEmprestimo);
            Console.WriteLine($"Data de devolução: {DataDevolucao}");

            emprestimos[numeroEmprestimo++] = new Emprestimo(amigo, revista, DataDevolucao);
        }

        public static void MostrarEmprestimos()
        {
            for (int i = 0; i < emprestimos.Length; i++)
            {
                if (emprestimos[i] != null)
                    Console.WriteLine(emprestimos[i]);
            }
        }

        public static void CadastrarReserva()
        {
            MostrarTeus();
            Console.WriteLine("Digite o numero do amigo que deseja: ");
            int IndiceAmigo = Convert.ToInt32(Console.ReadLine()) - 1;

            Amigo amigo = teuzinhos[IndiceAmigo];

            MostrarRevistas();
            Console.WriteLine("Digite o numero da revista que deseja: ");
            int IndiceRevista = Convert.ToInt32(Console.ReadLine()) - 1;

            Revista revista = revistas[IndiceRevista];

            if (revistas[IndiceRevista].JaFoiEmprestada == true)
            {
                Console.WriteLine("A revista ja foi emprestada");
                return;
            }

            if (revistas[IndiceRevista].JaFoiReservada == true)
            {
                Console.WriteLine("A revista ja foi reservada");
                return;
            }

            revistas[IndiceRevista].JaFoiReservada = true;

            Console.WriteLine($"Data de reserva: {DateTime.Now}");

            Console.WriteLine($"Data de limite da reserva: {DateTime.Now.AddDays(2)}");

            reservas[numeroReserva++] = new Reserva(amigo, revista);

        }

        public static void MostrarReservasFazerEmprestimos()
        {
            for (int i = 0; i < reservas.Length; i++)
            {
                if (reservas[i] != null)
                    Console.WriteLine(reservas[i]);
            }

            Console.WriteLine("Digite 1 para realizar emprestimo: " +
                            "\nDigite 2 para sair: ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite o numero da reserva que deseja usar: ");
                    int indiceReserva = Convert.ToInt32(Console.ReadLine()) - 1;

                    Amigo amigo = reservas[indiceReserva].Amigo;
                    Revista revista = reservas[indiceReserva].Revista;
                    DateTime dataDevolucao = DateTime.Now.AddDays(reservas[indiceReserva].Revista.Categoria.DiasEmprestimo);
                    emprestimos[numeroEmprestimo++] = new Emprestimo(amigo, revista, dataDevolucao);

                    break;

                case 2:
                    break;
            }
        }
    }
}
