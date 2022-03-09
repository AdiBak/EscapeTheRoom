using UnityEngine;
using System.Collections;
using UnityEditor;
using UnityEngine.UI;
public class OpenPaint : MonoBehaviour
{

    public bool isOpen = false;
    public bool drawOpen = false;
    public bool isLift = false;
    public bool canUncScream = false;
    public GameObject battery1;
    public GameObject battery2;
    public GameObject battery3;
    public GameObject safe;
    public GameObject scream;
    public static bool enableBatteries = false;
    public GameObject clue1;
    public GameObject inputField;
    public GameObject pwQs; 
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //FOR MOUSE CLICKS
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("Name = " + hit.collider.name);
                Debug.Log("Tag = " + hit.collider.tag);
                Debug.Log("Hit Point = " + hit.point);
                Debug.Log("Object position = " + hit.collider.gameObject.transform.position);
                Debug.Log("--------------");
                
                if (hit.collider.tag == "book1")
                {
                    StartCoroutine(showClue1());
                    Debug.Log("ssssscxxsx");
                    enableBatteries = true;
                    addStuff();
                } else if (hit.collider.tag == "painting"){
                     isOpen = !isOpen;
                     hit.collider.gameObject.GetComponent<PaintingOpen>().Uncover(isOpen);
                 } else if (hit.collider.tag == "pillow"){
                     isLift = !isLift;
                     hit.collider.gameObject.GetComponent<LiftPillow>().Lift(isLift);
                 } else if (hit.collider.tag == "tvdrawer"){
                     drawOpen = !drawOpen;
                     hit.collider.gameObject.GetComponent<OpenDrawer>().OpenDraw(drawOpen);
                 } else if (hit.collider.tag == "book"){
                     if (PlayerCollisions.showedGJ){
                         canUncScream = true;
                        StartCoroutine(showPaintClue());
                        safe.SetActive(true);
                     }
                 } else if (hit.collider.tag == "safe"){
                     inputField.SetActive(true);
                     pwQs.SetActive(true);
                 }
            }
        }
      

    }

    public IEnumerator showClue1()
    {
        clue1.gameObject.SetActive(true);
        yield return new WaitForSeconds(10);
        clue1.gameObject.SetActive(false);
        enableBatteries = true;
    }

    public IEnumerator showPaintClue(){
        scream.SetActive(true);
        yield return new WaitForSeconds(10);
        scream.SetActive(false);
    }

    void addStuff()
    {
        if (enableBatteries)
        {
          
            if (battery1 != null && battery2 != null && battery3 != null)
                battery1.SetActive(true);
                battery2.SetActive(true);
                battery3.SetActive(true);

        }

    }


}