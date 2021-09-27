using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Fizzbuzz
{
    // A Test behaves as an ordinary method
    [Test]
    public void FizzbuzzSimplePasses()
    {
        int[] input = { 4, 3, 6, 30, 10, 12 };
        int[] output = FizzBuzz.CalculateFizzBuzz(input);
        int[] expected = { 4, 3, 3, 0, 5, 3 };

        CollectionAssert.AreEqual(expected, output);
    }
}
