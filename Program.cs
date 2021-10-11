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

            foreach( Persona integrante in integrantesEquipo1   )
            {
                Console.WriteLine("Teléfono {0}",integrante.Telefono  );
                Console.WriteLine("Edad {0}", integrante.Edad);
            }


            Persona[,] parejasG4 = new Persona[2,2];

            //Equipo 1
            parejasG4[0,0] = new Persona("Armando","5517458878",20);
            parejasG4[0, 1] = new Persona("Juan", "5522148878", 21);

            //Equipo 2
            parejasG4[1, 0] = new Persona("Rodrigo", "251487582", 22);
            parejasG4[1, 1] = new Persona("Luisa", "54212458", 21);

            for(int i=0; i <=1; i++     )
            {
                Console.WriteLine("****Equipo {0} ****", i+1);
                for(int j=0; j <= 1; j++   )
                {
                    Console.WriteLine("Integrante {0}",j+1);
                    Console.WriteLine(parejasG4[i, j].ToString()  );
                 /*   Console.WriteLine("Nombre: {0}", parejasG4[i, j].Nombre);
                    Console.WriteLine("Teléfono: {0}", parejasG4[i, j].Telefono);
                    Console.WriteLine("Edad: {0}", parejasG4[i, j].Edad);*/

                }
            }





            Console.ReadLine();


        }
    }
}
