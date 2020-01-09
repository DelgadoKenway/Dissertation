using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackingclicks : MonoBehaviour
{
    public static int totalclicks = 0;
    public KeyCode mouseclick;
       
    void Update()
    {

        if (Input.GetKeyDown(mouseclick))
        {
            totalclicks += 1;          

        }

        if (totalclicks >= 5)
        {
            //Debug.Log("FAIL!!!");
            totalclicks = 0;
        }

    }
}
