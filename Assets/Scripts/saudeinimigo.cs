using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saudeinimigo : MonoBehaviour
{
    public int vidaMaxima;
    public int vidaAtual;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReceberDano()
    {
        vidaAtual -= 1;

        if(vidaAtual <= 0)
        {
            Debug.Log("Voce Matou Ele");
        }
    }
}
