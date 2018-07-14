using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform player;
    public float cameraDistance = 30.0f;
    public bool follow;
    public Vector3 playerVal;
    void Awake()
    {
        playerVal = player.transform.position;
        follow = true;
        //GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height / 2) / cameraDistance);
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        follow = player.transform.position.x > playerVal.x;
        if (follow)
        {
            transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
        }
        
	}
}
