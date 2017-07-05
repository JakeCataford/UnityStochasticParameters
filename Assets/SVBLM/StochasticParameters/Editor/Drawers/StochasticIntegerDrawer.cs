using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace SVBLM.StochasticParameters.Editor {
    [CustomPropertyDrawer(typeof(StochasticInteger))]
    public class StochasticIntegerDrawer : PropertyDrawer {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label) {
            StochasticEditorHelper.DrawIntervalDrawer(position, property, label);
        }
    }
}
