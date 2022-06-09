using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Tiempo : MonoBehaviour
{

    public Text txtCountdown;
    float tiempo;

    // Start is called before the first frame update
    void Start()
    {
        txtCountdown.text = "0";
        
    }

    // Update is called once per frame
    void Update()
    {
        tiempo = Mathf.FloorToInt(Time.timeSinceLevelLoad);
        txtCountdown.text = "Tiempo: " + tiempo.ToString();

        if (tiempo == 40)
        {
            SceneManager.LoadScene("Ganaste");
        }
    }
}
