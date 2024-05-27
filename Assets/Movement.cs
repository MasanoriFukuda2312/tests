using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f; // �v���C���[�̈ړ����x

    void Update()
    {
        Vector2 movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized; // ���͂��ꂽ�����𐳋K�����Ĉړ��x�N�g�����쐬
        Move(movement); // �v���C���[���ړ�������
    }

    private void Move(Vector2 direction)
    {
        transform.Translate(direction * moveSpeed * Time.deltaTime); // �����ɉ����ăv���C���[���ړ�������
    }
}