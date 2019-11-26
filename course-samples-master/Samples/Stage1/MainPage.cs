using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Stage1.chapter3
{
    class MainPage
    {
        [Test]
        public void LoadTest()
        {
            Transport car = new Car("AC/DC", "Carbon", 20);
            Assert.That(car.Loading("Bagagge", 10), Is.EqualTo("Багаж загружен"));
            Assert.That(car.Loading("Bagagge", 30), Is.EqualTo("Груз не помещается в багаж"));


        }

        [Test]
        public void UnloadTest()
        {
            Transport car = new Car("AC/DC", "Carbon", 20);
            Assert.That(car.Loading("Bagagge", 30), Is.EqualTo("Груз не помещается в багаж"));
            car.Loading("Bagagge", 10);
            Assert.That(car.Unloading("Elefant"), Is.EqualTo("Груз не найден"));
            Assert.That(car.Unloading("Bagagge"), Is.EqualTo("Груз выгружен"));
            car.Unloading("Bagagge");
            Assert.That(car.Unloading("Bagagge"), Is.EqualTo("Багажник пуст"));
        }

        [Test]
        public void CarTest()
        {
            Transport car = new Car("AC/DC", "Carbon", 20);
            car.Move();
            car.Reparing();
        }

        static void Main()
        {

        }
    }
}