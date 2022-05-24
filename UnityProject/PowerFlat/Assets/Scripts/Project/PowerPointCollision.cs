using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PowerFlat
{
    /// <summary>
    /// �R���W�����^�p���[�����_.
    /// </summary>
    /// <remarks>
    /// isTrigger��On�̃R���W����������GameObect�ɂ��Ďg�p.
    /// �w�肳�ꂽkey�������ƁA�R���W�������d�Ȃ������̂ɑ΂��ė͂�^����.
    /// </remarks>>
    public class PowerPointCollision : MonoBehaviour
    {
        [SerializeField] private KeyCode key;
        [SerializeField] private Vector3 powerAngle;

        private bool requireAddForce = false;

        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            if(Input.GetKeyDown(key))
            {
                requireAddForce = true;
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log($"{other.gameObject.name}");
        }
    }
}
