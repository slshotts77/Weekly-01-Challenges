using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Week_01_Challenge
{
    [TestClass]
    public class Week_01_Challenge
    {
        [TestMethod]
        public void decalreAndInitializeVariables()
        {
            string firstName = "Steve";
            string lastName = "Shotts";
            int numGiven = 7;
            int age = 43;

            Console.WriteLine(age + numGiven);
            Console.WriteLine(age - numGiven);
            Console.WriteLine(age * numGiven);
            Console.WriteLine(age / numGiven);
            Console.WriteLine(age % numGiven);
        }


        [TestMethod]
        public void decalreAndInitializeArray()
        {
            string[] books = { "Nelson DeMille, Plum Island ", "Nelson DeMille, Night Fall", "Nelson DeMille,THe Lion's Game", "John Grisham, Sycamore Row" };
            foreach (string i in books)
            {
                Console.WriteLine(i);
            }
        }


        [TestMethod]
        public void listOfDatesAndCurrent()
        {
            List<string> listOfDates = new List<string>();  //List<DateTime> listofDates = new List<DateTime>();
            listOfDates.Add("11/01/2020");  //using example above this would be listOfDates.Add(new DateTime(2020/12/25));
            listOfDates.Add("11/02/2020");
            listOfDates.Add("11/03/2020");
            listOfDates.Add("11/04/2020");
            listOfDates.Add("11/05/2020");
            listOfDates.Add("11/06/2020");
            listOfDates.Add("11/07/2020");
            listOfDates.Add("11/08/2020");
            listOfDates.Add("11/09/2020");
            listOfDates.Add("11/10/2020");


            DateTime today = DateTime.Today;
            //DateTime today = DateTime.Today;
            //listOfDates.Add(today);
        }


        [TestMethod]
        public void HowManyHoursofSleep()
        {
            Console.WriteLine("How many hours of sleep did you get?????");
            int hours = 4;
            if (hours >= 10)
            {
                Console.WriteLine("Wow, that's alot of sleep");
            }
            else if (hours > 8 && hours < 10)
            {
                Console.WriteLine("Your ahould be pretty ressted");
            }
            else if (hours > 4 && hours < 8)
            {
                Console.WriteLine("Bummer");
            }
            else
            {
                Console.WriteLine("Oh man get some sleep");
            }
        }

        [TestMethod]
        public void HowHasYourDayBeen()
        {
            string userDay = "Okay";
            switch (userDay)
            {
                case "Great":
                    Console.WriteLine("Glad you are having a greatday");
                    break;
                case "Good":
                    Console.WriteLine("It is a day to be good on");
                    break;
                case "Okay":
                    Console.WriteLine("Hopefully it will get better from here");
                    break;
                case "Bad":
                    Console.WriteLine("There is always tomorrow");
                    break;
                case ":(":
                    Console.WriteLine("I guess this is us now");
                    break;
                default:
                    Console.WriteLine("Please enter somethhing above");
                    break;
            }
        }

        [TestMethod]
        public void Supercalifragilisticexpialidocious()
        {
            string name = "Supercalifragilisticexpialidocious";
            foreach (char letter in name)
            {
                if (letter == 'i')
                {
                    Console.WriteLine(letter);
                }
                else
                {
                    Console.WriteLine("not a i");
                }
            }
        }
    }
}