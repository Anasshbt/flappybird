using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public float backgroundSpeed = 1.0f; // Vitesse de déplacement du fond
    public float backgroundWidth = 20.0f; // Largeur de l'image de fond

    void Update()
    {
        MoveBackground(); // Appel de la méthode pour déplacer le fond
    }

    public void MoveBackground()
    {
        // Déplacement du fond
        transform.Translate(Vector3.left * backgroundSpeed * Time.deltaTime);

        // Si le bord droit du fond est hors de l'écran
        if (transform.position.x <= -backgroundWidth)
        {
            // Réinitialiser la position du fond pour qu'il apparaisse à droite de l'écran
            Vector3 newPos = transform.position;
            newPos.x += backgroundWidth * 2;
            transform.position = newPos;
        }
    }
}
