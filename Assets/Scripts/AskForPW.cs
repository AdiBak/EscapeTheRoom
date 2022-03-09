using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AskForPW : MonoBehaviour {
    public GameObject pwqes;
    public GameObject floaty;
    public GameObject key;
     void Start ()
     {
         var input = gameObject.GetComponent<InputField>();
         var se= new InputField.SubmitEvent();
         se.AddListener(SubmitName);
         input.onEndEdit = se;
 
         //or simply use the line below, 
         //input.onEndEdit.AddListener(SubmitName);  // This also works
     }
 
     private void SubmitName(string arg0)
     {
         Debug.Log(arg0);
         if (arg0 == "3" || arg0 == "three" || arg0 == "Three"){
             //Debug.Log("----ssss-----*****");
             Destroy(gameObject);
             Destroy(pwqes.gameObject);
             key.SetActive(true);
         }
     }
 }