using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knopcka : MonoBehaviour
{
public GameObject[] firstGroup;
public GameObject[] secondGroup;
public knopcka button;
public Material normal;
public Material transparent;
private void OnTriggerEnter (Collider other){
    if(other. CompareTag("Cube") || other. CompareTag("Player"))
{
        foreach(GameObject first in firstGroup)
{
            first.GetComponent<Renderer>().material = normal;
            first.gameObject.layer=3;
}
        foreach (GameObject second in secondGroup){
            second.GetComponent<Renderer>().material = transparent;
            second.gameObject.layer = 6;
}
        button.GetComponent<Renderer>().material = transparent;
     button.GetComponent<Renderer>().material = normal;
}
}
}