using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCube : MonoBehaviour
{

    public GameObject prefab_SmallCube;
    public GameObject prefab_BigCube;

    public GameObject PairedCube;

    public GameObject PairedCube_Last;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("mapcube start");
        PairedCube_Last = PairedCube;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision targetObj)
    {
        
        if (targetObj.gameObject.tag == "Droplet")
        {
            Debug.Log("FOOBAR");
            //Creates a small cube on top of the existing small cube

            Vector3 cubePosition;
            Vector3 offsetPosition = Vector3.up * .5f;
            cubePosition = this.transform.position + offsetPosition;

            GameObject cube = GameObject.Instantiate<GameObject>(prefab_SmallCube);
            cube.gameObject.tag = "New";
            cube.transform.position = cubePosition;

            //--//

            //Creates a big cube on top of the PAIRED big cube
            Vector3 cubePosition_Big;
            Vector3 offsetPosition_Big = Vector3.up * 1f;
            cubePosition_Big = PairedCube.transform.position + offsetPosition_Big;

            GameObject cube_Big = GameObject.Instantiate<GameObject>(prefab_BigCube);
            cube_Big.gameObject.tag = "New";
            cube_Big.transform.position = cubePosition_Big;

            //PairedCube_Last 
            // cube.PairedCube = cube_Big;
            cube.GetComponent<MapCube>().setPairedCube(cube_Big);



        }
    }

    public void setPairedCube(GameObject c)
    {
        Debug.Log("SETCUBE");
        PairedCube = c;
    }
    void createCube(GameObject cubeType, Vector3 spawnPos)
    {
        //pass;
    }

}
