using DPcode.Domain;
using NUnit.Framework;

namespace DPcode.Tests
{
    public class WheatherCheckerTest
    {
        public double[] cloudBurst;
        public double[] veryHeavyRain;
        public double[] heavyRain;
        public double[] noRain;

        private IWheatherChecker _wheatherChecker;

        [SetUp]
        public void Setup()
        {
            cloudBurst = new double[] { 5, 10, 3 };
            veryHeavyRain = new double[] { 0.5, 0.7, 0.12 };
            heavyRain = new double[] { 0.12, 0.123, 0.4 };
            noRain = new double[] { 0, 0, 0 };
            _wheatherChecker = new WheatherChecker();
        }

        [Test]
        public void CloudBurstTest()
        {
            // Method must return -1 if there isn't cloudburst.
            Assert.AreEqual(-1, _wheatherChecker.ContainsCloudBurst(noRain), "Method must return -1 if there isn't cloudburst.");

            //Method must not return -1 when there is a couldburst
            Assert.AreNotEqual(-1, _wheatherChecker.ContainsCloudBurst(cloudBurst), "Method must return -1 if there isn't cloudburst.");
        }

        [Test]
        public void HeavyRainTest()
        {

            Assert.AreEqual(-1, _wheatherChecker.ContainsHeavyRain(noRain), "Method must return -1 if there isn't heavy rain.");

            //Method must not return -1 when there is a couldburst
            Assert.AreNotEqual(-1, _wheatherChecker.ContainsHeavyRain(heavyRain), "Method must return -1 if there isn't heavy rain.");
        }
        [Test]
        public void VeryHeavyRainTest()
        {

            Assert.AreEqual(-1, _wheatherChecker.ContainsVeryHeavyRain(noRain), "Method must return -1 if there isn't very heavy rain.");

            //Method must not return -1 when there is a couldburst
            Assert.AreNotEqual(-1, _wheatherChecker.ContainsVeryHeavyRain(veryHeavyRain), "Method must return -1 if there isn't very heavy rain.");
        }
    }
}