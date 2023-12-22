
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torreta : MonoBehaviour
{
 
    public Colisiones colisiones;

    private Animator animator;
    [SerializeField] Transform Player;

    void Start()
    {
      
        animator = GetComponent<Animator>();

        colisiones = FindObjectOfType<Colisiones>();
        Debug.Log(colisiones.tocar);

    }
    void Update()
    {
        animator.SetBool("Detecta_player", colisiones.tocar);

        //Debug.DrawLine(transform.position, destPos, Color.blue);
        Vector3 aimVector = Player.position + new Vector3(0f, 1.9f, 0f);
        Vector3 dir = aimVector - transform.position;
        dir.Normalize();
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle - 90);
        //AUTOR: JORGE SÁNCHEZ (2º Animación – Curso 2021-22)
    }
}



