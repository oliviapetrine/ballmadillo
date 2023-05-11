using UnityEngine;

public class ApplyMaterialToChildren : MonoBehaviour
{
    public Material materialToApply;

    void Start()
    {
        MeshRenderer[] childRenderers = GetComponentsInChildren<MeshRenderer>();
        foreach (MeshRenderer renderer in childRenderers)
        {
            renderer.material = materialToApply;
        }
    }
}
