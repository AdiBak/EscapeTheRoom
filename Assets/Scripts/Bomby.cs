using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomby : MonoBehaviour
{
    public GameObject exp;
    public float expForce, radius;
    // Start is called before the first frame update
   

    private void OnCollisionEnter(Collision other){
        GameObject _exp = Instantiate(exp,transform.position, transform.rotation);
        Destroy(_exp, 3);
        knockBack();
        Destroy(gameObject);
    }
    void knockBack(){
        Collider[] colliders = Physics.OverlapSphere(transform.position,radius);
        foreach (Collider nearyby in colliders){
            Rigidbody rigg = nearyby.GetComponent<Rigidbody>();
            if (rigg != null){
                rigg.AddExplosionForce(expForce, transform.position, radius);
                
            }
        }
    }
}
