using System.Collections.Generic;

namespace _0924
{
    public class tupleString
    {

        string first = "";
        string last = "";

        public tupleString(string a, string b)
        {
            first = a;
            last = b;
        }
    }

    public class TemperatureSolverSingle
    {
        public TemperatureSolverSingle(string formula)
        {

        }
    }

    public class TemperatureSolver
    {
        public Dictionary<tupleString, object> dict;

        public TemperatureSolver()
        {
            dict = new Dictionary<tupleString, object>()
            {
                {new tupleString("c","f"), "F(x) = (x-32) * (5/9)" },
            };

        }

        public static float ctof(float c)
        {
            return (c * (9f / 5f) + 32);
        }

        public static float ftoc(float f)
        {
            return (f - 32) * (5f / 9f);
        }
    }
}