using System;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                Destroy(hit.transform.gameObject);
                
                Debug.Log("You Win");
            }
        }
    }
}
