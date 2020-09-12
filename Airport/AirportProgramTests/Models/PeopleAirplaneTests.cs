using Microsoft.VisualStudio.TestTools.UnitTesting;
using AirportProgram.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AirportProgram.Models.Tests
{
    [TestClass()]
    public class PeopleAirplaneTests
    {

        PeopleAirplane PeopleAirplane;
        [TestInitialize]
        public void SetUp()
        {
            PeopleAirplane = new PeopleAirplane("ABC123", 60, 20, false, 234.0);
        }


        [TestMethod()]
        public void TakeOffTest()
        {
            //Act
            /* The plain will take off so the isFlying will change to be true
             */
            PeopleAirplane.TakeOff();
            //Assert 
            Assert.IsTrue(PeopleAirplane.IsFlying);
        }

        [TestMethod()]
        public void LoadTest()
        {
            //Act
            /* trying to load a number more than the max so it will not load
             * and the current passengers number will stay the same 20
             */
            PeopleAirplane.Load(50);

            //Assert
            Assert.AreEqual(PeopleAirplane.CurrentNoOfPassengers, 20);

        }
    }
}