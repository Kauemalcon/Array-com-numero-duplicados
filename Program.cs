using System;
using System.Linq;

namespace Array_com_numero_duplicados
{
    class Program
    {




        static void Main(string[] args)
        {
            // crie uma matriz 5 X 5 com valores inteiros aleatórios na faixa
            // -500 a 500
            // depois ordene os elementos de forma crescente
            // apresente esta matriz da seguinte forma:

            //Matriz onde vão ser postos todos os valores
            var matriz = new int[5, 5];
            //Vetor que adquirá todos os valores da matriz (criei ele para conseguir usar o OrderBy)
            var vetor = new int[25];

            //Insere os valores na matriz:
            matriz = InserirNumerosNaMatriz(matriz);
            //Coloca a matriz em um vetor:
            vetor = ColocarMatrizEmVetor(matriz, vetor);
            //Mostra a matriz original em forma de tabela:
            MostrarTabela(vetor, "\n\tTabela da matriz não ordenada:", true);
            //Ordena de modo crescente os valores da matriz, que estão dentro do vetor:
            vetor = OrdenarVetorDaMatriz(vetor);
            //Mostra o vetor ordenado:
            MostrarTabela(vetor, "\tTabela da matriz ordenada:", false);

            //-------------------------- Modo de fazer sem o OrderBy ----------------------------
            // matriz = new int[5, 5];
            //var novaMatriz = new int[5, 5];

            //matriz = InserirNumerosNaMatriz(matriz);
            //int indice1MenorValor = 0, indice2MenorValor = 0, menorValor = int.MaxValue;

            /////Percorre os índices da novaMatriz:
            //for (int index1 = 0; index1 < novaMatriz.GetLength(0); index1++)
            //{
            //    for (int subIndex1 = 0; subIndex1 < novaMatriz.GetLength(1); subIndex1++)
            //    {
            //       // Percorre os índices da matriz original:
            //         for (int index2 = 0; index2 < matriz.GetLength(0); index2++)
            //        {
            //            for (int subIndex2 = 0; subIndex2 < matriz.GetLength(1); subIndex2++)
            //            {
            //                if (matriz[index2, subIndex2] < menorValor)
            //                {
            //                    menorValor = matriz[index2, subIndex2];
            //                    indice1MenorValor = index2;
            //                    indice2MenorValor = subIndex2;
            //                }
            //            }
            //        }
            //        novaMatriz[index1, subIndex1] = menorValor;
            //        matriz[indice1MenorValor, indice2MenorValor] = int.MaxValue;
            //        menorValor = int.MaxValue;
            //    }
            //}
            //-----------------------------------------------------------------------------------
        }

        static int[,] InserirNumerosNaMatriz(int[,] matriz)
        {
            //Percorre todos os índices da matriz:
            for (int index = 0; index < matriz.GetLength(0); index++)
            {
                for (int subIndex = 0; subIndex < matriz.GetLength(1); subIndex++)
                {
                    //Para cada índice,subídice, ele escolherá um valor entre -500 e 500:
                    var random = new Random();
                    int numeroAleatorio = random.Next(-500, 500);
                    //Depois colocará esse valor no índice da matriz:
                    matriz[index, subIndex] = numeroAleatorio;
                }
            }
            //Retornará a matriz completa, com todos os valores:
            return matriz;
        }

        static int[] ColocarMatrizEmVetor(int[,] matriz, int[] vetor)
        {
            int i = 0;
            //Para cada valor da matriz:
            foreach (var valor in matriz)
            {
                //Ele coloca esse valor dentro do índice (variável auxiliar: i) do vetor:
                vetor[i] = valor;
                i++;
            }
            //No fim ele retornará o vetor, que tem todos os valores da matriz:
            return vetor;
        }

        static int[] OrdenarVetorDaMatriz(int[] vetor)
        {
            //Aqui ele ordena automaticamente os valores do vetor:
            var valoresMatrizOrdenados = vetor.OrderBy(x => x);

            Console.WriteLine();
            int x = 0;
            //Para cada valor nesse valoresMatrizOrdenados:
            foreach (var valor in valoresMatrizOrdenados)
            {
                //Ele põe o valor no devido índice (variável auxiliar: x) do vetor:
                vetor[x] = valor;
                x++;
            }
            return vetor;
        }

