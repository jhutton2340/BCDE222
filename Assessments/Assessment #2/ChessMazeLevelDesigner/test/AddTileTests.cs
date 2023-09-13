using ChessMazeLevelDesigner;
using System.Security.Cryptography.X509Certificates;

namespace test
{
    [TestClass]
    public class AddTileTests
    {
        [TestMethod]
        // Tests if an exemption is returned when the x and y coordinates are out of bounds for king
        public void TestMethod1()
        {
            var le = new LevelEditor();
            le.CreateLevel("Test", 5, 5);

            void addKingAction() => le.AddKing(5, 5);

            var exception = Assert.ThrowsException<IndexOutOfRangeException>(addKingAction);
            Assert.AreEqual("Index was outside the bounds of the array.", exception.Message);
        } 

        [TestMethod]
        // Tests if the AddKing method works correctly and adds a king to the board 
        public void TestMethod2()
        {
            var le = new LevelEditor();
            le.CreateLevel("Test", 5, 5);
            le.AddKing(0, 0);

            Assert.AreEqual(Part.King, le.GetPartAtIndex(0, 0));
            Assert.AreEqual(PartColour.Null, le.GetPartColourAtIndex(0, 0));
        }

        [TestMethod]
        // Tests if the AddKing method works when a colour is included
        public void TestMethod3()
        {
            var le = new LevelEditor();
            le.CreateLevel("Test", 5, 5);
            le.AddKing(0, 0, PartColour.Black);

            Assert.AreEqual(Part.King, le.GetPartAtIndex(0, 0));
            Assert.AreEqual(PartColour.Black, le.GetPartColourAtIndex(0, 0));
        }

        [TestMethod]
        // Tests if an exemption is returned when the x and y coordinates are out of bounds for rook

        public void TestMethod4()
        {
            var le = new LevelEditor();
            le.CreateLevel("Test", 5, 5);

            void addRookAction() => le.AddRook(5, 5);

            var exception = Assert.ThrowsException<IndexOutOfRangeException>(addRookAction);
            Assert.AreEqual("Index was outside the bounds of the array.", exception.Message);
        }

        [TestMethod]
        // Tests if the AddRook works correctly and adds a rook to the board
        public void TestMethod5()
        {
            var le = new LevelEditor();
            le.CreateLevel("Test", 5, 5);
            le.AddRook(0, 0);

            Assert.AreEqual(Part.Rook, le.GetPartAtIndex(0, 0));
            Assert.AreEqual(PartColour.Null, le.GetPartColourAtIndex(0, 0));
        }

        [TestMethod]
        // Tests if the AddRook method works when a colour is included
        public void TestMethod6()
        {
            var le = new LevelEditor();
            le.CreateLevel("Test", 5, 5);
            le.AddRook(0, 0, PartColour.Black);

            Assert.AreEqual(Part.Rook, le.GetPartAtIndex(0, 0));
            Assert.AreEqual(PartColour.Black, le.GetPartColourAtIndex(0, 0));
        }

        [TestMethod]
        // Tests if an exemption is returned when the x and y coordinates are out of bounds for bishop
        public void TestMethod7()
        {
            var le = new LevelEditor();
            le.CreateLevel("Test", 5, 5);

            void addBishopAction() => le.AddBishop(5, 5);

            var exception = Assert.ThrowsException<IndexOutOfRangeException>(addBishopAction);
            Assert.AreEqual("Index was outside the bounds of the array.", exception.Message);
        }

        [TestMethod]
        // Tests if the AddBishop method works correctly and adds a bishop to the board
        public void TestMethod8()
        {
            var le = new LevelEditor();
            le.CreateLevel("Test", 5, 5);
            le.AddBishop(0, 0);

            Assert.AreEqual(Part.Bishop, le.GetPartAtIndex(0, 0));
            Assert.AreEqual(PartColour.Null, le.GetPartColourAtIndex(0, 0));
        }
        
        [TestMethod]
        // Tests if the AddBishop method works when a colour is included
        public void TestMethod9()
        {
            var le = new LevelEditor();
            le.CreateLevel("Test", 5, 5);
            le.AddBishop(0, 0, PartColour.Black);

            Assert.AreEqual(Part.Bishop, le.GetPartAtIndex(0, 0));
            Assert.AreEqual(PartColour.Black, le.GetPartColourAtIndex(0, 0));
        }
        
