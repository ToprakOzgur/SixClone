using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntegerRandomSeperator
{
    //ie: input =10=> output = 4,3,2,1 or 5,2,3...
    public static List<int> RandomlySeperate(int number)
    {
        List<int> numbers = new List<int>();

        var total = 0;

        //%33 probability for  5 
        if (UnityEngine.Random.Range(1, 4) < 2 && number > 5)
        {
            total = 5;
            numbers.Add(5);
        }

        while (total != 10)
        {
            var rndm = UnityEngine.Random.Range(1, number - total + 1);
            total += rndm;
            numbers.Add(rndm);
        }

        return numbers;
    }
}
