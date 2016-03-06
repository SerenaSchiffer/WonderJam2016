using UnityEngine;
using System.Collections;

public class HeroMovement : MonoBehaviour {

    Rigidbody2D heroRidigBody2d;
    public float speed = 4;
    private Vector3 ActualVecteur;
    private string lastTriggerName;
    private Animator heroAnimator;


	public Sprite backSprite;
	private Sprite frontSprite;
	private SpriteRenderer mySR;
	// Use this for initialization
	void Start () {
        heroAnimator = gameObject.GetComponent<Animator>();
        heroRidigBody2d = gameObject.GetComponent<Rigidbody2D>();
        ActualVecteur = gameObject.transform.localScale;
        lastTriggerName = "LookLeft";
		mySR = GetComponent<SpriteRenderer> ();
		frontSprite = mySR.sprite;
    }
	
	// Update is called once per frame
	void FixedUpdate () {

        if (Input.GetAxisRaw("Horizontal") == 0 && Input.GetAxisRaw("Vertical") == 0)
        {
            heroAnimator.SetBool("Moving", false);
            heroRidigBody2d.velocity = new Vector2(0, 0);
        }

        if (!heroAnimator.GetBool("Dead"))
        {

            #region Diagonnales
            /*if (Input.GetAxisRaw("Horizontal") == -1 && Input.GetAxisRaw("Vertical") == 1)
            {
                heroRidigBody2d.velocity = new Vector2(-1 * speed * Time.deltaTime, 0);
                translateMainCameraOnAxis(new Vector3(-0.5f * speed * Time.deltaTime, -0.25f * speed * Time.deltaTime));
            }

            else if (Input.GetAxisRaw("Horizontal") == -1 && Input.GetAxisRaw("Vertical") == -1)
            {
                heroRidigBody2d.velocity = new Vector2(0, -1 * speed * Time.deltaTime);
               // translateMainCameraOnAxis(new Vector3(0, -1 * speed * Time.deltaTime));
            }
            else if (Input.GetAxisRaw("Horizontal") == 1 && Input.GetAxisRaw("Vertical") == -1)
            {
                heroRidigBody2d.velocity = new Vector2(1 * speed * Time.deltaTime, 0);
                translateMainCameraOnAxis(new Vector3(0.5f * speed * Time.deltaTime, 0.25f * speed * Time.deltaTime));
            }

            else if (Input.GetAxisRaw("Horizontal") == 1 && Input.GetAxisRaw("Vertical") == 1)
            {
                heroRidigBody2d.velocity = new Vector2(0, 1 * speed * Time.deltaTime);
                //translateMainCameraOnAxis(new Vector3(0, 1 * speed * Time.deltaTime));
            }*/
            #endregion

        
            
            if (Input.GetAxisRaw("Horizontal") == 1)
            {
                //right

                if (lastTriggerName != "LookRight")
                {
                    heroAnimator.ResetTrigger(lastTriggerName);
                }

                heroAnimator.SetTrigger("LookRight");
                lastTriggerName = "LookRight";
                heroAnimator.SetBool("Moving", true);
                gameObject.transform.localScale = new Vector3((ActualVecteur.x) * -1, ActualVecteur.y, ActualVecteur.z);
                heroRidigBody2d.velocity = new Vector2(1 * speed * Time.deltaTime, 0.5f * speed * Time.deltaTime);
                translateMainCameraOnAxis(gameObject.transform.position.x, gameObject.transform.position.y);
				mySR.sprite = backSprite;
            }

            else if (Input.GetAxisRaw("Horizontal") == -1)
            {
                if (lastTriggerName != "LookLeft")
                {
                    heroAnimator.ResetTrigger(lastTriggerName);
                }
                //left
                heroAnimator.SetTrigger("LookLeft");
                lastTriggerName = "LookLeft";
                heroAnimator.SetBool("Moving", true);
                gameObject.transform.localScale = new Vector3(ActualVecteur.x, ActualVecteur.y, ActualVecteur.z);
                heroRidigBody2d.velocity = new Vector2(-1 * speed * Time.deltaTime, -0.5f * speed * Time.deltaTime);
                translateMainCameraOnAxis(gameObject.transform.position.x, gameObject.transform.position.y);
				mySR.sprite = frontSprite;
            }

            else if (Input.GetAxisRaw("Vertical") == 1)
            {
                if (lastTriggerName != "LookLeft")
                {
                    heroAnimator.ResetTrigger(lastTriggerName);
                }

                //left
                heroAnimator.SetTrigger("LookLeft");
                lastTriggerName = "LookLeft";
                heroAnimator.SetBool("Moving", true);
                gameObject.transform.localScale = new Vector3(ActualVecteur.x, ActualVecteur.y, ActualVecteur.z);
                heroRidigBody2d.velocity = new Vector2(-1 * speed * Time.deltaTime, 0.5f * speed * Time.deltaTime);
                translateMainCameraOnAxis(gameObject.transform.position.x, gameObject.transform.position.y);
				mySR.sprite = backSprite;

            }

            else if (Input.GetAxisRaw("Vertical") == -1)
            {
                if (lastTriggerName != "LookRight")
                {
                    heroAnimator.ResetTrigger(lastTriggerName);
                }
                //right
                heroAnimator.SetTrigger("LookRight");
                lastTriggerName = "LookRight";
                heroAnimator.SetBool("Moving", true);
                gameObject.transform.localScale = new Vector3((ActualVecteur.x) * -1, ActualVecteur.y, ActualVecteur.z);
                heroRidigBody2d.velocity = new Vector2(1 * speed * Time.deltaTime, -0.5f * speed * Time.deltaTime);
                translateMainCameraOnAxis(gameObject.transform.position.x, gameObject.transform.position.y);
				mySR.sprite = frontSprite;
            }

        }
        else
        {
            heroRidigBody2d.velocity = new Vector2(0,0);
        }
    }
    void translateMainCameraOnAxis(float x,float y)
    {
        Camera.main.transform.position = new Vector3(x, y,-10);
    }

    //void translateMainCameraOnAxis(Vector3 positionVecteur)
    //{
    //    Camera.main.transform.position += positionVecteur*Time.deltaTime;
    //}
}
