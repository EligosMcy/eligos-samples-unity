using System;
using System.Collections.Generic;
using UIFramework.UIPanel;
using UnityEngine;

namespace UIFramework.Manager
{
    [Serializable]
    public class UIPanelTypeJson
    {
        public List<UIPanelInfo> InfoList;
    }

    [Serializable]
    public class UIPanelTypeStrJson
    {
        public List<UIPanelInfoStr> InfoList;
    }

    public static class UIJsonParseManager
    {
        public static Dictionary<UIPanelType, string> PanelPathDict = new Dictionary<UIPanelType, string>();

        public static void ParseUIPanelTypeJson()
        {
            PanelPathDict = new Dictionary<UIPanelType, string>();

            TextAsset text = Resources.Load<TextAsset>("UIPanelType");

            UIPanelTypeJson uiPlaneTypeJson = JsonUtility.FromJson<UIPanelTypeJson>(text.text);

            foreach (UIPanelInfo uiPanelInfo in uiPlaneTypeJson.InfoList)
            {
                PanelPathDict.Add(uiPanelInfo.panelType, uiPanelInfo.path);
            }
        }


        public static void Test()
        {
            TextAsset text = Resources.Load<TextAsset>("UIPanelType");

            UIPanelTypeJson uiPlaneTypeJson = JsonUtility.FromJson<UIPanelTypeJson>(text.text);

            Debug.Log("Test:" + text.text);

            foreach (UIPanelInfo uiPanelInfo in uiPlaneTypeJson.InfoList)
            {
                Debug.Log($"Type: {uiPanelInfo.panelType} Path: {uiPanelInfo.path}");
            }
        }


        /// <summary>
        /// 测试一种新的序列化方式
        /// </summary>
        public static void TestInfoStr()
        {
            TextAsset text = Resources.Load<TextAsset>("UIPanelTypeStr");

            UIPanelTypeStrJson uiPlaneTypeJson = JsonUtility.FromJson<UIPanelTypeStrJson>(text.text);

            Debug.Log("Test:" + text.text);

            foreach (UIPanelInfoStr uiPanelInfoStr in uiPlaneTypeJson.InfoList)
            {
                Debug.Log($"Type: {uiPanelInfoStr.panelType} Path: {uiPanelInfoStr.path}");
            }
        }
    }
}