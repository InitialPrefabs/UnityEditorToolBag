using UnityEditor;
using UnityEngine;

namespace InitialPrefabs.Editor.Attributes.Utils {

    public static class PropertyTypeUtils {
        
        /// <summary>
        /// A utility function to help short hand that a property is a particular type.
        /// </summary>
        /// <param name="orig">The original property type.</param>
        /// <param name="type">The type to determine that a property is of some type.</param>
        /// <returns>True, if the type happens to be a selected type, false otherwise.</returns>
        public static bool IsPropertyType(SerializedPropertyType orig, SerializedPropertyType type) =>
            orig == type;

        /// <summary>
        /// A utility function to help short hand that a property type is a 32 bit numerical value.
        /// </summary>
        /// <param name="type">The type to compare.</param>
        /// <returns>True, if the value happens to be a float or integer, false otherwise.</returns>
        public static bool IsPropertyTypeNumeric(SerializedPropertyType type) =>
            type == SerializedPropertyType.Integer || type == SerializedPropertyType.Float;

        public static SerializedProperty GetSerializedProperty(SerializedProperty prop, string propName) {
            var origin       = prop.serializedObject;
            var fullPropPath = prop.propertyPath;
            return origin.FindProperty(propName);
        }
    }
}
