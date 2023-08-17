using UnityEngine;
using UnityEngine.InputSystem;

public class KeyManager : MonoBehaviour
{
    [SerializeField]
    private InputActionReference pause;

    [SerializeField]
    private GameObject keyPanel,padPanel;

    [SerializeField] 
    private RebindSaveManager rsm;

    private bool openFlg = false;

    private void Awake()
    {
        //�L�[�R���ǂݍ���
        rsm.Load();

        ClosePanel();

        //�L�[�̗L����
        pause.action.Enable();
    }

    void Update()
    {
        //pause�L�[�������ꂽ��
        if (pause.action.triggered)
        {
            if (openFlg == false) KeyBoardPanel();
            else ClosePanel();
        }
    }

    public void KeyBoardPanel()
    {
        keyPanel.SetActive(true);
        padPanel.SetActive(false);
        openFlg = true;
    }

    public void GamePadPanel()
    {
        padPanel.SetActive(true);
        keyPanel.SetActive(false);
        openFlg = true;
    }

    public void ClosePanel()
    {
        padPanel.SetActive(false);
        keyPanel.SetActive(false);
        openFlg = false;
    }
}
