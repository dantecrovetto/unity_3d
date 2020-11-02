using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendoor : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag ("Player"))
        {
            myAnimationController.SetBool("Door",true);
         }
    }
  /*  void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag ("Player"))
        {
            myAnimationController.SetBool("Door",false);
        }
    }*/

}
