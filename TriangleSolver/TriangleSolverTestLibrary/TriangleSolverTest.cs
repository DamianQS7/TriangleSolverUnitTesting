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

        //[Test]
        //public void AnalyzeTriangle_Input60_60_60_OutputEquilateralTriangle()
        //{
        //    // Arrange
        //    Triangle triangle = new Triangle();
        //    int firstSide = 60;
        //    int secondSide = 60;
        //    int thirdSide = 60;

        //    // Act
        //    string actual = triangle.AnalyzeTriangle(firstSide, secondSide, thirdSide);

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
