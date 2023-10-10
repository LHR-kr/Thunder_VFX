using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ThunderContoller : MonoBehaviour
{
    // Start is called before the first frame update

    private Coroutine cr = null;
    public GameObject Thunder;
    void Start()
    {
        Thunder.SetActive(false);
    }

    
    public void OnAttack()
    {
        if(cr == null) cr = StartCoroutine(SpawnThunder());

    }

    IEnumerator SpawnThunder()
    {
        Thunder.SetActive(true);
        
        yield return new WaitForSeconds(0.6f);
        Debug.Log(Thunder.GetComponent<CapsuleCollider>() == null);
        Thunder.GetComponent<CapsuleCollider>().enabled  = true;
        yield return new WaitForSeconds(1.0f);
        Thunder.GetComponent<CapsuleCollider>().enabled  = false;
        Thunder.SetActive(false);
        cr =null;
    }
}
