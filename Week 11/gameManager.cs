using Unity.VisualScripting;
using UnityEngine;
public class GameManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public GameObject player;
    public GameObject gameOverUI;
void Start()
    {
    }
    void Update()
    {
        GameEnd();
    }
    void GameEnd()
    {
        if (playerHealth.health <= 0)
        {
            playerHealth.healthText.text = "Health: 0";
            player.SetActive(false);
            gameOverUI.SetActive(true);
        }
    }
}