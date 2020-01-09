using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauza;
    public KeyCode pauseBut;
    public static string gamepause = "n";

    void Update()
    {
        if (Input.GetKeyDown (pauseBut) && gamepause == "n")
        {
            pauza.SetActive(true);
            gamepause = "y";
        }

        else
            if (Input.GetKeyDown (pauseBut) && gamepause == "y")
        {
            pauza.SetActive(false);
            gamepause = "n";
        }
        

    }
}
