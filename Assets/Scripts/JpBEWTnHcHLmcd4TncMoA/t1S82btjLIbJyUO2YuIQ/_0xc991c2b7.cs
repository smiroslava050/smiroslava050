using UnityEngine;

public class _0xc991c2b7 : MonoBehaviour
{
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0xc991c2b7>();
            DontDestroyOnLoad(this.gameObject);
            this._0x6de47e66();
        }
        else
        {
            this._0x1fa3b6e6();
            Destroy(this.gameObject);
        }
    }

    public bool IsTimerEnabled;
    public bool IsOnlyWinGameEndEnabled;
    public static _0xc991c2b7 Instance;
    public bool IsCheckScoreEnabled;
    private void _0x6de47e66()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    public bool IsTutorialEnabled;
    public bool IsSkipSplashEnabled;
    public bool IsLevelSelectorEnabled;
    public bool IsBestScoreEnabled;
    public bool IsLevelIncrementOnWin;
    private void _0x1fa3b6e6()
    {
    }

    public bool IsStoryEnabled;
}