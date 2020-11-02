using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class linterna : MonoBehaviour
{

    public float timeLeft;
    private float currCountdownValue;
    public Light luz;

     void Start()
     {
          StartCoroutine(StartCountdown(timeLeft));
     }


    
    public IEnumerator StartCountdown(float countdownValue)
    {
        currCountdownValue = countdownValue;
        while (currCountdownValue > 0)
        {
            yield return new WaitForSeconds(1.0f);
            currCountdownValue--;
        }
        luz.intensity = Mathf.PingPong(Time.time, 1);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag ("Pick Up"))
        {
            other.gameObject.SetActive (false);
            luz.intensity = Mathf.PingPong(Time.time, 8);
            StartCoroutine(StartCountdown(timeLeft));
        }
    }
}