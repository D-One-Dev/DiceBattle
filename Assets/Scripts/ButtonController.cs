using UnityEngine;

public class ButtonController : MonoBehaviour
{
    public GameObject gameController;
    public bool isPlayerButton;
    public int buttonNumber;
    public void OnPress()
    {
        gameController.GetComponent<GameController>().SetNumber(buttonNumber, isPlayerButton);
    }
}
