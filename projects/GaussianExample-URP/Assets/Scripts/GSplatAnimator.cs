using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GSplatAnimator : MonoBehaviour
{
    public GameObject splatCutout;

    // Start is called before the first frame update
    void Start()
    {
        splatCutout.transform.localScale = new Vector3(0.001f, 0.001f, 0.001f);
    }

    // Update is called once per frame
    void Update()
    {
        // If space bar is pressed, change the size of the rectangle
        if (Input.GetKeyDown(KeyCode.Space))
        {
            splatCutout.transform.DOScale(new Vector3(1.0f, 1.0f, 1.0f), 2.0f);


        }
    }
}
