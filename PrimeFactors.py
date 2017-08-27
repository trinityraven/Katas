import unittest

class TestFactoring(unittest.TestCase):
    def test_suite(self):
        self.assertSetEqual(PrimeFactors.Factor(1), set())

class PrimeFactors:
    def Factor(number):
        factors = set()
        return factors
        
if __name__ == '__main__':
    unittest.main(verbosity=2)

