using UnityEngine;

public class UnitController : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Vector2 movement = new Vector2(moveX, moveY);

        transform.Translate(movement.normalized * moveSpeed * Time.deltaTime);
    }
}