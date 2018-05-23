using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VirtureBtn : MonoBehaviour , IVirtualButtonEventHandler{

    public string btnName;
    public GameObject Player;
    public Animator cubeAni;
    public Canvas message;
    public bool change = false;
    private int condition = 0;

    // Use this for initialization
    void Start () {

        message.gameObject.SetActive(false);
        Player = GameObject.Find(btnName);
        Player.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        

        cubeAni.GetComponent<Animator>();


    }

 

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
    
        message.gameObject.SetActive(true);
        if (!change)
        {
            if (condition > 3)
            {
                condition = 0;
            }
            cubeAni.SetInteger("Condition", condition);
            condition++;
            change = true;
        }

        
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //message.gameObject.SetActive(false);
        change = false;
    }
    
}
