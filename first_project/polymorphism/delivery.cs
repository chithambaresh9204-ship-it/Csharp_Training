using System;
public class DeliveryService
{
    double CalculatedeliveryCharge(double amt,double dis)
    {
        if (dis>0||dis < 5)
        {
            amt=amt+30;
        }else if (dis>5||dis < 10)
        {
            amt=amt+50;
        }
        else
        {
            amt=amt+100;
        }
        return amt;
    }
    double CalculatedeliveryCharge(double amt,double dis,double weight)
    {
            if ((dis>0||dis < 5)&&(weight>0||weight<20))
            {
                amt=amt+50;
            }else if ((dis<10||dis>5)&&(weight>20||weight<50))
            {
                amt=amt+100;
            }
            else
            {
                amt=amt+150;
            }
            return amt;
        }
         double CalculatedeliveryCharge(double amt,double dis,double weight,double express)
        {
            if ((dis>0||dis < 5)&&(weight>0||weight<20)&&(express>0||express<3))
            {
                amt=amt+100;
            }else if ((dis<10||dis>5)&&(weight>20||weight<50)&&(express>3||express<6))
            {
                amt=amt+150;
            }
            else
            {
                amt=amt+200;
            }
            return amt;
        }
    
    public static void Main(String[] args)
    {
        DeliveryService p = new DeliveryService();
        int amt=1000;
        Console.WriteLine(p.CalculatedeliveryCharge(amt,5));
        Console.WriteLine(p.CalculatedeliveryCharge(amt,5,30));
        Console.WriteLine(p.CalculatedeliveryCharge(amt,5,30,6));
    }
}