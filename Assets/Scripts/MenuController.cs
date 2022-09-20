using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuController : MonoBehaviour
{
    public GameObject rulesScreen;
    public int currentRule = 0, rulesAmount;
    public string[] rules;
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
        ruleText.text = rules[currentRule];
        ruleSprite.GetComponent<Image>().sprite = images[currentRule];
    }
    public void StartGame()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
