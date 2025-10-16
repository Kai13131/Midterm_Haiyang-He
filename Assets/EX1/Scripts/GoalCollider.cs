using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GoalCollider : MonoBehaviour {
    [SerializeField] GameObject winText;
    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.tag == "Ball") {
            winText.SetActive(true);
        }
    }
}