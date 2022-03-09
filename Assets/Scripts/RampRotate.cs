using UnityEngine;

public class RampRotate : MonoBehaviour
{
    public bool canTilt = false;
    float degrees = 90;
    void Update()
    {
        
        Vector3 to = new Vector3(degrees, 0, 0);

        if (canTilt){
            transform.eulerAngles = Vector3.Lerp(transform.rotation.eulerAngles, to, Time.deltaTime * 0.01f);

        }
   }
}