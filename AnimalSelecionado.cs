using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    class AnimalSelecionado
    {
        public static string AnimalEscolido(ReinoAnimal reinoAnimal)
        {

            string grupo = reinoAnimal.Grupo;
            string filo = reinoAnimal.Filo;
            string classificacao = reinoAnimal.Classificacao;
            string animal;

            if (grupo == "vertebrado" && filo == "ave" && classificacao == "carnivoro")
                animal = "aguia";
            else if (grupo == "vertebrado" && filo == "ave" && classificacao == "onivoro")
                animal = "pomba";
            else if (grupo == "vertebrado" && filo == "mamifero" && classificacao == "onivoro")
                animal = "homem";
            else if (grupo == "vertebrado" && filo == "mamifero" && classificacao == "herbivoro")
                return "vaca";
            else if (grupo == "invertebrado" && filo == "inseto" && classificacao == "hematofago")
                animal = "pulga";
            else if (grupo == "invertebrado" && filo == "inseto" && classificacao == "herbivoro")
                animal = "largata";
            else if (grupo == "invertebrado" && filo == "anelideo" && classificacao == "hematofago")
                animal = "sanguessuga";
            else if (grupo == "invertebrado" && filo == "anelideo" && classificacao == "onivoro")
                animal = "minhoca";
            else
                animal = "Impossivel Calcular";
            return animal;

        }
    }

}
