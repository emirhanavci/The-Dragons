using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private new GameObject gameObject;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.SetActive(false);


        //  SpriteRenderer render = gameObject.GetComponentInChildren<SpriteRenderer>();

        //  render.enabled = false;

        //   Destroy(gameObject);
    }

}
