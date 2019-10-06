// Enrick De Munter 5ITN 2019/10/04 IT-Admin
/* De gegevens van een leerling invoeren.
 * analyse....
 * De voornaam en  famillienaam van een leerling.
 * zijn klas
 * zijn e-mail adress van school
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItAdmin
{
    class Program
    {
        static void Main(string[] args)
        {//DECLARATIES 
            Console.Write("voornaam: ");
            voornaam = Console.ReadLine();
            Console.Write("famillienaam: ");
            famillienaam = Console.ReadLine();
            Console.Write("klas?: ");
            klas = Console.ReadLine();
            Console.Write("mail?: ");
            mail = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine(voornaam + " " + famillienaam.ToUpper());
            Console.WriteLine(klas);
            Console.WriteLine(mail);
            Console.ReadLine();
        }

        
        }
    }
}
