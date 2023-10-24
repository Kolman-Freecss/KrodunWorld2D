using UnityEngine;

namespace Kolman_Freecss.KrodunWorld2D
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class KrodunController : MonoBehaviour
    {
        [SerializeField] float moveSpeed = 1f;

        Rigidbody2D myRigidBody;
        Animator myAnimator;
        CapsuleCollider2D myBodyCollider;

        private KrodunInputs _krodunInputs;

        void Start()
        {
            myRigidBody = GetComponent<Rigidbody2D>();
            myAnimator = GetComponent<Animator>();
            myBodyCollider = GetComponent<CapsuleCollider2D>();
            _krodunInputs = GetComponent<KrodunInputs>();
        }

        void Update()
        {
            Run();
        }
        
        void Run()
        {
            Vector2 playerVelocity = new Vector2(_krodunInputs.move.x * moveSpeed, myRigidBody.velocity.y);
            myRigidBody.velocity = playerVelocity;
        }
        
    }
}