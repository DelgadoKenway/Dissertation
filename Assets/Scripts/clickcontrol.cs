using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class clickcontrol : MonoBehaviour
{
    //On Click
    public static string nameofobj;
    public GameObject objnametext;
    public Transform objnametextPos;
    public Transform sucessclick;

    //End Menu
    public GameObject endmenu;
    

    //AudioSource
    public AudioSource pick;
    public AudioClip clip;
    public AudioClip lvlbg;
    public AudioClip victory;
    //public AudioClip clip1;

    

    private int randNumb = 0;
    private static int count;

    void Awake()
    {
        endmenu.SetActive(false);
        count = 0;
        pick = GetComponent<AudioSource>();
        pick.clip = lvlbg;
        pick.Play();

    }


    // Start is called before the first frame update
    void Start()
    {
        
        

    }

    // Update is called once per frame
    void Update()
    {
        if (hintmeter.hintused == "y")
        {
            randNumb = Random.Range(1, 6);


            if ((gameObject.name == "spear") && (randNumb == 1))
            {
                GetComponent<MeshRenderer>().material.color = new Color(0f / 255f, 255f / 255f, 255f / 255f);
                GetComponent<MeshRenderer>().receiveShadows = false;
                hintmeter.hintused = "n";
            }


            if ((gameObject.name == "sword_2h") && (randNumb == 2))
            {
                GetComponent<MeshRenderer>().material.color = new Color(0f / 255f, 255f / 255f, 255f / 255f);
                GetComponent<MeshRenderer>().receiveShadows = false;
                hintmeter.hintused = "n";
            }


            if ((gameObject.name == "axe_2h") && (randNumb == 3))
            {
                GetComponent<MeshRenderer>().material.color = new Color(0f / 255f, 255f / 255f, 255f / 255f);
                GetComponent<MeshRenderer>().receiveShadows = false;
                hintmeter.hintused = "n";
            }


            if ((gameObject.name == "Shield01") && (randNumb == 4))
            {                
                GetComponent<MeshRenderer>().material.color = new Color(0f / 255f, 255f / 255f, 255f / 255f);
                GetComponent<MeshRenderer>().receiveShadows = false;
                hintmeter.hintused = "n";

            }

            if ((gameObject.name == "dagger") && (randNumb == 5))
            {
                GetComponent<MeshRenderer>().material.color = new Color(0f / 255f, 255f / 255f, 255f / 255f);
                GetComponent<MeshRenderer>().receiveShadows = false;
                hintmeter.hintused = "n";
            }


        }

        
    }
    
    void OnMouseDown()

    {
        nameofobj = gameObject.name;
        pick.clip = clip;
        pick.Play();
        //Debug.Log (nameofobj);
        Destroy(gameObject, pick.clip.length);
        Destroy(objnametext, pick.clip.length);
        count++;

        //trackingclicks.totalclicks = 0;
        Instantiate(sucessclick, objnametextPos.position, sucessclick.rotation);        
        Debug.Log (count);

        if (count >= 5)
        {
            
            endmenu.SetActive(true);
            AudioListener.pause = true;
            

            if (endmenu.active == true)
            {
                
                
            }

        }
    }


}
