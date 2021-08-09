using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'caesarCipher' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER k
     */

    public static string caesarCipher(string s, int k)
    {
        int decimalConvert;
        int decimalConvertEncrypt;
        StringBuilder encryptedString = new StringBuilder();

        foreach (var item in s)
        {
            if(Char.IsLetter(item))
            {
                decimalConvert = (int)item;

                System.Console.WriteLine($"{item} = {decimalConvert}");

                if(decimalConvert >= 65 && decimalConvert <= 90)
                {
                    if (decimalConvert + k > 90)
                    {
                        decimalConvertEncrypt = (((Math.Abs(decimalConvert - 65)) + k) % 26) + 65;
                        encryptedString.Append((char)decimalConvertEncrypt);
                    }
                    else
                    {
                        decimalConvertEncrypt = decimalConvert + k;
                        encryptedString.Append((char)decimalConvertEncrypt);
                    }
                }
                else if ((decimalConvert >= 97 && decimalConvert <= 122))
                {
                    
                    if (decimalConvert + k > 122)
                    {
                        decimalConvertEncrypt = (((Math.Abs(decimalConvert - 97)) + k) % 26) + 97;
                        encryptedString.Append((char)decimalConvertEncrypt);
                    }
                    else
                    {
                        decimalConvertEncrypt = decimalConvert + k;
                        encryptedString.Append((char)decimalConvertEncrypt);
                    }
                }
            }
            else
            {
                encryptedString.Append(item);
            }
        }
        
        System.Console.WriteLine(s);
        System.Console.WriteLine(encryptedString.ToString());

        return encryptedString.ToString();
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        // int n = Convert.ToInt32(Console.ReadLine().Trim());
        int n = 11;

        // string s = Console.ReadLine();
        // string s = "abcdefghijklmnopqrstuvwxyz";
        // string s = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string s = "middle-Outz"; //okffng-Qwvb
        

        // int k = Convert.ToInt32(Console.ReadLine().Trim());
        int k = 2;

        string result = Result.caesarCipher(s, k);

        // textWriter.WriteLine(result);

        // textWriter.Flush();
        // textWriter.Close();
    }
}
