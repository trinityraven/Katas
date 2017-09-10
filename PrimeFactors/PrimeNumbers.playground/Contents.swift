
class Assert {
    public static func AreEqual<T: Equatable>(_ exp: T, _ act: T) -> Bool {
        return exp == act
    }
    
    public static func AreEqual(_ exp: [Int], _ act: [Int]) -> Bool {
        var result = AreEqual(exp.count, act.count)
        if result {
            for i in 0 ..< exp.count {
                if exp[i] != act[i] {
                    result = false
                    break
                }
            }
        }
        return result
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

class PrimeFactors {
    public static func of(_ number: Int) -> [Int] {
        var remainder = number
        var factors = [Int]()
        var factor = 2
        while remainder > 1 {
            while (remainder % factor == 0) {
                remainder /= factor
                factors.append(factor)
            }
            factor += 1
        }
        return factors
    }
}

func runTests() {
    let empty = [Int]()
    Assert.AreEqual(empty, PrimeFactors.of(1))
    Assert.AreEqual([2], PrimeFactors.of(2))
    Assert.AreEqual([3], PrimeFactors.of(3))
    Assert.AreEqual([2, 2], PrimeFactors.of(4))
    Assert.AreEqual([5], PrimeFactors.of(5))
    Assert.AreEqual([2, 3], PrimeFactors.of(6))
    Assert.AreEqual([2, 2, 2], PrimeFactors.of(8))
    Assert.AreEqual([2, 2, 2, 3, 3, 3, 5, 7, 11, 13], PrimeFactors.of(2*2*2*3*3*3*5*7*11*13))
}

runTests()
