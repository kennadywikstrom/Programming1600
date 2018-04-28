using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{

    public void LoadLevel(string name)
    {
        Debug.Log("New Level load: " + name);
#pragma warning disable CS0618 // Type or member is obsolete
        Application.LoadLevel(name);
#pragma warning restore CS0618 // Type or member is obsolete
    }

    public void QuitRequest()
    {
        Debug.Log("Quit requested");
        Application.Quit();
    }

}
