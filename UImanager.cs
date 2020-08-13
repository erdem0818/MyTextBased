using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    public Image Health;
    [SerializeField] Text HealthText;

    void Start()
    {
        Enemy._enemy += ChangeBar;
    }
    private void OnDestroy()
    {
        Enemy._enemy -= ChangeBar;
    }
    void ChangeBar(Enemy enemy)
    {
        float health = enemy._Health;
        string healthString = health.ToString();
        HealthText.text = healthString;

        Health.fillAmount = health /10;
    }
}
