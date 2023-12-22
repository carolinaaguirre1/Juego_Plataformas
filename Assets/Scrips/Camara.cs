using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    public GameObject player;
    private Vector3 Posicamara;

    // Use this for initialization
    void Start()
    {

        Posicamara = transform.position - player.transform.position;

    }

    // Update is called once per frame
    void Update()
    {

        transform.position = player.transform.position + Posicamara;

    }
}