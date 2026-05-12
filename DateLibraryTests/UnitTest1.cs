using DateLibrary;
using System.ComponentModel;

namespace DateLibraryTests
{
    
    public class UnitTest1
    {
        [Category("DateLib")]
        [Theory]
        [InlineData("dd-MM-yyyy")]
        [InlineData("hh-mm-ss tt")]
        public void DateTest(string format)
        {
            string result=DateLib.GetFormattedDate(format);    
            Assert.NotNull(result);
        }

        [Category("DateLib")]
        [Theory]
        [InlineData(10,20)]
        [InlineData(100,200)]
        public void RandomTest(int start,int end)
        {
            int result = DateLib.RandomNumber(start,end);
            Assert.IsType<int>(result);
        }
    }
}
