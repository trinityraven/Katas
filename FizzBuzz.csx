using System;

public class Assert {
    public static bool IsTrue(bool test)
    {
            return true == test;
    }
    
    public static bool AreEqual<T>(T expected, T actual) {
        return expected.Equals(actual);
    }
}

class Fizz {
    public static string Say(int number) {
        string result = number.ToString();
        return DetermineSay(result, number, 3, "Fizz");   
    }
    
    public static string DetermineSay(string result, int number, int factor, string word)
    {
        if (ResultIsNumber(result, number) && NumberIsDivisibleByFactor(number, factor))
            result = word;
        else if (ResultNotIsNumber(result, number) && NumberIsDivisibleByFactor(number, factor))
            result += word;
        
        return result;
    }
        
    public static bool NumberIsDivisibleByFactor(int number, int factor)
    {
        return number % factor == 0;
    }
    
    public static bool ResultIsNumber(string result, int number)
    {
        return result == number.ToString();
    }
    
    public static bool ResultNotIsNumber(string result, int number)
    {
        return !ResultIsNumber(result, number);
    }
}

class FizzBuzz : Fizz {
    public static new string Say(int number) {
        string result = Fizz.Say(number);
        result = DetermineSay(result, number, 5, "Buzz"); 
        return result;
    }
}

class FizzBuzzPop : FizzBuzz {
    public static new string Say(int number) {
        string result = FizzBuzz.Say(number);
        result = DetermineSay(result, number, 7, "Pop");
        return result;
    }
}

public void main() {
    testNothing();
    testFizz("1", 1);
    testFizzBuzzPop("1", 1);
    testFizz("2", 2);
    testFizz("Fizz", 3);
    testFizz("4", 4);
    testFizzBuzz("4", 4);
    testFizz("5", 5);
    testFizzBuzz("Buzz", 5);
    testFizz("Fizz", 6);
    testFizzBuzz("Fizz", 6);
    testFizz("7", 7);
    testFizzBuzz("7", 7);
    testFizzBuzzPop("Pop", 7);
    testFizz("10", 10);
    testFizzBuzz("Buzz", 10);
    testFizz("Fizz", 15);
    testFizzBuzz("FizzBuzz", 15);
    testFizzBuzzPop("FizzBuzz", 15);
    testFizzBuzzPop("FizzPop", 21);
    testFizzBuzzPop("BuzzPop", 35);
    testFizzBuzzPop("FizzBuzzPop", 105);
}

main();

public void testNothing()
{
    Console.WriteLine("testNothing: " + (Assert.IsTrue(true) ? "Pass" : "Fail"));
}

public void testFizz(string expected, int number) {
    string actual = Fizz.Say(number);
    string result = Assert.AreEqual(expected, actual) ? "Pass" : "FAIL";
    Console.WriteLine($"Fizz: {number}: \"{actual}\" | {result}");
}

public void testFizzBuzz(string expected, int number) {
    string actual = FizzBuzz.Say(number);
    string result = Assert.AreEqual(expected, actual) ? "Pass" : "FAIL";
    Console.WriteLine($"FizzBuzz: {number}: \"{actual}\" | {result}");
}

public void testFizzBuzzPop(string expected, int number) {
    string actual = FizzBuzzPop.Say(number);
    string result = Assert.AreEqual(expected, actual) ? "Pass" : "FAIL";
    Console.WriteLine($"FizzBuzzPop: {number}: \"{actual}\" | {result}");
}