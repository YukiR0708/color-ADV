using UnityEngine;
using UnityEngine.InputSystem;

/// <summary> Player�̈ړ�����������X�N���v�g 
///           �J�����̑O�������Player�̐��ʂƂ��ړ�����</summary>
public class PlayerMove : MonoBehaviour
{
    [SerializeField, Tooltip("Player�̈ړ����x")] float _speed = default;

    Rigidbody _rb = default;
    PlayerInputAction _playerInputs = default;
    Vector2 _inputValue = default;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _playerInputs = new PlayerInputAction();
        //Action�C�x���g��o�^�E�L��������
        _playerInputs.Player.Move.started += OnMove;
        _playerInputs.Player.Move.performed += OnMove;
        _playerInputs.Player.Move.canceled += OnMove;
        _playerInputs.Enable();
    }

    //Move�Ɏw�肵�����͂��󂯎��
    private void OnMove(InputAction.CallbackContext context)
    {
        _inputValue = context.ReadValue<Vector2>();
    }

    private void Update()
    {
        //�J�����̃��[�J���x�N�g�������[���h�x�N�g���֕ϊ�
        Vector3 pForward = Camera.main.transform.TransformDirection(Vector3.forward);   
        Vector3 pRight = Camera.main.transform.TransformDirection(Vector3.right);
        Vector3 pDir = (_inputValue.x * pRight + _inputValue.y * pForward) * _speed * Time.deltaTime;
        pDir.y = 0; //y�����͖�������
        _rb.AddForce(pDir); //�ړ�����
    }
}
