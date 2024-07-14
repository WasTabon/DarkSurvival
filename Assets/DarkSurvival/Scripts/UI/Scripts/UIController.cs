using System;
using UnityEngine;
using DarkSurvival.Scripts.Interfaces;

namespace DarkSurvival.Scripts.UI.Scripts
{
    public class UIController : IUpdatable
    {
        public event Action<Vector2> InputPressed;

        private InputControls _inputControls;

        public void Initialize(InputControls inputControls)
        {
            _inputControls = inputControls;
            
            _inputControls.Player.Move.performed += ctx => OnMovePerformed(ctx.ReadValue<Vector2>());
        }
        
        public void Update()
        {
            
        }
        
        private void OnMovePerformed(Vector2 movement)
        {
            InputPressed?.Invoke(movement);
        }
    }
}
