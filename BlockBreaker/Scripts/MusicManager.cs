using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{

    public static MusicManager instance = null;

    void Awake()
    {
        //Singleton
        if (instance == null)
        {             //if instance is not assigned
            instance = this;                //then assign instance to this object
        }
        else if (instance != this)
        {
            Destroy(this.gameObject);       //then destroy this object
        }

        DontDestroyOnLoad(this.gameObject);
    }

}
