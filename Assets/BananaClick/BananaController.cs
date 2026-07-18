using UnityEngine;

public class BananaController : MonoBehaviour
{
    float x;
    float y;
    float z;
    float delta = 0;

    void BananaMove()
    {
        //ワールド座標を指定し、秒速の60分の1で動かす
        transform.Translate(x * Time.deltaTime, y * Time.deltaTime, 0,Space.World);
        transform.Rotate(0, 0, z * Time.deltaTime);
    }
    //回転をランダムにするメソッド
    void RotateRandomize()
    {
        z = Random.Range(-900f, 900f);
    }
    
    void Start()
    {
        //フレームレートを60に固定
        Application.targetFrameRate = 60;
        //移動速度決定、回転速度決定
        x = Random.Range(-10f,10f);
        y = Random.Range(-10f,10f);
        RotateRandomize();
    }

    void Update()
    {
        BananaMove();
        
        //右にはみ出したら左向きに
        if(transform.position.x > 9)
        {
            x = -Random.Range(0.01f, 10f);
            y = Random.Range(-10f, 10f);
            RotateRandomize();
        }
        //左にはみ出したら右向きに
        if(transform.position.x < -9)
        {
            x = Random.Range(0.01f, 10f);
            y = Random.Range(-10f, 10f);
            RotateRandomize();
        }
        //上にはみ出したら下向きに
        if(transform.position.y > 6)
        {
            x = Random.Range(-10f, 10f);
            y = -Random.Range(0.01f, 10f);
            RotateRandomize();
        }
        //下にはみ出したら上向きに
        if(transform.position.y < -6)
        {
            x = Random.Range(-10f, 10f);
            y = Random.Range(0.01f, 10f);
            RotateRandomize();
        }
        //5秒経過したら消去
        this.delta += Time.deltaTime;
        if(this.delta > 5)
        {
            Destroy(gameObject);
        }
    }
   

}

