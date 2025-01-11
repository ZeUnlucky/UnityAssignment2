using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] CollisionDetection Agent1;
    [SerializeField] CollisionDetection Agent2;
    void Start()
    {
        Agent1.CollisionActionEvent += ShowInfoOnCollision;
        Agent2.CollisionActionEvent += ShowInfoOnCollision;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ShowInfoOnCollision(CollisionData data)
    {
        Debug.Log(data.Collider.name + " has collided with " + data.CollidedWith.name);
        data.Collider.GetComponent<Renderer>().material = data.CollisionColor;
    }
}
