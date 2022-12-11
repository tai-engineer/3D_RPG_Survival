using System;
using UnityEngine;
using UnityEngine.InputSystem;
namespace TV.Input
{
    [CreateAssetMenu(fileName = "New User Input", menuName = "CharacterInput/UserInput")]
    public class UserInputSO : CharacterInputSO, InputControls.IPlayerMovementActions
    {
        public Vector2 cameraInput { get; protected set; }
        private InputControls controls;

        private void OnEnable()
        {
            if (controls == null)
            {
                controls = new InputControls();
                controls.PlayerMovement.SetCallbacks(this);
            }
            controls.Enable();
        }

        private void OnDisable()
        {
            controls.Disable();
        }

        #region Callback Functions
        public void OnMovement(InputAction.CallbackContext context)
        {
            moveInput = context.ReadValue<Vector2>();
        }

        public void OnCamera(InputAction.CallbackContext context)
        {
            cameraInput = context.ReadValue<Vector2>();
        }
        #endregion
    }
}
