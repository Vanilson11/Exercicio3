namespace Exercicio3;

public class Program
{
    public static void Main()
    {
        string palavra = Console.ReadLine();
        int totalCaracteres = 0;

        foreach(char letra in palavra)
        {
            bool isNumber = char.IsDigit(letra);
            bool isSymbol = char.IsPunctuation(letra);

            if (letra == ' ' || isNumber) continue;
            if (isSymbol) continue;

            totalCaracteres++;
        }

        Console.WriteLine(totalCaracteres);
    }
}
