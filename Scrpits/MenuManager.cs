using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public static MenuManager instance;
    [SerializeField]
    private Text scoreText, astronotText, goAstronotText;

    public bool gameOver = false;
 //   public bool gameStart = true;


    public int currentAstronot, currentScore;
    [SerializeField]
    private GameObject gameMenu, levelManager, gameOverMenu;

    private bool onetime = false;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        gameMenu.SetActive(true);
    }


    void Start()
    {
        currentScore = 5;
        scoreText.text = "" + 5;
        astronotText.text = 0 + "/20";
        Player.instance.StartMoving = true;
    }
    private void Update()
    {
        if (onetime == false)
        {
            if (currentScore < 1)
            {
                GameOver();
                onetime = true;
            }
            if (currentAstronot > 19 && SceneManager.GetActiveScene().buildIndex != 5)
            {            
                gameOver = true;
                levelManager.SetActive(true);
                SoundManager.instance.PlayClick();
                onetime = true;
            }
        }
 
    }
    public void IncreaseAstronot()
    {
        currentAstronot++;
        astronotText.text = currentAstronot + "/20";
    }

    public void IncreaseScore()
    {
        currentScore = currentScore - 1;
        scoreText.text = "" + currentScore;
    }
    public void GameOver()
    {
        SoundManager.instance.PlayDeath();
        gameOver = true;
        gameMenu.SetActive(false);
        gameOverMenu.SetActive(true);
        goAstronotText.text = "Score: " + currentAstronot;
    }

    public void AgainBtn()
    {
        SoundManager.instance.PlayClick();
        SceneManager.LoadScene(1);
    }
    public void MenuBtn()
    {
        SoundManager.instance.PlayClick();
        SceneManager.LoadScene(0);
    }
    public void LvlBtn()
    {
        SoundManager.instance.PlayClick();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
