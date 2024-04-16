using UnityEngine;

public class PipeController : MonoBehaviour
{
    public float pipeSpeed = 2.0f; // Vitesse de déplacement des tuyaux

    void Update()
    {
        // Déplacement des tuyaux de droite à gauche
        transform.Translate(Vector3.left * pipeSpeed * Time.deltaTime);

        // Si le tuyau est complètement sorti de l'écran
        if (transform.position.x > 200f) // Assurez-vous que cette valeur correspond à la largeur du fond
        {
            // Réinitialiser la position du tuyau
            // Vous pouvez également le désactiver pour le réutiliser ultérieurement
            Destroy(gameObject);
        }
    }
}
