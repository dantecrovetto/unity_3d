using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class question : MonoBehaviour
{
    public Text pregunta;
    [SerializeField] private Animator myAnimationController;

        void Start()
    {
        pregunta.text = "";
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag ("Player"))
        {
            pregunta.text = "Pregunta, si la respuesta es 'x' presione la tecla a  ";
         }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag ("Player"))
        {
            pregunta.text = "";
        }
    }

}