        static void MostrarTabela(int[] vetor, string legenda, bool matrizOriginal)
        {
            Console.WriteLine($"{legenda}");
            //Se caso for a matriz original a ser mostrada, a cor do console vai ser azul, senão magenta.
            Console.ForegroundColor = (matrizOriginal ? ConsoleColor.Blue : ConsoleColor.Magenta);
            //Coloca a primeira separação da linha da tabela:
            Console.WriteLine("--------------------------------------------");
            //Esse for é como se fosse as linhas da tabela, ele vai de 5 em 5, pois são 5 valores a serem mostrados:
            for (var j = 0; j < vetor.Length; j += 5)
            {
                //A cada linha ele escreve esses pontilhados no começo:
                Console.Write("----");
                //Esse for meio que representa as colunas da tabela. O i está com o valor do j pois ele deve saber em qual índice do vetor 
                //ele está para fazer seu papel de coluna (é como percorrer um array bidimensional, mas esse é adaptado pra vetores):
                for (var i = j; i < j + 5; i++)
                {
                    //A cada coluna, ele escreve o | e o número. No caso eu usei o String.Format, 
                    //que coloca o valor (vetor[i]) dentro de um espaço de 5 caracteres ({0,5}), isso é só pra deixar bonitinho no terminal:
                    Console.Write(String.Format("| {0,5}", vetor[i] + " "));
                }
                //No fim da linha ele coloca esse |---- e depois, a separação final da linha:
                Console.WriteLine("|----");
                Console.WriteLine("--------------------------------------------");
            }
            Console.ResetColor();
        }


    }
    
}
            //-------------------------------------------------------------------------------------------

            //Exercício:----------------------------------------------------
            //Crie uma matriz de 4 x 5 de inteiros e
            //para cada indice popule com um número aleatório entre -2000 a 2000
            //Ao final escreva o índice com o menor e o indice com o maior valor
            //Ignore se tiver repetidos
            // EX. 2,4 - O indice 2,5 que contém o valor X é o indice com menor valor
            // EX. 3,4 - O indice 3,4 que contém o valor Y é o indice com maior valor

        //    const int linha = 4;
        //    const int coluna = 5;
        //    int maiorValor = int.MinValue, menorValor = int.MaxValue;
        //    int indice1MaiorValor = 0, indice2MaiorValor = 0;
        //    int indice1MenorValor = 0, indice2MenorValor = 0;

        //    var matriz = new decimal[linha, coluna];

        //    for (int index = 0; index < linha; index++)
        //    {
        //        for (int subIndex = 0; subIndex < coluna; subIndex++)
        //        {
        //            int valorAux = ValorAleatorio();
        //            matriz[index, subIndex] = valorAux;
        //            if (valorAux > maiorValor)
        //            {
        //                indice1MaiorValor = index;
        //                indice2MaiorValor = subIndex;
        //                maiorValor = valorAux;
        //            }
        //            else if (valorAux < menorValor)
        //            {
        //                indice1MenorValor = index;
        //                indice2MenorValor = subIndex;
        //                menorValor = valorAux;
        //            }
        //        }
        //    }
        //    Console.WriteLine("Os valores da matriz são: ");
        //    foreach (decimal valorAuxiliar in matriz)
        //    {
        //        Console.Write($"{valorAuxiliar}");
        //        Console.WriteLine();
        //    }
        //    Console.WriteLine($"O indice {indice1MaiorValor},{indice2MaiorValor} que contém o valor" +
        //        $" {maiorValor} é o indice com maior valor\n");
        //    Console.WriteLine($"O indice {indice1MenorValor},{indice2MenorValor} que contém o valor" +
        //        $" {menorValor} é o indice com menor valor\n");

        //}
        //static int ValorAleatorio()
        //{
        //    var random = new Random();
        //    int numeroAleatorio = random.Next(-2000, 2000);
        //    return numeroAleatorio;
        //}
            //-------------------------------------------------------------------------------------------------------

            //----Exemplo------MATRIZ/FOREACH/RANDOM
            //const int linha = 3;
            //const int coluna = 4;
            //decimal valor = 1.2m;



            //var matriz = new decimal[linha, coluna];



            //for (int index = 0; index < linha; index++)
            //{
            // for (int subIndex = 0; subIndex < coluna; subIndex++)
            // {
            // matriz[index, subIndex] = valor;
            // valor *= 0.34m;
            // }
            //}



            //for (int index = 0; index < linha; index++)
            //{
            // for (int subIndex = 0; subIndex < coluna; subIndex++)
            // {
            // Console.WriteLine(matriz[index, subIndex]);
            // }
            //}



            //foreach (decimal valorAuxiliar in matriz)
            //{
            // Console.WriteLine(valorAuxiliar);
            //}

            //for (int x = 0; x < 100; x++)                         //|
            //{                                                     //|
            //    var random = new Random();                        // Numeros Aleatorios
            //    int numeroAleatorio = random.Next(-741, 852);     //|
            //    Console.WriteLine(numeroAleatorio);               //|
            //}


            //-----------------------------------------------------------------------------------------------------------------

            //-----------Atividade-----Kaue------------------------------------------------------------
            // Receber um array de int de inteiros e  que vai devolver um arrray de inteiros sem elementos duplicados.

            //var vetor = new int[12] { 1, 2, 0, 8, 1, 1, 2, -4, 0, 0, -4, 5 };

            //var novoArray = ListarArrays(vetor);
            //ImprimirLista(vetor, "antes");
            //ImprimirLista(novoArray, "depois");

            //static int[] ListarArrays(int[] lista)
            //{
            //    int[] testeLista = new int[lista.Length];
            //    int quantidade = 0;
            //    bool zero = false;
            //    for (int indice = 0; indice < lista.Length; indice++)
            //    {
            //        if (!testeLista.Contains(lista[indice]))
            //        {
            //            testeLista[quantidade] = lista[indice];
            //            quantidade++;
            //        }
            //    }
            //    if (lista.Contains(0))
            //    {
            //        zero = true;
            //        quantidade++;
            //    }
            //    int[] novoArrey = new int[quantidade];
            //    quantidade = 0;
            //    for (int indice = 0; indice < lista.Length; indice++)
            //    {
            //        if (!novoArrey.Contains(lista[indice]))
            //        {
            //            novoArrey[quantidade] = lista[indice];
            //            quantidade++;
            //        }
            //    }
            //    return novoArrey;
            //}
            //static void ImprimirLista(int[] valores, string ordenacao)
            //{
            //    string lista = ordenacao == "antes" ? "\nLista com valores duplicados: " : "\nLista sem valores duplicados: ";
            //    Console.Write(lista);
            //    for (int indice = 0; indice < valores.Length; indice++)
            //    {
            //        Console.Write(valores[indice] + " ");
            //    }
            //    Console.WriteLine(" ");
            //}

            //-------------------------------------------------------------------------------------------------------------------------

            //////Array com elementos duplicados
            ////var velhoArray = new int[25] { -5, 64, -5, 9, 100, 9, 88, 22, 13, 4, 98, 76, 25, 32, 25, 11, 0, 88, 27, 55, 98, 0, 36, -7, -100 };
            //var vetor = new int[12] { 1, 2, 0, 8, 1, 1, 2, -4, 0, 0, -4, 5 };
            ////Chamar função passando como parametro o velho array e receber um novo array sem numeros duplicados
            //var novoArray = ListarArrays(vetor);

            ////Imprimir a lista do array anterior e posterior
            //ImprimirLista(vetor, "antes");
            //ImprimirLista(novoArray, "depois");


            //static int[] ListarArrays(int[] lista)
            //{
            //    //iniciar array de teste do tamanho do array original
            //    int[] testeLista = new int[lista.Length];
            //    //contador para verificar a quantidade de numeros existe (se tiver zero na lista ele começa com 1, se não com zero)        
            //    int quantidade = 0;
            //    //variavel para verificar se possui zero
            //    bool zero = false;
            //    //loop para passar todos os valores para um novo array contando a quantidade de vezes que o numero foi adicionado
            //    for (int i = 0; i < lista.Length; i++)
            //    {   //se não tiver o numero na lista, ele adiciona
            //        if (!testeLista.Contains(lista[i]))
            //        {   //conta a quantidade de valores e adiciona na lista para ser verificado novamente                    
            //            testeLista[quantidade] = lista[i];
            //            quantidade++;
            //        }
            //    }
            //    //verifica se tem, pois se tiver ele não vai adicionar normalmente, pois todos os valores iniciam com zero e vão sendo preenchidos
            //    if (lista.Contains(0))
            //    {
            //        zero = true;
            //        quantidade++;
            //    }
            //    //iniciar o novo array para os valores sem duplicação
            //    int[] novoArray = new int[quantidade];
            //    //setar quantidade para zero
            //    quantidade = 0;
            //    //iniciar o loop até o tamanho da lista, porque agora sei qual o tamanho que meu novo array vai ter
            //    for (int i = 0; i < lista.Length; i++)
            //    {   //verifica se não tem o valor no novo array
            //        if (!novoArray.Contains(lista[i]))
            //        {   //ele entra e insere o valor na posição preenchendo o array completamente e incrementa a quantidade
            //            novoArray[quantidade] = lista[i];
            //            quantidade++;
            //        }
            //    }
            //    //retorna sem valores duplicados
            //    return novoArray;
            //}

            //static void ImprimirLista(int[] valores, String ordenacao)
            //{
            //    String lista = ordenacao == "antes" ? "\nLista Com Valores Duplicados: " : "\nLista Sem Valores Duplicados: ";
            //    Console.Write(lista);
            //    for (int i = 0; i < valores.Length; i++)
            //    {
            //        Console.Write(valores[i] + " ");
            //    }
            //    Console.WriteLine("");
            //}

      //  }



        /*retorna o numero de uma determinada posição
         *Console.WriteLine(Array.IndexOf(numeros, 7));
         */

        // --------Correçao Professor-----------------FOR/FOREACH-----
        //{
        //    var vetor = new int[12] { 1, 2, 0, 8, 1, 1, 2, -4, 0, 0, -4, 5 };
        //    vetor = RemoverElementosDuplicados(vetor);
        //    for (int indice = 0; indice < vetor.Length; indice++)
        //    {
        //        Console.WriteLine($"Indice: {indice} --> {vetor[indice]}");
        //    }
        //    Console.WriteLine();
        //}
        //static int[] RemoverElementosDuplicados(int[] vetor)
        //{
        //    int quantidadeDuplicados = 0;
        //    for (int indice = 0; indice < vetor.Length; indice++)
        //    {
        //        for (int subIndice = indice + 1; subIndice < vetor.Length; subIndice++)
        //        {
        //            if (subIndice != indice && vetor[subIndice] == vetor[indice])
        //            {
        //                quantidadeDuplicados++;
        //                break;
        //            }
        //        }
        //    }
        //    var novoVetor = new int[vetor.Length - quantidadeDuplicados];
        //    int indiceNovoVetor = 0;
        //    foreach (int valor in vetor)
        //    {
        //        if (!novoVetor.Contains(valor)) // Ctrl + . caso tiver suplinhado em vermelho
        //        {
        //            novoVetor[indiceNovoVetor] = valor;
        //            indiceNovoVetor++;
        //        }
        //    }
        //    return novoVetor;
        //}
    ///}
