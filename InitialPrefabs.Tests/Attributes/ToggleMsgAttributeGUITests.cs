using InitialPrefabs.Attributes.Messages;
using InitialPrefabs.Examples;
using NUnit.Framework;
using System;
using UnityEditor;

namespace InitialPrefabs.Tests.Attributes {

    public class ToggleMsgAttributeGUITests : BaseAttributeGUITests {

        private MsgToggleAttribute defaultMsgToggle;

        [SetUp]
        public override void SetUp() {
            AssignTestObject<MsgToggleExample>();
            defaultMsgToggle = new MsgToggleAttribute("Test attribute");
        }

        [Test]
        public void MsgToggleShowWhenEnabled() {
            var pair = RetrievePropertyHeights("toggleMsg", true);
            Assert.Greater(pair.Item2, pair.Item1, "The actual height should be greater than the "
                + "expectedHeight!");
        }

        [Test]
        public void MsgToggleHideWhenDisable() {
            var pair = RetrievePropertyHeights("toggleMsg", false);
            Assert.AreEqual(pair.Item1, pair.Item2, "Height mismatch, should be the same!");
        }

        [Test]
        public void MsgToggleGUIShowWhenDisabled() {
            var pair = RetrievePropertyHeights("invertedToggleMsg", false);
            Assert.Greater(pair.Item2, pair.Item1, "The expected height should be greater than the " 
                + "actual height!");
        }

        [Test]
        public void MsgToggleGUIHideWhenDisable() {
            var pair = RetrievePropertyHeights("invertedToggleMsg", true);
            Assert.AreEqual(pair.Item2, pair.Item1, "Height mismatch, should be the same!");
        }

        [Test]
        public void InvalidMsgToggleTest() {
            var pair = RetrievePropertyHeights("invalidMsgToggle");
            Assert.Greater(pair.Item2, pair.Item1, "An invalid field should have a modified height!");
        }

        /// <summary>
        /// Returns a pair of heights with the LHS being the default height and the RHS being the modified 
        /// custom height.
        /// </summary>
        private ValueTuple<float, float> RetrievePropertyHeights(string field, bool value = false) {
            var defaultField = serializedObject.FindProperty("defaultBool");
            var currentField = serializedObject.FindProperty(field);

            if (currentField.propertyType == SerializedPropertyType.Boolean) {
                currentField.boolValue = value;
            }

            return ValueTuple.Create(EditorGUI.GetPropertyHeight(defaultField), 
                    EditorGUI.GetPropertyHeight(currentField));
        }
    }
}
