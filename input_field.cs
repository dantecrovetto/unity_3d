using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class input_field : MonoBehaviour
{
    [SerializeField] private Animator myAnimationController;
    public Button btnClick;
    public InputField inputAnswer;

    private void Start(){

        btnClick.onClick.AddListener(GetInputOnClickHandler);
    }


    public void GetInputOnClickHandler(){
        
        if (inputAnswer.text == "a"){
            Debug.Log("Text: " + inputAnswer.text);
            myAnimationController.SetBool("Door",true);
        }
    }
}
