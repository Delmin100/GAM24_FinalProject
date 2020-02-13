using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class PlayerShooting : MonoBehaviour 
{
    public UnityEvent ChangeNone;
    public UnityEvent ChangeOne;
    public UnityEvent ChangeTwo;

	// Use this for initialization
	void Start () 
    {
        ChangeNone.Invoke();
	}
	
	// Update is called once per frame
	void Update () 

    {
        if(Input.GetKeyDown(KeyCode.Q))
            {

                ChangeOne.Invoke();
            }

        if(Input.GetKeyDown(KeyCode.E))
            {

                    ChangeTwo.Invoke();
            }

	}



}
