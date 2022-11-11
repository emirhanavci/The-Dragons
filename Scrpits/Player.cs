using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player instance;

    [SerializeField]
    private float xLimit = 2f;
    [SerializeField]
    private float speed = 1f;
    private Touch touch;

    //[SerializeField]
    //private float moveSpeed;

   // private bool movingRight = true;
    [SerializeField]
    private Animator anim;
    //private int direction = 1;
    private bool startMoving = false;

    public bool StartMoving { get { return startMoving; } set { startMoving = value; } }

    private void Awake()
    {
        if (instance == null)
            instance = this;
    }

    private void Start()
    {

    }

    void Update()
    {

        if (Input.touchCount > 0 && MenuManager.instance.gameOver == false)
        {      

            touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Moved) {
                transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speed,
                    transform.position.y, transform.position.z);
                transform.position = new Vector3(Mathf.Clamp(transform.position.x, -xLimit, xLimit), transform.position.y, transform.position.z);

                anim.SetBool("Start", startMoving);
            }


            if (touch.phase == TouchPhase.Ended)
            {
                anim.SetBool("Start", false);
            }
        }
    }

}
