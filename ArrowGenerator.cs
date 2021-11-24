using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 1.0f;
    float delta = 0;

    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;//フレーム毎の前フレームとの時間差を蓄積
        if(this.delta > this.span){
            this.delta = 0;
            GameObject go = Instantiate(arrowPrefab);
            int px = Random.Range(-6,7);//-6以上7未満でランダムな整数を返す
            go.transform.position = new Vector3(px,7,0);
        }
    }
}
