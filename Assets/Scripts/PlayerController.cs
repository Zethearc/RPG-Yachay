using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed = 4.0f; // Velocidad de movimiento

    private const string horizontal = "Horizontal"; // Conexión a la tecla asignada
    private const string vertical = "Vertical";  // Conexión a la tecla asignada

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // s = v*t distancia es igual a velocidad por tiempo

        if(Mathf.Abs(Input.GetAxisRaw(horizontal)) > 0.5f)
        {
            this.transform.Translate(new Vector3(Input.GetAxisRaw(horizontal)*speed*Time.deltaTime, 0, 0));
        }
        if(Mathf.Abs(Input.GetAxisRaw(vertical)) > 0.5f)
        {
            this.transform.Translate(new Vector3(0, Input.GetAxisRaw(vertical)*speed*Time.deltaTime, 0));
        }
    }
}
