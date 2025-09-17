using Day_01_G03;
using System;
using System.Numerics;
using System.Runtime.Intrinsics.Arm;
using System.Text.RegularExpressions;
using System.Threading;
using static Day_01_G03.ListGenerator;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Transfromation

            #region Q1
            //1. Return a sequence of just the names of a list of products.

            //var res = ProductsList.Select(p=>p.ProductName);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q2
            //2. Produce a sequence of the uppercase and lowercase versions of each word in the original array

            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var res = words.Select(w => new { upper = w.ToUpper(), lower = w.ToLower() });


            //res=from w in words
            //    select new
            //    {
            //        upper = w.ToUpper(),
            //        lower = w.ToLower()
            //    };


            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q3
            //3. Returns all pairs of numbers from both arrays such that the number from numbersA is less
            //than the number from numbersB.

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var res= from a in numbersA
            //         from b in numbersB
            //         where a < b
            //         select new { a, b };
            //foreach (var item in res)
            //{
            //    Console.WriteLine($"{item.a} is less than {item.b}");
            //}

            #endregion
            #region q4
            //4. Select all orders where the order total is less than 500.00.
            //var res = from c in CustomersList
            //          from o in c.Orders
            //          where o.Total < 500.00M
            //          select new { c.CustomerID, o.OrderID, o.Total };
            //foreach (var item in res)
            //{
            //    Console.WriteLine($"{item.CustomerID} has an order {item.OrderID} with total {item.Total}");
            //}

            #endregion
            #region Q5
            //5.Determine if the value of int in an array match their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = Arr.Select((p, i) => new { number = p, same = (i == p) });
            //foreach (var item in res)
            //{
            //    Console.WriteLine($"{item.number}: {item.same}");
            //}
            #endregion

            #endregion
            #region Restriction Operators><


            #region Q1
            //1. Find all products that are out of stock.

            //var res =ProductsList.Where(p => p.UnitsInStock == 0);


            //res = from p in ProductsList
            //      where p.UnitsInStock == 0
            //      select p;

            //foreach (var item in res) Console.WriteLine(item);
            #endregion

            #region Q2
            //2. Find all products that are in stock and cost more than 3.00 per unit.


            //var res = ProductsList.Where(p => p.UnitsInStock >= 0 && p.UnitPrice > 3m);


            //res =from p in ProductsList
            //      where p.UnitsInStock >= 0 && p.UnitPrice > 3m
            //      select p;

            //foreach (var item in res) Console.WriteLine(item);

            #endregion

            #region Q3
            //3.Returns Numbers whose Position is Match their value

            //int[] Arr = { 3, 4, 2, 0, 1, 5, 6 };
            //var res = Arr.Where((p, i) => p == i);
            //foreach (var item in res) Console.WriteLine(item);


            #endregion
            #region Q4
            //4.Produce a sequence containing some properties of Products, including UnitPrice which is
            //renamed to Price in the result

            //var res = ProductsList.Select(p => new { p.ProductName, Price = p.UnitPrice, p.UnitsInStock });
            //res = from p in ProductsList
            //      select new
            //      {
            //          p.ProductName,
            //          Price = p.UnitPrice,
            //          p.UnitsInStock

            //      };

            //foreach (var item in res) Console.WriteLine(item);
            #endregion
            #region Q5
            //5.Select all orders where the order was made in 1998 or later.
            //var res = from c in CustomersList
            //          from o in c.Orders
            //          where o.OrderDate.Year >= 1998
            //          select o;
            //foreach (var item in res) Console.WriteLine(item);

            #endregion
            #endregion
            #region Ordering Operators
            #region Q1
            //1. Sort a list of products by name

            //var res = ProductsList.OrderBy(p => p.ProductName);
            //res = from p in ProductsList
            //      orderby p.ProductName
            //      select p;
            //foreach (var item in res) Console.WriteLine(item);

            #endregion
            #region Q2
            //2. Sort a list of products by units in stock from highest to lowest.


            //var res = ProductsList.OrderByDescending(p => p.UnitsInStock);
            //res = from p in ProductsList
            //        orderby p.UnitsInStock descending
            //        select p;
            //foreach (var item in res) Console.WriteLine(item);


            #endregion
            #region Q3
            //3. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var res = Arr.OrderBy(w => w.Length).ThenBy(w => w);
            //res = from w in Arr
            //      orderby w.Length, w
            //      select w;
            //foreach (var item in res) Console.WriteLine(item);
            #endregion
            #region Q4
            //4. Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var res = ProductsList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            //res = from p in ProductsList
            //      orderby p.Category, p.UnitPrice descending
            //      select p;
            //foreach (var item in res) Console.WriteLine(item);

            #endregion
            #region Q5
            //5. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var res = Arr.OrderBy(w => w.Length).ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase);
            ////res = from w in Arr
            ////      orderby w.Length, w descending
            ////      select w;
            //foreach (var item in res) Console.WriteLine(item);

            #endregion
            #region Q6
            //6. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in
            //the original array.

            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var res = Arr.Where(w => w.Length >= 2 && w[1] == 'i').Reverse();
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
            #endregion

            #endregion


        }
    }
}
