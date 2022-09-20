using UnityEngine;
using UnityEngine.UI;
public class NumberGenerator : MonoBehaviour
{
    public int currentNumber;
    public Image numberSprite;
    public Sprite[] diceSprites;
    void Start()
    {
        GetNewNumber();
    }
    public void GetNewNumber()
    {
        currentNumber = Random.Range(1, 7);
        numberSprite.sprite = diceSprites[currentNumber];
    }
}
