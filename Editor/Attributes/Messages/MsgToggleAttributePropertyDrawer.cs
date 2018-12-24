using InitialPrefabs.Attributes.Messages;
using UnityEngine;
using UnityEditor;

namespace InitialPrefabs.Editor.Attributes.Messages {

    [CustomPropertyDrawer(typeof(MsgToggleAttribute))]
    public class MsgToggleAttributePropertyDrawer : BasePropertyDrawer {

        private float height;

        protected override void OnInspectorAttribute(Rect rect, SerializedProperty prop, GUIContent label) {
            var toggleMsg      = attribute as MsgToggleAttribute;
            var originalHeight = GetPropertyHeight(prop, label);
            var propRect       = new Rect(rect.x, rect.y, rect.width, height);
            var msgRect        = new Rect(rect.x, rect.y + height, rect.width, originalHeight - height);
            EditorGUI.PropertyField(propRect, prop);

            if (prop.propertyType == SerializedPropertyType.Boolean) {
                var isMsgShown = toggleMsg.isInverted ? !prop.boolValue : prop.boolValue;

                if (isMsgShown) {
                    EditorGUI.HelpBox(msgRect, toggleMsg.message, (MessageType)toggleMsg.messageLevel);
                }
            } else {
                EditorGUI.HelpBox(msgRect, $"{fieldInfo.Name} is not a bool type, is it a {fieldInfo.FieldType}!", 
                    MessageType.Error);
            }
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label) {
            var isBoolType = property.propertyType == SerializedPropertyType.Boolean;
            var toggleMsg  = attribute as MsgToggleAttribute;
            height         = EditorGUI.GetPropertyHeight(property);

            if (isBoolType) {
                var isMsgShown = toggleMsg.isInverted ? !property.boolValue : property.boolValue;
                return isMsgShown ? toggleMsg.height * height : height;
            }
            return height * toggleMsg.height;
        }
    }
}
