using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.EventSystems;

public class ButtonTextShift : MonoBehaviour
{
    [SerializeField, Header("�Ώۂ̃{�^��")]
    private ButtonTextShift _button;

    [SerializeField, Header("�Ώۂ̃{�^���e�L�X�g")]
    private TextMeshProUGUI _buttonText;

    [Header("pading�̒l")]
    [SerializeField,Header("�����O�e�L�X�g�ʒu"),Tooltip("����FLeft,Top.Right,Bottom")]
    private Vector4 _beforePadding =  new Vector4(0, -4, 0, 4);

    [SerializeField,Header("�������e�L�X�g�ʒu"),Tooltip("����FLeft,Top.Right,Bottom")]
    private Vector4 _afterPadding = new Vector4(0, 2, 0, -2);


    // Start is called before the first frame update
    void Start()
    {
        //�������
        _buttonText.margin = _beforePadding;

        //�{�^���ɃC�x���g��ǉ�
        EventTrigger trigger = _button.gameObject.AddComponent<EventTrigger>();

        //PointerDown�C�x���g��ǉ�
        var downEntry = new EventTrigger.Entry { eventID = EventTriggerType.PointerDown };
        downEntry.callback.AddListener((data) =>//�����ݒ�@�N���b�N�����u�Ԃɉ�������padding�ɕύX
        {
            _buttonText.margin = _afterPadding;
        });
        trigger.triggers.Add(downEntry);//Button��EventTrigger��ǉ�
        

        //PointerUp�C�x���g��ǉ�
        var upEntry = new EventTrigger.Entry { eventID = EventTriggerType.PointerUp };
        upEntry.callback.AddListener((date)=>//�����ݒ�@�N���b�N�����u�Ԃɉ����O��padding�ɕύX
        {
            _buttonText.margin = _beforePadding;
        });
        trigger.triggers.Add(upEntry);//Button��EventTrigger��ǉ�

    }
}
