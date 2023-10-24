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
        
        private int _animIDRun;

        void Start()
        {
            myRigidBody = GetComponent<Rigidbody2D>();
            myAnimator = GetComponent<Animator>();
            myBodyCollider = GetComponent<CapsuleCollider2D>();
            _krodunInputs = GetComponent<KrodunInputs>();
            AssignAnimationIds();
        }

        void Update()
        {
            Run();
            FlipSprite();
        }
        
        void AssignAnimationIds()
        {
            _animIDRun = Animator.StringToHash("isRunning");
        }
        
        void FlipSprite()
        {
            bool playerHasHorizontalSpeed = Mathf.Abs(myRigidBody.velocity.x) > Mathf.Epsilon;
            if (playerHasHorizontalSpeed)
            {
                transform.localScale = new Vector2(Mathf.Sign(myRigidBody.velocity.x), 1f);
            }
        }
        
        void Run()
        {
            Vector2 playerVelocity = new Vector2(_krodunInputs.move.x * moveSpeed, myRigidBody.velocity.y);
            myRigidBody.velocity = playerVelocity;
            
            bool playerHasHorizontalSpeed = Mathf.Abs(myRigidBody.velocity.x) > Mathf.Epsilon;
            myAnimator.SetBool(_animIDRun, playerHasHorizontalSpeed);
        }
        
    }
}