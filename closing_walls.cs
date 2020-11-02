using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class closing_walls : MonoBehaviour { 

    public int direction_and_speed;
    void Update(){
        transform.Translate(new Vector3(direction_and_speed,0,0) * Time.deltaTime);
    }

}