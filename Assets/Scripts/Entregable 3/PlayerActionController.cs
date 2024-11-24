using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActionController : MonoBehaviour
{
   
    public GameObject spellPrefab;
    public float spellSpeed = 60f;
    private Rigidbody spellRigidBody;


    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonUp(0))
        {
            GameObject spellTemp = Instantiate(spellPrefab, transform.position, Quaternion.identity);
            spellRigidBody = spellTemp.GetComponent<Rigidbody>();
            spellRigidBody.velocity = transform.forward * spellSpeed;
            Destroy(spellTemp, 5f);
        }
    }
}
