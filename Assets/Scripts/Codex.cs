using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Codex : MonoBehaviour
{
    public GameObject endmenu;
    public GameObject codexmenu;


    public void LoadCodex()
    {
        endmenu.SetActive(false);
        codexmenu.SetActive(true);

    }
}
