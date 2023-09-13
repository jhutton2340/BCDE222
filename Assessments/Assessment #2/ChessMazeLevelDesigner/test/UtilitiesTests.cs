using LevelDesignNS;

namespace test
{
    [TestClass]
    public class UtilitiesTests
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

        [TestMethod]
        //Tests if the SetStart method in the Board class, and SetStartLocation method in the levelEditor class, sets the correct tile to IsStart = true
        public void TestMethod3()
        {
            var le = new LevelEditor();
            le.CreateLevel("Test", 5, 5);
            le.AddBishop(0, 0);
            le.SetStartLocation(0, 0);

            Assert.AreEqual(true, le.CurrentLevel.CurrentBoard.CurrentTiles[0,0].IsStart);
        }

        [TestMethod]
        //Tests that there is only ever 1 or 0 start locations. Also tests that the startlocation is set to the newest tile that is set to IsStart = true
        public void TestMethod4()
        {
            var le = new LevelEditor();
            le.CreateLevel("Test", 5, 5);
            le.AddBishop(0, 0);
            le.AddKnight(1, 1);
            le.SetStartLocation(0, 0);
            le.SetStartLocation(1, 1);

            var startCount = 0;

            foreach(Tile tile in le.CurrentLevel.CurrentBoard.CurrentTiles)
            {
                if (tile.IsStart)
                {
                    startCount++;
                }
                
            }
            Assert.AreEqual(1, startCount);
            Assert.AreEqual(true, le.CurrentLevel.CurrentBoard.CurrentTiles[1, 1].IsStart);
        }

        [TestMethod]
        //Tests if the SetEnd method in the Board class, and SetEndLocation method in the levelEditor class, sets the correct tile to IsEndLocation = true
        public void TestMethod5()
        {
            var le = new LevelEditor();
            le.CreateLevel("Test", 5, 5);
            le.AddBishop(0, 0);
            le.SetEndLocation(0, 0);

            Assert.AreEqual(true, le.CurrentLevel.CurrentBoard.CurrentTiles[0, 0].IsEndLocation);
        }
        [TestMethod]
        //Tests that there is only ever 1 or 0 end locations. Also tests that the end location is set to the newest tile that is set to IsEndLocation = true
        public void TestMethod6()
        {
            var le = new LevelEditor();
            le.CreateLevel("Test", 5, 5);
            le.AddBishop(0, 0);
            le.AddKnight(1, 1);
            le.SetEndLocation(0, 0);
            le.SetEndLocation(1, 1);

            var endCount = 0;

            foreach (Tile tile in le.CurrentLevel.CurrentBoard.CurrentTiles)
            {
                if (tile.IsEndLocation)
                {
                    endCount++;
                }

            }
            Assert.AreEqual(1, endCount);
            Assert.AreEqual(true, le.CurrentLevel.CurrentBoard.CurrentTiles[1, 1].IsEndLocation);
        }

        [TestMethod]
        //Tests if the CheckValid method works correctly
        public void TestMethod7()
        {
            var le = new LevelEditor();
            le.CreateLevel("Test", 5, 5);
            le.AddBishop(0, 0);
            le.AddKnight(1, 1);
            le.SetStartLocation(0, 0);
            le.SetEndLocation(1, 1);

            Assert.AreEqual(true, le.CheckValid());
        }

        [TestMethod]
        //Tests if the ResetBoard method works correctly
        public void TestMethod8()
        {
            var le = new LevelEditor();
            le.CreateLevel("Test", 5, 5);
            le.AddBishop(0, 0);
            le.AddKnight(1, 1);
            le.SetStartLocation(0, 0);
            le.SetEndLocation(1, 1);
            le.AddPlayerOnBishop(0, 0);

            le.ResetBoard();
            foreach (Tile tile in le.CurrentLevel.CurrentBoard.CurrentTiles)
            {
                Assert.AreEqual(false, tile.IsStart);
                Assert.AreEqual(false, tile.IsEndLocation);
                Assert.AreEqual(Part.Empty, tile.CurrentPart);
                Assert.AreEqual(PartColour.Null, tile.PartColour);
            }


        }
    }
}