using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] AnimalPrefabs;
    public int animalIndex;

    private float maxZ = 20.0f;
    private Vector3 newAnimalPosition;
	private void Start()
	{
        newAnimalPosition = new Vector3(0, 0, maxZ);
    }

	void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
            Instantiate(AnimalPrefabs[animalIndex], newAnimalPosition, AnimalPrefabs[animalIndex].transform.rotation);
    }
}
