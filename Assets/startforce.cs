using UnityEngine;

public class StartForce : MonoBehaviour
{
    public Vector3 startForce;

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddForce(startForce, ForceMode.Impulse);
    }
}
