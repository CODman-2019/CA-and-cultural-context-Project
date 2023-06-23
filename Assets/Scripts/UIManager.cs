using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject show, hide, pause;
    public PlayerControls player;

    private void Start()
    {
        Resume();
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            show.SetActive(!show.active);
            hide.active = !hide.active;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            switch (pause.active)
            {
                case true:
                    Resume();
                    break;
                case false:
                    Pause();
                    break;
            }
        }
    }

    public void Pause()
    {
        player.DisablePlayer();
        Cursor.visible = true;
        pause.active = true;
    }

    public void Resume()
    {
        player.EnablePlayer();
        Cursor.visible = false;
        pause.active = false;

    }

    public void Quit()
    {
        Application.Quit();
    }
}
