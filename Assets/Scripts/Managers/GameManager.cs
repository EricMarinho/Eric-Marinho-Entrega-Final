using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Managers
{
    public class GameManager : MonoBehaviour
    {
        public Action OnGamePaused;
        public Action OnGameUnpaused;

        public static GameManager instance;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(gameObject);
            }

            DontDestroyOnLoad(gameObject);
        }

        //M�todos para pausar o jogo
        public void PauseGame()
        {
            Time.timeScale = 0;
            OnGamePaused?.Invoke();
        }

        // M�todo para despausar o jogo
        public void ResumeGame()
        {
            Time.timeScale = 1;
            OnGameUnpaused?.Invoke();
        }

        // M�todo para alternar entre pausar e despausar o jogo
        public void TogglePauseGame()
        {
            if (Time.timeScale == 0)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }

        // M�todo para sair do jogo
        public void ExitGame()
        {
            Application.Quit();
        }

        internal void GoToMenu()
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene(Constants.StageNamesConstants.MENU);
        }

        internal void GoToInGame()
        {
            SceneManager.LoadScene(Constants.StageNamesConstants.INGAME);
        }
    }
}