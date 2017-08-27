import unittest

class LearningTests(unittest.TestCase):
    
    def test_equal(self):
        self.assertEqual('FOO', 'foo'.upper())

    def test_true(self):
        self.assertTrue('FOO'.isupper())
    
    def test_false(self):
        self.assertFalse('FOO'.islower())
    
    @unittest.expectedFailure    
    def test_fail(self):
        self.assertTrue('FOO'.islower())
        
    def test_lists(self):
        self.assertListEqual([1, 2, 3], [1, 2, 3])
        
    def test_sets(self):
        self.assertSetEqual(set([1, 2, 3]), frozenset([3, 2, 1]))

if __name__ == '__main__':
    unittest.main(verbosity=2)
