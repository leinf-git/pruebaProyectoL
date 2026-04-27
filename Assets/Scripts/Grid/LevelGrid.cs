using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGrid : MonoBehaviour
{
    //en este script se crea el piso, como los demás no heredan de Mnobehaviour, no se pueden agregar a un objeto

    private GridSystem gridSystem;
    void Awake()
    {
        gridSystem = new GridSystem(10, 10, 1);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
