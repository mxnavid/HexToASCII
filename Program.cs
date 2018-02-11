/**
Name: Mohammed Nafiuzzaman
Mail: mxn4459@rit.edu
Description: A simple hex to ASCII converter in C#.
 */

using System;
using System.Text;

    class Program{
     
        /**
        hextoASCII is the method that converts the Hexadecimal String 
        to ASCII Values.
        @input String hexString: String with the hexadecimal values.
        @return string: the method will return a converted ASCII String.
        */
        public static string hextoASCII(string hexString){
            if (String.IsNullOrWhiteSpace(hexString)){
                return "String is invalid.";
            }
            hexString = hexString.Replace(" ", "");
            hexString = hexString.Replace("-", "");
            if (hexString.Length %2 !=0){
                return "String is Incomplete. Please complete it.";
            }
            else{    
                var finalString = new StringBuilder();
                for (var i = 0; i < hexString.Length; i += 2) {
                    var hexCharac = hexString.Substring(i, 2);
                    finalString.Append((char)Convert.ToByte(hexCharac, 16));
                }
                return  finalString.ToString();
                }
            }

        /**
        Test Case to see whether the code is functioning in the right way.!--
        @return Hexadecimal of my name Mohammed Nafiuzzaman.
         */
        public static string testHex(){
            return "4d 6f 68 61 6d 6d 65 64 20 4e 61 66 69 75 7a 7a 61 6d 61 6e";

        }

        /**
        Main method which takes input from the user and prints out 
        the ASCII String.
         */
            static void Main(string[] args){
            Console.WriteLine("Hi there!");
            Console.WriteLine("Please input your hex:");
            string input = Console.ReadLine();
            Console.WriteLine(hextoASCII(input));
            //Console.WriteLine(hextoASCII(testHex()));
        }

    }
        
        
        
