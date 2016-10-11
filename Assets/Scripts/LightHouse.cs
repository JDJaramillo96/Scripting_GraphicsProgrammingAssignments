using UnityEngine;
using System.Collections;

public class LightHouse : MonoBehaviour {

    //Properties

    [SerializeField]
    private float velocity;

    //Unity functions

    void Update ()
    {
        transform.Rotate(Vector3.right * velocity * Time.deltaTime);
	}
}