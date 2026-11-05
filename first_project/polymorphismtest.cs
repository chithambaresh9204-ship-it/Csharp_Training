using System;
public class Notification
{

        public string ReceiverName;
        public string Message;

     public virtual void Send()
    {
        if (ValidateMessage())
            Console.WriteLine($"Notification sent to {ReceiverName}");
        else
            Console.WriteLine("Error: Message cannot be empty");
    }
     public bool ValidateMessage()
    {
        return !string.IsNullOrEmpty(Message);
    }
}
public class EmailNotification : Notification
{
    public override void Send()
    {
        if (ValidateMessage())
            Console.WriteLine($"Email sent successfully to {ReceiverName} and the message is {Message}");
        else
            Console.WriteLine("Error: Message cannot be empty");
    }
}
public class SMSNotification : Notification
{
    public override void Send()
    {
        if (ValidateMessage())
            Console.WriteLine($"SMS sent successfully to {ReceiverName} and the message is {Message}");
        else
            Console.WriteLine("Error: Message cannot be empty");
    }
}
public class WhatsappNotification : Notification
{
    public override void Send()
    {
        if (ValidateMessage())
            Console.WriteLine($"Whatsapp Message sent successfully to {ReceiverName} and the message is {Message}");
        else
            Console.WriteLine("Error: Message cannot be empty");
    }
}

class TestProgram
{
    static void Main()
    {
        Notification n1 = new EmailNotification { ReceiverName = "Arun", Message = "Meeting at 10 AM Please atten it without fail" };
        Notification n2 = new SMSNotification { ReceiverName = "Priya", Message = "Your Recharge plan is goinb to be experied on 07-11-2026 so Recharge immediately to experience and uninterrupted services ThankYou!!" };
        Notification n3 = new WhatsappNotification { ReceiverName = "Kumar", Message = "Come and meet me at my cabin by 12 pm" };
        Notification n4 = new SMSNotification { ReceiverName = "Suresh", Message = "" };

        n1.Send();
        n2.Send();
        n3.Send();
        n4.Send();
    }
}