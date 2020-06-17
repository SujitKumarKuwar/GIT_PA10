﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//This script manages the behavior of individual obstacle
public class Obstacle : MonoBehaviour
{
    [SerializeField] private float Speed = 3;

    void Update()
    {
        if (transform.position.x <= -10)
        {
            GameManager.thisManager.UpdateScore();
            Destroy(gameObject);
        }
           
        else
            transform.Translate(Vector3.right * Time.deltaTime * -Speed);

    }
}
