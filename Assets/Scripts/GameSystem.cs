using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace AHA
{
    public class GameSystem : MonoBehaviour
    {
        public float timeLeft;
        protected int score;

        public Text timeText;
        public Text scoreText, highscoreText;

        public GameObject PauseUI,Player;
        //public static bool gameisPause = false;

        public bool gameIsPause { get; private set; }

        void Start()
        {

        }

        void Update()
        {
            PauseCheck();
            Timer();
            ScoreManager();
        }

        void Timer()
        {
            timeLeft -= Time.deltaTime;
            timeText.text = "Time: " + Mathf.Round(timeLeft).ToString();
            if (timeLeft <= 0f)
            {
                SceneManager.LoadScene("EndingScene");
            }
        }
        void ScoreManager()
        {
            float live = Player.gameObject.GetComponent<CharacterSystem>().liveLeft;

            if (Time.timeScale == 1f)
            {
                score += (int)live;
            }
            else
            {
                score += 0;
            }

            
            scoreText.text = "Score: " + score;

            int highscore = PlayerPrefs.GetInt("Highscore", 0);

            if (score > highscore)
            {
                PlayerPrefs.SetInt("Highscore", score);
            }
            highscoreText.text = "Highscore: " + PlayerPrefs.GetInt("Highscore", 0);
        }

        void PauseCheck()
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                //if (gameIsPause)
                //{
                //    Pause();
                //}
                //else
                //{
                //    Resume();
                //}

                switch (gameIsPause)
                {
                    case true:
                        Resume();
                        break;
                    case false:
                        Pause();
                        break;
                }
            }
        }

        void Resume()
        {
            PauseUI.SetActive(false);
            Time.timeScale = 1f;
            gameIsPause = false;
        }

        void Pause()
        {
            PauseUI.SetActive(true);
            Time.timeScale = 0f;
            gameIsPause = true;
        }
        
        public void Restart_Button()
        {
            SceneManager.LoadScene("GameScene");
            Time.timeScale = 1f;
        }
        public void MainMenu_Button()
        {
            SceneManager.LoadScene("MainMenu");
        }
        public void Quit_Button()
        {
            Application.Quit();
        }

    }
}