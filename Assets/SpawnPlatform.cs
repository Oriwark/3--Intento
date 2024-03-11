using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{
    public List<GameObject> platformList = new List<GameObject>();
    public float spawnTime;
    private float SpawnCountTime;
    private Vector3 SpawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SpwanPlatform();
    }

    public void SpwanPlatform()
    {
        SpawnCountTime += Time.deltaTime;
        SpawnPosition = transform.position;
        SpawnPosition.x = Random.Range(-8.50f,2.77f);

        if (SpawnCountTime >= spawnTime)
        {
            platformAppereance();
            SpawnCountTime = 0;
        }
    }

    public void platformAppereance()
    {
        int index =Random.Range(0,platformList.Count);
        Instantiate(platformList[index],SpawnPosition,Quaternion.identity);
    }
}
