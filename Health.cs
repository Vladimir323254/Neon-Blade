using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    [SerializeField] private Animator anim;
    public float currentHealth;
    private bool isAlive;
    public GameObject LoseScreen;
    public int Achivment;
    public delegate void EnemyKilled();
    public static event EnemyKilled OnEnemyKilled;

    private void Awake()
    {
        currentHealth = maxHealth;
        isAlive = true;
    }
    public void TakeDamage(float damage)
    {
        currentHealth -= damage;
        CheckIsAlive();
    }
    public void TakeHealer()
    {
        currentHealth += 1;

    }
    

    private void CheckIsAlive()
    {
        if (currentHealth > 0)
            isAlive = true;
        else
        {
           
            isAlive = false;
            anim.SetBool("isAlive", false);
            Invoke("DelayedMethod", 0.6f);
            Invoke("ShowLoseScreen", 0.55f);
            
        }
    }
    public void DelayedMethod()
    {

        Destroy(gameObject);
    }
    public void ShowLoseScreen()
    {
        LoseScreen.SetActive(true);
        Time.timeScale = 0;
    }
    private void OnDestroy()
    {
        if (OnEnemyKilled != null)
        {
            OnEnemyKilled();
        }
    }


    public void GetAchive()
    {
        Achivment +=1 ;
        
    }
    
}
