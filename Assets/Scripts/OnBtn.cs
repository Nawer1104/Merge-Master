using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnBtn : MonoBehaviour
{
    public bool buttonToSpawnSwordMan;

    void Start()
    {

    }

    void Update()
    {

    }

    public void OnMouseDown()
    {
        if (buttonToSpawnSwordMan == true)
        {
            if (GameManager.Instance.swordMans.Count == 0)
            {
                foreach (Transform swordManSpawnPoint in GameManager.Instance.swordMan_SpawnPos)
                {
                    GameObject swordManPrefab = Instantiate(GameManager.Instance.swordManPrefab, swordManSpawnPoint);
                    GameManager.Instance.swordMans.Add(swordManPrefab);
                }
            }
        }
        else
        {
            if (GameManager.Instance.archerMans.Count == 0)
            {
                foreach (Transform archerManSpawnPoint in GameManager.Instance.archerMan_SpawnPos)
                {
                    GameObject archerManPrefab = Instantiate(GameManager.Instance.archerManPrefab, archerManSpawnPoint);
                    GameManager.Instance.archerMans.Add(archerManPrefab);
                }
            }
        }
    }
}
