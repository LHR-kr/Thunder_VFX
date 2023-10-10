using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thunder : MonoBehaviour
{
  public LayerMask target;

  private void OnTriggerEnter(Collider other) {
    if(other.GetComponent<Rigidbody>() == null) return;
    if((target.value & (1<<other.gameObject.layer))>0)
    {
      other.GetComponent<Enemy>().OnHit();
    }

    
  }

  
}
