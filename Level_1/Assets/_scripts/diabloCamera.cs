using UnityEngine;
using System.Collections;

public class diabloCamera : MonoBehaviour {

    public GameObject target;
    public float yOffset;
    private float temp;
    Vector3 offset;
    Vector3 camOffset;
	// Use this for initialization
	void Start () {
        offset = target.transform.position - transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {

        temp = target.transform.position.y;
        camOffset = new Vector3(target.transform.position.x, temp, target.transform.position.z);
        float wantAngle = target.transform.eulerAngles.y;
        Quaternion rotation = Quaternion.Euler(0, wantAngle, 0);
        transform.position = target.transform.position - (rotation * offset);
        transform.LookAt(transform.position);
	}
}
