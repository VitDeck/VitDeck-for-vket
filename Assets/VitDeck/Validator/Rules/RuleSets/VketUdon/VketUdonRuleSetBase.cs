#if VRC_SDK_VRCSDK3
using UnityEngine;
using VitDeck.Language;
using VRC.SDKBase;
using VRC.Udon;
using VRC.SDK3.Components;

namespace VitDeck.Validator.RuleSets
{

    /// <summary>
    /// Vket Udonの基本ルールセット。
    /// </summary>
    /// <remarks>
    /// 変数をabstractまたはvirtualプロパティで宣言し、継承先で上書きすることでワールドによる制限の違いを表現する。
    /// </remarks>
    public abstract class VketUdonRuleSetBase : IRuleSet
    {
        public abstract string RuleSetName
        {
            get;
        }

        protected IOfficialAssetData _officialAssetData;

        protected readonly long MegaByte = 1048576;

        private readonly VketTargetFinder targetFinder = new VketTargetFinder();
        public IValidationTargetFinder TargetFinder => targetFinder;

        protected IObjectDetector officialPrefabsDetector;

        public VketUdonRuleSetBase(IOfficialAssetData officialAssetData) : base()
        {
            _officialAssetData = officialAssetData;
            officialPrefabsDetector = new PrefabPartsDetector(
                _officialAssetData.AudioSourcePrefabGUIDs,
                _officialAssetData.AvatarPedestalPrefabGUIDs,
                _officialAssetData.PickupObjectSyncPrefabGUIDs,
                _officialAssetData.CanvasPrefabGUIDs,
                _officialAssetData.PointLightProbeGUIDs,
                _officialAssetData.UdonBehaviourPrefabGUIDs);
        }

