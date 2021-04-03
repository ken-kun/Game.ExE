using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour {

	public float timer = 10.0f;
	private Text timerSeconds;
	public GameObject winScreen;
    public GameObject startScreen;

	//public bool timesUp;
	//[SerializeField] string levelToLoad;

	// Use this for initialization
	void Start () {
        Time.timeScale = 0.0f;
		timerSeconds = GetComponent<Text> ();

	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		timerSeconds.text = timer.ToString ("f2");
		if (timer <= 0.0f) {
			Time.timeScale = 0.0f;
			winScreen.SetActive (true);
		}

	}
		
	/*
	public void DoSceneChange()
	{
		SceneManager.LoadScene (levelToLoad);
	}
    */
}
