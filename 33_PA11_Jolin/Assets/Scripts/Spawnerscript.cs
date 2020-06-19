using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject SpawnObject1;
    public GameObject SpawnObject2;
    public GameObject SpawnObject3;

    float PositionY;

    // Start is called before the first frame update
    void Start()
    {
        //invoke the function 
        //Repeat the function at a certain time and certain repeat rate
        InvokeRepeating("SpawnFirstObj", 1, 3);
        InvokeRepeating("SpawnSecondObj", 2, 3);
        InvokeRepeating("SpawnThirdObj", 3, 3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnFirstObj()
    {
        //At any Y position
        PositionY = Random.Range(4, -4f);

        //Make the spawner go to random place
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);

        //Spawn the obj
        Instantiate(SpawnObject1, transform.position, transform.rotation);
    }

    void SpawnSecondObj()
    {
        //At any Y position
        PositionY = Random.Range(4, -4f);

        //Make the spawner go to random place
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);

        //Spawn the obj
        Instantiate(SpawnObject2, transform.position, transform.rotation);
    }

    void SpawnThirdObj()
    {
        //At any Y position
        PositionY = Random.Range(4, -4f);

        //Make the spawner go to random place
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);

        //Spawn the obj
        Instantiate(SpawnObject3, transform.position, transform.rotation);
    }

}

    

