using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace StartFromZeroToFullStack
{
    // პროდუქტის კლასი
    public class Product
    {

        // ფილდები (ფროფერთები)
        public static string davidMarket { get; set; }
        public  string name { get; set; }
        public string description { get; set; }

        private double price;

        // ეს ზონა არის ფასი რომ 0 ზე დაბლა არ იყოს...
        public double Price
        {
            get { return price; }
            set {
                if (value > 0)
                {
                    price = value;
                }
                
                
            }
        }

        private double discount;

        // ეს ზონაც არის ფასდაკლების ფასი 0 ზე დაბალი რომ არ იყოს
        public double Discount
        {
            get { return discount; }
            set {
                if (value >= 0)
                {
                    discount = value;
                }
               
            }
        }

        // ამ ზონაზე მინიჭებულია ფასდაკლების ფორმულა
        public double discountprice { get; set; }
        public double DiscountPrice
        {
            get { return discountprice = price - (price * discount / 10); }
            
        }
        
    }


   


    partial class Program
    {


        static void Main(string[] args)
        {

            // პროდუქტის მასივის ობიექტების გამოცხადება კონსოლში
            Product[] product = new Product[]
            {
                new Product{name = "google", description="google pixel 3", Price=500, Discount= 2, discountprice=0.2},
                new Product{name = "sony", description="xperia 1 ii", Price=800, Discount= 1, discountprice=0.2},
                new Product{name = "apple", description="iphone x", Price=900, Discount= 3, discountprice=0.2},
                new Product{name = "samsung", description="galaxy s21 ultra", Price=1000, Discount= 5, discountprice=0.2}
            };


            print(product);

        }


        // დაბეჭვდის მეთოდი ფროფერთების
        static void print(Product[] products)
        {
            foreach (var product in products)
            {
                Console.WriteLine($"magaziis saxeli : {Product.davidMarket}");
               
                Console.WriteLine($"produqtis dasaxeleba : {product.name}");
                
                Console.WriteLine($"produqtis fasi : {product.Price}");
                
                Console.WriteLine($"produqtis agwera : {product.description}");
                
                Console.WriteLine($"produqtis fasdakleba % : {product.Discount*10}");
                
                Console.WriteLine($"fastdaklebuli produqti : {product.DiscountPrice}");
                Console.WriteLine();
                Console.WriteLine();


            }
        }

    }

}

