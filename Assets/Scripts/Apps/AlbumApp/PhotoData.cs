using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary> �e�ʐ^���������W�̃f�[�^ </summary>
[CreateAssetMenu(menuName = "Scriptable/Create PhotoData")]
public class PhotoData : ScriptableObject

{
    [SerializeField, Tooltip("�Ώۂ̏ꏊ��XZ���ʍ��W")]private Vector2 _location = default;
    [SerializeField, Multiline,Tooltip("TimeLine�ŕ\���e�L�X�g")] private string _scenario = default;
    
    public Vector2 Location => _location;
    public string Scenario => _scenario;
}