        public virtual IRule[] GetRules()
        {
            // デフォルトで使っていたAttribute式は宣言時にconst以外のメンバーが利用できない。
            // 継承したプロパティを参照して挙動を変えることが出来ない為、直接リストを返す方式に変更した。
            return new IRule[]
            {

                new UnityVersionRule(LocalizedMessage.Get("VketRuleSetBase.UnityVersionRule.Title", "2018.4.20f1"), "2018.4.20f1"),

                new VRCSDKVersionRule(LocalizedMessage.Get("VketRuleSetBase.VRCSDKVersionRule.Title"),
                    new VRCSDKVersion("2021.03.09.13.57"),
                    "https://files.vrchat.cloud/sdk/VRCSDK3-WORLD-2021.03.09.13.57_Public.unitypackage"),

                new ExistInSubmitFolderRule(LocalizedMessage.Get("VketRuleSetBase.ExistInSubmitFolderRule.Title"), _officialAssetData.GUIDs, targetFinder),

                new AssetGuidBlacklistRule(LocalizedMessage.Get("VketRuleSetBase.OfficialAssetDontContainRule.Title"), _officialAssetData.GUIDs),

                new AssetNamingRule(LocalizedMessage.Get("VketRuleSetBase.NameOfFileAndFolderRule.Title"), @"[a-zA-Z0-9 _\.\-\(\)]+"),

                new AssetPathLengthRule(LocalizedMessage.Get("VketRuleSetBase.FilePathLengthLimitRule.Title", 184), 184),

                new AssetExtentionBlacklistRule(LocalizedMessage.Get("VketRuleSetBase.MeshFileTypeBlacklistRule.Title"),
                                                new string[]{".ma", ".mb", "max", "c4d", ".blend"}
                ),

                new ContainMatOrTexInAssetRule(LocalizedMessage.Get("VketRuleSetBase.ContainMatOrTexInAssetRule.Title")),

                new FolderSizeRule(LocalizedMessage.Get("VketRuleSetBase.FolderSizeRule.Title"), FolderSizeLimit),

                new ExhibitStructureRule(LocalizedMessage.Get("VketRuleSetBase.ExhibitStructureRule.Title"), ExhibitStructureRuleIsEnabled),

                new StaticFlagRule(LocalizedMessage.Get("VketRuleSetBase.StaticFlagsRule.Title")),

                new BoothBoundsRule(LocalizedMessage.Get("VketRuleSetBase.BoothBoundsRule.Title"),
                    size: BoothSizeLimit,
                    margin: 0.01f,
                    Vector3.zero,
                    _officialAssetData.SizeIgnorePrefabGUIDs),

                new AssetTypeLimitRule(
                    LocalizedMessage.Get("VketRuleSetBase.MaterialLimitRule.Title", MaterialUsesLimit),
                    typeof(Material),
                    MaterialUsesLimit,
                    _officialAssetData.MaterialGUIDs),

                new LightmapSizeLimitRule(
                    LocalizedMessage.Get("VketRuleSetBase.LightMapsLimitRule.Title", LightmapCountLimit, 512),
                    lightmapCountLimit: LightmapCountLimit,
                    lightmapResolutionLimit: 512),

                // シェーダーエラーの検出
                new ErrorShaderRule(LocalizedMessage.Get("Booth.ErrorShaderRule.Title")), 
                // // シェーダーホワイトリストのチェック
                // new ShaderWhitelistRule(LocalizedMessage.Get("Booth.ShaderWhiteListRule.Title"),
                //     _officialAssetData.AllowedShaders, LocalizedMessage.Get("Booth.ShaderWhiteListRule.Solution")), 

                new GlobalIlluminationBakedRule(LocalizedMessage.Get("VketRuleSetBase.GlobalIlluminationBakedRule.Title")),

                new UsableComponentListRule(LocalizedMessage.Get("VketRuleSetBase.UsableComponentListRule.Title"),
                    GetComponentReferences(),
                    ignorePrefabGUIDs: _officialAssetData.GUIDs),

                new SkinnedMeshRendererRule(LocalizedMessage.Get("VketRuleSetBase.SkinnedMeshRendererRule.Title")),

                new MeshRendererRule(LocalizedMessage.Get("VketRuleSetBase.MeshRendererRule.Title")),

                new ReflectionProbeRule(LocalizedMessage.Get("VketRuleSetBase.ReflectionProbeRule.Title")),

                new UseMeshColliderRule(LocalizedMessage.Get("VketRuleSetBase.UseMeshColliderRule.Title")),

                new LightCountLimitRule(LocalizedMessage.Get("VketRuleSetBase.DirectionalLightLimitRule.Title"), UnityEngine.LightType.Directional, 0),

                new LightConfigRule(LocalizedMessage.Get("VketRuleSetBase.PointLightConfigRule.Title"), UnityEngine.LightType.Point, ApprovedPointLightConfig),

                new LightConfigRule(LocalizedMessage.Get("VketRuleSetBase.SpotLightConfigRule.Title"), UnityEngine.LightType.Spot, ApprovedSpotLightConfig),

                new LightConfigRule(LocalizedMessage.Get("VketRuleSetBase.AreaLightConfigRule.Title"), UnityEngine.LightType.Area, ApprovedAreaLightConfig),

                new LightCountLimitRule(
                    LocalizedMessage.Get("VketRuleSetBase.AreaLightLimitRule.Title", AreaLightUsesLimit),
                    UnityEngine.LightType.Area,
                    AreaLightUsesLimit),

                new UseLightModeRule(LocalizedMessage.Get("VketRuleSetBase.PointLightModeRule.Title"), UnityEngine.LightType.Point, unusablePointLightModes),

                new UseLightModeRule(LocalizedMessage.Get("VketRuleSetBase.SpotLightModeRule.Title"), UnityEngine.LightType.Spot, unusableSpotLightModes),

                // new AnimationMakesMoveCollidersRule(LocalizedMessage.Get("VketRuleSetBase.AnimationMakesMoveCollidersRule.Title")),

                new AnimationClipRule(LocalizedMessage.Get("VketRuleSetBase.AnimationClipRule.Title")),

                new AnimationComponentRule(LocalizedMessage.Get("VketRuleSetBase.AnimationComponentRule.Title"), officialPrefabsDetector),

                new AnimatorComponentRule(LocalizedMessage.Get("VketRuleSetBase.AnimatorComponentRule.Title"),
                    new System.Type[]{
                        typeof(VRC_Pickup),
                        // typeof(VRC_ObjectSync)
                    },officialPrefabsDetector),

                new CanvasRenderModeRule(LocalizedMessage.Get("VketRuleSetBase.CanvasRenderModeRule.Title")),

                new CameraComponentRule(LocalizedMessage.Get("VketRuleSetBase.CameraComponentRule.Title"), maxRenderTextureSize: new Vector2(1024, 1024)),

                new CameraComponentMaxCountRule(LocalizedMessage.Get("VketRuleSetBase.CameraComponentMaxCountRule.Title"), limit: 1),

                new ProjectorComponentRule(LocalizedMessage.Get("VketRuleSetBase.ProjectorComponentRule.Title")),

                new ProjectorComponentMaxCountRule(LocalizedMessage.Get("VketRuleSetBase.ProjectorComponentMaxCountRule.Title"), limit: 1),

                new PickupObjectSyncPrefabRule(LocalizedMessage.Get("VketRuleSetBase.PickupObjectSyncRule.Title"), _officialAssetData.PickupObjectSyncPrefabGUIDs),

                new AvatarPedestalPrefabRule(LocalizedMessage.Get("VketRuleSetBase.AvatarPedestalPrefabRule.Title"), _officialAssetData.AvatarPedestalPrefabGUIDs),

                new AudioSourcePrefabRule(LocalizedMessage.Get("VketRuleSetBase.AudioSourcePrefabRule.Title"),  _officialAssetData.AudioSourcePrefabGUIDs),

                //// UdonCube では IsKinematic = False を許可する 
                // new RigidbodyRule(LocalizedMessage.Get("VketRuleSetBase.RigidbodyRule.Title")),

                new PrefabLimitRule(
                    LocalizedMessage.Get("VketRuleSetBase.UnusabePrefabRule.Title", ChairPrefabUsesLimit),
                    _officialAssetData.VRCSDKPrefabGUIDs,
                    0),

                new PrefabLimitRule(
                    LocalizedMessage.Get("VketRuleSetBase.PickupObjectSyncPrefabLimitRule.Title", PickupObjectSyncUsesLimit),
                    _officialAssetData.PickupObjectSyncPrefabGUIDs,
                    PickupObjectSyncUsesLimit),

                new PrefabLimitRule(
                    LocalizedMessage.Get("VketRuleSetBase.VketVideoPlayerPrefabLimitRule.Title", VketVideoPlayerUsesLimit),
                    new string[]{"73b0727ab433c3140929fbf088cd8b88"},
                    VketVideoPlayerUsesLimit),

                //// IN SDK3 Video Player is suspended.
                // new VideoPlayerComponentRule(LocalizedMessage.Get("VketRuleSetBase.VideoPlayerComponentRule.Title")),

                //// IN SDK3 Video Player is suspended.
                // new VideoPlayerComponentMaxCountRule(LocalizedMessage.Get("VketRuleSetBase.VideoPlayerComponentMaxCountRule.Title"), limit: 1),

                //new AnimatorComponentMaxCountRule(LocalizedMessage.Get("VketRuleSetBase.AnimatorComponentMaxCountRule.Title"), limit: 50),
                new SceneComponentLimitRule(LocalizedMessage.Get("VketRuleSetBase.AnimatorComponentMaxCountRule.Title"),typeof(Animator), limit: 50,_officialAssetData.UdonBehaviourPrefabGUIDs),


                // Udon Behaviour
                // UdonBehaviourを含むオブジェクト、UdonBehaviourによって操作を行うオブジェクトは全て入稿ルール C.Scene内階層規定におけるDynamicオブジェクトの階層下に入れてください
                new UdonDynamicObjectParentRule(LocalizedMessage.Get("VketUdonRuleSetBase.UdonDynamicObjectParentRule.Title"), _officialAssetData.UdonBehaviourGlobalLinkGUIDs, UdonDynamicObjectParentRuleIsEnabled), 
                
                // 全てのUdonBehaviourオブジェクトの親であるDynamicオブジェクトは初期でInactive状態にしてください
                new UdonDynamicObjectInactiveRule(LocalizedMessage.Get("VketUdonRuleSetBase.UdonDynamicObjectInactiveRule.Title"), UdonInactiveRuleIsEnabled), 

                // UdonBehaviourを含むオブジェクトのLayerはUserLayer23としてください
                // new UdonBehaviourLayerConstraintRule(LocalizedMessage.Get("VketUdonRuleSetBase.UdonBehaviourLayerConstraintRule.Title"),_officialAssetData.UdonBehaviourPrefabGUIDs),

                // UdonBehaviourは1ブースあたり 25 まで
                new SceneComponentLimitRule(
                    LocalizedMessage.Get("VketUdonRuleSetBase.UdonBehaviourLimitRule.Title", UdonBehaviourCountLimit),
                    typeof(UdonBehaviour),
                    UdonBehaviourCountLimit,
                    _officialAssetData.UdonBehaviourPrefabGUIDs),

                // VRC Object Syncの使用数が1個以下であること
                new SceneComponentLimitRule(
                    LocalizedMessage.Get("VketUdonRuleSetBase.VRCObjectSyncLimitRule.Title", VRCObjectSyncCountLimit),
                    typeof(VRCObjectSync),
                    VRCObjectSyncCountLimit,
                    _officialAssetData.UdonBehaviourPrefabGUIDs),

                // VRC Object Poolの使用数が1個以下であること
                new SceneComponentLimitRule(
                    LocalizedMessage.Get("VketUdonRuleSetBase.VRCObjectPoolLimitRule.Title", VRCObjectPoolCountLimit),
                    typeof(VRCObjectPool),
                    VRCObjectPoolCountLimit,
                    _officialAssetData.UdonBehaviourPrefabGUIDs),

                //VRCObjectPoolのPoolに登録するオブジェクトは5個以内にすること
                new VRCObjectPoolPoolLimitRule(
                    LocalizedMessage.Get("VketUdonRuleSetBase.VRCObjectPoolPoolLimitRule.Title", VRCObjectPoolPoolLimit),
                    VRCObjectPoolPoolLimit),

                // VRC Pickupの使用数が10個以下であること
                new SceneComponentLimitRule(
                    LocalizedMessage.Get("VketUdonRuleSetBase.VRCObjectPickupLimitRule.Title", VRCPickupCountLimit),
                    typeof(VRCPickup),
                    VRCPickupCountLimit,
                    _officialAssetData.GUIDs),

                // Clothの使用数が1個以下であること
                new SceneComponentLimitRule(
                    LocalizedMessage.Get("VketUdonRuleSetBase.ClothLimitRule.Title", ClothCountLimit),
                    typeof(Cloth),
                    ClothCountLimit,
                    _officialAssetData.GUIDs),

                // Clothの使用数が1個以下であること
                new SceneComponentLimitRule(
                    LocalizedMessage.Get("VketUdonRuleSetBase.AudioSourceLimitRule.Title", AudioSourceCountLimit),
                    typeof(AudioSource),
                    AudioSourceCountLimit,
                    _officialAssetData.GUIDs),

                // SynchronizePositionが有効なUdonBehaviourは1ブースあたり 10 まで
                new UdonBehaviourSynchronizePositionCountLimitRule(
                    LocalizedMessage.Get("VketUdonRuleSetBase.UdonBehaviourSynchronizePositionCountLimitRule.Title", UdonBehaviourSynchronizePositionCountLimit),
                    UdonBehaviourSynchronizePositionCountLimit
                ),

                //運営が配布するprefabs以外でUdonBehaviourコンポーネントを使用する際は、VketUdonControlコンポーネントをアタッチすること
                new NeedVketUdonControlRule(
                    LocalizedMessage.Get("VketUdonRuleSetBase.NeedVketUdonControlRule.Title"),
                    _officialAssetData.GUIDs
                ),

                // AllowOwnershipTransferOnCollisionは必ずFalseにすること
                new VRCObjectSyncAllowOwnershipTransferOnCollisionIsFalseRule(LocalizedMessage.Get("VRCObjectSyncAllowOwnershipTransferOnCollisionIsFalseRule.Title")),

                // VRCStation は1ブースあたり 8 まで
                new VRCStationCountLimitRule(LocalizedMessage.Get("VketUdonRuleSetBase.VRCStationCountLimitRule.Title", VRCStationCountLimit), VRCStationCountLimit), 

                // VRCSpatialAudioSourceを含むオブジェクトは全てDynamicオブジェクトの階層下に入れてください
                new VRCSpatialAudioSourceDynamicObjectParentRule(LocalizedMessage.Get("VketUdonRuleSetBase.X07_SpatialAudioDynamicObjectParentRule.Title")), 

                // VRCPickup は UdonBehaviour [AutoResetPickup] を持つ必要があります。
                new VRCPickupUdonBehaviourRule(LocalizedMessage.Get("VketUdonRuleSetBase.X08_VRCPickupUdonBehaviourRule.Title")), 

                // UdonBehaviourによってオブジェクトをスペース外に移動させる行為は禁止
                // ⇒ スタッフによる目視確認

                // プレイヤーの設定(移動速度等)の変更はプレイヤーがスペース内にいる場合のみ許可されます
                // ⇒ スタッフによる目視確認

                // プレイヤーの位置変更(テレポート)は、プレイヤーがスペース内にいる状態 スペース内のどこかに移動させる
                // ⇒ スタッフによる目視確認

                // Udon Script
                // 使用禁止UdonAssembly
                new UsableUdonAssemblyListRule(LocalizedMessage.Get("VketUdonRuleSetBase.UsableUdonAssemblyListRule.Title"),
                    GetUdonAssemblyReferences(),
                    ignorePrefabGUIDs: _officialAssetData.GUIDs), 

                // [UdonSynced]を付与した変数は1ブースあたり 3 まで
                // [UdonSynced]を付与した変数は下記の型のみ使用できます bool, sbyte, byte, ushort, short, uint, int, float
                new UdonBehaviourSyncedVariablesRule(LocalizedMessage.Get("VketUdonRuleSetBase.UdonBehaviourSyncedVariablesRule.Title"), UdonScriptSyncedVariablesLimit), 

                // U#においては、全てのクラスは運営よりブース毎に指定するnamespaceに所属させてください
                new UdonSharpScriptNamespaceRule(LocalizedMessage.Get("VketUdonRuleSetBase.UdonSharpNameSpaceRule.Title"), UdonSharpNamespace), 

                // PhysicsクラスのCast関数 layerMaskを設定し、レイヤー23以外のコライダを無視するようにする, maxDistanceは最長で10メートルまで
                new UdonAssemblyPhysicsCastFunctionRule(LocalizedMessage.Get("VketUdonRuleSetBase.UdonAssemblyPhysicsCastFunctionRule.Title"), GetUdonAssemblyPhysicsCastFunctionReferences(),RayCastLength), 

                //Is Kinematicを有効にすること
                new RigidbodyRule(LocalizedMessage.Get("VketUdonRuleSetBase.RigidbodyRule.Title"),AllowIsKinematic),

                //AudioSourceの使用数が10個以下であること
                new AudioSourceRule(LocalizedMessage.Get("VketUdonRuleSetBase.AudioSourceRule.Title")),

                //特定のコールバックの使用禁止
                new DisabledCallbackRule(LocalizedMessage.Get("VketUdonRuleSetBase.DisabledCallbackRule.Title"),
                _officialAssetData.DisabledCallback,
                _officialAssetData.GUIDs),
            };
        }

