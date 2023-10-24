using UnityEngine;
using UnityEngine.InputSystem;

namespace Kolman_Freecss.KrodunWorld2D
{
    [RequireComponent(typeof(PlayerInput))]
    public class KrodunInputs : MonoBehaviour
    {
        #region Inspector Variables

        [Header("Character Input Values")] public Vector2 move;
        public bool isJumping;

        #endregion

        #region On Events

        public void OnMove(InputValue value)
        {
            MoveInput(value.Get<Vector2>());
        }
        
        public void OnJump(InputValue value)
        {
            JumpInput(value.isPressed);
        }

        #endregion

        #region Input functions

        public void MoveInput(Vector2 newMoveDirection)
        {
            move = newMoveDirection;
        }
        
        public void JumpInput(bool newJumpState)
        {
            isJumping = newJumpState;
        }

        #endregion
    }
}