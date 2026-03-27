using UnityEngine;
public class Movement : MonoBehaviour
{
    [SerializeField] float speed = 100f; // Vitesse de déplacement du personnage
    private bool isLeft =
      false; // Booléen pour savoir si le personnage se déplace vers la gauche
    private SpriteRenderer
      sp; // Référence au SpriteRenderer pour gérer le flip du sprite
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sp = GetComponent<SpriteRenderer>(); // Initialisation du SpriteRenderer
    }

    // Update is called once per frame


    void Update()
    {
        float axisH = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * axisH * speed * Time.deltaTime);
        // Flip du sprite
        if (axisH < 0)
            isLeft =
                true; // Si l'input est négatif, le personnage se déplace à gauche
        if (axisH > 0)
            isLeft =
                false; // Si l'input est positif, le personnage se déplace à droite
        sp.flipX = isLeft; // Inverse le sprite si nécessaire
        float axisV = Input.GetAxis("Vertical");
        transform.Translate(Vector2.up * axisV * speed * Time.deltaTime);
        // Flip du sprite
        if (axisV < 0)
            isLeft =
                true; // Si l'input est négatif, le personnage se déplace à gauche
        if (axisV > 0)
            isLeft =
                false; // Si l'input est positif, le personnage se déplace à droite
        sp.flipX = isLeft; // Inverse le sprite si nécessaire
    }
}
