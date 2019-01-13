using InitialPrefabs.Attributes;
using InitialPrefabs.Editor.Attributes.Utils;
using UnityEditor;
using UnityEngine;

namespace InitialPrefabs.Editor.Attributes.ProgressBar {

    [CustomPropertyDrawer(typeof(DynamicProgressBarAttribute))]
    public class DynamicProgressBarAttributeDrawer : BasePropertyDrawer {

        protected override void OnInspectorAttribute(Rect rect, SerializedProperty prop, GUIContent label) {
            if (PropertyTypeUtils.IsPropertyTypeNumeric(prop.propertyType)) {
                var singleLineHeight = rect.height / 2;
                var propRect         = new Rect(rect.x, rect.y, rect.width, singleLineHeight);

                EditorGUI.PropertyField(propRect, prop);

                var progressRect     = new Rect(rect.x, rect.y + singleLineHeight, rect.width, rect.height -
                        singleLineHeight);

                DrawProgressBar(progressRect, prop);
            } else {
                EditorGUI.PropertyField(rect, prop);
            }
        }

        public override float GetPropertyHeight(SerializedProperty prop, GUIContent label) {
            var height = EditorGUI.GetPropertyHeight(prop);
            return PropertyTypeUtils.IsPropertyTypeNumeric(prop.propertyType) ? height * 2 : height;
        }

        private void DrawProgressBar(Rect r, SerializedProperty prop) {
            var progressBar = attribute as DynamicProgressBarAttribute;
            SerializedProperty max;
            switch (prop.propertyType) {
                case SerializedPropertyType.Integer:
                    max = PropertyTypeUtils.GetSerializedProperty(prop, progressBar.maxProperty);
                    EditorGUI.ProgressBar(r, (float)prop.intValue / max.intValue, $"{progressBar.label}: {prop.intValue} / " +
                            $"{max.intValue}");
                    return;
                case SerializedPropertyType.Float:
                    max = PropertyTypeUtils.GetSerializedProperty(prop, progressBar.maxProperty);
                    EditorGUI.ProgressBar(r, prop.floatValue / max.floatValue, $"{progressBar.label}: {prop.floatValue} / " +
                            $"{max.floatValue}");
                    return;
                default:
                    Debug.LogError($"{fieldInfo} is not a numeric type!");
                    return;
            }
        }
    }
}
