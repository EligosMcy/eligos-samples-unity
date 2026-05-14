using UnityEngine.UI;

namespace UIComponent.CustomUI
{
    public class CustomUnRaycastImage : Image
    {
        protected override void Awake()
        {
            base.Awake();
            raycastTarget = false;
        }
    }
}
