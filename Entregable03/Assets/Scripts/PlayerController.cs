using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Posiciona el gameObject en el (0, 0, 0) al iniciar
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {

        // Al pulsar la tecla W, escala el objeto en más 2 en X, Y, Z
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.localScale += new Vector3(2, 2, 2);
        }

        // Al pulsar la tecla R, rota el objeto en 45º en X y Z
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.rotation *= Quaternion.Euler(45, 0, 45);
        }

    }
}
