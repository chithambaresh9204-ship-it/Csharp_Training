using System;
public interface IPayment {
    void Payment(int amt);
}

// Step 2: Concrete Classes
public class Cash : IPayment {
    public void Payment(int amt){
        Console.WriteLine("The Amount of RS "+amt+" is credited by Cash");
    }
}

public class Gpay : IPayment {
    public void Payment(int amt)
    {
        Console.WriteLine("The Amount of RS "+amt+" is credited by Gpay");
    }
}
public class CreditCard : IPayment {
    public void Payment(int amt)
    {
        Console.WriteLine("The Amount of RS "+amt+" is credited by CreditCard");
    }
}

public class ShapeFactory {
    public static IPayment GetShape(string amttype) {
        if (amttype == "Cash")
            return new Cash();
        else if (amttype == "Gpay")
            return new Gpay();
        else 
            return new CreditCard();
    }
}
class MainProgram {
    static void Main() {
        IPayment type1 = ShapeFactory.GetShape("Cash");
        type1.Payment(123456789);
        IPayment type2 = ShapeFactory.GetShape("Gpay");
        type2.Payment(0987654321);
        IPayment type3 = ShapeFactory.GetShape("CreditCard");
        type3.Payment(1234567890);

    }
}