using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PowerFlat
{
    /// <summary>
    /// �͂𔭐����镽�ʃN���X
    /// </summary>
    /// <remarks>
    /// PowerFlat�͕�����PowerPoint�ō\�������.
    /// �������܂Ƃߏグ��̂����̃N���X.
    /// Point���ʂ̐ݒ���s��,Group�I�ȑ�����s��.
    /// </remarks>
    public class PowerFlat : MonoBehaviour
    {
        [SerializeField] private PowerPointCollision pointCollision;

        private bool active = true;

        public void SetActive(bool active)
        {
            this.active = active;
        }
    }
}
