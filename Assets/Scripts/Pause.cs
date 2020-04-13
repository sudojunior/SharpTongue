using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool Paused = false;
    public GameObject PauseMenu;
    [SerializeField]
    private GameObject Player;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Paused)
            {
                ResumePlay();
            }
            else
            {
                PausePlay();
            }
        }
    }

    public void ResumePlay()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
        Player.GetComponent<Animator>().enabled = true;
    }

    void PausePlay()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        Paused = true;
        Player.GetComponent<Animator>().enabled = false;

    }

    public void Quit()
    {
        Quit();
    }
}
