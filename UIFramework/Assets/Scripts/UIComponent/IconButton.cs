using System;
using TMPro;
using UIComponent.CustomUI;
using UnityEngine;
using UnityEngine.UI;

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

        private Button _button;

        private void Awake()
        {
            initComponent();

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
}
