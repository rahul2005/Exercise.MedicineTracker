using AutoMoq;
using Exercise.MedicineTracker.API.Controllers;
using Exercise.MedicineTracker.API.Models;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Exercise.MedicineTracker.API.UnitTests.Controllers
{
    [TestFixture]
    public class MedicinesControllerTests
    {
        [Test]
        public void GetMedicines_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var medicinesController = mocker.Create<MedicinesController>();

            // Act
            var result = medicinesController.GetMedicines();

            // Assert
            Assert.Fail();
        }

        [Test]
        public async Task GetMedicine_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var medicinesController = mocker.Create<MedicinesController>();
            int id = 0;

            // Act
            var result = await medicinesController.GetMedicine(
                id);

            // Assert
            Assert.Fail();
        }

        [Test]
        public async Task PutMedicine_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var medicinesController = mocker.Create<MedicinesController>();
            int id = 0;
            Medicine medicine = null;

            // Act
            var result = await medicinesController.PutMedicine(
                id,
                medicine);

            // Assert
            Assert.Fail();
        }

        [Test]
        public async Task PostMedicine_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var medicinesController = mocker.Create<MedicinesController>();
            Medicine medicine = null;

            // Act
            var result = await medicinesController.PostMedicine(
                medicine);

            // Assert
            Assert.Fail();
        }

        [Test]
        public async Task DeleteMedicine_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var medicinesController = mocker.Create<MedicinesController>();
            int id = 0;

            // Act
            var result = await medicinesController.DeleteMedicine(
                id);

            // Assert
            Assert.Fail();
        }

        [Test]
        public void Test_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var mocker = new AutoMoqer();
            var medicinesController = mocker.Create<MedicinesController>();

            // Act
            var result = medicinesController.Test();

            // Assert
            Assert.Fail();
        }
    }
}
