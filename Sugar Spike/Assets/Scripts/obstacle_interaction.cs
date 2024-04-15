using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle_interaction : MonoBehaviour
{
    public int value;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            sugarCounter.instance.decreaseHealth(value);
            Debug.Log("hit");
        }
    }
}
