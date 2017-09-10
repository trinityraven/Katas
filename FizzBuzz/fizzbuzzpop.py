# Attempt at an extensible version of FizzBuzz/FizzBuzzPop

import unittest

class TestFizz(unittest.TestCase):
    def test_value_01(self):
        self.assertEqual(1, Fizz.getValue(1))
    def test_value_02(self):
        self.assertEqual(2, Fizz.getValue(2))
    def test_value_03(self):
        self.assertEqual('fizz', Fizz.getValue(3))
    def test_value_06(self):
        self.assertEqual('fizz', Fizz.getValue(6))
    def test_value_05(self):
        self.assertNotEqual('buzz', Fizz.getValue(5))
        self.assertEqual(5, Fizz.getValue(5))
    def test_value_10(self):
        self.assertNotEqual('buzz', Fizz.getValue(10))
        self.assertEqual(10, Fizz.getValue(10))
    def test_value_15(self):
        self.assertNotEqual('fizzbuzz', Fizz.getValue(15))
        self.assertEqual('fizz', Fizz.getValue(15))
    def test_value_30(self):
        self.assertNotEqual('fizzbuzz', Fizz.getValue(30))
        self.assertEqual('fizz', Fizz.getValue(30))

class TestFizzBuzz(unittest.TestCase):
    def test_value_05(self):
        self.assertEqual('buzz', FizzBuzz.getValue(5))
    def test_value_07(self):
        self.assertNotEqual('pop', FizzBuzz.getValue(7))
        self.assertEqual(7, FizzBuzz.getValue(7))
    def test_value_10(self):
        self.assertEqual('buzz', FizzBuzz.getValue(10))
    def test_value_14(self):
        self.assertNotEqual('pop', FizzBuzz.getValue(14))
        self.assertEqual(14, FizzBuzz.getValue(14))
    def test_value_15(self):
        self.assertEqual('fizzbuzz', FizzBuzz.getValue(15))
    def test_value_21(self):
        self.assertNotEqual('fizzpop', FizzBuzz.getValue(21))
        self.assertEqual('fizz', FizzBuzz.getValue(21))
    def test_value_30(self):
        self.assertEqual('fizzbuzz', FizzBuzz.getValue(30))
    def test_value_35(self):
        self.assertNotEqual('buzzpop', FizzBuzz.getValue(35))
        self.assertEqual('buzz', FizzBuzz.getValue(35))

class TestFizzBuzzPop(unittest.TestCase):
    def test_value_07(self):
        self.assertEqual('pop', FizzBuzzPop.getValue(7))
    def test_value_14(self):
        self.assertEqual('pop', FizzBuzzPop.getValue(14))
    def test_value_21(self):
        self.assertEqual('fizzpop', FizzBuzzPop.getValue(21))
    def test_value_35(self):
        self.assertEqual('buzzpop', FizzBuzzPop.getValue(35))
    def test_value_105(self):
        self.assertEqual('fizzbuzzpop', FizzBuzzPop.getValue(105))

class Fizz:
    def getValue(value):
        if (value % 3 == 0):
            return 'fizz'
        return value

class FizzBuzz(Fizz):
    def getValue(value):
        result = Fizz.getValue(value)
        if result != value and value % 5 == 0:
            result += 'buzz'
        elif value % 5 == 0:
            result = 'buzz'
        return result

class FizzBuzzPop(FizzBuzz):
    def getValue(value):
        result = FizzBuzz.getValue(value)
        if result != value and value % 7 == 0:
            result += 'pop'
        elif value % 7 == 0:
            result = 'pop'
        return result

unittest.main(verbosity=2)

i = 1
while i <= 105:
    print(FizzBuzzPop.getValue(i))
    i += 1
