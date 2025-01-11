using UnityEngine;

public class CollisionData
{
    public GameObject Collider { private set; get; }
    public GameObject CollidedWith { private set; get; }
    public Material CollisionColor { private set; get; }
    public CollisionData(GameObject collider, GameObject collidedWith, Material collisionColor)
    {
        Collider = collider;
        CollidedWith = collidedWith;
        CollisionColor = collisionColor;
    }
}
