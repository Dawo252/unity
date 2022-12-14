using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;


public class CameraBounds : MonoBehaviour
{
    // public Camera camera;
    // public GameObject enemy;
    public List<GameObject> enemies;
    private float y_spawn_cord = 0.2f;
    private float x_spawn_cord = 1.1f;
    private int counter = 0;
    private int SpawnEnemyCounter = 0;

    void SpawnEnemy()
    {
        System.Random random = new System.Random(); 
        if (Input.GetAxis("Horizontal") < 0)
        {
            Vector3 v3Pos = Camera.main.ViewportToWorldPoint(new Vector3(-x_spawn_cord + 1.0f, y_spawn_cord, 10.0f));
            GameObject enem = Instantiate(enemies[random.Next(enemies.Count)], v3Pos, quaternion.identity);
            enem.GetComponent<Rigidbody2D>().AddForce(new Vector3(60.0f,0.0f,0.0f));
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {
            Vector3 v3Pos = Camera.main.ViewportToWorldPoint(new Vector3(x_spawn_cord, y_spawn_cord, 10.0f));
            GameObject enem = Instantiate(enemies[random.Next(enemies.Count)], v3Pos, Quaternion.Euler(0, 180, 0));
            enem.GetComponent<Rigidbody2D>().AddForce(new Vector3(-60.0f,0.0f,0.0f));
        }
        else
        {
            if (SpawnEnemyCounter % 2 == 0)
            {
                Vector3 v3Pos = Camera.main.ViewportToWorldPoint(new Vector3(-x_spawn_cord + 1.0f, y_spawn_cord, 10.0f));
                GameObject enem = Instantiate(enemies[random.Next(enemies.Count)], v3Pos, quaternion.identity);
                enem.GetComponent<Rigidbody2D>().AddForce(new Vector3(60.0f,0.0f,0.0f));
                SpawnEnemyCounter++;
            }
            else
            {
                Vector3 v3Pos = Camera.main.ViewportToWorldPoint(new Vector3(x_spawn_cord, y_spawn_cord, 10.0f));
                GameObject enem = Instantiate(enemies[random.Next(enemies.Count)], v3Pos, Quaternion.Euler(0, 180, 0));
                enem.GetComponent<Rigidbody2D>().AddForce(new Vector3(-60.0f,0.0f,0.0f));
                SpawnEnemyCounter++;

            }
        }
        counter++;
        if (counter <= 6)
        {
            y_spawn_cord += 0.1f;
        }
        else if (counter > 6)
        {
            y_spawn_cord -= 0.1f;
            if (counter == 12)
            {
                counter = 0;
            }
        }
    }
    
    private void Start()
    {
        InvokeRepeating("SpawnEnemy", 1, 1.5f);
    }
    
    }