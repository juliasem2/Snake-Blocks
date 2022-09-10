using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Collision : MonoBehaviour
{
    //public TextMeshProUGUI PriceEnter;
    public Transform HeadSnake;
    public GameObject Block;
    private void OnCollisionEnter(UnityEngine.Collision collision) //������������ �� ������
    {
        Debug.Log("������������");
        int _s = this.GetComponent<ChangeText>()._numberLife; //������� ���������� � ���������� � ��� "�������" ����� �� ������ �� �������� �����
        List<Transform> _tailList = HeadSnake.GetComponent<Snake>()._tails;// �������� ������ ������ (������)
        int _countTails = _tailList.Count;// ������� ����� ������ ��� ��������� �� � "��������" �����

        for (int i = 0; i <= _countTails+2; i++) //������� ���� ��� ��������� "�������" ����� � ���������� ������  
        {
            Debug.Log("����� ������: " + _countTails+"i="+i);
            if (_s == 0 && _countTails >= 0) //���� "�������" ����� = 0, � ����� ��� ��������, ��:
            {
                Debug.Log("#1");
                Destroy(this.gameObject);
                Destroy(Block.gameObject);
                break; //������� �� �����
                
            }
            else if (_s > 0 && _countTails == 0) // ���� "�������" �����  ������ 0, � ������ �� ��������, ��:
            {
                Debug.Log("#2");
                Destroy(collision.gameObject);
                this.GetComponent<TextMeshPro>().text = (_s-1).ToString();//����� �� ����� ����� �����
                Debug.Log("GAME OVER!!!"); //���� ����� ������
            }
            else // � ���� �������:
            {
                Debug.Log("#3");
                _s -=1; // �������� 1 �� ������� �����
                this.GetComponent<TextMeshPro>().text = _s.ToString();//����� �� ����� ����� �����
                _countTails -= 1; //�������� 1 �� ���������� ������
                Destroy(_tailList[_tailList.Count-1].gameObject); // ���������� ��������� ������� ������
                _tailList.Remove(_tailList[_tailList.Count -1]); // ������� ��������� ������� �� ������ ��������� ������

            }

        }

    }
}
