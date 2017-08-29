import unittest

class TestFactoring(unittest.TestCase):
    def test_one(self):
        self.assertListEqual(PrimeFactors.Factor(1), [])
    def test_two(self):
        self.assertListEqual(PrimeFactors.Factor(2), [2])
    def test_three(self):
        self.assertListEqual(PrimeFactors.Factor(3), [3])
    def test_four(self):
        self.assertListEqual(PrimeFactors.Factor(4), [2, 2])
    def test_five(self):
        self.assertListEqual(PrimeFactors.Factor(5), [5])
    def test_six(self):
        self.assertListEqual(PrimeFactors.Factor(6), [2, 3])
    def test_seven(self):
        self.assertListEqual(PrimeFactors.Factor(7), [7])
    def test_eight(self):
        self.assertListEqual(PrimeFactors.Factor(8), [2, 2, 2])
    def test_169(self):
        self.assertListEqual(PrimeFactors.Factor(169), [13, 13])

class PrimeFactors:
    def Factor(number):
        remainder = number
        factor = 2
        factors = []

        while remainder > 1:
            while (remainder % factor) == 0:
                remainder = remainder // factor
                factors.append(factor)
            factor += 1

        return factors

if __name__ == '__main__':
    unittest.main(verbosity=2)

