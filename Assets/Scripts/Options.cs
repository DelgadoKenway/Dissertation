using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Options : MonoBehaviour
{

    public GameObject Current;
    public GameObject Previous;

    public void BackLvls()
    {
        Current.SetActive(false);
        Previous.SetActive(true);

    }
}
