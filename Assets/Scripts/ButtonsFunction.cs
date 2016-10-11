using UnityEngine;
using System.Collections;

public class ButtonsFunction : MonoBehaviour {

    //Buttons functions

    public void Play()
    {
        PauseManager.Instance.isPause = false;
    }

    public void Exit()
    {
        Application.Quit();
    }
}