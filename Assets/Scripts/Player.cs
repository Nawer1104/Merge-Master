using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI recipesDeliveredText;

    public int power = 1;

    private void Start()
    {
        recipesDeliveredText.text = power.ToString();
    }

    public void PowerUp(int param)
    {
        power = param;

        recipesDeliveredText.text = power.ToString();
    }
}