        [TestMethod]
        // Tests if an exemption is returned when the x and y coordinates are out of bounds for knight
        public void TestMethod10()
        {
            var le = new LevelEditor();
            le.CreateLevel("Test", 5, 5);

            void addKnightAction() => le.AddKnight(5, 5);

            var exception = Assert.ThrowsException<IndexOutOfRangeException>(addKnightAction);
            Assert.AreEqual("Index was outside the bounds of the array.", exception.Message);
        }
        
        [TestMethod]
        // Tests if the AddKnight method works correctly and adds a knight to the board
        public void TestMethod11()
        {
            var le = new LevelEditor();
            le.CreateLevel("Test", 5, 5);
            le.AddKnight(0, 0);

            Assert.AreEqual(Part.Knight, le.GetPartAtIndex(0, 0));
            Assert.AreEqual(PartColour.Null, le.GetPartColourAtIndex(0, 0));
        }
        
        [TestMethod]
        // Tests if the AddKnight method works when a colour is included
        public void TestMethod12()
        {
            var le = new LevelEditor();
            le.CreateLevel("Test", 5, 5);
            le.AddKnight(0, 0, PartColour.Black);

            Assert.AreEqual(Part.Knight, le.GetPartAtIndex(0, 0));
            Assert.AreEqual(PartColour.Black, le.GetPartColourAtIndex(0, 0));
        }

        [TestMethod]
        // Tests if an exemption is returned when the x and y coordinates are out of bounds for AddPlayerOnEmpty
        public void TestMethod13()
        {
            var le = new LevelEditor();
            le.CreateLevel("Test", 5, 5);

            void addPlayerOnEmptyAction() => le.AddPlayerOnEmpty(5, 5);

            var exception = Assert.ThrowsException<IndexOutOfRangeException>(addPlayerOnEmptyAction);
            Assert.AreEqual("Index was outside the bounds of the array.", exception.Message);
        }
        
        [TestMethod]
        // Tests if the AddPlayerOnEmpty method works correctly and adds a player to the board
        public void TestMethod14()
        {
            var le = new LevelEditor();
            le.CreateLevel("Test", 5, 5);
            le.AddPlayerOnEmpty(0, 0);

            Assert.AreEqual(Part.PlayerOnEmpty, le.GetPartAtIndex(0, 0));
            Assert.AreEqual(PartColour.Null, le.GetPartColourAtIndex(0, 0));
        }
        
        [TestMethod]
        // Tests if the AddPlayerOnEmpty method works when a colour is included
        public void TestMethod15()
        {
            var le = new LevelEditor();
            le.CreateLevel("Test", 5, 5);
            le.AddPlayerOnEmpty(0, 0, PartColour.Black);

            Assert.AreEqual(Part.PlayerOnEmpty, le.GetPartAtIndex(0, 0));
            Assert.AreEqual(PartColour.Black, le.GetPartColourAtIndex(0, 0));
        }

        [TestMethod]
        // Tests if an exemption is returned when the x and y coordinates are out of bounds for AddPlayerOnKing
        public void TestMethod16()
        {
            var le = new LevelEditor();
            le.CreateLevel("Test", 5, 5);

            void addPlayerOnKingAction() => le.AddPlayerOnKing(5, 5);

            var exception = Assert.ThrowsException<IndexOutOfRangeException>(addPlayerOnKingAction);
            Assert.AreEqual("Index was outside the bounds of the array.", exception.Message);
        }
        
        [TestMethod]
        // Tests if the AddPlayerOnKing method works correctly and adds a player to the board on a King
        public void TestMethod17()
        {
            var le = new LevelEditor();
            le.CreateLevel("Test", 5, 5);
            le.AddPlayerOnKing(0, 0);

            Assert.AreEqual(Part.PlayerOnKing, le.GetPartAtIndex(0, 0));
            Assert.AreEqual(PartColour.Null, le.GetPartColourAtIndex(0, 0));
        }
        
        [TestMethod]
        // Tests if the AddPlayerOnKing method works when a colour is included
        public void TestMethod18()
        {
            var le = new LevelEditor();
            le.CreateLevel("Test", 5, 5);
            le.AddPlayerOnKing(0, 0, PartColour.Black);

            Assert.AreEqual(Part.PlayerOnKing, le.GetPartAtIndex(0, 0));
            Assert.AreEqual(PartColour.Black, le.GetPartColourAtIndex(0, 0));
        }
        
