using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UI : MonoBehaviour
{
    public Health healthManager;
    public Shooter Ammos;

    private Text UITEXT;  

    void Start()
    {
        UITEXT = GetComponent<Text>();  
    }

    void Update()
    {
        int health;
        float healthf = healthManager.currentHealth;
        health = (int)healthf;
        UITEXT.text = "Health: " + health + " Ammo: " + Ammos.bullets;
    }

}
