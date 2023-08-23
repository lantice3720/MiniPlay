using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridScript : MonoBehaviour
{
    
    [SerializeField] GameObject gridPrefab;

    [SerializeField] private float number;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < number; i++)
        {
            for (int j = 0; j < number; j++)
            {
                GameObject grid = Instantiate(gridPrefab);
                grid.transform.position = new Vector3(i, j, 0f);
                // Instantiate(gridPrefab, new Vector3(i, 0, j), Quaternion.identity);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
