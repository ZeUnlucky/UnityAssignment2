using UnityEngine;
using UnityEngine.Events;

public class CollisionDetection : MonoBehaviour
{
    [SerializeField] Material CollisionColor;
    public UnityAction<CollisionData> CollisionActionEvent;
    private void OnCollisionEnter(Collision collision)
    {
        // calls the CollisionActionEvent each time it collides with something,
        // returning what it collided with
        if (collision.gameObject.tag == "Player")
            CollisionActionEvent.Invoke(new CollisionData(gameObject, collision.gameObject, CollisionColor));
    }
}
