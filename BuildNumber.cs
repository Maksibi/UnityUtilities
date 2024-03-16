using System;
using System.Linq;
using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;

namespace CodeBase.Editor
{
    public class BuildNumber : IPreprocessBuildWithReport
    {
        public int callbackOrder { get; }

        public void OnPreprocessBuild(BuildReport report)
        {
            UpdateVersion();
        }

        [MenuItem("Custom/UpdateVersion")]
        public static void UpdateVersion()
        {
            DateTime thisDay = DateTime.Today;
            int buildNumber = (int.Parse(PlayerSettings.bundleVersion.Split('.').Last())) + 1;

            PlayerSettings.bundleVersion =
                thisDay.Day + "." + thisDay.Month + "." + buildNumber;
        }
    }
}