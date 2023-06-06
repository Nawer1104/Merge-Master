using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class OnDrag : MonoBehaviour
{



    // Start is called before the first frame update
    public GameObject prefab;
    public TextMeshPro text;
    private bool check;
    Vector3 offset;
    private object collision;

    void OnMouseDown()
    {
        check = true;
    }
    void OnMouseDrag()
    {
        if (check)
        {

            float distance_to_screen = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
            transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen));


        }

    }
    void OnCollisionEnter(Collision other)
    {
        check = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            int sum = Int32.Parse(text.text) +1;
            text.text = sum.ToString(); 
            Destroy(collision.gameObject);
            if (prefab  != null)
            {
                prefab.SetActive(true);
                prefab.transform.position = transform.position;
            }
            
        }
        
    }
}



