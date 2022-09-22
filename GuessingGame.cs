using System;

namespace guessing_number;

public class GuessNumber
{    
    private IRandomGenerator random;    
    public GuessNumber() : this(new DefaultRandom()){}
    public GuessNumber(IRandomGenerator obj)
    {
        this.random = obj;
    }

    //user variables
    public string? response;
    public int userValue;
    public int randomValue;


    public void Greet()
    {
        Console.Write("---Bem-vindo ao Guessing Game---");
        Console.Write("Para começar, tente adivinhar o número que eu pensei, entre -100 e 100!");
        
        }

    public void ChooseNumber()
    {
    response = Console.ReadLine();

    while (!(int.TryParse(response, out userValue) && userValue is >= -100 and <= 100))
    {
      Console.WriteLine($"Por favor, digite um número inteiro:");
      ChooseNumber();
    }
    }
    
    public void RandomNumber()
    {
        randomValue = random.GetInt(-100, 100);
    }
    
    public void AnalyzePlay()
    {
        if (userValue > randomValue) {
            Console.Write("Tente um número MENOR");
        }

            if (userValue < randomValue) {
            Console.Write("Tente um número MAIOR");
        }

            if (userValue == randomValue) {
            Console.Write("ACERTOU!");
        }
    }
}