using System;
using UnityEngine;
using UnityEditor;
using VitDeck.Utilities;
using VitDeck.Language;
using VitDeck.Main;
using System.Threading.Tasks;

namespace VitDeck.PerformanceCalculator
{
    /// <summary>
    /// 負荷計算機能のGUI
    /// </summary>
    public class Wizard : ScriptableWizard
    {
        private const string prefix = "VitDeck/";

        [SerializeField]
        private DefaultAsset baseFolder;

        [SerializeField]
        private Calculator.SpaceSize spaceSize;

#if !VITDECK_HIDE_MENUITEM
        [MenuItem(prefix + "Calculate Peformance", priority = 103)]
#endif
        public static void Open()
        {
            DisplayWizard<Wizard>("VitDeck", "Calculate Peformance").LoadSettings();
        }

        protected override bool DrawWizardGUI()
        {
            base.DrawWizardGUI();
            this.isValid = baseFolder;
            return true;
        }

        /// <summary>
        /// VitDeckのユーザー設定を読み込む。
        /// </summary>
        private void LoadSettings()
        {
            var userSettings = UserSettingUtility.GetUserSettings();
            this.baseFolder = AssetDatabase.LoadAssetAtPath<DefaultAsset>(userSettings.validatorFolderPath);
        }

        /// <summary>
        /// VitDeckのユーザー設定を保存する。
        /// </summary>
        private void SaveSettings()
        {
            var userSettings = UserSettingUtility.GetUserSettings();
            userSettings.validatorFolderPath = AssetDatabase.GetAssetPath(this.baseFolder);
            UserSettingUtility.SaveUserSettings(userSettings);
        }

        private void OnWizardCreate()
        {
            this.SaveSettings();

            if (!AssetUtility.OpenScene(this.baseFolder))
            {
                EditorUtility.DisplayDialog("VitDeck", LocalizedMessage.Get("VketTargetFinder.SceneNotFound", AssetUtility.GetScenePath(this.baseFolder)), "OK");
                return;
            }

            this.Calculate();
        }

        private async void Calculate()
        {
            var bakeCheck = GUIUtilities.BakeCheckAndRun();
            while (bakeCheck.MoveNext())
            {
                await Task.Delay(TimeSpan.FromSeconds(0.05f));
            }

            if (!(bool)bakeCheck.Current)
            {
                return;
            }

            var setPassCallsAndBatches = await Calculator.EditorPlay(AssetUtility.GetId(this.baseFolder), this.spaceSize);
            if (setPassCallsAndBatches == null)
            {
                return;
            }
            var (setPassCalls, batches) = ((int, int))setPassCallsAndBatches;

            EditorUtility.DisplayDialog(
                "VitDeck",
                LocalizedMessage.Get("PerformanceCalculator0.Result", AssetUtility.GetScenePath(this.baseFolder), setPassCalls, batches),
                "OK"
            );
        }
    }
}
