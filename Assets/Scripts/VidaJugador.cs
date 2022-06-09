using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VidaJugador : MonoBehaviour
{
    public int vidasrestantes = 3;
    public Text VidasRestantesTxt;
    public Text txtCountdown;

    // Start is called before the first frame update
    void Start()
    {
        txtCountdown.text = "0";
        VidasRestantesTxt.text += vidasrestantes.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        VidasRestantesTxt.text = "Vidas restantes: " + vidasrestantes;
        txtCountdown.text = "Tiempo: " + Mathf.FloorToInt(Time.timeSinceLevelLoad).ToString();

        if (txtCountdown.text == "10")
        {
            SceneManager.LoadScene("Ganaste");
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemigo")
        {
            if (vidasrestantes >= 0)
            {
                vidasrestantes--;
                transform.position = new Vector3(0, 0.5f, 0);
            }
            if (vidasrestantes == 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene("GameOver");
            }

        }
    }
    void OnCollisionExit(Collision col2)
    {
        if (col2.gameObject.name == "Plane")
        {
            if (vidasrestantes >= 0)
            {
                transform.position = new Vector3(0, 0.5f, 0);
                vidasrestantes--;
            }
            if (vidasrestantes == 0)
            {
                Destroy(gameObject);
                SceneManager.LoadScene("GameOver");
            }
        }
    }
}
