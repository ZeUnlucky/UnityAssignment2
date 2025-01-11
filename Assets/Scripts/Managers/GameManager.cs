using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] CollisionDetection Agent1;
    [SerializeField] CollisionDetection Agent2;
    [SerializeField] public SoundController SoundController;
    void Start()
    {
        Agent1.CollisionActionEvent += ShowInfoOnCollision;
        Agent2.CollisionActionEvent += ShowInfoOnCollision;
        Agent1.CollisionActionEvent += SoundController.PlaySound;
        Agent1.CollisionActionEvent += changeColorOnCollision;
        Agent2.CollisionActionEvent += changeColorOnCollision;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ShowInfoOnCollision(CollisionData data)
    {
        Debug.Log(data.Collider.name + " has collided with " + data.CollidedWith.name);
    }

    private void changeColorOnCollision(CollisionData data)
    {
        data.Collider.GetComponent<Renderer>().material = data.CollisionColor;
    }
}
