using UnityEngine;
using System.Collections;

public class BaseCharacter : MonoBehaviour {

    private float f_baseLives;
    private float f_baseMana;
    private float f_baseMovementSpeed;


	// Use this for initialization
	void Start () {
        f_baseLives = 100f;
        f_baseMana = 100f;
        f_baseMovementSpeed = 5f;
	}

    // Getters & Setters
    public float BaseLives {
        get { return f_baseLives; }
    }

    public float BaseMana {
        get { return f_baseMana; }
    }

    public float BaseMovementSpeed {
        get { return f_baseMovementSpeed; }
    }
}
