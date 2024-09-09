using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubo : MonoBehaviour
{
    public float Velocidade = 5f;
    public float forcapulo = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float movimentoHorizontal = 0f;
        float movimentoVertical = 0f;
        if( Input.GetKey(KeyCode.RightArrow))
        {
            movimentoHorizontal = 1f;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            movimentoHorizontal = -1f;
        
        }
        else
        {
            movimentoHorizontal = 0f;

        }
        transform.position += new Vector3 (movimentoHorizontal, 0f, 0f) * Velocidade * Time.deltaTime;

        if(Input.GetKey(KeyCode.UpArrow)){
            movimentoVertical = 1f;
        }
        
        else{
            movimentoVertical = 0f;
        }
         transform.position += new Vector3 (0f, movimentoVertical, 0f) * forcapulo * Time.deltaTime;
    }
}
