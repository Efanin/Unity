using UnityEngine;

public class SetupField : MonoBehaviour
{
    [SerializeField] private GameObject field;
    [SerializeField] private int startSize = 1;
    [SerializeField] private GameObject spawnAnimal;

    private void Start()
    {
        field.transform.localScale = new Vector3(startSize, startSize, startSize);
        spawnAnimal.GetComponent<SpawnAnimal>().Spawn(startSize, startSize);
    }
}
