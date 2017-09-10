using System;
using System.Collections.Generic;
using System.Linq;

public class PrimeFactors {
    public static void main() {
        Console.WriteLine($"Factors of 1: {Print(FactorsOf(1))}");
        Console.WriteLine($"Factors of 2: {Print(FactorsOf(2))}");
        Console.WriteLine($"Factors of 3: {Print(FactorsOf(3))}");
        Console.WriteLine($"Factors of 4: {Print(FactorsOf(4))}");
        Console.WriteLine($"Factors of 5: {Print(FactorsOf(5))}");
        Console.WriteLine($"Factors of 6: {Print(FactorsOf(6))}");
        Console.WriteLine($"Factors of 7: {Print(FactorsOf(7))}");
        Console.WriteLine($"Factors of 8: {Print(FactorsOf(8))}");
        Console.WriteLine($"Factors of 9: {Print(FactorsOf(9))}");
        Console.WriteLine($"Factors of 10: {Print(FactorsOf(10))}");
        Console.WriteLine($"Factors of 125: {Print(FactorsOf(125))}");
    }
    
    public static bool AssertAreEqual<T>(T expected, T actual) where T : IEquatable<T> {
        return (expected.Equals(actual));
    }
    
    public static List<int> FactorsOf(int n) {
        List<int> factors = new List<int>();
        int remainder = n;
        int factor = 2;
        
        while (remainder > 1) {
            while (remainder % factor == 0) {
                    factors.Add(factor);
                    remainder /= factor;
            }
            factor++;
        }
        
        return factors;
    }

    public static string Print(List<int> list) {
        string str = "";
    
        if (list.Count > 0) {
            foreach (int item in list) { str += item + ", "; }
        }
        else 
        {
            str = "<empty>  ";
        }
    
        return str.Substring(0, str.Length-2);
    }
}

List<int> test = new List<int>();

PrimeFactors.main();