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

        //[Test]
        //public void AnalyzeTriangle_Input60_60_60_OutputEquilateralTriangle()
        //{
        //    // Arrange
        //    int firstSide = 60;
        //    int secondSide = 60;
        //    int thirdSide = 60;

        //    // Act

        //    // Assert
        //}

        //[Test]
        //public void AnalyzeTriangle_Input60_60_60_OutputEquilateralTriangle()
        //{
        //    // Arrange
        //    int firstSide = 60;
        //    int secondSide = 60;
        //    int thirdSide = 60;

        //    // Act

        //    // Assert
        //}

        //[Test]
        //public void AnalyzeTriangle_Input60_60_60_OutputEquilateralTriangle()
        //{
        //    // Arrange
        //    int firstSide = 60;
        //    int secondSide = 60;
        //    int thirdSide = 60;

        //    // Act

        //    // Assert
        //}

        //[Test]
        //public void AnalyzeTriangle_Input60_60_60_OutputEquilateralTriangle()
        //{
        //    // Arrange
        //    int firstSide = 60;
        //    int secondSide = 60;
        //    int thirdSide = 60;

        //    // Act

        //    // Assert
        //}

        //[Test]
        //public void AnalyzeTriangle_Input60_60_60_OutputEquilateralTriangle()
        //{
        //    // Arrange
        //    int firstSide = 60;
        //    int secondSide = 60;
        //    int thirdSide = 60;

        //    // Act

        //    // Assert
        //}

        //[Test]
        //public void AnalyzeTriangle_Input60_60_60_OutputEquilateralTriangle()
        //{
        //    // Arrange
        //    int firstSide = 60;
        //    int secondSide = 60;
        //    int thirdSide = 60;

        //    // Act

        //    // Assert
        //}

        //[Test]
        //public void AnalyzeTriangle_Input60_60_60_OutputEquilateralTriangle()
        //{
        //    // Arrange
        //    int firstSide = 60;
        //    int secondSide = 60;
        //    int thirdSide = 60;

        //    // Act

        //    // Assert
        //}

        //[Test]
        //public void AnalyzeTriangle_Input60_60_60_OutputEquilateralTriangle()
        //{
        //    // Arrange
        //    int firstSide = 60;
        //    int secondSide = 60;
        //    int thirdSide = 60;

        //    // Act

        //    // Assert
        //}

        //[Test]
        //public void AnalyzeTriangle_Input60_60_60_OutputEquilateralTriangle()
        //{
        //    // Arrange
        //    int firstSide = 60;
        //    int secondSide = 60;
        //    int thirdSide = 60;

        //    // Act

        //    // Assert
        //}

        //[Test]
        //public void AnalyzeTriangle_Input60_60_60_OutputEquilateralTriangle()
        //{
        //    // Arrange
        //    int firstSide = 60;
        //    int secondSide = 60;
        //    int thirdSide = 60;

        //    // Act

        //    // Assert
        //}

        //[Test]
        //public void AnalyzeTriangle_Input60_60_60_OutputEquilateralTriangle()
        //{
        //    // Arrange
        //    int firstSide = 60;
        //    int secondSide = 60;
        //    int thirdSide = 60;

        //    // Act

        //    // Assert
        //}
    }
}
