using System;
using System.Text;

    class Program
    {
        public static string hextoASCII(string hexString)
        {
            if (String.IsNullOrWhiteSpace(hexString)){
                return "String is invalid.";
            }
            if (hexString.Length %2 !=0){
                return "String is Incomplete. Please complete it.";
            }
            else{
                hexString = hexString.Replace(" ", "");
                hexString = hexString.Replace("-", "");
                
                var finalString = new StringBuilder();
                for (var i = 0; i < hexString.Length; i += 2) {
                    var hexCharac = hexString.Substring(i, 2);
                    finalString.Append((char)Convert.ToByte(hexCharac, 16));
                }
                return  finalString.ToString();
                }
            }

        public static string testHex(){
            return "68744442";

        }
            static void Main(string[] args)
        {
            Console.WriteLine("Hi there");
            Console.WriteLine("Please input your hex code");
            string input = Console.ReadLine();
            Console.WriteLine(hextoASCII(input));
            Console.WriteLine(hextoASCII(testHex()));
        }

    }
        
        
        
