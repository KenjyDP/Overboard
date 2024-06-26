using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    [SerializeField]
    private int _floorWidth = 22;
    [SerializeField]
    private int _floorHeight = 15;
    [SerializeField]
    private GameObject _tilePrefab;


    // Start is called before the first frame update
    void Start()
    {
        GenerateFloor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void GenerateFloor()
    {
        Vector3 floorPosition = new Vector3(-_floorWidth / 2, 0, -_floorHeight / 2);

        for (int x = 0; x < _floorWidth; x++)
        {
            for (int z = 0; z < _floorHeight; z++)
            {
                Vector3 tilePosition = new Vector3(floorPosition.x + x, 0, floorPosition.z + z);
                Instantiate(_tilePrefab, tilePosition, _tilePrefab.transform.rotation);
            }
        }
    }
}
