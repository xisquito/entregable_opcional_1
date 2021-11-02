using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class planeLimits : MonoBehaviour
{
    

    //Limites de mapa
    
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(x: 0f, y: 0.5f, z: 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left);
        }
        if (transform.position.x > 50)
        {
            transform.position = new Vector3(50, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -50)
        {
            transform.position = new Vector3(-50, transform.position.y, transform.position.z);
        }

        if (transform.position.z > 20)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 20);
        }
        if (transform.position.z < -20)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -20);
        }
    }
}
