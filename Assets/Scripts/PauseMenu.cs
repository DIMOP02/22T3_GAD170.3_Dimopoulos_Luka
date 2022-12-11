 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace LukaDimopoulos
{
    public class PauseMenu : MonoBehaviour
    {
        public static bool Paused = false;
        public GameObject PauseMenuCanvas;

        // Start is called before the first frame update
        void Start()
        {
            Time.timeScale = 1f;
            AudioListener.volume = 1f;
        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                if(Paused)
                {
                    Play();
                    
                }
                else
                {
                    Stop();
                    
                }
            }
            Cursor.visible = true;
        }

        void Stop()
        {
            PauseMenuCanvas.SetActive(true);
                Time.timeScale = 0f;
            Paused = true;
            AudioListener.volume = 0f;
        }

        public void Play()
        {
            PauseMenuCanvas.SetActive(false);
            Time.timeScale = 1f;
            Paused = false;
            AudioListener.volume = 1f;
        }

        public void MainMenuButton()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}

