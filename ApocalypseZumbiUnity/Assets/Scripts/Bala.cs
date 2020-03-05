using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float velocidade;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + transform.forward * velocidade * Time.deltaTime);
    }

    public void OnTriggerEnter(Collider objetoColidido)
    {
        if (objetoColidido.gameObject.tag == "Inimigo")
        {
            Destroy(objetoColidido.gameObject);
        }

        Destroy(gameObject);
    }
}
