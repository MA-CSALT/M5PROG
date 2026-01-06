using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    public GameObject towerPrefab;

    private Vector3 randPos()
    {
        float y = 1f;
        float x = Random.Range(-10f, 10f);
        float z = Random.Range(-10f, 10f);

        return new Vector3(x, y, z);

    }

    private Vector3 randScale()
    {
        float allpos = Random.Range(1f, 5f);

        float y = allpos;
        float x = allpos;
        float z = allpos;

        return new Vector3(x, y, z);

    }

    private GameObject CreateTower(Vector3 scale, Vector3 pos)
    {
        GameObject tower = Instantiate(towerPrefab);
        tower.transform.position = pos;
        tower.transform.localScale = scale;
        return tower;
    }
    
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector3 pos = randPos();
            Vector3 scale = randScale();
            GameObject tower = CreateTower(scale, pos);
        }
    }
}
