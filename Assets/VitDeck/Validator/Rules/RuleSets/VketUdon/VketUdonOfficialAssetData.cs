using System.Collections.Generic;

namespace VitDeck.Validator.RuleSets
{
    public class VketUdonOfficialAssetData: IOfficialAssetData
    {
        /// <summary>
        /// 公式配布されたアセット及び前提となるアセットのGUID
        /// <list type="bullet">
        /// <item>DynamicBone</item>
        /// <item>TextMeshPro</item>
        /// <item>VRCSDK</item>
        /// <item>Udon</item>
        /// <item>VitDeck</item>
        /// <item>VitDeck Template SharesAssets</item>
        /// <item>VketAssets</item>
        /// <item>VketShaderPack</item>
        /// </list>
        /// </summary>
        public virtual string[] GetGUIDs()
        {
            return new string[]
            {
                #region DynamicBone

                "bdbe6feeda2a62b45ad9a4e311031478", // Assets/DynamicBone/ReadMe.txt
                "ba128457d0ea5e3439dbe4a53b9d1273", // Assets/DynamicBone/Demo/c1.fbx
                "902c84bf971339c459ce4b757e333a55", // Assets/DynamicBone/Demo/Demo1.unity
                "178320cedf292cb4f8d6c0b737b35953", // Assets/DynamicBone/Demo/DynamicBoneDemo1.cs
                "19015a5957bbaa745a61cba005220542", // Assets/DynamicBone/Demo/tail.FBX
                "f9ac8d30c6a0d9642a11e5be4c440740", // Assets/DynamicBone/Scripts/DynamicBone.cs
                "baedd976e12657241bf7ff2d1c685342", // Assets/DynamicBone/Scripts/DynamicBoneCollider.cs
                "04878769c08021a41bc2d2375e23ec0b", // Assets/DynamicBone/Scripts/DynamicBoneColliderBase.cs
                "4e535bdf3689369408cc4d078260ef6a", // Assets/DynamicBone/Scripts/DynamicBonePlaneCollider.cs

                #endregion

                #region Text Mesh Pro

                "6e59c59b81ab47f9b6ec5781fa725d2c", // Assets/TextMesh Pro/Fonts/LiberationSans - OFL.txt
                "e3265ab4bf004d28a9537516768c1c75", // Assets/TextMesh Pro/Fonts/LiberationSans.ttf
                "fade42e8bc714b018fac513c043d323b", // Assets/TextMesh Pro/Resources/LineBreaking Following Characters.txt
                "d82c1b31c7e74239bff1220585707d2b", // Assets/TextMesh Pro/Resources/LineBreaking Leading Characters.txt
                "3f5b5dff67a942289a9defa416b206f3", // Assets/TextMesh Pro/Resources/TMP Settings.asset
                "e73a58f6e2794ae7b1b7e50b7fb811b0", // Assets/TextMesh Pro/Resources/Fonts & Materials/LiberationSans SDF - Drop Shadow.mat
                "2e498d1c8094910479dc3e1b768306a4", // Assets/TextMesh Pro/Resources/Fonts & Materials/LiberationSans SDF - Fallback.asset
                "79459efec17a4d00a321bdcc27bbc385", // Assets/TextMesh Pro/Resources/Fonts & Materials/LiberationSans SDF - Outline.mat
                "8f586378b4e144a9851e7b34d9b748ee", // Assets/TextMesh Pro/Resources/Fonts & Materials/LiberationSans SDF.asset
                "407bc68d299748449bbf7f48ee690f8d", // Assets/TextMesh Pro/Resources/Shaders/TMPro.cginc
                "3997e2241185407d80309a82f9148466", // Assets/TextMesh Pro/Resources/Shaders/TMPro_Properties.cginc
                "d930090c0cd643c7b55f19a38538c162", // Assets/TextMesh Pro/Resources/Shaders/TMPro_Surface.cginc
                "48bb5f55d8670e349b6e614913f9d910", // Assets/TextMesh Pro/Resources/Shaders/TMP_Bitmap-Custom-Atlas.shader
                "1e3b057af24249748ff873be7fafee47", // Assets/TextMesh Pro/Resources/Shaders/TMP_Bitmap-Mobile.shader
                "128e987d567d4e2c824d754223b3f3b0", // Assets/TextMesh Pro/Resources/Shaders/TMP_Bitmap.shader
                "dd89cf5b9246416f84610a006f916af7", // Assets/TextMesh Pro/Resources/Shaders/TMP_SDF Overlay.shader
                "bc1ede39bf3643ee8e493720e4259791", // Assets/TextMesh Pro/Resources/Shaders/TMP_SDF-Mobile Masking.shader
                "a02a7d8c237544f1962732b55a9aebf1", // Assets/TextMesh Pro/Resources/Shaders/TMP_SDF-Mobile Overlay.shader
                "fe393ace9b354375a9cb14cdbbc28be4", // Assets/TextMesh Pro/Resources/Shaders/TMP_SDF-Mobile.shader
                "85187c2149c549c5b33f0cdb02836b17", // Assets/TextMesh Pro/Resources/Shaders/TMP_SDF-Surface-Mobile.shader
                "f7ada0af4f174f0694ca6a487b8f543d", // Assets/TextMesh Pro/Resources/Shaders/TMP_SDF-Surface.shader
                "68e6db2ebdc24f95958faec2be5558d6", // Assets/TextMesh Pro/Resources/Shaders/TMP_SDF.shader
                "cf81c85f95fe47e1a27f6ae460cf182c", // Assets/TextMesh Pro/Resources/Shaders/TMP_Sprite.shader
                "c41005c129ba4d66911b75229fd70b45", // Assets/TextMesh Pro/Resources/Sprite Assets/EmojiOne.asset
                "f952c082cb03451daed3ee968ac6c63e", // Assets/TextMesh Pro/Resources/Style Sheets/Default Style Sheet.asset
                "381dcb09d5029d14897e55f98031fca5", // Assets/TextMesh Pro/Sprites/EmojiOne Attribution.txt
                "8f05276190cf498a8153f6cbe761d4e6", // Assets/TextMesh Pro/Sprites/EmojiOne.json
                "dffef66376be4fa480fb02b19edbe903", // Assets/TextMesh Pro/Sprites/EmojiOne.png

                #endregion

                #region VRCSDK

                "2cdbe2e71e2c46e48951c13df254e5b1", // Assets/VRCSDK/version.txt
                "820ee6e459999be418b410c7af108bc3", // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.CognitoIdentity.dll
                "17e2ad8740ce0ab4eb1a95a73e362865", // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.CognitoIdentity.dll.mdb
                "aecaffc7454b52e448fc0ea1aef2dd1d", // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.Core.dll
                "027e8b8acf565544d9050219e1521b7e", // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.Core.dll.mdb
                "d4055bfc0cd67d642a7eceaf547c4901", // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.S3.dll
                "0da239ac72288814a9c4b799c7674b25", // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.S3.dll.mdb
                "625a50dd0dd525a49a41cb3e3117fa15", // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.SecurityToken.dll
                "b93a9778ddf074845b1649181fda7e86", // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.SecurityToken.dll.mdb
                "34b0990e1522a284b9666d6821cd601c", // Assets/VRCSDK/Dependencies/DotZLib/DotZLib.dll
                "b609c54f9d3581e4fa22b3e389fd8d33", // Assets/VRCSDK/Dependencies/DotZLib/Plugins/x86/zlibwapi.dll
                "54f59547b5261e64f8256d6daaa01b17", // Assets/VRCSDK/Dependencies/DotZLib/Plugins/x86_64/zlibwapi.dll
                "a2e4b2ce02fa7914895069e5fdbf112d", // Assets/VRCSDK/Dependencies/librsync/Blake2Sharp.dll
                "912b2ac597cb1ad4c9bdc1a98ec15459", // Assets/VRCSDK/Dependencies/librsync/librsync.net.dll
                "cb850b86de9091d4db4595959c56f954", // Assets/VRCSDK/Dependencies/Oculus/Spatializer/Editor/ONSPAudioSourceEditor.cs
                "e503ea6418d27594caa33b93cac1b06a", // Assets/VRCSDK/Dependencies/Oculus/Spatializer/Scripts/ONSPAudioSource.cs
                "ad074644ff568a14187a3690cfbd7534", // Assets/VRCSDK/Dependencies/Oculus/Spatializer/Scripts/ONSPSettings.cs
                "5a8cc42eaba7a2a41b6ca3be3c40b315", // Assets/VRCSDK/Dependencies/SharpZipLib/ICSharpCode.SharpZipLib.dll
                "d471b09e7f06a69458457ec63d3532b8", // Assets/VRCSDK/Dependencies/VRChat/Settings.asset
                "10d9f721d76e07a47bc9e5f61e2fae72", // Assets/VRCSDK/Dependencies/VRChat/Editor/EnvConfig.cs
                "c3399613f583f3e46b2df27ae87dd5d6", // Assets/VRCSDK/Dependencies/VRChat/Editor/HDRColorFixerUtility.cs
                "7b8bb626428d0f341b9ed6a68cb5c9cc", // Assets/VRCSDK/Dependencies/VRChat/Editor/SDKUpdater.cs
                "679ba0056bf110c4db8b550082e73a5f", // Assets/VRCSDK/Dependencies/VRChat/Editor/ShaderKeywordsUtility.cs
                "4a9696f3dea8a764f9c4bc6d2e652b74", // Assets/VRCSDK/Dependencies/VRChat/Editor/VRCCachedWWW.cs
                "cb5d1f9882b08564cae97b2b14ad4e8f", // Assets/VRCSDK/Dependencies/VRChat/Editor/VRC_EditorTools.cs
                "f4cf5dd705ab67149afaba40b4a8fa7e", // Assets/VRCSDK/Dependencies/VRChat/Editor/VRC_SdkSplashScreen.cs
                "3d6a1d7b0624f414ba6fb922687a06da", // Assets/VRCSDK/Dependencies/VRChat/Editor/AWS/S3Manager.cs
                "21332e1f0d937794d916d2402ba1943a", // Assets/VRCSDK/Dependencies/VRChat/Editor/BuildPipeline/VRC.SDKBase.Editor.BuildPipeline.asmdef
                "0a1d20f4241085e46bdddc71b691465b", // Assets/VRCSDK/Dependencies/VRChat/Editor/BuildPipeline/Samples/VRCSDKBuildRequestedCallbackSample.cs
                "39cdf3092ab81be4b9e623cb5a8819d8", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/ApiCacheEditor.cs
                "0a364ece829b6234888c59987a305a00", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/AutoAddSpatialAudioComponents.cs
                "89005ebc9543e0a4284893c09ca19b1d", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/EditorCoroutine.cs
                "3d6c2e367eaa9564ebf6267ec163cfbd", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/EditorHandling.cs
                "4810e652e8242384c834320970702290", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/EventHandlerEditor.cs
                "482185bf29f12074dada194ffef6a682", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/OldTriggerEditors.cs
                "5e83254bb97e84795ac882692ae124ba", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRCAvatarDescriptorEditor.cs
                "26a75599848adb449b7aceed5090e35c", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRCObjectSpawnEditor.cs
                "ed4aad2698d3b62408e69b57c7748791", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRCObjectSyncEditor.cs
                "8986a640e24a0754ea0aded12234b808", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRCPlayerModEditorWindow.cs
                "792e7964a56e51f4188e1221751642e9", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRCPlayerModsEditor.cs
                "5262a02c32e41e047bdfdfc3b63db8ff", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRCPlayerStationEditor.cs
                "e9cbc493bbbc443fb92898aa84d221ec", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRCSceneDescriptorEditor.cs
                "eeda995d0ceac6443a54716996eab52e", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_AvatarVariationsEditor.cs
                "0ac7998a36f085844847acbc046d4e27", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_DataStorageEditor.cs
                "3b63b118c0591b548ba1797e6be4292e", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_DestructibleStandardEditor.cs
                "e19a7147a2386554a8e4d6e414f190a2", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_ObjectSyncEditor.cs
                "4aff4e5c0d600c845b29d7b8b7965d68", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_PickupEditor.cs
                "5c545625e0bf93045ac1c5864141c5c1", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_PlayerAudioOverrideEditor.cs
                "0d2d4cba733f5eb4ba170368e67710d2", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_SpatialAudioSourceEditor.cs
                "ae0e74693b7899f47bd98864f94b9311", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_SyncVideoPlayerEditor.cs
                "3f9dccfed0b072f49a307b3f20a7e768", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_SyncVideoStreamEditor.cs
                "3aecd666943878944a811acb9db2ace7", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_TriggerEditor.cs
                "d09b36020f697be4d9a0f5a6a48cfa83", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_WebPanelEditor.cs
                "764e26c1ca28e2e45a30c778c1955a47", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_YouTubeSyncEditor.cs
                "d57b23c04034119448f23c5fdbc57662", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components3/VRCDestructibleUdonEditor.cs
                "8901d07a685ca424492a3cabff506184", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components3/VRCPlayerStationEditor3.cs
                "4b2b9ac625bc5b04c887ff9ee9b5fdbe", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components3/VRCSceneDescriptorEditor3.cs
                "a8cc4c1876b26174fbaeb062178a6bda", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components3/VRC_PickupEditor3.cs
                "3f8f999a8e1ebee4588f94a8a618d7c6", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components3/VRC_SpatialAudioSourceEditor3.cs
                "310a760e312f2984e85eece367bab19a", // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/IVRCSdkControlPanelBuilder.cs
                "20b4cdbdda9655947aab6f8f2c90690f", // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanel.cs
                "5066cd5c1cc208143a1253cac821714a", // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanelAccount.cs
                "4c73e735ee0380241b186a8993fa56bf", // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanelBuilder.cs
                "c768b42ca9a2f2b48afeb1fa03d5e1bf", // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanelBuilderAttribute.cs
                "c7333cdb3df19724b84b4a1b05093fe0", // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanelContent.cs
                "f3507a74e4b8cfd469afac127fa5f4e5", // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanelHelp.cs
                "8357b9b7ef2416946ae86f465a64c0e0", // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanelSettings.cs
                "f2a720a30f1043247af7742fdfd0b8e5", // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanelWorldBuilder.cs
                "93710d221addc0243ba90dd20369844b", // Assets/VRCSDK/Dependencies/VRChat/Editor/SDK3Compatibility/VRCSdk3Analysis.cs
                "c18570190ea21fa4babc80af77d4d766", // Assets/VRCSDK/Dependencies/VRChat/Editor/ShaderStripping/StripPostProcessing.cs
                "b1e8486f7c7c81a4ea45be9776971082", // Assets/VRCSDK/Dependencies/VRChat/Editor/ShaderStripping/VRC.SDKBase.Editor.ShaderStripping.asmdef
                "62d40cc4e8f8494695f0102c58b3ea60", // Assets/VRCSDK/Dependencies/VRChat/Editor/Validation/Performance/SDKPerformanceDisplay.cs
                "da07ab9b78cb0432e95e11e2cb619ea7", // Assets/VRCSDK/Dependencies/VRChat/Materials/BlueprintCam.mat
                "94b649c2bd1ac4cac95049605dc5333d", // Assets/VRCSDK/Dependencies/VRChat/Materials/BlueprintCam.renderTexture
                "2166f6bbfce69594fad494087eca58e8", // Assets/VRCSDK/Dependencies/VRChat/Materials/damageGrey.mat
                "e13e96301b7c8214dac6883be5b82bfa", // Assets/VRCSDK/Dependencies/VRChat/Models/damageSphere.fbx
                "841c3ce718e8b61408005c1cfce6b7de", // Assets/VRCSDK/Dependencies/VRChat/Models/Materials/lambert2.mat
                "4acdf7b3eb426480bb5acf58638bd493", // Assets/VRCSDK/Dependencies/VRChat/Resources/awsconfig.xml
                "dd5614b710e774040ab715161f7dfaca", // Assets/VRCSDK/Dependencies/VRChat/Resources/endpoints.customizations.json
                "37b4abef7420c4c7ea71dbe76757498a", // Assets/VRCSDK/Dependencies/VRChat/Resources/endpoints.json
                "be98467dc5d3c4eb1aeef22952913b0e", // Assets/VRCSDK/Dependencies/VRChat/Resources/VRCCam.prefab
                "dce0dda226bd1f147a34f9b4660f5992", // Assets/VRCSDK/Dependencies/VRChat/Resources/VRCProjectSettings.prefab
                "b14e1b78a061f8543b2f4120b5c369fa", // Assets/VRCSDK/Dependencies/VRChat/Resources/VRCSDKAvatar.prefab
                "248f850c58993ed43bcaad6b934b7c92", // Assets/VRCSDK/Dependencies/VRChat/Resources/vrcSdkBottomHeader.png
                "551946bfd2b165f419f297805d1e1256", // Assets/VRCSDK/Dependencies/VRChat/Resources/vrcSdkBottomHeader_Oculus_Quest.png
                "d2244637721b4f3458280ffc1f9dd7cc", // Assets/VRCSDK/Dependencies/VRChat/Resources/vrcSdkClDialogNewIcon.png
                "38956f4b67ba0984587b1a913d05beea", // Assets/VRCSDK/Dependencies/VRChat/Resources/vrcSdkHeader.png
                "ff7f4f4963793a340bde459bc9975c07", // Assets/VRCSDK/Dependencies/VRChat/Resources/vrcSdkHeaderWithCommunityLabs.png
                "1d151b29d1d1c704daa27e4921e39129", // Assets/VRCSDK/Dependencies/VRChat/Resources/vrcSdkSplashUdon1.png
                "8458230047d35d4498b2de453f2cabda", // Assets/VRCSDK/Dependencies/VRChat/Resources/vrcSdkSplashUdon2.png
                "fc887d4eeb5a941ed86bca0135b05e2b", // Assets/VRCSDK/Dependencies/VRChat/Resources/VRCSDKWorld.prefab
                "e8e780ff40c6a484294bfec8711ced23", // Assets/VRCSDK/Dependencies/VRChat/Resources/VRC_PlayerVisualDamage.prefab
                "43066d8a73c579048891e3c123e252a0", // Assets/VRCSDK/Dependencies/VRChat/Resources/2FAIcons/SDK_Warning_Triangle_icon.png
                "f310c3dbad3125d4e8fc2e00bdc2acb4", // Assets/VRCSDK/Dependencies/VRChat/Resources/CL_Icons/CL_Lab_Icon_256.png
                "36349feed06587e479724a1a09c0b267", // Assets/VRCSDK/Dependencies/VRChat/Resources/CL_Icons/Icon_New.png
                "4109d4977ddfb6548b458318e220ac70", // Assets/VRCSDK/Dependencies/VRChat/Resources/PerformanceIcons/Perf_Good_32.png
                "644caf5607820c7418cf0d248b12f33b", // Assets/VRCSDK/Dependencies/VRChat/Resources/PerformanceIcons/Perf_Great_32.png
                "2886eb1248200a94d9eaec82336fbbad", // Assets/VRCSDK/Dependencies/VRChat/Resources/PerformanceIcons/Perf_Horrible_32.png
                "9296abd40c7c1934cb668aae07b41c69", // Assets/VRCSDK/Dependencies/VRChat/Resources/PerformanceIcons/Perf_Medium_32.png
                "e561d0406779ab948b7f155498d101ee", // Assets/VRCSDK/Dependencies/VRChat/Resources/PerformanceIcons/Perf_Poor_32.png
                "8ae6e7ea5b8982143aa8c2c4e2fe81c6", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/AnimatorPerformanceScanner.asset
                "c2ca835e9f95b464b8a2df5c181ba44e", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/AudioPerformanceScanner.asset
                "d162a2d08d890e644b79b605f1d1120e", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/ClothPerformanceScanner.asset
                "371dfb95b91b4684eb1ad68d37d81ac9", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/DynamicBonePerformanceScanner.asset
                "69c7115984bf82e46af96d6f144fe463", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/LightPerformanceScanner.asset
                "07199be0cf1b2a34f8dff60d486129ea", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/LineRendererPerformanceScanner.asset
                "e750aae2c41768e4485dfb9a6de00454", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/MeshPerformanceScanner.asset
                "f4004220746a95a4e84a3909a49d844b", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/ParticlePerformanceScanner.asset
                "18ec5f6f963b6774fa1b84c5bff0246f", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/PhysicsPerformanceScanner.asset
                "986c284df70b4c34dad7e5ef27a86156", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/TrailRendererPerformanceScanner.asset
                "bf50321b92d503d4a823939356ce856d", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/ScannerSets/PerformanceScannerSet_Quest.asset
                "b0d7b483809dd6441bb36507c9f64040", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/ScannerSets/PerformanceScannerSet_Windows.asset
                "f0f530dea3891c04e8ab37831627e702", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Quest/AvatarPerformanceStatLevels_Quest.asset
                "e750436d0bab192489da0debe67ee879", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Quest/Excellent_Quest.asset
                "b25db21b17fba3d49a7248568fdb9870", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Quest/Good_Quest.asset
                "31feb7417182a80469408649071d10ac", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Quest/Medium_Quest.asset
                "171503e8193e15447967be1e3ca1e714", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Quest/Poor_Quest.asset
                "438f83f183e95f740877d4c22ed91af2", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Windows/AvatarPerformanceStatLevels_Windows.asset
                "88c46902276e7624e8adda9020bef28b", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Windows/Excellent_Windows.asset
                "38957d57ab5a7f145b954d20fc24b1d4", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Windows/Good_Windows.asset
                "65edaefdc2f87414594559cb89383b5b", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Windows/Medium_Windows.asset
                "595049d4e162571489f2437524d98a31", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Windows/Poor_Windows.asset
                "36c0d886a26373c46be857f2fc441071", // Assets/VRCSDK/Dependencies/VRChat/Scripts/ApiFileHelper.cs
                "acadc6659c5ab3446ad0d5de2563f95f", // Assets/VRCSDK/Dependencies/VRChat/Scripts/AudioManagerSettings.cs
                "8d047eaa3325d654aa62ccad6f73eb93", // Assets/VRCSDK/Dependencies/VRChat/Scripts/CommunityLabsConstants.cs
                "e1c693656bf5d584b87df969efeb5536", // Assets/VRCSDK/Dependencies/VRChat/Scripts/ContentUploadedDialog.cs
                "a3132e0ab7e16494a9d492087a1ca447", // Assets/VRCSDK/Dependencies/VRChat/Scripts/RuntimeAPICreation.cs
                "1e5ebf65c5dceeb4c909aa7812bd2999", // Assets/VRCSDK/Dependencies/VRChat/Scripts/RuntimeBlueprintCreation.cs
                "2bd5ee5d69ee0f3449bf2f81fcb7f4e3", // Assets/VRCSDK/Dependencies/VRChat/Scripts/RuntimeWorldCreation.cs
                "0d49300ad532d4ae6b569b28de5b7dac", // Assets/VRCSDK/Dependencies/VRChat/Scripts/SceneSaver.cs
                "10121679f780956408f9a434a526f553", // Assets/VRCSDK/Dependencies/VRChat/Scripts/MaterialFallback/FallbackMaterialCache.cs
                "bef0a8d1d2c547119a62b7d7a5c512ea", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/ShaderValidation.cs
                "8a90ec11b51863c4cb2d8a8cee31c2fb", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/ValidationUtils.cs
                "9b03724cd556cb047b2da80492ea28a5", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/WorldValidation.cs
                "15ecac6f7fdc1bc4fb723fee6f4635dd", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/AvatarPerformance.cs
                "f1ce994297384ff1bc330196df61b7ca", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/AvatarPerformanceCategory.cs
                "f28c978154794266b38d686139c6b872", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/MeshUtils.cs
                "8cdca9d06d1b4732b9ccb82a38bb8d9c", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/PerformanceFilterSet.cs
                "a5ed7498cb1a46c78eab031f5f32448c", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/PerformanceInfoDisplayLevel.cs
                "5019a55ee9e2404c81bc61a39a010d8d", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/PerformanceRating.cs
                "4afb61f36d144fc381114cd7f78d13e7", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/PerformanceScannerSet.cs
                "abda65e062e44213aa3e1f4c82b400a8", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Filters/AbstractPerformanceFilter.cs
                "0bd0691a021844f49444a04a959d6328", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/AbstractPerformanceScanner.cs
                "08c8e931d0544866a0f626855d9c1841", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/AnimatorPerformanceScanner.cs
                "b3a8bba736414d1aaa9e766da27b56b5", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/AudioPerformanceScanner.cs
                "0cec88b5a46f459195f10a2f11fddb2f", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/ClothPerformanceScanner.cs
                "a226df494ef04404a9a47c714822ab9f", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/DynamicBonePerformanceScanner.cs
                "405778fdc32c44c1bb9fdd0476fb0007", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/LightPerformanceScanner.cs
                "ec87392b85844f7bb526a48ec866a8f0", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/LineRendererPerformanceScanner.cs
                "38bca10261df4ddfa10cff3b3bbb9428", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/MeshPerformanceScanner.cs
                "10723e354ff14f98a49ab797b3f005e6", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/ParticlePerformanceScanner.cs
                "6a94ecdeecd04f85824cc3244be5712a", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/PhysicsPerformanceScanner.cs
                "2efd714b564547b4be1ebd1f2700668b", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/TrailRendererPerformanceScanner.cs
                "1bf4fb79a49d4b109c4dce6b38e5548e", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Stats/AvatarPerformanceStats.cs
                "f742c36dce5730f4d96e37d82c330584", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Stats/AvatarPerformanceStatsLevel.cs
                "468554b1bfc447f41a20a2f5bae65d16", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Stats/AvatarPerformanceStatsLevelSet.cs
                "9ae7399f0cf902a41a20f3487af8322a", // Assets/VRCSDK/Dependencies/VRChat/SdkGraphics/SDK_Panel_Banner.png
                "13d3efffb839ced4c8426a88a0c3e98c", // Assets/VRCSDK/Dependencies/VRChat/Textures/damageGreyNoAlpha.png
                "8d95767408d35544c98f92ef7279b8db", // Assets/VRCSDK/Dependencies/VRChat/Textures/damageGRNoAlpha.png
                "861bc2dd35aa1534d89330ffa4434b61", // Assets/VRCSDK/Dependencies/VRChat/Textures/VRChatBanner.png
                "3bb6d22e89000724b90fb830af69384b", // Assets/VRCSDK/Plugins/sqlite3.dll
                "4ecd63eff847044b68db9453ce219299", // Assets/VRCSDK/Plugins/VRCCore-Editor.dll
                "b0e1c0f72d838fe49bfe88b987a471bd", // Assets/VRCSDK/Plugins/VRCCore-Standalone.dll
                "215be632cb025bd429dd50a3fa942168", // Assets/VRCSDK/Plugins/VRCSDK3-Editor.dll
                "661092b4961be7145bfbe56e1e62337b", // Assets/VRCSDK/Plugins/VRCSDK3.dll
                "d09383607271b19468447945fda29e86", // Assets/VRCSDK/Plugins/VRCSDK3Base-Editor.dll
                "bdccfb093344e7545a49b72a64499682", // Assets/VRCSDK/Plugins/VRCSDK3Base.dll
                "dc5cab6c932db3247aab9f50c5f3bd5f", // Assets/VRCSDK/Plugins/VRCSDKBase-Editor.dll
                "db48663b319a020429e3b1265f97aff1", // Assets/VRCSDK/Plugins/VRCSDKBase.dll

                #endregion

                #region Udon

                "45115577ef41a5b4ca741ed302693907", // Assets/Udon/UdonBehaviour.cs
                "530bdb25a3862ff4c8be42f678c53527", // Assets/Udon/UdonManager.cs
                "473737f63e15e204aa3a3df7a3a173e3", // Assets/Udon/version.txt
                "3c1bc1267eab5884ebe7f232c09ee0d9", // Assets/Udon/VRC.Udon.asmdef
                "84de2da7fe8ad8e439c084731189bc12", // Assets/Udon/Editor/UdonBehaviourEditor.cs
                "66ebdaa27f6d2d54cbb62abddc493674", // Assets/Udon/Editor/UdonEditorManager.cs
                "627c4d5cd580ddf41bd320e784fe8b9d", // Assets/Udon/Editor/VRC.Udon.Editor.asmdef
                "8b6535096cfa29340897276abbdd015f", // Assets/Udon/Editor/External/VRC.Udon.Compiler.dll
                "585dd63e377866248b16bdba915820ed", // Assets/Udon/Editor/External/VRC.Udon.EditorBindings.dll
                "b335798a4f28bec40ba9b3d4a15acee7", // Assets/Udon/Editor/External/VRC.Udon.Graph.dll
                "21dcba1a47cc8c84381629950b692129", // Assets/Udon/Editor/External/VRC.Udon.UAssembly.dll
                "161140ecae894b84ba7bdd6e44ff4371", // Assets/Udon/Editor/External/VRC.Udon.VRCGraphModules.dll
                "19cff77330d183441a69ff6c69e07629", // Assets/Udon/Editor/External/VRC.Udon.VRCTypeResolverModules.dll
                "cac80b40f57c41d4b941dc5059271583", // Assets/Udon/Editor/GraphModules/VRCInstantiateNodeRegistry.cs
                "e1b5b45f24b268b42826fc5c5497dc15", // Assets/Udon/Editor/ProgramSources/SerializedUdonProgramAssetEditor.cs
                "0e5ced9511d591140b191bbd9e948e61", // Assets/Udon/Editor/ProgramSources/Attributes/UdonProgramSourceNewMenuAttribute.cs
                "22203902d63dec94194fefc3e155c43b", // Assets/Udon/Editor/ProgramSources/UdonAssemblyProgram/UdonAssemblyProgramAsset.cs
                "3df823f3ab561fc43bcb81286e14b91d", // Assets/Udon/Editor/ProgramSources/UdonAssemblyProgram/UdonAssemblyProgramAssetEditor.cs
                "3c0638314c289c24193b47d1c53c9fca", // Assets/Udon/Editor/ProgramSources/UdonAssemblyProgram/UdonAssemblyProgramAssetImporter.cs
                "4f11136daadff0b44ac2278a314682ab", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UdonGraphProgramAsset.cs
                "31d6811854f59254aa1a263a8d566eb2", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UdonGraphProgramAssetEditor.cs
                "57422d3fdb0cc124189c68f87b7157cd", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/UdonGraphExtensions.cs
                "e2f2300f99ce0ea4a8d9a20b464384df", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/TypeExtension.cs
                "9214873dab0ea8a4b91861cd5a04dae3", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/UdonGraph.cs
                "f166d8f1c152ef34899019ab9a4fd0f2", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/UdonGraphElementData.cs
                "54dd824c6c614b94183d92710efe4f5f", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/UdonGraphStatus.cs
                "87e2044d3bcb715499ac68cc7380a9ed", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/UdonGraphViewSettings.cs
                "c6f017dc2674fec4da54a57b2655a948", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/UdonGraphWindow.cs
                "5dcd92112af21784ba5bf6383abab768", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/UdonParameterField.cs
                "70616b8b964e3664780fc03f65f27f4f", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/UdonParameterProperty.cs
                "fddc146e8502d7b49a294b6264d66dfd", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/UdonProgramSourceView.cs
                "e5786fc577943ae45953c6f54c97116b", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/UdonWelcomeView.cs
                "aabdd863f82551d40bd3a1b0835d2fc3", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/VideoPlayerElement.cs
                "469db50616185d04e8a46dcd75db12d2", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/GraphElementExtension.cs
                "f4f0ade55ae13b6468a765826f1f2540", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/UdonArrayInspector.cs
                "7e5916b8dd19e4445a9156a457b82ee4", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/UdonComment.cs
                "ba3ecc4c46929404d8c2ec920743b823", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/UdonGraphElement.cs
                "1b8045222a10ce04b815642b9cd5ca17", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/UdonGroup.cs
                "b006d67642298f04e895b6709ef12429", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/UdonMinimap.cs
                "dcd657bc1dcf357448d27bcfa8c5dc36", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/UdonNode.cs
                "8f83d1d3578dd28498c71a980bca86dd", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/UdonPort.cs
                "c5cfbbfcd7bb5ad4487f1f9388a3a168", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/UdonStackNode.cs
                "2d0a4730c5f61b247b27b54f280300b5", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/UdonVariablesBlackboard.cs
                "6581176c97993bb40976acff208bd0b1", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/Search/UdonFocusedSearchWindow.cs
                "b721120e6c1d320448a55fe87a7de824", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/Search/UdonFullSearchWindow.cs
                "e94c084f399869b42a21244fd07778c4", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/Search/UdonPortSearchWindow.cs
                "6a6c453fae11b5349a33399e258d1578", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/Search/UdonRegistrySearchWindow.cs
                "e5a10bb1987c27944bd08a88119b2844", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/Search/UdonSearchManager.cs
                "d825ed3ba6aa7f14294e73efefc217d0", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/Search/UdonSearchWindowBase.cs
                "16fc7a7a059deeb458fdcdf719b467a4", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/Search/UdonVariableTypeWindow.cs
                "264ec3c8a1d423f42a144da0df6c5ebe", // Assets/Udon/Editor/ProgramSources/UdonProgram/UdonProgramAsset.cs
                "41d70977fa7936441afe41442f1862b2", // Assets/Udon/Editor/ProgramSources/UdonProgram/UdonProgramAssetEditor.cs
                "9e84f8ee45862f04ca6b9f8d5c7f5897", // Assets/Udon/Editor/Resources/CornerResize.png
                "632470b93f35ec64ab6e3efd639c986c", // Assets/Udon/Editor/Resources/DarkButtonBG.png
                "d4ca7f47895ab36408e28f4f742fba99", // Assets/Udon/Editor/Resources/DropdownBG.png
                "f43fd332539599c47b3bb05ea38d5d0d", // Assets/Udon/Editor/Resources/ToolbarBG.png
                "5cbfe49b858635b44844a178cb934b68", // Assets/Udon/Editor/Resources/ToolbarButtonBG.png
                "7dade49b2f58f734f8db0983d8e7fb60", // Assets/Udon/Editor/Resources/UdonChangelog.uxml
                "927841c571a405846b3442bc0aa56220", // Assets/Udon/Editor/Resources/UdonFlowSlot.png
                "3803fec4c7b065042891595e749524cc", // Assets/Udon/Editor/Resources/UdonFlowSlotFilled.png
                "7c75c00422f12124faed19bfb8dd96df", // Assets/Udon/Editor/Resources/UdonFlowSlotFilledLight.png
                "610088fc92e5fc64b8c7f9e9c51f2939", // Assets/Udon/Editor/Resources/UdonFlowSlotLight.png
                "d47fd176596dfbe4e9e78964b40c93ee", // Assets/Udon/Editor/Resources/UdonGraphNeonStyle.uss
                "815baa9989198624aa5fec5ecdb42bd0", // Assets/Udon/Editor/Resources/UdonGraphStyle.uss
                "0e2cfcbd717e75441b108d3ad9de2d29", // Assets/Udon/Editor/Resources/UdonLogo.png
                "8cf68553c5a4bb140a6341072891aa88", // Assets/Udon/Editor/Resources/UdonLogoAlpha.png
                "d0608d33a4043b2499adb1fee18f2a64", // Assets/Udon/Editor/Resources/UdonLogoAlphaWhite.png
                "17102758d03099542afc7a1808745eaf", // Assets/Udon/Editor/Resources/UdonNodeAccent.png
                "c0230adfeb2abe242b8d64c7e3bd2adc", // Assets/Udon/Editor/Resources/UdonNodeActiveBackground.png
                "8289cc16393cd3040a9920e71bfe10bc", // Assets/Udon/Editor/Resources/UdonNodeActiveBackgroundLight.png
                "f47842ead2f80fa46ab6e5bbde409193", // Assets/Udon/Editor/Resources/UdonNodeBackground.png
                "c9235631e37566447ae4567624755326", // Assets/Udon/Editor/Resources/UdonNodeBackgroundLight.png
                "2d2675a75fea1d2438859bdb320d544d", // Assets/Udon/Editor/Resources/UdonNodeInlay.png
                "12f29a8be9fc52640b40f6ffa59336c6", // Assets/Udon/Editor/Resources/UdonNodeInlayLight.png
                "1ed47570201e1854d9e455e38eecbcf7", // Assets/Udon/Editor/Resources/UdonSettings.uxml
                "91b7c8d7d899ec04e9568e9385aba34d", // Assets/Udon/Editor/Resources/UdonSlot.png
                "3a1ab76e09365f14cab0665b40da8843", // Assets/Udon/Editor/Resources/UdonSlotFilled.png
                "add07ab72e2fc3d4d81143ab77d121f5", // Assets/Udon/Editor/Resources/UdonSlotFilledLight.png
                "1badb339ed4f23541b6db8a9420aeea9", // Assets/Udon/Editor/Resources/UdonSlotLight.png
                "37bd184e5e9b13945840f70329f2e0f6", // Assets/Udon/Editor/Resources/videoStill.png
                "c041fa712f66a5d4f8525cd447dc8b29", // Assets/Udon/Editor/TypeResolvers/UdonBehaviourTypeResolver.cs
                "02e7e7f5f9fc2c24ab3af0b8780f3623", // Assets/Udon/Editor/UnityEditorTests/UICompilerTests.cs
                "3c3c5a3876474c648a47177c1875f447", // Assets/Udon/Editor/UnityEditorTests/UnityEditorTests.asmdef
                "80455fb15755bfd47b1803c8fe84e16e", // Assets/Udon/External/VRC.Udon.ClientBindings.dll
                "a5e7b2f5005f10e44b082e7c18871cc6", // Assets/Udon/External/VRC.Udon.Common.dll
                "9d86dc4a513809149af3856eab191a3d", // Assets/Udon/External/VRC.Udon.Security.dll
                "ecb1eec40b5e47047891ee46e739186a", // Assets/Udon/External/VRC.Udon.VM.dll
                "92886df353bf1f14489cf2c4578e58af", // Assets/Udon/External/VRC.Udon.VRCWrapperModules.dll
                "a3a3dda899277cc4ea6aebe18c6b5736", // Assets/Udon/External/VRC.Udon.Wrapper.dll
                "bf61d954ecb803046953c666facfb904", // Assets/Udon/ProgramSources/SerializedUdonProgramAsset.cs
                "2fad63ba312d5f44a8ab215c3f5b18f1", // Assets/Udon/ProgramSources/Abstract/AbstractSerializedUdonProgramAsset.cs
                "7fa64b2d7df72fb4cbf7898a400e86ef", // Assets/Udon/ProgramSources/Abstract/AbstractUdonProgramSource.cs
                "b1d0b8aa8084bcd44a572d524d7a31bb", // Assets/Udon/Serialization/Formatters/UdonGameObjectComponentReferenceFormatter.cs
                "f2626352b2a60eb41adc3580ae44c750", // Assets/Udon/Serialization/Formatters/UdonProgramFormatter.cs
                "ec4e6da38017fe7df076afceb30fa17c", // Assets/Udon/Serialization/OdinSerializer/LICENSE
                "2105a6c0e5c0955d2d4a704c5e9c9b8f", // Assets/Udon/Serialization/OdinSerializer/Version.txt
                "f70a94b0bedfa8ec50ed757f72032810", // Assets/Udon/Serialization/OdinSerializer/VRC.Udon.Serialization.OdinSerializer.asmdef
                "bfaf18dca1f68cc99ebeb0b862179265", // Assets/Udon/Serialization/OdinSerializer/Config/GlobalSerializationConfig.cs
                "4ac1e1612275111bd50db8a3de8ba9c4", // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/BaseDataReader.cs
                "501a7e1356f5fdc8e9bbefcd61a56490", // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/BaseDataReaderWriter.cs
                "9638b18c6b6b6532b3b3cd3a73fefc2a", // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/BaseDataWriter.cs
                "dc1fe25e670cf981ed66b3e85c3e4249", // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/IDataReader.cs
                "af6696e41807b3c3f9a1d73667f76701", // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/IDataWriter.cs
                "ee0465a1838833eb878447b34339d4f4", // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/Binary/BinaryDataReader.cs
                "1bc9e2503afdd0290574ebc14cf4a16d", // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/Binary/BinaryDataWriter.cs
                "1361420bc2b384389a065fd2fe59fb22", // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/Binary/BinaryEntryType.cs
                "7a3a6dce9e0b8317b3804b35f48f6a97", // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/Json/JsonConfig.cs
                "2ecc39ef0dc55ec10f83bb7eefd4f1db", // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/Json/JsonDataReader.cs
                "3e05b98a26be61fa9203d4a45bfc1e95", // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/Json/JsonDataWriter.cs
                "aad0a34e801ae645b359e4800ef7f636", // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/Json/JsonTextReader.cs
                "6a0f5e01b82ae0763f6f907157a2c9c8", // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/SerializationNodes/SerializationNode.cs
                "eab5938e837a8de93ce64c25399edde6", // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/SerializationNodes/SerializationNodeDataReader.cs
                "9321fb650525f4bed18119d187111569", // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/SerializationNodes/SerializationNodeDataReaderWriterConfig.cs
                "dd54f07c359d141095a031192c5ca084", // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/SerializationNodes/SerializationNodeDataWriter.cs
                "0bdecd79f568c8a3252bb5a9f3e2acdc", // Assets/Udon/Serialization/OdinSerializer/Core/FormatterLocators/ArrayFormatterLocator.cs
                "c4228cdbba89e2a5d52357b998c3387d", // Assets/Udon/Serialization/OdinSerializer/Core/FormatterLocators/DelegateFormatterLocator.cs
                "cf715e98fa96d74c81b4d3f4491d2592", // Assets/Udon/Serialization/OdinSerializer/Core/FormatterLocators/FormatterLocator.cs
                "d35d0d1eb290f5d00e273d65e5db09d7", // Assets/Udon/Serialization/OdinSerializer/Core/FormatterLocators/GenericCollectionFormatterLocator.cs
                "f2a9beaeecdd6eb929ddb049d7846a14", // Assets/Udon/Serialization/OdinSerializer/Core/FormatterLocators/IFormatterLocator.cs
                "cdd12b278851bfdc68ca0d9e1e4f2d28", // Assets/Udon/Serialization/OdinSerializer/Core/FormatterLocators/ISerializableFormatterLocator.cs
                "876ae9a404abe412e663fd9bc03d3525", // Assets/Udon/Serialization/OdinSerializer/Core/FormatterLocators/SelfFormatterLocator.cs
                "00e10f526d476731ebc596ceb66271a6", // Assets/Udon/Serialization/OdinSerializer/Core/FormatterLocators/TypeFormatterLocator.cs
                "9aaf14140a26e04b861b027d5ddb8fb6", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/ArrayFormatter.cs
                "3f5dc00eb17e568de42119a7f0f30ee8", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/ArrayListFormatter.cs
                "9598679c29f3e3696941746c26f1ccf8", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/BaseFormatter.cs
                "dff51bfb9b4d71aa78b3e5c8fec8c924", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/DateTimeFormatter.cs
                "3480954e7eecdc9745c1d08721b2f8b3", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/DateTimeOffsetFormatter.cs
                "4f17b17e986ae6f3be6a2ea1b716fcaf", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/DelegateFormatter.cs
                "4402da708267c579874c808a813bfe62", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/DerivedDictionaryFormatter.cs
                "b80567603fe814a8b4341584f8c3b4a6", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/DictionaryFormatter.cs
                "5c21ee7e54dff531da57563e2f81fff5", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/DoubleLookupDictionaryFormatter.cs
                "54578488936f8484c97ba7c52bfb0563", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/EasyBaseFormatter.cs
                "e226537cbfa910681132da3718f41c34", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/EmittedFormatterAttribute.cs
                "149c482b2ab9c601b8bc2ecc20bbd8d9", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/EmptyTypeFormatter.cs
                "b7da6bf97199e0bb743f7639c17112ac", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/FormatterEmitter.cs
                "06ccb8250c692f2695d28bfd6bcd4273", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/GenericCollectionFormatter.cs
                "f1eaa1b43658215b6d81013928eac19e", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/HashSetFormatter.cs
                "0fcb040f1c493dc2a5224e446be8b3c9", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/IFormatter.cs
                "5cae1c5d1116a090d70b6d0289061d21", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/KeyValuePairFormatter.cs
                "ba4ee6777a44f6e9a8e2e0a222c0f7db", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/ListFormatter.cs
                "21078ce134ce87231526dee77088e7ab", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/MethodInfoFormatter.cs
                "ae604bc0ef4ef9938100804f05decb21", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/MinimalBaseFormatter.cs
                "dc1b5b3148988d0d4fc2dab60a5c146c", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/MultiDimensionalArrayFormatter.cs
                "f9ea00de8051ca957d994e11630671d9", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/NullableFormatter.cs
                "6b6a62ea2fe943a4b261f832e8a1f3dd", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/PrimitiveArrayFormatter.cs
                "8045e4edca7c27f5b16bd90d7101c935", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/QueueFormatter.cs
                "15fa864c9e3363220ceac4ec93c7f5b8", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/ReflectionFormatter.cs
                "dde0095df6bea6624dfa72a31127bc48", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/ReflectionOrEmittedBaseFormatter.cs
                "12a47dd574302b77ba3c5ac05cd04541", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/SelfFormatterFormatter.cs
                "0f59404c810d015ed87c7e1557188435", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/SerializableFormatter.cs
                "087303d0d43cf7ce5af060a0cc0b5d38", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/StackFormatter.cs
                "4b0676b49f03cc50a1e532cf23e3988e", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/TimeSpanFormatter.cs
                "c6529471b992ba4080a123aa504ef9ea", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/TypeFormatter.cs
                "4a7c8e71a3ef1124db10e72af34e1724", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/VersionFormatter.cs
                "23fa5d3fed3b4b9de502257a594b00de", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/AllowDeserializeInvalidDataAttribute.cs
                "92726834b08002d525b86fbb012e184f", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/AlwaysFormatsSelfAttribute.cs
                "72783638708ea644ba5c3e1b91f827f6", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/ArchitectureInfo.cs
                "ad4e17831e9503c1f11149997c609477", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/Buffer.cs
                "e7e73146f1e861c27c5608bff4142402", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/CachedMemoryStream.cs
                "4fd6ff4077bbbef9b366d8ffd9236173", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/CustomFormatterAttribute.cs
                "e02123fad495d06f2a89e5335f00126c", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/CustomGenericFormatterAttribute.cs
                "97e9e01eb36fd43879b166b6b3c2469b", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/CustomLogger.cs
                "95bb5531b6c1d1a5eab8400ea1bd6167", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/CustomSerializationPolicy.cs
                "c2a40a3e6a114e5a50c0af209b8ae35e", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/DataFormat.cs
                "0bd9ab6cf3bd913588b6652279b7a6ba", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/DefaultLoggers.cs
                "996e793dcc0920d2590cb61f0761d498", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/DefaultSerializationBinder.cs
                "c79df97337d89089be40beb2e272df0b", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/DeserializationContext.cs
                "ae849a3e6d277006f3b4dd58a5765955", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/EmittedAssemblyAttribute.cs
                "3b06b106636f38afbb25ddd11e0c597c", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/EntryType.cs
                "c73435dff291e72c0d9ce55b59c39145", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/ErrorHandlingPolicy.cs
                "df06475ac5299f402ca1bdee3cf7e702", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/ExcludeDataFromInspectorAttribute.cs
                "08528593c8dd764b6d928dcee6daca9f", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/FormatterLocationStep.cs
                "30194d27b77855bf09b9af809a761ca5", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/FormatterUtilities.cs
                "32f94aca65b8d09ddd7b3db72e08db3f", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/IAskIfCanFormatTypes.cs
                "7ef6b6dd5e3be66c3a66753cc7e799de", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/IExternalGuidReferenceResolver.cs
                "d1eaa1a505a876bebb9cad40d01989e9", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/IExternalIndexReferenceResolver.cs
                "9414cf6a3ea9a51afcf648fe9ea02bed", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/IExternalStringReferenceResolver.cs
                "8bab352682356b8a2b02842520a68a11", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/ILogger.cs
                "106ca47adfa52732b129015337a1c8cd", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/ISelfFormatter.cs
                "90bcbfdc0286ca48d51fc578a1e15b8f", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/ISerializationPolicy.cs
                "7de3f23805ad9d4b3d033eef45e3b59b", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/LoggingPolicy.cs
                "10eb7be2b7c363367c46bc5699a361a8", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/NodeInfo.cs
                "766bbafe64ad16f63af4b81eb430e380", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/OdinSerializeAttribute.cs
                "3db8c00661ec222984427ab12295940f", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/PrefabModification.cs
                "23ceed712f987034deb8e92c561a1d3b", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/PrefabModificationType.cs
                "96fec6c04f13e378def42ea5ad5dc940", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/PreviouslySerializedAsAttribute.cs
                "989e99cd5b8f922edc1b13bbc22f4289", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/ProperBitConverter.cs
                "82702718797409c332f9174bdad57bbc", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/RegisterFormatterAttribute.cs
                "a000ffc63858a974eb63d9ef6f91adac", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/RegisterFormatterLocatorAttribute.cs
                "dca124a461001ad1494664ed95539612", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/SerializationAbortException.cs
                "eba33c8e77e2084c660af46be1b547dd", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/SerializationConfig.cs
                "1e93880e733f9a6a084cf4061634e7fb", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/SerializationContext.cs
                "67a19021ff9e6b27d8e9257ad075055a", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/SerializationPolicies.cs
                "08607b6e9c39ec19c1b61341583c2f3e", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/SerializationUtility.cs
                "bc69d8fd9d15913a491a45d1e040faf6", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/TwoWaySerializationBinder.cs
                "0e8d8c5a97fdc322a8b8471aaf02f469", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/BooleanSerializer.cs
                "8aa9f52771b0e4e6f8f0c438a4f0430b", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/ByteSerializer.cs
                "d44d1ae83013328d7b855275fa1cfad7", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/CharSerializer.cs
                "5a2a43b51cef79fd0e85028650394b55", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/ComplexTypeSerializer.cs
                "50c67937d611e4749188b838e4cff5dc", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/DecimalSerializer.cs
                "9fc4716f683bc313c24bfa537cdd97f6", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/DoubleSerializer.cs
                "7a5d23b139cd8e692702aa431b071d07", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/EnumSerializer.cs
                "19dcfa9f6a40979fc2b6c3ae0f24b67c", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/GuidSerializer.cs
                "d280b44f7c75a9a18484a84745998130", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/Int16Serializer.cs
                "eafebb70813195e03b1ba467931eb686", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/Int32Serializer.cs
                "afe45c48508431a62aba886d943d8501", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/Int64Serializer.cs
                "6ccaffe3090611c2ada67d49cf834771", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/IntPtrSerializer.cs
                "88f3ec418fdfdd7eabd6134f1de91991", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/SByteSerializer.cs
                "29261eaea99f2d34c42cdc0b04f95daa", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/Serializer.cs
                "7aa356971fd0b66eb59875b278fa7f03", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/SingleSerializer.cs
                "85996580a8691185d06ec342c5c43747", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/StringSerializer.cs
                "3936194ea64890e11a7db8474eb0bbcf", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/UInt16Serializer.cs
                "f30e426f88b471e498dd1853b7bbaee6", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/UInt32Serializer.cs
                "f55c085325e12800428d01e3535cb297", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/UInt64Serializer.cs
                "0ee9dd19c234e4b16c835b9188459e36", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/UIntPtrSerializer.cs
                "94a6cc2044fcd2cb317b1cdb1e8fcdaf", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/AOTSupportScanner.cs
                "f5fe153775edbadfa2b659e0e35dc881", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/AOTSupportUtilities.cs
                "aaf2f90207414827b53b85dae0eae82e", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/OdinPrefabSerializationEditorUtility.cs
                "de5584f66ccc5e072681a310c5987b8c", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/UnityReferenceResolver.cs
                "f670c1f9aa9ab0c5988e81802c005767", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/UnitySerializationInitializer.cs
                "9eb15f2339819bb651c7872d73c89776", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/UnitySerializationUtility.cs
                "864fb1c011715f9df2998d71ac8716f6", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/DictionaryKeySupport/BaseDictionaryKeyPathProvider.cs
                "ef6f699f176c2dfdea788982526f989a", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/DictionaryKeySupport/DictionaryKeyUtility.cs
                "b513c156933d8b833ccd40d717bf7e2b", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/DictionaryKeySupport/IDictionaryKeyPathProvider.cs
                "54f653ed4a4e15c07057283c11dce4d9", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/DictionaryKeySupport/RegisterDictionaryKeyPathProviderAttribute.cs
                "0405ef103432161dff609e75f71f3f55", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/DictionaryKeySupport/Vector2DictionaryKeyPathProvider.cs
                "1d61e235c606c1c9d7269f7e68471e38", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/DictionaryKeySupport/Vector3DictionaryKeyPathProvider.cs
                "51bb2cf369b5ea90948a20e4f2ebae48", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/DictionaryKeySupport/Vector4DictionaryKeyPathProvider.cs
                "3d2976bd61cccf62b11b4d3f02762465", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/AnimationCurveFormatter.cs
                "6ff1b29d64402a15d020739becd8661e", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/BoundsFormatter.cs
                "0878ec68b6ab3c9ebc365b6d139e4840", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/Color32Formatter.cs
                "25e35581ce6d1febd9ac41864a76ecdb", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/ColorBlockFormatter.cs
                "484768ba343a6a05522c29d81a4ce61d", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/ColorFormatter.cs
                "c3968bef792c5668478ac01be7645b30", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/CoroutineFormatter.cs
                "b5b415c00da8157ac50b8f5543f0b1d9", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/GradientAlphaKeyFormatter.cs
                "8936a3e43078251682f18923139f7aee", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/GradientColorKeyFormatter.cs
                "d5b54660d5342fd45e2e43775538879d", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/GradientFormatter.cs
                "68ac0b27f571616d3ed26c23eef40c8c", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/KeyframeFormatter.cs
                "afc596cd95a1ac316024d16f6fec6536", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/LayerMaskFormatter.cs
                "558323987bf9b75943382a5faa093ee3", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/QuaternionFormatter.cs
                "196809b991e565a48e3d4ad08cb30b5e", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/RectFormatter.cs
                "c934302874ac3315ed322feefefa1f9c", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/UnityEventFormatter.cs
                "70c675a7b4c71c685ee39d745ccb058b", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/Vector2Formatter.cs
                "da2644647af1368176103aa87de1dbaf", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/Vector3Formatter.cs
                "60afa8ede3981c383782a01ddc55e943", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/Vector4Formatter.cs
                "ff1ca109149d83b03b39644f8045275e", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/IOverridesSerializationFormat.cs
                "8942002e9ac41c2bfd27c4fbedf93f09", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/IOverridesSerializationPolicy.cs
                "7279ec8ad7837f13ec833193ab4282cc", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/ISupportsPrefabSerialization.cs
                "ea095023abd05a7af0da4166dcefdee8", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/SerializationData.cs
                "c3cecb461cebbc940ede3b5ddb72382e", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/SerializedBehaviour.cs
                "56b88cfe9935184fe250bda018144f26", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/SerializedComponent.cs
                "d1b9fa6342beb9fdfc2c4bc1d8e5e971", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/SerializedMonoBehaviour.cs
                "6cb9325ffffee5d6ed94d71590b4049a", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/SerializedScriptableObject.cs
                "eefcd68a84ee7903b08c6254c17fafe3", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/SerializedStateMachineBehaviour.cs
                "d62f7ab4e5aa075b819d6c71e929686b", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/SerializedUnityObject.cs
                "78ce67c0b3c1975c520a08d1ff9fd24e", // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/FieldInfoExtensions.cs
                "068f5645a5c3f9ce36a580ec57e775d1", // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/GarbageFreeIterators.cs
                "0f84614827ff91701149564447a3932b", // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/LinqExtensions.cs
                "62088a9c188c943eb4035de16eb6ec32", // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/MemberInfoExtensions.cs
                "63a9a0384a6fe66fb04f82f325895b30", // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/MethodInfoExtensions.cs
                "1df9513f03131466eecad22d1b19c4d8", // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/Operator.cs
                "da8aea12015a2df5402c9e2d4f1cec5c", // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/PathUtilities.cs
                "7f13450d6fd82372ffa7ee075a8eb4c9", // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/PropertyInfoExtensions.cs
                "b554cbd9469011b544a2d92ae85a3b60", // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/StringExtensions.cs
                "a6a172cef14a88c7fb714df37bbecedb", // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/TypeExtensions.cs
                "eb77f5278e425e91b71e186df29a5f16", // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/UnityExtensions.cs
                "787c97af872124f748a4a9b366f325d3", // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/AssemblyImportSettingsUtilities.cs
                "146b6bd1e3b0f0926205abf839ec9e6f", // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/Cache.cs
                "1bd625694c606aab0cb7895da4911c6a", // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/DoubleLookupDictionary.cs
                "bda92ec6156282448e883bf8f6a781fd", // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/EmitUtilities.cs
                "570028979953bd2c60b7e89ff7cef92e", // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/FastTypeComparer.cs
                "42e5d977e21c7a6524213a8a7dbee24a", // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/Flags.cs
                "783316da32d87acfae14953e341732a3", // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/ICacheNotificationReceiver.cs
                "1bc635f3755c60fe69f1895dd53974e2", // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/ImmutableList.cs
                "000592e93b119574207ea3bf59f659e4", // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/MemberAliasFieldInfo.cs
                "c1e85c1ef449ccb40e05f0afd3dd717f", // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/MemberAliasMethodInfo.cs
                "00bf47593f2a330c1bb41552bdc1233f", // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/MemberAliasPropertyInfo.cs
                "5ad884ed6013d621a310ceb4c954f62a", // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/ReferenceEqualityComparer.cs
                "0fe3820fb4651e200f17905245ec8be2", // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/UnityVersion.cs
                "93b4d01199b118896c756b09a9206fc0", // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/UnsafeUtilities.cs
                "f6cfa3d8ec4f885468d17f5b023d2529", // Assets/Udon/WrapperModules/ExternVRCInstantiate.cs

                #endregion

                #region UdonSharp

                "c333ccfdd0cbdbc4ca30cef2dd6e6b9b", // Assets/UdonSharp/Editor/UdonSharpProgramAsset.cs

                #endregion

                #region VitDeck

                "6ca6388f2eb7b124c9822f0ec18507ee", // Assets/VitDeck/Validator/Runtime/BoundsIndicators/BoothRangeIndicator.cs
                "61a91fd6b14a4c74d8def021d6ac569b", // Assets/VitDeck/Validator/Runtime/BoundsIndicators/BoundsRangeOutIndicator.cs
                "087a446a9975ddb46a8258b730da5b4a", // Assets/VitDeck/Validator/Runtime/BoundsIndicators/ColliderBoundsSource.cs
                "ff83b2b8a00549b44917c8d655d8d986", // Assets/VitDeck/Validator/Runtime/BoundsIndicators/IBoothBoundsProvider.cs
                "fd2ce3eee33700a41882b61a9f0ab570", // Assets/VitDeck/Validator/Runtime/BoundsIndicators/IBoundsSource.cs
                "d94df5fc33543984b847883374ecd8f6", // Assets/VitDeck/Validator/Runtime/BoundsIndicators/LightProbeBoundsSource.cs
                "934a5f28e95c42347b819e98e4da1030", // Assets/VitDeck/Validator/Runtime/BoundsIndicators/RectTransformRangeOutIndicator.cs
                "98a472ef355204d4bb8ea4843d56ca71", // Assets/VitDeck/Validator/Runtime/BoundsIndicators/RendererBoundsSource.cs
                "ed421118c3b307d45a120e16c922b98a", // Assets/VitDeck/Validator/Runtime/BoundsIndicators/ResetToken.cs
                "1aa83c466a8ea1e4ba2e7f307c221a3f", // Assets/VitDeck/Validator/Runtime/BoundsIndicators/ResetTokenSource.cs
                "4919afe7ffcff8544bc0a71dc7451fc5", // Assets/VitDeck/Validator/Runtime/BoundsIndicators/TransformMemory.cs
                "af1597e2617a95e4a9d30a3020a864ee", // Assets/VitDeck/Validator/Runtime/BoundsIndicators/TransformRangeOutIndicator.cs

                #endregion

                #region VitDeck Templates SharedAssets

                "762ec8e0068722147bde7138cf8b2808", // Assets/VitDeck/Templates/07_UC/SharedAssets/CustomReflection(07_UC).exr
                "93ef499a9d942ef4d8ac40bf05328f7e", // Assets/VitDeck/Templates/07_UC/SharedAssets/Floor(07_UC).fbx
                "852b1a8f6b8cf714ab105ed0b009020c", // Assets/VitDeck/Templates/07_UC/SharedAssets/FloorGrid(07_UC).mat
                "e302a7dfcc30b4e488fe7119a1e3a414", // Assets/VitDeck/Templates/07_UC/SharedAssets/FloorGrid(07_UC).png
                "d3d89b9ab72ef0d4696365b9fd07f7de", // Assets/VitDeck/Templates/07_UC/SharedAssets/Post-process Volume Profile(07_UC).asset
                "43952b04c671c85499219a62eb939303", // Assets/VitDeck/Templates/07_UC/SharedAssets/SampleBooth(07_UC).mat
                "262f8e55a8b27584092f4aef6a6ee290", // Assets/VitDeck/Templates/07_UC/SharedAssets/Skybox(07_UC).mat
                "fe9c6cf6073f2514e82259a4142d6932", // Assets/VitDeck/Templates/07_UC/SharedAssets/UC_WorldSetting.asset
                "e23af24be2b1e7d40955d52dfad73f75", // Assets/VitDeck/Templates/07_UC/TemplateAssets/{CIRCLEID}/{CIRCLEID}.unity
                "100bf51bc40cf3247937686b55939dcd", // Assets/VitDeck/Templates/07_UC/TemplateAssets/{CIRCLEID}/UdonScript/Dummy.asset

                #endregion

                #region VketAssets

                "0de3ccc1017c4a045a4fed5f810c2748", // Assets/VketAssets/Prefabs/AvatarPedestal/Materials/UI-Lookat.mat
                "d35acdd70bdcab445bbbd6deac832a3b", // Assets/VketAssets/Prefabs/AvatarPedestal/Shaders/UI-Lookat.shader
                "834f21d704cafe3498f4d2ecc38dc5ea", // Assets/VketAssets/Prefabs/AvatarPedestal/Textures/Background.png
                "86487b9f4f81a774a9c49d53278c76cf", // Assets/VketAssets/Prefabs/AvatarPedestal/Textures/Button.png
                "62f7352a395147043809a2d315af37ae", // Assets/VketAssets/Prefabs/AvatarPedestal/Textures/Change Avatar.png
                "96c692c63aeba764081c1e04790fd3f1", // Assets/VketAssets/Prefabs/AvatarPedestal/Textures/Sample.png
                "2c70a653a699f5c4b9c51c2160786525", // Assets/VketAssets/Prefabs/CirclePageOpener/Components/CirclePageOpener.dll
                "171b9d597b1e63f4590b8d754491769a", // Assets/VketAssets/Prefabs/CirclePageOpener/Textures/BUY.png
                "109a7475f1e5fd74ea8ac3ebd42ab182", // Assets/VketAssets/Prefabs/VketLauncher/VketLauncher.dll
                "59261512e4100df488de6ddd9b530829", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_2D_L.prefab
                "3e6652d46d6d66d4092650094b064987", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_2D_M.prefab
                "87a721a2eb0c25643a5eb305781dc3a8", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_2D_S.prefab
                "104b8771f1874de40bf91473c2afb5ec", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_3D_L.prefab
                "2cdd22b46ff13f2409e7dd60e077eed7", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_3D_M.prefab
                "045501f8edaa2e748857c6c17a96b2f1", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_3D_S.prefab
                "d7a2d6aa4218cdd45854cd81900deba6", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_Default_L.prefab
                "8134e8c0ab5943a479b31c509f2325fb", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_Default_M.prefab
                "fb107661b9b479d4fa95452f7fd46426", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_Default_S.prefab
                "0294f3138a383d44188238141e43a0d2", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/Animation/Active_2D.anim
                "8ecf1c1367fda5c45b707eaaf1e6e300", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/Animation/Active_3D.anim
                "826602674183e284685c8212ca89f3ca", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/Animation/AvatarPedestal_2D.controller
                "8dd57fafbfdbd5146b2e808a8b28a2ea", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/Animation/AvatarPedestal_3D.controller
                "cc64c7910ebf50249bc5cfdc65ba4729", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/Animation/Deactive_2D.anim
                "68bbad9fbab0708449c847419d62a17e", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/Animation/Deactive_3D.anim
                "6b468349f6cba0248a76b7d33570fbad", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/Animation/Idle_2D.anim
                "8d5e148b91b24cf4dae7e22e010f7603", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/Animation/Idle_3D.anim
                "8efcb83444471ae4f99c5f5fecdd3e6e", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/Scripts/AvatarPedestal Udon C# Program Asset.asset
                "0d2cf2386895ff5499a1660a4327ad75", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/Scripts/AvatarPedestal.asset
                "63af405779b7d6d44b64d709fb3fbdd7", // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/CirclePageOpener2D_L.prefab
                "ae8b674ab5516664ea5d5c535f5fbc6a", // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/CirclePageOpener2D_M.prefab
                "405b6beaa9b7b9947b9111840f170452", // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/CirclePageOpener2D_S.prefab
                "139aa3624bf91214dabb39362ccf4382", // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/CirclePageOpener3D_L.prefab
                "4cb05397779ec7a48818e05b68c26960", // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/CirclePageOpener3D_M.prefab
                "a4471dc2b540f9e46a5e36fe66ede5e9", // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/CirclePageOpener3D_S.prefab
                "cfec853519dd4de4690152f16894cd49", // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/ItemPageOpener2D.prefab
                "91bb88e5f85d499488ebe6a238b396a3", // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/ItemPageOpener3D.prefab
                "af49ba9be5e5e2149b9c6dfa6decec82", // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/Animations/Active_2D.anim
                "f770e16ed5ac5c149b9e34d271b9fea4", // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/Animations/Active_3D.anim
                "251fd152628ba744899b986ab59ff7d3", // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/Animations/CirclePageOpener_2D.controller
                "886d4cde2c016cb4c9ea42c0af58f717", // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/Animations/CirclePageOpener_3D.controller
                "495ce3af8d25dcd49ab1eb9da5692373", // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/Animations/Deactive_2D.anim
                "a41d2fdf7f5e5eb49ab85919cf41e188", // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/Animations/Deactive_3D.anim
                "f93cc62348e48c64cbdb3a9b069a1d11", // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/Animations/Idle_2D.anim
                "ff7931a8fe75c2142a4e83797c8c21e9", // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/Animations/Idle_3D.anim
                "26ac8287216792149b49a2db74fc0309", // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/Animations/Open_2D.anim
                "72fddf1509a7339498051122d1da2ce5", // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/Animations/Open_3D.anim
                "64d15967613adfa44a4c6926b6b9d714", // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/Scripts/CirclePageOpener Udon C# Program Asset.asset
                "6ea1e8fa7533f9647996810212fa976e", // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/Scripts/CirclePageOpener.asset
                "304812fb2352c7c419581d8f68b23f94", // Assets/VketAssets/UdonPrefabs/Udon_PickupObjectSync/PickupObjectSync.prefab
                "e3fd1bb74f6500f4aac868dd0c369b03", // Assets/VketAssets/UdonPrefabs/Udon_PickupObjectSync/Scripts/AutoResetPickup Udon C# Program Asset.asset
                "73398b290b7c5ec43a2e158bfc1c45db", // Assets/VketAssets/UdonPrefabs/Udon_PickupObjectSync/Scripts/AutoResetPickup.asset
                "47accc564d52c0e4abc61201a680477a", // Assets/VketAssets/UdonPrefabs/Udon_WorldBGMFade/FadeIn.anim
                "f3c75b315c1b019409bf422bfa5ac0fc", // Assets/VketAssets/UdonPrefabs/Udon_WorldBGMFade/FadeOut.anim
                "79cc3ed8171a44e44a01c2100e57cb0b", // Assets/VketAssets/UdonPrefabs/Udon_WorldBGMFade/Idle.anim
                "4f06c6b6d95c99e4c9eba1761a599fd6", // Assets/VketAssets/UdonPrefabs/Udon_WorldBGMFade/WorldBGMFade.controller
                "e6d5c31911ec7404e8b613767bc9c944", // Assets/VketAssets/UdonPrefabs/Udon_WorldBGMFade/WorldBGMFade.prefab

                "31bd08cb1c9908742ab7ced575f28811", // Assets/VketAssets/VketAssets/VketPrefabs/PrefabAssets/Scripts/VketUdonControl.cs

                "9ade6bede296164498060af8ff1eb032", // Assets/VketAssets/VketPrefabs/AudioVolumeSample/vket6_booth_samplemusic_-14lufs_-3db.ogg

                "3c0dbec26839f9b4ea24f9606ec62ce4", // Assets/VketAssets/VketPrefabs/UITemplate/UI_Button.prefab
                "b4625b5c33c27804d889d16704b81c33", // Assets/VketAssets/VketPrefabs/UITemplate/UI_Image.prefab
                "4dc5396d6e370ef4fa9b9e9458c3f735", // Assets/VketAssets/VketPrefabs/UITemplate/UI_Text.prefab
                "333992c7f0890014d9a775e3f2303857", // Assets/VketAssets/VketPrefabs/UITemplate/UI_TextMeshPro.prefab

                "eba1c3ea387350c4681877ab193d1761", // Assets/VketAssets/VketPrefabs/UITemplate/FontAssets/Mplus1-Regular SDF.asset

                "d410c15388ebb13449d51bca1b8724aa", // Assets/VketAssets/Fonts/Mplus1-Regular.ttf

                "da2f193786576d041aa8d2e860314c22", // Assets/VketAssets/VketPrefabs/VketAvatarPedestal/VketAvatarPedestal_2D.prefab
                "9fffe84a94533884eaf481963546643d", // Assets/VketAssets/VketPrefabs/VketAvatarPedestal/VketAvatarPedestal_3D.prefab
                "1e0f83d3ba1d83045866a6a4dc2e8e83", // Assets/VketAssets/VketPrefabs/VketAvatarPedestal/VketAvatarPedestal_Default.prefab

                "0294f3138a383d44188238141e43a0d2", // Assets/VketAssets/VketPrefabs/VketAvatarPedestal/Animations/Active_2D.anim
                "8ecf1c1367fda5c45b707eaaf1e6e300", // Assets/VketAssets/VketPrefabs/VketAvatarPedestal/Animations/Active_3D.anim
                "826602674183e284685c8212ca89f3ca", // Assets/VketAssets/VketPrefabs/VketAvatarPedestal/Animations/AvatarPedestal_2D.controller
                "2f0b20cb1dadf3c498b1272896dd3ba5", // Assets/VketAssets/VketPrefabs/VketAvatarPedestal/Animations/AvatarPedestal_3D.controller
                "cc64c7910ebf50249bc5cfdc65ba4729", // Assets/VketAssets/VketPrefabs/VketAvatarPedestal/Animations/Deactive_2D.anim
                "68bbad9fbab0708449c847419d62a17e", // Assets/VketAssets/VketPrefabs/VketAvatarPedestal/Animations/Deactive_3D.anim
                "6b468349f6cba0248a76b7d33570fbad", // Assets/VketAssets/VketPrefabs/VketAvatarPedestal/Animations/Idle_2D.anim
                "8d5e148b91b24cf4dae7e22e010f7603", // Assets/VketAssets/VketPrefabs/VketAvatarPedestal/Animations/Idle_3D.anim

                "62a7876d06fb1d645ab6cb81d87d0a3a", // Assets/VketAssets/VketPrefabs/VketAvatarPedestal/Scripts/VketAvatarPedestal.asset
                "ebe3df2ed38fdfd479e2fce1c5403a74", // Assets/VketAssets/VketPrefabs/VketAvatarPedestal/Scripts/VketAvatarPedestal.cs

                "62f7352a395147043809a2d315af37ae", // Assets/VketAssets/VketPrefabs/VketAvatarPedestal/Textures/Change Avatar.png
                "96c692c63aeba764081c1e04790fd3f1", // Assets/VketAssets/VketPrefabs/VketAvatarPedestal/Textures/Sample.png

                "26e911c1e4e64964ea73100994e7c984", // Assets/VketAssets/VketPrefabs/VketLanguageSwitcher/Scripts/VketLanguageSwitcher.asset
                "450cb8826e2f672478ba0b27310dd446", // Assets/VketAssets/VketPrefabs/VketLanguageSwitcher/Scripts/VketLanguageSwitcher.cs

                "7f697f0a5403d864a9240a9f0d1e83e4", // Assets/VketAssets/VketPrefabs/VketLanguageSwitcher/Textures/SwitchToEnglish.png
                "1e87d7c02aa11184aab67f6998f6a03b", // Assets/VketAssets/VketPrefabs/VketLanguageSwitcher/Textures/SwitchToJapanese.png

                "8c011f4ab9cc45c4aaddb76bbd8003c5", // Assets/VketAssets/VketPrefabs/VketLanguageSwitcher/VketLangageSwitcher.prefab

                "3ffeb968a1d1ed244b45c026bb22f30b", // Assets/VketAssets/VketPrefabs/VketPickup/Animations/ModeController.controller
                "be21e07eff32d7e4fbbf7babfed27d88", // Assets/VketAssets/VketPrefabs/VketPickup/Animations/PickupAnimation.fbx

                "ab981b08fcfada8458fc2ec950e16e17", // Assets/VketAssets/VketPrefabs/VketPickup/Scripts/VketFollowPickup.asset
                "57498a849a57d5e44bb3fea02cfabbad", // Assets/VketAssets/VketPrefabs/VketPickup/Scripts/VketFollowPickup.cs
                "fc11049e6474c5e47bc42f47d1a8efca", // Assets/VketAssets/VketPrefabs/VketPickup/Scripts/VketPickup.asset
                "b5d9b5598ab43f64e8aca7422be14f5c", // Assets/VketAssets/VketPrefabs/VketPickup/Scripts/VketPickup.cs

                "6893d5acfbed8d544856d8eb7cc11133", // Assets/VketAssets/VketPrefabs/VketPickup/AnimationOverrideEmpty.overrideController
                "ba410268b82f1d940aedd0d418541c83", // Assets/VketAssets/VketPrefabs/VketPickup/VketFollowPickup.prefab
                "6d1e9170d4533ed448e46b707a3ee47a", // Assets/VketAssets/VketPrefabs/VketPickup/VketPickup.prefab

                "d6755e37e53268542aae9bd79954a6ab", // Assets/VketAssets/VketPrefabs/VketSoundFade/Scripts/VketSoundFade.asset
                "2a96b9847fc7b3a4cb515cee9955948c", // Assets/VketAssets/VketPrefabs/VketSoundFade/Scripts/VketSoundFade.cs

                "b2a6c13adeda05d40adb398906d58645", // Assets/VketAssets/VketPrefabs/VketSoundFade/VketSoundFade.prefab

                "7c77782274e76654e8cd0aefdfb978ab", // Assets/VketAssets/VketPrefabs/VketTriggerSample/SampleAssets/AnimationMove.anim
                "c227fd2cc782eef47abc5da50df7eebb", // Assets/VketAssets/VketPrefabs/VketTriggerSample/SampleAssets/Animator.controller
                "2db0d4bdf2e175a45bfea9d196e184f8", // Assets/VketAssets/VketPrefabs/VketTriggerSample/SampleAssets/InteractActive.asset
                "107c77d0ec82f9d4e83bfb68de193341", // Assets/VketAssets/VketPrefabs/VketTriggerSample/SampleAssets/InteractAnimation.asset

                "20cf75c90d5e1dc459b132ea44e65c72", // Assets/VketAssets/VketPrefabs/VketTriggerSample/VketTriggerSample.unity

                "5426b85d610dd5a4990a6965e3716f2d", // Assets/VketAssets/VketPrefabs/VketVideoPlayer/Scripts/VketVideoPlayer.asset
                "9e731e574c230934d9ae7df37f8a2603", // Assets/VketAssets/VketPrefabs/VketVideoPlayer/Scripts/VketVideoPlayer.cs

                "798bf62f082a7a64c9d48e6f992ecfaa", // Assets/VketAssets/VketPrefabs/VketVideoPlayer/Textures/DisabledVideoPlayerImage.mat
                "866f25587f50b85479e2cf4d2d197fee", // Assets/VketAssets/VketPrefabs/VketVideoPlayer/Textures/DisabledVideoPlayerImage.png
                "f8768f74f96d1df46be77f6093cafc26", // Assets/VketAssets/VketPrefabs/VketVideoPlayer/Textures/g_t2.png
                "232b8ac3d18030645a30cb20c9427da8", // Assets/VketAssets/VketPrefabs/VketVideoPlayer/Textures/t_a2.png

                "73b0727ab433c3140929fbf088cd8b88", // Assets/VketAssets/VketPrefabs/VketVideoPlayer/VketVideoPlayer.prefab

                "af49ba9be5e5e2149b9c6dfa6decec82", // Assets/VketAssets/VketPrefabs/VketWebPageOpener/Animations/Active_2D.anim
                "f770e16ed5ac5c149b9e34d271b9fea4", // Assets/VketAssets/VketPrefabs/VketWebPageOpener/Animations/Active_3D.anim
                "495ce3af8d25dcd49ab1eb9da5692373", // Assets/VketAssets/VketPrefabs/VketWebPageOpener/Animations/Deactive_2D.anim
                "a41d2fdf7f5e5eb49ab85919cf41e188", // Assets/VketAssets/VketPrefabs/VketWebPageOpener/Animations/Deactive_3D.anim
                "f93cc62348e48c64cbdb3a9b069a1d11", // Assets/VketAssets/VketPrefabs/VketWebPageOpener/Animations/Idle_2D.anim
                "ff7931a8fe75c2142a4e83797c8c21e9", // Assets/VketAssets/VketPrefabs/VketWebPageOpener/Animations/Idle_3D.anim
                "26ac8287216792149b49a2db74fc0309", // Assets/VketAssets/VketPrefabs/VketWebPageOpener/Animations/Open_2D.anim
                "72fddf1509a7339498051122d1da2ce5", // Assets/VketAssets/VketPrefabs/VketWebPageOpener/Animations/Open_3D.anim
                "251fd152628ba744899b986ab59ff7d3", // Assets/VketAssets/VketPrefabs/VketWebPageOpener/Animations/WebPageOpener_2D.controller
                "aac12a50b7cdf694eb2fc4defc7776da", // Assets/VketAssets/VketPrefabs/VketWebPageOpener/Animations/WebPageOpener_3D.controller

                "7704391c33fb5e44a9759bcae27b38a8", // Assets/VketAssets/VketPrefabs/VketWebPageOpener/Scripts/VketWebPageOpener.asset
                "e1e4c1b5ec275be4c832348eed80ecc7", // Assets/VketAssets/VketPrefabs/VketWebPageOpener/Scripts/VketWebPageOpener.cs

                "171b9d597b1e63f4590b8d754491769a", // Assets/VketAssets/VketPrefabs/VketWebPageOpener/Textures/BUY.png

                "5d4f49b1d4a5dca43b04aed3bc01b61f", // Assets/VketAssets/VketPrefabs/VketWebPageOpener/VketCirclePageOpener_2D.prefab
                "829918e636553bf489526e19e7c08a9f", // Assets/VketAssets/VketPrefabs/VketWebPageOpener/VketCirclePageOpener_3D.prefab
                "249a82240095e1a44b9b4aae5f72d41e", // Assets/VketAssets/VketPrefabs/VketWebPageOpener/VketItemPageOpener_2D.prefab
                "8b95eab6f59b5e64d9393292aca982ca", // Assets/VketAssets/VketPrefabs/VketWebPageOpener/VketItemPageOpener_3D.prefab

                #endregion

                #region VketShaderPack

                "917bb21acbedd3c49b3a66fee0e2a0cd", //Assets/VketShaderPack/ArxCharacterShaders/Changelog.txt
"10c126862b1dd7c4b975a244eae01be8", //Assets/VketShaderPack/ArxCharacterShaders/LICENSE
"09a5bf6d0f820794eac61eb205435d54", //Assets/VketShaderPack/ArxCharacterShaders/README.md
"02a5e10e436c65143afc3f55c8dccfa3", //Assets/VketShaderPack/ArxCharacterShaders/Editor/AxCommon.cs
"74c2419ffb2b7fc498b21f8a9a2abbf6", //Assets/VketShaderPack/ArxCharacterShaders/Editor/AxInspector.cs
"0571380a9e1852d4f9f5793db83f0b9e", //Assets/VketShaderPack/ArxCharacterShaders/Editor/AxTips.cs
"dcc2ee0355c9c784fb78055de8a258b4", //Assets/VketShaderPack/ArxCharacterShaders/Editor/Generator/AxGenerator.cs
"bccf1a29daed7e347a5365f4ef9714aa", //Assets/VketShaderPack/ArxCharacterShaders/Shaders/Cutout.shader
"9ce3973bae37a5c43a3c22309be11936", //Assets/VketShaderPack/ArxCharacterShaders/Shaders/EmissiveFreak_Cutout.shader
"9a50e49ef4da46f42869e7bb359e38ae", //Assets/VketShaderPack/ArxCharacterShaders/Shaders/EmissiveFreak_Fade.shader
"64c7ca6ee0374bb49928cc04ae72e564", //Assets/VketShaderPack/ArxCharacterShaders/Shaders/EmissiveFreak_FadeRefracted.shader
"f64626cad72e22a4d9c5b9f2edcae765", //Assets/VketShaderPack/ArxCharacterShaders/Shaders/EmissiveFreak_Opaque.shader
"82b077c6cd0a1bf49924f2e40bbaa11a", //Assets/VketShaderPack/ArxCharacterShaders/Shaders/EmissiveFreak_StencilReader_Cutout.shader
"2f13f85e17b00034082d64dcb9f7e465", //Assets/VketShaderPack/ArxCharacterShaders/Shaders/EmissiveFreak_StencilReader_DoubleFade.shader
"efa8f9f56db47404997e88b85819baea", //Assets/VketShaderPack/ArxCharacterShaders/Shaders/EmissiveFreak_StencilReader_Fade.shader
"745457dca56c6574fba900c741151b79", //Assets/VketShaderPack/ArxCharacterShaders/Shaders/EmissiveFreak_StencilReader_FadeRefracted.shader
"8f7fc78e18d31314daa105489df1315e", //Assets/VketShaderPack/ArxCharacterShaders/Shaders/EmissiveFreak_StencilWriter_Cutout.shader
"d6d2255661809bc4e87babd1a8edaff6", //Assets/VketShaderPack/ArxCharacterShaders/Shaders/Fade.shader
"0c89b4121f71eb546abb7748e6c7d25f", //Assets/VketShaderPack/ArxCharacterShaders/Shaders/FadeRefracted.shader
"acaabbe907212b94c85ab392bb1306a1", //Assets/VketShaderPack/ArxCharacterShaders/Shaders/Opaque.shader
"ed3ee25e40abe154ea5386166422d8fd", //Assets/VketShaderPack/ArxCharacterShaders/Shaders/Outline_Cutout.shader
"844a9d3f6c0fa1044abe14728e14e7e9", //Assets/VketShaderPack/ArxCharacterShaders/Shaders/Outline_EmissiveFreak_Cutout.shader
"ed627574387225c449eaccd6fdbc6d15", //Assets/VketShaderPack/ArxCharacterShaders/Shaders/Outline_EmissiveFreak_Opaque.shader
"f14d4aa117bff4e4e8626947f279fc44", //Assets/VketShaderPack/ArxCharacterShaders/Shaders/Outline_EmissiveFreak_StencilReader_Cutout.shader
"8da7952f673810b41afcb4fb3dbe2673", //Assets/VketShaderPack/ArxCharacterShaders/Shaders/Outline_EmissiveFreak_StencilWriter_Cutout.shader
"87d1c60aa88359946943a8f85f3f67ce", //Assets/VketShaderPack/ArxCharacterShaders/Shaders/Outline_Opaque.shader
"4c3618b923505674184591106c01b13d", //Assets/VketShaderPack/ArxCharacterShaders/Shaders/Outline_StencilReader_Cutout.shader
"49071b1dd6dced84ebbae1ad62c386c5", //Assets/VketShaderPack/ArxCharacterShaders/Shaders/Outline_StencilWriter_Cutout.shader
"034f74b4fdca8cc4a941b0de9ce3616f", //Assets/VketShaderPack/ArxCharacterShaders/Shaders/StencilReader_Cutout.shader
"e8cd3ae42f616ee48875891991c1ecad", //Assets/VketShaderPack/ArxCharacterShaders/Shaders/StencilReader_DoubleFade.shader
"727d200179b6d6c469453149d0678cd5", //Assets/VketShaderPack/ArxCharacterShaders/Shaders/StencilReader_Fade.shader
"b1e4cf9f03cc70a4aa9ec9f8b26c967e", //Assets/VketShaderPack/ArxCharacterShaders/Shaders/StencilReader_FadeRefracted.shader
"1adb078ef83bc634d91fa5a5e4961844", //Assets/VketShaderPack/ArxCharacterShaders/Shaders/StencilWriter_Cutout.shader
"88114f823868e46499f38529e274c874", //Assets/VketShaderPack/ArxCharacterShaders/Shaders/cginc/arkludeAdd.cginc
"53197a94cb19cef4f87146e3a60dcbd0", //Assets/VketShaderPack/ArxCharacterShaders/Shaders/cginc/arkludeDecl.cginc
"6279286c116b40c4b89f4515985a80db", //Assets/VketShaderPack/ArxCharacterShaders/Shaders/cginc/arkludeFadeShadowCaster.cginc
"bcb34ccca9630de43803b596ab9fb33d", //Assets/VketShaderPack/ArxCharacterShaders/Shaders/cginc/arkludeFrag.cginc
"6c29e94a661d9564f81f237f71561d0c", //Assets/VketShaderPack/ArxCharacterShaders/Shaders/cginc/arkludeFragOnlyStencilWrite.cginc
"58d2bd24894859c40bb08f1c498b8773", //Assets/VketShaderPack/ArxCharacterShaders/Shaders/cginc/arkludeOther.cginc
"347c7b749e91cff4cb7b0751b8f7ec9c", //Assets/VketShaderPack/ArxCharacterShaders/Shaders/cginc/arkludeVertGeom.cginc
"bea93105aa1daac43974972a792f133f", //Assets/VketShaderPack/ArxCharacterShaders/Textures/Ramps.ai
"9384d986d3c93e84b896716821787d47", //Assets/VketShaderPack/ArxCharacterShaders/Textures/Ramp_1.png
"f848c68db2ea54546905195e13b42731", //Assets/VketShaderPack/ArxCharacterShaders/Textures/Ramp_2.png
"a249399272899034eb992ad37ffd0b81", //Assets/VketShaderPack/ArxCharacterShaders/Textures/Ramp_3.png
"748abec0e90c15e4983b5d12f2f03917", //Assets/VketShaderPack/ArxCharacterShaders/Textures/Ramp_4.png
"c164a5690bb1f3646ae8b26e0d170783", //Assets/VketShaderPack/ArxCharacterShaders/Textures/Ramp_5.png
"5ddbcea7f4f05a44b87e3f5b7af74baa", //Assets/VketShaderPack/ArxCharacterShaders/Textures/Ramp_6.png
"05c75ecad50759a48afd09f49736b73b", //Assets/VketShaderPack/ArxCharacterShaders/Textures/Ramp_7.png
"242351f50fe050d40879c196cfd8b0a8", //Assets/VketShaderPack/ArxCharacterShaders/Textures/Ramp_Default.png
"82e13d2a938694aedb5dbb01bd3ecf07", //Assets/VketShaderPack/MMS3/LICENSE
"8dd7c14dadb834c4e8324f7d08c5674e", //Assets/VketShaderPack/MMS3/MMS3.shader
"128f4720891e8914ab7e6673099df0f0", //Assets/VketShaderPack/MMS3/MMS3_Cutout.shader
"fbaec084851cef64fbd877b3b15716cb", //Assets/VketShaderPack/MMS3/MMS3_Outline.shader
"f889d00a055a0488e9ecbf22c558ae76", //Assets/VketShaderPack/MMS3/MMS3_Stencil_Reader.shader
"f55508f2ed8cc477f9574099971bc4eb", //Assets/VketShaderPack/MMS3/MMS3_Stencil_Writer.shader
"fda424b70f79d4e5488e1cc3ee100a95", //Assets/VketShaderPack/MMS3/MMS3_Transparent.shader
"ece969dbfb97d446ba8f8358a78789b5", //Assets/VketShaderPack/MMS3/Shade_Matcap1.psd
"d419788b84c0ad84080f188bcd8d724f", //Assets/VketShaderPack/Mochie/LICENSE.txt
"909b3ce927e8cf246b13b1dbdef33f62", //Assets/VketShaderPack/Mochie/Common/Color.cginc
"d5468ef40ceedc549a0911e23c0b1568", //Assets/VketShaderPack/Mochie/Common/Noise.cginc
"66399fdb22339fe4daa7700e36ae9465", //Assets/VketShaderPack/Mochie/Common/Sampling.cginc
"71a928ffb0de3b442ab7e52a33f42d54", //Assets/VketShaderPack/Mochie/Common/Utilities.cginc
"cddaa3a02eb956746b502b80b76e92bc", //Assets/VketShaderPack/Mochie/Mochie Standard/Mochie Standard.shader
"e1e688f8a6bee854cbf34c599989d152", //Assets/VketShaderPack/Mochie/Mochie Standard/MochieStandardBRDF.cginc
"3bb158287983274479b31131c42d344b", //Assets/VketShaderPack/Mochie/Mochie Standard/MochieStandardCore.cginc
"b65452b9b58de00458966db7c742a120", //Assets/VketShaderPack/Mochie/Mochie Standard/MochieStandardCoreForward.cginc
"8fa3c40715f92f34796f3658af91c019", //Assets/VketShaderPack/Mochie/Mochie Standard/MochieStandardInput.cginc
"65625153f0e17f645bbe3a88be64e27d", //Assets/VketShaderPack/Mochie/Mochie Standard/MochieStandardParallax.cginc
"77a161d297d8ae6469a456c3173c84c3", //Assets/VketShaderPack/Mochie/Mochie Standard/MochieStandardShadow.cginc
"bbbf9947de0eb8f4aa275f897aa4353b", //Assets/VketShaderPack/Mochie/Mochie Standard/MochieStandardSSR.cginc
"74e814afd5b766447b0de37c532cc8f9", //Assets/VketShaderPack/Mochie/Particle Shader/Particles.shader
"d1c93822d1541934c8fa436a39f0351a", //Assets/VketShaderPack/Mochie/Particle Shader/PSDefines.cginc
"56a4a30195ab7a4459b604ae189b3ccd", //Assets/VketShaderPack/Mochie/Particle Shader/PSFunctions.cginc
"c46a10d001a1d1b4fa634b7e561639ad", //Assets/VketShaderPack/Mochie/Particle Shader/PSKeyDefines.cginc
"0d1d977ca72938b4bb8f3ed06b9a8645", //Assets/VketShaderPack/Mochie/ScreenFX Shader/SFX.shader
"0622846791c27d3499465434f2f63a0f", //Assets/VketShaderPack/Mochie/ScreenFX Shader/SFXBlur.cginc
"e06fb4e15a03e164dae45a93c3ab3591", //Assets/VketShaderPack/Mochie/ScreenFX Shader/SFXDefines.cginc
"e51e722628c0c834f841cbca164dc53b", //Assets/VketShaderPack/Mochie/ScreenFX Shader/SFXFunctions.cginc
"7cbe4084658fd6b4e8b73782d48a461d", //Assets/VketShaderPack/Mochie/ScreenFX Shader/SFXKernel.cginc
"b78f95f931b33c846b19851684cd7cdc", //Assets/VketShaderPack/Mochie/ScreenFX Shader/SFXKeyDefines.cginc
"9a10756a86708fc4f840711e05cf723c", //Assets/VketShaderPack/Mochie/ScreenFX Shader/SFXPass.cginc
"4bd03e585f1830247a19f1af0893e73f", //Assets/VketShaderPack/Mochie/ScreenFX Shader/SFXXFeatures.cginc
"87a52d53f3012e448b23af4d55a79d02", //Assets/VketShaderPack/Mochie/ScreenFX Shader/SFXXPasses.cginc
"b252ff402bce931488cf8ff5152bf2dc", //Assets/VketShaderPack/Mochie/Uber Shader/Uber (Outline).shader
"5398f14cd241f2649988529db4480d1c", //Assets/VketShaderPack/Mochie/Uber Shader/Uber.shader
"21947c9bef25458429000c46ca32e021", //Assets/VketShaderPack/Mochie/Uber Shader/USBRDF.cginc
"6cd01882b763be542be24bd25c155871", //Assets/VketShaderPack/Mochie/Uber Shader/USDefines.cginc
"6e016b6a7bd29c24581e80488f391a0e", //Assets/VketShaderPack/Mochie/Uber Shader/USFunctions.cginc
"6390189603c02114c9822185832e97fc", //Assets/VketShaderPack/Mochie/Uber Shader/USKeyDefines.cginc
"a517223ef2cd6074b9947340447724b9", //Assets/VketShaderPack/Mochie/Uber Shader/USLighting.cginc
"b6948e44e1f92fc4891f424daf8e7bfd", //Assets/VketShaderPack/Mochie/Uber Shader/USPass.cginc
"4ec15cb7a78843d4fb5c7c8bdf19bd9b", //Assets/VketShaderPack/Mochie/Uber Shader/USSSR.cginc
"76eed4008ba5d464199dcfc895daf3b7", //Assets/VketShaderPack/Mochie/Uber Shader/USXFeatures.cginc
"1da8bba388ad86741b84e6899d501ca7", //Assets/VketShaderPack/Mochie/Uber Shader/USXGeom.cginc
"d9b054af17135c745adff39d435e039d", //Assets/VketShaderPack/Mochie/Unity/Editor/Foldouts.cs
"2adee688b156d3c4f9c32a71869329ed", //Assets/VketShaderPack/Mochie/Unity/Editor/KeywordHunter.cs
"2f59b3e0bf10120419b941583795ef54", //Assets/VketShaderPack/Mochie/Unity/Editor/MGUI.cs
"07e2014e25903e548b0e102aebc5851f", //Assets/VketShaderPack/Mochie/Unity/Editor/MochieStandardGUI.cs
"fdc00d0c66b6f3f4eb834fd87b6d760c", //Assets/VketShaderPack/Mochie/Unity/Editor/PSEditor.cs
"4689d28cb77840b488838b0a89f5dd78", //Assets/VketShaderPack/Mochie/Unity/Editor/SFXEditor.cs
"566cd2268c7d9194087322ca64b68f61", //Assets/VketShaderPack/Mochie/Unity/Editor/Toggles.cs
"eed6a60c5f8da544690d739b516ada01", //Assets/VketShaderPack/Mochie/Unity/Editor/USEditor.cs
"497f8485774204244abb7ba6c0865927", //Assets/VketShaderPack/Mochie/Unity/Prefabs/Default.mat
"3bb643d832d69134f8fbea4efcd0e109", //Assets/VketShaderPack/Mochie/Unity/Prefabs/Depth Light.prefab
"cd555b15b892a6342821da231de50d42", //Assets/VketShaderPack/Mochie/Unity/Prefabs/Screen FX.prefab
"c5eaa139ce0fb7c4b9ee2604697e997f", //Assets/VketShaderPack/Mochie/Unity/Resources/ClearTexIcon.png
"3e38383d19b750046a6fa03b1c2f8bac", //Assets/VketShaderPack/Mochie/Unity/Resources/CollapseIcon.png
"09c9c066a27ac424da976a9ae8474231", //Assets/VketShaderPack/Mochie/Unity/Resources/CopyTo1Icon.png
"124358866068baa4f90186cb87430c24", //Assets/VketShaderPack/Mochie/Unity/Resources/CopyTo2Icon.png
"b69d260e9a20c444cb3ac36d41d2d479", //Assets/VketShaderPack/Mochie/Unity/Resources/ExpandIcon.png
"d29b3eb8412f5e64096afc1ab733122d", //Assets/VketShaderPack/Mochie/Unity/Resources/Header.png
"29f18c82d04215e4f87185a100e9ff1b", //Assets/VketShaderPack/Mochie/Unity/Resources/Header_Pro.png
"1cbf300790ff57b4caf3fbe023eca45f", //Assets/VketShaderPack/Mochie/Unity/Resources/KeyIcon.psd
"f632ab1767b9c1e45b285c0731fbd1d8", //Assets/VketShaderPack/Mochie/Unity/Resources/KeyIcon_Pro.psd
"8f1c2bbd99970c841b096d9447417468", //Assets/VketShaderPack/Mochie/Unity/Resources/ParticleHeader.png
"ca6d24562e19aab4e90be114647a98bb", //Assets/VketShaderPack/Mochie/Unity/Resources/ParticleHeader_Pro.png
"31fef82c771a5374b904c64a98fde2ac", //Assets/VketShaderPack/Mochie/Unity/Resources/Patreon_Icon.png
"ec636ed50f955cc42a934e1bd42403d0", //Assets/VketShaderPack/Mochie/Unity/Resources/ResetIcon.png
"2201e3ff274d60b42ba46809810c7f0e", //Assets/VketShaderPack/Mochie/Unity/Resources/SFXHeader.png
"30a883d22a3859443a814b6bba897043", //Assets/VketShaderPack/Mochie/Unity/Resources/SFXHeader_Pro.png
"dff4b38eef00de14487e9ee7ee4359b0", //Assets/VketShaderPack/Mochie/Unity/Resources/StandardIcon.png
"21cb8a0fd46250e489c418eeff4a2222", //Assets/VketShaderPack/Mochie/Unity/Resources/Watermark.png
"0b25d34e04b2c7a4c98d9cc5c69fa830", //Assets/VketShaderPack/Mochie/Unity/Resources/Watermark_Pro.png
"7589d70a1d40b7c47857a6722e4a0aae", //Assets/VketShaderPack/Mochie/Unity/Textures/Blend.png
"89819f8cb0b9e5d418f6e90ca96ac9c3", //Assets/VketShaderPack/Mochie/Unity/Textures/Distortion.tif
"930ac9d4c358e5846af139e693a08bd2", //Assets/VketShaderPack/Mochie/Unity/Textures/Hair Normal.png
"2059b62900034054f9f93aafbf8293fb", //Assets/VketShaderPack/Mochie/Unity/Textures/Perlin (Alpha).jpg
"dfbb7eeed695dc14d82b08d887041406", //Assets/VketShaderPack/Mochie/Unity/Textures/Perlin.jpg
"b8d1261e60bcece48b7708cac8798bfc", //Assets/VketShaderPack/Mochie/Unity/Textures/Shake Noise.png
"b7359cc7e3e84444b88656ff6c166220", //Assets/VketShaderPack/Mochie/Unity/Textures/SSR Noise.png
"9c8ede69ecd0f824aa80b9929c0b1e5c", //Assets/VketShaderPack/Mochie/Unity/Textures/Transparent 4x4.png
"f276a76437cf84847a5986084b4d11f3", //Assets/VketShaderPack/Mochie/Unity/Textures/Ramps/DefaultRamp.png
"9674bc46ecefab84b9f135c13b18ce36", //Assets/VketShaderPack/Mochie/Unity/Textures/Ramps/RampImporter.cs
"2a5e8a5d481e3574b8274fa7ce4bdc2d", //Assets/VketShaderPack/MToon-3.6/LICENSE
"1021e7e6d453b9f4fb2f46a130425deb", //Assets/VketShaderPack/MToon-3.6/README.md
"a9bc101fb0471f94a8f99fd242fdd934", //Assets/VketShaderPack/MToon-3.6/MToon/MToon.asmdef
"24156f9da0724eb5a159f36c69a7d90a", //Assets/VketShaderPack/MToon-3.6/MToon/Editor/EditorEnums.cs
"531922bb16b74a00b81445116c49b09c", //Assets/VketShaderPack/MToon-3.6/MToon/Editor/EditorUtils.cs
"dddf8398e965f254cae2d7519d7f67d2", //Assets/VketShaderPack/MToon-3.6/MToon/Editor/MToon.Editor.asmdef
"8b43baa9f62f04748bb167ad186f1b1a", //Assets/VketShaderPack/MToon-3.6/MToon/Editor/MToonInspector.cs
"1a97144e4ad27a04aafd70f7b915cedb", //Assets/VketShaderPack/MToon-3.6/MToon/Resources/Shaders/MToon.shader
"ef6682d138947ed4fbc8fbecfe75cd28", //Assets/VketShaderPack/MToon-3.6/MToon/Resources/Shaders/MToonCore.cginc
"084281ffd8b1b8e4a8605725d3b0760b", //Assets/VketShaderPack/MToon-3.6/MToon/Resources/Shaders/MToonSM3.cginc
"17d4e0f990fbc794ab41e4fcc196d559", //Assets/VketShaderPack/MToon-3.6/MToon/Resources/Shaders/MToonSM4.cginc
"9a3fb070d7eb4114b5cf387e2cd60391", //Assets/VketShaderPack/MToon-3.6/MToon/Scripts/Enums.cs
"2849b99d94074fcf9e10c5ca3eab15a8", //Assets/VketShaderPack/MToon-3.6/MToon/Scripts/MToonDefinition.cs
"9d2012c170a74b3db0002f7ecda53622", //Assets/VketShaderPack/MToon-3.6/MToon/Scripts/Utils.cs
"6724aa45c8c349fabd5954a531301aa8", //Assets/VketShaderPack/MToon-3.6/MToon/Scripts/UtilsGetter.cs
"b24a672e82874c9fbfef9c2b2dfdab42", //Assets/VketShaderPack/MToon-3.6/MToon/Scripts/UtilsSetter.cs
"4702d4b2c1414cc08b4382c3762eebab", //Assets/VketShaderPack/MToon-3.6/MToon/Scripts/UtilsVersion.cs
"c6060936f19cacf47a848143c995221a", //Assets/VketShaderPack/Silent's Cel Shading Shader/LICENSE
"020a0e50634d4f4459abb3f7e7448eb3", //Assets/VketShaderPack/Silent's Cel Shading Shader/README.txt
"840c70bb39e48cc43a17ac9279a026d9", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/SCSS Logo.png
"80684a860e75c9a4295d27ead38010c7", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/LightRamps/Info.txt
"a7e8258f4d13af1419c0326602f31748", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/LightRamps/LightRamp Sharp.png
"70853d21e5cf0a945ba9ef1baa2f37fa", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/LightRamps/LightRamp Skin.png
"6af41be6e81954543bfe50e9b2131c4d", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/LightRamps/LightRamp Smooth (old).png
"6584ffcc7e2c6a746afd371ec1d6ad5d", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/LightRamps/LightRamp Smooth.png
"a8fbd87577f16ea43ac168bbf9ef88f3", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/LightRamps/LightRamp Soft (old).png
"51b142bdc7b4f7a428477e77eb815bc7", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/LightRamps/LightRamp Soft.png
"d0d2092a7d8176a419858a5536e205ee", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/LightRamps/LightRamp Toon v2.png
"7f445efa362f16248af955f190843381", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/LightRamps/LightRamp Toon v3.png
"ae6fa37de6d2b4e45a6176091e47455c", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/Mnmr/LICENSE.txt
"63a9cd46c7dd97644b42c0721976f257", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/Mnmr/Readme.txt
"fb2f01db930474c3fbd62634f03ffe4b", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/Mnmr/Matcap/MMS_Light_Hard.psd
"4348a2a80916845739da8629005aef03", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/Mnmr/Matcap/MMS_Light_Hard_Hair2.psd
"5306755cc52e04770bf7169839c6b350", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/Mnmr/Matcap/MMS_Light_Soft.psd
"1f802a1910910432ca435480b93e70ec", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/Mnmr/Matcap/MMS_Light_Soft_Hair.psd
"d247459fa9b47465d92f1eb93eba56e9", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/Mnmr/Matcap/MMS_RimLightMatcap1.psd
"c2dda37b49c0b4bde9e211e894f7344d", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/Mnmr/Matcap/MMS_RimLightMatcap2.psd
"44d209fdf321840569dd21a5b61e277d", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/Mnmr/Matcap/MMS_ShadowMatcap1.psd
"ecfa3da8397834305821fe311f1cbf15", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/Mnmr/Matcap/MMS_ShadowMatcap2.psd
"c68fab11bf4dfb044a2f51d7ddc4d064", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/mofuaki_/mofuaki_-1185084491351515136-img1.png
"48e16bad9d9551b499dfb08af7ee7e31", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/mofuaki_/mofuaki_-1185084491351515136-img2.png
"fb8f4c7cfbfa3f743b381bda894c2eb6", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/mofuaki_/mofuaki_-1185084491351515136.txt
"21e7d43547251ef4bb267a4aa24f04b7", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/mofuaki_/mofuaki_-1185084491351515136.url
"ebd77ce0e53676d49853f56eb043a827", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/LICENSE
"c855d2d0c1361d14a841af5aa24d6d26", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/README.txt
"b7b167660549b8e48a231f62d2fcb008", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Glare.png
"3dd155f12c76e1447bf62608fc1bf572", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Gloss(LargeFlat).png
"3dfb01f9d1c32f048ac838f6e3fa8810", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Gloss(LargePoint).png
"9a6b29adf08462e4f98ec4a45cc7c57c", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Gloss(MultiFlat).png
"bd882f7694bebd04eb144979a8787993", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Gloss(MultiPoint).png
"c6cbb49dcbadf93489feca05b6652723", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Gloss(SmallFlat).png
"b3d17e4df2a84274f8810d14ad0d1537", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Gloss(SmallPoint).png
"5866d4cb591aa9443b2cb4948139b112", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Hair_AngelRing(Blue).png
"a369076245553a64eb0f96d537272196", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Hair_AngelRing(Green).png
"a8845002a4d852249b1f5b2d0422279c", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Hair_AngelRing(Purple).png
"0db92e9598eb9f64c82095d66efe6a1a", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Hair_AngelRing(Red).png
"2b71b8337c476dc4b875b2836a0e2720", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Hair_AngelRing(Yellow).png
"86e9818d2a3ca7041b09c97748be153d", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Hair_AngelRing.png
"70ae0ed388398f14a983b9be841fbf92", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Iridescent(Large).png
"431e901af18398a40876e71e33afcb9c", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Iridescent(Multi).png
"d3a73c13da3082b499720fd2e340fd58", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Iridescent(Small).png
"c3348e9a93cf3f041a47eab885eff5a4", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Skin_Dark(Peach).png
"81aad2673b3c3564e86273be96df3985", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Skin_Dark(Red).png
"51458ebc5861843449e59e63cfbe9312", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Skin_Dark(White).png
"8d80aa31a13e4ca499d7a120c31b5c30", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Skin_Dark(Yellow).png
"1e1bd6119670c6644b39d585be1c7dd4", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Skin_Pale(Peach).png
"de1140e088e6df840abef03788989036", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Skin_Pale(Red).png
"b249fa84e5347e047a14ebd946f5b992", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Skin_Pale(White).png
"eeb275611fdaf2648b0749546abab7e7", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Skin_Pale(Yellow).png
"118b92d83e2a11040921f1eb0de754f2", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Tights_HighDensity.png
"d7043e6bdc77d9a48bdbfc3fb6dc63b8", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/LightCap/lcap_WF_Tights_LowDensity.png
"21b34471bb21d714695594ed013671e5", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_Gloss(BlackEnamel繝ｻBlue).png
"4b7f9eac7f86d804fa4651f78c2f77a2", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_Gloss(BlackEnamel繝ｻRed).png
"a86b7309210462d49937588b29ecb453", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_Gloss(BlackEnamel繝ｻWhite).png
"e789df0d8e991dc46bbbcb776c5a3ada", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_Gloss(Rim).png
"cfc0ca869f3f6aa488e442597f757c16", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_Gloss(RimBright).png
"eba422e248e1b7b46a44eca939e97a7c", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_Gloss(WhiteEnamel繝ｻRainbow).png
"d9eed75190795c742b2a4ad01169a572", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_GradientShadow(Blue).png
"981358a9d84b3254796caa2aed07f755", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_GradientShadow(Red).png
"cb816f85c59d0594e919df78215b8643", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_GradientShadow(White).png
"141320f81a2860f45b14a1de5bb46964", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_GradientShadow.png
"228a97a7223a715439f7b999a17cb9d5", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_Hair_AngelRing(Blue).png
"de0bb15fb581f874b8c33b1cc5ea50e4", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_Hair_AngelRing(Green).png
"4e89ea8f4509c2d479adc1b6eb4a59b8", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_Hair_AngelRing(Purple).png
"bf6207586b81cc14fa15f173c8e3e88d", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_Hair_AngelRing(Red).png
"731335fba7efbcb4c9c77281e6ebf259", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_Hair_AngelRing(Yellow).png
"7237239c7d9b876468e784c193ea453f", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_Hair_AngelRing.png
"140f68527af730a42884e180331e2385", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_MetalGloss(Yellow).png
"fc5c401b877c1bf4f90c09420e4564cb", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_SimpleShadow(Hemi).png
"fb8412e5c0ec1864d94ffbc1c6573070", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_SimpleShadow.png
"63de7b1aca5f56547b4566d5c452971d", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_SimpleShadow繝ｻBlueReflection.png
"cd71180b27fb20b46bd8a67b792511d4", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_SimpleShadow繝ｻSideRim.png
"cde5a8eff47aab14f956da09db682183", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_Skin_BrownSlick_GlosslessFace.png
"6019069d567c03e40b2e57285c9cf05b", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_Skin_BrownSlick_GlossyBody.png
"e2f3f51b74c61cb4fa33d42a0d857e74", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_Skin_Brown_GlossStrong.png
"b3a2e207de951c44db9c4bacaee6010f", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shaded_Skin_Brown_Rim_GlossWeak.png
"e2e3379d7afc6c548a77840f6fd5f488", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Glare+Gloss(PointSmall).png
"874b5960d1ad3b442b9f03199627562f", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Glare.png
"862bb4f308d31a449b8fbfa82451d751", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Gloss(LargeFlat).png
"fc0cf484220685d4eafa9ed00ef8cc7e", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Gloss(LargePoint).png
"cd6d2060efad2c846afb263d634f1f70", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Gloss(MultiFlat).png
"2e2858828b151be4695fd36ca4d19a40", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Gloss(MultiPoint).png
"5923f328fc4cb4147ab169d1db94b29c", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Gloss(SmallFlat).png
"a3680a23ee096f44b9d976c690a872dd", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Gloss(SmallPoint).png
"5ee24b69dfded3240b1e950e8cfea8bb", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Hair_AngelRing(Blue).png
"aab7586db9bd139439746510e249d68b", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Hair_AngelRing(Green).png
"551ec63cc2428814e811c7b90822a9ea", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Hair_AngelRing(Purple).png
"4e03c1e10a8731844ac2136ea96dff4f", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Hair_AngelRing(Red).png
"4456fab6540937b4f80185dfcdb32acd", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Hair_AngelRing(Yellow).png
"9c2691948a9baf44e8231ff1ddd00b36", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Hair_AngelRing.png
"1c368911528c60d429257dc57624517f", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Iridescent(Large).png
"3d294a5afc79400468719f6af35dabdf", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Iridescent(Multi).png
"efd84db93a4cca24d93687e84f48fdf8", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Iridescent(Small).png
"ae7d1c4c107c5794c8c4ec92b3e31630", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Skin_Glare+Gloss(LargePoint).png
"96cf3bb60ffe3384fbd847ec4857c9dc", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Shadeless_Skin_Glare.png
"a8ca5b675c614d348ac51cc580b8e5e2", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Skin_Dark(Peach).png
"8ace27bb9234eff44b5ec8f841b8ddaf", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Skin_Dark(Red).png
"865d0a3b58a86df45ac20e870fcf6255", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Skin_Dark(White).png
"bf45007d8a3c0aa4098a23916c68e58d", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Skin_Dark(Yellow).png
"cf7bfae60977d664b911c3e163bb92a8", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Skin_Pale(Peach).png
"01a3d35c1bc39f646a22769f40bbbb20", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Skin_Pale(Red).png
"4fed231081a962e428e196625a7a4475", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Skin_Pale(White).png
"478dd3812b01a39469a08b45e94ea6fa", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Skin_Pale(Yellow).png
"4ff7604ea3c143144a465740b84499dc", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Tights_HighDensity.png
"3d29d801cba569448b6aacb582271a69", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/WhiteFlare/MedianCap/mcap_WF_Tights_LowDensity.png
"020b20d50dee3b64784514e35d8a53b8", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/YSHT/HairMat.png
"a2b389612cf565643b4b0bbd236f3335", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/YSHT/Ramp1.png
"8339ae69dbe9dcc439ff088723737cfb", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/YSHT/Ramp2.png
"0280c480c48fcbe40ac3bd5b8888b2d7", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/YSHT/ReadMe.txt
"f99f096fbf6cf4d40a2f990e8076c1db", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/YSHT/ShadowMat.png
"401e17d367f33e849a6fdb867b4ce269", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/YSHT/ShadowMat_BGR.png
"10af221457820f04c96c4b2932e290ab", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/YSHT/SkinMat.png
"4e1e2c12906898449933f67285cdc085", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/YSHT/SpecMat.png
"b0a5e22ce82df9b42a386995879e80d0", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/YSHT/SpecMat2.png
"c61dab59da88c87499105c1b046bcf73", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/YSHT/Sample/Albedo.png
"5f8a50cc30df039489b8ee08453375d2", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/YSHT/Sample/Metal.png
"06d8cbe587a3d2c4c967de17cac6c502", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/YSHT/Sample/Normal.png
"721cd36de640a974ca45b613e85cd800", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/YSHT/Sample/Sample 1.mat
"4b8608d176dcf934585ec1b6886e05e4", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/YSHT/Sample/Sample 2.mat
"d469e28ac045d044fb9cb2226a7c9c72", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/YSHT/Sample/Sample.mat
"af8197deebc61ce459480bd679aa6abc", //Assets/VketShaderPack/Silent's Cel Shading Shader/Assets/YSHT/Sample/Sample_SCSS.mat
"a3185396b596ad949854a764984b9171", //Assets/VketShaderPack/Silent's Cel Shading Shader/Editor/SCSS_Inspector.cs
"88a031d938963714a8250672469d5214", //Assets/VketShaderPack/Silent's Cel Shading Shader/Editor/SCSS_InspectorBase.cs
"4836f67ee2df5b449a778c67c1ead5d2", //Assets/VketShaderPack/Silent's Cel Shading Shader/Editor/SCSS_InspectorData.English.txt
"07e7aaa47f6b9a04caf3a47e59ff4589", //Assets/VketShaderPack/Silent's Cel Shading Shader/Editor/SCSS_InspectorTools.cs
"97aa53bd6e8cb564589015cbdc14fa40", //Assets/VketShaderPack/Silent's Cel Shading Shader/Editor/SCSS_ShaderBaking.cs
"dd58167f3f5799f4db066008579b778a", //Assets/VketShaderPack/Silent's Cel Shading Shader/Editor/SCSS_XSGradientEditor.cs
"0757509132a7ee748b11bc26b6fd10dd", //Assets/VketShaderPack/Silent's Cel Shading Shader/Editor/SCSS_XSMultiGradient.cs
"218766231df1c4d4bbd26fe825a2dc8c", //Assets/VketShaderPack/Silent's Cel Shading Shader/Editor/SilentCelShading.Unity.asmdef
"a9a812ee108476f4eae9c507264cc297", //Assets/VketShaderPack/Silent's Cel Shading Shader/Shaders/Crosstone (No Outline).shader
"932c3f8bb2ba7d04480beb8e4c98b2a8", //Assets/VketShaderPack/Silent's Cel Shading Shader/Shaders/Crosstone.shader
"92b4d092592529b4f9a87764c0c44117", //Assets/VketShaderPack/Silent's Cel Shading Shader/Shaders/Flat Lit Toon (Cutout) (No Outline).shader
"193c1d1febff24f46bc72d88e8b205f8", //Assets/VketShaderPack/Silent's Cel Shading Shader/Shaders/Flat Lit Toon (Cutout).shader
"369d2ecd6fc95bc469360ddecf6b2155", //Assets/VketShaderPack/Silent's Cel Shading Shader/Shaders/Flat Lit Toon (No Outline).shader
"f78fe2d8cca2202429d0c2e0d810c763", //Assets/VketShaderPack/Silent's Cel Shading Shader/Shaders/Flat Lit Toon (Transparent) (No Outline).shader
"5028bedf4f7ad6a4aaf7727fead41880", //Assets/VketShaderPack/Silent's Cel Shading Shader/Shaders/Flat Lit Toon (Transparent).shader
"a883b384ca4bc054aa10b5f554ae85a3", //Assets/VketShaderPack/Silent's Cel Shading Shader/Shaders/Flat Lit Toon.shader
"949047d11aa1be843ab010f80e6e1ad7", //Assets/VketShaderPack/Silent's Cel Shading Shader/Shaders/SCSS_Core.cginc
"ac54125faed4a1c4d8641c311f115c9d", //Assets/VketShaderPack/Silent's Cel Shading Shader/Shaders/SCSS_Forward.cginc
"ad30dacf242f54a49b203e540fe72e8a", //Assets/VketShaderPack/Silent's Cel Shading Shader/Shaders/SCSS_Input.cginc
"8acce3fdffc81da43bbff56f95bd5e98", //Assets/VketShaderPack/Silent's Cel Shading Shader/Shaders/SCSS_Shadows.cginc
"e4f4f1f16f5f7a940a8a91cda2684a75", //Assets/VketShaderPack/Silent's Cel Shading Shader/Shaders/SCSS_UnityGI.cginc
"4918d8dc352c4f14095b785dedffaab1", //Assets/VketShaderPack/Silent's Cel Shading Shader/Shaders/SCSS_Utils.cginc
"a780591bd355dfb42b8d43171c524127", //Assets/VketShaderPack/Sunao Shader/LICENSE
"3e696a6fcbf6c3d48b6b18d391ac27f3", //Assets/VketShaderPack/Sunao Shader/README.txt
"52db967a50319a342b8d3e03e2c948c5", //Assets/VketShaderPack/Sunao Shader/Sunao Shader 隗｣隱ｬ譖ｸ.url
"ac4920ac84fea1840bcc25ab63dd1154", //Assets/VketShaderPack/Sunao Shader/Editor/SunaoShaderGUI.cs
"58f628f02e892b441aa26d5402c0fb19", //Assets/VketShaderPack/Sunao Shader/Logo/SS_logo_B.png
"28a0ceca2c0231940b7704112685d322", //Assets/VketShaderPack/Sunao Shader/Logo/SS_logo_BS.png
"a626f2283039de04e867eeb889b593d2", //Assets/VketShaderPack/Sunao Shader/Logo/SS_logo_W.png
"ffa077d687eb240489acb287b977dfa4", //Assets/VketShaderPack/Sunao Shader/Logo/SS_logo_WS.png
"01846cdaa65259e48a71d9812e4e1c22", //Assets/VketShaderPack/Sunao Shader/Shader/Sunao_Shader_Cutout.shader
"09296c4f29b71fb4ba42ef8983d8007f", //Assets/VketShaderPack/Sunao Shader/Shader/Sunao_Shader_Cutout_SO.shader
"3701d6a6f5f988b4a9cea92f1426a955", //Assets/VketShaderPack/Sunao Shader/Shader/Sunao_Shader_Opaque.shader
"2fb75b0069e4fe147a396141dcf70627", //Assets/VketShaderPack/Sunao Shader/Shader/Sunao_Shader_Opaque_SO.shader
"7362334fb65c850469785caac3918093", //Assets/VketShaderPack/Sunao Shader/Shader/Sunao_Shader_Stencil_R.shader
"a95ac57a344b931459880f4ca527efc4", //Assets/VketShaderPack/Sunao Shader/Shader/Sunao_Shader_Stencil_W.shader
"0b073aeeaec66294aa00c57784f4a0bb", //Assets/VketShaderPack/Sunao Shader/Shader/Sunao_Shader_Transparent.shader
"cd2723fb285798b4b801e483a793b3c3", //Assets/VketShaderPack/Sunao Shader/Shader/Sunao_Shader_Transparent_SO.shader
"0bcbd141d25c3594698232b7cf028e95", //Assets/VketShaderPack/Sunao Shader/Shader/Cginc/SunaoShader_Core.cginc
"a0a8cef7d729dd548bea8c0179114e1a", //Assets/VketShaderPack/Sunao Shader/Shader/Cginc/SunaoShader_Frag.cginc
"7c91ecb7ec33e624aa825469df256c8d", //Assets/VketShaderPack/Sunao Shader/Shader/Cginc/SunaoShader_Function.cginc
"349b3c656072d0444812de08c663ff40", //Assets/VketShaderPack/Sunao Shader/Shader/Cginc/SunaoShader_OL.cginc
"331fdc83d13aff84cb82da583877f0d7", //Assets/VketShaderPack/Sunao Shader/Shader/Cginc/SunaoShader_SC.cginc
"666562b3b8d23d64fa0f6ee5216239b1", //Assets/VketShaderPack/Sunao Shader/Shader/Cginc/SunaoShader_Vert.cginc
"e30857b716beae5479b313fde1a5efaf", //Assets/VketShaderPack/Toon/Editor/CopyMaterialParameter.cs
"cad15f56be91b744aaf8e22339bc598c", //Assets/VketShaderPack/Toon/Editor/RemoveUnusedMaterialProperties.cs
"a9775daf5f793f64e98ccd6c4a61bbc8", //Assets/VketShaderPack/Toon/Editor/RemoveUnusedShaderKeywordsFromUTS2Material.cs
"e403ef4b1d56fce47b49ec46981d9fcb", //Assets/VketShaderPack/Toon/Editor/UTS2GUI.cs
"4c57a42f315f467488f69755e6a7d42c", //Assets/VketShaderPack/Toon/Shader/README.txt
"96d4d9f975e6c8849bd1a5c06acfae84", //Assets/VketShaderPack/Toon/Shader/ToonColor_DoubleShadeWithFeather.shader
"ccd13b7f8710b264ea8bd3bc4f51f9e4", //Assets/VketShaderPack/Toon/Shader/ToonColor_DoubleShadeWithFeather_Clipping.shader
"9c3978743d5db18448a8b945c723a6eb", //Assets/VketShaderPack/Toon/Shader/ToonColor_DoubleShadeWithFeather_Clipping_StencilMask.shader
"d7da29588857e774bb0650f1fae494c6", //Assets/VketShaderPack/Toon/Shader/ToonColor_DoubleShadeWithFeather_Clipping_StencilOut.shader
"315897103223dab42a0746aa65ec251a", //Assets/VketShaderPack/Toon/Shader/ToonColor_DoubleShadeWithFeather_StencilMask.shader
"2e5cc2da6af713844956264245e092e4", //Assets/VketShaderPack/Toon/Shader/ToonColor_DoubleShadeWithFeather_StencilOut.shader
"369d674ae1ba36249bb00e2f73b0cd10", //Assets/VketShaderPack/Toon/Shader/ToonColor_DoubleShadeWithFeather_TransClipping.shader
"8600b2bec3ae31145afa80084df20c61", //Assets/VketShaderPack/Toon/Shader/ToonColor_DoubleShadeWithFeather_TransClipping_StencilMask.shader
"43d0eeb4c46f52841b0941e99ac9b16b", //Assets/VketShaderPack/Toon/Shader/ToonColor_DoubleShadeWithFeather_TransClipping_StencilOut.shader
"97b7edb5fc0f5744c9b264c2224a0b1e", //Assets/VketShaderPack/Toon/Shader/ToonColor_DoubleShadeWithFeather_Transparent.shader
"3b20fc0febd34f94baf0304bf47841d8", //Assets/VketShaderPack/Toon/Shader/ToonColor_DoubleShadeWithFeather_Transparent_StencilOut.shader
"af8454e09b3a41448a4140e792059446", //Assets/VketShaderPack/Toon/Shader/ToonColor_ShadingGradeMap.shader
"295fec4a7029edd4eb9522bef07f41ce", //Assets/VketShaderPack/Toon/Shader/ToonColor_ShadingGradeMap_AngelRing.shader
"e32270aa38f4b664b90f04cc475fdb81", //Assets/VketShaderPack/Toon/Shader/ToonColor_ShadingGradeMap_AngelRing_StencilOut.shader
"29a860a3f3c4cec43ab821338e28eac8", //Assets/VketShaderPack/Toon/Shader/ToonColor_ShadingGradeMap_AngelRing_TransClipping.shader
"d5d9c1f4718235248ad37448b0c74c68", //Assets/VketShaderPack/Toon/Shader/ToonColor_ShadingGradeMap_AngelRing_TransClipping_StencilOut.shader
"6439813c08a1f8947bb0ca6599499dd7", //Assets/VketShaderPack/Toon/Shader/ToonColor_ShadingGradeMap_StencilMask.shader
"b39692f1382224b4cbe21c12ae51c639", //Assets/VketShaderPack/Toon/Shader/ToonColor_ShadingGradeMap_StencilOut.shader
"cd7e85b59edbb7740841003baeb510b5", //Assets/VketShaderPack/Toon/Shader/ToonColor_ShadingGradeMap_TransClipping.shader
"6b4b6d07944415f44b1fc2f0fc24535f", //Assets/VketShaderPack/Toon/Shader/ToonColor_ShadingGradeMap_TransClipping_StencilMask.shader
"31c75b34739dfc64fb57bf49005e942d", //Assets/VketShaderPack/Toon/Shader/ToonColor_ShadingGradeMap_TransClipping_StencilOut.shader
"7737ca8c4e3939f4086a6e08f93c2ebd", //Assets/VketShaderPack/Toon/Shader/ToonColor_ShadingGradeMap_Transparent.shader
"be27d4be45de7dd4ab2e69c992876edb", //Assets/VketShaderPack/Toon/Shader/ToonColor_ShadingGradeMap_Transparent_StencilOut.shader
"9baf30ce95c751649b14d96da3a4b4d5", //Assets/VketShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather.shader
"345def18d0906d544b7d12b050937392", //Assets/VketShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_Clipping.shader
"7a735f9b121d96349b6da0a077299424", //Assets/VketShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_Clipping_StencilMask.shader
"ed7fba947f3bccb4cbc78f55d7a56a70", //Assets/VketShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_Clipping_StencilOut.shader
"1d10c7840eb6ba74c889a27f14ba6081", //Assets/VketShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_Mobile.shader
"88791c14394118d42a5e176b433af322", //Assets/VketShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_Mobile_Clipping.shader
"41f4ee183cb66ad40bc74a9f8f944974", //Assets/VketShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_Mobile_Clipping_StencilMask.shader
"dec01cbdbc5b8da4ca8671815cda1557", //Assets/VketShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_Mobile_StencilMask.shader
"55e8b9eeaaff205469365133fe7bc744", //Assets/VketShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_Mobile_StencilOut.shader
"d4c592285a93c3844aafdaafffc07ec7", //Assets/VketShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_Mobile_TransClipping.shader
"100d373b596f44d49ac9bb944d671d32", //Assets/VketShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_Mobile_TransClipping_StencilMask.shader
"036bc90bfe3475b4c9fadb85d0520621", //Assets/VketShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_StencilMask.shader
"0a1e4c9dcc0e9ea4db38ae9cb5059608", //Assets/VketShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_StencilOut.shader
"e8e7d781c3155254b9ea8956c5bd1218", //Assets/VketShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_TransClipping.shader
"79add09e32e5c4541980118f6c4045b6", //Assets/VketShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_TransClipping_StencilMask.shader
"fb47be5a840097b45bac228446468ef3", //Assets/VketShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_TransClipping_StencilOut.shader
"42a47eda2ed77084c9136507eadb8641", //Assets/VketShaderPack/Toon/Shader/Toon_OutlineObject.shader
"2e2edd12fbf6bcb4ea1f34c17ee42df5", //Assets/VketShaderPack/Toon/Shader/Toon_OutlineObject_StencilOut.shader
"ca035891872022e4f80c952b3916e450", //Assets/VketShaderPack/Toon/Shader/Toon_ShadingGradeMap.shader
"9aadc53d7cdc63f4898ea042aa9d853b", //Assets/VketShaderPack/Toon/Shader/Toon_ShadingGradeMap_AngelRing.shader
"23e399973d807464fb195291a44a614c", //Assets/VketShaderPack/Toon/Shader/Toon_ShadingGradeMap_AngelRing_Mobile.shader
"8d33e4e4084e5af449f3e762fecce3c9", //Assets/VketShaderPack/Toon/Shader/Toon_ShadingGradeMap_AngelRing_Mobile_StencilOut.shader
"415f07ab6fd766048ac6f8c2f2b406a9", //Assets/VketShaderPack/Toon/Shader/Toon_ShadingGradeMap_AngelRing_StencilOut.shader
"b2a70923168ea0c40a3051a013c93a8a", //Assets/VketShaderPack/Toon/Shader/Toon_ShadingGradeMap_AngelRing_TransClipping.shader
"d1e11a558d143f14c864edf263332764", //Assets/VketShaderPack/Toon/Shader/Toon_ShadingGradeMap_AngelRing_TransClipping_StencilOut.shader
"f90e11a40dcf4f745ae6b21b857943fa", //Assets/VketShaderPack/Toon/Shader/Toon_ShadingGradeMap_Mobile.shader
"206c554c8b0c60041a9d242385f543d3", //Assets/VketShaderPack/Toon/Shader/Toon_ShadingGradeMap_Mobile_StencilMask.shader
"cfc201757f2519c4bb6ef9265a046582", //Assets/VketShaderPack/Toon/Shader/Toon_ShadingGradeMap_Mobile_StencilOut.shader
"cce1da34c52aff745adf0222f56a356c", //Assets/VketShaderPack/Toon/Shader/Toon_ShadingGradeMap_Mobile_TransClipping.shader
"e88039bab21b7894e918126e8fce5d1b", //Assets/VketShaderPack/Toon/Shader/Toon_ShadingGradeMap_Mobile_TransClipping_StencilMask.shader
"aa2e05ed58ca15441bd0989f008da78b", //Assets/VketShaderPack/Toon/Shader/Toon_ShadingGradeMap_StencilMask.shader
"923058fda1b61544b93d91eeee772086", //Assets/VketShaderPack/Toon/Shader/Toon_ShadingGradeMap_StencilOut.shader
"aebd33b74ef849a4882b4a8d55f0f0c9", //Assets/VketShaderPack/Toon/Shader/Toon_ShadingGradeMap_TransClipping.shader
"0a05dd221bacbb448afac3d63e6bd833", //Assets/VketShaderPack/Toon/Shader/Toon_ShadingGradeMap_TransClipping_StencilMask.shader
"67212ac11ff43b04a833d3986b997a9f", //Assets/VketShaderPack/Toon/Shader/Toon_ShadingGradeMap_TransClipping_StencilOut.shader
"80bd7ce6cad775a4e9de24e18eb5e61e", //Assets/VketShaderPack/Toon/Shader/UCTS_DoubleShadeWithFeather.cginc
"ec7b5c1d006f6be49b412bcd7a789c78", //Assets/VketShaderPack/Toon/Shader/UCTS_Outline.cginc
"eca315d4d2d36194b8be3cf2a6869762", //Assets/VketShaderPack/Toon/Shader/UCTS_ShadingGradeMap.cginc
"ae8d06deb98501947846000ba6cd3ab2", //Assets/VketShaderPack/Toon/Shader/UCTS_ShadowCaster.cginc
"5b8a1502578ed764c9880a7be65c9672", //Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_DoubleShadeWithFeather_Clipping_Tess.shader
"682e6e6cf60a51040ade19437a3f53e2", //Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_DoubleShadeWithFeather_Clipping_Tess_StencilMask.shader
"148d1eca2cf299e4eb949d15c4cf95ee", //Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_DoubleShadeWithFeather_Clipping_Tess_StencilOut.shader
"e987cf9cca0941042aa68d1dd51ee20f", //Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_DoubleShadeWithFeather_Tess.shader
"97df86a7afe06ef41b2a2c242b10593e", //Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_DoubleShadeWithFeather_Tess_StencilMask.shader
"b179fb8a87955a347b5f594a18b43475", //Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_DoubleShadeWithFeather_Tess_StencilOut.shader
"60fe384b76fb67d40bc7e38411073dd6", //Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_DoubleShadeWithFeather_TransClipping_Tess.shader
"4a20b66d106d3f5409f759b5193ecdc2", //Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_DoubleShadeWithFeather_TransClipping_Tess_StencilMask.shader
"a7842aa9522c7584cae2169b8e1ddb86", //Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_DoubleShadeWithFeather_TransClipping_Tess_StencilOut.shader
"0cb6c9e6216a91e4a9d38cd2acb4ccb6", //Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_DoubleShadeWithFeather_Transparent_Tess.shader
"f28bba8b2f259bb40b697d91849c8794", //Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_DoubleShadeWithFeather_Transparent_Tess_StencilOut.shader
"4876871966ca2344793e439d7391d7b0", //Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_ShadingGradeMap_AngelRing_Tess.shader
"7c48bdc9fed28c14b8ad0748673b1369", //Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_ShadingGradeMap_AngelRing_Tess_StencilOut.shader
"d3fb22770ec830b43bdb5ccb973e6f76", //Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_ShadingGradeMap_AngelRing_Tess_TransClipping.shader
"11e8f1e181e558a47a387492d3ecdb88", //Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_ShadingGradeMap_AngelRing_TransClipping_Tess_StencilOut.shader
"01494e58d87212f44ab51d29caea84e4", //Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_ShadingGradeMap_Tess.shader
"24c20b8ed5be113499b40f4e3b6b03e6", //Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_ShadingGradeMap_Tess_StencilMask.shader
"9cf7e8eb46e9128438d50adf7a841de6", //Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_ShadingGradeMap_Tess_StencilOut.shader
"3c39a77fda28b5043a7a17c7877cf7b2", //Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_ShadingGradeMap_TransClipping_Tess.shader
"bf840a439c33c8b4a99d52e6c3d8511f", //Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_ShadingGradeMap_TransClipping_Tess_StencilMask.shader
"8eff803eae89c994fae3acf2f686fafa", //Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_ShadingGradeMap_TransClipping_Tess_StencilOut.shader
"0959cb8822a344c4da890457e668fdc9", //Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_ShadingGradeMap_Transparent_Tess.shader
"6d115cf94d14d1842a56dfff76b57f42", //Assets/VketShaderPack/Toon/Shader/Tess/ToonColor_ShadingGradeMap_Transparent_Tess_StencilOut.shader
"f0b2fc9b8a189134da9c7d24f361caf4", //Assets/VketShaderPack/Toon/Shader/Tess/Toon_DoubleShadeWithFeather_Clipping_Tess.shader
"8c94ee3046ef0574f87f6b658b4e4691", //Assets/VketShaderPack/Toon/Shader/Tess/Toon_DoubleShadeWithFeather_Clipping_Tess_StencilMask.shader
"c4aed8662ca0f194284f3ab649e66d23", //Assets/VketShaderPack/Toon/Shader/Tess/Toon_DoubleShadeWithFeather_Clipping_Tess_StencilOut.shader
"1f248db3b28fc5f44aabd7aca618bd1e", //Assets/VketShaderPack/Toon/Shader/Tess/Toon_DoubleShadeWithFeather_Tess.shader
"a3214384442742648aa664ef0039d397", //Assets/VketShaderPack/Toon/Shader/Tess/Toon_DoubleShadeWithFeather_Tess_Light.shader
"3073cd2564e4cde45a19c05e0012d22a", //Assets/VketShaderPack/Toon/Shader/Tess/Toon_DoubleShadeWithFeather_Tess_Light_StencilMask.shader
"7e7690a767a07da4f943439680e70db8", //Assets/VketShaderPack/Toon/Shader/Tess/Toon_DoubleShadeWithFeather_Tess_Light_StencilOut.shader
"08c65988dc25d9f44b791fcc18fb543a", //Assets/VketShaderPack/Toon/Shader/Tess/Toon_DoubleShadeWithFeather_Tess_StencilMask.shader
"f937ea4ce96dfbe448afc0fb671198e5", //Assets/VketShaderPack/Toon/Shader/Tess/Toon_DoubleShadeWithFeather_Tess_StencilOut.shader
"3fb99ac3775edeb4aa9530db5a614c92", //Assets/VketShaderPack/Toon/Shader/Tess/Toon_DoubleShadeWithFeather_TransClipping_Tess.shader
"9855f226cd8152d4e99085272aceede6", //Assets/VketShaderPack/Toon/Shader/Tess/Toon_DoubleShadeWithFeather_TransClipping_Tess_StencilMask.shader
"2a0d4af863770404faee6488b86fe3c9", //Assets/VketShaderPack/Toon/Shader/Tess/Toon_DoubleShadeWithFeather_TransClipping_Tess_StencilOut.shader
"1847c44f729b68e49ba63610abdf9132", //Assets/VketShaderPack/Toon/Shader/Tess/Toon_OutlineObject_Tess.shader
"06cae78b869a3234bab02eeb52197e1c", //Assets/VketShaderPack/Toon/Shader/Tess/Toon_OutlineObject_Tess_StencilOut.shader
"3a1af221400a61a4b94bae19aa79da2b", //Assets/VketShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_AngelRing_Tess.shader
"a1449ab672051624ca3160737b630f5e", //Assets/VketShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_AngelRing_Tess_Light.shader
"79d3dc54c32b69b42be17c48d33575f2", //Assets/VketShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_AngelRing_Tess_Light_StencilOut.shader
"18c9172cdf36a344f9aca9bbc0e7002d", //Assets/VketShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_AngelRing_Tess_StencilOut.shader
"54a94f776a43a074c8c2d205bb934005", //Assets/VketShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_AngelRing_TransClipping_Tess.shader
"d496a1c70c797ad43836d5bfff575b5f", //Assets/VketShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_AngelRing_TransClipping_Tess_StencilOut.shader
"183ea557143786346b1bfc862ad22636", //Assets/VketShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_Tess.shader
"356dd5af8f0d40e41b647d3d0a0555c1", //Assets/VketShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_Tess_Light.shader
"ffadecfbd9e31f840ba4109fea0f0436", //Assets/VketShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_Tess_Light_StencilMask.shader
"98ac5d198a471494da681b7b8d1e1727", //Assets/VketShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_Tess_Light_StencilOut.shader
"0d799eb857c0e2c45bbdfb2c033d33e6", //Assets/VketShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_Tess_StencilMask.shader
"e667137c8b6fd3d4390fc364b2e5c70b", //Assets/VketShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_Tess_StencilOut.shader
"feba437d8ff93f745a78828529e9a272", //Assets/VketShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_TransClipping_Tess.shader
"8d1395a9f4bfad44d8fddd0f2af19b1e", //Assets/VketShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_TransClipping_Tess_StencilMask.shader
"08c6bb334aed21c4198cf46b71ebca2d", //Assets/VketShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_TransClipping_Tess_StencilOut.shader
"6d04fc34e9717d34d9589f39decf8333", //Assets/VketShaderPack/Toon/Shader/Tess/UCTS_DoubleShadeWithFeather_tess.cginc
"c139664fde6401f45a09b0f32279484b", //Assets/VketShaderPack/Toon/Shader/Tess/UCTS_Outline_Tess.cginc
"ad7807131760d5544843d7424e535b75", //Assets/VketShaderPack/Toon/Shader/Tess/UCTS_ShadingGradeMap_tess.cginc
"6261ac20c5dfa024a98d6ce3921bab70", //Assets/VketShaderPack/Toon/Shader/Tess/UCTS_ShadowCaster_Tess.cginc
"13aee1e1f6c49d94fa292dca9910126e", //Assets/VketShaderPack/Toon/Shader/Tess/UCTS_Tess.cginc
"00999fd020bde754ab4ae5f8a5205844", //Assets/VketShaderPack/UniUnlit/LICENSE.md
"8c17b56f4bf084c47872edcb95237e4a", //Assets/VketShaderPack/UniUnlit/Resources/UniUnlit.shader
"b8bbbd51c2e41dd4bbcb0da1b7a48808", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/LICENSE
"4ebc920fe2745624bbed02e79a222e3d", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/README.txt
"f9bd228ff6fb34948a32cc6fd10d7d5b", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/version.json
"b71e250f3c9f9a54cac228148bc800f7", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Editor/WF_Common.cs
"6b1a45934e0846141979f322772dc3b8", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Editor/WF_DebugViewEditor.cs
"052a5a21704733543a9cbbf6369ca43c", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Editor/WF_Dictionary.cs
"3ca4c3d3a4488214db9818862a2eff69", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Editor/WF_MiscUtil.cs
"4f0275352c196ca4d864b6611897bfd7", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Editor/WF_ShaderCustomEditor.cs
"e3269783b9ab81e4f85d813345bc1a7e", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Editor/WF_ShaderToolWindow.cs
"16f6ecebfe3bedf48922ade8760ef404", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Editor/WF_VersionCheck.cs
"2a4dc116efeb0db4192f11f17d555b87", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Logo/README.txt
"c02ebf9b7a5d66c4ead5f94ef99b20c8", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Logo/UnlitWF繝ｭ繧ｴ_1024.png
"54ed4f64546b23741987a94ff9769567", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Logo/UnlitWF繝ｭ繧ｴ_256.png
"b8e19d3beb8c169458f9b150a00f40ec", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Logo/UnlitWF繝ｭ繧ｴ_512.png
"81bd216f29ecf2f46b29029ec01f55a3", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/README.txt
"80b684ec03e5e1c40943d9eb0e0d32f4", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/CubeMap/HDRIHaven_lythwood_room_1k_32.hdr
"55f94f02873c1bb4bb1f43eed973a999", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/CubeMap/README.txt
"0c90f262b70f7634ea0fb53f2912f537", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Matcaps/Noise邏�譚�/noise_繝ｩ繝ｳ繝�繝�(邊�)_1024.png
"c7e5995223250464cac205689e058693", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_DebugView.shader
"58bb80b63bec29d4384e105c53ca6970", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_FakeFur_TransCutout.shader
"2210f95a2274e9d4faf8a14dac933fdb", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_FakeFur_Transparent.shader
"c0f75d3ed420fd144a74722588d3bc21", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_Gem_Opaque.shader
"21f6eaa1dd1f25c4cb29a42c4ff5d98f", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_Gem_Transparent.shader
"4ba701b07ccc81e4aae7f053bf332eab", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Custom_GhostTransparent.shader
"f3f80636c64e389498b3b19e2ee218da", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Custom_LameOnly_Transparent.shader
"90cac9ec3b2a7524eb99b36ab87f25f1", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Custom_OffsetOutline_Opaque.shader
"871fd7a51a8ea3e4980c3fe7b8347619", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Custom_PowerCap_Outline_Opaque.shader
"58ccf9c912b226146a25726b8a1f04db", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Custom_Tess_PowerCap_Opaque.shader
"af51615040dcdad4cb01c29ea34dbb03", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Hidden.shader
"4bd76f6599a5b8e4d88d81300fb74c37", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Mobile_Opaque.shader
"d279a88eda1ae0e4c89e92539639eb16", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Mobile_OutlineOnly_Opaque.shader
"e0b93fdad2eeedf42baccbc0975cdd1d", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Mobile_OutlineOnly_TransCutout.shader
"af3422dc9372a89449a9f44d409d9714", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Mobile_TransCutout.shader
"0a7a6cdca16a38548a5d81aca8d4e3ba", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Mobile_Transparent.shader
"4e4be4aab63a2bd4fbcea2390ae92fdf", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Mobile_TransparentOverlay.shader
"a3678756e883b9349ac22fce33313139", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Opaque.shader
"4eef00f52cc21b04e9e34e4caefa6bbf", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_OutlineOnly_Opaque.shader
"64bf3ca653a7b274fab3e8a87016bfb0", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_OutlineOnly_TransCutout.shader
"660abd485057f4740ac9050f7ab3237d", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_OutlineOnly_Transparent.shader
"3c07b964e541eef45bc195a029b878b3", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_OutlineOnly_Transparent_MaskOut.shader
"a5ae7f40ac53e274ea0bc1262e1f6895", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Outline_Opaque.shader
"ab4eb87c406a22f46887cf72178e2685", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Outline_TransCutout.shader
"5523e041d29d259439fa14bd131f5c82", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Outline_Transparent.shader
"5498b01615002d948bea7542f55e0c07", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Outline_Transparent3Pass.shader
"9350854c6e88f3f4eb873d2f94ff3328", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Outline_Transparent_MaskOut.shader
"ad88000744b4fb241835ba6ec106caf4", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Outline_Transparent_MaskOut_Blend.shader
"0733cfc88032e8d4eafce250263c497c", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_PowerCap_Opaque.shader
"2cf66b0706c40744baab089297afa895", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_PowerCap_TransCutout.shader
"747bf283d686334469fb662b2fc4a5c2", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_PowerCap_Transparent.shader
"d242cb83664caae4f957030870dd801d", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_PowerCap_Transparent3Pass.shader
"dd3a683002b3a6f43bdb6c97bd0985c1", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Tess_Opaque.shader
"94ee7f8988740fd4887f8b1ce41f0c1c", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Tess_TransCutout.shader
"3bde56820d1aece41bd22966876a061c", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Tess_Transparent.shader
"78d2e3fa0b8eb674aa9cf9e048f79c93", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Tess_Transparent3Pass.shader
"8c7888a4ac175584f81e0b6e7d4af5a7", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_TransCutout.shader
"15212414cba0c7a4aac92d94a4ae8750", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Transparent.shader
"d1e7b0a18e221a1409ad59065ec157e4", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Transparent3Pass.shader
"2efe527cfcbf0e1408b67463225f552f", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Transparent_Mask.shader
"0b53cf0bcd0f9db4fa9d1297d255d06d", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Transparent_MaskOut.shader
"d01a5c313ada49e488b2ef8c6b00f56d", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Transparent_MaskOut_Blend.shader
"a220e3e0675cc3f4f817a485688788d6", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_TriShade_Opaque.shader
"2d294f328149d944eb0899b452ff879c", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_TriShade_TransCutout.shader
"1435581bcf13e7a47b5bf5636f8d8252", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_TriShade_Transparent.shader
"e7263331a8ee0a04aa4a271fc1fef104", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_TriShade_Transparent3Pass.shader
"0299954f2a9b0994f8c9587945948766", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_TriShade_Transparent_Mask.shader
"06e9294a93df4474cac2f4157b5e1d1d", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_TriShade_Transparent_MaskOut.shader
"dfb821bc7afadc14591e4338a8ec865f", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_TriShade_Transparent_MaskOut_Blend.shader
"0380b1621ab524c43aeb10eba3346ea6", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_Common.cginc
"578346e318940304389ae3dda992ac86", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_Common_BuiltinRP.cginc
"2762fae01792d2745ad5d02376392d52", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_Common_LightweightRP.cginc
"ef1a901a2feeb0a45859ecc184e2e3e2", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_FakeFur.cginc
"b892a7ae3359eb0428b2f8aebf24d314", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_FakeFur_Uniform.cginc
"45af0d16a1af0a947b445e08dd6dead4", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_Gem.cginc
"34a1cdb7cd82cd045a521aa2db90ba27", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_Gem_Uniform.cginc
"77ee5292cc4f46649a13611c8d76c85b", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_INPUT_FakeFur.cginc
"e33666b113c868d41bfa058f5bc50d9c", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_INPUT_Gem.cginc
"be668f2e5a5e4ef46838001f79babcef", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_INPUT_UnToon.cginc
"22546fe6fb0bed84e8db3fc80b0b2302", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_UnToon.cginc
"93e68367384c3bd42a3a37868cc25554", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_UnToon_DepthOnly.cginc
"8e439fa11883d4b429904a7fc398851e", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_UnToon_Function.cginc
"afa8b2842288b044b9cdccd7508670a7", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_UnToon_LineCanceller.cginc
"074195645f64a224d9482cb666563c89", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_UnToon_Meta.cginc
"bf91baf439ae72542bd718eb51378f5a", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_UnToon_PowerCap.cginc
"ad9922cd501663b4cbfbef594d1b22d0", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_UnToon_ShadowCaster.cginc
"95ae3c73098e55148862b3125c46785e", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_UnToon_Tessellation.cginc
"bad784f674c77404f8234c8d284656d2", //Assets/VketShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_UnToon_Uniform.cginc
"0c23e5908bcdfaf498f03fc626fe8a46", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/LICENSE
"86d4b790f390cce47810844e4b4a93d0", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/README.md
"5686e1cbe30779e4cb12a3cfebd04af4", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/XSToon 2.0 _ Carbon Fiber.mat
"80add08b1b71e974cb7445f615a6d45f", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/XSToon 2.0 _ StippledHalftone.mat
"072ae31b0e1564b4eb95e3b4437e7d1d", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/XSToon 2.0.mat
"56bf125c9c397154ab9ee5a017746a85", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Editor/XSGradientEditor.cs
"e89d2df0d1b52e4448cda16d9d6eed7d", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Editor/XSMultiGradient.cs
"0e1d31a0eef7c5644832cbcbfc92e7d5", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Editor/XSReimportMyShadersPlease.cs
"dee482cbfe1d3634ab799af2c78502f0", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Editor/XSStyles.cs
"263ae1c7b2037ed4fbf02e938e8bceb4", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Editor/XSTextureMerger.cs
"005c83a3d97ccf040bdbfacbf03b42dc", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Editor/XSToonInspector.cs
"65e344abcde5260468f0010b4c73a2fa", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Editor/XSUpdater.cs
"be9c15115645ef049adaf17bee497ab7", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Editor/Resources/MultiGradient_Object_Ico.png
"4dbcda476eefc6a4286ec65191ef2495", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Main/Test.mat
"d7083d96cb8a0da48beb300faaf2e125", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Main/CGIncludes/XSDefines.cginc
"f7d2bc5531da1c44aa6e753eb1c8636f", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Main/CGIncludes/XSFrag.cginc
"4bc0681c9b92ff74ba271d2b561e56cf", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Main/CGIncludes/XSGeom.cginc
"3007b66203f38424caffb4c058879c59", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Main/CGIncludes/XSHelperFunctions.cginc
"b34fd1827e9b4974db3ee215e80ce465", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Main/CGIncludes/XSLighting.cginc
"59e9937e913f34b4c9335c6f6b288c78", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Main/CGIncludes/XSLightingFunctions.cginc
"3e944a29d3c4a044a8bfc8d73ed46f60", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Main/CGIncludes/XSVert.cginc
"956a7ff9ce5a1cf4c8735b173dfac4bc", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Main/Shaders/XSToon2.0 Outlined.shader
"85c615217d617204cb497ae6838b8bae", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Main/Shaders/XSToon2.0.shader
"39f23e8c24d1e864096d29da0407b88e", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Main/Shaders/XSToonStenciler.shader
"f66d026b6ceed614ba4e5242c17e59b5", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/AO/TriaxialWeave_AO.png
"40ea18bf7298bd3428adcd1737d4b66e", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/CubeMaps/glass_passage_1k.hdr
"efb6603dbbc0ab040848d6b6e2d2091e", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/CubeMaps/short_tunnel_1k.hdr
"dab1297d5c0a834408f49a7365015920", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/CubeMaps/XSStudio_3Light.exr
"efc14fb6a410a27428a516b78b346c33", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/CubeMaps/XSStudio_SkyLight.exr
"8a16b055fdf67054aaea56d1907f39b7", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/CubeMaps/XSStudio_SoftUnder_3Mid.exr
"6707d30b9abd3e244b6bb7b3797b013b", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/Matcap/Metal/Anistropic Metal.jpg
"4303d29ccd156034d9950aa050a59f3c", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/Matcap/Metal/ArtisticMetal.exr
"0ab1477629f706a45bb7b99bbf97e33f", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/Matcap/Metal/FireLitMetal.exr
"f740bde6462de5e4b96b07daeeefbff8", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/Matcap/Metal/LightSteel.jpg
"2aee663d3fa347b49b73df5d27cef38e", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/Matcap/Metal/MetalAF.exr
"2eb97550e316c3347831faf08ac6bb64", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/Matcap/Metal/MetallicPurpleGreen.exr
"79db10ff60487f748a5cd3f0065d7400", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/Matcap/Metal/MetallicRegPurple.png
"da32fe84b577f0246adf3b4ecc490b69", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/Matcap/Skin/DeepSkintone.exr
"1e82fa48fd9295540ab46a89ea403a8f", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/Matcap/Skin/LightSkin.exr
"0818273a570e4084a9f9d258b34ae2c2", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/Matcap/Skin/LightSkin2.exr
"afa6fb48b4cd0bf48a20623477e78f85", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/Matcap/Skin/Skin.exr
"5fb787fb7dd30d849837c095d7bf8e01", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/Matcap/Unique/Amber.exr
"1273e32827ed4f04f9516dbbcd0ac25d", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/Matcap/Unique/BlueRedBacklit.exr
"2cbdf1f25b78eba409fca976ed98e531", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/Matcap/Unique/Default.exr
"6b28500662c4f1f48a8661ed99c56a2e", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/Matcap/Unique/Lightbulb.exr
"3335747e6d5447b49b52f863baaaa7dc", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/Matcap/Unique/Normals.exr
"420d03330b808f34b8f3f2c0b1c77dfb", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/Matcap/Unique/Painting.jpg
"eb13dbc9c89b8424c8f21eabee6af2c4", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/Matcap/Unique/resin.exr
"0c540c5cf863ea743b3091ace3a20e07", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/Normal Maps/CrossWeave_N.png
"24055b3e737e1c949ac98a1f42b42f02", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/Normal Maps/TriaxialTint.png
"1632d2058ed6e554cae477f5a18dbcd6", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/Normal Maps/TriaxialWeave_N.png
"c907c0321c6c65741942d4b98c578003", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/Shadow Ramps/Generated/gray to white.png
"a49de73e4c2486943b4fd591c1607441", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/Shadow Ramps/Generated/redgradient.png
"564b27c878c5df04f86d017bb6f75452", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/Shadow Ramps/Generated/skingradient.png
"12043050a25113c4099c34d2a3ae1eb4", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/Shadow Ramps/Generated/skingradient2.png
"1ee69b57a0cfcc24c8fb898e84d8a84f", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/Shadow Ramps/Generated/smoothcutoff black to white.png
"833058007f71b1b42b6d2a052121d494", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/Shadow Ramps/MGPresets/Example_MultiGradient.asset
"549c0a5d52c1f8042b0a2e090d9f0d22", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/Shadow Ramps/MGPresets/Skin_Multi.asset
"cf6c1f21161d44548a43bcd566b5bbd0", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/Specular Patterns/Abstract1.png
"2d494ba3ef3a48e43abe4ae435602b78", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/Specular Patterns/Brushed Map.tif
"6e3ab83cce46dee44b40d0ea5202fce8", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/Specular Patterns/Skulls.png
"a9d899b9b5f746b4cbf7ec49e7b32ccd", //Assets/VketShaderPack/Xiexes-Unity-Shaders-2.5/Textures/Specular Patterns/SpecLines.png
"969cb948c36a8c04aa8a33d82bc34085", //Assets/VketShaderPack/_PoiyomiShaders/LICENSE.txt
"c1886b825430ada47a42d52f33c03cac", //Assets/VketShaderPack/_PoiyomiShaders/poiToonPresets.txt
"3f398d68f8c01b54485d2a04a13c958b", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/poi-tools/Editor/BakeToVertexColorsEditor.cs
"8f58036675b906e4797a5c394781b2a0", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/poi-tools/Editor/PoiData.cs
"32406f186e960c04ab7448ec0b4ca0e0", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/poi-tools/Editor/PoiHelpers.cs
"1e29ffa815f2cd648839d9b094a4631f", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/poi-tools/Editor/TextureChannelPackerEditor.cs
"71129bd3774e04d48827a25fc98d45a7", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/poi-tools/Resources/PoiTexturePacker.shader
"245e67c21ccaa9a43ad7e84d1c7bb5fc", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/poi-tools/Resources/PoiTextureUnpacker.shader
"11eeab9ab5997bf419f83bfb9ffa1ba7", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/docs.html
"eae8b588a2e3ab84e834f00087295749", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/LICENSE.md
"30877c6905d94034c8c91a9aba08fc01", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/thry_editor_locale.csv
"5b48f91946ace6944a90d8313e080259", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Editor/Config.cs
"42f9390784d11e84bbf6366e794e6b20", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Editor/DataStructs.cs
"f835e027ceb24bf4b8607004ce304fa7", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Editor/Drawers.cs
"2512996118f494a44972192a9fafb1a3", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Editor/EditorChanger.cs
"02b9c440c777db4458c2284c28736ca0", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Editor/EditorStructs.cs
"73c53de23fe449f41b1272569a42147a", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Editor/GradiantEditor.cs
"86ee0d31fc0c2e740bb6237d6281a257", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Editor/GUIHelper.cs
"878844302fe9a8b498f7002ac13ffc7a", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Editor/Helper.cs
"907a3ff8fb013c44f8e504603af2a4a6", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Editor/HelperWeb.cs
"75c479cb152ec084c918f69a99c3ac18", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Editor/Locale.cs
"811f88ca7752d5f458c12b5864202fc9", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Editor/MaterialLinker.cs
"404e4ca46c4f1c045a13674ca45d73d4", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Editor/Mediator.cs
"8349089a9d8124c4bb52b5d414ddca2a", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Editor/ModuleHandler.cs
"3b95745f9a604df4bbc5a00933f516d0", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Editor/Parser.cs
"bd711b7c02d5bb54ba06a46dbd46f9d4", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Editor/Settings.cs
"01a32216cdf0b0e44af9eb3d82fff780", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Editor/ShaderOptimizer.cs
"0b3a6712cb451dc4fa105ca3acd64957", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Editor/Styles.cs
"1efbd8ef56fbc0146a62083b5af6074c", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Editor/ThryAssemblyDefinition.asmdef
"d0ba26704202cee44b1927fe3b60da4e", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Editor/ThryEditor.cs
"e2d2cf739465a3b49aad32cfd86f0f83", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Editor/ThryFileBuilder.cs
"fcf19c9e085d3b442a2974d5c193c268", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Editor/Unity.cs
"8a38f752c293b5548b674637c2a6f99a", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Examples/Example1.shader
"0b436e0db169bde429124bf491f28cef", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Examples/Example2.shader
"dfe226dc787c45b4780d5cc939390f76", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Examples/ThryLabelExample.txt
"cf52f15671610fa4a80b4ee95174e3cc", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Examples/ThryPresetsExample.txt
"901c2a6413418de44ab1678f66fa3826", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Examples/thry_locale_example.csv
"5d5070d92080a424695a221a1bfe96a0", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Resources/thry_animated_icon.png
"db7186aa7d058ea48884c28a5543afd4", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Resources/thry_arrow.png
"cc6bb2a1394d82948a6c734598b1efa0", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Resources/thry_dark_rect.png
"9623e09f716407743aa3eed4d4c1122a", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Resources/thry_link_icon_active.png
"8ff5341a1d25fba4b952596fc0899701", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Resources/thry_link_icon_inactive.png
"22364bdf4781da6458a421602e204912", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Resources/thry_magnifying_glass_icon.png
"bfe72896029084143b99b3ae9f31f683", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Resources/thry_presets_icon.png
"ac423ab0eabbdd445a050b2057d909fe", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Resources/thry_settings_dropdown.png
"ca6ab0375b0d6884e860c28f87c8fbf2", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Resources/thry_settings_icon.png
"d8b879c5a5cb2cb4d9f3d0436f4c1111", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Resources/thry_visiblity_icon.png
"2329f8696fd09a743a5baf2a5f4986af", //Assets/VketShaderPack/_PoiyomiShaders/Scripts/ThryEditor/Resources/thry_white_rect.png
"0a61a58ee74a4074e96d62e63f4e3354", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/PoiLabels.txt
"a49dd2fba12886c499261512c6eaaa80", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Extras/InvisStencil.shader
"add1d40d10695a24b9e91e172ccb9525", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Extras/MasterScanner.shader
"2e376fd109ce87a41b889d93e88c6639", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_FunctionsArtistic.cginc
"89ff22574b0f92e49a4b10267d737637", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiAlphaToCoverage.cginc
"b4f547d93a614ad4d86c09ba02a0ba8d", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiAudioLink.cginc
"9ee086be5141bcb458615f8ad9f54d79", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiBackFace.cginc
"49ee29e0fa0a33c48a51991dc965e8eb", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiBlackLight.cginc
"9f7b9815516b9bd45afc0657803fde91", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiBlending.cginc
"0543f339ffab97d418a5577bd4cd049c", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiBRDF.cginc
"c49023d4328abbe4dbce068a8f1ded2d", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiBulge.cginc
"05e2de0df0c3a8147a1f7989db8ebd19", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiClearCoat.cginc
"d0e3e8cd70bfa154ab69be067aba0d59", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_Poicludes.cginc
"221d9e3fa8c8639449704bdb192dbc4f", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiData.cginc
"1cc16395659ad2b4b886b2caaeb83829", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiDebug.cginc
"664de60cb14b4194ba278cf1f8d8cec5", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiDecal.cginc
"7c4268f3614d17d49ba4a6865bd104de", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiDefines.cginc
"051133829be575149906a0cbe6572012", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiDepthColor.cginc
"e737055de48f98a4587f09a286ede08f", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiDissolve.cginc
"07d19319226672d40891a9cf8095bb1d", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiDithering.cginc
"fb39e9f722d93614d8bb1b9b708f60e6", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiEmission.cginc
"a1c11292ccd8b1d41887e0f69e6695dd", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiEnvironmentalRimLighting.cginc
"87a9dab4f8128cd41bf38bac18075b14", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiFlipbook.cginc
"60cd78e9ddf39f8488c9f5574a8a5a7b", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiFrag.cginc
"951e19b6f0892c246b81926ee196e733", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiGlitter.cginc
"31b4450700d5cc244853b4488e455231", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiGrab.cginc
"fb03052ea8dc42740b104275ae961ae0", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiHelpers.cginc
"ea5f0a88cd7909642be3bb003cd6c291", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiHologram.cginc
"72605619fbb558a40926b8b605114f53", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiIridescence.cginc
"be833b6d97385124b8b1cbbcf36275b6", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiLighting.cginc
"6e064571b72c98948b7726439d667d07", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiMacros.cginc
"543c4fafdae39c64ebbb99654c35c4b6", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiMainTex.cginc
"ea56da5c525e5e441bf82593f3151cac", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiMatcap.cginc
"382dd34f82ef0a742b5bb3e691f224f6", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiMath.cginc
"ef435eef1f3062442a396ae471e4c023", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiMetal.cginc
"6a90225807e1d2943a87f41b64493968", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiMirror.cginc
"39347a84f5d044c4d917618f2cad9661", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiMSDF.cginc
"7db374de8ad35a74e8b931bcef6e3ba8", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiOutlineFrag.cginc
"3ffaf29d05947a14fa6c536ce06612d5", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiOutlineVert.cginc
"1181a36e0475df340b0a8d40fc95f05b", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiPanosphere.cginc
"3737980e09be8994e929a4a8aca17fd4", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiParallax.cginc
"fa1dff6cd1c9b9f4891de1a7c880523d", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiPass.cginc
"0fe97530a72193b4faea2c5e3dd997a6", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiPassOutline.cginc
"94f93700d2c2f3946ba884cd83881c8e", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiPassShadow.cginc
"4c432851cf0d1dd44b21e0713429604a", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiPenetration.cginc
"b6260b56386a2b743a6bc537a3307cc7", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiRandom.cginc
"5a887d6c0dfbbba48a780737a0351a55", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiRGBMask.cginc
"a87bd1004a9f61d4da9d5159ced4fcc8", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiRimLighting.cginc
"6f029ac6c95637345af7f9fa039b835d", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiShadowFrag.cginc
"388afdf5d08890a498d21c55347c0a2c", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiShadowIncludes.cginc
"85240e87020438747a5fa50f428e5cdf", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiShadowVert.cginc
"7913db65c40101341a2f9d4c1b15f96d", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiSpawnInFrag.cginc
"73fa7e501ae5f2643ac34be3ad11b72a", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiSpawnInVert.cginc
"da46d1a0fb2f8cc48a64a10aabc5df20", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiSpecular.cginc
"c86cb17bac1d3ae469535ac16b47fcf9", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiSubsurfaceScattering.cginc
"cb923a9217d969d40a045da0c480df7e", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiTessellation.cginc
"b781c7822eb79cd4d94941b850ec86fd", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiUVDistortion.cginc
"ef2c28e0e6cae3d49989341119faa165", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiV2F.cginc
"c608d4e6f9b40dc4a854fca20604e6b6", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiVert.cginc
"8f221171da2883d41ab5a08dd1de9779", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiVertexManipulations.cginc
"ff77987a6a6483746ae074933182b0e0", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiVideo.cginc
"e434761b466d9634bb3659a0b8ec52b8", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiVoronoi.cginc
"65110f189ab785a48b0a0d99d987ea15", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/CGI_PoiWireframe.cginc
"572baf09485ff2d4b9e074da2bba81bb", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Includes/Notes.txt
"d91e0db3d0441454e8f7d1d26d2ec2e4", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Shaders/7PlusLabels.txt
"917b37092bae034459c28c00a3a19b54", //Assets/VketShaderPack/_PoiyomiShaders/Shaders/Pro/Shaders/S_Poiyomi_Toon.shader
"f0639686d59f97549bb28e5ee83a6710", //Assets/VketShaderPack/_PoiyomiShaders/Textures/DiscordBannerTrans.png
"bb7711dde80ffc949b3171744eb92cdd", //Assets/VketShaderPack/_PoiyomiShaders/Textures/UV_Check.png
"8fc1b64e56c5c6540a4fe651abb8e855", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Cubemaps/T_Clouds_CM.jpg
"4c4ee3a819827ba44982aa9914a492c1", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Cubemaps/T_Gold_CM.png
"137e423b84d592745900f40e96109a42", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Cubemaps/T_iridescent_CM.png
"926fb776fa6806b4ab672dc408235d54", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Cubemaps/T_Shine_CM.png
"8c08eedd2cd5c4341b81cbad4b78bc14", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Cubemaps/T_ToonLit_CM.psd
"26945f7417f404a4991f14e10add5cbe", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Debug/T_SecretMessage.png
"1f79f71b84fc2844bb81e9ae4f5bc384", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Defaults/T_Default_CM.exr
"61bd594533da4fc42bd46ef93ba5a4f6", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Defaults/T_Default_SR.png
"a6d6984545cde4a4f9317b17d6dca225", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Defaults/T_MainTex_D.png
"0e5adf556c7cd744cb68a0358216904f", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Detail/T_Cracks_D.jpg
"07f0a54a3a4e7754eabc8ced70d7b30c", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Distortion/T_DistortionMap0_DM.png
"70cd704e7a9550241b8a8b51fffc1a68", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Distortion/T_DistortionMap1_DM.png
"fa80ac020379e5047896d6c7551b216a", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Fonts/T_DigitalBold_FONT.png
"bb52cc9d00ce83f49a4c555ae9ceeb45", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Fonts/T_RobotoBlack_FONT.png
"bd25b8c9bd6d54b4bbf037665d011bc1", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Fonts/T_RobotoMedium_FONT.png
"02efa160dddcf4d4b98cd9c8f73ea0c2", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Fonts/T_RobotoRegular_FONT.png
"b2d5844398779944897100ab02debb3f", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Fur/Fur (1).jpg
"6dd6638e8d91f324383b214a129f143d", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Fur/Fur (1).png
"fefe6a3985f51034d940687be8f7202c", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Fur/Fur (10).jpg
"0b48796ae2eff2e4592f97849436677a", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Fur/Fur (11).jpg
"1427eb7067b0ff84fbb3c12c2a3da7a9", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Fur/Fur (12).jpg
"f6678285637dca9478005297b797c3e5", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Fur/Fur (13).jpg
"e449b338bcb7aa04d856b0fca929c017", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Fur/Fur (14).jpg
"10a7a1354002a1044ad5ef6a7d65eb07", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Fur/Fur (15).jpg
"7e8ded856e9486c45a0c72a2ca9b2cfe", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Fur/Fur (16).jpg
"86ca19b5a4decea4ea533b7f1f0a80f0", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Fur/Fur (17).jpg
"ef2cd5ae79f431f488a863cda3cb1fd1", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Fur/Fur (18).jpg
"14f9237ca5b8ac04e933d8f136c013cf", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Fur/Fur (19).jpg
"dad9afee739f8254ab2dd517e4cf7da0", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Fur/Fur (2).jpg
"c0125b075311ac74c93f83b0e6558dc0", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Fur/Fur (2).png
"5925e757158e2d241b10165ea723b9ef", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Fur/Fur (21).jpg
"e3f0167066cb8de40a2a6e03c35c1812", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Fur/Fur (22).jpg
"ef0eddc6bbd1fe44f8535592c33c8286", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Fur/Fur (23).jpg
"85673f25242c2fd42bc72f6a2d75a1b7", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Fur/Fur (24).jpg
"2c9b1fc62caa05245b2d5691922ed7e9", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Fur/Fur (3).jpg
"8ddce56e0290541428b1143f3df5259e", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Fur/Fur (4).jpg
"b974fce48120c9b408a637334056614e", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Fur/Fur (4).png
"b96cad894c8c3cd4c8b72e4ef06afc01", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Fur/Fur (5).jpg
"66fa20c31f3fd964795803c2209f2254", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Fur/Fur (6).jpg
"1aff2597cadef9442ab67b460bbd6241", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Fur/Fur (7).jpg
"a0623b299d92a564e8f308dd645856a1", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Fur/Fur (8).jpg
"d3b42841e5cd27d4bb0f683ec498000e", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Fur/Fur (9).jpg
"4936f95df08752e46940d871d9288f05", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Fur/FurHeightMap.gif
"d5e4a521aa43ec742a51e66e8da2871a", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Fur/noise_simplex.png
"336f8973abdb4564e901d06333a17ce9", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Fur/ornage-fur-texture.jpg
"3219b69a8562db0439012ae282fc6eb1", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Gifs/T_2ColorLines_GIF.gif
"81515002c3860be4f915641814f9b491", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Gifs/T_3ColorLines_GIF.gif
"4366357a39e155f4582cd3fcc18ea692", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Gifs/T_FireWorks_GIF.gif
"51e12303b2e7b6047ace7411e66b3988", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Gifs/T_GrayThing_GIF.gif
"a937e2d8cd8cb8840ab729392c896c42", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Gifs/T_Hearts_GIF.gif
"effb638e91144eb4780b51a79c07fe4c", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Gifs/T_HorizontalCircles_GIF.gif
"6863931c533eef040bb9ff8f6341c075", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Gifs/T_Matrix_GIF.gif
"5c4dcd6a4d55c704a830a6e4145c556f", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Gifs/T_Ovals_GIF.gif
"b9f11add051c1244aa4e36fe23bc24c1", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Gifs/T_Snakes_GIF.gif
"4defab4eefbca0d45a9cfe92f54d8f3f", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Gifs/VerticalCircles.gif
"ac094b6695c5d1940a30a73008adef44", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Gifs/Waves.gif
"1bd6fecb7f38f1d449b84445a83e7c3e", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Gifs/zigzags.gif
"30c88667252e4f14baa78199305d0f9e", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Icons/T_icon-discord.png
"27bc48bbcc0ee57449b438e68a16dfa6", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Icons/T_icon-github.png
"61cb1accaca1c8f4db4dc55dbfa567bb", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Icons/T_icon-patreon.png
"c52984d0a6817cd4997ffe016a84b55d", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Icons/T_icon-twitter.png
"3687bc92cd8dea14bbae5ee5f2a6a4bd", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Icons/T_icon-youtube.png
"39505ec18a2256247be0f9ff777b8ef6", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Masks/T_circuit_MBW.png
"47a1e48d03a0094499c5ebdd30e29495", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Masks/T_Grid_MBW.png
"e615f84c8371ebd4fa56258f42800739", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Masks/T_RampTest_MRGBA.tif
"e21db298689c4f84abe7200bc9c130da", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Masks/T_Star_MBW.jpg
"1db11fa2fd2d3fe47b1f585645db2a5a", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/LatexMatcap2.png
"18bc3c3625266ef4b8fee18269619212", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/MatcapLatex.png
"b66c2d17fdb7f5a4197a759142e82c96", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap.png
"d52ce43dad0c07d4ba39d794d17f4639", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_MatcapPinkBlue_MC.png
"119bfe51061529d40929df43ea5b5687", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (1).bmp
"22e746c3d444b3c43b687229e8263cfc", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (1).jpg
"3dbb3be39df7e7c4eac60386a0f67ea8", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (1).png
"0e0d81b6be9daaf459ba80b0e93f2ce1", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (10).jpg
"c9e5ea5d5e5e6f740815297d05d53ed4", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (10).png
"82136e8697de6eb4394177338725876f", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (11).jpg
"652deaaf3db3ffd49ac1658c5feed917", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (11).png
"16cfdbf57bd4a5f4e8a240217503734a", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (12).jpg
"c5758d4a5402db14c856bc927fcd9582", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (12).png
"64eda4a30094fd24198f44b0c9d41208", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (13).jpg
"bd0cc922d6a571e438eee900fe57a5b1", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (13).png
"ee08a1bb6cc9ce44284b711477c79df4", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (14).jpg
"b70fb87bdaed04d4db351ed4a1cf8433", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (14).png
"3d2cce892a030694d9a72a92dad5e82f", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (15).jpg
"5ff5ddb61accef94bbd8aaad130b93e6", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (15).png
"507ec010e33595d4ca0fadcc45844169", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (16).jpg
"b2af0c8d2bd641648a8d1ec0b9536b17", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (16).png
"bca7518f2d385c340b84b107c599abe2", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (17).jpg
"b2a2a720253b640459f15f64a371a83e", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (17).png
"7bd1664c669e2e94683e48d235b1bb27", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (18).jpg
"55b34dc98a1beda49a9004a81b46af61", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (18).png
"97b53db9a7bc7a64181a216a90907e39", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (19).jpg
"b9031c1f7aa3af84a9c6db1738c1ba59", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (19).png
"ffefc5ef27c0c5542b545dd6169d0428", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (2).jpg
"7960f3b319c2a4e4baad0c57ba8f9d48", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (2).png
"9069ac80b6926394eaefe7ef40fafcfb", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (20).jpg
"5f94789d7f6da9b449e4cb1139ebecc6", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (20).png
"b5e71f00f5605f64bb2b7e60473e750c", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (21).jpg
"5586e7d602e5b49408769f87e8c907d2", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (21).png
"760bc4ee5d362ff4da1ba3ca0e2efc76", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (22).jpg
"b36a67a8cb824694cbd0f71b5ba9de5e", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (22).png
"cabfaa2a3d851a448929f9ef1807bb05", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (23).jpg
"6fe30ec40a285ae4f90a2656a59b8048", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (23).png
"6123b53d024ac0b489e5d7a87528c5da", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (24).jpg
"bf41ad2e79589774f97ac0e6b7f950bf", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (24).png
"0585906ec08a78346b9fe60a303e12ee", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (25).jpg
"194efd6ff3768ab44b7ad9647dcd9d7e", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (25).png
"58b5b74caaea4b74ab0e210d080d43da", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (26).jpg
"be401e0134922d1429f57d073a05f469", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (26).png
"f6a76475a220f20468f16ec0e17d67b1", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (27).jpg
"57b8918006ce46f478039228a2880c63", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (27).png
"54a1fdb38de704840acc087caf4683bf", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (28).jpg
"3eac3478dda6e6d42860167a61d0c39e", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (28).png
"7a28f4ace6d11af4a8b1e41c0e74e245", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (29).jpg
"893868d7303292244881c1e37a3113b4", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (29).png
"8d2fc396afb45da4bb76782b8fc0f4a5", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (3).jpg
"f5303b4da8057574c84c7322a19702b7", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (3).png
"0108fa829c99c56478b917b81937622c", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (30).jpg
"8b0294a2d71b5044180c0ace903cd6bf", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (30).png
"25bab4ee27508ec419f44b2357baa9ea", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (31).jpg
"c481b4ce3da24254d8535e039bddd9a2", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (31).png
"789f2ef616997194d9a6075249378b36", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (32).jpg
"3c1b5b63bfcf1d64a85ae92a997559ad", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (32).png
"9093fc5a69128ad4b8d57fdfa63614ad", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (33).jpg
"c2900629045488a4b89b252f60b7ba80", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (33).png
"fa2e476756e68e54d8218936d92f44de", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (34).png
"f5d590d6f058eab4ca5501856f5b48d2", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (35).png
"19d43460f5d9e824ca794439434578de", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (36).png
"3e5c458f086955147b31f6fc5f0e118a", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (37).png
"96af20914dee77340aa59723bee8417f", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (38).png
"9d10c0c5b584761468fae139861a42de", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (39).png
"ad62a319e566fdd4c8c6441b7250ba61", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (4).jpg
"2b5e0b031839238468f548ae5e30d127", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (4).png
"9c38b9b79d5e16b43b79b9c7d3f0fe7e", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (40).png
"8db27ba22c9f17c408dd81739495da48", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (41).png
"aa27df79f39a4aa4f9e59e56f202da35", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (42).png
"46ec5de8b6955e74b85a8173d64fd30f", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (43).png
"e2f800df165ce7b42bc331a89805b4b0", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (44).png
"cbecb892fa166824ab4114ffc7f27c17", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (45).png
"191938ee788301d408ee03ab53a3d47d", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (46).png
"0aac4adcdab886c46a45ab1b9d264123", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (47).png
"625ea777e073d1644a0e1eb481eec64a", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (5).jpg
"caf2f79a23000a84599416e236287616", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (5).png
"9bb7c453de514554db5dbb8a2cfc672b", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (6).jpg
"33148cf06f81cac40b9b18a9aa5b3bff", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (6).png
"a24496aa77800b24c960741cb4c32203", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (7).jpg
"0e50551111e650f44bebc5d6f589d704", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (7).png
"30c6e066a187de543a9e1bae3a6c6852", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (8).jpg
"e8626a4d5c2f311438c72481922d7efe", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (8).png
"612476841a11fb94ca01633cc01282df", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (9).jpg
"f712d8b4373eba943baf1989e0aeb15f", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Matcap_MC (9).png
"fc239b868ef86f94087bad300518901e", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Matcaps/T_Rainbow_Matcap.png
"4ce40eff399b11a4fb5cddbc29ee2227", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Misc/T_Black.png
"ce440cfbe62dfdd4abc464cf7b031b8c", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Misc/T_Circle.png
"5e54fd3fa7d2eb2448d1afc2697bf8a4", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Misc/T_LightRainbowVertical.png
"bc453e8dc8d53ae42a9930a8b0de1dc5", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Misc/T_PastelRainbowVertical.png
"fb2cd373b18d16146922f755a1109a94", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Misc/T_RainbowHorizontal.png
"68238ea52b01b4646a834ac408126548", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Misc/T_RainbowVertical.png
"f8f2f125174239f44bbd65262132328c", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/Gradient.jpg
"efad3a5f6f0666945bb3a8dd0dc9afe9", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/Gradient2.jpg
"5b4e56cbe10b0ab48ba4a4f8e21be893", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Abstract2_Noise.png
"b60b8211733a76c4b9a4322bfcf0b581", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Abstract_Noise.png
"3f0ebc93eb910fa4e83d2dbdc92fedb7", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Blotch_Noise.png
"f70e10900053fb44986fb2d3d6bf8454", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Brick2_Noise.png
"65cfe9f1e5990e8448929ef8a4b649d4", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Brick_Noise.png
"aded3d8bdb52eb744964762b45920654", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Caustic_Noise.png
"d2b08e9dd82d76b4fa5e07bb95ff2196", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Cell_Noise.png
"41c4dd3ec1abf6e42964db04353440bc", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Checker_Noise.png
"39587adffa9ad98488e3d4c7c56a92a9", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Cloudy_Noise.png
"5757e282ae2aac54e99d40378b103e7c", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_InvertedHex_Noise.png
"39bb96d456be4a84f926ee715e5b626a", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No (1).jpg
"1539e659b3b7d4940b051f702bc0c13e", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No (1).png
"83350d98782a3f64cb46dd7bb928271c", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No (10).jpg
"c2523251ed02cab4f9261d7a4c0678f9", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No (11).jpg
"1b65b9963ccf248489844c4d18ebd6a2", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No (12).jpg
"73dcc3a84b09e3146b6194acca5be1fb", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No (12).TGA
"7a5009302aa7c3d44b67e520541750a7", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No (13).jpg
"c0264675a41c58142ac2cd8e1e2c60d8", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No (13).TGA
"feb2e298e2fdcfc4ea372610bddb4ab4", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No (14).jpg
"0b021ae2081d45541a752b1d7ad0d570", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No (15).jpg
"948d051b07279294088742d8154223f9", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No (16).jpg
"588b1cf3457e893429b891d9e309773c", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No (16).TGA
"f09ed133d3c2ea743880f31ed4c4ec60", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No (17).jpg
"7f726d3d09907a74e8ca61caef91350c", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No (18).jpg
"384585c1d1eb2ae4293c37bc13542310", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No (19).jpg
"faaad765f99ebf042892806a43c5acee", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No (2).jpg
"71eb1cadc5880074bb3788081492b75e", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No (2).png
"50407170ac45a6c49a6044f71e0413c3", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No (20).jpg
"1ff8ebef6b28683499c6fa04a4098e70", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No (21).jpg
"d2fc7e621ee2eac4b986c465de92c6bf", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No (22).jpg
"ea37624af93d96943b2dd93ab64a1128", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No (23).jpg
"a43e3197e3af367458fa25637d0ace57", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No (3).jpg
"04adfac2018725f43bf17158a3b6991a", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No (4).jpg
"68b47bf7b40cbbd4d98fb5edba9c6b08", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No (5).jpg
"64318b6160916704db4495c99e14d9bb", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No (6).jpg
"5cd2541f2a58a49439b03b255264c50c", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No (7).jpg
"8c2ba11c031f30747abe2e9d52d3483d", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No (8).jpg
"e645408cc6f35154bb09808bc39471b3", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No (9).jpg
"a174f25610aa260419d13c28372ca403", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No (9).TGA
"3d2855f84e40fc0479ba50c9b2822793", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No.png (1).png
"12d2a54817ebe334db38e85a687d9439", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No.png (10).png
"a239bf9efb27401409c75b90cc73007a", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No.png (11).png
"0f65047a52bd6484d968e94f2c6777cb", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No.png (12).png
"abc13b08eb4023448b37a833482f82ff", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No.png (13).png
"ea593121750048e49b98c3f20671a5b8", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No.png (14).png
"2586df9a3b5ce4e4b83b617390ce682c", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No.png (15).png
"0cd62273cab4ce24bade5b72b2e02127", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No.png (16).png
"84cd2c832f417e147879a1b683213016", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No.png (17).png
"69cd5ad91b4778c46ae1cd2a81ed3760", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No.png (18).png
"689a97b4b90b8b94baea6243cdc7a0d6", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No.png (2).png
"98a08c318257af648b4288a136e3d523", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No.png (3).png
"fd389a4cbaf52d945b09babc7cce4e91", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No.png (4).png
"bf57ae9997325ec44af94043bbfce786", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No.png (5).png
"dc45c2a31dc431b4489192aac5b85cf2", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No.png (6).png
"db2de0fac2c4b2040a6b7807330991ee", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No.png (7).png
"0fa953077ee3b4d49b74e56801a27e77", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No.png (8).png
"e87e3d84ef8b649469166e2afa88c1c5", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Noise_No.png (9).png
"19ddda4f7d303094db07b8fda5037a03", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Pattern2_Noise.jpg
"e0764bbcb1913ce4eb038fe89988a396", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Pattern_Noise.jpg
"6bfa05600af138847bc516fd43534e52", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Sketch_Noise.png
"e90e0fb9119be9b4db37ee3b86de6440", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Smudge_Noise.png
"3e93baabe07c2e443ab3cf659438417c", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Vornoi2_Noise.png
"71c08610deb243144888703479205c12", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Voronoi_Noise.png
"8b5a4f787794c584ab3fdb7f40d4ac37", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_Wiggly_Noise.png
"ef36503fcb9106a4e982cc94d83685e9", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Noise/T_ZigZag_Noise.png
"f3dc3d4e2a6de754d93047830bdc5d15", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Normals/T_Cloth_N.jpg
"ed3986805d60eda499042ce23b1be705", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Normals/T_couch_N.jpg
"446cd9992afb87f45b237154fea5f570", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Normals/T_crystal_N.jpg
"95569409267572b49813657ae5de18e1", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Normals/T_Fabric_N.jpg
"f771a6313a5869d44b53020b3dc105b7", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Normals/T_Random_N.jpg
"ab89d0b40a0410c4aa787b95750cb036", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Normals/T_Wave_N.jpg
"b8960a088bdbdad478c88078ffab9d8c", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Normals/WaterNorm.png
"d13510bb2be49aa40a66a0101efb6a36", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Ramps/SkinLUT.png
"49bcc4a51b69ddc438f1914cfa7f41f0", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Ramps/T_Hair_SR.tga
"7ff3cc732aae9734f85c697329ee371f", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Ramps/T_Metal_SR.png
"0901749828304e340844c78be88fe2e8", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Ramps/T_Mihoyo_MCSR.tga
"6982ddf13e4f7ab4cb10c88cb6ba3ba4", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Ramps/T_Neitri_skin_SR.png
"b4ae486ee54de7243a507d6356e7537d", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Ramps/T_Skin_SR.tga
"9bb77cf8c1bd8184680cdfdc7f7b4c46", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Ramps/T_SoftHardBlack_SR.png
"732b4977557d2954f822f01846fa0dba", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Ramps/T_SoftHardGrey_SR.png
"56b3aaba9b026e84887babe35c1969f8", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Ramps/T_ToonSkin_SR.png
"3739010f030632a4fa615f9a0a4a62ec", //Assets/VketShaderPack/_PoiyomiShaders/Textures/Shapes/T_Snowflake.png


                #endregion

            };
        }
        public virtual string[] GetMaterialGUIDs()
        {
            return new string[]
            {
                "852b1a8f6b8cf714ab105ed0b009020c", // Assets/VitDeck/Templates/07_UC/SharedAssets/FloorGrid(07_UC).mat
                "43952b04c671c85499219a62eb939303", // Assets/VitDeck/Templates/07_UC/SharedAssets/SampleBooth(07_UC).mat
                "262f8e55a8b27584092f4aef6a6ee290", // Assets/VitDeck/Templates/07_UC/SharedAssets/Skybox(07_UC).mat

                "0de3ccc1017c4a045a4fed5f810c2748", // Assets/VketAssets/Prefabs/AvatarPedestal/Materials/UI-Lookat.mat
                "0bfe6778f100206489baf9dbd0c24646", // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/avatar1-helloweenmqo_服_AlbedoTransparency.mat
                "88581c9aef71ea549b2f133599cb89bf", // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/mat1.mat
                "88728f426bf72d74b9abd9ceb8ecbd2c", // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material 1.mat
                "112ba1c1df66b5e47b93c5c355fb8e69", // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material 10.mat
                "27f323571b8327e409c9b9669fb84d93", // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material 11.mat
                "7d4ac9335e1cc82488a383bd849a380c", // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material 12.mat
                "eb0465484fd24bd458c85ad5c6554747", // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material 2.mat
                "d6390657f902d1142a20b5cc7f92ffe2", // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material 3.mat
                "119d5edced9d6bf469181f8497c65731", // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material 4.mat
                "2f2236791569d124eb4b48f19730cb06", // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material 5.mat
                "f651c02bf9fdac1408c87c0e4f6cdd2b", // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material 6.mat
                "345659f361c837b4cab35176f8c8d671", // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material 7.mat
                "57338689439fb4a4fa1a42ebf3816059", // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material 8.mat
                "86c25d309b5f3114ab3f949d7655aea3", // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material 9.mat
                "a2d8565e76f62d14e9c149040f122c19", // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/material.mat
                "a87e62033b0ad4848838ebcf5f89858f", // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/violin.mat
                "b407561bc3f21de4c8808646f3a719ca", // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/Walls.mat
                "5ebfcc9cd374c614dba1f903f8de36ba", // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/cloth/Cloth.mat
                "130e4ea006e957749a3e19016c5b918a", // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/EmissiveFreak/EmissiveFreakMaterial 1.mat
                "6182e5d390ecba149a1f8d75312e956e", // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/EmissiveFreak/EmissiveFreakMaterial.mat
                "4329612c3238cc44091f699ba05da324", // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/mannequin/mannequin1.mat
                "5cdca66777e3963468a57b44e76b86c4", // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/mannequin/mannequin2.mat
                "63000287678da044197a3ff745d75c25", // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/mannequin-knit/mannequin-knit.mat
                "c2c262af144c1b042adc2954103f4e22", // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/mannequin-painted-stl/mannequin-green-metal.mat
                "e9bfebf98ae9cae45b922038482fc4da", // Assets/VketShaderPack/arktoon Shaders/Examples/Objects/Materials/mannequin-painted-stl/mannequin-steel.mat
                "497f8485774204244abb7ba6c0865927", // Assets/VketShaderPack/Mochie/Unity/Prefabs/Default.mat
                "4f42a26097c877b40a7616aa60580c43", // Assets/VketShaderPack/MToon-3.4/MToon/Samples/Materials/Ex_OutlineWidth_Screen.mat
                "e40a129e14e378c4db040df3fd4a6077", // Assets/VketShaderPack/MToon-3.4/MToon/Samples/Materials/Ex_OutlineWidth_World.mat
                "54da18ba3126f1343924588562df72e0", // Assets/VketShaderPack/MToon-3.4/MToon/Samples/Materials/Ground.mat
                "9639e17dffc656345a70282f7f216672", // Assets/VketShaderPack/MToon-3.4/MToon/Samples/Materials/Toon.mat
                "721cd36de640a974ca45b613e85cd800", // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/YSHT/Sample/Sample 1.mat
                "4b8608d176dcf934585ec1b6886e05e4", // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/YSHT/Sample/Sample 2.mat
                "d469e28ac045d044fb9cb2226a7c9c72", // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/YSHT/Sample/Sample.mat
                "af8197deebc61ce459480bd679aa6abc", // Assets/VketShaderPack/SCSS-master/Assets/Silent's Cel Shading Shader/Assets/YSHT/Sample/Sample_SCSS.mat
                "82c58dbbc5f31aa49ab2e0ebbd5328a1", // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/Gem_Sample_Assets/etc/Plane.mat
                "af5aea2243dd470499bd0bf866c0b9da", // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/Gem_Sample_Assets/GemMaterials/BlackGem.mat
                "0efac9871ef36134e8cb4e3e0e58e417", // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/Gem_Sample_Assets/GemMaterials/GrayGem.mat
                "d1543206c7f9ed343b13306b48245ca1", // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/Gem_Sample_Assets/GemMaterials/LavenderGem.mat
                "182eea833aea07742bfa8fc0a4569886", // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/Gem_Sample_Assets/GemMaterials/PurpleGem.mat
                "6ac01d29450339841a15c26eba3d8f69", // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/Gem_Sample_Assets/GemMaterials/RedGem.mat
                "670fd4fcf34aac041a7e8e0371e823dd", // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/Gem_Sample_Assets/GemMaterials/TurquoiseGem.mat
                "df3e5d3bc81bf6c46a04d49fc90e6ffe", // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/Gem_Sample_Assets/GemMaterials/WhiteGem.mat
                "9fc65c41a4b61824fa4ceab8da248ccd", // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/Gem_Sample_Assets/GemMaterials/YellowAndBlueGem.mat
                "84dfbffad7f596740917a1141ee43da2", // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/LightBlue.mat
                "2818ac500dfe28a4a85d13db74f5dcbe", // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/LightWhite.mat
                "f7eefc425eaa92b4ebffefdbb614d3d9", // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/Metallic.mat
                "88355daa712318d4eae5fce35352e6dd", // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/SolidGreen.mat
                "477ec3581917a6d4f8208e7033266223", // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/SolidRed.mat
                "3e5c4d6f454685c48af83064384632f6", // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/SolidWhite.mat
                "2f80c16eced9cb349a82cdbda5bd188d", // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/SolidWhiteSmooth.mat
                "a8131972d52e03346bee8239f2411e6a", // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/tex_armor(Clone)_asset2.mat
                "1429d632eff8a234c93a9b7fb5f5668a", // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/tex_body(Clone)_asset0.mat
                "a73dfe133639fa84e8e7d782a6aa3b74", // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/tex_face(Clone)_asset4.mat
                "43fa3186550698f47a2b59113d4f7a6f", // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/tex_faceoption(Clone)_asset5.mat
                "442460180ad002b41bb56108bbcfb4dd", // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/tex_hair(Clone)_asset3.mat
                "262edb4e47175d548ba2702c87fce227", // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/tex_photon(Clone)_asset1.mat
                "ca4943be5b3769a489a1cda05ee74f4c", // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_CornelBox_Assets/Materials/Transparent.mat
                "87becb86f20ba0e419af2c5c8a436ba4", // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/mat/tex_armor.mat
                "8b15ad46734538841955a43f514e9eeb", // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/mat/tex_body.mat
                "1004a60cbe00f9c48b9a4416c792490f", // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/mat/tex_face.mat
                "c54ec1195bccfbd4a96cab6eda085d3a", // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/mat/tex_faceoption.mat
                "419055f2e83080543a4c34a4f539967e", // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/mat/tex_hair.mat
                "249b5835018dde04aa22f00a83f47552", // Assets/VketShaderPack/Unlit_WF_ShaderSuite/Examples/UnToon_Sample_Assets/2a7s_2eroVRC/mat/tex_photon.mat
                "5686e1cbe30779e4cb12a3cfebd04af4", // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/XSToon 2.0 _ Carbon Fiber.mat
                "80add08b1b71e974cb7445f615a6d45f", // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/XSToon 2.0 _ StippledHalftone.mat
                "072ae31b0e1564b4eb95e3b4437e7d1d", // Assets/VketShaderPack/Xiexes-Unity-Shaders-2.2.4.1/XSToon 2.0.mat
            };
        }

