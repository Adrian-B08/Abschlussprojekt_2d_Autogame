/*
Author: Adrian Bischoff
Date: 28.06.2024
Version: 1.0
Description: This code is used to collect coins.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if  (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
