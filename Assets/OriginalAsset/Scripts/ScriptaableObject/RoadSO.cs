using UnityEngine;
namespace Assets.OriginalAsset.Scripts.ScriptaableObject
{
	[CreateAssetMenu(menuName = "ScriptableObjects/RoadType")]
	internal class RoadSO : ScriptableObject 
	{
		public string nameString;
		public Transform prefab;
		public bool isGeneratedResource;
		public Sprite sprite;
		public float minConstructionRadius;
	}
}