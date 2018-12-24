using InitialPrefabs.Attributes.Messages;
using InitialPrefabs.Examples;
using NUnit.Framework;
using UnityEditor;

namespace InitialPrefabs.Tests.Attributes {

    public class MsgAttributeGUITests : BaseAttributeGUITests {

        private MsgExample example;
        private MsgAttribute stdMsgAttr;

        [SetUp]
        public override void SetUp() {
            AssignTestObject<MsgExample>();
            stdMsgAttr = new MsgAttribute("Test");
        }

        /// <summary>
        /// Ensures that a standard msg attribute has exactly the height given on the inspector.
        /// </summary>
        [Test]
        public void StandardMsgAttributeGUIHeightTest() {
            var intMsgProp = serializedObject.FindProperty("defaultMsg");

            var currentHeight = EditorGUI.GetPropertyHeight(intMsgProp);
            Assert.AreEqual(stdMsgAttr.height * EditorGUIUtility.singleLineHeight, EditorGUI.GetPropertyHeight(intMsgProp),
                "Height mismatch!");
        }

        /// <summary>
        /// Get the customMsgHeight field to ensure that it manipulates the height in the inspector.
        /// </summary>
        [Test]
        public void CustomMsgAttributeGUIHeightTest() {
            var charMsgProp = serializedObject.FindProperty("customMsgHeight");
            Assert.IsNotNull(charMsgProp, $"{testObject.name} does not have an charMsg field!");

            var currentHeight = EditorGUI.GetPropertyHeight(charMsgProp);
            Assert.Greater(currentHeight, stdMsgAttr.height * EditorGUIUtility.singleLineHeight,
                "Height is smaller than the standard height!");
        }
    }
}
