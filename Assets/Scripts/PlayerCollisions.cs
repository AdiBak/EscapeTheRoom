using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerCollisions : MonoBehaviour
{
    public GameObject batCt;
    public GameObject goodJob;
    public static bool isOnEnd = false;
    public GameObject timerTxt;
    public GameObject safeBox;
    
    public static int numBats = 0;
    public GameObject screamP;
    public static bool showedGJ = false;
    public static bool canEscape = false;
    public GameObject door;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (numBats == 3){
            //safeBox.SetActive(true);
            StartCoroutine(ShowGoodJob());
        }
    }
    void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "batterys"){
            if (OpenPaint.enableBatteries == true){
                //Debug.Log("ss________sss");
                Destroy(other.gameObject);
                numBats++;
                //Debug.Log(nusmBats);
                StartCoroutine(displayBatCt());
            }
        } else if (other.gameObject.tag == "key"){
            Destroy(other.gameObject);
            canEscape = true;
            Debug.Log(canEscape);
            Destroy(door.gameObject);
            Timer.timerIsRunning = true;
            timerTxt.SetActive(true);
        } 
    }

    void OnCollisionEnter(Collision other){
        if (other.gameObject.tag == "ramp"){
            other.gameObject.GetComponent<RampRotate>().canTilt = true;
        } else if (other.gameObject.tag == "Finish"){
            isOnEnd = true;
        }
    }

    public IEnumerator displayBatCt(){
        batCt.SetActive(true);
        batCt.GetComponent<Text>().text = "Battery " + numBats.ToString() + " of 3 collected";
        yield return new WaitForSeconds(4);
        batCt.SetActive(false);
        //batCt.GetComponent<
    }

    public IEnumerator ShowGoodJob(){
        if (goodJob != null)
            goodJob.SetActive(true);
        yield return new WaitForSeconds(7);
        //goodJob.SetActive(false);

        Destroy(goodJob.gameObject);
        showedGJ = true;
    }

    public IEnumerator showScreamClue(bool canshow){
        if (canshow){
            screamP.SetActive(true);
            yield return new WaitForSeconds(10);
            //canshow = false;
            //screamP.SetActive(false);
            canshow = false;
        }
    }
}
