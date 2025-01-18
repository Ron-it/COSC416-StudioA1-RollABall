using UnityEngine;

public class BallController : MonoBehaviour
{

    [SerializeField] private Rigidbody sphereRigidbody;
    [SerializeField] float ballSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    public void MoveBall(Vector2 input)
    {
        Vector3 inputXZPlane = new(input.x, 0, input.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = Vector2.zero; // initialize our input vector to zero
        if (Input.GetKey(KeyCode.W))
        {
            inputVector += Vector2.up; // "a += b" <=> "a = a + b"
        }
        if (Input.GetKey(KeyCode.S))
        {
            inputVector += Vector2.down;
        }
        if (Input.GetKey(KeyCode.A))
        {
            inputVector += Vector2.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            inputVector += Vector2.right;
        }

        Vector3 inputXZPlane = new Vector3(inputVector.x, 0, inputVector.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
        Debug.Log("Resultant Vector: " + inputVector);
        Debug.Log("Resultant 3D Vector: " + inputXZPlane);

    }
}
