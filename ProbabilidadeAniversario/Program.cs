namespace ProbabilidadeAniversario
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Projeto Probabilidade do Aniversario!");
            Console.WriteLine("Aperte ENTER para continuar . . .");
            Console.ReadLine();


            Console.WriteLine("\n");
            Console.Write("Coleque uma quantidade de pessoas que vai ter dentro de um salão: ");
            string pessoas = Console.ReadLine();
            Console.WriteLine($"\nAdicionado {pessoas} pessoas dentro do salão . . .");
            Console.WriteLine($"\nQual a chance de {pessoas} pessoas fazerem aniversario no mesmo dia? Veremos a seguir!");
            Console.WriteLine("Aperte ENTER para continuar. . . \n");
            Console.ReadLine();

            Information inf = new Information(Convert.ToInt16(pessoas));

            Console.WriteLine($"Probabilidade de {inf.Aniversario}% \n \n \n");
            Console.WriteLine("Obrigado por testar meu Projeto! \n \n");
            Console.WriteLine("Feito por Faluckes, fevereiro de 2022 \nhttps://github.com/Faluckes\n \n Aperte ENTER para fechar o programa.");





            Console.ReadLine();
        }
    }
}