using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuController : MonoBehaviour
{
    public GameObject rulesScreen;
    public int currentRule = 0, rulesAmount;
    public string[] rulesRus, rulesEng;
    public Sprite[] images;
    public TMP_Text ruleText;
    public GameObject ruleSprite;
    public Button nextRule, previousRule;
    public void ShowRules()
    {
        rulesScreen.SetActive(true);
        previousRule.GetComponent<Button>().interactable = false;
        nextRule.GetComponent<Button>().interactable = true;
        currentRule = 0;
        UpdateRule();
    }
    public void HideRules()
    {
        rulesScreen.SetActive(false);
    }
    public void NextRule()
    {
        currentRule ++;
        previousRule.GetComponent<Button>().interactable = true;
        if(currentRule == rulesAmount - 1)
        {
            nextRule.GetComponent<Button>().interactable = false;
        }
        UpdateRule();
    }
    public void PreviousRule()
    {
        currentRule --;
        nextRule.GetComponent<Button>().interactable = true;
        if(currentRule == 0)
        {
            previousRule.GetComponent<Button>().interactable = false;
        }
        UpdateRule();
    }
    public void UpdateRule()
    {
        if(PlayerPrefs.GetInt("language", 0) == 0) ruleText.text = rulesEng[currentRule];
        else if (PlayerPrefs.GetInt("language", 0) == 1) ruleText.text = rulesRus[currentRule];
        ruleSprite.GetComponent<Image>().sprite = images[currentRule];
    }
    public void StartGameWithAI()
    {
        PlayerPrefs.SetInt("isAiOn", 1);
        SceneManager.LoadScene("Gameplay");
    }
    public void StartGameWithPlayer()
    {
        PlayerPrefs.SetInt("isAiOn", 0);
        SceneManager.LoadScene("Gameplay");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