        public virtual string[] GetPickupObjectSyncPrefabGUIDs()
        {
            return new string[]
            {
                "304812fb2352c7c419581d8f68b23f94", // Assets/VketAssets/UdonPrefabs/Udon_PickupObjectSync/PickupObjectSync.prefab
            };
        }


        public virtual string[] GetAvatarPedestalPrefabGUIDs()
        {
            return new string[]
            {
                "59261512e4100df488de6ddd9b530829", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_2D_L.prefab
                "3e6652d46d6d66d4092650094b064987", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_2D_M.prefab
                "87a721a2eb0c25643a5eb305781dc3a8", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_2D_S.prefab
                "104b8771f1874de40bf91473c2afb5ec", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_3D_L.prefab
                "2cdd22b46ff13f2409e7dd60e077eed7", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_3D_M.prefab
                "045501f8edaa2e748857c6c17a96b2f1", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_3D_S.prefab
                "d7a2d6aa4218cdd45854cd81900deba6", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_Default_L.prefab
                "8134e8c0ab5943a479b31c509f2325fb", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_Default_M.prefab
                "fb107661b9b479d4fa95452f7fd46426", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_Default_S.prefab
            };
        }

        public virtual string[] GetUdonBehaviourPrefabGUIDs()
        {
            return new string[]
            {
                "304812fb2352c7c419581d8f68b23f94", // Assets/VketAssets/UdonPrefabs/Udon_PickupObjectSync/PickupObjectSync.prefab
                "59261512e4100df488de6ddd9b530829", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_2D_L.prefab
                "3e6652d46d6d66d4092650094b064987", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_2D_M.prefab
                "87a721a2eb0c25643a5eb305781dc3a8", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_2D_S.prefab
                "104b8771f1874de40bf91473c2afb5ec", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_3D_L.prefab
                "2cdd22b46ff13f2409e7dd60e077eed7", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_3D_M.prefab
                "045501f8edaa2e748857c6c17a96b2f1", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_3D_S.prefab
                "d7a2d6aa4218cdd45854cd81900deba6", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_Default_L.prefab
                "8134e8c0ab5943a479b31c509f2325fb", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_Default_M.prefab
                "fb107661b9b479d4fa95452f7fd46426", // Assets/VketAssets/UdonPrefabs/Udon_AvatarPedestal/AvatarPedestal_Default_S.prefab
                "63af405779b7d6d44b64d709fb3fbdd7", // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/CirclePageOpener2D_L.prefab
                "ae8b674ab5516664ea5d5c535f5fbc6a", // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/CirclePageOpener2D_M.prefab
                "405b6beaa9b7b9947b9111840f170452", // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/CirclePageOpener2D_S.prefab
                "139aa3624bf91214dabb39362ccf4382", // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/CirclePageOpener3D_L.prefab
                "4cb05397779ec7a48818e05b68c26960", // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/CirclePageOpener3D_M.prefab
                "a4471dc2b540f9e46a5e36fe66ede5e9", // Assets/VketAssets/UdonPrefabs/Udon_CirclePageOpener/CirclePageOpener3D_S.prefab

                "3c0dbec26839f9b4ea24f9606ec62ce4", // Assets/VketAssets/VketPrefabs/UITemplate/UI_Button.prefab
                "b4625b5c33c27804d889d16704b81c33", // Assets/VketAssets/VketPrefabs/UITemplate/UI_Image.prefab
                "4dc5396d6e370ef4fa9b9e9458c3f735", // Assets/VketAssets/VketPrefabs/UITemplate/UI_Text.prefab
                "333992c7f0890014d9a775e3f2303857", // Assets/VketAssets/VketPrefabs/UITemplate/UI_TextMeshPro.prefab
                "da2f193786576d041aa8d2e860314c22", // Assets/VketAssets/VketPrefabs/VketAvatarPedestal/VketAvatarPedestal_2D.prefab
                "9fffe84a94533884eaf481963546643d", // Assets/VketAssets/VketPrefabs/VketAvatarPedestal/VketAvatarPedestal_3D.prefab
                "1e0f83d3ba1d83045866a6a4dc2e8e83", // Assets/VketAssets/VketPrefabs/VketAvatarPedestal/VketAvatarPedestal_Default.prefab
                "8c011f4ab9cc45c4aaddb76bbd8003c5", // Assets/VketAssets/VketPrefabs/VketLanguageSwitcher/VketLangageSwitcher.prefab
                "ba410268b82f1d940aedd0d418541c83", // Assets/VketAssets/VketPrefabs/VketPickup/VketFollowPickup.prefab
                "6d1e9170d4533ed448e46b707a3ee47a", // Assets/VketAssets/VketPrefabs/VketPickup/VketPickup.prefab
                "b2a6c13adeda05d40adb398906d58645", // Assets/VketAssets/VketPrefabs/VketSoundFade/VketSoundFade.prefab
                "73b0727ab433c3140929fbf088cd8b88", // Assets/VketAssets/VketPrefabs/VketVideoPlayer/VketVideoPlayer.prefab
                "5d4f49b1d4a5dca43b04aed3bc01b61f", // Assets/VketAssets/VketPrefabs/VketWebPageOpener/VketCirclePageOpener_2D.prefab
                "829918e636553bf489526e19e7c08a9f", // Assets/VketAssets/VketPrefabs/VketWebPageOpener/VketCirclePageOpener_3D.prefab
                "249a82240095e1a44b9b4aae5f72d41e", // Assets/VketAssets/VketPrefabs/VketWebPageOpener/VketItemPageOpener_2D.prefab
                "8b95eab6f59b5e64d9393292aca982ca", // Assets/VketAssets/VketPrefabs/VketWebPageOpener/VketItemPageOpener_3D.prefab
            };
        }

