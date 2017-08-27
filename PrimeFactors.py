import unittest

class TestFactoring(unittest.TestCase):
    def test_suite(self):
        self.assertListEqual(PrimeFactors.Factor(1), [])

class PrimeFactors:
    def Factor(number):
        factors = []
        return factors
        
if __name__ == '__main__':
    unittest.main(verbosity=2)

