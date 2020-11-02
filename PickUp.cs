using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PickUp : MonoBehaviour { 

    public Text countText;
    public Text winText;
    public int keys;
    
    private Rigidbody rb;
    private int count;

    [SerializeField] private Animator myAnimationController;

    void Start()
    {
        count = 0;
        SetCountText();
        winText.text = "";
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag ("Pick Up"))
        {
            other.gameObject.SetActive (false);
            count = count + 1;
            SetCountText ();
        }
    }

    void SetCountText ()
    {
        countText.text = "Count: " + count.ToString ();
        if (count >= keys)
        {
            winText.text = "You Win!";
            myAnimationController.SetBool("Door",true);
        }    
    }
}