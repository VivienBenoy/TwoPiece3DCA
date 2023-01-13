using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
namespace Game
{
    public class GameManager: MonoBehaviour
    {
        public int gamestate;
        public bool isPaused;
        public Button playButton;
        public Button quitButton;

        public void Start()
        {
            gamestate = 1;
            InitializeEnvironment();
            StartCoroutine(GameLoop());
        }

        private IEnumerator GameLoop()
        {
            yield return StartCoroutine(StartLevel());
            yield return StartCoroutine(PlayLevel());
            yield return StartCoroutine(EndLevel());
        }

        private IEnumerator EndLevel()
        {
            throw new NotImplementedException();
        }

        private IEnumerator StartLevel()
        {
            throw new NotImplementedException();
        }
        public void Play()
        {
            isPaused = false;
        }

        public void Pause()
        {
            isPaused = true;
        }

        private IEnumerator PlayLevel()
        {
            throw new NotImplementedException();
        }

        private void InitializeEnvironment()
        {
            throw new NotImplementedException();
        }
        private void OnDestroy()
        {
            StopAllCoroutines();
        }
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.P))
            {
                isPaused = !isPaused;
            }

            if (isPaused)
                Time.timeScale = 0;
            else
                Time.timeScale = 1;

            playButton.onClick.AddListener(OnClick1);
            quitButton.onClick.AddListener(OnClick2);
        }
        private void OnClick1()
        {
            gamestate = 2;
        }
        private void OnClick2()
        {
            gamestate = 3;
        }
    }
}