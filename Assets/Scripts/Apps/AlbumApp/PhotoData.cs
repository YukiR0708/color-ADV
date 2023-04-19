using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary> 各写真が示す座標のデータ </summary>
[CreateAssetMenu(menuName = "Scriptable/Create PhotoData")]
public class PhotoData : ScriptableObject

{
    [SerializeField, Tooltip("対象の場所のXZ平面座標")]private Vector2 _location = default;
    [SerializeField, Multiline,Tooltip("TimeLineで表示テキスト")] private string _scenario = default;
    
    public Vector2 Location => _location;
    public string Scenario => _scenario;
}
