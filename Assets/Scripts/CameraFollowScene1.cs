using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScene1 : MonoBehaviour {

    public Transform player;
    public float cameraOffsetY = 2.0f;

    public bool follow;

    void Awake()
    {
        follow = true;
        transform.position = new Vector3(player.position.x, player.position.y + cameraOffsetY, transform.position.z);
        //GetComponent<UnityEngine.Camera>().orthographicSize = ((Screen.height / 2) / cameraDistance);
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        
        follow = player.transform.position.x > -82f;
        if (follow)
        {
            transform.position = new Vector3(player.position.x, player.position.y + cameraOffsetY, transform.position.z);
        }
        
	}
}
