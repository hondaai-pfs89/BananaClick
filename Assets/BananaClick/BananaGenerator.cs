using UnityEngine;

public class BananaGenerator : MonoBehaviour
{
    //生成したいアイテムを宣言
    public GameObject BananaPrefab;

    float span = 0.5f;
    float delta = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            //バナナの実体を代入
            GameObject banana = Instantiate(BananaPrefab);
            float positionx = Random.Range(-9, 9);
            float positiony = Random.Range(-6, 6);
            //バナナをランダムな座標に生成
            banana.transform.position = new Vector3(positionx, positiony, 0);
        }
    }
}
