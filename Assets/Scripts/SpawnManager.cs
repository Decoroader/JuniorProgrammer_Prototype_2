using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] AnimalPrefabs;
    private float maxAbsX = 20.0f;
    private float maxZ = 20.0f;
    private Vector3 newAnimalPosition;
	
	void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            int animalIndex = Random.Range(0, AnimalPrefabs.Length);
            newAnimalPosition = new Vector3(Random.Range(-maxAbsX, maxAbsX), 0, maxZ);
            Instantiate(AnimalPrefabs[animalIndex], newAnimalPosition, AnimalPrefabs[animalIndex].transform.rotation);
        }
    }
}
