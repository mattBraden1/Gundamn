using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer irisIcon;
    [SerializeField]
    private EnemyHealth health;
    private float otherColors = 255;
    void Update()
    {
        otherColors = 255 * (health.getCurrentHealth() / health.getMaxHealth());
        irisIcon.color = new Color(255/255, otherColors/255, otherColors/255);
    }
}
