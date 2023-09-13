using ChessMazeLevelDesigner;

namespace test
{
    [TestClass]
    public class CreateLevelTests
    {
        [TestMethod]
        //Tests if exception is thrown when width and height are less than 3
        public void TestMethod1()
        {
            var le = new LevelEditor();

            
            void createLevelAction() => le.CreateLevel(2, 5);

           
            var exception = Assert.ThrowsException<ArgumentException>(createLevelAction);
            Assert.AreEqual("Width and height must be above 3", exception.Message);
        }

        [TestMethod]
        // Tests if exception is thrown when width and height are greater than 10
        public void TestMethod2()
        {
            var le = new LevelEditor();

            
            void createLevelAction() => le.CreateLevel(11, 5);

            
            var exception = Assert.ThrowsException<ArgumentException>(createLevelAction);
            Assert.AreEqual("Width and height must be less than 10", exception.Message);
        }

        [TestMethod]

        // Tests if exception is thrown when width and height are not equal but above 3 and less than 10
        public void TestMethod3()
        {
            var le = new LevelEditor();

            void createLevelAction() => le.CreateLevel(4, 5);

            var exception = Assert.ThrowsException<ArgumentException>(createLevelAction);
            Assert.AreEqual("Width and height must be equal", exception.Message);
        }

        [TestMethod]
        // tests that overloading works correctly with a name parameter
        public void TestMethod4()
        {
            var le = new LevelEditor();
            le.CreateLevel("Test", 5, 5);

            Assert.AreEqual("Test", le.CurrentLevel.Name);
        }

        [TestMethod]
        //Tests if the board is initialized correctly and the AddEmpty method works
        public void TestMethod5()
        {
            var le = new LevelEditor();
            le.CreateLevel(5, 5);

            for(int row = 0; row < le.CurrentLevel.Width; row++)
            {
                for(int column = 0; column < le.CurrentLevel.Height; column++)
                {
                    Assert.AreEqual(Part.Empty, le.CurrentLevel.CurrentBoard.GetPart(row, column));
                    
                }
            }

            
        }
       


    }
        
}