using UnityEngine;


//カメラの回転に合わせてPlayerを回転させるクラス
public class PlayerRotate : MonoBehaviour
{
    Quaternion _pRot = default;
    private void Awake()
    {
        _pRot = Camera.main.transform.rotation;
        _pRot.x = 0;
        _pRot.z = 0;
        transform.rotation = _pRot;
    }
    private void Update()
    {
        //カメラの回転を取得する。x軸,z軸は無視する。
        _pRot = Camera.main.transform.rotation;
        _pRot.x = 0;
        _pRot.z = 0;
        transform.rotation = Quaternion.Slerp(transform.rotation, _pRot, 1.0f); // カメラの正面を向く
    }
}
