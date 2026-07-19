using UnityEngine;

public class Start_BanandaController : MonoBehaviour
{
    void BanandaPositionRandomize()
    {
        float y =Random.Range(-5.0f, 4.0f);
        this.transform.position = new Vector3(-10.5f, y, 0);  
    }   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.targetFrameRate = 60;
        BanandaPositionRandomize();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * 5.0f * Time.deltaTime, Space.World);
        if (transform.position.x > 10.5f)
        {
            BanandaPositionRandomize();
        }
    }
}
