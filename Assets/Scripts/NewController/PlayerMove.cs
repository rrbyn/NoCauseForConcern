using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _speed;

    private CharacterController _player;
    private Vector3 _moveDir;
    private float gravity;
    private void Awake() => _player = GetComponent<CharacterController>();
    

    public void Move() 
    {
        _moveDir = ((transform.right * Input.GetAxis("Horizontal")) + (transform.forward * Input.GetAxis("Vertical"))) * _speed;
        _player.Move(new Vector3((_moveDir * Time.deltaTime).x, -1, (_moveDir * Time.deltaTime).z));
    }
}