        public virtual string[] GetSizeIgnorePrefabGUIDs()
        {
            return new string[]
            {
                "e6d5c31911ec7404e8b613767bc9c944", // Assets/VketAssets/UdonPrefabs/Udon_WorldBGMFade/WorldBGMFade.prefab
            };
        }

        public virtual string[] GetUdonBehaviourGlobalLinkGUIDs()
        {
            return new string[]
            {
            };
        }

        public virtual string[] GetAudioSourcePrefabGUIDs()
        {
            return new string[]
            {
            };
        }

        public virtual string[] GetCanvasPrefabGUIDs()
        {
            return new string[]
            {
                "3c0dbec26839f9b4ea24f9606ec62ce4", // Assets/VketAssets/VketPrefabs/UITemplate/UI_Button.prefab
                "b4625b5c33c27804d889d16704b81c33", // Assets/VketAssets/VketPrefabs/UITemplate/UI_Image.prefab
                "4dc5396d6e370ef4fa9b9e9458c3f735", // Assets/VketAssets/VketPrefabs/UITemplate/UI_Text.prefab
                "333992c7f0890014d9a775e3f2303857", // Assets/VketAssets/VketPrefabs/UITemplate/UI_TextMeshPro.prefab
            };
        }

        public virtual string[] GetPointLightProbeGUIDs()
        {
            return new string[]
            {
            };
        }

