using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static MainMenu instance;

    public bool gameOver = false;
    public bool gameStart = false;
    [SerializeField]
    private GameObject missionsMenu;
    public void PlayGame()
    {
        SoundManager.instance.PlayClick();
        gameStart = true;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
    public void MissionBtn()
    {
        missionsMenu.SetActive(true);
        SoundManager.instance.PlayClick();
    }
    public void MenuBtn()
    {
        SoundManager.instance.PlayClick();
        SceneManager.LoadScene(0);
    }
    
}
