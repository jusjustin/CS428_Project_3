using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duplicate : MonoBehaviour
{
    public GameObject rootObj;
    public Duplicate script;
    private bool x;

    [System.Obsolete]
    // Start is called before the first frame update
    void Start()
    {
        script = rootObj.GetComponent<Duplicate>();
    }

    void Update(){
        if(script.isActiveAndEnabled){
                GameObject duplicate = Instantiate(rootObj);
                duplicate.SetActive(false);
                Destroy(duplicate.GetComponent<Duplicate>());
                duplicate.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
                duplicate.SetActive(true);
                duplicate = null;
             }
    }

    private void Destroy(Func<Duplicate> getComponent)
    {
        throw new NotImplementedException();
    }
}
