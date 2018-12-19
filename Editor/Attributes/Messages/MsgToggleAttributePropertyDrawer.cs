using InitialPrefabs.Attributes.Messages;
using UnityEngine;
using UnityEditor;

namespace InitialPrefabs.Editor.Attributes.Messages {

    [CustomPropertyDrawer(typeof(MsgToggleAttribute))]
    public class MsgToggleAttributePropertyDrawer : BasePropertyDrawer {

        protected override void OnInspectorAttribute(Rect rect, SerializedProperty prop, GUIContent label) =>
            throw new System.NotImplementedException();
    }
}
