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

public void testNothing()
{
    Console.WriteLine("testNothing: " + (Assert.IsTrue(true) ? "Pass" : "FAIL"));
}

public void main() {
    testNothing();
    //testFizzBinn(expected, call);
}

main()