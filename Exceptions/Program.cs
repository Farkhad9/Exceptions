

using Exceptions.Models;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Xml;
using Group = Exceptions.Models.Group;

namespace Exceptions
{
    internal partial class Program
    {
        private static string groupNo;
        private static int limit;

        static void Main(string[] args)
        {
            #region task4
            Console.WriteLine("User Yaradilmasi");
            Console.Write("Zehmet olmasa User ucun Fullname qeyd edin: ");
            string fullname = Console.ReadLine();
            Console.Write("Zehmet olmasa User ucun Email qeyd edin: ");
            string email = Console.ReadLine();
            Console.Write("Zehmet olmasa User ucun Password qeyd edin: ");
            string password = Console.ReadLine();


            User user1 = new User(fullname, email, password);
            Console.WriteLine("User ugurla yaradildi");


            while (true)
            {
                Console.WriteLine("Mnenu");
                Console.WriteLine("1. Show Info");
                Console.WriteLine("2. Create new Group");
                Console.WriteLine("Zehmet olmasa komanda secin ");



                string command = Console.ReadLine();
                switch (command)
                {
                    case "1":
                        user1.ShowInfo();
                        break;
                    case "2":
                        Console.Write("GroupNo: ");
                        string groupNo = Console.ReadLine();
                        Console.Write("Group ucun limit qeyd edin");
                        int limit = Convert.ToInt32(Console.ReadLine());
                        Group group1 = new Group(groupNo, limit);
                        Console.WriteLine("Group ugurla yaradildi");
                        break;

                    default:
                        Console.WriteLine("Seciminiz yanlisdir!!");
                        break;
                }
                while (true)
                {

                    Console.WriteLine("Menu");
                    Console.WriteLine("1.Show all students");
                    Console.WriteLine("2.Get student by id");
                    Console.WriteLine("3.Add student");
                    Console.WriteLine("0. Quit");
                    Console.Write("Zehmet olmasa komanda secin: ");
                    string command2 = Console.ReadLine();
                    switch (command2)
                        
                    {
                        case "1":
                            Group group1 = new Group(groupNo, limit);
                            if ( group1 == null)
                            {
                                Console.WriteLine("Qrup yaradılmayıb!");
                                break;
                            }

                            Student[] all = group1.GetAllStudents();
                            if (all.Length == 0)
                            {
                                Console.WriteLine("Qrupda hələ tələbə yoxdur!");
                            }
                            else
                            {
                                foreach (Student st in all)
                                {
                                    st.StudentInfo();
                                    Console.WriteLine("-----------------");
                                }
                            }
                            break; 

                        case "0":
                            Console.WriteLine("Program bitdi!");
                            return;

                        default:
                            Console.WriteLine("Yanlış seçim!");
                            break;
                    }



                }
            }
            }



            #endregion


            #region task3
            //while (true)
            //{

            //    Console.WriteLine("Menu");
            //    Console.WriteLine("1. Square");
            //    Console.WriteLine("2. Rectangular");
            //    Console.WriteLine("0. Quit");


            //    Console.WriteLine("Zehmet olmasa komanda secin: ");
            //    string command = Console.ReadLine();
            //    switch (command)
            //    {
            //        case "1":
            //            try
            //            {
            //                Console.WriteLine("Zehmet olmasa kvadratin terefini qeyd edin: ");
            //                int side = Convert.ToInt32(Console.ReadLine());
            //                Square square = new Square(side);
            //                square.CalcArea();

            //            }
            //            catch (ArgumentOutOfRangeException ex)
            //            {
            //                Console.WriteLine($"Error: {ex.Message}");
            //            }
            //            catch (FormatException)
            //            {
            //                Console.WriteLine("Error: Invalid input format. Please enter a valid integer.");
            //            }
            //            break;

            //        case "2":
            //            try
            //            {
            //                Console.WriteLine("Zehmet olmasa duzbucaqlinin tereflerini qeyd edin: ");
            //                int width = Convert.ToInt32(Console.ReadLine());
            //                int length = Convert.ToInt32(Console.ReadLine());
            //                Rectangular rectangular = new Rectangular(width, length);
            //                rectangular.CalcArea();

            //            }
            //            catch (ArgumentOutOfRangeException ex)
            //            {
            //                Console.WriteLine($"Error: {ex.Message}");
            //            }
            //            catch (FormatException)
            //            {
            //                Console.WriteLine("Error: Invalid input format. Please enter a valid integer.");
            //            }
            //            break;
            //        case "0":
            //            {
            //                Console.WriteLine("istifade etdiyiniz ucun tesekkurler");
            //                return;
            //            }
            //        default:
            //            Console.WriteLine("Seciminiz Yanlisdir!!");
            //            break;
            //    }
            //}
            #endregion
            #region task1
            //double result = Exchange(Currecy.Try, 2);
            //Console.WriteLine($"konvertasiya neticesinde elde olunmush mebleg: {result}");
            #endregion
            #region task2
            //Kelvin kelvin = new Kelvin(500);
            //Celsius celsius = kelvin;
            //Console.WriteLine($" degree is : { celsius.Degree}");
            #endregion
        

        
        #region task1
        public static double Exchange(Enum curr, double azn)
        {
            if (curr.GetType() != typeof(Currecy))
            {
                throw new Exception($"Gonderilen Enum Obyekti Currecy Enum Deyil");
            }
            Currecy currecy = (Currecy)curr;

            switch (currecy)

            {
                case Currecy.Usd:
                    return azn * 0.59;
                case Currecy.Eur:
                    return azn * 0.55;
                case Currecy.Try:
                    return azn * 17.89;
                default:
                    throw new Exception("bilinməyən valyuta");
            }

        }
        #endregion



    }
}
