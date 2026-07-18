using UnityEngine;

public class ClickManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider != null)
            {
                GetComponent<AudioSource>().Play();
                //ヒットしたコライダーがついたオブジェクトを削除する
                Destroy(hit.collider.gameObject);
            }
        }
    }
}