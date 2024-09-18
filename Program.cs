
using System;

class PruebaTusuerte
{
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(@"
██████╗ ██████╗ ██╗   ██╗███████╗██████╗  █████╗     ████████╗██╗   ██╗    ███████╗██╗   ██╗███████╗██████╗ ████████╗███████╗
██╔══██╗██╔══██╗██║   ██║██╔════╝██╔══██╗██╔══██╗    ╚══██╔══╝██║   ██║    ██╔════╝██║   ██║██╔════╝██╔══██╗╚══██╔══╝██╔════╝
██████╔╝██████╔╝██║   ██║█████╗  ██████╔╝███████║       ██║   ██║   ██║    ███████╗██║   ██║█████╗  ██████╔╝   ██║   █████╗  
██╔═══╝ ██╔══██╗██║   ██║██╔══╝  ██╔══██╗██╔══██║       ██║   ██║   ██║    ╚════██║██║   ██║██╔══╝  ██╔══██╗   ██║   ██╔══╝  
██║     ██║  ██║╚██████╔╝███████╗██████╔╝██║  ██║       ██║   ╚██████╔╝    ███████║╚██████╔╝███████╗██║  ██║   ██║   ███████╗
╚═╝     ╚═╝  ╚═╝ ╚═════╝ ╚══════╝╚═════╝ ╚═╝  ╚═╝       ╚═╝    ╚═════╝     ╚══════╝ ╚═════╝ ╚══════╝╚═╝  ╚═╝   ╚═╝   ╚══════╝");
        
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
     Console.WriteLine   (@"¡Bienvenido a Prueba tu suerte adivinando un número!
Prepárate para desafiar tu intuición en este emocionante juego de adivinanzas. Cada intento te acerca al número mágico, pero la suerte puede ser caprichosa.
¿Podrás descifrar el enigma? Acomódate y deja que el misterio te envuelva. ¡Que comience el juego!
Presiona cualquier tecla para empezar. ¡Buena suerte!!!");
        Console.ResetColor();
        Console.ReadKey();
        Console.Clear();

        Console.WriteLine("¿Cómo te gustaría llamarte en el juego?");
        string nombre = Console.ReadLine()!;
        
        while (string.IsNullOrWhiteSpace(nombre) || nombre == string.Empty)
        {
            Console.WriteLine("Necesitas un nombre para continuar, ¿cuál es tu nombre?");
            nombre = Console.ReadLine()!;
        }
        
        string respuesta = "si";
        for (; respuesta.ToLower() == "si";)
        {
        Console.Clear();
        Console.WriteLine($"¡Hola {nombre}!");
        Console.WriteLine("Cargando...");
        Thread.Sleep(3000);
        Console.Clear();
        
        Random aleatorio = new Random();
        int numeroParaAdivinar = aleatorio.Next(1, 21);
        int intentos = 4;
        bool adivinadoCorrectamente = false;

        Console.WriteLine(@$"{nombre}, ¡Hemos seleccionado un número secreto entre 1 y 20! Tienes {intentos} intentos para descubrirlo. ¡Atrévete a 
        adivinar y descubre cuál es nuestro misterioso número!");
        Thread.Sleep(1500);

        while (intentos > 0 && !adivinadoCorrectamente)
        {
            Console.WriteLine("Intruduce tu numero favorito:");
            string entrada = Console.ReadLine()!;
            int suposicion;

            if (int.TryParse(entrada, out suposicion))
            {
                if (suposicion == numeroParaAdivinar)
                {
                    adivinadoCorrectamente = true;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($@"¡Felicidades {nombre}! Has adivinado el número.
██    ██  ██████  ██    ██     ██     ██  ██████  ███    ██ 
 ██  ██  ██    ██ ██    ██     ██     ██ ██    ██ ████   ██ 
  ████   ██    ██ ██    ██     ██  █  ██ ██    ██ ██ ██  ██ 
   ██    ██    ██ ██    ██     ██ ███ ██ ██    ██ ██  ██ ██ 
   ██     ██████   ██████       ███ ███   ██████  ██   ████ ");
                    Console.ResetColor();
                    Console.WriteLine(@"
                                   :      :         
                                   :                
                                    :    :          
                        -===                  .     
               ::  ===  -====                       
               :::::-===--====                      
         ::::  ::::::--==--====-      :::           
          :::::-:::::::-==--=====    ::::-          
          ::::::-::::::::-=--=====  :::::-  ===     
          :::::::--:::::::----===== :::::- ====     
        :::-::::::--::::::::---====-::::::=====     
        ::::-::::::---:::::::::-===-::::::=====     
         ::::--::::::--:::::::::--==::::::-====     
          ::::--::::::-=-:::::::::---::::::====     
       ::-:::::-=-::::::--:::::::::::::::::-===     
       :::--:::::--::::::::::::::::::::::::-===     
        :::--:::::-=-:::::::::::::::::::::::-===    
         :::--:::::--:::::::::::::::::::::::-===    
         ::::--:::::::::::::::::::::::::::::-===    
          ::::-=-::::::::::::::::::::::::::::===    
           :::::--:::::::::::::::::::::::::::==-    
  ::        .:::::::::::::::::::::::::::::::-==     
              ::::::::::::::::::::::::::::::-==     
               ::::::::::::::::::::::::::::-==      
      :          ::::::::::::::::::::::::::-=       
    :             .:::::::::::::::::::::::-=        
           :        ::::::::::::::::::::-=          
          .            :::::::::::::::--            
                            :::::               ");
                }
                else
                {
                    intentos--;
                    if (suposicion < 1 || suposicion > 20)
                    {
                        Console.WriteLine("El número debe estar entre 1 y 20.");
                    }
                    else if (suposicion < numeroParaAdivinar)
                    {
                        Console.WriteLine("El número es mayor.");
                    }
                    else
                    {
                        Console.WriteLine("El número es menor.");
                    }

                    Console.WriteLine($"Te quedan {intentos} intentos.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, introduce un número.");
            }
        }

        if (!adivinadoCorrectamente)
        {
            Console.WriteLine($"Lo siento, {nombre}. Se te acabaron los intentos. El número era {numeroParaAdivinar}.");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"
 ██████   █████  ███    ███ ███████      ██████  ██    ██ ███████ ██████  
██       ██   ██ ████  ████ ██          ██    ██ ██    ██ ██      ██   ██ 
██   ███ ███████ ██ ████ ██ █████       ██    ██ ██    ██ █████   ██████  
██    ██ ██   ██ ██  ██  ██ ██          ██    ██  ██  ██  ██      ██   ██ 
 ██████  ██   ██ ██      ██ ███████      ██████    ████   ███████ ██   ██ 
                                                                          ");
            Console.ResetColor();
            Console.WriteLine(@"

                           ,--.
                          {    }
                          K,   }
                         /  `Y`
                    _   /   /
                   {_'-K.__/
                     `/-.__L._
                     /  ' /`\_}
                    /  ' /     
            ____   /  ' /
     ,-'~~~~    ~~/  ' /_
   ,'             ``~~~%%',
  (                     %  Y
 {                      %% I
{      -                 %  `.
|       ',                %  )
|        |   ,..__      __. Y
|    .,_./  Y ' / ^Y   J   )|
\           |' /   |   |   ||
 \          L_/    . _ (_,.'(
  \,   ,      ^^""' / |      )
    \_  \          /,L]     /
      '-_`-,       ` `   ./`
         `-(_            )
             ^^\..___,.--`");
        }
        Console.WriteLine("¿Deseas continuar? (si/no)");
    respuesta = Console.ReadLine()!;
            if (respuesta == "no")
            {
                Console.WriteLine("Tú te lo pierdes.");
            }
        }
    }
}

/*using System;

namespace CiclosIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cuantas frutas se va a comer: ");
            int cantidad = int.Parse(Console.ReadLine());

            string[] frutas = new string[cantidad];

            for (int i = 0; i< frutas.Length; i++)
            {
                Console.Clear();
                Console.Write("Ingrese la fruta que quiere: ");
                frutas[i] = Console.ReadLine();
            }

            for (int i = 0; i < frutas.Length; i++)
            {
                Console.WriteLine(frutas[i]);
            }


            /*string[] nombres = new string[4];//arreglo

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Clear();
                Console.Write("Ingrese un nombre: ");
                nombres[i] = Console.ReadLine();
            }

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i]);
            }


            Console.ReadKey();

            //int[] valores = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };


            //string[] paises = new string[5] { "Argentina", "Bolivia", "Peru", "Chile", "Colombia" };

            //Inicializacion omitiendo el tamaño de la matriz
            //int[] valores = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //string[] paises = new string[] { "Argentina", "Bolivia", "Peru", "Chile", "Colombia" };

            ////Tambien podemos omitir el operador new

            int[] valores = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] paises = { "Argentina", "Bolivia", "Peru", "Chile", "Colombia" };
        }
    }
}
}
}
}*/
