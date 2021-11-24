using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        //等速落下
        transform.Translate(0,-0.1f,0);

        //画面外で破棄
        if(transform.position.y < -5.0f){
            Destroy(gameObject);
        }

        //当たり判定
        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        float r1 = 0.5f;
        float r2 = 1.0f;

        if(d < r1+r2){
            GameObject director = GameObject.Find("GameDirector");//GameDirectorオブジェクトを探す
            director.GetComponent<GameDirector>().DecreaseHp();//GameDirectorオブジェクトの持つGameDirectorスクリプトのDecreaseHpメソッドを実行

            Destroy(gameObject);
        }
    }
}
