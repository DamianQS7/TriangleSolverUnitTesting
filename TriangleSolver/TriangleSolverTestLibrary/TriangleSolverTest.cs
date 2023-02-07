using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TriangleSolver;


namespace TriangleSolverTestLibrary
{
    [TestFixture]
    public class TriangleSolverTest
    {
        [Test]
        public void AnalyzeTriangle_Input60_60_60_OutputEquilateralTriangle()
        {
            // Arrange
            Triangle triangle = new Triangle();
            int firstSide = 60;
            int secondSide = 60;
            int thirdSide = 60;

            string expected = "Based on all sides being equal, the type of triangle is an EQUILATERAL";

            // Act
            string actual = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.IsTrue(expected.Equals(actual));
        }

        [Test]
        public void AnalyzeTriangle_Input50_50_80_OutputIsoscelesTriangle()
        {
            // Arrange
            Triangle triangle = new Triangle();

            int firstSide = 50;
            int secondSide = 50;
            int thirdSide = 80;

            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";

            // Act
            string actual = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.IsTrue(expected.Equals(actual));
        }

        [Test]
        public void AnalyzeTriangle_Input70_55_55_OutputIsoscelesTriangle()
        {
            // Arrange
            Triangle triangle = new Triangle();

            int firstSide = 70;
            int secondSide = 55;
            int thirdSide = 55;

            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";

            // Act
            string actual = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.IsTrue(expected.Equals(actual));
        }

        [Test]
        public void AnalyzeTriangle_Input50_90_50_OutputIsoscelesTriangle()
        {
            // Arrange
            Triangle triangle = new Triangle();

            int firstSide = 50;
            int secondSide = 80;
            int thirdSide = 50;

            string expected = "Based on two sides being equal, the type of triangle is an ISOSCELES";

            // Act
            string actual = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.IsTrue(expected.Equals(actual));
        }

        [Test]
        public void AnalyzeTriangle_Input50_60_70_OutputScaleneTriangle()
        {
            // Arrange
            Triangle triangle = new Triangle();

            int firstSide = 50;
            int secondSide = 60;
            int thirdSide = 70;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            // Act
            string actual = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_Input50_70_90_OutputScaleneTriangle()
        {
            // Arrange
            Triangle triangle = new Triangle();

            int firstSide = 50;
            int secondSide = 70;
            int thirdSide = 90;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            // Act
            string actual = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_Input40_70_100_OutputScaleneTriangle()
        {
            // Arrange
            Triangle triangle = new Triangle();

            int firstSide = 40;
            int secondSide = 70;
            int thirdSide = 100;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            // Act
            string actual = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_Input1_2_3_OutputScaleneTriangle()
        {
            // Arrange
            Triangle triangle = new Triangle();

            int firstSide = 2;
            int secondSide = 3;
            int thirdSide = 4;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            // Act
            string actual = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_Input2000_3000_4000_OutputScaleneTriangle()
        {
            // Arrange
            Triangle triangle = new Triangle();

            int firstSide = 2000;
            int secondSide = 3000;
            int thirdSide = 4000;

            string expected = "Based on all three sides being different, the type of triangle is a SCALENE";

            // Act
            string actual = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_Input0_3_4_OutputZeroLengthSideIdentified()
        {
            // Arrange
            Triangle triangle = new Triangle();

            int firstSide = 0;
            int secondSide = 3;
            int thirdSide = 4;

            string expected = "At least one side of your triangle has a zero length and is thus invalid";

            // Act
            string actual = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_Input0_0_4_OutputZeroLengthSideIdentified()
        {
            // Arrange
            Triangle triangle = new Triangle();

            int firstSide = 0;
            int secondSide = 0;
            int thirdSide = 4;

            string expected = "At least one side of your triangle has a zero length and is thus invalid";

            // Act
            string actual = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AnalyzeTriangle_Input0_0_0_OutputZeroLengthSideIdentified()
        {
            // Arrange
            Triangle triangle = new Triangle();

            int firstSide = 0;
            int secondSide = 0;
            int thirdSide = 0;

            string expected = "At least one side of your triangle has a zero length and is thus invalid";

            // Act
            string actual = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.AreEqual(expected, actual);
        }


    }
}
