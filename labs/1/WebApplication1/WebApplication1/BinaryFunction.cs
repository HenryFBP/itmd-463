using System;
using System.Collections.Generic;

namespace Lab1
{

    public static class BinaryFunctions
    {
        public static Dictionary<string, BinaryFunction> dict = new Dictionary<string, BinaryFunction>()
        {
            {"+", new BinaryFunction((l) => l[0] + l[1]) },
            {"-", new BinaryFunction((l) => l[0] - l[1]) },
            {"*", new BinaryFunction((l) => l[0] * l[1]) },
            {"/", new BinaryFunction((l) => l[0] / l[1]) },
            {"^", new BinaryFunction((l) => Math.Pow(l[0], l[1]))},
            {"%", new BinaryFunction((l) => l[0] % l[1]) },
            {"log", new BinaryFunction((l) => Math.Log(l[1], l[0]) )},
            {"concat", new BinaryFunction((l) => double.Parse(l[0].ToString() + l[1].ToString()))}
        };
    }

    public class BinaryFunction
    {
        public Func<double[], double> function = l => l[0] + l[1];

        public BinaryFunction(Func<double[], double> f)
        {
            function = f;
        }

        public double Calculate(double[] b)
        {
            return function(b);
        }
    }
}