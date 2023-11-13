using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameManager : MonoBehaviour
{
    public GameObject enemyOnePrefab;
    public GameObject enemyTwoPrefab; // Add a reference to the EnemyTwo prefab.
    private int score = 0;

    void Start()
    {
        // Spawn EnemyOne with a repeating pattern.
        InvokeRepeating("CreateEnemyOne", 1.0f, 3.0f);

        // Spawn EnemyTwo with a different repeating pattern.
        InvokeRepeating("CreateEnemyTwo", 2.0f, 4.0f);
    }

    void Update()
    {
        // Update your game logic here.
    }

    void CreateEnemyOne()
    {
        // Spawn EnemyOne at a random position.
        Instantiate(enemyOnePrefab, new Vector3(Random.Range(-8, 8), 7, 0), Quaternion.identity);
    }

    void CreateEnemyTwo()
    {
        // Spawn EnemyTwo at a different pattern.
        Instantiate(enemyTwoPrefab, new Vector3(Random.Range(-19, 19), 7, 0), Quaternion.identity);
    }

    public void EarnScore(int points)
    {
        score += points;
    }
}