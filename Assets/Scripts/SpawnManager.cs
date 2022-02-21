using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //public float xLeftRange = -0.5f;
   // public float xRightRange = 2.8f;

    public GameObject[] animalPrefabs;
    private float spawnXLeftRange = -0.5f;
    private float spawnXRightRange = 2.8f;
    private float spawnRangeZ = 10.0f;
    private float startDelay = 3;
    private float spawnInterval = 2.5f;
   
    // Start is called before the first frame update
    void Start()
    {
        //StartCoroutine(CoroutineSpawn());
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnRandomAnimal()
    {
        if (DestroyOutBounds.gameOver == false)
        {
            Vector3 spawnPos = new Vector3(Random.Range(spawnXLeftRange, spawnXRightRange), 0.636f, spawnRangeZ);
            int animalIndex = Random.Range(0, animalPrefabs.Length);
            Instantiate(animalPrefabs[animalIndex], spawnPos,
                animalPrefabs[animalIndex].transform.rotation);
        }
        
    }

   /* private IEnumerator CoroutineSpawn()
    {
        
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        yield return new WaitForSeconds(10);

        spawnInterval = 4.0f;
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        yield return new WaitForSeconds(40);

        spawnInterval = 3.5f;
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        yield return new WaitForSeconds(500);

        spawnInterval = 3.0f;
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        yield return new WaitForSeconds(80);


        spawnInterval = 2.5f;
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        yield return new WaitForSeconds(100);
    }*/
}
