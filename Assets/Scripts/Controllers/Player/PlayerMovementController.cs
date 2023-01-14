using Data.ValueObjects;
using Managers;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Controllers.Player
{
    public class PlayerMovementController : MonoBehaviour
    {
        #region Self Variables

        #region Serialized Variables

        [SerializeField] private new Rigidbody rigidbody;
        [SerializeField] private new Collider collider;
        [SerializeField] private PlayerManager manager;

        #endregion

        #region Private Variables

        [ShowInInspector] private MovementData _data;

        #endregion

        #endregion

        public void OnReset()
        {
            
        }

        public void GetMovementData(MovementData movementData)
        {
            _data = movementData;
        }
    }
}