using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    [SerializeField] private GameObject cam1;
    [SerializeField] private GameObject cam2;
    private bool switchCam = true;
    // Start is called before the first frame update
    void Start()
    {
        // cam1.SetActive(true);
        // cam2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (switchCam)
            {
                Debug.Log(1);
                switchCam = false;
                cam1.SetActive(false);
                cam2.SetActive(true);
            }
            else
            {
                Debug.Log(2);
                switchCam = true;
                cam1.SetActive(true);
                cam2.SetActive(false);
            }
        }
    }
}
