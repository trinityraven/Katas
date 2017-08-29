# Attempt at an extensible version of FizzBuzz/FizzBuzzPop

import unittest

class TestFizz(unittest.TestCase):
    def test_value_01(self):
        self.assertEqual(1, Fizz.getValue(Fizz, 1))
    def test_value_02(self):
        self.assertEqual(2, Fizz.getValue(Fizz, 2))
    def test_value_03(self):
        self.assertEqual('fizz', Fizz.getValue(Fizz, 3))
    def test_value_06(self):
        self.assertEqual('fizz', Fizz.getValue(Fizz, 6))
    def test_value_05(self):
        self.assertNotEqual('buzz', Fizz.getValue(Fizz, 5))
        self.assertEqual(5, Fizz.getValue(Fizz, 5))
    def test_value_10(self):
        self.assertNotEqual('buzz', Fizz.getValue(Fizz, 10))
        self.assertEqual(10, Fizz.getValue(Fizz, 10))
    def test_value_15(self):
        self.assertNotEqual('fizzbuzz', Fizz.getValue(Fizz, 15))
        self.assertEqual('fizz', Fizz.getValue(Fizz, 15))
    def test_value_30(self):
        self.assertNotEqual('fizzbuzz', Fizz.getValue(Fizz, 30))
        self.assertEqual('fizz', Fizz.getValue(Fizz, 30))

class TestFizzBuzz(unittest.TestCase):
    def test_value_005(self):
        self.assertEqual('buzz', FizzBuzz.getValue(FizzBuzz, 5))
    def test_value_007(self):
        self.assertNotEqual('pop', FizzBuzz.getValue(FizzBuzz, 7))
        self.assertEqual(7, FizzBuzz.getValue(FizzBuzz, 7))
    def test_value_010(self):
        self.assertEqual('buzz', FizzBuzz.getValue(FizzBuzz, 10))
    def test_value_014(self):
        self.assertNotEqual('pop', FizzBuzz.getValue(FizzBuzz, 14))
        self.assertEqual(14, FizzBuzz.getValue(FizzBuzz, 14))
    def test_value_015(self):
        self.assertEqual('fizzbuzz', FizzBuzz.getValue(FizzBuzz, 15))
    def test_value_021(self):
        self.assertNotEqual('fizzpop', FizzBuzz.getValue(FizzBuzz, 21))
        self.assertEqual('fizz', FizzBuzz.getValue(FizzBuzz, 21))
    def test_value_030(self):
        self.assertEqual('fizzbuzz', FizzBuzz.getValue(FizzBuzz, 30))
    def test_value_035(self):
        self.assertNotEqual('buzzpop', FizzBuzz.getValue(FizzBuzz, 35))
        self.assertEqual('buzz', FizzBuzz.getValue(FizzBuzz, 35))
    def test_value_105(self):
        self.assertNotEqual('fizzbuzzpop', FizzBuzz.getValue(FizzBuzz, 105))
        self.assertEqual('fizzbuzz', FizzBuzz.getValue(FizzBuzz, 105))

class TestFizzBuzzPop(unittest.TestCase):
    def test_value_007(self):
        self.assertEqual('pop', FizzBuzzPop.getValue(FizzBuzzPop, 7))
    def test_value_014(self):
        self.assertEqual('pop', FizzBuzzPop.getValue(FizzBuzzPop, 14))
    def test_value_021(self):
        self.assertEqual('fizzpop', FizzBuzzPop.getValue(FizzBuzzPop, 21))
    def test_value_035(self):
        self.assertEqual('buzzpop', FizzBuzzPop.getValue(FizzBuzzPop, 35))
    def test_value_105(self):
        self.assertEqual('fizzbuzzpop', FizzBuzzPop.getValue(FizzBuzzPop, 105))

class Fizz:
    def getValue(self, value):
        return self.modifyValue(self, value)

    def modifyValue(self, value):
        result = value
        return self.substituteWordForFactorInResultForValue(self, 'fizz', 3, result, value)

    def substituteWordForFactorInResultForValue(self, word, factor, result, value):
        if self.resultIsValue(self, result, value) and self.isDivisibleByFactor(self, value, factor):
            result = word
        elif self.isDivisibleByFactor(self, value, factor):
            result += word
        return result

    def resultIsValue(self, result, value):
        return result == value

    def isDivisibleByFactor(self, value, factor):
        return value % factor == 0

class FizzBuzz(Fizz):
    def modifyValue(self, value):
        result = Fizz.getValue(Fizz, value)
        return self.substituteWordForFactorInResultForValue(self, 'buzz', 5, result, value)

class FizzBuzzPop(FizzBuzz):
    def modifyValue(self, value):
        result = FizzBuzz.getValue(FizzBuzz, value)
        return self.substituteWordForFactorInResultForValue(self, 'pop', 7, result, value)

unittest.main(verbosity=2)

i = 1
while i <= 105:
    print(FizzBuzzPop.getValue(FizzBuzzPop, i))
    i += 1
