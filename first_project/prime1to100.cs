using System;
public class Primeloop
{
    public static void Main(String[] args)
    {
        bool isprime=true;
        int num=1;
        for(int j=num;j<=100;j++){
            
            isprime=true;
            for(int i=2;i<=j/2;i++){
                if(j%i==0){
                    isprime=false;
                    break;
                }
            }
            if(isprime==true){
                Console.WriteLine(j+" is a prime number");
            }
        }
    }
}