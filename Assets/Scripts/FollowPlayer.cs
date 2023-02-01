using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset1 = new Vector3 (0,5,-7);
    private Vector3 offset2 = new Vector3 (0,4,0);
    private Vector3 offset;
    private bool switchCam = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (switchCam)
            {
                // Debug.Log(1);
                offset = offset1;
                switchCam = false;
            }
            else
            {
                // Debug.Log(2);
                offset = offset2;
                switchCam = true;
            }
        }
        transform.position = player.transform.position + offset;
    }
}
