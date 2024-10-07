using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MoverPlayer : MonoBehaviour
{
    private const string Horizontal = "Horizontal";
    private const string Vertical = "Vertical";

    private float _inputHorizontal;
    private float _inputVertical;

    private void Update()
    {
        _inputHorizontal = Input.GetAxis(Horizontal);
        _inputVertical = Input.GetAxis(Vertical);

        transform.Translate(_inputHorizontal * Time.deltaTime, _inputVertical * Time.deltaTime, 0, Space.World);
    }
}
