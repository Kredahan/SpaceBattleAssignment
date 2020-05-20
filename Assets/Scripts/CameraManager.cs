using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraManager : MonoBehaviour
{
    public GameObject Tetsuo;
    public GameObject Laser;
    public GameObject Blood;
    public Camera CityCam;
    public Camera TetsuoCam;
    public bool cityPanFinished;
    public bool laserNotFired;

    // Start is called before the first frame update
    void Start()
    {
        laserNotFired = true;
        cityPanFinished = false;
        CityCam.enabled = true;
        TetsuoCam.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(cityPanFinished == true)
        {
            CityCam.enabled = false;
            TetsuoCam.enabled = true;
            Tetsuo.SetActive(true);
            if(laserNotFired == true)
            {
                Invoke("fireLaser", 3);
                laserNotFired = false;
            }
        }

        if(cityPanFinished == true && laserNotFired == false)
        {
            Invoke("ChangeScene", 7);
        }
        
    }

    void fireLaser()
    {
        Laser.SetActive(true);
        Blood.SetActive(true);
    }

    void ChangeScene()
    {
        SceneManager.LoadScene("SpaceScene");
    }
}


