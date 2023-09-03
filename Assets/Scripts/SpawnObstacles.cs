using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject newObject;
    public GameObject[] spawnObjects;
    public GameObject pipe;

    public Transform spawnTransformTop, spawnTransformMid, spawnTransformBot;


    public float spawnTime = 1;
    public float timer = 0;
    private int spawnedObjectCount;
    private int lastRandomPositionIndex;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > spawnTime)
        {
            int randomIndex = Random.Range(0, 100);
            if(randomIndex <= 90)
            {
                randomIndex = 1; // cloud
            }
            else if(randomIndex > 90)
            {
                randomIndex = 0; // coin
            }
            
            int randomPositionIndex;
            do
            {
                randomPositionIndex = Random.Range(0, 3);
            } while (randomPositionIndex == lastRandomPositionIndex);

            if(spawnedObjectCount % 10 == 0)
            {
                newObject = Instantiate(pipe);
                newObject.transform.position = spawnTransformMid.transform.position;
                spawnedObjectCount++;
                timer = 0;
                timer += Time.deltaTime;
                return;
            }
            newObject = Instantiate(spawnObjects[randomIndex]); // spawn a random object
            spawnedObjectCount++;
      

            if (randomPositionIndex == 0)
            {
                newObject.transform.position = spawnTransformTop.transform.position;
            }
            if (randomPositionIndex == 1)
            {
                newObject.transform.position = spawnTransformMid.transform.position;
            }
            if (randomPositionIndex == 2)
            {
                newObject.transform.position = spawnTransformBot.transform.position;
            }
            lastRandomPositionIndex = randomPositionIndex;
            Destroy( newObject, 15);
            timer = 0;
        }
        timer += Time.deltaTime;

    }
}
