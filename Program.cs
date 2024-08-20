﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace csharp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
               shopping_cart sc = new shopping_cart();
               sc.shopping();
               Console.ReadKey();

              Temperature t = new Temperature();
              t.convert_temp();
              Console.ReadKey();

              ATM atm = new ATM();
              atm.check_balance();
              atm.deposit();
              atm.withdraw();
              atm.check_balance();

             Marks_Average ma= new Marks_Average();
             ma.cal_avg();
             Console.ReadKey();

             password ps = new password();
             ps.validate_password();
             Console.ReadKey();

             fare f = new fare();
             f.taxi_fare();
             Console.ReadKey();

            a1q7 a1q7 = new a1q7();
            a1q7.perfect_attendence();
            Console.ReadKey();

            a1q8 m = new a1q8();
            m.expenses();
            Console.ReadKey();

            a1q9 q9 = new a1q9();
            q9.Main_items();
            Console.ReadKey();

            a1q10 ms = new a1q10();
            ms.shoping_Cart();
            Console.ReadKey();

        }
    }

    class shopping_cart
    {
        private int[] arr = { 2500, 200, 500, 186, 780 };
        private int sum = 0;


        public void shopping()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            if (sum > 3000)
            {
                double discount = (sum * 10) / 100;
                Console.WriteLine("Total Shopping bill " + (sum - discount));
            }
            else
            {
                Console.WriteLine("Total Shopping bill " + sum);
            }
        }
    }
    class Temperature
    {
        public void convert_temp()
        {
            Console.Write("Enter Temperatute in celcious : ");
            double cel = Convert.ToDouble(Console.ReadLine());

            if (cel < 0)
            {
                Console.WriteLine("Temperature is at at freezing point ");
            }
            else
            {
                double feh = (9 / 5) * cel + 32;
                Console.WriteLine("Temperature in fehrainheit " + feh);
            }
        }
    }

    class ATM
    {
        private double balance = 2000;
        private double amount;

        public void check_balance()
        {
            Console.WriteLine("your total balance is : " + balance);
        }

        public void deposit()
        {
            Console.Write("Enter amount for deposit : ");
            amount = Convert.ToDouble(Console.ReadLine());
            balance += amount;
            Console.WriteLine("Deposit Successful ");
        }
        public void withdraw()
        {
            Console.Write("Enter amount for withdrawl : ");
            amount = Convert.ToDouble(Console.ReadLine());
            if (amount > balance)
            {
                Console.WriteLine("Insufficient balance ");
            }
            else
            {
                balance -= amount;
                Console.WriteLine("Amount Withdraw Successful");
            }
        }
    }

    class Marks_Average
    {

        public void cal_avg()
        {
            Console.Write("Enter the length of array :");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] marks = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter the Marks in Subject {i + 1} :");
                marks[i] = Convert.ToInt32(Console.ReadLine());
                sum += marks[i];
            }
            double avg = sum / n;
            if (avg >= 90)
            {
                Console.WriteLine("Grades : A");
            }
            else if (avg >= 80)
            {
                Console.WriteLine("Grades : B");
            }
            else if (avg >= 70)
            {
                Console.WriteLine("Grades : C");
            }
            else if (avg >= 60)
            {
                Console.WriteLine("Grades : D");
            }
            else if (avg >= 50)
            {
                Console.WriteLine("Grades : E");
            }
            else
            {
                Console.WriteLine("Fail");
            }
; }
    }

    class password
    {
        public void validate_password()
        {
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();

            string validationMessage = ValidatePassword(password);

            Console.WriteLine(validationMessage);
        }

        static string ValidatePassword(string password)
        {
            if (password.Length < 8)
            {
                return "Password must be at least 8 characters long.";
            }

            if (!Regex.IsMatch(password, "[A-Z]"))
            {
                return "Password must contain at least one uppercase letter.";
            }

            if (!Regex.IsMatch(password, "[a-z]"))
            {
                return "Password must contain at least one lowercase letter.";
            }

            if (!Regex.IsMatch(password, "[0-9]"))
            {
                return "Password must contain at least one number.";
            }

            return "Password is valid.";
        }
    }


    class fare
    {
        public void taxi_fare()
        {
                Console.Write("Enter the distance traveled in kilometers: ");
                double distance = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the time of the ride (in 24-hour format, e.g., 23 for 11 PM): ");
                int hour = Convert.ToInt32(Console.ReadLine());

                const double flatRate = 20.0;       
                const double perKmRate = 10.0;     
                const double nightSurcharge = 0.2;  

                double fare = CalculateFare(distance, hour, flatRate, perKmRate, nightSurcharge);

                Console.WriteLine($"The total fare for the ride is: Rs. {fare:F2}");
            }

            static double CalculateFare(double distance, int hour, double flatRate, double perKmRate, double nightSurcharge)
            {
                double fare = 0.0;

                if (distance <= 2)
                {
                    fare = flatRate;
                }
                else
                {
                     fare = flatRate + (distance - 2) * perKmRate;
                }

                if (hour >= 22 || hour < 5) 
                {
                    fare += fare * nightSurcharge;
                }

                return fare;
            }
    }



