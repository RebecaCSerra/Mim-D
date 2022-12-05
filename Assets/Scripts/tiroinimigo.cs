using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System; 

public class tiroinimigo : MonoBehaviour
{
    public GameObject tiroPrefab;
    public GameObject canhao;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        System.Random tiro = new System.Random();
        if (tiro.NextDouble()<0.01)
        Instantiate(tiroPrefab, new Vector3(canhao.transform.position.x, canhao.transform.position.y, canhao.transform.position.z), canhao.transform.rotation);
    }
}
