using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dusmanhasaralma : MonoBehaviour
{
    public static float dusmansayısı = 8;
    private void Start()
    {
        dusmansayısı = 8;
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "atestopu")
        {
            dusmansayısı--;
            gameObject.SetActive(false);
        }
    }
}
