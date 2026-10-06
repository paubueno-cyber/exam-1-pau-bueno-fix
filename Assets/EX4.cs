using UnityEngine;
using UnityEngine.InputSystem;

public class VehicleController : MonoBehaviour
{
    public Transform turret;

    public float moveSpeed = 5f;
    public float rotationSpeed = 100f;
    public float turretSpeed = 100f;

    private Vector2 driveInput;
    private Vector2 turretInput;

    public void OnDrive(InputAction.CallbackContext context)
    {
        driveInput = context.ReadValue<Vector2>();
    }

    public void OnTurret(InputAction.CallbackContext context)
    {
        turretInput = context.ReadValue<Vector2>();
    }

    void Update()
    {
      
        transform.Translate(
            Vector3.forward * driveInput.y * moveSpeed * Time.deltaTime
        );

      
        transform.Rotate(
            Vector3.up * driveInput.x * rotationSpeed * Time.deltaTime
        );

       
        turret.Rotate(
            Vector3.up * turretInput.x * turretSpeed * Time.deltaTime
        );
    }
}
