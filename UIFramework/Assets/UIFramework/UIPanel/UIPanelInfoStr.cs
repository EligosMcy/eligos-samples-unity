using System;
using UnityEngine;

namespace UIFramework.UIPanel
{
    [Serializable]
    public class UIPanelInfoStr : ISerializationCallbackReceiver
    {
        //当遇到类型是再其他dll文件中,不能添加可序列时
        //就需要使用ISerializationCallbackReceiver
        [NonSerialized]
        public UIPanelType panelType;

        public string panelTypeString;

        public string path;

        //序列化前,修改到对应的string,方便序列化使用
        public void OnBeforeSerialize()
        {
            panelTypeString = panelType.ToString();
        }


        //序列化后,因为UIPanelType,不能直接转换,在序列化后在获取对应的枚举
        public void OnAfterDeserialize()
        {
            UIPanelType type = Enum.Parse<UIPanelType>(panelTypeString);
            panelType = type;
        }
    }
}