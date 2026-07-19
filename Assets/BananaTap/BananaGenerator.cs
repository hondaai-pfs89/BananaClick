using UnityEngine;

public class BananaGenerator : MonoBehaviour
{
    float span = 0.5f;
    float delta = 0;

    //生成したいアイテムを宣言
    public GameObject yellowBananaPrefab;
    public GameObject greenBananaPrefab;
    public GameObject goldenBananaPrefab;

    public void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = null;
            int num = Random.Range(0, 10);
            if (num <= 5)
            {
                go = Instantiate(yellowBananaPrefab) as GameObject;
            }
            else if (num >= 6 && num <= 8)
            {
                go = Instantiate(greenBananaPrefab) as GameObject;
            }
            else
            {
                go = Instantiate(goldenBananaPrefab) as GameObject;
            }

            float x = Random.Range(-9.0f, 9.0f);
            float y = Random.Range(-6.0f, 6.0f);
            go.transform.position = new Vector3(x, y, 0);
        }
    }






}
