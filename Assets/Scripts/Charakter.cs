using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Charakter : MonoBehaviour
{
  /*  void Start()
    {
            
    } */

    void Update()
    {
        this.transform.position += new Vector3(1f, 0f, 0f);
    }
}
