using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DADA : MonoBehaviour
{
    public int enemiesKilled = 0;

    void Start()
    {
        Health.OnEnemyKilled += HandleEnemyKilled;
    }

 
    void Update()
    {
   
    }
    private void HandleEnemyKilled()
    {
        enemiesKilled++;
    }
}
