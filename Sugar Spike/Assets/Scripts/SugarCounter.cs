using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class sugarCounter : MonoBehaviour
{
    public static sugarCounter instance;
    public int currentSugars = 0;

    private void Awake()
    {
        instance = this;
    }


    // Update is called once per frame
    public void increaseSugars(int v)
    {
        currentSugars += v;
    }
    public void decreaseHealth(int v)
    {
        currentSugars -= v;
    }
}
