using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x9ff42d58 : MonoBehaviour
{
    public float FirstAnimationTime = 10.0f;
    public GameObject Background;
    public void _0xad7c50b1()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this.AnimSliderSequence?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0xdd88d6ba = false;
    }

    public void _0xb178dc13()
    {
        this._0xabe0e2ea();
        bool _0xa9b06f1f = _0xdd88d6ba;
        this.AnimSliderSequence = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x5f3ab46e => this.AnimationSlider.value = _0x5f3ab46e, _0xa9b06f1f ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0xdd88d6ba = !_0xdd88d6ba;
    }

    public Sequence AnimSliderSequence;
    public void _0xabe0e2ea()
    {
        this.AnimSliderSequence?.Kill();
        this.AnimationSlider.value = _0xdd88d6ba ? this.SecondPassSliderValue : 0.05f;
    }

    private static bool _0xdd88d6ba = false;
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0x47a641fc._0xb2d9c6f9.SCENE_0 && !_0xdd88d6ba)
        {
            this._0xf8328fe7();
        }
        else
        {
            this._0xb178dc13();
        }
    }

    private void _0xf8328fe7()
    {
        this.AnimationSlider.value = 0.05f;
        _0xdd88d6ba = !_0xdd88d6ba;
        this.AnimSliderSequence = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0x5f3ab46e => this.AnimationSlider.value = _0x5f3ab46e, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            if (!_0x3858c973._0x318df0ea._0xf67969c4)
            {
                {
#if B_LOGS
                    {
                        Debug.Log($"[Test] Timer out -> move to scene");
                    }
#endif
                }

                _0x3858c973._0x318df0ea._0x1b48520f();
            }
        });
    }

    public static _0x9ff42d58 Instance;
    public Slider AnimationSlider;
    public GameObject Error;
    public GameObject Content;
    public float DefaultAnimationTime = 0.4f;
    public float SecondPassSliderValue = 0.5f;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x9ff42d58>();
    }
}