        protected abstract long FolderSizeLimit { get; }

        protected abstract Vector3 BoothSizeLimit { get; }

        protected abstract int UdonBehaviourCountLimit { get; }

        protected abstract int VRCObjectSyncCountLimit { get; }

        protected abstract int VRCObjectPoolCountLimit { get; }

        protected abstract int VRCObjectPoolPoolLimit { get; }

        protected abstract int VRCPickupCountLimit { get; }

        protected abstract int UdonBehaviourSynchronizePositionCountLimit { get; }

        protected abstract int UdonScriptSyncedVariablesLimit { get; }

        protected abstract int MaterialUsesLimit { get; }

        protected abstract int LightmapCountLimit { get; }

        protected abstract int VRCStationCountLimit { get; }

        protected abstract int ClothCountLimit { get; }

        protected abstract int AudioSourceCountLimit { get; }

        protected abstract float RayCastLength { get; }

        private ComponentReference[] GetComponentReferences()
        {
            return new ComponentReference[] {
                new ComponentReference("Rigidbody", new string[]{"UnityEngine.Rigidbody"}, ValidationLevel.ALLOW),
                new ComponentReference("Cloth", new string[]{"UnityEngine.Cloth"}, MoreAdvancedObjectValidationLevel),
                new ComponentReference("Collider", new string[]{"UnityEngine.SphereCollider", "UnityEngine.BoxCollider", "UnityEngine.SphereCollider", "UnityEngine.CapsuleCollider", "UnityEngine.MeshCollider", "UnityEngine.WheelCollider"}, ValidationLevel.ALLOW),
                new ComponentReference("Dynamic Bone", new string[]{"DynamicBone"}, ValidationLevel.ALLOW),
                new ComponentReference("Dynamic Bone Collider", new string[]{"DynamicBoneCollider"}, ValidationLevel.ALLOW),
                new ComponentReference("Skinned Mesh Renderer", new string[]{"UnityEngine.SkinnedMeshRenderer"}, ValidationLevel.ALLOW),
                new ComponentReference("Mesh Renderer ", new string[]{"UnityEngine.MeshRenderer"}, ValidationLevel.ALLOW),
                new ComponentReference("Mesh Filter", new string[]{"UnityEngine.MeshFilter"}, ValidationLevel.ALLOW),
                new ComponentReference("Particle System", new string[]{"UnityEngine.ParticleSystem", "UnityEngine.ParticleSystemRenderer"}, ValidationLevel.ALLOW),
                new ComponentReference("Trail Renderer", new string[]{"UnityEngine.TrailRenderer"}, ValidationLevel.ALLOW),
                new ComponentReference("Line Renderer", new string[]{"UnityEngine.LineRenderer"}, ValidationLevel.ALLOW),
                new ComponentReference("Light", new string[]{"UnityEngine.Light"}, AdvancedObjectValidationLevel),
                new ComponentReference("LightProbeGroup", new string[]{"UnityEngine.LightProbeGroup"}, AdvancedObjectValidationLevel),
                new ComponentReference("ReflectionProbe", new string[]{"UnityEngine.ReflectionProbe"}, AdvancedObjectValidationLevel),
                new ComponentReference("Camera", new string[]{"UnityEngine.Camera"}, MoreAdvancedObjectValidationLevel),
                new ComponentReference("Projector", new string[]{"UnityEngine.Projector"}, MoreAdvancedObjectValidationLevel),
                new ComponentReference("LookatTarget", new string[]{"UnityStandardAssets.Cameras.LookatTarget" }, MoreAdvancedObjectValidationLevel),
                new ComponentReference("FollowTarget", new string[]{"UnityStandardAssets.Utility.FollowTarget" }, MoreAdvancedObjectValidationLevel),
                new ComponentReference("Suspension", new string[]{"UnityStandardAssets.Vehicles.Car.Suspension" }, MoreAdvancedObjectValidationLevel),
                new ComponentReference("Animator", new string[]{"UnityEngine.Animator"}, ValidationLevel.ALLOW),
                new ComponentReference("Animation", new string[]{"UnityEngine.Animation"}, ValidationLevel.ALLOW),
                new ComponentReference("Audio Source", new string[]{"UnityEngine.AudioSource", "ONSPAudioSource", "VRCSDK2.VRC_SpatialAudioSource"}, ValidationLevel.ALLOW),
                new ComponentReference("Canvas", new string[]{"UnityEngine.Canvas", "UnityEngine.CanvasGroup", "UnityEngine.RectTransform", "UnityEngine.UI.CanvasScaler", "UnityEngine.UI.GraphicRaycaster", "UnityEngine.UI.AspectRatioFitter", "UnityEngine.UI.LayoutElement", "UnityEngine.UI.ContentSizeFitter", "UnityEngine.UI.HorizontalLayoutGroup", "UnityEngine.UI.VerticalLayoutGroup", "UnityEngine.UI.GridLayoutGroup", "UnityEngine.UI.Text", "UnityEngine.UI.Image", "UnityEngine.UI.RawImage", "UnityEngine.UI.Mask", "UnityEngine.UI.RectMask2D", "UnityEngine.UI.Button", "UnityEngine.UI.InputField", "UnityEngine.UI.Toggle", "UnityEngine.UI.ToggleGroup", "UnityEngine.UI.Slider", "UnityEngine.UI.Scrollbar", "UnityEngine.UI.Dropdown", "UnityEngine.UI.ScrollRect", "UnityEngine.UI.Selectable", "UnityEngine.UI.Shadow", "UnityEngine.UI.Outline", "UnityEngine.UI.PositionAsUV1", "UnityEngine.RectTransform", "UnityEngine.CanvasRenderer"}, ValidationLevel.ALLOW),
                new ComponentReference("VideoPlayer", new string[]{"UnityEngine.Video.VideoPlayer" }, MoreAdvancedObjectValidationLevel),
                new ComponentReference("EventSystem", new string[]{"UnityEngine.EventSystems.EventSystem", "UnityEngine.EventSystems.StandaloneInputModule"}, ValidationLevel.DISALLOW),
                new ComponentReference("StandaloneInputModule", new string[]{"UnityEngine.EventSystems.StandaloneInputModule"}, ValidationLevel.DISALLOW),
                new ComponentReference("PlayableDirector", new string[]{"UnityEngine.Playables.PlayableDirector" }, ValidationLevel.DISALLOW),

                // VRCSDK2
                new ComponentReference("VRC_Trigger", new string[]{"VRCSDK2.VRC_Trigger", "VRCSDK2.VRC_EventHandler"}, ValidationLevel.DISALLOW),
                new ComponentReference("VRC_Object Sync", new string[]{"VRCSDK2.VRC_ObjectSync"}, ValidationLevel.DISALLOW),
                new ComponentReference("VRC_Pickup", new string[]{"VRCSDK2.VRC_Pickup"}, ValidationLevel.DISALLOW),
                new ComponentReference("VRC_Audio Bank", new string[]{"VRCSDK2.VRC_AudioBank"}, ValidationLevel.DISALLOW),
                new ComponentReference("VRC_Avatar Pedestal", new string[]{"VRCSDK2.VRC_AvatarPedestal"}, ValidationLevel.DISALLOW),
                new ComponentReference("VRC_Ui Shape", new string[]{"VRCSDK2.VRC_UiShape"}, ValidationLevel.DISALLOW),
                new ComponentReference("VRC_Station", new string[]{"VRCSDK2.VRC_Station"}, ValidationLevel.DISALLOW),
                new ComponentReference("VRC_Mirror", new string[]{ "VRCSDK2.VRC_MirrorCamera", "VRCSDK2.VRC_MirrorReflection" }, ValidationLevel.DISALLOW),
                new ComponentReference("VRC_PlayerAudioOverride", new string[]{"VRCSDK2.VRC_PlayerAudioOverride"}, ValidationLevel.DISALLOW),
                new ComponentReference("VRC_Panorama", new string[]{"VRCSDK2.scripts.Scenes.VRC_Panorama", "VRC.SDKBase.VRC_Panorama" }, ValidationLevel.DISALLOW),
                new ComponentReference("VRC_SyncVideoPlayer", new string[]{"VRCSDK2.VRC_SyncVideoPlayer", "VRCSDK2.VRC_SyncVideoStream", "VRC.SDKBase.VRC_SyncVideoPlayer", "VRC.SDKBase.VRC_SyncVideoStream" }, ValidationLevel.DISALLOW),
                new ComponentReference("VRC_SceneResetPosition", new string[]{"VRCSDK2.VRC_SceneResetPosition"}, ValidationLevel.DISALLOW),

                // VRCSDK3
                //// VRC_Trigger is obsolete. Use instead Udon Behaviour
                new ComponentReference("VRC Trigger", new string[]{"VRC.SDKBase.VRC_Trigger", "VRC.SDK3.Components.VRCTrigger"}, ValidationLevel.DISALLOW),
                new ComponentReference("VRC Pickup", new string[]{"VRC.SDKBase.VRC_Pickup", "VRC.SDK3.Components.VRCPickup"}, ValidationLevel.ALLOW),
                new ComponentReference("VRC Station", new string[]{"VRC.SDKBase.VRCStation", "VRC.SDK3.Components.VRCStation"}, ValidationLevel.ALLOW),
                new ComponentReference("VRC Avatar Pedestal", new string[]{"VRC.SDKBase.VRC_AvatarPedestal", "VRC.SDK3.Components.VRCAvatarPedestal"}, ValidationLevel.DISALLOW),
                new ComponentReference("VRC Mirror Reflection", new string[]{"VRC.SDKBase.VRC_MirrorReflection", "VRC.SDK3.Components.VRC_MirrorReflection"}, ValidationLevel.DISALLOW),
                new ComponentReference("VRC Ui Shape", new string[]{"VRC.SDKBase.VRC_UiShape", "VRC.SDK3.Components.VRCUiShape"}, AdvancedObjectValidationLevel),
                new ComponentReference("VRC Url Input Field", new string[]{"VRC.SDK3.Components.VRCUrlInputField"}, ValidationLevel.DISALLOW),
                new ComponentReference("VRC Visual Damage", new string[]{"VRC.SDKBase.VRC_VisualDamage", "VRC.SDK3.Components.VRCVisualDamage"}, ValidationLevel.DISALLOW),
                new ComponentReference("VRC Spacial Audio Source", new string[]{"VRC.SDKBase.VRC_SpatialAudioSource", "VRC.SDK3.Components.VRCSpatialAudioSource"}, ValidationLevel.ALLOW),
                new ComponentReference("VRC Unity Video Player", new string[]{"VRC.SDK3.Video.Components.VRCUnityVideoPlayer", }, MoreAdvancedObjectValidationLevel),
                new ComponentReference("VRC AV Pro Video Player", new string[]{"VRC.SDK3.Video.Components.AVPro.VRCAVProVideoPlayer", "VRC.SDK3.Video.Components.AVPro.VRCAVProVideoSpeaker", "VRC.SDK3.Video.Components.AVPro.VRCAVProVideoPlayer"}, ValidationLevel.DISALLOW),
                new ComponentReference("VRC Midi", new string[]{"VRC.SDK3.Midi.VRCMidiHandler", "VRC.SDK3.Midi.VRCMidiListener"}, ValidationLevel.DISALLOW),
                new ComponentReference("VRC Portal Marker", new string[]{"VRC.SDKBase.VRC_PortalMarker", "VRC.SDK3.Components.VRCPortalMarker"}, ValidationLevel.DISALLOW),
                new ComponentReference("VRC Scene Descriptor", new string[]{"VRC.SDKBase.VRC_SceneDescriptor", "VRC.SDK3.Components.VRCSceneDescriptor"}, ValidationLevel.DISALLOW),
                new ComponentReference("VRC Test Marker", new string[]{"VRC.SDK3.VRCTestMarker"}, ValidationLevel.DISALLOW),
                new ComponentReference("VRC Project Settings", new string[]{"VRCProjectSettings"}, ValidationLevel.DISALLOW),
                new ComponentReference("VRC_Sdk Builder", new string[]{"VRC.SDK3.Editor.VRC_SdkBuilder"}, ValidationLevel.DISALLOW),
                new ComponentReference("VRC_Event Handler(Obsolete)", new string[]{"VRC.SDKBase.VRC_EventHandler", "VRC.SDK3.Components.VRCEventHandler"}, ValidationLevel.DISALLOW),
                new ComponentReference("Udon Behaviour", new string[]{"VRC.Udon.UdonBehaviour", "VRC.SDKBase.VRC_Interactable"}, MoreAdvancedObjectValidationLevel),
                new ComponentReference("VRC Object Pool", new string[]{"VRC.SDK3.Components.VRCObjectPool"}, ValidationLevel.ALLOW),

                //VketAsset
                 new ComponentReference("VKet Udon Controll", new string[]{ "Vket.UdonManager.VketUdonControl"}, ValidationLevel.ALLOW),
                 new ComponentReference("Item Teleport Marker", new string[]{ "Vket.UdonManager.ItemTeleportMarker"}, ValidationLevel.ALLOW),
            };
        }

