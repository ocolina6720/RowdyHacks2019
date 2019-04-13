using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour{

    public Text counterText;

    public float startTime = 30;
    public float currentTime;
    // Start is called before the first frame update
    void Start(){
        currentTime = startTime;
        counterText.text = ":" + startTime.ToString("00");
    }
    // Update is called once per frame
    void Update(){
        currentTime -= 1 * Time.deltaTime;
        counterText.text = currentTime.ToString("00");

        if(currentTime <= 0)
        {
            currentTime = 0;
            counterText.color = Color.red;
        }
    }
}
