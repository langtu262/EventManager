using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float horizontalSpeed = 100f;
    [SerializeField] float verticalSpeed = 10f;
    private Animator _anim;
    // Start is called before the first frame update
    void Start()
    {
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = horizontalSpeed * Input.GetAxis("Horizontal");
        float v = verticalSpeed * Input.GetAxis("Vertical");
        transform.Translate(0, 0, v * Time.deltaTime );
        transform.Rotate(0, h * Time.deltaTime, 0);
        _anim.SetFloat("isRun", Mathf.Abs(v));
    }
}