class a1q7
    {
        public void perfect_attendence()
        {
            const int totalDays = 5;
            bool[] attendance = new bool[totalDays];

            for (int i = 0; i < totalDays; i++)
            {
                Console.Write($"Did the student attend on day {i + 1}? (y/n): ");
                char input = Console.ReadKey().KeyChar;
                Console.WriteLine();

                attendance[i] = input == 'y' || input == 'Y';
            }

            int daysAttended = CalculateTotalAttendance(attendance);

            bool hasPerfectAttendance = CheckPerfectAttendance(attendance);

            Console.WriteLine($"\nTotal days attended: {daysAttended}");
            Console.WriteLine(hasPerfectAttendance ? "The student has perfect attendance." : "The student does not have perfect attendance.");
        }

        static int CalculateTotalAttendance(bool[] attendance)
        {
            int daysAttended = 0;

            foreach (bool day in attendance)
            {
                if (day)
                {
                    daysAttended++;
                }
            }

            return daysAttended;
        }

        static bool CheckPerfectAttendance(bool[] attendance)
        {
            foreach (bool day in attendance)
            {
                if (!day)
                {
                    return false;
                }
            }

            return true;
        }
    }




    class a1q8
    {
        public void expenses()
        {
            string[] months = new string[12]
            {
                    "January", "February", "March", "April", "May", "June",
                    "July", "August", "September", "October", "November", "December"
            };


            double[] monthExpenses = new double[12];
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine("Enter the month " + (i + 1) + " expenses: ");
                monthExpenses[i] = Convert.ToDouble(Console.ReadLine());
            }

            double total_expenses = 0;
            double max_expense = 0;
            double min_expense = monthExpenses[0];
            int min = 0;
            int max = 0;
            for (int i = 0; i < monthExpenses.Length; i++)
            {
                if (monthExpenses[i] > max_expense)
                {
                    max_expense = monthExpenses[i];
                    max = i+1;
                }
                if (monthExpenses[i] < min_expense)
                {
                    min_expense = monthExpenses[i];
                    min = i+1;
                }

                total_expenses += monthExpenses[i];
            }

            Console.WriteLine("total expenses of the Year is: " + total_expenses);

            Console.WriteLine("month highest expenses: " + max);
            Console.WriteLine("month lowest expenses: " + min);
           
        }

    }



class a1q9
    {
        public void Main_items()
        {
            List<Item> cart = new List<Item>();
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nShopping Cart System");
                Console.WriteLine("1. Add item");
                Console.WriteLine("2. Remove item");
                Console.WriteLine("3. View cart");
                Console.WriteLine("4. View total price");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddItem(cart);
                        break;
                    case "2":
                        RemoveItem(cart);
                        break;
                    case "3":
                        ViewCart(cart);
                        break;
                    case "4":
                        ViewTotalPrice(cart);
                        break;
                    case "5":
                        running = false;
                        Console.WriteLine("Exiting the system. Thank you for shopping!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please choose again.");
                        break;
                }
            }
        }

        static void AddItem(List<Item> cart)
        {
            Console.Write("Enter the name of the item: ");
            string name = Console.ReadLine();

            Console.Write("Enter the price of the item: ");
            double price = Convert.ToDouble(Console.ReadLine());

            cart.Add(new Item(name, price));
            Console.WriteLine($"Item '{name}' added to the cart.");
        }

        static void RemoveItem(List<Item> cart)
        {
            Console.Write("Enter the name of the item to remove: ");
            string name = Console.ReadLine();

            Item itemToRemove = cart.Find(item => item.Name == name);

            if (itemToRemove != null)
            {
                cart.Remove(itemToRemove);
                Console.WriteLine($"Item '{name}' removed from the cart.");
            }
            else
            {
                Console.WriteLine($"Item '{name}' not found in the cart.");
            }
        }

        static void ViewCart(List<Item> cart)
        {
            Console.WriteLine("\nItems in your cart:");

            if (cart.Count == 0)
            {
                Console.WriteLine("Your cart is empty.");
            }
            else
            {
                foreach (var item in cart)
                {
                    Console.WriteLine($"- {item.Name}: Rs. {item.Price:F2}");
                }
            }
        }

        static void ViewTotalPrice(List<Item> cart)
        {
            double totalPrice = 0;

            foreach (var item in cart)
            {
                totalPrice += item.Price;
            }

            Console.WriteLine($"\nTotal price of items in the cart: Rs. {totalPrice:F2}");
        }
    }

    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Item(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }

    class a1q10
    {
        public void shoping_Cart()
        {
            Console.Write("Enter the hourly wage: ");
            decimal hourlyWage = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Enter the number of hours worked in a week: ");
            int hoursPerWeek = Convert.ToInt32(Console.ReadLine());

            decimal weeklySalary = hourlyWage * hoursPerWeek;

            decimal monthlySalary = weeklySalary * 4;

            Console.WriteLine($"\nThe monthly salary is: {monthlySalary:C}");
        }
    }

   }
