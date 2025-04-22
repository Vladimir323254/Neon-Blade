using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishScript : MonoBehaviour
{
    public GameObject WinScreen;
    public GameObject LoseScreen;

    private void Start()
    {
        WinScreen.SetActive(false);
        LoseScreen.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Finish"))
        {
            WinScreen.SetActive(true);
            Time.timeScale = 0;
        }
        if (collision.CompareTag("Respawn"))
        {
            LoseScreen.SetActive(true);
            Time.timeScale = 0;
        }
    }
    

}
