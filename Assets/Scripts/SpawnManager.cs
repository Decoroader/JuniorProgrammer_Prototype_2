using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] AnimalPrefabs;
    
    private float maxAbsX = 20.0f;
    private float maxZ = 25.0f;
    private Vector3 newAnimalPosition;
    private float startDelay = 2.0f;
    private float spInterval = 1.5f;

	void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spInterval);
    }
    void SpawnRandomAnimal()
	{
        int animalIndex = Random.Range(0, AnimalPrefabs.Length);
        newAnimalPosition = new Vector3(Random.Range(-maxAbsX, maxAbsX), 0, maxZ);
        Instantiate(AnimalPrefabs[animalIndex], newAnimalPosition, AnimalPrefabs[animalIndex].transform.rotation);
    }
}
