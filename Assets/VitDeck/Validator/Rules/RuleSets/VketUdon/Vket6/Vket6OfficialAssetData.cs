using System.Collections.Generic;
using System.Linq;

namespace VitDeck.Validator.RuleSets
{
    public class Vket6OfficialAssetData: VketUdonOfficialAssetData
    {
        public override string[] GetGUIDs()
        {
            var guids = base.GetGUIDs().ToList();
            var addGuids = new string[]
            {
                #region GamvGimmicks

                "9bee14e2f42335f47b9baf422aebe3f1", // Assets/GamVGimmicks/Camera_system/camera_obj.prefab
                "020ed5feab27df441b1923f7ba71a21b", // Assets/GamVGimmicks/Camera_system/Render Texture.renderTexture
                "b1edb69289c5d6740a2209796dbc778b", // Assets/GamVGimmicks/Camera_system/Material/Camera_mat.mat
                "a5c6e422e0cf2c344924018dcb7f28eb", // Assets/GamVGimmicks/Camera_system/Material/Screen_mat.mat
                "9522392d588224f4faa89f41070a4834", // Assets/GamVGimmicks/Camera_system/Material/UI.mat
                "a162b86d5d1c2e848b927da7879359b0", // Assets/GamVGimmicks/Camera_system/Material/viweDome_mat.mat
                "4c81a4515f3d1d74f82888f660f3ddb2", // Assets/GamVGimmicks/Camera_system/PosTracking/PosTracking.mat
                "2547870e43f431340b6292e7a7fc87a1", // Assets/GamVGimmicks/Camera_system/PosTracking/PosTracking.renderTexture
                "47d6b5c09e69f5246acc7d42e6dc81ce", // Assets/GamVGimmicks/Camera_system/SE/CounDown.wav
                "13fb2724eaa3d6f4ea89edd692a4d3ae", // Assets/GamVGimmicks/Camera_system/shader/Canvas_shader.shader
                "50b8fb7c1b68d714d82497132da9b489", // Assets/GamVGimmicks/Camera_system/shader/Pos_Tracking_shader.shader
                "c4e88f7a31e81544491e0fc24d70d67c", // Assets/GamVGimmicks/Camera_system/shader/viewDome_Shader.shader
                "ef848392ff3c45549b96d420e1e9ab8f", // Assets/GamVGimmicks/Scenes/BoothVideoTest.unity
                "92885dfb3492f684d84fcc7c5b3a5449", // Assets/GamVGimmicks/Scenes/DroneTest.unity
                "74267b393d684574fb4623a942df4ecb", // Assets/GamVGimmicks/Scenes/JoinCounterTest.unity
                "ed154ffced95c124cb294465ebb4ba42", // Assets/GamVGimmicks/Scenes/JoinCounterTest_UdonProgramSources/JoinCounterVideoPlayer Udon C# Program Asset.asset
                "a9a84836445836249b8eb4e60dc1b12c", // Assets/GamVGimmicks/UdonScripts/GamVDrone.asset
                "3cd25baea1355bc488d6b1d5af97d700", // Assets/GamVGimmicks/UdonScripts/GamVDrone.cs
                "3740d1276d198a344881f35c64e2ac33", // Assets/GamVGimmicks/UdonScripts/GamVDrone_DomeSwitcher.asset
                "a1020bf9421c0dd419d351c0477e75c9", // Assets/GamVGimmicks/UdonScripts/GamVDrone_DomeSwitcher.cs
                "85b912f0cae05fd4c90451c0df9ab65c", // Assets/GamVGimmicks/UdonScripts/GamVDrone_MenuActivator.asset
                "28c29b492b329ec4cab0e279a6399c24", // Assets/GamVGimmicks/UdonScripts/GamVDrone_MenuActivator.cs
                "b8bb5229af7717b489c839d904f43ae7", // Assets/GamVGimmicks/UdonScripts/JoinCounterVideoPlayer.cs

                #endregion

                #region VideoPlayer

                "0168152082a389040bfaf951144686cb",  // Assets/GamVGimmicks/VideoPlayer_system/BoothVideoPlayer.prefab
                "7ff4353ca28b14b4aae0659f87ff36d7",  // Assets/GamVGimmicks/VideoPlayer_system/BoothVideoPlayerMaster.prefab
                "866f25587f50b85479e2cf4d2d197fee",  // Assets/GamVGimmicks/VideoPlayer_system/DisabledVideoPlayerImage.png
                "f15c5f42ce1be0a48b1ba25d0cf6361a",  // Assets/GamVGimmicks/VideoPlayer_system/VideoPlayerTexture.renderTexture
                "414a471b5fafc3246a7c33b2ae29f2b9",  // Assets/GamVGimmicks/VideoPlayer_system/Udon/UdonComponents/BoothVideoPlayer Udon C# Program Asset.asset
                "6abc392e5dd9c1848b09205e404a5adf",  // Assets/GamVGimmicks/VideoPlayer_system/Udon/UdonComponents/BoothVideoPlayerMaster Udon C# Program Asset.asset
                "914a5b3bc87014041ac99d01fa56365f",  // Assets/GamVGimmicks/VideoPlayer_system/Udon/UdonScripts/BoothVideoPlayer.cs
                "55548138ddf20b3499f66c54f60b37d7",  // Assets/GamVGimmicks/VideoPlayer_system/Udon/UdonScripts/BoothVideoPlayerMaster.cs

                #endregion
            };
            guids.AddRange(addGuids);
            return guids.ToArray();
        }

