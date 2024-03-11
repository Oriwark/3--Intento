using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataformaMov : MonoBehaviour
{
    public GameObject ObjetoAmover;
    public Transform PuntodeInicio;
    public Transform PuntodeFin;

    public float Velocidad;

    private Vector3 Moverhacia;
    
    
    // Start is called before the first frame update
    void Start()
    {
        Moverhacia = PuntodeFin.position;
    }

    // Update is called once per frame
    void Update()
    {
        ObjetoAmover.transform.position = Vector3.MoveTowards(ObjetoAmover.transform.position, Moverhacia, Velocidad * Time.deltaTime); 
    }
}
