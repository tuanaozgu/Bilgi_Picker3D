using UnityEngine;
using Managers;

namespace Controllers.Player
{
    public class PlayerPhysicsController : MonoBehaviour
    {
        #region Self variables

        #region Serialized Variables
        

        [SerializeField] public new Collider collider;
        [SerializeField] public new Rigidbody rigidbody;
        [SerializeField] private PlayerManager manager;

        #endregion

        #endregion

        public void OnReset()
        {
            
        }
    }
}