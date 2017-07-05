using UnityEditor;
using UnityEngine;

namespace SVBLM.StochasticParameters.Editor {
    [CustomPropertyDrawer(typeof(StochasticFloat))]
    public class StochasticFloatDrawer : PropertyDrawer {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            StochasticEditorHelper.DrawIntervalDrawer(position, property, label);
        }
    }
}
