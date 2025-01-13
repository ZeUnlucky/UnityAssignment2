using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class CollisionEvent : UnityEvent<int> { }
public class CollisionEventManager : MonoBehaviour
{
    public CollisionEvent OnCollisionEvent;
    private int collisionCount = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (OnCollisionEvent == null)
            OnCollisionEvent = new CollisionEvent();
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collisionCount++;
            
            OnCollisionEvent.Invoke(collisionCount);
        }  
    }
}
