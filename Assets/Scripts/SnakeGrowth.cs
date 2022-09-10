using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeGrowth : MonoBehaviour
{
    public GameObject —oinObject;
    public GameObject SnakeBodyPrefab;
    public Transform HeadSnake;
    [SerializeField] private float _dictance;
 

    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        List<Transform> _tailList = HeadSnake.GetComponent<Snake>()._tails;
        
        if (!collision.collider.TryGetComponent(out TextCoin _coinText)) return;
        Debug.Log("ÃÓÌÂÚÍ‡!");
        int _numberNewObjects = _coinText.GetComponent<ChangeText>()._numberLife;

        for (int i = 0; i < _numberNewObjects; i++) 
        { 
            GameObject body = Instantiate(SnakeBodyPrefab);
            body.transform.position = new Vector3(_tailList[_tailList.Count-1].position.x, _tailList[_tailList.Count - 1].position.y, _tailList[_tailList.Count - 1].position.z-1);
            _tailList.Add(body.transform);            
        }
        Destroy(_coinText.gameObject);
        Destroy(—oinObject.gameObject);
    }   
}
