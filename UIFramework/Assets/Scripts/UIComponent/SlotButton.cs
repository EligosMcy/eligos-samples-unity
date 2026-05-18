using System;
using TMPro;
using UIComponent.CustomUI;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace UIComponent
{
    public class SlotButton : MonoBehaviour
    {
        [SerializeField]
        private Sprite _itemSprite;

        [Space(20)]
        [SerializeField]
        private Image _itemImage;

        [SerializeField]
        private Button _button;

        private void Awake()
        {
            initComponent();
        }

        private void Start()
        {
            _itemImage.sprite = _itemSprite;
        }

        private void OnEnable()
        {
            _button.onClick.AddListener(OnButtonClick);
        }

        private void OnButtonClick()
        {
            Debug.Log("Button onClick: Slot Button");
        }

        private void initComponent()
        {
            if (_button == null)
            {
                _button = transform.GetComponent<Button>();
            }

            if (_itemImage == null)
            {
                _itemImage = transform.GetChild(1).GetComponent<Image>();
            }
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(OnButtonClick);
        }
    }
}