        public override Dictionary<string, string> GetAllowedShaders()
        {
            return new Dictionary<string, string>()
            {
                {"TextMeshPro/Mobile/Distance Field", "fe393ace9b354375a9cb14cdbbc28be4"},
                {"VRChat/Mobile/Bumped Diffuse", "f8c1f8ac363df824899534a0b30eef00"},
                {"VRChat/Mobile/Bumped Mapped Specular", "584dc70fbb9834e48beb29e3206e3ca0"},
                {"VRChat/Mobile/Diffuse", "2dcd9e0568e0a6f45b92c60ba2eb16a0"},
                {"VRChat/Mobile/Lightmapped", "b1f7ecc80417c414b9d62ce541d5bcbf"},
                {"VRChat/Mobile/MatCap Lit", "3ad043b7f9839cb48a75a9238d433dec"},
                {"VRChat/Mobile/Particles/Additive", "9200bec112b65ec4fbbbd33fa89c20f4"},
                {"VRChat/Mobile/Particles/Multiply", "d5b89f0c74ccf5049ba803c14a090378"},
                {"VRChat/Mobile/Skybox", "c0d3cb006bb294142bef136f492f2568"},
                {"VRChat/Mobile/Standard Lite", "0b7113dea2069fc4e8943843eff19f70"},
                {"VRChat/Mobile/Toon Lit", "affc81f3d164d734d8f13053effb1c5c"},
                {"VRChat/Panosphere", "1278163a2a3ba2b4cad540a862292784"},
                {"UniGLTF/NormalMapDecoder", "53762a37d0a403e42a4921e3e3b84915"},
                {"UniGLTF/NormalMapEncoder", "3e39586253f31b34f87fa7e133449b1e"},
                {"UniGLTF/StandardVColor", "5ef7bdb14a8f23043805e41692d10787"},
                {"UniGLTF/UniUnlit", "8c17b56f4bf084c47872edcb95237e4a"},
                {"VRM/MToon", "1a97144e4ad27a04aafd70f7b915cedb"},
                {"VRM/UnlitCutout", "4c9ce97af40038f45811fc4b0975a483"},
                {"VRM/UnlitTexture", "1a70c9898704e1a4691843883f5101af"},
                {"VRM/UnlitTransparent", "df359ad0838642d4fa0339514fcbbb2d"},
                {"VRM/UnlitTransparentZWrite", "429a3203ab2959741aab76fa2856b450"},
                {"UnlitWF/UnToon_Mobile/WF_UnToon_Mobile_Opaque", "4bd76f6599a5b8e4d88d81300fb74c37"},
                {"UnlitWF/UnToon_Mobile/WF_UnToon_Mobile_OutlineOnly_Opaque", "d279a88eda1ae0e4c89e92539639eb16"},
                {"UnlitWF/UnToon_Mobile/WF_UnToon_Mobile_OutlineOnly_TransCutout", "e0b93fdad2eeedf42baccbc0975cdd1d"},
                {"UnlitWF/UnToon_Mobile/WF_UnToon_Mobile_TransCutout", "af3422dc9372a89449a9f44d409d9714"},
                {"UnlitWF/UnToon_Mobile/WF_UnToon_Mobile_Transparent", "0a7a6cdca16a38548a5d81aca8d4e3ba"},
                {"UnlitWF/UnToon_Mobile/WF_UnToon_Mobile_TransparentOverlay", "4e4be4aab63a2bd4fbcea2390ae92fdf"},
                {"MMS3/Mnmrshader3", "8dd7c14dadb834c4e8324f7d08c5674e"},
                {"MMS3/Mnmrshader3_Cutout", "128f4720891e8914ab7e6673099df0f0"},
                {"MMS3/Mnmrshader3_Outline", "fbaec084851cef64fbd877b3b15716cb"},
                {"MMS3/Mnmrshader3_Transparent", "fda424b70f79d4e5488e1cc3ee100a95"},
                {"MMS3/Stencil/MMS3_Reader ", "f889d00a055a0488e9ecbf22c558ae76"},
                {"MMS3/Stencil/MMS3_Writer", "f55508f2ed8cc477f9574099971bc4eb"},
                {"UnityChanToonShader/Mobile/Toon_DoubleShadeWithFeather", "1d10c7840eb6ba74c889a27f14ba6081"},
                {"UnityChanToonShader/Mobile/Toon_DoubleShadeWithFeather_Clipping", "88791c14394118d42a5e176b433af322"},
                {
                    "UnityChanToonShader/Mobile/Toon_DoubleShadeWithFeather_Clipping_StencilMask",
                    "41f4ee183cb66ad40bc74a9f8f944974"
                },
                {
                    "UnityChanToonShader/Mobile/Toon_DoubleShadeWithFeather_StencilMask",
                    "dec01cbdbc5b8da4ca8671815cda1557"
                },
                {
                    "UnityChanToonShader/Mobile/Toon_DoubleShadeWithFeather_StencilOut",
                    "55e8b9eeaaff205469365133fe7bc744"
                },
                {
                    "UnityChanToonShader/Mobile/Toon_DoubleShadeWithFeather_TransClipping",
                    "d4c592285a93c3844aafdaafffc07ec7"
                },
                {
                    "UnityChanToonShader/Mobile/Toon_DoubleShadeWithFeather_TransClipping_StencilMask",
                    "100d373b596f44d49ac9bb944d671d32"
                },
                {"UnityChanToonShader/Mobile/AngelRing/Toon_ShadingGradeMap", "23e399973d807464fb195291a44a614c"},
                {
                    "UnityChanToonShader/Mobile/AngelRing/Toon_ShadingGradeMap_StencilOut",
                    "8d33e4e4084e5af449f3e762fecce3c9"
                },
                {"UnityChanToonShader/Mobile/Toon_ShadingGradeMap", "f90e11a40dcf4f745ae6b21b857943fa"},
                {"UnityChanToonShader/Mobile/Toon_ShadingGradeMap_StencilMask", "206c554c8b0c60041a9d242385f543d3"},
                {"UnityChanToonShader/Mobile/Toon_ShadingGradeMap_StencilOut", "cfc201757f2519c4bb6ef9265a046582"},
                {"UnityChanToonShader/Mobile/Toon_ShadingGradeMap_TransClipping", "cce1da34c52aff745adf0222f56a356c"},
                {
                    "UnityChanToonShader/Mobile/Toon_ShadingGradeMap_TransClipping_StencilMask",
                    "e88039bab21b7894e918126e8fce5d1b"
                },
            };
        }

