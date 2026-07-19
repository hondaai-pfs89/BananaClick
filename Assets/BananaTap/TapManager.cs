using UnityEngine;
using UnityEngine.InputSystem;

public class TapManager : MonoBehaviour
{
   public AudioClip yellowBanana_SE;
   public AudioClip greenBanana_SE;
   GameObject GameDirector;

   void Start()
    {
        GameDirector = GameObject.Find("GameDirector");
    }

    void Update()
    {
        if (Touchscreen.current.primaryTouch.press.wasPressedThisFrame)
        {
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(Touchscreen.current.primaryTouch.position.ReadValue());

            RaycastHit2D hit = Physics2D.Raycast(touchPos, Vector2.zero);
            if (hit.collider != null)
            {
                AudioSource audioSource = GetComponent<AudioSource>();
                if (hit.transform.CompareTag("greenBanana"))
                {
                    audioSource.clip = greenBanana_SE;
                    this.GameDirector.GetComponent<GameDirector>().ClickGreenBanana();
                }
                else if (hit.transform.CompareTag("yellowBanana"))
                {
                    audioSource.clip = yellowBanana_SE;
                    this.GameDirector.GetComponent<GameDirector>().ClickYellowBanana();
                }
                else
                {
                    audioSource.clip = yellowBanana_SE;
                    this.GameDirector.GetComponent<GameDirector>().ClickGoldenBanana();
                }
                audioSource.Play();
                hit.transform.localScale *= 1.2f;
                Destroy(hit.transform.gameObject, 0.1f);
            }
        
        }  
    }
}