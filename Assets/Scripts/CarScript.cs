using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    public bool switchy = false;
    
        
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (switchy){
            player.transform.SetParent(this.gameObject.transform);
            player.transform.position = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y + 1.5f, this.gameObject.transform.position.z);
        } else {
            player.transform.SetParent(null);
        }
    }

    void OnMouseDown(){
        switchy = !switchy;
        
    }
}
