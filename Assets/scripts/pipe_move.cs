﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.Lerp(transform.position, new Vector2(transform.position.x - 0.5f, transform.position.y), 0.1f); 
    }
}
