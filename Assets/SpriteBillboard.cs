using UnityEngine;

public class SpriteBillboard : MonoBehaviour
{
    [SerializeField]
    public bool freezeXZ = true;
    // Update is called once per frame
    void LateUpdate()
    {
        if (freezeXZ)   
        {
            transform.rotation = Quaternion.Euler(0f, Camera.main.transform.eulerAngles.y, 0f); 
        } else
        {
            transform.rotation = Camera.main.transform.rotation;
        }
    }
}
