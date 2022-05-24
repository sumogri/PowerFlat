using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PowerFlat
{
    /// <summary>
    /// 力を発生する平面クラス
    /// </summary>
    /// <remarks>
    /// PowerFlatは複数のPowerPointで構成される.
    /// それらをまとめ上げるのがこのクラス.
    /// Point共通の設定を行う,Group的な操作を行う.
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
