﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotMoves : MonoBehaviour
{
    public GameObject potCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            potCanvas.SetActive(false);
        }
    }

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            potCanvas.SetActive(true);
        }
    }
}
