using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

/// <summary>
/// 値を管理・保持
/// </summary>
public class model2 : MonoBehaviour
{
    public  IntReactiveProperty Score = new IntReactiveProperty(0);
}
