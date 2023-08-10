using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject swordManPrefab;

    public GameObject archerManPrefab;

    public List<GameObject> swordMans;

    public List<GameObject> archerMans;

    public Transform[] swordMan_SpawnPos;

    public Transform[] archerMan_SpawnPos;


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

    }

    private void Update()
    {

    }
}