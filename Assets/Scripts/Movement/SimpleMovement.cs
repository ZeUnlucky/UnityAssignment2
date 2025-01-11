using UnityEngine;

public class SimpleMovement : MonoBehaviour
{
    [SerializeField] float destinationZ;
    private bool didCollide = false;

    private void Start()
    {
        GetComponent<CollisionDetection>().CollisionActionEvent += CheckCollision;
    }

    void Update()
    {
        if (!didCollide)
        {
            if (Mathf.Abs(transform.position.z - destinationZ) > 0.5f)
                transform.Translate(new Vector3(0, 1, destinationZ) * Time.deltaTime * 0.2f);
        }
    }

    private void CheckCollision(CollisionData collisionData)
    {
        didCollide = true;
    }
}
