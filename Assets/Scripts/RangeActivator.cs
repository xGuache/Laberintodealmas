using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeActivator : MonoBehaviour
{

    [SerializeField] private BoxCollider2D BoxCollider;
    [SerializeField] private LayerMask PlayerLayer;
    [SerializeField] private float Range;
    [SerializeField] private float ColliderDistance;
    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {

        if (PlayerInSight())
        {

        }
    }

    private bool PlayerInSight()
    {
        RaycastHit2D hit =
        Physics2D.BoxCast(BoxCollider.bounds.center + transform.right * Range * transform.localScale.x * ColliderDistance,
        new Vector3(BoxCollider.bounds.size.x * Range, BoxCollider.bounds.size.y, BoxCollider.bounds.size.z),
        0, Vector2.left, 0, PlayerLayer);

        return hit.collider != null;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(BoxCollider.bounds.center + transform.right * Range * transform.localScale.x * ColliderDistance,
        new Vector3(BoxCollider.bounds.size.x * Range, BoxCollider.bounds.size.y, BoxCollider.bounds.size.z));
    }
}


