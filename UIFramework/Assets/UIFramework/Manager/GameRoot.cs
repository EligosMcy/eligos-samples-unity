using UIFramework.UIPanel;
using UnityEngine;

namespace UIFramework.Manager
{
    public class GameRoot : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {
            UIManager.Instance.PushPanel(UIPanelType.MainMenu);

            //实验一种新的序列化方式
            // UIJsonParseManager.TestInfoStr();
        }
    }
}
