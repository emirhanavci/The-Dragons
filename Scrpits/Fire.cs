using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    [SerializeField]
    private Animator anim;

    [SerializeField]
    private new GameObject gameObject;

    private Touch touch;

    private bool startMoving = false;

    void Start()
    {
        //    SpriteRenderer render = gameObject.GetComponentInChildren<SpriteRenderer>();

        //    render.enabled = false;

        GetComponent<EdgeCollider2D>().enabled = false;


        gameObject.SetActive(false);
    }

    void Update()
    {

        if (Input.touchCount > 0 && MenuManager.instance.gameOver == false)
        {

            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                GetComponent<EdgeCollider2D>().enabled = true;

                gameObject.SetActive(true);
                startMoving = true;
                anim.SetBool("Fire", startMoving);
            }


            if (touch.phase == TouchPhase.Ended)
            {
                GetComponent<EdgeCollider2D>().enabled = false;
                gameObject.SetActive(false);
            }
        }
    }
}
