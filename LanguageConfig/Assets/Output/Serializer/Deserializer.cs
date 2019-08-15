public class Deserializer
{
    public static void Deserialize(SerializableSet set)
    {
       
        for (int i = 0, l = set.LanguageConfigs.Length; i < l; i++)
        {
            LanguageConfigSheet.GetDictionary().Add(set.LanguageConfigs[i].LanguageID, set.LanguageConfigs[i]);
        }


    }
}
