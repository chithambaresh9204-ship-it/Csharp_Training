using System;
public class Order
{
    public static void Main(String[] args)
    {
        Console.Write("Select product category(Watch(5000), Stationary(3000),Dress(8000))");
        string Product=Console.ReadLine();
        Console.Write("Enter the Number of Quantity: ");
        int Quantity=Convert.ToInt32(Console.ReadLine());
        double total=0;
        if(Quantity>5){
            Console.Write("If you have any Coupon Codes Enter it: ");
            string Coupon=Console.ReadLine();
            switch (Product)
            {
                case("Watch"):
                    total=5000*Quantity;
                    break;
                case("Stationary"):
                    total=3000*Quantity;            
                    break;
                case("Dress"):
                    total=8000*Quantity;
                    break;
                default:
                    Console.WriteLine("Enter a Valid Product");
                    break;
            }
            if(Coupon == "wat001")
            {
                total -= total * 0.15;
            }
            else if(Coupon == "sta001")
            {
                total -= total * 0.15;
            }
            else if(Coupon == "dre001")
            {
                total -= total * 0.15;
            }
            else
            {
                Console.WriteLine("Enter a Valid Coupon Code");
            }
            Console.WriteLine("You Have Choosen the product type "+Product+" and the total amount after applying coupon code will be "+total);
        }
        else
        {
            Console.WriteLine("You have to order more than 5 products");
        }
    }
}