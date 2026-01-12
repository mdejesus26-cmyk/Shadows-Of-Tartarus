using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public bool resistPhys;
    public bool resistFire;
    public bool resistIce;
    public bool resistThunder;
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        resistPhys = false;
        resistFire = false;
        resistIce = false;
        resistThunder = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
