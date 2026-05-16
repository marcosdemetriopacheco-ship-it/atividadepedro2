using System;

class Program
{
    static void Main()
    {
        // ==================================
        // PARTE 1 - IF / ELSE
        // ===================================
        Console.WriteLine("=== Sitema Escolar ===");
        Console.Write("Digite a nota do aluno: ");
        Double nota = Convert.ToDouble(Console.ReadLine());
        if (nota >= 7)
        {
            Console.WriteLine("Aluno aprovado!");
        }
        else if (nota >= 5)
        {
            Console.WriteLine("Aluno em recuperação!");
        }
        else
        {
            Console.WriteLine("Aluno reprovado!");
        }

        //==================================
        // PARTE 2 - SWITCH / CASE
        //==================================

        Console.WriteLine("=== Sitema Escolar ===");
        Console.WriteLine("1 - Secretaria");
        Console.WriteLine("2 - Financeiro");
        Console.WriteLine("3 - Coordenação");
        Console.WriteLine("4 - Biblioteca");
        Console.Write("Escolha uma opção: ");
        int opcao = Convert.ToInt32(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Console.WriteLine("Você escolheu Secretaria.");
                break;
            case 2:
                Console.WriteLine("Você escolheu Financeiro.");
                break;
            case 3:
                Console.WriteLine("Você escolheu Coordenação.");
                break;
            case 4:
                Console.WriteLine("Você escolheu Biblioteca.");
                break;
            default:
                Console.WriteLine("Opção inválida!");
                break;
        }
    }
}


