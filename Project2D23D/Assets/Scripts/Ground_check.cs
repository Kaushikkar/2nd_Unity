using UnityEngine;

public class Ground_check : MonoBehaviour
{
    public float groundDistance = 0.2f;
    public LayerMask groundLayer;

    private bool isGrounded;

    public bool IsGrounded { get { return isGrounded; } }

    void Update()
    {
        Vector3 origin = transform.position;
        Vector3 direction = Vector3.down;
        float maxDistance = groundDistance;

        if (Physics.Raycast(origin, direction, out RaycastHit hit, maxDistance, groundLayer))
        {
            if (hit.normal.y > 0.5f)
            {
                isGrounded = true;
            }
            else
            {
                isGrounded = false;
            }
        }
        else
        {
            isGrounded = false;
        }
    }
}
