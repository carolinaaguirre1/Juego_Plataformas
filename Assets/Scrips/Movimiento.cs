using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movimiento : MonoBehaviour
{

    InputControler inputController;

    private Rigidbody2D rb2d;


    [Header("Movimiento")]
    private float movimientohorizontal = 0f;
    [SerializeField] private float velocidadM=400f;
    [Range(0, 0.3f)][SerializeField] private float suavizadoM;
    private Vector3 velocidad = Vector3.zero;
    private bool mirandoDerecha = true;
    private float enMov ;
    private bool sicorrer;
    private float valoraxis;

    [Header("Salto")]
    [SerializeField] private float fuerzaDesalto;
    [SerializeField] LayerMask queEsSuelo;
    [SerializeField] private Transform ColisionardorSuelo;
    [SerializeField] private Vector3 dimensionesCaja;
    [SerializeField] private bool enSuelo;
    [SerializeField] private bool enSalto;
    private bool salto = false;

    [Header("agachado")]
    [SerializeField] bool estoyAgachado;
   


    [Header("animacion")]
    private Animator animator;



    private void Awake()
    {
        inputController = new InputControler();
        inputController.Movimiento.Salto.started += ctx => {
            salto = true;
            Debug.Log("Has saltado"); ;
        };

        inputController.Movimiento.mover.performed += ctx => enMov = ctx.ReadValue<float>();
        inputController.Movimiento.mover.canceled += ctx => enMov = 0f;


        inputController.Movimiento.correr.performed += ctx => {
            sicorrer = true;
            Debug.Log("estascorriendo"); ;
        };
        inputController.Movimiento.correr.canceled += ctx => {
            sicorrer = false;
            Debug.Log("dejastesdecorrer"); ;
        };

        inputController.Movimiento.agachar.performed += ctx => {
            estoyAgachado = true;
            Debug.Log("estasagachado"); ;
        };
        inputController.Movimiento.agachar.canceled += ctx => {
            estoyAgachado = false;
            Debug.Log("dejastesagachado"); ;
        };

    }
    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();


    }

    private void Update()
    {
        valoraxis = enMov;
        if (valoraxis < 0)
        {
            valoraxis= valoraxis * -1;
        }


        //movimientohorizontal = Input.GetAxisRaw("Horizontal") * velocidadM;
        animator.SetFloat("mov", valoraxis);
        animator.SetBool("salto", enSalto);
        animator.SetBool("correr", sicorrer);
        animator.SetBool("agachado", estoyAgachado);
        movimientohorizontal = enMov * velocidadM;
        enSalto = !enSuelo;
        correr();


    }
    private void FixedUpdate()
    {
        enSuelo = Physics2D.OverlapBox(ColisionardorSuelo.position, dimensionesCaja, 0f, queEsSuelo);

        Mover(movimientohorizontal * Time.fixedDeltaTime, salto);
        salto = false;
    }
    private void Mover(float mover, bool saltar)
    {
        Vector3 velocidadObjetivo = new Vector2(mover, rb2d.velocity.y);
        rb2d.velocity = Vector3.SmoothDamp(rb2d.velocity, velocidadObjetivo, ref velocidad, suavizadoM);
        if (mover > 0 && !mirandoDerecha)
        {
            Girar();
        }
        else if (mover < 0 && mirandoDerecha)
        {
            Girar();
        }

        //ref salto
        if (enSuelo && saltar)
        {
            enSuelo = false;
            rb2d.AddForce(new Vector2(0f, fuerzaDesalto));
        }




    }
    private void correr()
    {
         if(sicorrer==false){
            velocidadM = 400f;
        }
    else
{
            velocidadM = 600f;
        }
    }
       
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Has tocado");
        if (collision.gameObject.tag == "plataformamovil")
        {
            transform.parent = collision.gameObject.transform;

        }
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "plataformamovil")
        {
            transform.parent = null;
        }
    }

    private void Girar()
    {
        mirandoDerecha = !mirandoDerecha;
        Vector3 escala = transform.localScale;
        escala.x *= -1;
        transform.localScale = escala;
    }

    private void OnDrawGizmos()
    {

        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(ColisionardorSuelo.position, dimensionesCaja);

    }

    private void OnEnable()
    {
        inputController.Enable();
    }

    private void OnDisable()
    {
        inputController.Disable();
    }
}
