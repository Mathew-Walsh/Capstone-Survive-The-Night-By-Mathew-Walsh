using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Health : MonoBehaviour {

    public TextMeshProUGUI healthText;

	// Use this for initialization
	void Start () {

        healthText = GetComponentInChildren<TextMeshProUGUI>();

    }
}
