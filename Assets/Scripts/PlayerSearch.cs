using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerSearch : MonoBehaviour
{
    PlayerInputAction _playerInputs = default;

    // Start is called before the first frame update
    void Start()
    {
        _playerInputs = new PlayerInputAction();
        //Action�C�x���g��o�^�E�L��������
        _playerInputs.Player.Search.performed += OnSearch;
        _playerInputs.Enable();
    }

    private void OnSearch(InputAction.CallbackContext context)
    {
        Debug.Log("���ׂ�");
    }
}
