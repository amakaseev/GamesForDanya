using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishController : MonoBehaviour {

  public Transform _fish;
  public float _speed = 10.0f;
  public float _rotationSpeed = 100.0f;

  // Start is called before the first frame update
  void Start() {

  }

  // Update is called once per frame
  void Update() {
    float translation = Input.GetAxis("Vertical") * _speed;
    float rotation = Input.GetAxis("Horizontal") * _rotationSpeed;

    // Make it move 10 meters per second instead of 10 meters per frame...
    translation *= Time.deltaTime;
    rotation *= Time.deltaTime;

    // Move translation along the object's z-axis
    // var position = _fish.position;
    // position.x += translation;
    // _fish.position = position;
    _fish.Translate(translation, 0, 0);

    // Rotate around our y-axis
    _fish.Rotate(0, rotation, 0);
  }
}
