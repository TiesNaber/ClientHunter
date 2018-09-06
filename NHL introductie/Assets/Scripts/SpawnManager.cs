using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

    [SerializeField]
    private GameObject costumer;

    private bool GameEnd = false;

	// Use this for initialization
	void Start () {
        StartCoroutine(EnemySpawner());
	}

    IEnumerator EnemySpawner()
    {
        while(GameEnd == false)
        {

            Instantiate(costumer, new Vector3(Random.Range(-12, 7), 1f, Random.Range(10, -3.5f)), Quaternion.identity);
            yield return new WaitForSeconds(5f);
        }
    }
}