//}




//-------------------------------------------------------------------------------------------------------------

//}//------------Atividade-----------

//    //Fazer um programa para ler os dados de um produto em estoque (nome, preço e quantidade no estoque).
//    //Em seguida: Mostrar os dados do produto(nome, preço, quantidade no estoque, valor total no estoque)
//    //• Realizar uma entrada no estoque e mostrar novamente os dados do produto
//    //• Realizar uma saída no estoque e mostrar novamente os dados do produto

////    Console.WriteLine("Entre com os dados do produto:\n \n");
////    Console.Write("Nome Produto: ");
////    string produto = Console.ReadLine();
////    Console.Write("Preço produto: ");
////    decimal preco = decimal.Parse(Console.ReadLine());
////    Console.Write("Quantidade em estoque: ");
////    int qntAltualEstoque = int.Parse(Console.ReadLine());

////    Console.Write("\nDigite uma quantidade em inteiros para adicionar no estoque: ");
////    int quantidadeAdd = int.Parse(Console.ReadLine());
////    Console.Write("\nDigite uma quantidade em inteiros para retirar no estoque: ");
////    int quantidadeRetirada = int.Parse(Console.ReadLine());


////    int quantidadeRetiradaEstoque = SubtrairQuantidadeEstoque(quantidadeRetirada, quantidadeAdd, qntAltualEstoque);
////    int quantidadeAddEstoque = SomarQuantidadeEstoque(quantidadeAdd, qntAltualEstoque);
////    decimal somaTotalEstoque = SomarValorTotalEstoque(preco, qntAltualEstoque, quantidadeAdd);
////    decimal subtTotalEstoque = SubtrairValorTotalEstoque(preco, qntAltualEstoque, quantidadeRetirada, quantidadeAdd);
////    decimal valorTotalEstoque = CalcularValorTotalEstoque(preco, qntAltualEstoque);

