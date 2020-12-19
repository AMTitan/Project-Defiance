﻿using System.Collections;
using System.Collections.Generic;
using other;
using UnityEngine;

public class ifSniper : MonoBehaviour
{

    public player player;
    private float newSize;
    public float sizeChangeAmount = 2f;

    // Start is called before the first frame update
    private void Start()
    {
        newSize = gameObject.GetComponent<Camera>().orthographicSize * sizeChangeAmount;
    }

    // Update is called once per frame
    private void Update()
    {
        if(player.selected == 4)
        {
            gameObject.GetComponent<Camera>().orthographicSize = newSize;
        }
    }
}
