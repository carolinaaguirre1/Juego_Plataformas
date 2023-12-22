using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cabeza_colider : MonoBehaviour
{
    public bool contadordecolision =false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OntriggerEnter(Collider other)
    {
        contadordecolision = true;
    }
    void OntriggerExit(Collider other)
    {
        contadordecolision = false;
    }

}
