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
        public Transform chest;
        public Transform player;

        public void Start()
        {
            gamestate = 0;
            chest = GameObject.FindWithTag("Chest").transform;
            player = GameObject.FindWithTag("Player").transform;
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
        public void WinOrLose()
        {

            if (chest.GetComponent<Chest>().OnMouseDown())
                gamestate = 1;
            if (player.GetComponent<Player>().health == 0)
                gamestate = 2;  
          

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

        }
      
    }
}