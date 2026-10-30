using UnityEngine;

public class GameManager : MonoBehaviour
{
    static private GameManager instance;
    static public GameManager Instance
    {
        get => instance;
    }
    private void Awake()
    {
        if((instance != null)&&(instance!=this))
        {
            Destroy(gameObject);
        }
        instance = this;
    }
    private int score = 0;
    private bool isGameOver = false;
    public void AddScore(int amount)
    {
        score += amount;
    }
    public bool GetGameOver()
    {
        return isGameOver;
    }
    
}
