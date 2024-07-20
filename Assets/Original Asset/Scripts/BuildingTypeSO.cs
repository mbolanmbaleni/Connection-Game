using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/BuildingType")]
public class BuildingTypeSO : ScriptableObject
{
    public string name;
    public Transform prefab;
    public bool isGeneratedResource;
    public Sprite sprite;
    public float minConstructionRadius;
}
