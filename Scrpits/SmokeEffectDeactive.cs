using UnityEngine;

public class SmokeEffectDeactive : MonoBehaviour
{
    [SerializeField]
    private float time = 1.1f;

    private float currentTime;
    void Start()
    {
        currentTime = time;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;
        if(currentTime < 0)
        {
            currentTime = time;
            gameObject.SetActive(false);
        }
    }
}
