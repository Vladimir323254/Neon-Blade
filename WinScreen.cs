using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScreen : MonoBehaviour
{

    private Text UITEXT;

    void Start()
    {
        UITEXT = GetComponent<Text>();
    }

    void Update()
    {
    int EnemyValue1;
    GameObject EnemyObject = GameObject.Find("Helper");
    DADA EnemyComponent = EnemyObject.GetComponentInChildren<DADA>();
    EnemyValue1 = EnemyComponent.enemiesKilled;
    int achievementValue;
    GameObject healthObject = GameObject.Find("Player");
    Health healthComponent = healthObject.GetComponentInChildren<Health>();
    achievementValue = healthComponent.Achivment;
    UITEXT.text = "Achivment " + achievementValue + "Killed Enemy " + EnemyValue1;
    }
    
}
