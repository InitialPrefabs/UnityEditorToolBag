﻿using InitialPrefabs.Attributes;
using InitialPrefabs.Editor.Attributes.Utils;
using UnityEditor;
using UnityEngine;

namespace InitialPrefabs.Editor.Attributes.ProgressBar {

    [CustomPropertyDrawer(typeof(FixedProgressBarAttribute))]
    public class FixedProgressBarAttributeDrawer : BasePropertyDrawer {

        protected override void OnInspectorAttribute(Rect rect, SerializedProperty prop, GUIContent label) {
            if (PropertyUtils.IsPropertyTypeNumeric(prop.propertyType)) {
                var singleLineHeight = rect.height / 2;
                var propRect = new Rect(rect.x, rect.y, rect.width, singleLineHeight);

                ClampNumericValue(prop);
                EditorGUI.PropertyField(propRect, prop);

                var progressRect = new Rect(rect.x, rect.y + singleLineHeight, rect.width, rect.height -
                    singleLineHeight);

                DrawProgressBar(progressRect, prop);
            } else {
                EditorGUI.PropertyField(rect, prop);
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
            var height = EditorGUI.GetPropertyHeight(property);
            return PropertyUtils.IsPropertyTypeNumeric(property.propertyType) ? height * 2 : height;
        }

        private void DrawProgressBar(Rect r, SerializedProperty prop) {
            var progressBar = attribute as FixedProgressBarAttribute;
            switch (prop.propertyType) {
                case SerializedPropertyType.Integer:
                    EditorGUI.ProgressBar(r, prop.intValue / progressBar.max, 
                            $"{progressBar.label}: {prop.intValue}/{progressBar.max}");
                    return;
                case SerializedPropertyType.Float:
                    EditorGUI.ProgressBar(r, prop.floatValue / progressBar.max, 
                            $"{progressBar.label}: {prop.floatValue}/{progressBar.max}");
                    return;
                default:
                    Debug.LogError($"{fieldInfo.Name} is not a numeric type!");
                    return;
            }
        }

        private void ClampNumericValue(SerializedProperty prop) {
            var progressBar = attribute as FixedProgressBarAttribute;
            switch (prop.propertyType) {
                case SerializedPropertyType.Integer:
                    prop.intValue = Mathf.Clamp(prop.intValue, 0, (int)progressBar.max);
                    return;
                case SerializedPropertyType.Float:
                    prop.floatValue = Mathf.Clamp(prop.floatValue, 0, progressBar.max);
                    return;
                default:
                    Debug.LogError($"{fieldInfo.Name} is not a numeric type!");
                    return;
            }
        }
    }
}