        [TestMethod]
        // Tests if an exemption is returned when the x and y coordinates are out of bounds for AddPlayerOnRook
        public void TestMethod19()
        {
            var le = new LevelEditor();
            le.CreateLevel("Test", 5, 5);

            void addPlayerOnRookAction() => le.AddPlayerOnRook(5, 5);

            var exception = Assert.ThrowsException<IndexOutOfRangeException>(addPlayerOnRookAction);
            Assert.AreEqual("Index was outside the bounds of the array.", exception.Message);
        }
        
        [TestMethod]
        // Tests if the AddPlayerOnRook method works correctly and adds a player to the board on a Rook
        public void TestMethod20()
        {
            var le = new LevelEditor();
            le.CreateLevel("Test", 5, 5);
            le.AddPlayerOnRook(0, 0);

            Assert.AreEqual(Part.PlayerOnRook, le.GetPartAtIndex(0, 0));
            Assert.AreEqual(PartColour.Null, le.GetPartColourAtIndex(0, 0));
        }
        
        [TestMethod]
        // Tests if the AddPlayerOnRook method works when a colour is included
        public void TestMethod21()
        {
            var le = new LevelEditor();
            le.CreateLevel("Test", 5, 5);
            le.AddPlayerOnRook(0, 0, PartColour.Black);

            Assert.AreEqual(Part.PlayerOnRook, le.GetPartAtIndex(0, 0));
            Assert.AreEqual(PartColour.Black, le.GetPartColourAtIndex(0, 0));
        }
        
        [TestMethod]
        // Tests if an exemption is returned when the x and y coordinates are out of bounds for AddPlayerOnKnight
        public void TestMethod22()
        {
            var le = new LevelEditor();
            le.CreateLevel("Test", 5, 5);

            void addPlayerOnKnightAction() => le.AddPlayerOnKnight(5, 5);

            var exception = Assert.ThrowsException<IndexOutOfRangeException>(addPlayerOnKnightAction);
            Assert.AreEqual("Index was outside the bounds of the array.", exception.Message);
        }
        
        [TestMethod]
        // Tests if the AddPlayerOnKnight method works correctly and adds a player to the board on a Knight
        public void TestMethod23()
        {
            var le = new LevelEditor();
            le.CreateLevel("Test", 5, 5);
            le.AddPlayerOnKnight(0, 0);

            Assert.AreEqual(Part.PlayerOnKnight, le.GetPartAtIndex(0, 0));
            Assert.AreEqual(PartColour.Null, le.GetPartColourAtIndex(0, 0));
        }
        
        [TestMethod]
        // Tests if the AddPlayerOnKnight method works when a colour is included
        public void TestMethod24()
        {
            var le = new LevelEditor();
            le.CreateLevel("Test", 5, 5);
            le.AddPlayerOnKnight(0, 0, PartColour.Black);

            Assert.AreEqual(Part.PlayerOnKnight, le.GetPartAtIndex(0, 0));
            Assert.AreEqual(PartColour.Black, le.GetPartColourAtIndex(0, 0));
        }
        
        [TestMethod]
        // Tests if an exemption is returned when the x and y coordinates are out of bounds for AddPlayerOnBishop
        public void TestMethod25()
        {
            var le = new LevelEditor();
            le.CreateLevel("Test", 5, 5);

            void addPlayerOnBishopAction() => le.AddPlayerOnBishop(5, 5);

            var exception = Assert.ThrowsException<IndexOutOfRangeException>(addPlayerOnBishopAction);
            Assert.AreEqual("Index was outside the bounds of the array.", exception.Message);
        }
        
        [TestMethod]
        // Tests if the AddPlayerOnBishop method works correctly and adds a player to the board on a Bishop
        public void TestMethod26()
        {
            var le = new LevelEditor();
            le.CreateLevel("Test", 5, 5);
            le.AddPlayerOnBishop(0, 0);

            Assert.AreEqual(Part.PlayerOnBishop, le.GetPartAtIndex(0, 0));
            Assert.AreEqual(PartColour.Null, le.GetPartColourAtIndex(0, 0));
        }
        
        [TestMethod]
        // Tests if the AddPlayerOnBishop method works when a colour is included
        public void TestMethod27()
        {
            var le = new LevelEditor();
            le.CreateLevel("Test", 5, 5);
            le.AddPlayerOnBishop(0, 0, PartColour.Black);

            Assert.AreEqual(Part.PlayerOnBishop, le.GetPartAtIndex(0, 0));
            Assert.AreEqual(PartColour.Black, le.GetPartColourAtIndex(0, 0));
        }

    }
}