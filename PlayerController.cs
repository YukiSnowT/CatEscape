using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void LButtonDown(){
        if(transform.position.x > -6){
            transform.Translate(-3,0,0);
        }
    }

    public void RButtonDown(){
        if(transform.position.x < 6){
            transform.Translate(3,0,0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //左矢印
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            LButtonDown();
        }
        //右矢印
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            RButtonDown();
        }
        
    }
}
