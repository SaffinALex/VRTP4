using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ChangeColorScript : MonoBehaviour
{
    public void Red() 
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
    public void Blue()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }
    public void Magenta()
    {
        GetComponent<Renderer>().material.color = Color.magenta;
    }
}