using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    [SerializeField]
    private string name;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