        public override string[] GetUdonBehaviourPrefabGUIDs()
        {
            var guids = base.GetUdonBehaviourPrefabGUIDs().ToList();
            var addGuids = new string[]
            {
                "9bee14e2f42335f47b9baf422aebe3f1", // Assets/GamVGimmicks/Camera_system/camera_obj.prefab
                "0168152082a389040bfaf951144686cb",  // Assets/GamVGimmicks/VideoPlayer_system/BoothVideoPlayer.prefab
                "7ff4353ca28b14b4aae0659f87ff36d7",  // Assets/GamVGimmicks/VideoPlayer_system/BoothVideoPlayerMaster.prefab
            };
            guids.AddRange(addGuids);
            return guids.ToArray();
        }

        public override string[] GetSizeIgnorePrefabGUIDs()
        {
            var guids = base.GetSizeIgnorePrefabGUIDs().ToList();
            var addGuids = new string[]
            {
                "0168152082a389040bfaf951144686cb",  // Assets/GamVGimmicks/VideoPlayer_system/BoothVideoPlayer.prefab
            };
            guids.AddRange(addGuids);
            return guids.ToArray();
        }

        public override string[] GetUdonBehaviourGlobalLinkGUIDs()
        {
            var guids = base.GetUdonBehaviourGlobalLinkGUIDs().ToList();
            var addGuids = new string[]
            {
                "0168152082a389040bfaf951144686cb",  // Assets/GamVGimmicks/VideoPlayer_system/BoothVideoPlayer.prefab
                "7ff4353ca28b14b4aae0659f87ff36d7",  // Assets/GamVGimmicks/VideoPlayer_system/BoothVideoPlayerMaster.prefab
            };
            guids.AddRange(addGuids);
            return guids.ToArray();
        }

    }
}