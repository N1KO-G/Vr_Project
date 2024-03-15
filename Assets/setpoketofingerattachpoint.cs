using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class setpoketofingerattachpoint : MonoBehaviour
{

    public Transform pokeAttachPoint;

    private XRPokeInteractor _xrPokeInteractor;
    // Start is called before the first frame update
    void Start()
    {
        _xrPokeInteractor = transform.parent.parent.GetComponentInChildren<XRPokeInteractor>();
        SetPokeAttachPoint();
    }

    // Update is called once per frame
    void SetPokeAttachPoint()
    {
        if(pokeAttachPoint == null) {Debug.Log("Poke Attach Point is null"); return;}

        if(_xrPokeInteractor == null) {Debug.Log("XR Poke Interactor is null"); return;}

        _xrPokeInteractor.attachTransform = pokeAttachPoint;
    }
}
