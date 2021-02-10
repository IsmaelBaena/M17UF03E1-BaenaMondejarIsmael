using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionMapa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        bool flag = false;
        Vector3 vector = new Vector3(transform.rotation.x, transform.rotation.y, transform.rotation.z);
        if (Input.GetButton("RotarDerecha"))
        {
            Debug.Log("Rota");
            vector.x += 1f;
            flag = true;
        }
        if (Input.GetButton("RotarIzquierda"))
        {
            vector.x -= 1f;
            flag = true;
        }
        if (Input.GetButton("RotarAdelante"))
        {
            vector.z += 1f;
            flag = true;
        }
        if (Input.GetButton("RotarAtras"))
        {
            vector.z -= 1f;
            flag = true;
        }
            if (flag)
        {
            this.gameObject.transform.Rotate(vector);
            flag = false;
        }
        
    }
}
