
class Assert {
    public static func AreEqual<T: Equatable>(_ exp: T, _ act: T) -> Bool {
        return exp == act
    }
    
    public static func AreNotEqual<T: Equatable>(_ exp: T, _ act: T) -> Bool {
        return exp != act
    }
    
    public static func IsTrue(_ test: Bool) -> Bool {
        return true == test
    }
    
    public static func IsFalse(_ test: Bool) -> Bool {
        return false == test
    }
}

class Fizz {
    class public func Say(_ number: Int) -> String {
        var result = String(number)
        result = DetermineSay(result: result, number: number, factor: 3, word: "Fizz")
        return result
    }
    
    class public func DetermineSay(result: String, number: Int, factor: Int, word: String) -> String {
        var working = result
        if ResultIsNotNumber(result, number) && NumberIsDivisibleByFactor(number, factor) {
            working += word
        } else if NumberIsDivisibleByFactor(number, factor) {
            working = word
        }
        return working
    }
    
    public static func ResultIsNumber(_ result: String, _ number: Int) -> Bool {
        return result == String(number)
    }
    
    public static func ResultIsNotNumber(_ result: String, _ number: Int) -> Bool {
        return !ResultIsNumber(result, number)
    }
    
    public static func NumberIsDivisibleByFactor(_ number: Int, _ factor: Int) -> Bool {
        return number % factor == 0
    }
}

class FizzBuzz : Fizz {
    class public override func Say(_ number: Int) -> String {
        var result = Fizz.Say(number)
        result = DetermineSay(result: result, number: number, factor: 5, word: "Buzz")
        return result
    }
}

class FizzBuzzPop : FizzBuzz {
    class public override func Say(_ number: Int) -> String {
        var result = FizzBuzz.Say(number)
        result = DetermineSay(result: result, number: number, factor: 7, word: "Pop")
        return result
    }
}

func testNothing() -> Bool {
    return Assert.IsTrue(true);
} 

func testFizz(_ exp: String, _ act: Int) -> Bool {
    return Assert.AreEqual(exp, Fizz.Say(act))
} 

func testFizzBuzz(_ exp: String, _ act: Int) -> Bool {
    return Assert.AreEqual(exp, FizzBuzz.Say(act))
}

func testFizzBuzzPop(_ exp: String, _ act: Int) -> Bool {
    return Assert.AreEqual(exp, FizzBuzzPop.Say(act))
}

func runTests() {
    testNothing()
    testFizz("1", 1)
    testFizzBuzz("1", 1)
    testFizz("2", 2)
    testFizz("Fizz", 3)
    testFizz("5", 5)
    testFizz("Fizz", 6)
    testFizz("7", 7)
    testFizzBuzzPop("Pop", 7)
    testFizzBuzz("Fizz", 6)
    testFizzBuzz("Buzz", 5)
    testFizzBuzz("Buzz", 10)
    testFizzBuzz("FizzBuzz", 15)
    testFizzBuzzPop("FizzPop", 21)
    testFizzBuzzPop("BuzzPop", 35)
    testFizzBuzzPop("FizzBuzzPop", 105)
}

runTests()
