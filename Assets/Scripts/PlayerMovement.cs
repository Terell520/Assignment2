using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Movement speed
    
    public CharacterController annamov;
    public float speed = 5f;
    public Vector3 annaPos;
    public Rigidbody rb;

    // Update is called once per frame
    //Update functions as Key movement code
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal"); //Raw inputs for when A & D are pressed 
        float vertical = Input.GetAxisRaw("Vertical"); // Raw inputs for when W & S are pressed

    }
}