        private UdonAssemblyReference[] GetUdonAssemblyReferences()
        {
            return new UdonAssemblyReference[]
            {
                // Variables
                new UdonAssemblyReference("Transform.root", new string[]{"__get_root__UnityEngineTransform", "__set_root__UnityEngineTransform"}, ValidationLevel.DISALLOW),
                //new UdonAssemblyReference("GameObject.Layer", new string[]{"UnityEngineGameObject.__get_layer__SystemInt32", "UnityEngineGameObject.__set_layer__SystemInt32"}, ValidationLevel.DISALLOW),
                new UdonAssemblyReference("RenderSettings", new string[]{"UnityEngineRenderSettings"}, ValidationLevel.DISALLOW),

                // Functions
                new UdonAssemblyReference("UdonSharpBehaviour.VRCInstantiate", new string[]{"VRCInstantiate"}, ValidationLevel.DISALLOW),
                new UdonAssemblyReference("GameObject.Find", new string[]{"__Find__SystemString__UnityEngineGameObject"}, ValidationLevel.DISALLOW),
                new UdonAssemblyReference("Object.Destroy", new string[]{"UnityEngineObject.__Destroy__UnityEngineObject__SystemVoid"}, ValidationLevel.DISALLOW),
                new UdonAssemblyReference("Object.DestroyImmediate", new string[]{"UnityEngineObject.__DestroyImmediate__UnityEngineObject__SystemVoid"}, ValidationLevel.DISALLOW),
                //new UdonAssemblyReference("Transform.DetachChildren", new string[]{"UnityEngineTransform.__DetachChildren__SystemVoid"}, ValidationLevel.DISALLOW),
                new UdonAssemblyReference("VRCSDK3VideoPlayer", new string[]{"VRCSDK3VideoComponentsBaseBaseVRCVideoPlayer"}, ValidationLevel.DISALLOW),
            };
        }

