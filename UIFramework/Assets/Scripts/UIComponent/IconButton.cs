using System;
using TMPro;
using UIComponent.CustomUI;
using UnityEngine;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace UIComponent
{
    public class IconButton : MonoBehaviour
    {
        [SerializeField]
        private Sprite _imageSprite;

        [SerializeField]
        private string _iconText;

        [Space(20)]
        [SerializeField]
        private CustomUnRaycastImage _unRaycastImage;

        [SerializeField]
        private TextMeshProUGUI _textMeshProUGUI;

        [SerializeField]
        private Button _button;

        private void Awake()
        {
            initComponent();
        }

        private void Start()
        {
            _unRaycastImage.sprite = _imageSprite;

            _textMeshProUGUI.text = _iconText;
        }

        private void OnEnable()
        {
            _button.onClick.AddListener(OnButtonClick);
        }

        private void OnButtonClick()
        {
            Debug.Log($"Button onClick: {_iconText}");
        }

        private void initComponent()
        {
            if (_unRaycastImage == null)
            {
                _unRaycastImage = transform.GetChild(0).GetComponent<CustomUnRaycastImage>();
            }

            if (_textMeshProUGUI == null && _unRaycastImage != null)
            {
                _textMeshProUGUI = _unRaycastImage.transform.GetChild(0).GetComponent<TextMeshProUGUI>();
            }

            if (_button == null)
            {
                _button = transform.GetComponent<Button>();
            }
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(OnButtonClick);
        }
    }
    /*
    #if UNITY_EDITOR
        [CustomEditor(typeof(IconButton))]
        public class IconButtonEditor : Editor
        {
            public override void OnInspectorGUI()
            {
                DrawDefaultInspector();

                IconButton iconButton = (IconButton)target;

                GUILayout.Space(20);

                if (GUILayout.Button("Apply ImageSprite and IconText"))
                {
                    ApplySpriteAndText(iconButton);
                }
            }

            private void ApplySpriteAndText(IconButton iconButton)
            {
                SerializedObject serializedObject = new SerializedObject(iconButton);

                SerializedProperty imageSpriteProp = serializedObject.FindProperty("_imageSprite");
                SerializedProperty iconTextProp = serializedObject.FindProperty("_iconText");
                SerializedProperty unRaycastImageProp = serializedObject.FindProperty("_unRaycastImage");
                SerializedProperty textMeshProProp = serializedObject.FindProperty("_textMeshProUGUI");

                if (unRaycastImageProp.objectReferenceValue != null)
                {
                    var unRaycastImage = (CustomUnRaycastImage)unRaycastImageProp.objectReferenceValue;
                    unRaycastImage.sprite = (Sprite)imageSpriteProp.objectReferenceValue;
                }

                if (textMeshProProp.objectReferenceValue != null)
                {
                    var textMeshPro = (TMPro.TextMeshProUGUI)textMeshProProp.objectReferenceValue;
                    textMeshPro.text = iconTextProp.stringValue;
                }

                EditorUtility.SetDirty(iconButton);
                serializedObject.ApplyModifiedProperties();

                Debug.Log("Applied imageSprite and iconText to components");
            }
        }
    #endif
    */
}
