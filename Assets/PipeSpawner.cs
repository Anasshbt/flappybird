using UnityEngine;
using System.Collections;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipePrefab; // Prefab du tuyau
    public GameObject background;
    public float spawnInterval = 2.0f; // Intervalle entre chaque génération de tuyau
    public float delayBetweenPipes = 2.5f; // Délai entre chaque génération de tuyaux successifs

    void Start()
    {
        // Lancer la coroutine pour générer des tuyaux
        StartCoroutine(SpawnPipeRoutine());
    }

    IEnumerator SpawnPipeRoutine()
    {
        // Tant que le jeu n'est pas terminé
        while (true) // Vous devrez modifier cette condition selon vos besoins
        {
            // Générer un nouveau tuyau
            SpawnPipe();

            // Attendre le prochain intervalle de génération
            yield return new WaitForSeconds(spawnInterval);

            // Attendre le délai entre chaque génération de tuyaux successifs
            yield return new WaitForSeconds(delayBetweenPipes);
        }
    }

    public void SpawnPipe()
    {
        // Définir la position de spawn du tuyau
        Vector3 spawnPosition = new Vector3(10f, 3.44f, 0f);
        
        // Définir la rotation du tuyau
        //Quaternion spawnRotation = Quaternion.Euler(0.412f, 293.917f, 0f);

        // Générer un nouveau tuyau à la position et rotation définies
        GameObject pipe = Instantiate(pipePrefab, spawnPosition, Quaternion.Euler(0,0,0)) as GameObject;
        pipe.transform.parent = background.transform;
    }
}
