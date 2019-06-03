using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyelles_et_consonnes
{
    class Program
    {
        static void Main(string[] args)
        {
          
                Console.WriteLine("Rentrer une lettre de l'alphabet");
                char Lettre;
                char.TryParse(Console.ReadLine(), out Lettre);
                switch (char.ToLower(Lettre))
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'y':

                        Console.WriteLine("C'est une voyelle ! ");
                        break;
                    default:
                        Console.WriteLine("C'est une consonne ! ");
                        break;         
                }
                
                     
            Console.ReadLine();
        }
    }
}
