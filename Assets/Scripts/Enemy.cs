using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
  private Renderer _renderer;

    private void Start() {
      _renderer = GetComponentInChildren<Renderer>();
    }
    public void OnHit()
    {
        gameObject.GetComponent<Animator>().SetTrigger("Die");
        StartCoroutine(doDissolve());
    }
    IEnumerator doDissolve()
  {
    yield return new WaitForSeconds(0.5f);
    Debug.Log("dissolve");
    while(_renderer.material.GetFloat("_TransparentScale")>=0f)
    {
        _renderer.material.SetFloat("_TransparentScale",_renderer.material.GetFloat("_TransparentScale") - 0.001f);
        yield return null;
    }
  }
}
