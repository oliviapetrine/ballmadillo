using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCams : MonoBehaviour
{
    public GameObject PlayerCam1;
    public GameObject PlayerCam2;
    public GameObject WorldCam;
    // Start is called before the first frame update
    void Start()
    {
        PlayerCam1.SetActive(false);
        PlayerCam2.SetActive(false);
        WorldCam.SetActive(true);
    }
}
