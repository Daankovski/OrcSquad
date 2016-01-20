using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    private BaseCharacter bc;

    private bool isFacingRight = true;
    private bool canJump = false;

    private float f_Health;
    private float f_Mana;
    private float f_MovementSpeed;

	
	void Start () {
        bc = GetComponent<BaseCharacter>();
	}
	
	
	void Update () {
	
	}
}
