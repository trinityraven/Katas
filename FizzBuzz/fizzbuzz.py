import unittest

class FizzBuzzTests(unittest.TestCase):
	def test_value01(self):
		self.assertEqual(1, FizzBuzz.getValue(1))
	def test_value03(self):
		self.assertEqual('fizz', FizzBuzz.getValue(3))
	def test_value05(self):
		self.assertEqual('buzz', FizzBuzz.getValue(5))
	def test_value06(self):
		self.assertEqual('fizz', FizzBuzz.getValue(6))
	def test_value10(self):
		self.assertEqual('buzz', FizzBuzz.getValue(10))
	def test_value15(self):
		self.assertEqual('fizzbuzz', FizzBuzz.getValue(15))
	def test_value45(self):
		self.assertEqual('fizzbuzz', FizzBuzz.getValue(45))

class FizzBuzz:
	def getValue(i):
		result = ''
		if i % 3 == 0:
			result += 'fizz'
		if i % 5 == 0:
			result += 'buzz'
		if i % 3 != 0 and i % 5 != 0:
			result = i
		return result

class FizzBuzzPopTests(unittest.TestCase):
	def test_value01(self):
		self.assertEqual(1, FizzBuzzPop.getValue(1))
	def test_value03(self):
		self.assertEqual('fizz', FizzBuzzPop.getValue(3))
	def test_value05(self):
		self.assertEqual('buzz', FizzBuzzPop.getValue(5))
	def test_value06(self):
		self.assertEqual('fizz', FizzBuzzPop.getValue(6))
	def test_value07(self):
		self.assertEqual('pop', FizzBuzzPop.getValue(7))
	def test_value10(self):
		self.assertEqual('buzz', FizzBuzzPop.getValue(10))
	def test_value14(self):
		self.assertEqual('pop', FizzBuzzPop.getValue(14))
	def test_value15(self):
		self.assertEqual('fizzbuzz', FizzBuzzPop.getValue(15))
	def test_value21(self):
		self.assertEqual('fizzpop', FizzBuzzPop.getValue(21))
	def test_value35(self):
		self.assertEqual('buzzpop', FizzBuzzPop.getValue(35))
	def test_value45(self):
		self.assertEqual('fizzbuzz', FizzBuzzPop.getValue(45))

class FizzBuzzPop:
	def getValue(i):
		result = ''
		if i % 3 == 0:
			result += 'fizz'
		if i % 5 == 0:
			result += 'buzz'
		if i % 7 == 0:
			result += 'pop'
		if i % 3 != 0 and i % 5 != 0 and i % 7 != 0:
			result = i
		return result

class driver:
	def main():
		i = 1
		while i <= 100:
			print(FizzBuzz.getValue(i))
			i += 1

unittest.main(verbosity=2)
#driver.main()
