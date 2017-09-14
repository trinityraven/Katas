<?php
class Assert {
	public static function IsTrue($test) {
		return (true == $test);
	}

	public static function IsFalse($test) {
		return (false == $test);
	}

	public static function AreEqual($expected, $actual) {
		return ($expected == $actual);
	}

	public static function AreNotEqual($expected, $actual) {
		return ($expected != $actual);
	}
}

class TestSuite {
	public static function run() {
		self::testNothing();
		self::testIsTrue();
		self::testIsFalse();
		self::testAreEqual();
		self::testAreNotEqual();
	}

	private static function testNothing() {
		self::printTest(__METHOD__, Assert::IsTrue(true));
	}

	private static function testIsTrue() {
		self::printTest(__METHOD__, Assert::IsTrue(true));
	}

	private static function testIsFalse() {
		self::printTest(__METHOD__, Assert::IsFalse(false));
	}

	private static function testAreEqual() {
		self::printTest(__METHOD__ . " - String", Assert::AreEqual("A", "A"));
		self::printTest(__METHOD__ . " - Int", Assert::AreEqual("1", "1"));
		self::printTest(__METHOD__ . " - Float", Assert::AreEqual(1.2, 1.2));
		self::printTest(__METHOD__ . " - Array", Assert::AreEqual([1, 2, 3], [1, 2, 3]));
	}

	private static function testAreNotEqual() {
		self::printTest(__METHOD__ . " - String", Assert::AreNotEqual("A", "B"));
		self::printTest(__METHOD__ . " - Int", Assert::AreNotEqual("1", "2"));
		self::printTest(__METHOD__ . " - Float", Assert::AreNotEqual(1.1, 1.2));
		self::printTest(__METHOD__ . " - Array", Assert::AreNotEqual([1, 2, 3], [3, 2, 1]));
	}

	private static function preparePrettyPrintTestResult($test) {
		return (test ? "pass" : "FAIL");
	}

	private static function printTest($testName, $testResult) {
		$result = self::preparePrettyPrintTestResult($testResult);
		echo("{$testName} -> {$result}<br />\n");
	}
}

TestSuite::run();

?>