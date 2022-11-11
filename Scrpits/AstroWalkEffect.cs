using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstroWalkEffect : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("gui"))
        {
            GameObject smokeEffect = ObjectPooling.instance.GetPooledObject("AstroRun");
            smokeEffect.transform.position = transform.position;
            smokeEffect.SetActive(true);
            smokeEffect.GetComponent<Animator>().Play("AstroRun", -1, 0);
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}