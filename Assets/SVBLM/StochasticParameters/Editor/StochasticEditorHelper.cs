using UnityEditor;
using UnityEngine;


namespace SVBLM.StochasticParameters.Editor {
    public class StochasticEditorHelper {
        public static void DrawIntervalDrawer(Rect position, SerializedProperty property, GUIContent label) {
            EditorGUI.BeginProperty(position, label, property);
            position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);
            var minRect = new Rect(position.x, position.y, 30, position.height);
            var arrowRect = new Rect(position.x + 35, position.y, 40, position.height);
            var maxRect = new Rect(position.x + 80, position.y, 30, position.height);
            EditorGUI.PropertyField(minRect, property.FindPropertyRelative("MinValue"), GUIContent.none);
            EditorGUI.LabelField(arrowRect, "⇠     ⇢");
            EditorGUI.PropertyField(maxRect, property.FindPropertyRelative("MaxValue"), GUIContent.none);
            EditorGUI.EndProperty();
        }
    }
}