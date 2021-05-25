using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
[RequireComponent(typeof(MeshCollider))]
public class HighlightHat : MonoBehaviour
{
    // private Material _currentMaterial;
    private MeshRenderer _meshRenderer;

    // [SerializeField]
    // public MeshRenderer highlightRenderer;
    // public bool isH = false;

    void Start()
    {
        _meshRenderer = GetComponent<MeshRenderer>();
        // _currentMaterial = _meshRenderer.material;
        // if (highlightRenderer)
        // {
        //     highlightMaterial = Instantiate(highlightMaterial);
        // }

        ToggleHighlight(false);
        // highlightMaterial.SetTexture("_texture", _currentMaterial.mainTexture);
    }

    private void ToggleHighlight(bool isOn)
    {
        // _meshRenderer.material = isOn && highlightMaterial ? highlightMaterial : _currentMaterial;
        // print(highlightMaterial.name);
        // gameObject.SetActive(isH ? isOn : !isOn);
        _meshRenderer.enabled = !isOn;

    }

    private void OnMouseEnter()
    {
        ToggleHighlight(true);
    }

    private void OnMouseExit()
    {
        ToggleHighlight(false);
    }
}