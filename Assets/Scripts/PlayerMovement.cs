﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private int i;

    // Start is called before the first frame update
    void Start() {
        i = 0;
    }

    // Update is called once per frame
    void Update() {
        i++;
        Debug.Log("Frames: " + i);
    }
}
