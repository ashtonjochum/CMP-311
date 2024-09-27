using EventUnitTestExcercise;

namespace PricingEngineTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PricingEngine_PriceCost_InputisCapD()
        {
            //arrange
            PricingEngine priceEngine = new PricingEngine();
            //act
            double unitPrice = priceEngine.PriceChange("D", 10);
            //assert
            Assert.AreEqual(unitPrice, 9);
        }
        [TestMethod]
        public void PricingEngine_PriceCost_InputisLowerd()
        {
            //arrange
            PricingEngine priceEngine = new PricingEngine();
            //act
            double unitPrice = priceEngine.PriceChange("d", 10);
            //assert
            Assert.AreEqual(unitPrice, 9);
        }
        [TestMethod]
        public void PricingEngine_PriceCost_InputisCapL()
        {
            //arrange
            PricingEngine priceEngine = new PricingEngine();
            //act
            double unitPrice = priceEngine.PriceChange("L", 10);
            //assert
            Assert.AreEqual(unitPrice, 11);
        }
        [TestMethod]
        public void PricingEngine_PriceCost_InputisLowerl()
        {
            //arrange
            PricingEngine priceEngine = new PricingEngine();
            //act
            double unitPrice = priceEngine.PriceChange("l", 10);
            //assert
            Assert.AreEqual(unitPrice, 11);
        }
        [TestMethod]
        public void PricingEngine_PriceCost_InputisCapE()
        {
            //arrange
            PricingEngine priceEngine = new PricingEngine();
            //act
            double unitPrice = priceEngine.PriceChange("E", 10);
            //assert
            Assert.AreEqual(unitPrice, 7.5);
        }
        [TestMethod]
        public void PricingEngine_PriceCost_InputisLowere()
        {
            //arrange
            PricingEngine priceEngine = new PricingEngine();
            //act
            double unitPrice = priceEngine.PriceChange("e", 10);
            //assert
            Assert.AreEqual(unitPrice, 7.5);
        }
        [TestMethod]
        public void PricingEngine_PriceCost_InputisCapF()
        {
            //arrange
            PricingEngine priceEngine = new PricingEngine();
            //act
            double unitPrice = priceEngine.PriceChange("F", 10);
            //assert
            Assert.AreEqual(unitPrice, 0);
        }
        [TestMethod]
        public void PricingEngine_PriceCost_InputisLowerf()
        {
            //arrange
            PricingEngine priceEngine = new PricingEngine();
            //act
            double unitPrice = priceEngine.PriceChange("f", 10);
            //assert
            Assert.AreEqual(unitPrice, 0);
        }
        [TestMethod]
        public void PricingEngine_PriceCost_InvalidInput()
        {
            //arrange
            PricingEngine priceEngine = new PricingEngine();
            //act
            double unitPrice = priceEngine.PriceChange("Wrong Input", 10);
            //assert
            Assert.AreEqual(unitPrice, 10);
        }
        [TestMethod]
        public void PricingEngine_PriceCost_WrongChar()
        {
            //arrange
            PricingEngine priceEngine = new PricingEngine();
            //act
            double unitPrice = priceEngine.PriceChange("Wrong Input Again", 10);
            //assert
            Assert.AreEqual(unitPrice, 10);
        }
    }
}