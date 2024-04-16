using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float jumpForce = 5.0f; // Force du saut de l'oiseau

    private Rigidbody2D rb; // Référence au Rigidbody2D de l'oiseau

    void Start()
    {
        // Obtenez la référence au Rigidbody2D attaché à l'oiseau
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Gestion du saut de l'oiseau lorsque vous appuyez sur la flèche vers le haut
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // Appliquer la force de saut vers le haut
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }

        // Gestion du mouvement vers le bas lorsque vous appuyez sur la flèche vers le bas
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            // Changer la gravité pour faire descendre l'oiseau plus rapidement
            rb.gravityScale = 2.0f;
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            // Rétablir la gravité normale lorsque vous relâchez la flèche vers le bas
            rb.gravityScale = 1.0f;
        }
    }
}
