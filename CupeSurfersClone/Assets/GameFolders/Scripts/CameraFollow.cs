using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject _targetObject;
    [SerializeField] private Vector3 _offset;
    void Start()
    {
        
    }
    private void LateUpdate()
    {
        this.transform.position =Vector3.Lerp(this.transform.position, _targetObject.transform.position+_offset, Time.deltaTime);
    }

    // Update is called once per frame


}
