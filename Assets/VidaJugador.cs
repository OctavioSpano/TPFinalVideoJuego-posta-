using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaJugador : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Toco");
        if (col.gameObject.name == "Policia(Clone)")
        {
            Destroy(gameObject);
        }
    }
}
