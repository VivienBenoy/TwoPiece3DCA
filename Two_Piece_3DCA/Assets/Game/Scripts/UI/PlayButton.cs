using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayButton : MonoBehaviour
{
    public GameObject canvas;

    // reference to the game object that you want to show
    public GameObject gameObjectToShow;

    // reference to the button component
    private Button playButton;

    private void Start()
    {
        // get the button component
        playButton = GetComponent<Button>();

        // add a listener to call the OnClick method when the button is clicked
        playButton.onClick.AddListener(OnClick);
    }

    // this method will be called when the button is clicked
    public void OnClick()
    {
        // hide the canvas
        canvas.SetActive(false);

        // show the game object
        gameObjectToShow.SetActive(true);
    }
}
