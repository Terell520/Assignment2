using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Movement speed

    public float speed = 5f;

    public float talk; 

    public Transform cam;

    public float DaSmoothTime = 0.1f;

    //serves as a reference to a veriable that holds current smooth Velocity
    float smoothTurn; 

    // Update is called once per frame
    //Update functions as Key movement code
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal"); //Raw inputs for when A & D are pressed 
        float vertical = Input.GetAxisRaw("Vertical"); // Raw inputs for when W & S are pressed
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref smoothTurn, DaSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward; //Turns rotaton into direction
            transform.position += moveDir.normalized * speed * Time.deltaTime;
        }



    }
}
