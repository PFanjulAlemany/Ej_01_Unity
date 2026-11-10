using UnityEngine;
using UnityEngine.InputSystem;


public class AttackController : MonoBehaviour
{

    [SerializeField] InputActionReference attackAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //sumamos al array de acciones una nueva funcion
        attackAction.action.performed += OnAttackAction;
        //esto se llama suscribirnos a un evento. agregar una funcion para attackAction performed. 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //CallbackContext devuelve informacion
    void OnAttackAction(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            print("mouse clicked");
        }
    }
}
