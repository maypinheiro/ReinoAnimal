using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
           var reinoAnimal = Tela.RecebeValores();
           Tela.ExibirAnimal(AnimalSelecionado.AnimalEscolido(reinoAnimal ));
        }

    }
}
