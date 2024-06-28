/*
Author: Adrian Bischoff
Date: 28.06.2024
Version: 1.0
Description: This code is used that the Player dies when the head touches the ground.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriverDeathFromHead : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            GameManager.instance.GameOver();
        }
    }
}
