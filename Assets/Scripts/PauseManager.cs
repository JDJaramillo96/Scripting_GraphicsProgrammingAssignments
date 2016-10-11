using UnityEngine;
using System.Collections;

public class PauseManager : MonoBehaviour {

    //Singleton

    private static PauseManager instance;
    public static PauseManager Instance
    {
        get
        {
            return instance;
        }
    }

    //Properties

    [HideInInspector]
    public bool isPause;

    [SerializeField]
    private GameObject menu;
    [SerializeField]
    private GameObject player;

    //Unity functions

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    void Start()
    {
        isPause = true;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) || Input.GetKeyDown(KeyCode.Escape))
        {
            isPause = !isPause;
        }

        if (isPause)
        {
            Cursor.visible = true;

            menu.SetActive(true);
            player.SetActive(false);
        }
        else
        {
            Cursor.visible = false;

            menu.SetActive(false);
            player.SetActive(true);
        }
    }
}