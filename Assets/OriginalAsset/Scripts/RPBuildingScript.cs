using Assets.OriginalAsset.Scripts.ScriptaableObject;
using UnityEngine;

namespace Assets.OriginalAsset.Scripts
{
	public class RPBuildingScript : MonoBehaviour
	{
		[SerializeField] private KeyCode deleteKC = KeyCode.T;
		[SerializeField] private KeyCode spawnKC = KeyCode.R;
		[SerializeField] private int Wide = 50;

		private BuildingTypeSO[] buildingPrefabs;

		private void Awake()
		{
			buildingPrefabs = Resources.LoadAll<BuildingTypeSO>("Building");
			GenerateBuilding(buildingPrefabs);
		}

		private void Update()
		{
			if (Input.GetKeyDown(deleteKC))
			{
				while (transform.childCount > 0)
				{
					DestroyImmediate(transform.GetChild(0).gameObject);
				}
			}
			if (Input.GetKeyDown(spawnKC))
			{
				GenerateBuilding(buildingPrefabs);
			}
		}

		private void GenerateBuilding(BuildingTypeSO[] buildingPrefabs)
		{
			foreach (var building in buildingPrefabs)
			{
				Vector3 pos = RandomXandZ();
				Transform bTransform = building.prefab;
				Instantiate(bTransform, pos, Quaternion.identity, transform);
			}
		}

		private Vector3 RandomXandZ()
		{
			int rx;
			int rz;
			rx = Random.Range(-Wide, Wide);
			rz = Random.Range(-Wide, Wide);
			return new Vector3(rx, 0, rz);
		}
	}
}