using System;

//Problem 1. Declare Variables

//    Declare five variables choosing for each of them the most appropriate of the types 
//    byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 
//        52130, -115, 4825932, 97, -10000.
//    Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.

public class Declarations
{
    public static void Main()
    {

        byte byteVar = 97;          //2^8
        sbyte sbyteVar = -115;      //2^8 +-
        //short goes here
        ushort ushortVar = 52130;   //16-bit (2^15) unsigned
        int intVar = -10000;        //32-bit int
        uint uintVar = 4825932;     //32-bit signed int
        //long goes here
        //ulong goes here
        

        //extras
        short shortVar = 32767;                        //16-bit signed
        long longVar = -9223372036854775808;           //64-bit signed 2^64
        ulong ulongVar = 18446744073709551615;         //64-bit unsigned

        Console.WriteLine("byteVar   = {0}", byteVar);
        Console.WriteLine("sbyteVar  = {0}", sbyteVar);
        Console.WriteLine("ushortVar = {0}", ushortVar);
        Console.WriteLine("intVar    = {0}", intVar);
        Console.WriteLine("uintVar   = {0}", uintVar);
        Console.WriteLine("shortVar  = {0}", shortVar);
        Console.WriteLine("longVar   = {0}", longVar);
        Console.WriteLine("ulongVar  = {0}", ulongVar);

    }
}