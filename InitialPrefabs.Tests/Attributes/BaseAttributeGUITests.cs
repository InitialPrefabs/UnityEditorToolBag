using NUnit.Framework;
using System;
using UnityEditor;
using UnityEngine;

namespace InitialPrefabs.Tests.Attributes {

    public abstract class BaseAttributeGUITests {

        protected GameObject testObject;
        protected SerializedObject serializedObject;

        [SetUp]
        public abstract void SetUp();

        [TearDown]
        public virtual void TearDown() => UnityEngine.Object.DestroyImmediate(testObject);

        protected void AssignTestObject<T>() where T : Component {
            testObject = new GameObject("[Test Object");
            serializedObject = new SerializedObject(testObject.AddComponent<T>());
        }

        /// <summary>
        /// Returns a pair of heights with the LHS being the default height and the RHS being the modified 
        /// custom height.
        /// </summary>
        protected ValueTuple<float, float> RetrievePropertyHeights(string defaultField, string customField) {
            var @default = serializedObject.FindProperty(defaultField);
            var @current = serializedObject.FindProperty(customField);

            return ValueTuple.Create(EditorGUI.GetPropertyHeight(@default),
                EditorGUI.GetPropertyHeight(@current));
        }
    }
}
