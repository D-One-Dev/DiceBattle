using UnityEngine;
using UnityEngine.SceneManagement;
public class LocalisationController : MonoBehaviour
{
    public int language;
    private void Start() 
    {
        language = PlayerPrefs.GetInt("language", -1);
        if(language == -1)
        {
            if(Application.systemLanguage == SystemLanguage.English)
            {
                PlayerPrefs.SetInt("language", 0);
                SceneManager.LoadScene("Menu");
            }
            else
            {
                PlayerPrefs.SetInt("language", 1);
                SceneManager.LoadScene("Menu");
            }
        }
    }
    public void ChangeLanguage(int curLanguage)
    {
        PlayerPrefs.SetInt("language", curLanguage);
        SceneManager.LoadScene("Menu");
    }
}
