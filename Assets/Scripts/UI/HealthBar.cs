using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField]
    private PlayerHealth playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(playerHealth.getCurrentHealth() + " " + playerHealth.getMaxHealth());
        gameObject.GetComponent<Image>().fillAmount = playerHealth.getCurrentHealth() / playerHealth.getMaxHealth();
    }
}
