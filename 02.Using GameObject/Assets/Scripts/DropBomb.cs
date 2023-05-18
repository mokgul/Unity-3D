using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropBomb : MonoBehaviour
{
    public GameObject bomb;
    // Start is called before the first frame update
    void Start()
    {
        bomb.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        var pressed = Input.GetKeyDown(KeyCode.Space);
        if (pressed)
        {
            
            GameObject clone = Instantiate(bomb,this.transform.position,this.transform.rotation);
            clone.SetActive(true);
            Destroy(clone, 5);
        }
            
    }
}
