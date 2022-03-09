using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boaty : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other){
        if (other.gameObject.tag == "player"){
            transform.parent = other.transform;
            GameObject[] walls = GameObject.FindGameObjectsWithTag("wall");
            for (int i = 0; i < walls.Length; i++){
                walls[i].AddComponent<Rigidbody>();
            }
        }
    }
    void OnCollisionExit(Collision other){
     if(other.gameObject.tag == "platform"){
             transform.parent = null;
             
         }
     }    

}
