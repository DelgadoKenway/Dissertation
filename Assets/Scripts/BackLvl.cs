using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackLvl : MonoBehaviour
{
    public GameObject Current;
    public GameObject Previous;

    public void BackLvls()
    {
        Current.SetActive(false);
        Previous.SetActive(true);

    }
}
