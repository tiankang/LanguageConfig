﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace TKFrameWork
{
    public class GameApp : MonoBehaviour
    {
        private Canvas mCanvas;

        private SerializableSet configSet;
        private void Awake()
        {
            mCanvas = GameObject.Find("Canvas").GetComponent<Canvas>();
            
            if (mCanvas == null)
            {
                Debug.LogError("未找到Canvas");
                return;
            }

            configSet = Resources.Load<SerializableSet>("Config/SerializableSet");
            Deserializer.Deserialize(configSet);
            Resources.UnloadUnusedAssets();

            Debug.Log(LanguageConfigSheet.Get(20).Text);

            GameObject go = GameObject.Instantiate(Resources.Load<GameObject>("UIPrefab/UIPanel"));
            go.transform.SetParent(mCanvas.transform,false);
        }
    }
}
