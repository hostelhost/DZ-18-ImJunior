using UnityEngine;

public class MoverEnemy : MonoBehaviour
{
    [SerializeField] private Point[] Targets;
    [SerializeField] private float _speed = 2f;

    private Vector3 _target;
    private int _countTarget;

    private void Awake()
    {
        _countTarget = Targets.Length-1;
    }

    private void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, _target, _speed * Time.deltaTime);

        if (Vector2.SqrMagnitude(transform.position - _target) == 0 * 0)
            _target = NextTarget();       
    }

    private Vector3 NextTarget()
    {
        _countTarget = ++_countTarget % Targets.Length;

        return Targets[_countTarget].transform.position;      
    }
}
