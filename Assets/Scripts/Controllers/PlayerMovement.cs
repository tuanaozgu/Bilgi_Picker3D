using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private new Rigidbody playerRigidbody;
    [SerializeField] private float speed = 50;
    private Vector2 _InputValues;
    private void Update()
    {
        _InputValues = GetInputValues();
    }
    
    private Vector2 GetInputValues()
    {
        return new Vector2(Input.GetAxisRaw("Vertical"), Input.GetAxisRaw("Horizontal"));
    }
    private void FixedUpdate()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        playerRigidbody.velocity += new Vector3(_InputValues.x + -speed + Time.fixedDeltaTime, playerRigidbody.velocity.y, _InputValues.y * speed + Time.fixedDeltaTime);
    }
}
