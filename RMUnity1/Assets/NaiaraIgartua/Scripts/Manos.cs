using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using UnityEngine.XR.Interaction.Toolkit;

public class Manos : MonoBehaviour
{
    [SerializeField] private XRPokeInteractor interactor;

    void OnEnable()
    {
        interactor.hoverEntered.AddListener(OnHoverEntered);
    }

    void OnDisable()
    {
        interactor.hoverEntered.RemoveListener(OnHoverEntered);
    }

    void OnHoverEntered(HoverEnterEventArgs args)
    {
        GameObject obj = args.interactableObject.transform.gameObject;
        if (obj.CompareTag("Cubo"))
        {
            Destroy(obj);
            GameManager.Instance.Contador();
        }
    }
}