        public virtual string[] GetVRCSDKPrefabGUIDs()
        {
            return new string[]
            {

                #region VRCSDK

                "2cdbe2e71e2c46e48951c13df254e5b1", // Assets/VRCSDK/version.txt
                "820ee6e459999be418b410c7af108bc3", // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.CognitoIdentity.dll
                "17e2ad8740ce0ab4eb1a95a73e362865", // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.CognitoIdentity.dll.mdb
                "aecaffc7454b52e448fc0ea1aef2dd1d", // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.Core.dll
                "027e8b8acf565544d9050219e1521b7e", // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.Core.dll.mdb
                "d4055bfc0cd67d642a7eceaf547c4901", // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.S3.dll
                "0da239ac72288814a9c4b799c7674b25", // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.S3.dll.mdb
                "625a50dd0dd525a49a41cb3e3117fa15", // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.SecurityToken.dll
                "b93a9778ddf074845b1649181fda7e86", // Assets/VRCSDK/Dependencies/AWSSDK/AWSSDK.SecurityToken.dll.mdb
                "34b0990e1522a284b9666d6821cd601c", // Assets/VRCSDK/Dependencies/DotZLib/DotZLib.dll
                "b609c54f9d3581e4fa22b3e389fd8d33", // Assets/VRCSDK/Dependencies/DotZLib/Plugins/x86/zlibwapi.dll
                "54f59547b5261e64f8256d6daaa01b17", // Assets/VRCSDK/Dependencies/DotZLib/Plugins/x86_64/zlibwapi.dll
                "a2e4b2ce02fa7914895069e5fdbf112d", // Assets/VRCSDK/Dependencies/librsync/Blake2Sharp.dll
                "912b2ac597cb1ad4c9bdc1a98ec15459", // Assets/VRCSDK/Dependencies/librsync/librsync.net.dll
                "cb850b86de9091d4db4595959c56f954", // Assets/VRCSDK/Dependencies/Oculus/Spatializer/Editor/ONSPAudioSourceEditor.cs
                "e503ea6418d27594caa33b93cac1b06a", // Assets/VRCSDK/Dependencies/Oculus/Spatializer/Scripts/ONSPAudioSource.cs
                "ad074644ff568a14187a3690cfbd7534", // Assets/VRCSDK/Dependencies/Oculus/Spatializer/Scripts/ONSPSettings.cs
                "5a8cc42eaba7a2a41b6ca3be3c40b315", // Assets/VRCSDK/Dependencies/SharpZipLib/ICSharpCode.SharpZipLib.dll
                "d471b09e7f06a69458457ec63d3532b8", // Assets/VRCSDK/Dependencies/VRChat/Settings.asset
                "10d9f721d76e07a47bc9e5f61e2fae72", // Assets/VRCSDK/Dependencies/VRChat/Editor/EnvConfig.cs
                "c3399613f583f3e46b2df27ae87dd5d6", // Assets/VRCSDK/Dependencies/VRChat/Editor/HDRColorFixerUtility.cs
                "7b8bb626428d0f341b9ed6a68cb5c9cc", // Assets/VRCSDK/Dependencies/VRChat/Editor/SDKUpdater.cs
                "679ba0056bf110c4db8b550082e73a5f", // Assets/VRCSDK/Dependencies/VRChat/Editor/ShaderKeywordsUtility.cs
                "4a9696f3dea8a764f9c4bc6d2e652b74", // Assets/VRCSDK/Dependencies/VRChat/Editor/VRCCachedWWW.cs
                "cb5d1f9882b08564cae97b2b14ad4e8f", // Assets/VRCSDK/Dependencies/VRChat/Editor/VRC_EditorTools.cs
                "f4cf5dd705ab67149afaba40b4a8fa7e", // Assets/VRCSDK/Dependencies/VRChat/Editor/VRC_SdkSplashScreen.cs
                "3d6a1d7b0624f414ba6fb922687a06da", // Assets/VRCSDK/Dependencies/VRChat/Editor/AWS/S3Manager.cs
                "21332e1f0d937794d916d2402ba1943a", // Assets/VRCSDK/Dependencies/VRChat/Editor/BuildPipeline/VRC.SDKBase.Editor.BuildPipeline.asmdef
                "0a1d20f4241085e46bdddc71b691465b", // Assets/VRCSDK/Dependencies/VRChat/Editor/BuildPipeline/Samples/VRCSDKBuildRequestedCallbackSample.cs
                "39cdf3092ab81be4b9e623cb5a8819d8", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/ApiCacheEditor.cs
                "0a364ece829b6234888c59987a305a00", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/AutoAddSpatialAudioComponents.cs
                "89005ebc9543e0a4284893c09ca19b1d", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/EditorCoroutine.cs
                "3d6c2e367eaa9564ebf6267ec163cfbd", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/EditorHandling.cs
                "4810e652e8242384c834320970702290", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/EventHandlerEditor.cs
                "482185bf29f12074dada194ffef6a682", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/OldTriggerEditors.cs
                "5e83254bb97e84795ac882692ae124ba", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRCAvatarDescriptorEditor.cs
                "26a75599848adb449b7aceed5090e35c", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRCObjectSpawnEditor.cs
                "ed4aad2698d3b62408e69b57c7748791", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRCObjectSyncEditor.cs
                "8986a640e24a0754ea0aded12234b808", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRCPlayerModEditorWindow.cs
                "792e7964a56e51f4188e1221751642e9", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRCPlayerModsEditor.cs
                "5262a02c32e41e047bdfdfc3b63db8ff", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRCPlayerStationEditor.cs
                "e9cbc493bbbc443fb92898aa84d221ec", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRCSceneDescriptorEditor.cs
                "eeda995d0ceac6443a54716996eab52e", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_AvatarVariationsEditor.cs
                "0ac7998a36f085844847acbc046d4e27", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_DataStorageEditor.cs
                "3b63b118c0591b548ba1797e6be4292e", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_DestructibleStandardEditor.cs
                "e19a7147a2386554a8e4d6e414f190a2", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_ObjectSyncEditor.cs
                "4aff4e5c0d600c845b29d7b8b7965d68", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_PickupEditor.cs
                "5c545625e0bf93045ac1c5864141c5c1", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_PlayerAudioOverrideEditor.cs
                "0d2d4cba733f5eb4ba170368e67710d2", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_SpatialAudioSourceEditor.cs
                "ae0e74693b7899f47bd98864f94b9311", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_SyncVideoPlayerEditor.cs
                "3f9dccfed0b072f49a307b3f20a7e768", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_SyncVideoStreamEditor.cs
                "3aecd666943878944a811acb9db2ace7", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_TriggerEditor.cs
                "d09b36020f697be4d9a0f5a6a48cfa83", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_WebPanelEditor.cs
                "764e26c1ca28e2e45a30c778c1955a47", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components/VRC_YouTubeSyncEditor.cs
                "d57b23c04034119448f23c5fdbc57662", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components3/VRCDestructibleUdonEditor.cs
                "8901d07a685ca424492a3cabff506184", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components3/VRCPlayerStationEditor3.cs
                "4b2b9ac625bc5b04c887ff9ee9b5fdbe", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components3/VRCSceneDescriptorEditor3.cs
                "a8cc4c1876b26174fbaeb062178a6bda", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components3/VRC_PickupEditor3.cs
                "3f8f999a8e1ebee4588f94a8a618d7c6", // Assets/VRCSDK/Dependencies/VRChat/Editor/Components3/VRC_SpatialAudioSourceEditor3.cs
                "310a760e312f2984e85eece367bab19a", // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/IVRCSdkControlPanelBuilder.cs
                "20b4cdbdda9655947aab6f8f2c90690f", // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanel.cs
                "5066cd5c1cc208143a1253cac821714a", // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanelAccount.cs
                "4c73e735ee0380241b186a8993fa56bf", // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanelBuilder.cs
                "c768b42ca9a2f2b48afeb1fa03d5e1bf", // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanelBuilderAttribute.cs
                "c7333cdb3df19724b84b4a1b05093fe0", // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanelContent.cs
                "f3507a74e4b8cfd469afac127fa5f4e5", // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanelHelp.cs
                "8357b9b7ef2416946ae86f465a64c0e0", // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanelSettings.cs
                "f2a720a30f1043247af7742fdfd0b8e5", // Assets/VRCSDK/Dependencies/VRChat/Editor/ControlPanel/VRCSdkControlPanelWorldBuilder.cs
                "93710d221addc0243ba90dd20369844b", // Assets/VRCSDK/Dependencies/VRChat/Editor/SDK3Compatibility/VRCSdk3Analysis.cs
                "c18570190ea21fa4babc80af77d4d766", // Assets/VRCSDK/Dependencies/VRChat/Editor/ShaderStripping/StripPostProcessing.cs
                "b1e8486f7c7c81a4ea45be9776971082", // Assets/VRCSDK/Dependencies/VRChat/Editor/ShaderStripping/VRC.SDKBase.Editor.ShaderStripping.asmdef
                "62d40cc4e8f8494695f0102c58b3ea60", // Assets/VRCSDK/Dependencies/VRChat/Editor/Validation/Performance/SDKPerformanceDisplay.cs
                "da07ab9b78cb0432e95e11e2cb619ea7", // Assets/VRCSDK/Dependencies/VRChat/Materials/BlueprintCam.mat
                "94b649c2bd1ac4cac95049605dc5333d", // Assets/VRCSDK/Dependencies/VRChat/Materials/BlueprintCam.renderTexture
                "2166f6bbfce69594fad494087eca58e8", // Assets/VRCSDK/Dependencies/VRChat/Materials/damageGrey.mat
                "e13e96301b7c8214dac6883be5b82bfa", // Assets/VRCSDK/Dependencies/VRChat/Models/damageSphere.fbx
                "841c3ce718e8b61408005c1cfce6b7de", // Assets/VRCSDK/Dependencies/VRChat/Models/Materials/lambert2.mat
                "4acdf7b3eb426480bb5acf58638bd493", // Assets/VRCSDK/Dependencies/VRChat/Resources/awsconfig.xml
                "dd5614b710e774040ab715161f7dfaca", // Assets/VRCSDK/Dependencies/VRChat/Resources/endpoints.customizations.json
                "37b4abef7420c4c7ea71dbe76757498a", // Assets/VRCSDK/Dependencies/VRChat/Resources/endpoints.json
                "be98467dc5d3c4eb1aeef22952913b0e", // Assets/VRCSDK/Dependencies/VRChat/Resources/VRCCam.prefab
                "dce0dda226bd1f147a34f9b4660f5992", // Assets/VRCSDK/Dependencies/VRChat/Resources/VRCProjectSettings.prefab
                "b14e1b78a061f8543b2f4120b5c369fa", // Assets/VRCSDK/Dependencies/VRChat/Resources/VRCSDKAvatar.prefab
                "248f850c58993ed43bcaad6b934b7c92", // Assets/VRCSDK/Dependencies/VRChat/Resources/vrcSdkBottomHeader.png
                "551946bfd2b165f419f297805d1e1256", // Assets/VRCSDK/Dependencies/VRChat/Resources/vrcSdkBottomHeader_Oculus_Quest.png
                "d2244637721b4f3458280ffc1f9dd7cc", // Assets/VRCSDK/Dependencies/VRChat/Resources/vrcSdkClDialogNewIcon.png
                "38956f4b67ba0984587b1a913d05beea", // Assets/VRCSDK/Dependencies/VRChat/Resources/vrcSdkHeader.png
                "ff7f4f4963793a340bde459bc9975c07", // Assets/VRCSDK/Dependencies/VRChat/Resources/vrcSdkHeaderWithCommunityLabs.png
                "1d151b29d1d1c704daa27e4921e39129", // Assets/VRCSDK/Dependencies/VRChat/Resources/vrcSdkSplashUdon1.png
                "8458230047d35d4498b2de453f2cabda", // Assets/VRCSDK/Dependencies/VRChat/Resources/vrcSdkSplashUdon2.png
                "fc887d4eeb5a941ed86bca0135b05e2b", // Assets/VRCSDK/Dependencies/VRChat/Resources/VRCSDKWorld.prefab
                "e8e780ff40c6a484294bfec8711ced23", // Assets/VRCSDK/Dependencies/VRChat/Resources/VRC_PlayerVisualDamage.prefab
                "43066d8a73c579048891e3c123e252a0", // Assets/VRCSDK/Dependencies/VRChat/Resources/2FAIcons/SDK_Warning_Triangle_icon.png
                "f310c3dbad3125d4e8fc2e00bdc2acb4", // Assets/VRCSDK/Dependencies/VRChat/Resources/CL_Icons/CL_Lab_Icon_256.png
                "36349feed06587e479724a1a09c0b267", // Assets/VRCSDK/Dependencies/VRChat/Resources/CL_Icons/Icon_New.png
                "4109d4977ddfb6548b458318e220ac70", // Assets/VRCSDK/Dependencies/VRChat/Resources/PerformanceIcons/Perf_Good_32.png
                "644caf5607820c7418cf0d248b12f33b", // Assets/VRCSDK/Dependencies/VRChat/Resources/PerformanceIcons/Perf_Great_32.png
                "2886eb1248200a94d9eaec82336fbbad", // Assets/VRCSDK/Dependencies/VRChat/Resources/PerformanceIcons/Perf_Horrible_32.png
                "9296abd40c7c1934cb668aae07b41c69", // Assets/VRCSDK/Dependencies/VRChat/Resources/PerformanceIcons/Perf_Medium_32.png
                "e561d0406779ab948b7f155498d101ee", // Assets/VRCSDK/Dependencies/VRChat/Resources/PerformanceIcons/Perf_Poor_32.png
                "8ae6e7ea5b8982143aa8c2c4e2fe81c6", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/AnimatorPerformanceScanner.asset
                "c2ca835e9f95b464b8a2df5c181ba44e", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/AudioPerformanceScanner.asset
                "d162a2d08d890e644b79b605f1d1120e", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/ClothPerformanceScanner.asset
                "371dfb95b91b4684eb1ad68d37d81ac9", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/DynamicBonePerformanceScanner.asset
                "69c7115984bf82e46af96d6f144fe463", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/LightPerformanceScanner.asset
                "07199be0cf1b2a34f8dff60d486129ea", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/LineRendererPerformanceScanner.asset
                "e750aae2c41768e4485dfb9a6de00454", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/MeshPerformanceScanner.asset
                "f4004220746a95a4e84a3909a49d844b", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/ParticlePerformanceScanner.asset
                "18ec5f6f963b6774fa1b84c5bff0246f", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/PhysicsPerformanceScanner.asset
                "986c284df70b4c34dad7e5ef27a86156", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/Scanners/TrailRendererPerformanceScanner.asset
                "bf50321b92d503d4a823939356ce856d", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/ScannerSets/PerformanceScannerSet_Quest.asset
                "b0d7b483809dd6441bb36507c9f64040", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/ScannerSets/PerformanceScannerSet_Windows.asset
                "f0f530dea3891c04e8ab37831627e702", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Quest/AvatarPerformanceStatLevels_Quest.asset
                "e750436d0bab192489da0debe67ee879", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Quest/Excellent_Quest.asset
                "b25db21b17fba3d49a7248568fdb9870", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Quest/Good_Quest.asset
                "31feb7417182a80469408649071d10ac", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Quest/Medium_Quest.asset
                "171503e8193e15447967be1e3ca1e714", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Quest/Poor_Quest.asset
                "438f83f183e95f740877d4c22ed91af2", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Windows/AvatarPerformanceStatLevels_Windows.asset
                "88c46902276e7624e8adda9020bef28b", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Windows/Excellent_Windows.asset
                "38957d57ab5a7f145b954d20fc24b1d4", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Windows/Good_Windows.asset
                "65edaefdc2f87414594559cb89383b5b", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Windows/Medium_Windows.asset
                "595049d4e162571489f2437524d98a31", // Assets/VRCSDK/Dependencies/VRChat/Resources/Validation/Performance/StatsLevels/Windows/Poor_Windows.asset
                "36c0d886a26373c46be857f2fc441071", // Assets/VRCSDK/Dependencies/VRChat/Scripts/ApiFileHelper.cs
                "acadc6659c5ab3446ad0d5de2563f95f", // Assets/VRCSDK/Dependencies/VRChat/Scripts/AudioManagerSettings.cs
                "8d047eaa3325d654aa62ccad6f73eb93", // Assets/VRCSDK/Dependencies/VRChat/Scripts/CommunityLabsConstants.cs
                "e1c693656bf5d584b87df969efeb5536", // Assets/VRCSDK/Dependencies/VRChat/Scripts/ContentUploadedDialog.cs
                "a3132e0ab7e16494a9d492087a1ca447", // Assets/VRCSDK/Dependencies/VRChat/Scripts/RuntimeAPICreation.cs
                "1e5ebf65c5dceeb4c909aa7812bd2999", // Assets/VRCSDK/Dependencies/VRChat/Scripts/RuntimeBlueprintCreation.cs
                "2bd5ee5d69ee0f3449bf2f81fcb7f4e3", // Assets/VRCSDK/Dependencies/VRChat/Scripts/RuntimeWorldCreation.cs
                "0d49300ad532d4ae6b569b28de5b7dac", // Assets/VRCSDK/Dependencies/VRChat/Scripts/SceneSaver.cs
                "10121679f780956408f9a434a526f553", // Assets/VRCSDK/Dependencies/VRChat/Scripts/MaterialFallback/FallbackMaterialCache.cs
                "bef0a8d1d2c547119a62b7d7a5c512ea", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/ShaderValidation.cs
                "8a90ec11b51863c4cb2d8a8cee31c2fb", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/ValidationUtils.cs
                "9b03724cd556cb047b2da80492ea28a5", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/WorldValidation.cs
                "15ecac6f7fdc1bc4fb723fee6f4635dd", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/AvatarPerformance.cs
                "f1ce994297384ff1bc330196df61b7ca", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/AvatarPerformanceCategory.cs
                "f28c978154794266b38d686139c6b872", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/MeshUtils.cs
                "8cdca9d06d1b4732b9ccb82a38bb8d9c", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/PerformanceFilterSet.cs
                "a5ed7498cb1a46c78eab031f5f32448c", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/PerformanceInfoDisplayLevel.cs
                "5019a55ee9e2404c81bc61a39a010d8d", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/PerformanceRating.cs
                "4afb61f36d144fc381114cd7f78d13e7", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/PerformanceScannerSet.cs
                "abda65e062e44213aa3e1f4c82b400a8", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Filters/AbstractPerformanceFilter.cs
                "0bd0691a021844f49444a04a959d6328", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/AbstractPerformanceScanner.cs
                "08c8e931d0544866a0f626855d9c1841", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/AnimatorPerformanceScanner.cs
                "b3a8bba736414d1aaa9e766da27b56b5", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/AudioPerformanceScanner.cs
                "0cec88b5a46f459195f10a2f11fddb2f", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/ClothPerformanceScanner.cs
                "a226df494ef04404a9a47c714822ab9f", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/DynamicBonePerformanceScanner.cs
                "405778fdc32c44c1bb9fdd0476fb0007", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/LightPerformanceScanner.cs
                "ec87392b85844f7bb526a48ec866a8f0", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/LineRendererPerformanceScanner.cs
                "38bca10261df4ddfa10cff3b3bbb9428", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/MeshPerformanceScanner.cs
                "10723e354ff14f98a49ab797b3f005e6", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/ParticlePerformanceScanner.cs
                "6a94ecdeecd04f85824cc3244be5712a", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/PhysicsPerformanceScanner.cs
                "2efd714b564547b4be1ebd1f2700668b", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Scanners/TrailRendererPerformanceScanner.cs
                "1bf4fb79a49d4b109c4dce6b38e5548e", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Stats/AvatarPerformanceStats.cs
                "f742c36dce5730f4d96e37d82c330584", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Stats/AvatarPerformanceStatsLevel.cs
                "468554b1bfc447f41a20a2f5bae65d16", // Assets/VRCSDK/Dependencies/VRChat/Scripts/Validation/Performance/Stats/AvatarPerformanceStatsLevelSet.cs
                "9ae7399f0cf902a41a20f3487af8322a", // Assets/VRCSDK/Dependencies/VRChat/SdkGraphics/SDK_Panel_Banner.png
                "13d3efffb839ced4c8426a88a0c3e98c", // Assets/VRCSDK/Dependencies/VRChat/Textures/damageGreyNoAlpha.png
                "8d95767408d35544c98f92ef7279b8db", // Assets/VRCSDK/Dependencies/VRChat/Textures/damageGRNoAlpha.png
                "861bc2dd35aa1534d89330ffa4434b61", // Assets/VRCSDK/Dependencies/VRChat/Textures/VRChatBanner.png
                "3bb6d22e89000724b90fb830af69384b", // Assets/VRCSDK/Plugins/sqlite3.dll
                "4ecd63eff847044b68db9453ce219299", // Assets/VRCSDK/Plugins/VRCCore-Editor.dll
                "b0e1c0f72d838fe49bfe88b987a471bd", // Assets/VRCSDK/Plugins/VRCCore-Standalone.dll
                "215be632cb025bd429dd50a3fa942168", // Assets/VRCSDK/Plugins/VRCSDK3-Editor.dll
                "661092b4961be7145bfbe56e1e62337b", // Assets/VRCSDK/Plugins/VRCSDK3.dll
                "d09383607271b19468447945fda29e86", // Assets/VRCSDK/Plugins/VRCSDK3Base-Editor.dll
                "bdccfb093344e7545a49b72a64499682", // Assets/VRCSDK/Plugins/VRCSDK3Base.dll
                "dc5cab6c932db3247aab9f50c5f3bd5f", // Assets/VRCSDK/Plugins/VRCSDKBase-Editor.dll
                "db48663b319a020429e3b1265f97aff1", // Assets/VRCSDK/Plugins/VRCSDKBase.dll

                #endregion

                #region Udon

                "45115577ef41a5b4ca741ed302693907", // Assets/Udon/UdonBehaviour.cs
                "530bdb25a3862ff4c8be42f678c53527", // Assets/Udon/UdonManager.cs
                "473737f63e15e204aa3a3df7a3a173e3", // Assets/Udon/version.txt
                "3c1bc1267eab5884ebe7f232c09ee0d9", // Assets/Udon/VRC.Udon.asmdef
                "84de2da7fe8ad8e439c084731189bc12", // Assets/Udon/Editor/UdonBehaviourEditor.cs
                "66ebdaa27f6d2d54cbb62abddc493674", // Assets/Udon/Editor/UdonEditorManager.cs
                "627c4d5cd580ddf41bd320e784fe8b9d", // Assets/Udon/Editor/VRC.Udon.Editor.asmdef
                "8b6535096cfa29340897276abbdd015f", // Assets/Udon/Editor/External/VRC.Udon.Compiler.dll
                "585dd63e377866248b16bdba915820ed", // Assets/Udon/Editor/External/VRC.Udon.EditorBindings.dll
                "b335798a4f28bec40ba9b3d4a15acee7", // Assets/Udon/Editor/External/VRC.Udon.Graph.dll
                "21dcba1a47cc8c84381629950b692129", // Assets/Udon/Editor/External/VRC.Udon.UAssembly.dll
                "161140ecae894b84ba7bdd6e44ff4371", // Assets/Udon/Editor/External/VRC.Udon.VRCGraphModules.dll
                "19cff77330d183441a69ff6c69e07629", // Assets/Udon/Editor/External/VRC.Udon.VRCTypeResolverModules.dll
                "cac80b40f57c41d4b941dc5059271583", // Assets/Udon/Editor/GraphModules/VRCInstantiateNodeRegistry.cs
                "e1b5b45f24b268b42826fc5c5497dc15", // Assets/Udon/Editor/ProgramSources/SerializedUdonProgramAssetEditor.cs
                "0e5ced9511d591140b191bbd9e948e61", // Assets/Udon/Editor/ProgramSources/Attributes/UdonProgramSourceNewMenuAttribute.cs
                "22203902d63dec94194fefc3e155c43b", // Assets/Udon/Editor/ProgramSources/UdonAssemblyProgram/UdonAssemblyProgramAsset.cs
                "3df823f3ab561fc43bcb81286e14b91d", // Assets/Udon/Editor/ProgramSources/UdonAssemblyProgram/UdonAssemblyProgramAssetEditor.cs
                "3c0638314c289c24193b47d1c53c9fca", // Assets/Udon/Editor/ProgramSources/UdonAssemblyProgram/UdonAssemblyProgramAssetImporter.cs
                "4f11136daadff0b44ac2278a314682ab", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UdonGraphProgramAsset.cs
                "31d6811854f59254aa1a263a8d566eb2", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UdonGraphProgramAssetEditor.cs
                "57422d3fdb0cc124189c68f87b7157cd", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/UdonGraphExtensions.cs
                "e2f2300f99ce0ea4a8d9a20b464384df", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/TypeExtension.cs
                "9214873dab0ea8a4b91861cd5a04dae3", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/UdonGraph.cs
                "f166d8f1c152ef34899019ab9a4fd0f2", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/UdonGraphElementData.cs
                "54dd824c6c614b94183d92710efe4f5f", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/UdonGraphStatus.cs
                "87e2044d3bcb715499ac68cc7380a9ed", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/UdonGraphViewSettings.cs
                "c6f017dc2674fec4da54a57b2655a948", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/UdonGraphWindow.cs
                "5dcd92112af21784ba5bf6383abab768", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/UdonParameterField.cs
                "70616b8b964e3664780fc03f65f27f4f", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/UdonParameterProperty.cs
                "fddc146e8502d7b49a294b6264d66dfd", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/UdonProgramSourceView.cs
                "e5786fc577943ae45953c6f54c97116b", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/UdonWelcomeView.cs
                "aabdd863f82551d40bd3a1b0835d2fc3", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/VideoPlayerElement.cs
                "469db50616185d04e8a46dcd75db12d2", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/GraphElementExtension.cs
                "f4f0ade55ae13b6468a765826f1f2540", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/UdonArrayInspector.cs
                "7e5916b8dd19e4445a9156a457b82ee4", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/UdonComment.cs
                "ba3ecc4c46929404d8c2ec920743b823", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/UdonGraphElement.cs
                "1b8045222a10ce04b815642b9cd5ca17", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/UdonGroup.cs
                "b006d67642298f04e895b6709ef12429", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/UdonMinimap.cs
                "dcd657bc1dcf357448d27bcfa8c5dc36", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/UdonNode.cs
                "8f83d1d3578dd28498c71a980bca86dd", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/UdonPort.cs
                "c5cfbbfcd7bb5ad4487f1f9388a3a168", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/UdonStackNode.cs
                "2d0a4730c5f61b247b27b54f280300b5", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/GraphElements/UdonVariablesBlackboard.cs
                "6581176c97993bb40976acff208bd0b1", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/Search/UdonFocusedSearchWindow.cs
                "b721120e6c1d320448a55fe87a7de824", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/Search/UdonFullSearchWindow.cs
                "e94c084f399869b42a21244fd07778c4", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/Search/UdonPortSearchWindow.cs
                "6a6c453fae11b5349a33399e258d1578", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/Search/UdonRegistrySearchWindow.cs
                "e5a10bb1987c27944bd08a88119b2844", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/Search/UdonSearchManager.cs
                "d825ed3ba6aa7f14294e73efefc217d0", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/Search/UdonSearchWindowBase.cs
                "16fc7a7a059deeb458fdcdf719b467a4", // Assets/Udon/Editor/ProgramSources/UdonGraphProgram/UI/GraphView/Search/UdonVariableTypeWindow.cs
                "264ec3c8a1d423f42a144da0df6c5ebe", // Assets/Udon/Editor/ProgramSources/UdonProgram/UdonProgramAsset.cs
                "41d70977fa7936441afe41442f1862b2", // Assets/Udon/Editor/ProgramSources/UdonProgram/UdonProgramAssetEditor.cs
                "9e84f8ee45862f04ca6b9f8d5c7f5897", // Assets/Udon/Editor/Resources/CornerResize.png
                "632470b93f35ec64ab6e3efd639c986c", // Assets/Udon/Editor/Resources/DarkButtonBG.png
                "d4ca7f47895ab36408e28f4f742fba99", // Assets/Udon/Editor/Resources/DropdownBG.png
                "f43fd332539599c47b3bb05ea38d5d0d", // Assets/Udon/Editor/Resources/ToolbarBG.png
                "5cbfe49b858635b44844a178cb934b68", // Assets/Udon/Editor/Resources/ToolbarButtonBG.png
                "7dade49b2f58f734f8db0983d8e7fb60", // Assets/Udon/Editor/Resources/UdonChangelog.uxml
                "927841c571a405846b3442bc0aa56220", // Assets/Udon/Editor/Resources/UdonFlowSlot.png
                "3803fec4c7b065042891595e749524cc", // Assets/Udon/Editor/Resources/UdonFlowSlotFilled.png
                "7c75c00422f12124faed19bfb8dd96df", // Assets/Udon/Editor/Resources/UdonFlowSlotFilledLight.png
                "610088fc92e5fc64b8c7f9e9c51f2939", // Assets/Udon/Editor/Resources/UdonFlowSlotLight.png
                "d47fd176596dfbe4e9e78964b40c93ee", // Assets/Udon/Editor/Resources/UdonGraphNeonStyle.uss
                "815baa9989198624aa5fec5ecdb42bd0", // Assets/Udon/Editor/Resources/UdonGraphStyle.uss
                "0e2cfcbd717e75441b108d3ad9de2d29", // Assets/Udon/Editor/Resources/UdonLogo.png
                "8cf68553c5a4bb140a6341072891aa88", // Assets/Udon/Editor/Resources/UdonLogoAlpha.png
                "d0608d33a4043b2499adb1fee18f2a64", // Assets/Udon/Editor/Resources/UdonLogoAlphaWhite.png
                "17102758d03099542afc7a1808745eaf", // Assets/Udon/Editor/Resources/UdonNodeAccent.png
                "c0230adfeb2abe242b8d64c7e3bd2adc", // Assets/Udon/Editor/Resources/UdonNodeActiveBackground.png
                "8289cc16393cd3040a9920e71bfe10bc", // Assets/Udon/Editor/Resources/UdonNodeActiveBackgroundLight.png
                "f47842ead2f80fa46ab6e5bbde409193", // Assets/Udon/Editor/Resources/UdonNodeBackground.png
                "c9235631e37566447ae4567624755326", // Assets/Udon/Editor/Resources/UdonNodeBackgroundLight.png
                "2d2675a75fea1d2438859bdb320d544d", // Assets/Udon/Editor/Resources/UdonNodeInlay.png
                "12f29a8be9fc52640b40f6ffa59336c6", // Assets/Udon/Editor/Resources/UdonNodeInlayLight.png
                "1ed47570201e1854d9e455e38eecbcf7", // Assets/Udon/Editor/Resources/UdonSettings.uxml
                "91b7c8d7d899ec04e9568e9385aba34d", // Assets/Udon/Editor/Resources/UdonSlot.png
                "3a1ab76e09365f14cab0665b40da8843", // Assets/Udon/Editor/Resources/UdonSlotFilled.png
                "add07ab72e2fc3d4d81143ab77d121f5", // Assets/Udon/Editor/Resources/UdonSlotFilledLight.png
                "1badb339ed4f23541b6db8a9420aeea9", // Assets/Udon/Editor/Resources/UdonSlotLight.png
                "37bd184e5e9b13945840f70329f2e0f6", // Assets/Udon/Editor/Resources/videoStill.png
                "c041fa712f66a5d4f8525cd447dc8b29", // Assets/Udon/Editor/TypeResolvers/UdonBehaviourTypeResolver.cs
                "02e7e7f5f9fc2c24ab3af0b8780f3623", // Assets/Udon/Editor/UnityEditorTests/UICompilerTests.cs
                "3c3c5a3876474c648a47177c1875f447", // Assets/Udon/Editor/UnityEditorTests/UnityEditorTests.asmdef
                "80455fb15755bfd47b1803c8fe84e16e", // Assets/Udon/External/VRC.Udon.ClientBindings.dll
                "a5e7b2f5005f10e44b082e7c18871cc6", // Assets/Udon/External/VRC.Udon.Common.dll
                "9d86dc4a513809149af3856eab191a3d", // Assets/Udon/External/VRC.Udon.Security.dll
                "ecb1eec40b5e47047891ee46e739186a", // Assets/Udon/External/VRC.Udon.VM.dll
                "92886df353bf1f14489cf2c4578e58af", // Assets/Udon/External/VRC.Udon.VRCWrapperModules.dll
                "a3a3dda899277cc4ea6aebe18c6b5736", // Assets/Udon/External/VRC.Udon.Wrapper.dll
                "bf61d954ecb803046953c666facfb904", // Assets/Udon/ProgramSources/SerializedUdonProgramAsset.cs
                "2fad63ba312d5f44a8ab215c3f5b18f1", // Assets/Udon/ProgramSources/Abstract/AbstractSerializedUdonProgramAsset.cs
                "7fa64b2d7df72fb4cbf7898a400e86ef", // Assets/Udon/ProgramSources/Abstract/AbstractUdonProgramSource.cs
                "b1d0b8aa8084bcd44a572d524d7a31bb", // Assets/Udon/Serialization/Formatters/UdonGameObjectComponentReferenceFormatter.cs
                "f2626352b2a60eb41adc3580ae44c750", // Assets/Udon/Serialization/Formatters/UdonProgramFormatter.cs
                "ec4e6da38017fe7df076afceb30fa17c", // Assets/Udon/Serialization/OdinSerializer/LICENSE
                "2105a6c0e5c0955d2d4a704c5e9c9b8f", // Assets/Udon/Serialization/OdinSerializer/Version.txt
                "f70a94b0bedfa8ec50ed757f72032810", // Assets/Udon/Serialization/OdinSerializer/VRC.Udon.Serialization.OdinSerializer.asmdef
                "bfaf18dca1f68cc99ebeb0b862179265", // Assets/Udon/Serialization/OdinSerializer/Config/GlobalSerializationConfig.cs
                "4ac1e1612275111bd50db8a3de8ba9c4", // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/BaseDataReader.cs
                "501a7e1356f5fdc8e9bbefcd61a56490", // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/BaseDataReaderWriter.cs
                "9638b18c6b6b6532b3b3cd3a73fefc2a", // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/BaseDataWriter.cs
                "dc1fe25e670cf981ed66b3e85c3e4249", // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/IDataReader.cs
                "af6696e41807b3c3f9a1d73667f76701", // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/IDataWriter.cs
                "ee0465a1838833eb878447b34339d4f4", // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/Binary/BinaryDataReader.cs
                "1bc9e2503afdd0290574ebc14cf4a16d", // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/Binary/BinaryDataWriter.cs
                "1361420bc2b384389a065fd2fe59fb22", // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/Binary/BinaryEntryType.cs
                "7a3a6dce9e0b8317b3804b35f48f6a97", // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/Json/JsonConfig.cs
                "2ecc39ef0dc55ec10f83bb7eefd4f1db", // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/Json/JsonDataReader.cs
                "3e05b98a26be61fa9203d4a45bfc1e95", // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/Json/JsonDataWriter.cs
                "aad0a34e801ae645b359e4800ef7f636", // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/Json/JsonTextReader.cs
                "6a0f5e01b82ae0763f6f907157a2c9c8", // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/SerializationNodes/SerializationNode.cs
                "eab5938e837a8de93ce64c25399edde6", // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/SerializationNodes/SerializationNodeDataReader.cs
                "9321fb650525f4bed18119d187111569", // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/SerializationNodes/SerializationNodeDataReaderWriterConfig.cs
                "dd54f07c359d141095a031192c5ca084", // Assets/Udon/Serialization/OdinSerializer/Core/DataReaderWriters/SerializationNodes/SerializationNodeDataWriter.cs
                "0bdecd79f568c8a3252bb5a9f3e2acdc", // Assets/Udon/Serialization/OdinSerializer/Core/FormatterLocators/ArrayFormatterLocator.cs
                "c4228cdbba89e2a5d52357b998c3387d", // Assets/Udon/Serialization/OdinSerializer/Core/FormatterLocators/DelegateFormatterLocator.cs
                "cf715e98fa96d74c81b4d3f4491d2592", // Assets/Udon/Serialization/OdinSerializer/Core/FormatterLocators/FormatterLocator.cs
                "d35d0d1eb290f5d00e273d65e5db09d7", // Assets/Udon/Serialization/OdinSerializer/Core/FormatterLocators/GenericCollectionFormatterLocator.cs
                "f2a9beaeecdd6eb929ddb049d7846a14", // Assets/Udon/Serialization/OdinSerializer/Core/FormatterLocators/IFormatterLocator.cs
                "cdd12b278851bfdc68ca0d9e1e4f2d28", // Assets/Udon/Serialization/OdinSerializer/Core/FormatterLocators/ISerializableFormatterLocator.cs
                "876ae9a404abe412e663fd9bc03d3525", // Assets/Udon/Serialization/OdinSerializer/Core/FormatterLocators/SelfFormatterLocator.cs
                "00e10f526d476731ebc596ceb66271a6", // Assets/Udon/Serialization/OdinSerializer/Core/FormatterLocators/TypeFormatterLocator.cs
                "9aaf14140a26e04b861b027d5ddb8fb6", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/ArrayFormatter.cs
                "3f5dc00eb17e568de42119a7f0f30ee8", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/ArrayListFormatter.cs
                "9598679c29f3e3696941746c26f1ccf8", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/BaseFormatter.cs
                "dff51bfb9b4d71aa78b3e5c8fec8c924", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/DateTimeFormatter.cs
                "3480954e7eecdc9745c1d08721b2f8b3", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/DateTimeOffsetFormatter.cs
                "4f17b17e986ae6f3be6a2ea1b716fcaf", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/DelegateFormatter.cs
                "4402da708267c579874c808a813bfe62", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/DerivedDictionaryFormatter.cs
                "b80567603fe814a8b4341584f8c3b4a6", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/DictionaryFormatter.cs
                "5c21ee7e54dff531da57563e2f81fff5", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/DoubleLookupDictionaryFormatter.cs
                "54578488936f8484c97ba7c52bfb0563", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/EasyBaseFormatter.cs
                "e226537cbfa910681132da3718f41c34", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/EmittedFormatterAttribute.cs
                "149c482b2ab9c601b8bc2ecc20bbd8d9", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/EmptyTypeFormatter.cs
                "b7da6bf97199e0bb743f7639c17112ac", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/FormatterEmitter.cs
                "06ccb8250c692f2695d28bfd6bcd4273", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/GenericCollectionFormatter.cs
                "f1eaa1b43658215b6d81013928eac19e", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/HashSetFormatter.cs
                "0fcb040f1c493dc2a5224e446be8b3c9", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/IFormatter.cs
                "5cae1c5d1116a090d70b6d0289061d21", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/KeyValuePairFormatter.cs
                "ba4ee6777a44f6e9a8e2e0a222c0f7db", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/ListFormatter.cs
                "21078ce134ce87231526dee77088e7ab", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/MethodInfoFormatter.cs
                "ae604bc0ef4ef9938100804f05decb21", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/MinimalBaseFormatter.cs
                "dc1b5b3148988d0d4fc2dab60a5c146c", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/MultiDimensionalArrayFormatter.cs
                "f9ea00de8051ca957d994e11630671d9", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/NullableFormatter.cs
                "6b6a62ea2fe943a4b261f832e8a1f3dd", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/PrimitiveArrayFormatter.cs
                "8045e4edca7c27f5b16bd90d7101c935", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/QueueFormatter.cs
                "15fa864c9e3363220ceac4ec93c7f5b8", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/ReflectionFormatter.cs
                "dde0095df6bea6624dfa72a31127bc48", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/ReflectionOrEmittedBaseFormatter.cs
                "12a47dd574302b77ba3c5ac05cd04541", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/SelfFormatterFormatter.cs
                "0f59404c810d015ed87c7e1557188435", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/SerializableFormatter.cs
                "087303d0d43cf7ce5af060a0cc0b5d38", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/StackFormatter.cs
                "4b0676b49f03cc50a1e532cf23e3988e", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/TimeSpanFormatter.cs
                "c6529471b992ba4080a123aa504ef9ea", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/TypeFormatter.cs
                "4a7c8e71a3ef1124db10e72af34e1724", // Assets/Udon/Serialization/OdinSerializer/Core/Formatters/VersionFormatter.cs
                "23fa5d3fed3b4b9de502257a594b00de", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/AllowDeserializeInvalidDataAttribute.cs
                "92726834b08002d525b86fbb012e184f", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/AlwaysFormatsSelfAttribute.cs
                "72783638708ea644ba5c3e1b91f827f6", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/ArchitectureInfo.cs
                "ad4e17831e9503c1f11149997c609477", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/Buffer.cs
                "e7e73146f1e861c27c5608bff4142402", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/CachedMemoryStream.cs
                "4fd6ff4077bbbef9b366d8ffd9236173", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/CustomFormatterAttribute.cs
                "e02123fad495d06f2a89e5335f00126c", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/CustomGenericFormatterAttribute.cs
                "97e9e01eb36fd43879b166b6b3c2469b", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/CustomLogger.cs
                "95bb5531b6c1d1a5eab8400ea1bd6167", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/CustomSerializationPolicy.cs
                "c2a40a3e6a114e5a50c0af209b8ae35e", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/DataFormat.cs
                "0bd9ab6cf3bd913588b6652279b7a6ba", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/DefaultLoggers.cs
                "996e793dcc0920d2590cb61f0761d498", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/DefaultSerializationBinder.cs
                "c79df97337d89089be40beb2e272df0b", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/DeserializationContext.cs
                "ae849a3e6d277006f3b4dd58a5765955", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/EmittedAssemblyAttribute.cs
                "3b06b106636f38afbb25ddd11e0c597c", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/EntryType.cs
                "c73435dff291e72c0d9ce55b59c39145", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/ErrorHandlingPolicy.cs
                "df06475ac5299f402ca1bdee3cf7e702", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/ExcludeDataFromInspectorAttribute.cs
                "08528593c8dd764b6d928dcee6daca9f", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/FormatterLocationStep.cs
                "30194d27b77855bf09b9af809a761ca5", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/FormatterUtilities.cs
                "32f94aca65b8d09ddd7b3db72e08db3f", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/IAskIfCanFormatTypes.cs
                "7ef6b6dd5e3be66c3a66753cc7e799de", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/IExternalGuidReferenceResolver.cs
                "d1eaa1a505a876bebb9cad40d01989e9", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/IExternalIndexReferenceResolver.cs
                "9414cf6a3ea9a51afcf648fe9ea02bed", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/IExternalStringReferenceResolver.cs
                "8bab352682356b8a2b02842520a68a11", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/ILogger.cs
                "106ca47adfa52732b129015337a1c8cd", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/ISelfFormatter.cs
                "90bcbfdc0286ca48d51fc578a1e15b8f", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/ISerializationPolicy.cs
                "7de3f23805ad9d4b3d033eef45e3b59b", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/LoggingPolicy.cs
                "10eb7be2b7c363367c46bc5699a361a8", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/NodeInfo.cs
                "766bbafe64ad16f63af4b81eb430e380", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/OdinSerializeAttribute.cs
                "3db8c00661ec222984427ab12295940f", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/PrefabModification.cs
                "23ceed712f987034deb8e92c561a1d3b", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/PrefabModificationType.cs
                "96fec6c04f13e378def42ea5ad5dc940", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/PreviouslySerializedAsAttribute.cs
                "989e99cd5b8f922edc1b13bbc22f4289", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/ProperBitConverter.cs
                "82702718797409c332f9174bdad57bbc", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/RegisterFormatterAttribute.cs
                "a000ffc63858a974eb63d9ef6f91adac", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/RegisterFormatterLocatorAttribute.cs
                "dca124a461001ad1494664ed95539612", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/SerializationAbortException.cs
                "eba33c8e77e2084c660af46be1b547dd", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/SerializationConfig.cs
                "1e93880e733f9a6a084cf4061634e7fb", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/SerializationContext.cs
                "67a19021ff9e6b27d8e9257ad075055a", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/SerializationPolicies.cs
                "08607b6e9c39ec19c1b61341583c2f3e", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/SerializationUtility.cs
                "bc69d8fd9d15913a491a45d1e040faf6", // Assets/Udon/Serialization/OdinSerializer/Core/Misc/TwoWaySerializationBinder.cs
                "0e8d8c5a97fdc322a8b8471aaf02f469", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/BooleanSerializer.cs
                "8aa9f52771b0e4e6f8f0c438a4f0430b", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/ByteSerializer.cs
                "d44d1ae83013328d7b855275fa1cfad7", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/CharSerializer.cs
                "5a2a43b51cef79fd0e85028650394b55", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/ComplexTypeSerializer.cs
                "50c67937d611e4749188b838e4cff5dc", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/DecimalSerializer.cs
                "9fc4716f683bc313c24bfa537cdd97f6", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/DoubleSerializer.cs
                "7a5d23b139cd8e692702aa431b071d07", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/EnumSerializer.cs
                "19dcfa9f6a40979fc2b6c3ae0f24b67c", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/GuidSerializer.cs
                "d280b44f7c75a9a18484a84745998130", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/Int16Serializer.cs
                "eafebb70813195e03b1ba467931eb686", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/Int32Serializer.cs
                "afe45c48508431a62aba886d943d8501", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/Int64Serializer.cs
                "6ccaffe3090611c2ada67d49cf834771", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/IntPtrSerializer.cs
                "88f3ec418fdfdd7eabd6134f1de91991", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/SByteSerializer.cs
                "29261eaea99f2d34c42cdc0b04f95daa", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/Serializer.cs
                "7aa356971fd0b66eb59875b278fa7f03", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/SingleSerializer.cs
                "85996580a8691185d06ec342c5c43747", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/StringSerializer.cs
                "3936194ea64890e11a7db8474eb0bbcf", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/UInt16Serializer.cs
                "f30e426f88b471e498dd1853b7bbaee6", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/UInt32Serializer.cs
                "f55c085325e12800428d01e3535cb297", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/UInt64Serializer.cs
                "0ee9dd19c234e4b16c835b9188459e36", // Assets/Udon/Serialization/OdinSerializer/Core/Serializers/UIntPtrSerializer.cs
                "94a6cc2044fcd2cb317b1cdb1e8fcdaf", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/AOTSupportScanner.cs
                "f5fe153775edbadfa2b659e0e35dc881", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/AOTSupportUtilities.cs
                "aaf2f90207414827b53b85dae0eae82e", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/OdinPrefabSerializationEditorUtility.cs
                "de5584f66ccc5e072681a310c5987b8c", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/UnityReferenceResolver.cs
                "f670c1f9aa9ab0c5988e81802c005767", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/UnitySerializationInitializer.cs
                "9eb15f2339819bb651c7872d73c89776", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/UnitySerializationUtility.cs
                "864fb1c011715f9df2998d71ac8716f6", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/DictionaryKeySupport/BaseDictionaryKeyPathProvider.cs
                "ef6f699f176c2dfdea788982526f989a", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/DictionaryKeySupport/DictionaryKeyUtility.cs
                "b513c156933d8b833ccd40d717bf7e2b", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/DictionaryKeySupport/IDictionaryKeyPathProvider.cs
                "54f653ed4a4e15c07057283c11dce4d9", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/DictionaryKeySupport/RegisterDictionaryKeyPathProviderAttribute.cs
                "0405ef103432161dff609e75f71f3f55", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/DictionaryKeySupport/Vector2DictionaryKeyPathProvider.cs
                "1d61e235c606c1c9d7269f7e68471e38", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/DictionaryKeySupport/Vector3DictionaryKeyPathProvider.cs
                "51bb2cf369b5ea90948a20e4f2ebae48", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/DictionaryKeySupport/Vector4DictionaryKeyPathProvider.cs
                "3d2976bd61cccf62b11b4d3f02762465", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/AnimationCurveFormatter.cs
                "6ff1b29d64402a15d020739becd8661e", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/BoundsFormatter.cs
                "0878ec68b6ab3c9ebc365b6d139e4840", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/Color32Formatter.cs
                "25e35581ce6d1febd9ac41864a76ecdb", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/ColorBlockFormatter.cs
                "484768ba343a6a05522c29d81a4ce61d", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/ColorFormatter.cs
                "c3968bef792c5668478ac01be7645b30", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/CoroutineFormatter.cs
                "b5b415c00da8157ac50b8f5543f0b1d9", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/GradientAlphaKeyFormatter.cs
                "8936a3e43078251682f18923139f7aee", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/GradientColorKeyFormatter.cs
                "d5b54660d5342fd45e2e43775538879d", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/GradientFormatter.cs
                "68ac0b27f571616d3ed26c23eef40c8c", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/KeyframeFormatter.cs
                "afc596cd95a1ac316024d16f6fec6536", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/LayerMaskFormatter.cs
                "558323987bf9b75943382a5faa093ee3", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/QuaternionFormatter.cs
                "196809b991e565a48e3d4ad08cb30b5e", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/RectFormatter.cs
                "c934302874ac3315ed322feefefa1f9c", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/UnityEventFormatter.cs
                "70c675a7b4c71c685ee39d745ccb058b", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/Vector2Formatter.cs
                "da2644647af1368176103aa87de1dbaf", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/Vector3Formatter.cs
                "60afa8ede3981c383782a01ddc55e943", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/Formatters/Vector4Formatter.cs
                "ff1ca109149d83b03b39644f8045275e", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/IOverridesSerializationFormat.cs
                "8942002e9ac41c2bfd27c4fbedf93f09", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/IOverridesSerializationPolicy.cs
                "7279ec8ad7837f13ec833193ab4282cc", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/ISupportsPrefabSerialization.cs
                "ea095023abd05a7af0da4166dcefdee8", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/SerializationData.cs
                "c3cecb461cebbc940ede3b5ddb72382e", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/SerializedBehaviour.cs
                "56b88cfe9935184fe250bda018144f26", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/SerializedComponent.cs
                "d1b9fa6342beb9fdfc2c4bc1d8e5e971", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/SerializedMonoBehaviour.cs
                "6cb9325ffffee5d6ed94d71590b4049a", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/SerializedScriptableObject.cs
                "eefcd68a84ee7903b08c6254c17fafe3", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/SerializedStateMachineBehaviour.cs
                "d62f7ab4e5aa075b819d6c71e929686b", // Assets/Udon/Serialization/OdinSerializer/Unity Integration/SerializedUnityObjects/SerializedUnityObject.cs
                "78ce67c0b3c1975c520a08d1ff9fd24e", // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/FieldInfoExtensions.cs
                "068f5645a5c3f9ce36a580ec57e775d1", // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/GarbageFreeIterators.cs
                "0f84614827ff91701149564447a3932b", // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/LinqExtensions.cs
                "62088a9c188c943eb4035de16eb6ec32", // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/MemberInfoExtensions.cs
                "63a9a0384a6fe66fb04f82f325895b30", // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/MethodInfoExtensions.cs
                "1df9513f03131466eecad22d1b19c4d8", // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/Operator.cs
                "da8aea12015a2df5402c9e2d4f1cec5c", // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/PathUtilities.cs
                "7f13450d6fd82372ffa7ee075a8eb4c9", // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/PropertyInfoExtensions.cs
                "b554cbd9469011b544a2d92ae85a3b60", // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/StringExtensions.cs
                "a6a172cef14a88c7fb714df37bbecedb", // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/TypeExtensions.cs
                "eb77f5278e425e91b71e186df29a5f16", // Assets/Udon/Serialization/OdinSerializer/Utilities/Extensions/UnityExtensions.cs
                "787c97af872124f748a4a9b366f325d3", // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/AssemblyImportSettingsUtilities.cs
                "146b6bd1e3b0f0926205abf839ec9e6f", // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/Cache.cs
                "1bd625694c606aab0cb7895da4911c6a", // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/DoubleLookupDictionary.cs
                "bda92ec6156282448e883bf8f6a781fd", // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/EmitUtilities.cs
                "570028979953bd2c60b7e89ff7cef92e", // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/FastTypeComparer.cs
                "42e5d977e21c7a6524213a8a7dbee24a", // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/Flags.cs
                "783316da32d87acfae14953e341732a3", // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/ICacheNotificationReceiver.cs
                "1bc635f3755c60fe69f1895dd53974e2", // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/ImmutableList.cs
                "000592e93b119574207ea3bf59f659e4", // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/MemberAliasFieldInfo.cs
                "c1e85c1ef449ccb40e05f0afd3dd717f", // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/MemberAliasMethodInfo.cs
                "00bf47593f2a330c1bb41552bdc1233f", // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/MemberAliasPropertyInfo.cs
                "5ad884ed6013d621a310ceb4c954f62a", // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/ReferenceEqualityComparer.cs
                "0fe3820fb4651e200f17905245ec8be2", // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/UnityVersion.cs
                "93b4d01199b118896c756b09a9206fc0", // Assets/Udon/Serialization/OdinSerializer/Utilities/Misc/UnsafeUtilities.cs
                "f6cfa3d8ec4f885468d17f5b023d2529", // Assets/Udon/WrapperModules/ExternVRCInstantiate.cs

                #endregion

            };
        }

