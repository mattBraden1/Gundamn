using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    [SerializeField]
    private EnemyHealth enemyHealth;
    public GameObject winScreenUI;
    [SerializeField]
    private PlayerDeath playerDeath;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (enemyHealth.getCurrentHealth() == 0)
        {
            playerDeath.hasWon(true);
            winScreenUI.SetActive(true);
        }

    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
