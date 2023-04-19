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
        //Actionイベントを登録・有効化する
        _playerInputs.Player.Search.performed += OnSearch;
        _playerInputs.Enable();
    }

    private void OnSearch(InputAction.CallbackContext context)
    {
        Debug.Log("調べた");
    }
}
