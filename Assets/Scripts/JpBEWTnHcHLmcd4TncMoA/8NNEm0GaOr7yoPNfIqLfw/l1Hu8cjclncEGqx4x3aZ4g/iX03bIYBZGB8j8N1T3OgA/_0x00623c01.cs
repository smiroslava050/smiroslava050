using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x00623c01 : MonoBehaviour
{
    public bool IsLoadCurrentScene;
    public int LoadSceneId;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public Button Button;
    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0x0e5ba754.Instance.LoadSceneByIndex(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0x0e5ba754.Instance.LoadSceneByIndex(this.LoadSceneId));
    }
}