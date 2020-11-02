using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour {

    public string Escena; 
    bool IsHit;
 
    private void Start()
    {
         IsHit = false;
    }

    void OnControllerColliderHit(ControllerColliderHit hit){
        print("hola1");
        if (hit.gameObject.tag == "hurdle" && IsHit == false)            {
                SceneManager.LoadScene("samplescene");//ints and such also work.
                //print("hola2");
                IsHit = true;
            }
    }
    void OnTriggerEnter(Collider collider){
        if (collider.gameObject.tag == "hurdle" && IsHit == false)            {
                SceneManager.LoadScene(Escena);//ints and such also work.
                //print("hola2");
                IsHit = true;
            }
    }
}
