using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Error

public class Destroy : MonoBehaviour
{
    public Color mouseHoverColor = Color.red;
    private Color previousColor;
    private MeshRenderer meshRenderer;
    private bool Remove; 

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        previousColor = meshRenderer.material.color;
    }

    // Update is called once per frame
    void Update ()
        {
            if(Input.GetKeyDown(KeyCode.Backspace)) // Makes the backspace as a ON/OFF switch to remove an object
            {
                Remove = !Remove;
            }
        }

    private void OnMouseDown()
        {
        if(Remove == true)
            {
            Destroy(gameObject); // Deletes the Object if mouse pointer is on it
            }
        }

    private void OnMouseOver()
        {
        if(Remove == true)
            {
            meshRenderer.material.color = mouseHoverColor; // turns the object red
            }
        else
            {
            meshRenderer.material.color = previousColor; // If backspace is off then the color of the object goes normal
            }
        }

    private void OnMouseExit()
        {
        meshRenderer.material.color = previousColor; //The color of the object goes normal if mouse pointer isn't on the object
        }

    public void DeleteMode()
        { //How to put the all the codes inside this void
            GameObject Button = GameObject.Find("Delete Mode Button"); //Error
            Button.onClick.AddListener(() => { Button.GetComponent<Image>().color = Color.red; }); //Error
        }
}
