using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GJGZ.Temperatura.UnitTest.AppxUnit
{
    public class StringManipulatorTests
    {
        [Fact]
        public void ReverseString_ShouldReturnReversedString()
        {
            // Arrange

            StringManipulator stringManipulator = new StringManipulator();
            string input = "Hola Mundo";
            string expected = "odnuM aloH";

            // Act
            string result = stringManipulator.ReverseString(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void RemoveSpaces_ShouldReturnStringWithoutSpaces()
        {
            // Arrange
            StringManipulator stringManipulator = new StringManipulator();
            string input = "Hola Mundo";
            string expected = "HolaMundo";

            // Act
            string result = stringManipulator.RemoveSpaces(input);

            // Assert
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ReverseString_EmptyString_ShouldReturnEmptyString()
        {
            // Arrange
            StringManipulator stringManipulator = new StringManipulator();
            string input = "";
            string expected = "";

            // Act
            string result = stringManipulator.ReverseString(input);

            // Assert
            Assert.Equal(expected, result);
        }

    }
}
