using UnityEngine;

public class Animal : MonoBehaviour
{
    [SerializeField] private GameObject food;

    private int speed;
    [HideInInspector] public int Speed {
        get { 
            return speed; 
        } 
        set {
            speed = value >= 1 && value <= 100 ? value : 1;
        }
    }

    private int maxTimeSpawn = 5;
    private int sizeField;

    private void spawnFood()
    {
        int timeDistance = maxTimeSpawn * speed;
        Debug.Log(transform.position.x);
        Vector3 position = new(
            Random.Range(
                point((int)transform.position.x, timeDistance, sizeField), 
                point((int)transform.position.x, -timeDistance, -sizeField)),
            0,
            Random.Range(
                point((int)transform.position.z, timeDistance, sizeField),
                point((int)transform.position.z, -timeDistance, -sizeField)));
        Instantiate(food, position, Quaternion.identity);  
    }
    public void SpawnAnimal(int sizeField)
    {
        this.sizeField = sizeField;
        Vector3 position = new(
            Random.Range(-sizeField / 2, sizeField / 2),
            0,
            Random.Range(-sizeField / 2, sizeField / 2));
        Instantiate(this, position, Quaternion.identity);

    }
    private void Start()
    {
        spawnFood();
    }
    private int point(int postion, int timeDistance, int sizeField)
    {
        return Mathf.Abs(postion + timeDistance) > Mathf.Abs(sizeField / 2) ?
            sizeField / 2 :
            postion + timeDistance;
    }
}
