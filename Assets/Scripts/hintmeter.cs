using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hintmeter : MonoBehaviour
{
    public float rb = 1f;
    public float colortimer = 0;
    public static string hintready = "n";
    public static string hintused = "n";

    

    public Transform hintglow;



    // Use this for initialization
    void Start()
    {
        ParticleSystem ps = hintglow.GetComponent<ParticleSystem>();
        var em = ps.emission;
        em.enabled = false;        

    }

    // Update is called once per frame
    void Update()
    {
        colortimer += Time.deltaTime; //How fast the hint meter charges based on time, not on frames.

        if ((colortimer >= .5) && (rb > 0))
        {
            rb -= .05f;
            colortimer = 0;
        }

        GetComponent<SpriteRenderer>().color = new Color(rb, rb, 1); //Color on RGB scale.

        if (rb <= 0)
        {
            hintready = "y";
            ParticleSystem ps = hintglow.GetComponent<ParticleSystem>();
            var em = ps.emission;
            em.enabled = true;

        }
    }

    void OnMouseDown()
    {
        if (hintready == "y")
        {
            
            hintused = "y";
            hintready = "n";
            rb = 1f;
            ParticleSystem ps = hintglow.GetComponent<ParticleSystem>();
            var em = ps.emission;
            em.enabled = false;
        }
    }
}
