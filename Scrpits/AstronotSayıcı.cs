using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstronotSayıcı : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Astronot"))
        {
            SoundManager.instance.PlayAstronot();
            MenuManager.instance.IncreaseAstronot();
        }
    }
}
