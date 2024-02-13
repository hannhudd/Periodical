using UnityEngine;

public class NewspaperMovement : MonoBehaviour
{
    [SerializeField] GameObject CenterEye;
    void Start()
    {
        
    }
    void LateUpdate()
    {
        Vector3 headsetPos = CenterEye.transform.position;
        this.transform.position = new Vector3(headsetPos.x, headsetPos.y - .4f, headsetPos.z + .25f);
    }
}
