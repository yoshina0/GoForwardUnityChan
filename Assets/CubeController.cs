using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    //キューブの移動速度
    private float speed = -0.2f;

    //消滅位置
    private float deadline = -10;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //キューブを移動させる
        transform.Translate(this.speed, 0, 0);

        //画面外に出たら破棄する
        if (transform.position.x < this.deadline)
        {
            Destroy(gameObject);
        }
    }

    //衝突時に効果音を鳴らす（課題）
    void OnCollisionEnter2D(Collision2D collision)
    {
        //キューブまたは地面に衝突した場合に音を鳴らす
        if (collision.gameObject.tag == "CubeTag" || collision.gameObject.tag == "GroundTag")
        {
            GetComponent<AudioSource>().Play();
        }

        //Unityちゃんと衝突した場合には音を鳴らさない
        if (collision.gameObject.tag == "UnityChanTag")
        {
            GetComponent<AudioSource>().Stop();
        }
    }
}
