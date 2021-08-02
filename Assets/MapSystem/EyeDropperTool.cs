using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;



public class EyeDropperTool : MonoBehaviour
{

    public GameObject prefab_Drop;
    public GameObject SpawnPoint;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Drop()
    {
        Vector3 dropPosition;

 
        //Vector3 offsetPosition = Vector3.down * .38f;

        dropPosition = SpawnPoint.transform.position;

        Debug.Log("Drop");
        GameObject drop = GameObject.Instantiate<GameObject>(prefab_Drop);
        drop.transform.position = dropPosition;


    }
}
