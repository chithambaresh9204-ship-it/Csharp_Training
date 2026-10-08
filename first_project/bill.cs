using System;
public class Bill
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the Product Name: ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        string ProductName =Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
        Console.Write("Enter the Quantity of the Product: ");
        int Quantity=Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Price of the Product: ");
        int Price=Convert.ToInt32(Console.ReadLine());
        double total =Price*Quantity;
        double gstp=0.12;
        double gst=total*gstp;
        double discount=0;
        if(total>5000)
        {
            discount=total*0.18;
            total= (total - discount);
            double finaltotal=total+gst;
            Console.WriteLine("You are eligible for a discount of 18% of the total amount. Your discount amount is: " + finaltotal);
        }
        
        /*Console.WriteLine("UPS BILLING SYSTEM");
        Console.WriteLine("Name    Quantity    Price    Total   GST    Total(incGST)");
        Console.Write(ProductName);
        Console.Write("     "+Quantity);
        Console.Write("          "+Price);
        Console.Write("        "+total);
        Console.Write("     "+gstp);
        Console.Write("    "+(finaltotal));*/
    }
}