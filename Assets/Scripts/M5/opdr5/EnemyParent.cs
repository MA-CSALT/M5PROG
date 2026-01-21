
using UnityEngine;

public class EnemyParent : MonoBehaviour
{
    
    public float HP;
    public float moveSpeed;
    Rigidbody rb;


    public void OnTriggerEnter(Collider other)
    {
        HP -= 20;
        if (HP < 0)
        {
            Destroy(gameObject);
        }
    }

    public void WalkRight()
    {
        Debug.Log($"rb: {rb} transform: {transform} movespeed: {moveSpeed}");

        transform.position += transform.right * moveSpeed * Time.deltaTime;

       //rb.velocity = transform.right * moveSpeed;
    }
    protected void Initialize()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("update");
        WalkRight();
    }
}
