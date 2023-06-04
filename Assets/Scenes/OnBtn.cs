using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnBtn : MonoBehaviour
{
    //public Button btnItem;
    public GameObject prefab;

    void Start()
    {
        //btnItem.onClick.AddListener(() => onClickItem());
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnMouseDown()
    {

        prefab.SetActive(true);
    }
}
