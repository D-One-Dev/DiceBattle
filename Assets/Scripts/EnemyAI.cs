using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public GameObject gameController;
    public int ReturnBestPos(int[] values)
    {
        int pos = Random.Range(0,9);
        if(values[pos] == 0) return pos;
        else return ReturnBestPos(values);
    }
}
