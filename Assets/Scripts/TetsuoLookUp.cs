using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetsuoLookUp : MonoBehaviour
{
    Animator anim;
    public bool CityPanComplete;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(CityPanComplete == true)
        {
            anim.SetTrigger("TetsuoTrig");
            CityPanComplete = false;
        }
    }

    void pauseAnimationEvent()
    {
        anim.enabled = false;
    }
}
