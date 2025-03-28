using System;
using Vererbung;
using NUnit.Framework;

namespace Vererbung
{
    [TestFixture]
    public class TierheimTests
    {
        [SetUp]
        public void SetUp() { }

        [Test]
        public void AddAnimal_AddOneCatAndOneDog_ReturnsTwoAnimals()
        {
            var myTierheim = new Tierheim();
            myTierheim.AddAnimal(new Cat(new DateTime(2020, 02, 02), "Milly", "black"));
            myTierheim.AddAnimal(new Cat(new DateTime(2020, 02, 02), "Markus", "black"));

            myTierheim.AddAnimal(new Dog(new DateTime(2020, 02, 02), "Tommy", "red"));
            myTierheim.AddAnimal(new Dog(new DateTime(2020, 02, 02), "Tom", "red"));

            Assert.IsTrue(myTierheim.NumberOfCats == 2);
            Assert.IsTrue(myTierheim.NumberOfDogs == 2);

        }
        [Test]
        public void AvgAge_AddTwoCatAndAddTwoDog_ReturnsAverageAgeFour()
        {
            var myTierheim = new Tierheim();
            myTierheim.AddAnimal(new Cat(new DateTime(2020, 02, 02), "Milly", "black"));
            myTierheim.AddAnimal(new Cat(new DateTime(2023, 02, 02), "Markus", "black"));

            myTierheim.AddAnimal(new Dog(new DateTime(2021, 02, 02), "Tommy", "red"));
            myTierheim.AddAnimal(new Dog(new DateTime(2021, 02, 02), "Tom", "red"));
            
            Assert.IsTrue(myTierheim.AvgAge == 2.75);

        }

    }
}