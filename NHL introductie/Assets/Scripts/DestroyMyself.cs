using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMyself : MonoBehaviour {

	// Use this for initialization
	void Update () {
        Destroy(this.gameObject, 2);
	}

}
