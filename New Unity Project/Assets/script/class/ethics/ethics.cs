﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ethics : MonoBehaviour
{
    public GameObject num1;
    public GameObject num2;
    public GameObject num3;

    public GameObject ans1;
    public GameObject ans2;
    public GameObject ans3;

    public GameObject re;

    // Start is called before the first frame update
    void Start()
    {
        ans1.SetActive(false);
        ans2.SetActive(false);
        ans3.SetActive(false);
        re.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (ethics_score.ethicsNum == 1)
            {
                num1.SetActive(false);
                ans1.SetActive(true);
                re.SetActive(true);
            }
            else if (ethics_score.ethicsNum == 2)
            {
                num2.SetActive(false);
                ans2.SetActive(true);
                re.SetActive(true);
            }
            else if (ethics_score.ethicsNum == 3)
            {
                num3.SetActive(false);
                ans3.SetActive(true);
                re.SetActive(true);
            }
        }
    }
}
