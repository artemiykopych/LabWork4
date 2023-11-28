using Lab4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class PointTests
    {
        [TestMethod]
        public void CreatePoint()
        {
            var a = new Point();
        }

        [TestMethod]
        public void CreatePoint2()
        {
            var a = new Point(0, 0);
        }

        [TestMethod]
        public void CreateSquare_Test() 
        { 
            var sq = new Square(0, 0);
        }

        [TestMethod]
        public void CreateRectangle_Test()
        {
            var rec = new Rectangle(0, 0);
        }

        [TestMethod]
        public void CreateRomb_Test()
        {
            var sq = new Romb(0, 0);
        }

        [TestMethod]
        public void movePointRight_Test()
        {
            var a = new Point(0, 0);
            a.movePoint(2, 0);
            double x = a.X;
            double y = a.Y;
            Assert.AreEqual(2, x);
            Assert.AreEqual(0, y);
        }

        [TestMethod]
        public void movePointLeft_Test()
        {
            var a = new Point(0, 0);
            a.movePoint(-2, 0);
            double x = a.X;
            double y = a.Y;
            Assert.AreEqual(-2, x);
            Assert.AreEqual(0, y);
        }

        [TestMethod]
        public void movePointTop_Test()
        {
            var a = new Point(0, 0);
            a.movePoint(0, 2);
            double x = a.X;
            double y = a.Y;
            Assert.AreEqual(0, x);
            Assert.AreEqual(2, y);
        }

        [TestMethod]
        public void movePointBottom_Test()
        {
            var a = new Point(0, 0);
            a.movePoint(0, -2);
            double x = a.X;
            double y = a.Y;
            Assert.AreEqual(0, x);
            Assert.AreEqual(-2, y);
        }

        [TestMethod]
        public void moveSquareRight_Test()
        {
            var sq = new Square(0, 0);
            sq.moveSquare(2, 0);
            double ax = sq.AX;
            double ay = sq.AY;
            double bx = sq.BX;
            double by = sq.BY;
            double cx = sq.CX;
            double cy = sq.CY;
            double dx = sq.DX;
            double dy = sq.DY;
            Assert.AreEqual(2, ax);
            Assert.AreEqual(0, ay);
            Assert.AreEqual(2, bx);
            Assert.AreEqual(5, by);
            Assert.AreEqual(7, cx);
            Assert.AreEqual(5, cy);
            Assert.AreEqual(7, dx);
            Assert.AreEqual(0, dy);
        }

        [TestMethod]
        public void moveSquareLeft_Test()
        {
            var sq = new Square(0, 0);
            sq.moveSquare(-2, 0);
            double ax = sq.AX;
            double ay = sq.AY;
            double bx = sq.BX;
            double by = sq.BY;
            double cx = sq.CX;
            double cy = sq.CY;
            double dx = sq.DX;
            double dy = sq.DY;
            Assert.AreEqual(-2, ax);
            Assert.AreEqual(0, ay);
            Assert.AreEqual(-2, bx);
            Assert.AreEqual(5, by);
            Assert.AreEqual(3, cx);
            Assert.AreEqual(5, cy);
            Assert.AreEqual(3, dx);
            Assert.AreEqual(0, dy);
        }

        [TestMethod]
        public void moveSquareTop_Test()
        {
            var sq = new Square(0, 0);
            sq.moveSquare(0, 2);
            double ax = sq.AX;
            double ay = sq.AY;
            double bx = sq.BX;
            double by = sq.BY;
            double cx = sq.CX;
            double cy = sq.CY;
            double dx = sq.DX;
            double dy = sq.DY;
            Assert.AreEqual(0, ax);
            Assert.AreEqual(2, ay);
            Assert.AreEqual(0, bx);
            Assert.AreEqual(7, by);
            Assert.AreEqual(5, cx);
            Assert.AreEqual(7, cy);
            Assert.AreEqual(5, dx);
            Assert.AreEqual(2, dy);
        }

        [TestMethod]
        public void moveSquareBottom_Test()
        {
            var sq = new Square(0, 0);
            sq.moveSquare(0, -2);
            double ax = sq.AX;
            double ay = sq.AY;
            double bx = sq.BX;
            double by = sq.BY;
            double cx = sq.CX;
            double cy = sq.CY;
            double dx = sq.DX;
            double dy = sq.DY;
            Assert.AreEqual(0, ax);
            Assert.AreEqual(-2, ay);
            Assert.AreEqual(0, bx);
            Assert.AreEqual(3, by);
            Assert.AreEqual(5, cx);
            Assert.AreEqual(3, cy);
            Assert.AreEqual(5, dx);
            Assert.AreEqual(-2, dy);
        }
    }
}
