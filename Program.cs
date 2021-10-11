using System;
using Personas;
namespace Arreglos_Objetos_G4_2022_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona[] integrantesEquipo1 = new Persona[3];

            integrantesEquipo1[0] = new Persona("Armando","5510124798",22);
            integrantesEquipo1[1] = new Persona("Luis", "55221090", 20);
            integrantesEquipo1[2] = new Persona("Carlos", "551248988", 21);

            for (int i = 0; i< integrantesEquipo1.Length; i++ )
            {
                Console.WriteLine("Nombre: {0} ", integrantesEquipo1[i].Nombre);
            }


            Persona[,] parejasG4 = new Persona[2,2];

            parejasG4[0,0] = new Persona("Armando","5517458878",20);
            parejasG4[0,1] = new Persona("Juan","5522148878",)




            Console.ReadLine();


        }
    }
}
