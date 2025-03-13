using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Movement speed
    public float speed 2.50f;
    public CharacterController playerMovement;
    public GameObject AnnaCap;
    public Vector3 annaMov;
    public Rigidbody rb;

     // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    //Update functions as Key movement code
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) //If the if statement is true, for every frame the W key held down.
        {
            
        }
    }
}
