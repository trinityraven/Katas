/*
Roman Numerals Notes

I = 1
V = 5
X = 10
L = 50
C = 100
D = 500
M = 1000

1 = I
2 = II
3 = III
4 = IV
5 = V
6 = VI
7 = VII
8 = VIII
9 = IX
10 = X
38 = XXXVIII
39 = XXXIX
40 = XL
41 = XLI
44 = XLIV
49 = IL or XLIX
50 = L
90 = XC
1978 = MCMLXXVIII

*/

using System;

public class Assert {
    public static bool AreEqual<T>(T expected, T actual) 
    {
        if (expected.Equals(actual))
            return true;
        else
            return false;
    }
    
    public static bool IsTrue(bool value) 
    {
        return (value == true);
    }
    
    public static bool IsFalse(bool value) 
    {
        return (value == false);
    }
}

public class RomanNumerals {
    private static bool debug = false;
    
    private static int POSITIONAL_ONE = 1;
    private static int POSITIONAL_FIVE = 5;
    private static int POSITIONAL_TEN = 10;
    private static int POSITIONAL_FIFTY = 50;
    private static int POSITIONAL_HUNDRED = 100;
    private static int POSITIONAL_FIVE_HUNDRED = 500;
    private static int POSITIONAL_THOUSAND = 1000;
    
    private static string ROMAN_ONE = "I";
    private static string ROMAN_FIVE = "V";
    
    public static string convertFromPositionalValue(int positionalValue) {
        int workingValue = positionalValue;
        string result = "";
        
        while (workingValue >= POSITIONAL_THOUSAND) {
            result += "M";
            workingValue -= POSITIONAL_THOUSAND;    
        }
        
        if (workingValue >= POSITIONAL_FIVE_HUNDRED) {
            result += "D";
            workingValue -= POSITIONAL_FIVE_HUNDRED;
        }
        
        while (workingValue >= POSITIONAL_HUNDRED) {
            result += "C";
            workingValue -= POSITIONAL_HUNDRED;
        }

        if (workingValue >= POSITIONAL_FIFTY) {
            result += "L";
            workingValue -= POSITIONAL_FIFTY;
        } 

        while (workingValue >= POSITIONAL_TEN)
        {
            result += "X";
            workingValue -= POSITIONAL_TEN;
            printProgress(workingValue, result);
        }

        if (workingValue >= POSITIONAL_FIVE) {
            result += ROMAN_FIVE;
            workingValue -= POSITIONAL_FIVE;
            printProgress(workingValue, result);
        }

        while (workingValue >= POSITIONAL_ONE) 
        {
            result += ROMAN_ONE;
            workingValue -= POSITIONAL_ONE;
            printProgress(workingValue, result);
        }
        
        return result;    
    }
    
    public static void printProgress(int working, string result) {
        if (debug) Console.WriteLine($"w {working}, r {result}");
    }
    
}

void executeTest(int positional, string roman) {
    string actual = RomanNumerals.convertFromPositionalValue(positional);
    Console.WriteLine($"{positional} is '{actual}' | {(Assert.AreEqual(roman, actual) ? "PASS" : "FAIL")}");
}

void main() {
    Console.WriteLine($"Tests run: {Assert.IsTrue(true)}");
    executeTest(1, "I");
    executeTest(2, "II");
    executeTest(3, "III");
    executeTest(4, "IV");
    executeTest(5, "V");
    executeTest(6, "VI");
    executeTest(7, "VII");
    executeTest(8, "VIII");
    executeTest(9, "IX");
    executeTest(10, "X");
    executeTest(20, "XX");
    executeTest(38, "XXXVIII");
    executeTest(39, "XXXIX");
    executeTest(40, "XL");
    executeTest(41, "XLI");
    executeTest(44, "XLIV");
    executeTest(49, "XLIX");
    executeTest(50, "L");
    executeTest(90, "XC");
    executeTest(100, "C");
    executeTest(200, "CC");
    executeTest(400, "XD");
    executeTest(500, "D");
    executeTest(900, "CM");
    executeTest(1000, "M");
    executeTest(1978, "MCMLXXVIII");
    executeTest(1988, "MCMLXXXVIII");
    executeTest(2000, "MM");
    executeTest(2010, "MMX");
    executeTest(3999, "MMMXMXCIX");
}

main();


