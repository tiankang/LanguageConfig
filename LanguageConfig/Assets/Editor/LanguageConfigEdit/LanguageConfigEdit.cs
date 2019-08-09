using System;
using System.Collections.Generic;
using UnityEditor;

namespace GameEdit
{
    public class LanguageConfigEdit : Editor
    {
        private static string uiPrefabPath = "UI";
        /// <summary>
        /// 生成Text.text 到excel
        /// </summary>
        [MenuItem("Tools/生成语言配置")]
        public static void WriteLanguageConfigToExcel()
        {

        }
    }
}
