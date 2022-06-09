﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorPolicia : MonoBehaviour
{
    public GameObject policia;
    public float xPos, zPos, enemyCount;
    public int elegirNumero;
    AudioSource audio;
    public AudioClip [] yutaSound;

    void Start()
    {
        StartCoroutine(EnemyDrop());
    }

    IEnumerator EnemyDrop()
    {
        while (enemyCount < 10)
        {
            xPos = Random.Range(-13, 14);
            zPos = Random.Range(-13, 13);
            elegirNumero = Random.Range(0, 3);
            policia = Instantiate(policia, new Vector3(xPos, 0.5f, zPos), Quaternion.identity);
            audio.clip = yutaSound [elegirNumero];
            audio.Play();
            yield return new WaitForSeconds(5);
            enemyCount += 1;
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Plane")
        {
            transform.position = new Vector3(0, 0.5f, 0);
        }
    }
}