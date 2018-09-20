using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Debugg
{
    public static void Log(string message)
    {
#if DEVELOPMENT_BUILD || UNITY_EDITOR
        UnityEngine.Debug.Log(message);
#endif
    }
    public static void Log(object message)
    {
#if DEVELOPMENT_BUILD || UNITY_EDITOR
        UnityEngine.Debug.Log(message);
#endif
    }
    public static void Log(string message, UnityEngine.Object context)
    {
#if DEVELOPMENT_BUILD || UNITY_EDITOR
        UnityEngine.Debug.Log(message, context);
#endif
    }
    public static void LogWarning(string message)
    {
#if DEVELOPMENT_BUILD || UNITY_EDITOR
        UnityEngine.Debug.LogWarning(message);
#endif
    }
    public static void LogWarning(string message, UnityEngine.Object context)
    {
#if DEVELOPMENT_BUILD || UNITY_EDITOR
        UnityEngine.Debug.LogWarning(message, context);
#endif
    }
    public static void LogError(string message)
    {
#if DEVELOPMENT_BUILD || UNITY_EDITOR
        UnityEngine.Debug.LogError(message);
#endif
    }
    public static void LogError(string message, UnityEngine.Object context)
    {
#if DEVELOPMENT_BUILD || UNITY_EDITOR
        UnityEngine.Debug.LogError(message, context);
#endif
    }

}
