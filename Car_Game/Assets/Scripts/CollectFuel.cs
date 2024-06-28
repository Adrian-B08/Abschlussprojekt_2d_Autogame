/*
Author: Adrian Bischoff
Date: 28.06.2024
Version: 1.0
Description: This code is used to collect fuel.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectFuel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            FuelController.instance.FillFuel();
            Destroy(gameObject);
        }
    }
}