////    Console.WriteLine("\nConferindo estoque: " + produto + ", R$ " + preco + ", Quantidade: "
////                          + qntAltualEstoque + ", valor total: R$" + valorTotalEstoque.ToString("F2") + ".\n");

////    Console.WriteLine("Conferindo estoque: " + produto + ", R$ " + preco + ", Quantidade: "
////                          + quantidadeAddEstoque + ", valor total: R$" + somaTotalEstoque.ToString("F2") + ".\n");

////    Console.WriteLine("Conferindo estoque: " + produto + ", R$ " + preco + ", Quantidade: "
////                          + quantidadeRetiradaEstoque + ", valor total: R$" + subtTotalEstoque.ToString("F2") + ".");

////}
////static decimal CalcularValorTotalEstoque(decimal valor, int qntAltualEstoque)
////{
////    decimal valorTotal = valor * qntAltualEstoque;
////    return valorTotal;
////}
////static decimal SomarValorTotalEstoque(decimal valor, int qntAltualEstoque, int quantidadeAdd)
////{
////    decimal valorTotal = valor * (qntAltualEstoque + quantidadeAdd);
////    return valorTotal;
////}
////static decimal SubtrairValorTotalEstoque(decimal valor, int qntAltualEstoque, int quantidadeRetirada, int quantidadeAdd)
////{
////    decimal valorTotal = valor * (quantidadeAdd + (qntAltualEstoque - quantidadeRetirada));
////    return valorTotal;
////}
////static int SomarQuantidadeEstoque(int quantidadeAdd, int qntAltualEstoque)
////{
////    int quantidadeAddTotal = quantidadeAdd + qntAltualEstoque;
////    return quantidadeAddTotal;
////}
////static int SubtrairQuantidadeEstoque(int quantidadeRetirada, int quantidadeAdd, int qntAtualEstoque)
////{
////    int quantidadeRetiradaTotal = (quantidadeAdd - quantidadeRetirada) + qntAtualEstoque;
////    return quantidadeRetiradaTotal;


