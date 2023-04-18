using UnityEngine;
using UnityEngine.InputSystem;

/// <summary> Playerの移動を実現するスクリプト 
///           カメラの前方を常にPlayerの正面とし移動する</summary>
public class PlayerMove : MonoBehaviour
{
    [SerializeField, Tooltip("Playerの移動速度")] float _speed = default;

    Rigidbody _rb = default;
    PlayerInputAction _playerInputs = default;
    Vector2 _inputValue = default;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _playerInputs = new PlayerInputAction();
        //Actionイベントを登録・有効化する
        _playerInputs.Player.Move.started += OnMove;
        _playerInputs.Player.Move.performed += OnMove;
        _playerInputs.Player.Move.canceled += OnMove;
        _playerInputs.Enable();
    }

    //Moveに指定した入力を受け取る
    private void OnMove(InputAction.CallbackContext context)
    {
        _inputValue = context.ReadValue<Vector2>();
    }

    private void Update()
    {
        //カメラのローカルベクトルをワールドベクトルへ変換
        Vector3 pForward = Camera.main.transform.TransformDirection(Vector3.forward);   
        Vector3 pRight = Camera.main.transform.TransformDirection(Vector3.right);
        Vector3 pDir = (_inputValue.x * pRight + _inputValue.y * pForward) * _speed * Time.deltaTime;
        pDir.y = 0; //y方向は無視する
        _rb.AddForce(pDir); //移動する
    }
}
