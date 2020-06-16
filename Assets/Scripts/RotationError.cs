using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace InformationLoss
{
    public class RotationError : MonoBehaviour
    {
        [SerializeField]
        private float rotation_deg = 16776000.0f;  // Memo: 1.677722e+07 Stop
        [SerializeField]
        private float speed_deg = 50.0f;

        void Start()
        {
            Debug.Log("Max float :" + float.MaxValue);
        }

        void Update()
        {
            rotation_deg += speed_deg * Time.deltaTime;
            transform.rotation = Quaternion.Euler(0f, rotation_deg, 0f);
        }
    }
}
