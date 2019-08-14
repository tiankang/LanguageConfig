using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("UI/LanguageText")]
public class LanguageText : Text
{
    [SerializeField]
    /// <summary>
    ///对应表里的ID
    /// </summary>
    public uint mLanguageId;

    protected override void Awake()
    {
        base.Awake();

        if (mLanguageId != 0)
        {
            text = LanguageConfigSheet.Get(mLanguageId).Text;
        }
    }

}
