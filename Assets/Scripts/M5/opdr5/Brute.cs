using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brute : EnemyParent
{
    // Start is called before the first frame update
    void Start() {

        Initialize();
        
        moveSpeed = 2;
        

        HP = 150;
    }

    // Update is called once per frame

}
