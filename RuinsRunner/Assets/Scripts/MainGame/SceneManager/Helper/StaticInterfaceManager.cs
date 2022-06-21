using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StaticInterfaceManager
{
    /// <summary>
    /// ����|���v�����󂯖��߂���
    /// �v���C���[���ڐG����gameObject���Q�Ɠn�����Ďg��
    /// </summary>
    /// <param name="_pillar"></param>
    static public void ToFallOverPillar(ref GameObject _pillar)
    {
        IToFallenOver obj = _pillar.GetComponent(typeof(IToFallenOver)) as IToFallenOver;
        if (obj == null) return;
        obj.CallToFallOver();
    }

    /// <summary>
    /// �U���v�����󂯖��߂���
    /// �U�����鑤���U���Ώۂ�gameObject���Q�Ɠn�����Ďg��
    /// </summary>
    static public void CauseDamage(ref GameObject _object)
    {
        IDamaged obj = _object.GetComponent(typeof(IDamaged)) as IDamaged;
        if (obj == null) return;
        obj.Damaged();
    }

    static public void MoveCamera(Vector3 _destination, GameObject _newTarget = null)
    {
        ICameraMoveTest obj = Camera.main.GetComponent(typeof(ICameraMoveTest)) as ICameraMoveTest;
        if (obj == null) return;
        obj.CallCameraMove(_destination, _newTarget);
    }
}