using UnityEngine;

//InputSystem���g����悤�ɂ���
using UnityEngine.InputSystem;

public class SampleScript : MonoBehaviour
{
    [SerializeField]
    private InputActionReference jump;

    void Start()
    {
        //�L�[�̗L����
        jump.action.Enable();
    }

    void Update()
    {
        if (jump.action.triggered) Debug.Log("�W�����v�L�[�������ꂽ�I");

        if (jump.action.inProgress) Debug.Log("�W�����v�L�[��������Ă�I");

        if (jump.action.ReadValue<float>() == 0f) Debug.Log("�W�����v�L�[�������ꂽ�I");
    }
}
