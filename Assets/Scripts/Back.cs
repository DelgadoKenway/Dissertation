using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Back : MonoBehaviour
{
    public GameObject Current;
    public GameObject Previous;

    public void Return()
    {
        Current.SetActive(false);
        Previous.SetActive(true);


    }

}