        private UdonAssemblyFunctionEssentialArgumentReference[] GetUdonAssemblyPhysicsCastFunctionReferences()
        {
            return new UdonAssemblyFunctionEssentialArgumentReference[]
            {
                new UdonAssemblyFunctionEssentialArgumentReference(
                    "Physics.RayCast",
                    "MaxDistance, LayerMask",
                    new []{"UnityEnginePhysics.__Raycast__", "UnityEnginePhysics.__RaycastAll__", "UnityEnginePhysics.__RaycastNonAlloc__"},
                    "_SystemSingle_SystemInt32_"), 
                new UdonAssemblyFunctionEssentialArgumentReference(
                    "Physics.BoxCast",
                    "MaxDistance, LayerMask",
                    new []{"UnityEnginePhysics.__Boxcast__", "UnityEnginePhysics.__BoxCastAll__", "UnityEnginePhysics.__BoxCastNonAlloc__"},
                    "_SystemSingle_SystemInt32_"), 
                new UdonAssemblyFunctionEssentialArgumentReference(
                    "Physics.SphereCast",
                    "MaxDistance, LayerMask",
                    new []{"UnityEnginePhysics.__SphereCast__", "UnityEnginePhysics.__SphereCastAll__", "UnityEnginePhysics.__SphereCastNonAlloc__"},
                    "_SystemSingle_SystemInt32_"), 
                new UdonAssemblyFunctionEssentialArgumentReference(
                    "Physics.CapsuleCast",
                    "MaxDistance, LayerMask",
                    new []{"UnityEnginePhysics.__CapsuleCast__", "UnityEnginePhysics.__CapsuleCastAll__", "UnityEnginePhysics.__CapsuleCastNonAlloc__"},
                    "_SystemSingle_SystemInt32_"), 
                new UdonAssemblyFunctionEssentialArgumentReference(
                    "Physics.LineCast",
                    "LayerMask",
                    new []{"UnityEnginePhysics.__Linecast__"},
                    "_SystemInt32_"), 
            };
        }
        protected virtual ValidationLevel AdvancedObjectValidationLevel
        {
            get
            {
                return ValidationLevel.ALLOW;
            }
        }

        protected virtual ValidationLevel MoreAdvancedObjectValidationLevel
        {
            get
            {
                return ValidationLevel.DISALLOW;
            }
        }

        protected abstract LightConfigRule.LightConfig ApprovedPointLightConfig { get; }

        protected abstract LightConfigRule.LightConfig ApprovedSpotLightConfig { get; }

        protected abstract LightConfigRule.LightConfig ApprovedAreaLightConfig { get; }

        protected abstract LightmapBakeType[] unusablePointLightModes { get; }

        protected abstract LightmapBakeType[] unusableSpotLightModes { get; }

        protected abstract int AreaLightUsesLimit { get; }

        protected abstract int ChairPrefabUsesLimit { get; }

        protected abstract int PickupObjectSyncUsesLimit { get; }

        protected abstract string UdonSharpNamespace { get; }

        protected abstract bool UdonInactiveRuleIsEnabled { get; }

        protected abstract bool ExhibitStructureRuleIsEnabled { get; }

        protected abstract bool UdonDynamicObjectParentRuleIsEnabled { get; }

        protected abstract int VketVideoPlayerUsesLimit { get; }

        protected abstract bool AllowIsKinematic { get; }
    }
}
#endif
