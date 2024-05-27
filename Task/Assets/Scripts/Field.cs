using UnityEngine;

public class Field : MonoBehaviour
{
    public void SetField(int startSize) =>
        this.transform.localScale = new Vector3(startSize, startSize, startSize);
}
