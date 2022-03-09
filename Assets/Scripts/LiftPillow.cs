using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftPillow : MonoBehaviour
{
    public Transform originalPos;
    public Transform newPos;
    private bool lifted = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Lift(bool canOpen){
        if (canOpen){
          //  transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 90);
           // transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 90);
            transform.position = newPos.transform.position; //new Vector3(-153, transform.position.y, transform.position.z);
        } else {
            //transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 0);
           // transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 0);
            transform.position = originalPos.transform.position;//new Vector3(-157, transform.position.y, transform.position.z);
        }
    }

    /*void OnMouseDown(){
        lifted = !lifted;
        Lift(lifted);
    }*/
}
