using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heals : MonoBehaviour
{
    public int value;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            medicinecounter.instance.increaseHeals(value);
        }
    }
}
