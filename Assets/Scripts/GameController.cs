using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameController : MonoBehaviour
{
    public GameObject gameController;
    public int[] playerValues;
    public int[] enemyValues;
    public GameObject[] playerButtons;
    public GameObject[] enemyButtons;
    public GameObject endScreen;
    public Sprite[] diceSprites;
    public TMP_Text playerCol1Text, playerCol2Text, playerCol3Text, playerFinText;
    public TMP_Text enemyCol1Text, enemyCol2Text, enemyCol3Text, enemyFinText;
    public TMP_Text whoWon, playerScore, enemyScore;
    private int playerCol1Sum, playerCol2Sum, playerCol3Sum, playerFinSum;
    private int enemyCol1Sum, enemyCol2Sum, enemyCol3Sum, enemyFinSum;
    public void SetNumber(int buttonNumber, bool isPlayerButton)
    {
        int currentNumber = gameController.GetComponent<NumberGenerator>().currentNumber;
        gameController.GetComponent<NumberGenerator>().GetNewNumber();
        if(isPlayerButton)
        {
            playerValues[buttonNumber] = currentNumber;
            playerButtons[buttonNumber].GetComponent<Image>().sprite = diceSprites[currentNumber];
            playerButtons[buttonNumber].GetComponent<Button>().interactable = false;
            DestroyDice(buttonNumber, true);
            UpdateSum();
            CheckGameEnd();
        }
        else
        {
            enemyValues[buttonNumber] = currentNumber;
            enemyButtons[buttonNumber].GetComponent<Image>().sprite = diceSprites[currentNumber];
            enemyButtons[buttonNumber].GetComponent<Button>().interactable = false;
            DestroyDice(buttonNumber, false);
            UpdateSum();
            CheckGameEnd();
        }
    }

    public void DestroyDice(int buttonNumber, bool isPlayerButton)
    {
        if(isPlayerButton)
        {
            if(buttonNumber == 0 || buttonNumber == 3 || buttonNumber == 6)
            {
                if(enemyValues[0] == playerValues[buttonNumber])
                {
                    enemyValues[0] = 0;
                    enemyButtons[0].GetComponent<Image>().sprite = diceSprites[0];
                    enemyButtons[0].GetComponent<Button>().interactable = true;
                }
                if(enemyValues[3] == playerValues[buttonNumber])
                {
                    enemyValues[3] = 0;
                    enemyButtons[3].GetComponent<Image>().sprite = diceSprites[0];
                    enemyButtons[3].GetComponent<Button>().interactable = true;
                }
                if(enemyValues[6] == playerValues[buttonNumber])
                {
                    enemyValues[6] = 0;
                    enemyButtons[6].GetComponent<Image>().sprite = diceSprites[0];
                    enemyButtons[6].GetComponent<Button>().interactable = true;
                }
            }
            else if(buttonNumber == 1 || buttonNumber == 4 || buttonNumber == 7)
            {
                if(enemyValues[1] == playerValues[buttonNumber])
                {
                    enemyValues[1] = 0;
                    enemyButtons[1].GetComponent<Image>().sprite = diceSprites[0];
                    enemyButtons[1].GetComponent<Button>().interactable = true;
                }
                if(enemyValues[4] == playerValues[buttonNumber])
                {
                    enemyValues[4] = 0;
                    enemyButtons[4].GetComponent<Image>().sprite = diceSprites[0];
                    enemyButtons[4].GetComponent<Button>().interactable = true;
                }
                if(enemyValues[7] == playerValues[buttonNumber])
                {
                    enemyValues[7] = 0;
                    enemyButtons[7].GetComponent<Image>().sprite = diceSprites[0];
                    enemyButtons[7].GetComponent<Button>().interactable = true;
                }
            }
            else if(buttonNumber == 2 || buttonNumber == 5 || buttonNumber == 8)
            {
                if(enemyValues[2] == playerValues[buttonNumber])
                {
                    enemyValues[2] = 0;
                    enemyButtons[2].GetComponent<Image>().sprite = diceSprites[0];
                    enemyButtons[2].GetComponent<Button>().interactable = true;
                }
                if(enemyValues[5] == playerValues[buttonNumber])
                {
                    enemyValues[5] = 0;
                    enemyButtons[5].GetComponent<Image>().sprite = diceSprites[0];
                    enemyButtons[5].GetComponent<Button>().interactable = true;
                }
                if(enemyValues[8] == playerValues[buttonNumber])
                {
                    enemyValues[8] = 0;
                    enemyButtons[8].GetComponent<Image>().sprite = diceSprites[0];
                    enemyButtons[8].GetComponent<Button>().interactable = true;
                }
            }
        }
        else
        {
           if(buttonNumber == 0 || buttonNumber == 3 || buttonNumber == 6)
            {
                if(playerValues[0] == enemyValues[buttonNumber])
                {
                    playerValues[0] = 0;
                    playerButtons[0].GetComponent<Image>().sprite = diceSprites[0];
                    playerButtons[0].GetComponent<Button>().interactable = true;
                }
                if(playerValues[3] == enemyValues[buttonNumber])
                {
                    playerValues[3] = 0;
                    playerButtons[3].GetComponent<Image>().sprite = diceSprites[0];
                    playerButtons[3].GetComponent<Button>().interactable = true;
                }
                if(playerValues[6] == enemyValues[buttonNumber])
                {
                    playerValues[6] = 0;
                    playerButtons[6].GetComponent<Image>().sprite = diceSprites[0];
                    playerButtons[6].GetComponent<Button>().interactable = true;
                }
            }
            else if(buttonNumber == 1 || buttonNumber == 4 || buttonNumber == 7)
            {
                if(playerValues[1] == enemyValues[buttonNumber])
                {
                    playerValues[1] = 0;
                    playerButtons[1].GetComponent<Image>().sprite = diceSprites[0];
                    playerButtons[1].GetComponent<Button>().interactable = true;
                }
                if(playerValues[4] == enemyValues[buttonNumber])
                {
                    playerValues[4] = 0;
                    playerButtons[4].GetComponent<Image>().sprite = diceSprites[0];
                    playerButtons[4].GetComponent<Button>().interactable = true;
                }
                if(playerValues[7] == enemyValues[buttonNumber])
                {
                    playerValues[7] = 0;
                    playerButtons[7].GetComponent<Image>().sprite = diceSprites[0];
                    playerButtons[7].GetComponent<Button>().interactable = true;
                }
            }
            else if(buttonNumber == 2 || buttonNumber == 5 || buttonNumber == 8)
            {
                if(playerValues[2] == enemyValues[buttonNumber])
                {
                    playerValues[2] = 0;
                    playerButtons[2].GetComponent<Image>().sprite = diceSprites[0];
                    playerButtons[2].GetComponent<Button>().interactable = true;
                }
                if(playerValues[5] == enemyValues[buttonNumber])
                {
                    playerValues[5] = 0;
                    playerButtons[5].GetComponent<Image>().sprite = diceSprites[0];
                    playerButtons[5].GetComponent<Button>().interactable = true;
                }
                if(playerValues[8] == enemyValues[buttonNumber])
                {
                    playerValues[8] = 0;
                    playerButtons[8].GetComponent<Image>().sprite = diceSprites[0];
                    playerButtons[8].GetComponent<Button>().interactable = true;
                }
            } 
        }
    }
    public void UpdateSum()
    {
        if(playerValues[0] == playerValues[3] && playerValues[3] == playerValues[6] && playerValues[0] > 1)
        {
            playerCol1Sum = Mathf.RoundToInt(Mathf.Pow(playerValues[0], 3));
        }
        else if(playerValues[0] == playerValues[3] && playerValues[0] > 1)
        {
            playerCol1Sum = Mathf.RoundToInt(Mathf.Pow(playerValues[0], 2)) + playerValues[6];
        }
        else if(playerValues[0] == playerValues[6] && playerValues[0] > 1)
        {
            playerCol1Sum = Mathf.RoundToInt(Mathf.Pow(playerValues[0], 2)) + playerValues[3];
        }
        else if(playerValues[3] == playerValues[6] && playerValues[3] > 1)
        {
            playerCol1Sum = Mathf.RoundToInt(Mathf.Pow(playerValues[3], 2)) + playerValues[0];
        }
        else
        {
            playerCol1Sum = playerValues[0] + playerValues[3] + playerValues[6]; 
        }
        


        if(playerValues[1] == playerValues[4] && playerValues[4] == playerValues[7] && playerValues[1] > 1)
        {
            playerCol2Sum = Mathf.RoundToInt(Mathf.Pow(playerValues[1], 3));
        }
        else if(playerValues[1] == playerValues[4] && playerValues[1] > 1)
        {
            playerCol2Sum = Mathf.RoundToInt(Mathf.Pow(playerValues[1], 2)) + playerValues[7];
        }
        else if(playerValues[1] == playerValues[7] && playerValues[1] > 1)
        {
            playerCol2Sum = Mathf.RoundToInt(Mathf.Pow(playerValues[1], 2)) + playerValues[4];
        }
        else if(playerValues[4] == playerValues[7] && playerValues[4] > 1)
        {
            playerCol2Sum = Mathf.RoundToInt(Mathf.Pow(playerValues[4], 2)) + playerValues[1];
        }
        else
        {
            playerCol2Sum = playerValues[1] + playerValues[4] + playerValues[7]; 
        }



        if(playerValues[2] == playerValues[5] && playerValues[5] == playerValues[8] && playerValues[2] > 1)
        {
            playerCol3Sum = Mathf.RoundToInt(Mathf.Pow(playerValues[2], 3));
        }
        else if(playerValues[2] == playerValues[5] && playerValues[2] > 1)
        {
            playerCol3Sum = Mathf.RoundToInt(Mathf.Pow(playerValues[2], 2)) + playerValues[8];
        }
        else if(playerValues[2] == playerValues[8] && playerValues[2] > 1)
        {
            playerCol3Sum = Mathf.RoundToInt(Mathf.Pow(playerValues[2], 2)) + playerValues[5];
        }
        else if(playerValues[5] == playerValues[8] && playerValues[5] > 1)
        {
            playerCol3Sum = Mathf.RoundToInt(Mathf.Pow(playerValues[5], 2)) + playerValues[2];
        }
        else
        {
            playerCol3Sum = playerValues[2] + playerValues[5] + playerValues[8]; 
        }
        playerFinSum = playerCol1Sum + playerCol2Sum + playerCol3Sum;
        playerCol1Text.text = playerCol1Sum.ToString();
        playerCol2Text.text = playerCol2Sum.ToString();
        playerCol3Text.text = playerCol3Sum.ToString();
        playerFinText.text = playerFinSum.ToString();



        if(enemyValues[0] == enemyValues[3] && enemyValues[3] == enemyValues[6] && enemyValues[0] > 1)
        {
            enemyCol1Sum = Mathf.RoundToInt(Mathf.Pow(enemyValues[0], 3));
        }
        else if(enemyValues[0] == enemyValues[3]  && enemyValues[0] > 1)
        {
            enemyCol1Sum = Mathf.RoundToInt(Mathf.Pow(enemyValues[0], 2)) + enemyValues[6];
        }
        else if(enemyValues[0] == enemyValues[6]  && enemyValues[0] > 1)
        {
            enemyCol1Sum = Mathf.RoundToInt(Mathf.Pow(enemyValues[0], 2)) + enemyValues[3];
        }
        else if(enemyValues[3] == enemyValues[6]  && enemyValues[3] > 1)
        {
            enemyCol1Sum = Mathf.RoundToInt(Mathf.Pow(enemyValues[3], 2)) + enemyValues[0];
        }
        else
        {
            enemyCol1Sum = enemyValues[0] + enemyValues[3] + enemyValues[6]; 
        }
        


        if(enemyValues[1] == enemyValues[4] && enemyValues[4] == enemyValues[7] && enemyValues[1] > 1)
        {
            enemyCol2Sum = Mathf.RoundToInt(Mathf.Pow(enemyValues[1], 3));
        }
        else if(enemyValues[1] == enemyValues[4] && enemyValues[1] > 1)
        {
            enemyCol2Sum = Mathf.RoundToInt(Mathf.Pow(enemyValues[1], 2)) + enemyValues[7];
        }
        else if(enemyValues[1] == enemyValues[7] && enemyValues[1] > 1)
        {
            enemyCol2Sum = Mathf.RoundToInt(Mathf.Pow(enemyValues[1], 2)) + enemyValues[4];
        }
        else if(enemyValues[4] == enemyValues[7] && enemyValues[4] > 1)
        {
            enemyCol2Sum = Mathf.RoundToInt(Mathf.Pow(enemyValues[4], 2)) + enemyValues[1];
        }
        else
        {
            enemyCol2Sum = enemyValues[1] + enemyValues[4] + enemyValues[7]; 
        }



        if(enemyValues[2] == enemyValues[5] && enemyValues[5] == enemyValues[8] && enemyValues[2] > 1)
        {
            enemyCol3Sum = Mathf.RoundToInt(Mathf.Pow(enemyValues[2], 3));
        }
        else if(enemyValues[2] == enemyValues[5] && enemyValues[2] > 1)
        {
            enemyCol3Sum = Mathf.RoundToInt(Mathf.Pow(enemyValues[2], 2)) + enemyValues[8];
        }
        else if(enemyValues[2] == enemyValues[8] && enemyValues[2] > 1)
        {
            enemyCol3Sum = Mathf.RoundToInt(Mathf.Pow(enemyValues[2], 2)) + enemyValues[5];
        }
        else if(enemyValues[5] == enemyValues[8] && enemyValues[5] > 1)
        {
            enemyCol3Sum = Mathf.RoundToInt(Mathf.Pow(enemyValues[5], 2)) + enemyValues[2];
        }
        else
        {
            enemyCol3Sum = enemyValues[2] + enemyValues[5] + enemyValues[8]; 
        }
        enemyFinSum = enemyCol1Sum + enemyCol2Sum + enemyCol3Sum;
        enemyCol1Text.text = enemyCol1Sum.ToString();
        enemyCol2Text.text = enemyCol2Sum.ToString();
        enemyCol3Text.text = enemyCol3Sum.ToString();
        enemyFinText.text = enemyFinSum.ToString();
    }
    public void CheckGameEnd()
    {
        bool isGameEnd = true;
        foreach(int curValue in playerValues)
        {
            if(curValue == 0) isGameEnd = false;
        }
        if (isGameEnd)
        {
            if(playerFinSum > enemyFinSum) EndGame(true);
            else EndGame(false);
        }

        isGameEnd = true;
        foreach(int curValue in enemyValues)
        {
            if(curValue == 0) isGameEnd = false;
        }
        if (isGameEnd)
        {
            if(playerFinSum > enemyFinSum) EndGame(true);
            else EndGame(false);
        }
    }
    public void EndGame(bool hasPlayerWon)
    {
        foreach(GameObject curButton in playerButtons)
        {
            curButton.GetComponent<Button>().interactable = false;
        }
        foreach(GameObject curButton in enemyButtons)
        {
            curButton.GetComponent<Button>().interactable = false;
        }
        playerScore.text = "Player score: " + playerFinSum.ToString();
        enemyScore.text = "Enemy socre: " + enemyFinSum.ToString();
        if(hasPlayerWon) whoWon.text = "Player won!";
        else whoWon.text = "Enemy won!";
        endScreen.SetActive(true);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}