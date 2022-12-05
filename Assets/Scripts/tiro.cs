using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiro : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject tiroPrefab;
    public GameObject canhao;
    public int moedasColetadas;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(tiroPrefab, new Vector3(canhao.transform.position.x, canhao.transform.position.y, canhao.transform.position.z), canhao.transform.rotation);
        }
        void OnTriggerSpace2D(Collider2D body)
        {
            if (body.gameObject.CompareTag("moeda"))
            {
                Destroy(body.gameObject);
                moedasColetadas++;
            }
        }
    }
}
