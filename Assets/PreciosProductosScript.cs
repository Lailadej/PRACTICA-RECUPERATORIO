using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreciosProductosScript : MonoBehaviour
{
    public int PrecioPod;

    // Start is called before the first frame update
    void Start()
    {
        PrecioPod = Random.Range(0, 100);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
