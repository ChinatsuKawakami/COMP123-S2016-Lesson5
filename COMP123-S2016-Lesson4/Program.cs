using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*This is driver class(program.cs file)
 * Author:Chinatsu Kawakami
 * 
 * 
 */
namespace COMP123_S2016_Lesson4
{
    /**
     * This is the "driver class" for our Program
     * @class Program
     */
    public class Program
    {
        /**
         * The main metod for our driver class Program
         * 
         * @mathod Main
         * @pram {string()} args
         */
        static void Main(string[] args)
        {

            //create instance of the Student
            Student tommy = new Student("Tommy", 20, "123456789");

            tommy.SaysHello();
            Console.WriteLine();
            tommy.Studies();

            // Course COMP123 = new Course("COMP123", "programming2");
            //  Course COMP125 = new Course("COMP125", "Web Development");
            tommy.Course.Add(new Course("COMP123", "programming2"));
            tommy.Course.Add(new Course("COMP125", "Web Development"));
            tommy.Course.Add(new Course("COMP397", "Web Gaming"));
            // create instance of the Teachers class
            Teacher tom = new Teacher("Tom", 47, "T123456789");
            tom.SaysHello();
            Console.WriteLine();
            tom.Teaches();

            MyList myList = new MyList();
            myList.Add(1);
            myList.Add(5);
            myList.Clear();
            myList.Print();

            List<string> names = new List<string>();
            names.Add("Tom");
            names.Add("Mary");
            names.Add("Ruiky");
            int count = 0;
            Console.WriteLine();
            Console.WriteLine("***********************************************");
            foreach (string item in names)
            {
                Console.WriteLine("Name #" + count + " is " + item);
                count++;

            }
            Console.WriteLine("***********************************************");
            List<Card> Deck = new List<Card>();
            CreateDeck(Deck);
        }
        public static void CreateDeck(List<Card> deck)
        {
            string suit;
            for (int i = 1; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        suit = "heart";
                        break;
                    case 1:
                        suit = "clubs";
                        break;
                    case 2:
                        suit = "diamonds";
                        break;
                    case 3:
                        suit = "spades";
                        break;
                }

                for (int index = 1; index < 14; index++)
                {
                    deck.Add(new Card(face, suit));
                }
            }
        }
    }
    }

