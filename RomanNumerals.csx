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
    
    private static int ONE = 1;
    private static int FIVE = 5;
    private static int TEN = 10;
    //private static int FIFTY = 50;
    //private static int HUNDRED = 100;
    //private static int FIVE_HUNDRED = 500;
    //private static int THOUSAND = 1000;
    
    public static string convertFromPositionalValue(int positionalValue) {
        int workingValue = positionalValue;
        string result = "";
        
        while (workingValue >= TEN)
        {
            result += "X";
            workingValue -= TEN;
            printProgress(workingValue, result);
            if (result.EndsWith("XXXX"))
            {
                string prefix = "";
                if (result.Length>4)
                    prefix = result.Substring(0, result.LastIndexOf("XXXX")-1);
                    
                string addin = "";
                if (result.Contains("L"))
                    addin = "C";
                else
                    addin = "L";
                result = prefix + "X" + addin;
            }
        }
        if (workingValue >= FIVE) {
            result += "V";
            workingValue -= FIVE;
            printProgress(workingValue, result);
        }
        while (workingValue >= ONE) 
        {
            result += "I";
            workingValue -= ONE;
            printProgress(workingValue, result);
            if (result.EndsWith("IIII"))
            {
                string prefix = "";
                if (result.Length>4)
                    prefix = result.Substring(0, result.LastIndexOf("IIII")-1);
                
                string addin = "";
                if (result.Contains("V"))
                    addin = "X";
                else
                    addin = "V";
                result = prefix + "I" + addin;
            }
        }
        
        return result;    
    }
    
    public static void printProgress(int working, string result) {
        if (debug) Console.WriteLine($"w {working}, r {result}");
    }
    
}

void executeTest(int positional, string roman) {
    string actual = RomanNumerals.convertFromPositionalValue(positional);
    Console.WriteLine($"Test {positional} is '{actual}' | {(Assert.AreEqual(roman, actual) ? "PASS" : "FAIL")}");
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
    executeTest(38, "XXXVIII");
    executeTest(39, "XXXIX");
    executeTest(40, "XL");
    executeTest(41, "XLI");
    executeTest(49, "XLIX");
}

main();


