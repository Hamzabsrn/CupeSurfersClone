using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableCube : MonoBehaviour
{
    bool _isCollect;
    int _index;
    [SerializeField] Picker _picker; 
    public int Ýndex
    {
        get { return _index; }
        set { _index = value; }
    }
    public bool IsCollect => _isCollect;
    // Start is called before the first frame update
    void Start()
    {
        _isCollect = false;
    }
    public void Collect()
    {
        _isCollect = true;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="Obstacle")
        { 
            GetComponent<BoxCollider>().enabled=false;
            other.GetComponent<BoxCollider>().enabled=false;
            _picker.DecreaseHeight();
            transform.parent= null;

        }
    }
}
