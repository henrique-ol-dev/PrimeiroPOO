using System;

namespace PrimeiroPOO
{
    class Program
    {
        static void Main(string[] args)
        {

            Personagem riri = new Personagem();
            riri.nome = "Riri Williams";
            riri.armadura = "Iron Heart";
       
            Console.WriteLine(riri.nome);
            Console.WriteLine(riri.Defender() );

            Console.WriteLine(riri.Atacar(34f, 20f));

        }
    }
}
