using InitialPrefabs.Examples;
using NUnit.Framework;

namespace InitialPrefabs.Tests.Attributes {

    public class DynamicProgressBarAttributeGUITests : BaseAttributeGUITests {

        private const string DefaultField = "floatMax";

        [SetUp]
        public override void SetUp() {
            AssignTestObject<DynamicProgressBarExample>();
        }

        [Test]
        public void DynamicProgressBarHeightTest() {
            var heights = this.RetrievePropertyHeights(DefaultField, "floatProgress");
            Assert.Greater(heights.Item2, heights.Item1, $"floatProgress field should be larger than the {DefaultField}");
        }
    }
}
