using UnityEngine;


//�J�����̉�]�ɍ��킹��Player����]������N���X
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
        //�J�����̉�]���擾����Bx��,z���͖�������B
        _pRot = Camera.main.transform.rotation;
        _pRot.x = 0;
        _pRot.z = 0;
        transform.rotation = Quaternion.Slerp(transform.rotation, _pRot, 1.0f); // �J�����̐��ʂ�����
    }
}
