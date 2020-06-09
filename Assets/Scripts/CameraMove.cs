
using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

	public float moveSpeed;
	public GameObject mainCamera;
    public GameObject Chara;

	// Use this for initialization
	void Start () {
		mainCamera.transform.localPosition = new Vector3 ( 0, 0, -2);
		mainCamera.transform.localRotation = Quaternion.Euler (25, 180, 0);
        Chara.transform.localPosition = new Vector3(0, -2, -7);
        Chara.transform.localRotation = Quaternion.Euler(0, 180, 0);

    }
	
	// Update is called once per frame
	void Update () {

		
	}

	void FixedUpdate()
	{
		MoveObj ();
		
		if (Input.GetKeyDown (KeyCode.A)) {
			ChangeView01();
		}
		
		if (Input.GetKeyDown (KeyCode.S)) {
			ChangeView02();
		}
	}
	
	
	void MoveObj() {		
		float moveAmount = Time.smoothDeltaTime * moveSpeed;
		transform.Translate ( 0f, 0f, moveAmount );	
	}



	void ChangeView01() {
		transform.position = new Vector3 (0, 2, 10);
		// x:0, y:1, z:52
		mainCamera.transform.localPosition = new Vector3 ( -8, -2, 5);
		mainCamera.transform.localRotation = Quaternion.Euler (14, -90, 0);
        Chara.transform.localPosition = new Vector3(-8, 0, 0);
        Chara.transform.localRotation = Quaternion.Euler(0, 90, 0);
    }

	void ChangeView02() {
		transform.position = new Vector3 (0, 2, 10);
		// x:0, y:1, z:52
		mainCamera.transform.localPosition = new Vector3 ( 0, -3, 5 );
		mainCamera.transform.localRotation = Quaternion.Euler ( 19, 180, 0 );
        Chara.transform.localPosition = new Vector3(0, -3, 0);
        Chara.transform.localRotation = Quaternion.Euler(0, 180, 0);
        moveSpeed = -1f;
		
	}
}























