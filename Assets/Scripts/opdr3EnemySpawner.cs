using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update

    public List<GameObject> enemies = new List<GameObject>();
    public GameObject Enemy;

    private GameObject createEnemy() 
    {
        GameObject enemy = Instantiate(Enemy);
        enemies.Add(enemy);
        return enemy;
    }

    private void destroyEnemy(GameObject enemy)
    {
        Destroy(enemy);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //enemies.Add(Instantiate(Enemy));

        if (Input.GetKeyDown(KeyCode.W)) 
        {
            for (int i = 0; i < 100; i++)
            {
                createEnemy();
            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            foreach (GameObject enemy in enemies)
            {
                destroyEnemy(enemy);
                //Destroy(enemy.gameObject);
                //DestroyImmediate(enemy, true);
            }
            enemies.Clear();
        }
    }
}
