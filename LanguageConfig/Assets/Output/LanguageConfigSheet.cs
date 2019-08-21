using System.Collections.Generic;

[System.Serializable]
public class LanguageConfigSheet
{
    /// <summary>
    /// 语言ID
    /// </summary>
    public uint LanguageID;

    /// <summary>
    /// 文字
    /// </summary>
    public string Text;


    private static Dictionary<uint, LanguageConfigSheet> dictionary = new Dictionary<uint, LanguageConfigSheet>();

    /// <summary>
    /// 通过LanguageID获取LanguageConfigSheet的实例
    /// </summary>
    /// <param name="LanguageID">索引</param>
    /// <returns>LanguageConfigSheet的实例</returns>
    public static LanguageConfigSheet Get(uint LanguageID)
    {
        LanguageConfigSheet sheet;
        if (dictionary.TryGetValue(LanguageID, out sheet))
        {
            return sheet;
        }

        return null;
    }
    
    /// <summary>
    /// 获取字典
    /// </summary>
    /// <returns>字典</returns>
    public static Dictionary<uint, LanguageConfigSheet> GetDictionary()
    {
        return dictionary;
    }
}
