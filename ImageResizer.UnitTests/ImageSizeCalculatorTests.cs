﻿using NUnit.Framework;

namespace ImageResizer.UnitTests
{
    [TestFixture]
    public class ImageSizeCalculatorTests
    {
        [Test]
        public void GetImageSizeTest()
        {
            var calc = new ImageSizeCalculator(800, 600);
            Assert.AreEqual(300, calc.Scale(400).Height);
        }

        [Test]
        public void ScaleToFillTest()
        {
            var calc = new ImageSizeCalculator(800, 600);
            var imageSize = calc.ScaleToFill(400, 400);
            Assert.AreEqual(400, imageSize.Width);
            Assert.AreEqual(400, imageSize.Height);
            Assert.AreEqual(200, imageSize.XOffset);
            Assert.AreEqual(0, imageSize.YOffset);
        }

        [Test]
        public void ScaleToFillTest2()
        {
            var calc = new ImageSizeCalculator(600, 800);
            var imageSize = calc.ScaleToFill(400, 400);
            Assert.AreEqual(400, imageSize.Width);
            Assert.AreEqual(400, imageSize.Height);
            Assert.AreEqual(0, imageSize.XOffset);
            Assert.AreEqual(200, imageSize.YOffset);
        }

        [Test]
        public void ScaleToFillTest3()
        {
            var calc = new ImageSizeCalculator(600, 450);
            var imageSize = calc.ScaleToFill(600, 300);
            Assert.AreEqual(600, imageSize.Width);
            Assert.AreEqual(300, imageSize.Height);
            Assert.AreEqual(0, imageSize.XOffset);
            Assert.AreEqual(75, imageSize.YOffset);
        }

        [Test]
        public void ScaleToFillTest4()
        {
            var calc = new ImageSizeCalculator(600, 312);
            var imageSize = calc.ScaleToFill(600, 300);
            Assert.AreEqual(600, imageSize.Width);
            Assert.AreEqual(300, imageSize.Height);
            Assert.AreEqual(0, imageSize.XOffset);
            Assert.AreEqual(6, imageSize.YOffset);
        }

        [Test]
        public void ScaleToFitTest()
        {
            var calc = new ImageSizeCalculator(800, 600);
            var imageSize = calc.ScaleToFit(400, 400);
            Assert.AreEqual(400, imageSize.Width);
            Assert.AreEqual(300, imageSize.Height);
            Assert.AreEqual(0, imageSize.XOffset);
            Assert.AreEqual(0, imageSize.YOffset);
        }

        [Test]
        public void ScaleToFitTest2()
        {
            var calc = new ImageSizeCalculator(600, 800);
            var imageSize = calc.ScaleToFit(400, 400);
            Assert.AreEqual(300, imageSize.Width);
            Assert.AreEqual(400, imageSize.Height);
            Assert.AreEqual(0, imageSize.XOffset);
            Assert.AreEqual(0, imageSize.YOffset);
        }
    }
}
