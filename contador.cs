using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class contador : MonoBehaviour
{

    public Text Time;
    float currCountdownValue;


     void Start()
     {
        currCountdownValue = 1;
        StartCoroutine(StartCountdown());
     }
    

    
    public IEnumerator StartCountdown()
    {
        while (currCountdownValue > 0){
            Time.text = "Tiempo: " + currCountdownValue.ToString ();
            yield return new WaitForSeconds(1.0f);
            currCountdownValue++;
        }        
    }
}
