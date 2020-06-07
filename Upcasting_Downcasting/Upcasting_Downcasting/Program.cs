using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Upcasting_Downcasting
{
    class Program
    {
        static void Main(string[] args)
        {
            /*          // upcasting: conversion from a derived class to a base class
                        // downcasting: conversion from a base class to a derived class
                        Text text = new Text();
                        Shape shape = text; // both are pointing to same object in memory

                        text.Width = 200;
                        shape.Width = 100;

                        Console.WriteLine("Width of text: " + text.Width); // outputs 100*/

            /*StreamReader reader = new StreamReader(new MemoryStream())*/

            /*            var list = new ArrayList();
                        list.Add(1);
                        list.Add("Britt");
                        list.Add(new Text());

                        var anotherList = new List<Shape>();*/

            Shape shape = new Text();
            Text text = (Text)shape;


        }
    }
}
