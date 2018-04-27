using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGenerator : MonoBehaviour
{

    public GameObject[] groundPrefabs;
    public float maxStep;

    public float maxHeight;
    public float minHeight;

    private float previousGroundY = -0.62f;

	// Use this for initialization
	void Start ()
    {
        InvokeRepeating("GenerateNewGround", 0, 2.5f);
	}
	
	// Update is called once per frame
	void GenerateNewGround ()
    {
        float newY;
        do
        {
            newY = Random.Range(minHeight, maxHeight);

        }
        while(newY > maxStep + previousGroundY);

        Vector3 targetPrefabPosition = new Vector3(this.transform.position.x, newY, this.transform.position.z);
        previousGroundY = targetPrefabPosition.y;
        Instantiate(groundPrefabs[Random.Range(0, groundPrefabs.Length)], targetPrefabPosition, Quaternion.identity);
	}
}
