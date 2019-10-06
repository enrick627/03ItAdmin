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
            string input1, input2, input3, input4;           //invoer
            int voornaam, famillienaam, klas, mail;           //processing
            int uitvoer;                             //uitvoer

            //input
            //vraag De voornaam en famillienaam van een leerling.
            Console.Write("wat is jouw voornaam?: ");
            input1 = Console.ReadLine();
            voornaam = int.Parse(input1);

            //vraag de famillienaam.
            Console.Write("wat is jouw achternaam?: ");
            input2 = Console.ReadLine();
            famillienaam = int.Parse(input2);

            //vraag zijn klas.
            Console.Write("wat is jouw klas?: ");
            input3 = Console.ReadLine();
            klas = int.Parse(input3);

            //vraag naar zijn e-mail adress van school
            Console.Write("wat is jouw email?: ");
            input4 = Console.ReadLine();
            mail = int.Parse(input4);

            //processing
            //toon voornaam en famillienaam, klas en mail van school
             voornaam = voornaam;
             famillienaam = famillienaam;
             klas = klas;
             mail = mail;

            //output
            //toon de naam, klas, mail van school
            uitvoer = ToLower(voornaam);
            uitvoer = ToUpper(famillienaam);
            uitvoer = klas;
            uitvoer = mail;
            Console.WriteLine();

            //wachten.....
            Console.WriteLine();
            Console.WriteLine("druk op enter om af te sluiten");
            Console.ReadLine();
        }

        private static int ToUpper(int famillienaam)
        {
            throw new NotImplementedException();
        }

        private static int ToLower(int voornaam)
        {
            throw new NotImplementedException();
        }
    }
}
