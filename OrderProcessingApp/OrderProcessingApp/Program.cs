using System;
using BusnessDomain.Interfaces;
using BusnessDomain.Models;
using Factory;
using Factory.Interfaces;

namespace OrderProcessingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Getting the input from the user about which product to process
            Console.WriteLine("Please enter the product number for which you need to process the order (enter the number):\n" +
                "1. Physical Product \n" +
                "2. Book \n" +
                "3. Membership \n" +
                "4. Membership Upgrade \n" +
                "5. Video \n");
            string input = Console.ReadLine();

            //Retrieving the correct product type from enum based on the input by the user
            string productType = Enum.GetName(typeof(ProductType), Convert.ToInt32(input));
            ProductType product = (ProductType)Enum.Parse(typeof(ProductType), productType);

            //Initializing the Factory
            IProductFactory prodFactory = new ProductFacotry();

            //Processing the order
            IOrderProcess orderRule = prodFactory.GetProductRuleInstance(product);

            //Process the Order for the selected product
            bool orderProcess = orderRule.ProcessOrder(productType);

            Console.WriteLine("Thank you! Your order has been processed!");
            Console.ReadLine();
        }
    }
}
