using UnityEngine;
using TMPro;
public class PlayerHealth : MonoBehaviour
{
    public int health = 100;
    public TMP_Text healthText;

    
    void Start()
    {
        healthText.text = "Health: " + health;
    }
    void Update()
    {
        healthText.text = "Health: " + health;
    }


}