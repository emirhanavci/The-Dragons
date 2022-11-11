using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSayıcı : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            MenuManager.instance.IncreaseScore();
        }
    }
}
