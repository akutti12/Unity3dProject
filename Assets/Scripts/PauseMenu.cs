using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PauseMenu : MonoBehaviour
{
   public static bool GameisPaused = false;
	public GameObject pauseMenuUI;
	
	void Start () 
	{
		pauseMenuUI.SetActive (false);
	}

	// Update is called once per frame
	void Update () 
	{
      
        
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			if (GameisPaused) 
			{
				Resume();
			} 
			
			else 
			{
				Pause();
			}
		}
	}
	
	public void Resume ()
	{
        Cursor.lockState = CursorLockMode.Locked;

		pauseMenuUI.SetActive (false);
		Time.timeScale = 1f;
		GameisPaused = false;
	}
	
	void Pause ()
	{
		pauseMenuUI.SetActive (true);
		Time.timeScale = 0f;
		GameisPaused = true;
		Cursor.lockState = CursorLockMode.None;

      
	}
	
	public void LoadMenu()
	{
		GameisPaused = false;
        Time.timeScale = 1f;
		SceneManager.LoadScene(0);
	}
	
	public void QuitGame()
	{
        Debug.Log("Quitting game...");
		Application.Quit();
	}
}