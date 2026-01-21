using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elf : EnemyParent
{
    public float timer;
    public bool visib;
   
    public Renderer Renderer;

    void Start()
    {
        Initialize();
        moveSpeed = 5;
        HP = 60;
        Renderer = GetComponent<Renderer>();

    }

    private void ToggleVisibility()
    {
        timer += Time.deltaTime;

        if (timer > 3 && !visib)
        {
            timer = 0;
            visib = true;
            Renderer.enabled = false;
        }

        if (timer > 0.5 && visib)
        {
            Renderer.enabled = true;
            visib = false;
            timer = 0;
        }
    }
    void Update()
    {
        base.WalkRight();
        ToggleVisibility();
    }
}
