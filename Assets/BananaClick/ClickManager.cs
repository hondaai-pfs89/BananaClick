using UnityEngine;

public class ClickManager : MonoBehaviour
{
   public AudioClip yellowBanana_SE;
   public AudioClip greenBanana_SE;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider != null)
            {
                AudioSource audioSource = GetComponent<AudioSource>();
                if (hit.transform.CompareTag("greenBanana"))
                {
                    audioSource.clip = greenBanana_SE;
                }
                else
                {
                    audioSource.clip = yellowBanana_SE;
                }
                audioSource.Play();
                hit.transform.localScale *= 1.2f;
                Destroy(hit.transform.gameObject, 0.1f);
            }
        
        }  
    }
}