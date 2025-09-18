
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opdr1 : MonoBehaviour
{
    public GameObject prefab;



    private Color RandColor()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);

        return new Color(r, g, b);
    }

    private Vector3 randPos()
    {
        float y = Random.Range(-10f, 10f);
        float x = Random.Range(-10f, 10f);
        float z = Random.Range(-10f, 10f);

        return new Vector3(x, y, z);
       
    }
    


   
    private GameObject CreateBall(Color c, Vector3 position)
    {
        GameObject ball =Instantiate(prefab);
        ball.transform.position = position;
        Material material = ball.GetComponent<MeshRenderer>().material;
        material.SetColor("_Color", c);
        return ball;
    }

    private float elapsedTime = 0f;


    private void DestroyBall(GameObject ball)
    {
     
            Destroy(ball,3f);
     
           
        
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 100; i++) 
        {
            Color color = RandColor();
            Vector3 pos = randPos();

            CreateBall(color, pos);
        }
    }

    // Update is called once per frame
    void Update()
    {

        elapsedTime += Time.deltaTime;
        if (elapsedTime > 1f)
        {
            Color color = RandColor();
            Vector3 pos = randPos();
            GameObject ball = CreateBall(color, pos);
            DestroyBall(ball);
            elapsedTime = 0f;
        }
    }
}
