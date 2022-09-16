using UnityEngine;

public class SwitchColor : MonoBehaviour
{
    MeshRenderer meshRenderer;
    public GameObject[] objects;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }
    public void doRed()
    {
        if (objects[0].active == true)
        {
            objects[0].GetComponent<MeshRenderer>().material.color = Color.red;
        }
        if (objects[1].active == true)
        {
            objects[1].GetComponent<MeshRenderer>().material.color = Color.red;
        }
        if (objects[2].active == true)
        {
            objects[2].GetComponent<MeshRenderer>().material.color = Color.red;
        }
        if (objects[3].active == true)
        { 
            objects[3].GetComponent<MeshRenderer>().material.color = Color.red;
        }
    }
    public void doGreen()
    {
        if (objects[0].active == true)
        {
            objects[0].GetComponent<MeshRenderer>().material.color = Color.green;
        }
        if (objects[1].active == true)
        {
            objects[1].GetComponent<MeshRenderer>().material.color = Color.green;
        }
        if (objects[2].active == true)
        {
            objects[2].GetComponent<MeshRenderer>().material.color = Color.green;
        }
        if (objects[3].active == true)
        {
            objects[3].GetComponent<MeshRenderer>().material.color = Color.green;
        }
    }
    public void doBlue()
    {
        if (objects[0].active == true)
        {
            objects[0].GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (objects[1].active == true)
        {
            objects[1].GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (objects[2].active == true)
        {
            objects[2].GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        if (objects[3].active == true)
        {
            objects[3].GetComponent<MeshRenderer>().material.color = Color.blue;
        }
    }
    public void doBlack()
    {
        if (objects[0].active == true)
        {
            objects[0].GetComponent<MeshRenderer>().material.color = Color.black;
        }
        if (objects[1].active == true)
        {
            objects[1].GetComponent<MeshRenderer>().material.color = Color.black;
        }
        if (objects[2].active == true)
        {
            objects[2].GetComponent<MeshRenderer>().material.color = Color.black;
        }
        if (objects[3].active == true)
        {
            objects[3].GetComponent<MeshRenderer>().material.color = Color.black;
        }
    }
}