using EventAppWithDI;

namespace EventAppDITest
{
    [TestClass]
    public class EventDIUnitTests
    {
        [TestMethod]
        public void GraduationNoModification()
        {
            //arrange
            IEvent @event = new GraduationEvent("1", "Test Grad", 1000);
            EventService eventService = new EventService(@event);
            //act
            double modPrice = eventService.modifiedCost("No Modification");
            //assert
            Assert.AreEqual(modPrice, 1000);
        }
        [TestMethod]
        public void GraduationEmployeeDiscountCapE()
        {
            //arrange
            IEvent @event = new GraduationEvent("2", "Test Grad", 1000);
            EventService eventService = new EventService(@event);
            //act
            double modPrice = eventService.modifiedCost("E");
            //assert
            Assert.AreEqual(modPrice, 750);
        }
        [TestMethod]
        public void GraduationEmployeeDiscountLowE()
        {
            //arrange
            IEvent @event = new GraduationEvent("3", "Test Grad", 1000);
            EventService eventService = new EventService(@event);
            //act
            double modPrice = eventService.modifiedCost("e");
            //assert
            Assert.AreEqual(modPrice, 750);
        }
        [TestMethod]
        public void GraduationLate()
        {
            //arrange
            IEvent @event = new GraduationEvent("4", "Test Grad", 1000);
            EventService eventService = new EventService(@event);
            //act
            double modPrice = eventService.modifiedCost("L");
            //assert
            Assert.AreEqual(modPrice, 1100);
        }
        [TestMethod]
        public void WeddingDiscount()
        {
            //arrange
            IEvent @event = new WeddingEvent("4", "Test Wedding", 1000);
            EventService eventService = new EventService(@event);
            //act
            double modPrice = eventService.modifiedCost("D");
            //assert
            Assert.AreEqual(modPrice, 900);
        }
        [TestMethod]
        public void WeddingFree()
        {
            //arrange
            IEvent @event = new WeddingEvent("5", "Test Wedding", 1000);
            EventService eventService = new EventService(@event);
            //act
            double modPrice = eventService.modifiedCost("f");
            //assert
            Assert.AreEqual(modPrice, 000);
        }
    }
}