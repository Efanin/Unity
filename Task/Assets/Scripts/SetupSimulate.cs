using UnityEngine;

public class SetupSimulate : MonoBehaviour
{
    [SerializeField] private GameObject animal;
    [SerializeField] private GameObject field;
    [SerializeField, Range(2, 1000)] private int startSize;
    [SerializeField, Range(1, 100)] private int speedAnimal;

    private void Start()
    {
        animal.GetComponent<Animal>().Speed = speedAnimal;
        field.GetComponent<Field>().SetField(startSize);
        for (int i = 0; i < 12; i++)
        animal.GetComponent<Animal>().SpawnAnimal(startSize);

    }
}
