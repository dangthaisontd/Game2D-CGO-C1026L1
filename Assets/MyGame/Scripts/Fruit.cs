using UnityEngine;

public class Fruit : MonoBehaviour
{
    [Header("Fruit Setting")]
    [SerializeField] int scoreValue = 1;
    private bool collected = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collected) return;
        if (GameManager.Instance.GetGameOver())
            return;
        if (collision.gameObject.CompareTag("Player"))
        {
            collected = true;
            GameManager.Instance.AddScore(scoreValue);
        }
        Destroy(gameObject);
    }
}
