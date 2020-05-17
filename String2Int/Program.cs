using System;

namespace String2Int
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello AppMan!");
            string strInput = Console.ReadLine();
            int Result = 0; int digit = 1;

            for(int i=strInput.Length-1; i>=0; i--) {
                if(strInput[i] == '0') {
                    Result += 0*digit;
                    digit*=10;
                }
                if(strInput[i] == '1') {
                    Result += 1*digit;
                    digit*=10;
                }
                if(strInput[i] == '2') {
                    Result += 2*digit;
                    digit*=10;
                }
                if(strInput[i] == '3') {
                    Result += 3*digit;
                    digit*=10;
                } 
                if(strInput[i] == '4') {
                    Result += 4*digit;
                    digit*=10;
                } 
                if(strInput[i] == '5') {
                    Result += 5*digit;
                    digit*=10;
                } 
                if(strInput[i] == '6') {
                    Result += 6*digit;
                    digit*=10;
                }
                if(strInput[i] == '7') {
                    Result += 7*digit;
                    digit*=10;
                }
                if(strInput[i] == '8') {
                    Result += 8*digit;
                    digit*=10;
                }
                if(strInput[i] == '9') {
                    Result += 9*digit;
                    digit*=10;
                }                
            }
            Console.WriteLine("Here is Result: "+ Result);
        }
    }
}
