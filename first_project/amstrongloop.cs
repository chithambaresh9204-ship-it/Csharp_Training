using System;
public class Amstrongloop
{
    public static void Main(String[] args)
    {
        int num=100;
        for(int i=num;i<=2000;i++){
            int sum=0;
            int temp=i;
            while(temp>0){
                int rem=temp%10;
                sum+=rem*rem*rem;
                temp/=10;
            }
            if(sum==i){
                Console.WriteLine(i+" is an Amstrong number");
            }
        }
    }
}