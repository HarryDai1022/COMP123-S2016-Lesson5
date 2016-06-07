using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Lesson5
{
    /*
     * This calss is the driver class 
     */
    public class Program
    {

        /*
         * The main method for the driver class Program
         * 
         * @method Main
         * @param {string[]} args
         */
        public static void Main(string[] args)
        {
            // create instance of the Student
            Student tommy = new Student("Tommy", 20, "123456789");

            tommy.Age = 20;
            tommy.Name = "Tommy";
            tommy.SaysHello();

            Console.WriteLine();

            tommy.Studies();

            //Course COMP123 = new Course("COMP123", "Programming 2");

            //tommy.Courses.Add(COMP123);

            tommy.Courses.Add(new Course("COMP123", "Programming 2"));
            tommy.Courses.Add(new Course("COMP125", "Client-Side Web Development"));
            tommy.Courses.Add(new Course("COMP397", "Web Game Programming"));

            tommy.ShowCourses();

            Console.WriteLine();

            //create instance of the Teacher
            Teacher tom = new Teacher("Tom", 47, "987654321");
            tom.SaysHello();

            Console.WriteLine();

            tom.Teaches();

            List<string> names = new List<string>();

            names.Add("Tom");
            names.Add("Mary");
            names.Add("Jerry");

            int count = 0;
            Console.WriteLine();
            Console.WriteLine("********************************");
            foreach (string name in names)
            {
                Console.WriteLine("Name #" + count + "is" + name);
                count++;
            }
            Console.WriteLine("********************************");




            List<Card> Deck = new List<Card>();
            CreateDeck(Deck);
        }

        public static void CreateDeck(List<Card> deck)
        {
            string suit = "";

            for (int i = 0; i < 4; i++)
            {
                switch (i)
                {
                    case 0:
                        suit = "hearts";
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
                for (int face = 1; face < 14; face++)
                {
                    deck.Add(new Card(face, suit));
                }
            }


        }

    }
}
