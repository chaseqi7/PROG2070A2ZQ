using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070A2ZQ
{
    public class TriangleFinder
    {
        public string stringResult;
        int temp;
        public string Analyze(int a = 0, int b = 0,int c = 0)
        {
            if (b >= a)//put the numbers in decsending order
            {
                temp = a;
                a = b;
                b = temp;
            }
            if (c >= a)
            {
                temp = a;
                a = c;
                c = temp;
            }
            if (c >= b)
            {
                temp = b;
                b = c;
                c = temp;
            }
            stringResult += "Inputs are: "+ a +", "+ b + ", " + c + "(Descending).";//print the inputs
            if (c <= 0)//check the smallest number, if it's neg or 0
            {
                stringResult += "\nThere's a negative or 0 in the inputs so it will not form a triangle";
            }
            else if(a<(b+c))//test if three numbers will be a triangle
            {
                stringResult += "\nAnd it WILL form a triangle.";
                if (a != b && b != c)//check if every line is different
                {
                    stringResult += "\nAnd the triangle is scalene.";
                }
                else if (a == b || b == c)//check if there's two lines that are the same length
                {
                    if(a==c)//check if three lines' length are equal
                    {
                        stringResult += "\nAnd the triangle is equilateral.";
                    }
                    else
                    {
                        stringResult += "\nAnd the triangle is isosceles.";
                    }
                }
            }
            else
            {
                stringResult += "\nAnd it will NOT form a triangle because " + a + ">=" + b + "+" + c;
            }
            return stringResult;
        }
        public int a;
        public int b;
        public int c;
        public TriangleFinder()
        {
            a = 5;
            b = 6;
            c = 7;
        }
    }
}
