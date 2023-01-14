using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpController : MonoBehaviour
{
    public GameObject player;
    public GameObject keys;
    public bool canPick;
    public bool isPicked;
    // Start is called before the first frame update
    void Start()
    {
        canPick = false;
        isPicked = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="object")
        {
            canPick = true;
            keys = other.gameObject;
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        canPick = false;
    }

    void Update()
    {

        if (canPick == true) 
        {
            if (Input.GetKeyDown("e")) 
            {
                keys.GetComponent<Rigidbody>().isKinematic = true;   
                keys.transform.position = player.transform.position;
                keys.transform.parent =keys.transform; 
                isPicked = true;
                keys.SetActive(false);
                
            }
        }
        if (Input.GetKeyDown("q") && isPicked == true) 
        {
            keys.GetComponent<Rigidbody>().isKinematic = false; 

            keys.transform.parent = null;
            isPicked = false;
        }
    }
}
