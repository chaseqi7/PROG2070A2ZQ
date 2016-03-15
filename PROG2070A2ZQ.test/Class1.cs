using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROG2070A2ZQ;
using NUnit.Framework;

namespace PROG2070A2ZQ.test
{
    public class Class1
    {

        [Test]
        public void TestAnalyze_Input5_5_5_ExpectEQU()
        {
            TriangleFinder testTri = new TriangleFinder();
            Assert.AreEqual("Inputs are: 5, 5, 5(Descending).\nAnd it WILL form a triangle.\nAnd the triangle is equilateral.", testTri.Analyze(5, 5, 5));
        }


        [Test]
        public void TestAnalyze_Input5_5_7_ExpectISO()
        {
            TriangleFinder testTri = new TriangleFinder();
            Assert.AreEqual("Inputs are: 7, 5, 5(Descending).\nAnd it WILL form a triangle.\nAnd the triangle is isosceles.", testTri.Analyze(5, 5, 7));
        }


        [Test]
        public void TestAnalyze_Input5_6_7_ExpectSCA()
        {
            TriangleFinder testTri = new TriangleFinder();
            Assert.AreEqual("Inputs are: 7, 6, 5(Descending).\nAnd it WILL form a triangle.\nAnd the triangle is scalene.", testTri.Analyze(5, 6, 7));
        }



        [Test]
        public void TestAnalyze_Input_5_6_7_ExpectNOT()
        {
            TriangleFinder testTri = new TriangleFinder();
            Assert.AreEqual("Inputs are: 7, 6, -5(Descending).\nThere's a negative or 0 in the inputs so it will not form a triangle", testTri.Analyze(-5, 6, 7));
        }

        [Test]
        public void TestAnalyze_Input0_6_7_ExpectNOT()
        {
            TriangleFinder testTri = new TriangleFinder();
            Assert.AreEqual("Inputs are: 7, 6, 0(Descending).\nThere's a negative or 0 in the inputs so it will not form a triangle", testTri.Analyze(0, 6, 7));
        }


        [Test]
        public void TestAnalyze_Input5_2_2_ExpectNOT()
        {
            TriangleFinder testTri = new TriangleFinder();
            Assert.AreEqual("Inputs are: 5, 2, 2(Descending).\nAnd it will NOT form a triangle because 5>=2+2", testTri.Analyze(5, 2, 2));
        }

        [Test]
        public void TestAnalyze_Input6_5_7_ExpectSCA()
        {
            TriangleFinder testTri = new TriangleFinder();
            Assert.AreEqual("Inputs are: 7, 6, 5(Descending).\nAnd it WILL form a triangle.\nAnd the triangle is scalene.", testTri.Analyze(6, 5, 7));
        }

        [Test]
        public void TestAnalyze_Input7_6_5_ExpectSCA()
        {
            TriangleFinder testTri = new TriangleFinder();
            Assert.AreEqual("Inputs are: 7, 6, 5(Descending).\nAnd it WILL form a triangle.\nAnd the triangle is scalene.", testTri.Analyze(7, 6, 5));
        }

        [Test]
        public void TestAnalyze_Input5_7_6_ExpectSCA()
        {
            TriangleFinder testTri = new TriangleFinder();
            Assert.AreEqual("Inputs are: 7, 6, 5(Descending).\nAnd it WILL form a triangle.\nAnd the triangle is scalene.", testTri.Analyze(5, 7, 6));
        }


    }
}
