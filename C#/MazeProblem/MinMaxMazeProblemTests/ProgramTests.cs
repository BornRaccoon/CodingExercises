using Microsoft.VisualStudio.TestTools.UnitTesting;
using MinMaxMazeProblem;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxMazeProblem.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        public class ConsoleOutput : IDisposable
        {
            private StringWriter stringWriter;
            private TextWriter originalOutput;

            public ConsoleOutput()
            {
                stringWriter = new StringWriter();
                originalOutput = Console.Out;
                Console.SetOut(stringWriter);
            }

            public string GetOuput()
            {
                return stringWriter.ToString();
            }

            public void Dispose()
            {
                Console.SetOut(originalOutput);
                stringWriter.Dispose();
            }
        }

        [TestMethod()]
        public void testCorrectPathPrint()
        {
            var consoleOutput = new ConsoleOutput();
            string expectedOutput = "7" + "\t" + "11" + "\t" + "1" + "\t" + "12" + "\t" + "10" + "\t" + Environment.NewLine +
                                    "7" + "\t" + "11" + "\t" + "2" + "\t" + "12" + "\t" + "10" + "\t" + Environment.NewLine +
                                    "7" + "\t" + "11" + "\t" + "2" + "\t" + "43" + "\t" + "10" + "\t" + Environment.NewLine +
                                    "7" + "\t" + "9" +  "\t" + "2" + "\t" + "12" + "\t" + "10" + "\t" + Environment.NewLine +
                                    "7" + "\t" + "9" +  "\t" + "2" + "\t" + "43" + "\t" + "10" + "\t" + Environment.NewLine +
                                    "7" + "\t" + "9" +  "\t" + "1" + "\t" + "43" + "\t" + "10" + "\t" + Environment.NewLine;
            List<int> path = new List<int>();
            int currentMaximum = 0;
            int x = 0, y = 0;
            int rowCount = 0, colCount = 0;
            int[,] m = {   { 7, 11, 1 },
                           { 9, 2, 12 },
                           { 1, 43, 10 }};

            rowCount = m.GetLength(0);
            colCount = m.GetLength(1);
            Program.possiblePaths(x, y, m, rowCount, colCount, currentMaximum, path);
            string actualOutput = consoleOutput.GetOuput();
            Assert.AreEqual(expectedOutput, actualOutput);
        }

        [TestMethod()]
        public void testCorrectMaximumReturned()
        {
            List<int> path = new List<int>();
            int currentMaximum = 0;
            int x = 0, y = 0;
            int rowCount = 0, colCount = 0;
            int[,] m = {   { 7, 11, 1 },
                           { 9, 2, 12 },
                           { 1, 43, 10 }};

            rowCount = m.GetLength(0);
            colCount = m.GetLength(1);
            int actualMaximum = Program.possiblePaths(x, y, m, rowCount, colCount, currentMaximum, path);
            int expectedMaximum = 2;
            Assert.AreEqual(expectedMaximum, actualMaximum);
        }

        [TestMethod()]
        public void testFailCaseMaximumReturned()
        {
            List<int> path = new List<int>();
            int currentMaximum = 0;
            int x = 0, y = 0;
            int rowCount = 0, colCount = 0;
            int[,] m = {   { 7, 11, 27 },
                           { 9, 50, 12 },
                           { 21, 43, 10 }};

            rowCount = m.GetLength(0);
            colCount = m.GetLength(1);
            int actualMaximum = Program.possiblePaths(x, y, m, rowCount, colCount, currentMaximum, path);
            int expectedMaximum = 2;
            Assert.AreNotEqual(expectedMaximum, actualMaximum);
        }

        [TestMethod()]
        public void testNewDataMaximumReturned()
        {
            List<int> path = new List<int>();
            int currentMaximum = 0;
            int x = 0, y = 0;
            int rowCount = 0, colCount = 0;
            int[,] m = {   { 40, 11, 27 },
                           { 9, 50, 12 },
                           { 21, 43, 100 }};

            rowCount = m.GetLength(0);
            colCount = m.GetLength(1);
            int actualMaximum = Program.possiblePaths(x, y, m, rowCount, colCount, currentMaximum, path);
            int expectedMaximum = 11;
            Assert.AreEqual(expectedMaximum, actualMaximum);
        }

        [TestMethod()]
        public void testBiggerMatrixMaximumReturned()
        {
            List<int> path = new List<int>();
            int currentMaximum = 0;
            int x = 0, y = 0;
            int rowCount = 0, colCount = 0;
            int[,] m = {   { 40, 110, 27, 31, 100, 2},
                           { 9, 50, 12, 88, 12, 21 },
                           { 4, 29, 110, 44, 12, 21 },
                           { 31, 60, 33, 88, 95, 21 },
                           { 23, 5, 12, 71, 12, 21 },
                           { 21, 43, 100, 8, 1, 65 }};

            rowCount = m.GetLength(0);
            colCount = m.GetLength(1);
            int actualMaximum = Program.possiblePaths(x, y, m, rowCount, colCount, currentMaximum, path);
            int expectedMaximum = 21;
            Assert.AreEqual(expectedMaximum, actualMaximum);
        }

        [TestMethod()]
        public void testSmallerMatrixMaximumReturned()
        {
            List<int> path = new List<int>();
            int currentMaximum = 0;
            int x = 0, y = 0;
            int rowCount = 0, colCount = 0;
            int[,] m = {   { 40, 11},
                           { 15, 43}};

            rowCount = m.GetLength(0);
            colCount = m.GetLength(1);
            int actualMaximum = Program.possiblePaths(x, y, m, rowCount, colCount, currentMaximum, path);
            int expectedMaximum = 15;
            Assert.AreEqual(expectedMaximum, actualMaximum);
        }
    }
}