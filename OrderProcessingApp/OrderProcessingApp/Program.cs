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
            //Initializations
            ProductType product;
            IProductFactory prodFactory;
            IOrderProcess orderRule;
            string productType = string.Empty;
            bool orderProcess = false;

            //Getting the input from the user about which product to process
            Console.WriteLine("Please enter the product number for which you need to process the order (enter the number):\n" +
                "1. Physical Product \n" +
                "2. Book \n" +
                "3. Membership \n" +
                "4. Membership Upgrade \n" +
                "5. Video \n");
            string input = Console.ReadLine();

            //Validate if the input is an integer or a string
            try
            {
                //Retrieving the correct product type from enum based on the input by the user
                productType = Enum.GetName(typeof(ProductType), Convert.ToInt32(input));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Sorry, we do not process this product type.");
            }


            //If it is a valid input, go ahead and process the order
            if (!string.IsNullOrEmpty(productType))
            {
                product = (ProductType)Enum.Parse(typeof(ProductType), productType);
                //Initializing the Factory
                prodFactory = new ProductFactory();

                //Processing the order
                orderRule = prodFactory.GetProductRuleInstance(product);
                //Process the Order for the selected product
                orderProcess = orderRule.ProcessOrder(productType);

            }

            //Validating the response
            if (orderProcess)
                Console.WriteLine("\nThank you! Your order has been processed!");
            else
                Console.WriteLine("Sorry, we do not process this product type.");
            Console.ReadLine();
        }
    }
}
