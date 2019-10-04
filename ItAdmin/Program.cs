// Enrick De Munter 5ITN 2019/10/04 IT-Admin
/* De gegevens van een leerling invoeren.
 * analyse....
 * De voornaam en  naam van een leerling.
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
            string input1, input2, input3;          //invoer
            int naam, klas, mail;                    //processing
            int uitvoer;                             //uitvoer

            //input
            //vraag De volledigenaam van een leerling.
            Console.Write("wat is jouw naam?: ");
            input1 = Console.ReadLine();
            naam = int.Parse(input1);

            //vraag zijn klas.
            Console.Write("wat is jouw klas?: ");
            input2 = Console.ReadLine();
            klas = int.Parse(input2);

            //vraag naar zijn e-mail adress van school
            Console.Write("wat is jouw email?: ");
            input3 = Console.ReadLine();
            mail = int.Parse(input3);

            //processing
            //toon volledige naam, klas en mail van school
            naam = naam;
            klas = klas;
            mail = mail;

            //output
            //toon de naam, klas, mail van school
            uitvoer = naam, klas, mail;
            Console.WriteLine();

        }
    }
}
