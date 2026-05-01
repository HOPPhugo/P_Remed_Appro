using UnityEngine;

public class Movementplayer : MonoBehaviour
{
    [SerializeField] float speed = 20f;

    void Update()
    {
        // Déplacement clavier
        float axisH = Input.GetAxis("Horizontal");
        float axisV = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(axisH, axisV);
        transform.Translate(movement * speed * Time.deltaTime, Space.World);

        // Rotation vers la souris
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0f;

        Vector2 direction = mousePos - transform.position;

        if (direction.magnitude > 0.1f) // évite les bugs si la souris est trop proche
        {
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, angle);
        }
    }
}