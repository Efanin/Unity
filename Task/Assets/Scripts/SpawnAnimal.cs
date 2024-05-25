using UnityEngine;

public class SpawnAnimal : MonoBehaviour
{
    public void Spawn(int x, int y)
    {
        Vector3 startPostion = new(Random.Range(-x / 2, x / 2), 0, Random.Range(-y / 2, y / 2));
        Instantiate(this, startPostion, Quaternion.identity);
    }
}
