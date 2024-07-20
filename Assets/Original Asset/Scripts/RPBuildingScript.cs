using UnityEngine;

public class RPBuildingScript : MonoBehaviour
{
	[SerializeField] private int Wide = 50;
	private void Awake()
	{
		GameObject[] buildingPrefabs = Resources.LoadAll<GameObject>("LoadablePrefab");

		foreach (var building in buildingPrefabs)
		{
			int rx = Random.Range(-Wide, Wide);
			int rz = Random.Range(-Wide, Wide);
			Vector3 pos = new Vector3(rx, 0, rz);
			Instantiate(building, pos, Quaternion.identity);
		}
	}
}