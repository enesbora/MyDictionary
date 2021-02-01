using System;
using System.Collections;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> dictionary = new MyDictionary<string, string>();

            dictionary.Add("car", "araba");
            dictionary.Add("knife", "bicak");
            dictionary.Add("cat", "kedi");
            dictionary.Add("muz", "banana");
            dictionary.Items();
        }
    }
}
