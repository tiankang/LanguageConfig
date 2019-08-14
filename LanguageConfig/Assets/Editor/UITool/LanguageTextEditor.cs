using System;
using UnityEditor;
using UnityEditor.UI;

namespace GameEdit
{
    [CustomEditor(typeof(LanguageText), true)]
    [CanEditMultipleObjects]
    public class LanguageTextEditor: GraphicEditor
    {
        SerializedProperty m_Text;
        SerializedProperty m_FontData;
        private SerializedProperty m_LanguageID;
        protected override void OnEnable()
        {
            base.OnEnable();
            m_Text = serializedObject.FindProperty("m_Text");
            m_FontData = serializedObject.FindProperty("m_FontData");
            m_LanguageID = serializedObject.FindProperty("mLanguageId");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            EditorGUILayout.PropertyField(m_LanguageID);
            EditorGUILayout.PropertyField(m_Text);
            EditorGUILayout.PropertyField(m_FontData);
            AppearanceControlsGUI();
            RaycastControlsGUI();
            serializedObject.ApplyModifiedProperties();
        }
    }
}
