using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class Tela
    {
        public static ReinoAnimal RecebeValores()
        {
            ReinoAnimal reinoAnimal = new ReinoAnimal();

            reinoAnimal.Grupo = Console.ReadLine().ToLower();
            reinoAnimal.Filo = Console.ReadLine().ToLower();
            reinoAnimal.Classificacao = Console.ReadLine().ToLower();
            return reinoAnimal;
        }

        public static void ExibirAnimal(string animal)
        {
            Console.WriteLine(animal);

        }

    }
}
