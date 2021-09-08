using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeiroProjeto
{
    class Programa
    {
        //Aula 4 const/ aray com variaveis globais;
        enum Notas {Minimo, Medio, Maximo }

        //Estrutura
        struct Pessoa
        {
            public string nome;
            public int idade;
            public double altura;
        }

        static void Main(string[] args)
        {
            //PrimeiraAula_Region_Console();
            //SegundaAula_Variaveis_Numeros();
            //TerceiraAula_Variaveis_CharBooleanVarObj();
            //QuartaAula_Const_Array_Struct();   //comandos do Console Write e Read//
            //AprendendoAusarOConsole();
            //Exercício_inversão_deNomes();
            //Aula_Cinco_Conversao();
            //Aula_Seis_ConversaoPerdaDeDados();
            MetodoParse_ConversaoVariavel();
            // Projeto main William

        }
        public static void PrimeiraAula_Region_Console()
        {
            //Bloco Region para que serve?
            /*
            O comando #region do próprio Visual Studio permite agrupar os comandos quando ele nao agrupa altomáticamente.
            exemplo:*/
            
            #region Exemplo Region
            //console.writeline("Hola");
            #endregion
           
            /*também é possível por a frente dele um título como: #region Comando de console linha
            no qual o nome Comando de console linha iria aparecer como título.*/
            
            #region Console texto exibido.
           // Console.WriteLine("My goodinho do céu");
           // Console.ReadKey();
            #endregion final do texto.

        }
        public static void SegundaAula_Variaveis_Numeros()
        {
            /* "Aprendendo Sobre as Varíaveis de Numeros" */
            //INTEGRAL COM SINAL.
            sbyte numero1 = 1; // 8 bits, de -128 a 127
            short numero2 = 2; // 16 bits, de -32.768 a 32.767
            int numero3 = 3;   // 32 bits, de -2.147.483.648 a 2.147.483.647
            long numero4 = 4;  // 64 bits, de -9.233.372.036.854.775.808 a 9.233.372.036.854.775.807

            //INTEGRAL SEM SINAL.
            byte number1 = 5;   // 8 bits, de 0 a 255
            ushort number2 = 6; // 16 bits, de 0 a 65.535
            uint number3 = 7;   // 32 bits, de 0 a 4.294.967.295
            ulong number4 = 8;  // 64 bits, de 0 a 18.446.744.073.709.551.615

            /*Varíaveis com Numeros com Decimais */
            float real = 100.00f;          // 32 bits para declarar como float deve se por o "f" após o nimero
            double real2 = 1.3550000;      // 64 bits
            decimal real3 = 77777777.555m; // 128 bits deve se por o "m"

            //double valor;
            //valor = real;
        }
        public static void TerceiraAula_Variaveis_CharBooleanVarObj()
        {
            /*Caracteres */
            char sexo = 'm';
            
            //Boolean = Verdadeiro ou Falso
            bool verificar = true;
            bool verificar2 = false;

            //String Varíavel tipo Texto
            string letras1 = "abc..";

            //Varíavel Adaptável
            var numero = 1;
            var letra = "a";

            //Varíavel Objeto
            object obj = false;
            obj = 200;
            obj = "wi";

        }
        public static void QuartaAula_Const_Array_Struct()
        {
            void Const() { }
            /*Aprendendo a reservar um valor usando o CONST*/
            // ao usar o CONST o valor definido na criação não pode ser alterado. serve para deixar a 
            // variavel privada de modificações de valor ou alterações

            const string nome = "williaml";
            const double PI = 3.14;


            void Array() { }
            /*Classe Program*/
            // variavel global array

            Notas notasAlunos = Notas.Minimo;
            Notas aluno2 = Notas.Medio;
            Notas aluno3 = Notas.Maximo;


            void Struct() { }
            /* Estrutura = struct */

            Pessoa p1 = new Pessoa();           //Criando um obj com a Herança da Estrutura feita 
            p1.nome = "william";
            p1.idade = 20;
            p1.altura = 1.67;

            /*Console.WriteLine("nome " + p1.nome + " idade " + p1.idade +" altura "+  p1.altura);
            Console.ReadKey();   */

            //tambem é possivel referenciar os dados do escopo como um array definindo apenas pelo nome
            //da variavel em questao "{ };" obrigatorio o uso do ponto e virgula ; no fechamento do array
            //Exemplo a baixo da forma feita;

            Pessoa p2 = new Pessoa() { nome = "segundo", idade = 25, altura = 1.70 };

            /*tambem é possivel escrever neste formato de quebra linha
             * {
                nome = "will",
                idade = 20,
                altura = 1.67
              };
             */

            /*Console.WriteLine("nome " + p2.nome + " idade " + p2.idade + " altura " + p2.altura);
              Console.ReadKey();*/

        }
        public static void AprendendoAusarOConsole() {
                //Metodo é caracterizado por ( abre e fecha ) "parenteses"

                /* Console.WriteLine("alo"); //imprimir a String com quebra de linha
                Console.Write("peido");     //imprimir a String sem a quebra de linha
                Console.ReadKey();         //Pausa o console para ler uma tecla
                Console.ReadLine();       //ReadLine espera uma tecla ser precionada para passar para proxima etapa
                Console.Read(); */       //Read é usado para ler as teclas pressionadas e escritas no console

                /* int codigo = Console.Read();
                 string texto = Console.ReadLine();
                 Console.WriteLine(texto);
                 Console.WriteLine(codigo); 
                 Console.Read(); */
            }
        public static void Exercício_inversão_deNomes()
        {
            //string um1, dois2, tres3, quatro4, Auxiliar;
            /*
            Console.Write("digite os nome 1: ");
            um1 = Console.ReadLine();

            Console.Write("nome 2: ");
            dois2 = Console.ReadLine();

            Console.Write("nome 3: ");
            tres3 = Console.ReadLine();

            Console.Write("nome 4: ");
            quatro4 = Console.ReadLine();
            */
            //invertendo os nomes//
            /*
            Auxiliar = um1;
            um1 = quatro4;
            quatro4 = Auxiliar;
            Auxiliar = dois2;
            dois2 = tres3;
            tres3 = Auxiliar;
            */
            /*
            Console.WriteLine();
            Console.WriteLine("Nomes inseridos invertidos");
            Console.WriteLine(nome1);
            Console.WriteLine(nome2);
            Console.WriteLine(nome3);
            Console.WriteLine(nome4);

            Console.ReadKey();
            */
            //rodou do jeito que foi feito no EAD//
        }
        public static void Aula_Cinco_Conversao()
        {
            byte nume1 = 100;  // 8 bits de 0 a 255
            ushort nume2;      // 16 bits de 0 a 65.0000
            nume2 = nume1;     // a variavel ushort suporta os dados da variavel byte 
                               // pois ela tem uma capaciadade maior;

            float nume3 = 1250.44f;
            double nume4 = nume3;
            nume3 = nume1;

            int numero = 'C';
            Console.WriteLine(numero);
           Console.ReadKey();

            //conversao com possivel perda de dados;
            ushort number1 = 100;
            byte number2 = (byte) number1;
            
            Console.WriteLine(number2);
            Console.ReadKey();

            double numenber4 = -33.44;
            char letra = (char) 97;  
            
            Console.WriteLine(letra);
            Console.ReadKey();
                       
        }
        public static void Aula_Seis_ConversaoPerdaDeDados()
        {
            //Conversão Implicita com perda de dados//

            ushort nume = 500;
            byte numee = (byte)nume;    //acontece a perda de dados de 500 recebe 
                                        //apenas 244; dos 500   
            float num = 2500.76f;
            int nu = (int)num;

            Console.WriteLine(numee);
            Console.ReadKey();
        }
        public static void MetodoParse_ConversaoVariavel()
        {
            string txtnumero = "2001";
            int data = int.Parse(txtnumero);

            byte dados = byte.Parse("33");
            
            Console.WriteLine(dados);
            Console.WriteLine(data);
            Console.ReadKey();

        }



    }
}
 
             
 
        

    











