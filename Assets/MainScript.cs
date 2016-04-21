using UnityEngine;
using System.Collections;

public class MainScript : MonoBehaviour {
	public GameObject coin;
	bool enableCoroutine = true;

	// Use this for initialization
	void Start () {
		StartCoroutine ("spawnCoin");
	}

	IEnumerator spawnCoin(){
		while (enableCoroutine) {
			Vector3 spawnPoint = new Vector3 (randomNumber(),randomNumber(),0);
			Instantiate (coin, spawnPoint, Quaternion.identity );
			yield return new WaitForSeconds(1.5f);
		}
	}

	int randomNumber(){
		int negpos = Random.Range (0, 1) * 2 - 1;
		int rand = Random.Range (0, negpos * 9);
		return rand;
	}
}
