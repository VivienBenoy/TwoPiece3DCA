using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitButton : MonoBehaviour
{

    public GameObject canvas;

    // reference to the game object that you want to show
    public GameObject gameObjectToShow;

    // reference to the button component
    private Button quitButton;

    private void Start()
    {
        // get the button component
        quitButton = GetComponent<Button>();

        // add a listener to call the OnClick method when the button is clicked
        quitButton.onClick.AddListener(OnClick);
    }

    // this method will be called when the button is clicked
    public void OnClick()
    {
        // hide the canvas
        canvas.SetActive(false);

        // show the game object
        gameObjectToShow.SetActive(false);
    }
}
