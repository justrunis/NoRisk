using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapManager : MonoBehaviour
{
	Color normalColor = Color.cyan;

    Color mouseDownColor = Color.magenta;
    Color mouseEnterColor = Color.black;

    [SerializeField]
    private Text countryText;

    public void mapclick(GameObject objClicked)
    {
        Debug.Log("Clicked: " + objClicked.name);
    }

    public void mapMouseDown(GameObject objClicked)
    {
        Debug.Log("Pointer Down: " + objClicked.name);
        countryText.text = objClicked.name.ToString();
        normalColor = objClicked.GetComponent<MeshRenderer>().material.color;

        MeshRenderer mr = objClicked.GetComponent<MeshRenderer>();
        mr.material.color = mouseDownColor;
    }

    public void mapMouseUp(GameObject objClicked)
    {
        Debug.Log("Pointer Up: " + objClicked.name);
        normalColor = objClicked.GetComponent<MeshRenderer>().material.color;

        MeshRenderer mr = objClicked.GetComponent<MeshRenderer>();
        mr.material.color = normalColor; ;
    }

    public void mapMouseEnter(GameObject objClicked)
    {
        Debug.Log("Pointer Enter: " + objClicked.name);
        normalColor = objClicked.GetComponent<MeshRenderer>().material.color;

        MeshRenderer mr = objClicked.GetComponent<MeshRenderer>();
        mr.material.color = mouseEnterColor;
    }

    public void mapMouseExit(GameObject objClicked)
    {
        Debug.Log("Pointer Exit: " + objClicked.name);

        MeshRenderer mr = objClicked.GetComponent<MeshRenderer>();
        mr.material.color = normalColor;
    }
}
