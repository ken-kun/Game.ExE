using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyCounter : MonoBehaviour {

	[SerializeField] Text enemyCount;

	[SerializeField] string levelToLoad;

	// Use this for initialization
	void Start () {
		enemyCount.text = "Turret: " + 10;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void EnemyNumber(int number) {
		enemyCount.text = "Turret: " + number;
		if (number <= 0) {
			DoSceneChange ();
		}

	}

	public void DoSceneChange()
	{
		SceneManager.LoadScene (levelToLoad);
	}
}
