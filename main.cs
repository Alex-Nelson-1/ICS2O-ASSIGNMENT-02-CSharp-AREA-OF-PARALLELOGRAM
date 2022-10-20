// Created by: Alex Nelson
// Created on: Oct 2022
//
// This program calculates the area of parallelograms
using System;

class Program
{
    public static void Main(string[] args)
    {
        int length;
        int width;
        int area;
        Console.WriteLine("This program calculates the area of parallelograms");
        Console.WriteLine("");
        //Input
        Console.WriteLine("Enter your parallelograms length");
        length = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your parallelograms width");
        width = Convert.ToInt32(Console.ReadLine());
        //Process
        area = length * width;
        //Output
        Console.WriteLine("The area of your parallelogram is: " + area + " cm²");
        Console.WriteLine("\nDone");
    }
}