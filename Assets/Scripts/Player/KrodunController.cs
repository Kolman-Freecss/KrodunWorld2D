using UnityEngine;

public class KrodunController : MonoBehaviour
{
    [SerializeField] float moveSpeed = 1f;
    
    Rigidbody2D myRigidBody;
    Animator myAnimator;
    CapsuleCollider2D myBodyCollider;
    
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        myBodyCollider = GetComponent<CapsuleCollider2D>();
    }

    void Update()
    {
        Run();

    }
    
    
    
}
