﻿using System;

namespace Arrays2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] lowercaseLetters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] uppercaseLetters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            string firstName = uppercaseLetters[4].ToString() + lowercaseLetters[12].ToString() + lowercaseLetters[4].ToString() + lowercaseLetters[17].ToString() + lowercaseLetters[24].ToString();
            Console.WriteLine(firstName);
        }
    }
}
