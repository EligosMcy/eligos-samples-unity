using UnityEngine.UI;

namespace UIComponent.CustomUI
{
    public class CustomUnRendererImage : Image
    {
        protected override void Awake()
        {
            base.Awake();
            raycastTarget = true;
        }

        protected override void OnPopulateMesh(VertexHelper toFill)
        {
            toFill.Clear();
        }
    }
}
