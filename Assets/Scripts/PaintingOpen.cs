using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Input;
public class PaintingOpen : MonoBehaviour
{
    private bool isOpen;
    public Transform originalPos;
    public Transform newPos;
    // Start is called before the first frame update
    void Start()
    {
        isOpen = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Uncover(bool canOpen){
        if (canOpen){
            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 90);
           // transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 90);
            transform.position = newPos.transform.position; //new Vector3(-153, transform.position.y, transform.position.z);
        } else {
            transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 0);
           // transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 0);
            transform.position = originalPos.transform.position;//new Vector3(-157, transform.position.y, transform.position.z);
        }
    }
   /* void OnMouseDown(){
        isOpen = !isOpen;
        Uncover(isOpen);
    }*/
}
