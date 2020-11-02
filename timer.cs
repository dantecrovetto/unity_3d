using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{

    public Text Time;
    public float timeLeft;
    private float currCountdownValue;

     void Start()
     {
          StartCoroutine(StartCountdown(timeLeft));
     }


    
    public IEnumerator StartCountdown(float countdownValue)
    {
        currCountdownValue = countdownValue;
        while (currCountdownValue > 0)
        {
            Time.text = "Tiempo restante: " + currCountdownValue.ToString ();
            yield return new WaitForSeconds(1.0f);
            currCountdownValue--;
        }
    }
}
