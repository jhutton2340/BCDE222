using ChessMazeLevelDesigner;

namespace test
{
    [TestClass]
    public class GetWidthAndHeightTests
    {
        [TestMethod]
        //Tests if the getLevelWidth method returns the correct width
        public void TestMethod1()
        {
            var le = new LevelEditor();
            le.CreateLevel("Test", 5, 5);

            Assert.AreEqual(5, le.GetLevelWidth());
        }

        [TestMethod]
        //Tests if the getLevelHeight method returns the correct height
        public void TestMethod2()
        {
            var le = new LevelEditor();
            le.CreateLevel("Test", 5, 5);

            Assert.AreEqual(5, le.GetLevelHeight());
        }
    }
}