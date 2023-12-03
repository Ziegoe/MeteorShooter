using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public Transform meteorsPrefab;
    public int fieldRadius = 2500;
    public int meteorCount = 1000;

    void Start()
    {
        for(int loop = 0; loop < meteorCount; loop++)
        {
            Instantiate(meteorsPrefab, Random.insideUnitSphere * fieldRadius, Quaternion.identity);
        }

    }


}
