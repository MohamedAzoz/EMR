namespace EMR.Test
{
    public class BMICalculaterTest
    {
        // All Methods Test Case To The Same Method 
        [Fact]
        public void CalculaterBMI_WhenHeightAndWeightAreGreaterThenZero_ShouldCalculaterBMICorrectly()
        {
            //Arrang
            var sut=new BMICalculater();

            //Act
            var result=Math.Round(sut.CalculaterBMI(1.75,90),2);

            //Assert
            Assert.Equal(29.39,result); 

        }
        [Fact]
        public void CalculaterBMI_WhenHeightAndWeightAreZeros_ShouldCalculaterBMICorrectly()
        {
            //Arrang
            var sut = new BMICalculater();

            //Act
            var result = Math.Round(sut.CalculaterBMI(0, 0), 2);

            //Assert
            Assert.Equal(0, result);

        }

        [Fact]
        public void CalculaterBMI_WhenHeightIsZeroAndWeightIsNotZero_ShouldCalculaterBMICorrectly()
        {
            //Arrang
            var sut=new BMICalculater();

            //Act
            var result=Math.Round(sut.CalculaterBMI(0,90),2);

            //Assert
            Assert.Equal(0,result); 

        }
        [Fact]
        public void CalculaterBMI_WhenHeightIsNotZeroAndWeightIsZero_ShouldCalculaterBMICorrectly()
        {
            //Arrang
            var sut=new BMICalculater();

            //Act
            var result=Math.Round(sut.CalculaterBMI(1.75,0),2);

            //Assert
            Assert.Equal(0,result); 

        }
    }
}