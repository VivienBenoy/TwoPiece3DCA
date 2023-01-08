using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimaController : MonoBehaviour
{
    public GameObject player;
   
    void Update()
    {
        if(Input.GetButtonDown("Front"))
        {
            player.GetComponent<Animator>().Play("RunForward");
        }
        if (Input.GetButtonDown("Backward"))
        {
            player.GetComponent<Animator>().Play("RunBackward");
        }
        if (Input.GetButtonDown("Left"))
        {
            player.GetComponent<Animator>().Play("StrafeLeft");
        }
        if (Input.GetButtonDown("Right"))
        {
            player.GetComponent<Animator>().Play("StrafeRight");
        }
        
    }
}
