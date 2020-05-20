using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CitySceneController : MonoBehaviour
{
    GameObject sceneManager;
    Animator anim;
    public bool switchScene;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        sceneManager = GameObject.FindWithTag("SceneManager");
    }

    // Update is called once per frame
    void Update()
    {
        if(switchScene == true)
        {
            sceneManager.GetComponent<CameraManager>().cityPanFinished = true;
        }
    }
    void triggerNextAnimationEvent()
    {
        //Need to switch camera
        //Need to trigger Tetsuo Animation
        switchScene = true;
    }
}
