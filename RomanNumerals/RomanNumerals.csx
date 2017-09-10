/*
Roman Numerals Notes

I = 1
V = 5
X = 10
L = 50
C = 100
D = 500
M = 1000

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
    private static string ROMAN_TEN = "X";
    private static string ROMAN_FIFTY = "L";
    private static string ROMAN_HUDRED = "C";
    private static string ROMAN_FIVE_HUNDRED = "D";
    private static string ROMAN_THOUSAND = "M";
    
    private static string WRONG_ROMAN_FOUR = "IIII";
    private static string WRONG_ROMAN_NINE = "VIIII";
    private static string WRONG_ROMAN_FOURTY = "XXXX";
    private static string WRONG_ROMAN_NINETY = "LXXXX";
    private static string WRONG_ROMAN_FOUR_HUNDRED = "CCCC";
    private static string WRONG_ROMAN_NINE_HUNDRED = "DCCCC";
    
    private static string CORRECT_ROMAN_FOUR = "IV";
    private static string CORRECT_ROMAN_NINE = "IX";
    private static string CORRECT_ROMAN_FOURTY = "XL";
    private static string CORRECT_ROMAN_NINETY = "XC";
    private static string CORRECT_ROMAN_FOUR_HUNDRED = "CD";
    private static string CORRECT_ROMAN_NINE_HUNDRED = "CM";
    
    public static string convertFromPositionalValue(int positionalValue) {
        int workingValue = positionalValue;
        string result = "";
        
        while (workingValueHasA(workingValue, POSITIONAL_THOUSAND))
        {
            result += ROMAN_THOUSAND;
            workingValue -= POSITIONAL_THOUSAND;    
        }
        
        if (workingValueHasA(workingValue, POSITIONAL_FIVE_HUNDRED))
        {
            result += ROMAN_FIVE_HUNDRED;
            workingValue -= POSITIONAL_FIVE_HUNDRED;
        }
        
        while (workingValueHasA(workingValue, POSITIONAL_HUNDRED))
        {
            result += ROMAN_HUDRED;
            workingValue -= POSITIONAL_HUNDRED;
        }
        
        result = result.Replace(WRONG_ROMAN_NINE_HUNDRED, CORRECT_ROMAN_NINE_HUNDRED);
        result = result.Replace(WRONG_ROMAN_FOUR_HUNDRED, CORRECT_ROMAN_FOUR_HUNDRED);

        if (workingValueHasA(workingValue, POSITIONAL_FIFTY))
        {
            result += ROMAN_FIFTY;
            workingValue -= POSITIONAL_FIFTY;
        }
        
        while (workingValueHasA(workingValue, POSITIONAL_TEN))
        {
            result += ROMAN_TEN;
            workingValue -= POSITIONAL_TEN;
            printProgress(workingValue, result);
        }
        
        result = result.Replace(WRONG_ROMAN_NINETY, CORRECT_ROMAN_NINETY);
        result = result.Replace(WRONG_ROMAN_FOURTY, CORRECT_ROMAN_FOURTY);

        if (workingValueHasA(workingValue, POSITIONAL_FIVE))
        {
            result += ROMAN_FIVE;
            workingValue -= POSITIONAL_FIVE;
            printProgress(workingValue, result);
        }

        while (workingValueHasA(workingValue, POSITIONAL_ONE))
        {
            result += ROMAN_ONE;
            workingValue -= POSITIONAL_ONE;
            printProgress(workingValue, result);
        }
        
        result = result.Replace(WRONG_ROMAN_NINE, CORRECT_ROMAN_NINE);
        result = result.Replace(WRONG_ROMAN_FOUR, CORRECT_ROMAN_FOUR);
        
        return result;    
    }
    
    private static bool workingValueHasA(int workingValue, int positionalValue) {
        return workingValue >= positionalValue;
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
    executeTest(30, "XXX");
    executeTest(34, "XXXIV");
    executeTest(38, "XXXVIII");
    executeTest(39, "XXXIX");
    executeTest(40, "XL");
    executeTest(41, "XLI");
    executeTest(44, "XLIV");
    executeTest(49, "XLIX");
    executeTest(50, "L");
    executeTest(60, "LX");
    executeTest(70, "LXX");
    executeTest(80, "LXXX");
    executeTest(90, "XC");
    executeTest(100, "C");
    executeTest(101, "CI");
    executeTest(104, "CIV");
    executeTest(200, "CC");
    executeTest(300, "CCC");
    executeTest(400, "CD");
    executeTest(450, "CDL");
    executeTest(500, "D");
    executeTest(555, "DLV");
    executeTest(600, "DC");
    executeTest(700, "DCC");
    executeTest(800, "DCCC");
    executeTest(900, "CM");
    executeTest(1000, "M");
    executeTest(1948, "MCMXLVIII");
    executeTest(1954, "MCMLIV");
    executeTest(1978, "MCMLXXVIII");
    executeTest(1988, "MCMLXXXVIII");
    executeTest(2000, "MM");
    executeTest(2010, "MMX");
    executeTest(3000, "MMM");
    executeTest(3999, "MMMCMXCIX");
}

main();