//////-----------------------------------------------------------------------------------------------


////--------Exercício-----Udemy-------------------------

///Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
//// velha.

//// Console.WriteLine("Digite os dados (Nome e Idade) da primeira pessoa");
//// string nome = Console.ReadLine();
//// int idade = int.Parse(Console.ReadLine());
//// Console.WriteLine("Digite os dados (Nome e Idade) da segunda pessoa");
//// string nome1 = Console.ReadLine();
////int idade1 = int.Parse(Console.ReadLine());

//// if (idade > idade1)
//// {
////     Console.WriteLine(nome + " é mais velho(a)!");
//// }
//// else
//// {
////     Console.WriteLine(nome1 + " é mais velho(a)!");
//// }
///

////--------Exercício-----Udemy--------------------------------------------------------------------------------


////Fazer um programa para ler nome e salário de dois funcionários. Depois,
////mostrar o salário  médio dos funcionários.

////    Console.WriteLine("Informe o nome do funcionário");
////    string nome = Console.ReadLine();
////    Console.WriteLine("Digite o seu salário");
////    decimal salario = decimal.Parse(Console.ReadLine());
////    Console.WriteLine("Informe o nome do segundo funcionário");
////    string nome1 = Console.ReadLine();
////    Console.WriteLine("Digite o seu salário");
////    decimal salario1 = decimal.Parse(Console.ReadLine());

