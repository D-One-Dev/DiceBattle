using UnityEngine;
using TMPro;

public class TextLocalisation : MonoBehaviour
{
    private int language;
    public string[] texts;
    void Start()
    {
        language = PlayerPrefs.GetInt("language", -1);
        if(language == -1) Debug.Log("Language number not set");
        else
        {
            if(gameObject.GetComponent<TMP_Text>() == null) Debug.LogError("TMP_Text not found");
            else
            {
                gameObject.GetComponent<TMP_Text>().text = texts[language];
            }
        }
    }
}
