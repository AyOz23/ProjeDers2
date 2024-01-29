using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
   
    private Button returnButton;
    private Button settingsButton;
    private Button quitButton;
  [SerializeField]  private GameObject pauseMenuUI;
    
    public static bool GameIsPaused = false;
    private void Start()
    {
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
           
            if (GameIsPaused)
            {
                Resume();
               
            }
            else
            {
                Pause(); 
               
            }
        }
    }
    void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        
    }
    
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Debug.Log("truu");
        
    }
}