////    decimal mediaFinal = CalcularMediaSalario(salario, salario1);
////    Console.WriteLine("Media final dos dois salario é: "+ mediaFinal.ToString("F2")+" reais. ");
////}
////static decimal CalcularMediaSalario(decimal salario, decimal salario1)
////{
////    decimal mediaSalario = (salario + salario1) / 2;
////    return mediaSalario;



////-----------Atividade Udemy--------------------------------------------------------------------
///
////    Console.WriteLine("Digite um valor para soma");
////    decimal valor1 = decimal.Parse(Console.ReadLine());
////    Console.WriteLine("Digite um segundo valor para soma");
////    decimal valor2 = decimal.Parse(Console.ReadLine());

////    decimal resultado = Somar(valor1, valor2);
////    Console.WriteLine("O resultado da soma é: "+ resultado);
////}
////static decimal Somar(decimal valor1, decimal valor2)
////{
////    decimal soma = valor1 + valor2;
////    return soma;

////-----------Atividade Udemy------------------------------------------------------------
///
////    Console.WriteLine("Digite um valor");
////    decimal valor1 = decimal.Parse(Console.ReadLine());
////    Console.WriteLine("Digite um segundo valor");
////    decimal valor2 = decimal.Parse(Console.ReadLine());
////    Console.WriteLine("Digite um sinal(+,-,/,*)");
////    string sinal = Console.ReadLine();



////    if (sinal == "+")
////    {
////        decimal resultadoSoma = Somar(valor1, valor2);
////        Console.WriteLine("O resultado da operaçao é: " + resultadoSoma);

////    }
////    else if (sinal == "-")
////    {
////        decimal resultadoSubtraçao = Subtrair(valor1, valor2);
////        Console.WriteLine("O resultado da operaçao é: " + resultadoSubtraçao);

////    }
////    else if (sinal == "*")
////    {
////        decimal resultadoMultiplicaçao = Multiplicar(valor1, valor2);
////        Console.WriteLine("O resultado da operaçao é: " + resultadoMultiplicaçao);

////    }
////    else if (sinal == "/")
////    {

////        if (valor2 != 0)
////        {
////            decimal resultadoDivisao = Dividir(valor1, valor2);
////            Console.WriteLine("O resultado da operaçao é: " + resultadoDivisao);

////        }
////        else
////        {
////            Console.WriteLine("Operaçao inválida");
////        }
////    }
////    else
////    {
////        Console.WriteLine("Operaçao inválida");
////    }


////--------Criando Metodos-----------------------------------------------------------------------

////}
////static decimal Somar(decimal valor1, decimal valor2)
////{
////    decimal valorSoma = valor1 + valor2;
////    return valorSoma;
////}
////static decimal Subtrair(decimal valor1, decimal valor2)
////{
////    decimal valorSubtracao = valor1 - (valor2);
////    return valorSubtracao;
////}
////static decimal Multiplicar(decimal valor1, decimal valor2)
////{
////    decimal valorMutiplicaçao = valor1 * valor2;
////    return valorMutiplicaçao;
////}
////static decimal Dividir(decimal valor1, decimal valor2)
////{
////    decimal valorDivisao = valor1 / valor2;
////    return valorDivisao;
////}