        public virtual string[] GetDisabledCallbak()
        {
            return new string[]
            {
                @"(Update)[ ,\n,\t]*\(.*\)",
                @"(LateUpdate)[ ,\n,\t]*\(.*\)",
                @"(FixedUpdate)[ ,\n,\t]*\(.*\)",
                @"(OnPlayerJoined)[ ,\n,\t]*\(.*\)",
                @"(OnPlayerLeft)[ ,\n,\t]*\(.*\)",
                @"(InputJump)[ ,\n,\t]*\(.*\)",
                @"(InputUse)[ ,\n,\t]*\(.*\)",
                @"(InputGrab)[ ,\n,\t]*\(.*\)",
                @"(InputDrop)[ ,\n,\t]*\(.*\)",
                @"(InputMoveHorizontal)[ ,\n,\t]*\(.*\)",
                @"(InputMoveVertical)[ ,\n,\t]*\(.*\)",
                @"(InputLookHorizontal)[ ,\n,\t]*\(.*\)",
                @"(InputLookVertical)[ ,\n,\t]*\(.*\)",
                @"(OnPlayerRespawn)[ ,\n,\t]*\(.*\)",
                "(#if)[ ,\n,\t]*(UNITY_EDITOR)",
            };
        }

        public virtual Dictionary<string,string> GetAllowedShaders()
        {
            return new Dictionary<string, string>();
        }

        public string[] GUIDs => GetGUIDs();
        public string[] MaterialGUIDs => GetMaterialGUIDs();
        public string[] PickupObjectSyncPrefabGUIDs => GetPickupObjectSyncPrefabGUIDs();
        public string[] AvatarPedestalPrefabGUIDs => GetAvatarPedestalPrefabGUIDs();
        public string[] UdonBehaviourPrefabGUIDs => GetUdonBehaviourPrefabGUIDs();
        public string[] UdonBehaviourGlobalLinkGUIDs => GetUdonBehaviourGlobalLinkGUIDs();
        public string[] SizeIgnorePrefabGUIDs => GetSizeIgnorePrefabGUIDs();
        public string[] AudioSourcePrefabGUIDs => GetAudioSourcePrefabGUIDs();
        public string[] CanvasPrefabGUIDs => GetCanvasPrefabGUIDs();
        public string[] PointLightProbeGUIDs => GetPointLightProbeGUIDs();
        public string[] VRCSDKPrefabGUIDs => GetVRCSDKPrefabGUIDs();
        public string[] DisabledCallback => GetDisabledCallbak();
        public Dictionary<string, string> AllowedShaders => GetAllowedShaders();
    }
}