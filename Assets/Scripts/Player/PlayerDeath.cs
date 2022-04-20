using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
{
    [SerializeField]
    private PlayerHealth playerHealth;
    [SerializeField]
    private Canvas canvas;
    [SerializeField]
    private GameObject gameOver;
    [SerializeField]
    private SpriteRenderer ship;
    private bool isDead = false;
    private bool wonGame = false;
    [SerializeField]
    private PlayerShooting playerShooting;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth.getCurrentHealth() <= 0 && !isDead && !wonGame)
        {
            isDead = true;
            Instantiate(gameOver,canvas.transform);
            Destroy(ship.gameObject);
            playerShooting.shootingEnabled(false);
        }
    }

    public void hasWon(bool a)
    {
        wonGame = a;
    }
}
