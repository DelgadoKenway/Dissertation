using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsLvl : MonoBehaviour
{
    public GameObject Opts;
    public GameObject PMenu;

    public void Options()
    {
        Opts.SetActive(true);
        PMenu.SetActive(false);


    }
}
