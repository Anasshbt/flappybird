using UnityEngine;
using System.Collections;

public class PipeSpawnerbas : MonoBehaviour
{
    public GameObject pipePrefab; // Prefab du tuyau
    public GameObject background; 
    public float spawnInterval = 2.0f; // Intervalle entre chaque génération de tuyau
    public float delayBetweenPipes = 2.5f; // Délai entre chaque génération de tuyaux successifs

    void Start()
    {
        // Lancer la coroutine pour générer des tuyaux
        StartCoroutine(SpawnPipeRoutinebas());
    }

    IEnumerator SpawnPipeRoutinebas()
    {
        // Tant que le jeu n'est pas terminé
        while (true) // Vous devrez modifier cette condition selon vos besoins
        {
            // Générer un nouveau tuyau
            SpawnPipebas();

            // Attendre le prochain intervalle de génération
            yield return new WaitForSeconds(spawnInterval);

            // Attendre le délai entre chaque génération de tuyaux successifs
            yield return new WaitForSeconds(delayBetweenPipes);
        }
    }

    public void SpawnPipebas()
    {
        // Définir la position de spawn du tuyau
        Vector3 spawnPosition = new Vector3(-4.85f, -3.2f, 0f);
        
        // Définir la rotation du tuyau
        Quaternion spawnRotation = Quaternion.Euler(-0.198f, 246.08f, 0f);

        // Générer un nouveau tuyau à la position et rotation définies
        //Instantiate(pipePrefab, spawnPosition, spawnRotation);
        GameObject pipe = Instantiate(pipePrefab, spawnPosition, Quaternion.Euler(0,0,0)) as GameObject;
        pipe.transform.parent = background.transform;
    }
}
