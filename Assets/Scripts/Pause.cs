using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public bool Paused = false;
    public GameObject PauseMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
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
    }

    void PausePlay()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        Paused = true;
    }
}
