using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    // Use this for initialization
    public GameObject player;
    private Vector3 offset;

	void Start () {
        offset = (transform.position - player.transform.position);
	}
	
	// Update is called once per frame
	void LateUpdate () {
        //set transform position of player pos plus offset
        transform.position = player.transform.position + offset;
        //lateupdate is follow camera best
	}
}
