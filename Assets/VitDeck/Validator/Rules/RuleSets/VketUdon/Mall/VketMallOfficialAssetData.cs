using System.Collections.Generic;
using System.Linq;

namespace VitDeck.Validator.RuleSets
{
    public class VketMallOfficialAssetData : VketUdonOfficialAssetData
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
                {"ArxCharacterShaders/AlphaCutout","bccf1a29daed7e347a5365f4ef9714aa"},
{"ArxCharacterShaders/_EmissiveFreak/AlphaCutout","9ce3973bae37a5c43a3c22309be11936"},
{"ArxCharacterShaders/_EmissiveFreak/Fade","9a50e49ef4da46f42869e7bb359e38ae"},
{"ArxCharacterShaders/_EmissiveFreak/FadeRefracted","64c7ca6ee0374bb49928cc04ae72e564"},
{"ArxCharacterShaders/_EmissiveFreak/Opaque","f64626cad72e22a4d9c5b9f2edcae765"},
{"ArxCharacterShaders/_EmissiveFreak/_StencilReader/AlphaCutout","82b077c6cd0a1bf49924f2e40bbaa11a"},
{"ArxCharacterShaders/_EmissiveFreak/_StencilReader/DoubleFade","2f13f85e17b00034082d64dcb9f7e465"},
{"ArxCharacterShaders/_EmissiveFreak/_StencilReader/Fade","efa8f9f56db47404997e88b85819baea"},
{"ArxCharacterShaders/_EmissiveFreak/_StencilReader/FadeRefracted","745457dca56c6574fba900c741151b79"},
{"ArxCharacterShaders/_EmissiveFreak/_StencilWriter/AlphaCutout","8f7fc78e18d31314daa105489df1315e"},
{"ArxCharacterShaders/Fade","d6d2255661809bc4e87babd1a8edaff6"},
{"ArxCharacterShaders/FadeRefracted","0c89b4121f71eb546abb7748e6c7d25f"},
{"ArxCharacterShaders/Opaque","acaabbe907212b94c85ab392bb1306a1"},
{"ArxCharacterShaders/_Outline/AlphaCutout","ed3ee25e40abe154ea5386166422d8fd"},
{"ArxCharacterShaders/_Outline/_EmissiveFreak/AlphaCutout","844a9d3f6c0fa1044abe14728e14e7e9"},
{"ArxCharacterShaders/_Outline/_EmissiveFreak/Opaque","ed627574387225c449eaccd6fdbc6d15"},
{"ArxCharacterShaders/_Outline/_EmissiveFreak/_StencilReader/AlphaCutout","f14d4aa117bff4e4e8626947f279fc44"},
{"ArxCharacterShaders/_Outline/_EmissiveFreak/_StencilWriter/AlphaCutout","8da7952f673810b41afcb4fb3dbe2673"},
{"ArxCharacterShaders/_Outline/Opaque","87d1c60aa88359946943a8f85f3f67ce"},
{"ArxCharacterShaders/_Outline/_StencilReader/AlphaCutout","4c3618b923505674184591106c01b13d"},
{"ArxCharacterShaders/_Outline/_StencilWriter/AlphaCutout","49071b1dd6dced84ebbae1ad62c386c5"},
{"ArxCharacterShaders/_StencilReader/AlphaCutout","034f74b4fdca8cc4a941b0de9ce3616f"},
{"ArxCharacterShaders/_StencilReader/DoubleFade","e8cd3ae42f616ee48875891991c1ecad"},
{"ArxCharacterShaders/_StencilReader/Fade","727d200179b6d6c469453149d0678cd5"},
{"ArxCharacterShaders/_StencilReader/FadeRefracted","b1e4cf9f03cc70a4aa9ec9f8b26c967e"},
{"ArxCharacterShaders/_StencilWriter/AlphaCutout","1adb078ef83bc634d91fa5a5e4961844"},
{"MMS3/Mnmrshader3","8dd7c14dadb834c4e8324f7d08c5674e"},
{"MMS3/Mnmrshader3_Cutout","128f4720891e8914ab7e6673099df0f0"},
{"MMS3/Mnmrshader3_Outline","fbaec084851cef64fbd877b3b15716cb"},
{"MMS3/Stencil/MMS3_Reader ","f889d00a055a0488e9ecbf22c558ae76"},
{"MMS3/Stencil/MMS3_Writer","f55508f2ed8cc477f9574099971bc4eb"},
{"MMS3/Mnmrshader3_Transparent","fda424b70f79d4e5488e1cc3ee100a95"},
{"Mochie/Mochie Standard","cddaa3a02eb956746b502b80b76e92bc"},
{"Mochie/Particles","74e814afd5b766447b0de37c532cc8f9"},
{"Mochie/Screen FX/Screen FX","0d1d977ca72938b4bb8f3ed06b9a8645"},
{"Mochie/Uber/Uber (Outline)","b252ff402bce931488cf8ff5152bf2dc"},
{"Mochie/Uber/Uber","5398f14cd241f2649988529db4480d1c"},
{"VRM/MToon","1a97144e4ad27a04aafd70f7b915cedb"},
{"Silent's Cel Shading/Crosstone","a9a812ee108476f4eae9c507264cc297"},
{"Silent's Cel Shading/Crosstone (Outline)","932c3f8bb2ba7d04480beb8e4c98b2a8"},
{"Hidden/Silent's Cel Shading/Old/☓ No Outline/Cutout","92b4d092592529b4f9a87764c0c44117"},
{"Hidden/Silent's Cel Shading/Old/Cutout","193c1d1febff24f46bc72d88e8b205f8"},
{"Silent's Cel Shading/Lightramp","369d2ecd6fc95bc469360ddecf6b2155"},
{"Hidden/Silent's Cel Shading/Old/☓ No Outline/Transparent","f78fe2d8cca2202429d0c2e0d810c763"},
{"Hidden/Silent's Cel Shading/Old/Transparent","5028bedf4f7ad6a4aaf7727fead41880"},
{"Silent's Cel Shading/Lightramp (Outline)","a883b384ca4bc054aa10b5f554ae85a3"},
{"Sunao Shader/Cutout","01846cdaa65259e48a71d9812e4e1c22"},
{"Sunao Shader/[Stencil Outline]/Cutout","09296c4f29b71fb4ba42ef8983d8007f"},
{"Sunao Shader/Opaque","3701d6a6f5f988b4a9cea92f1426a955"},
{"Sunao Shader/[Stencil Outline]/Opaque","2fb75b0069e4fe147a396141dcf70627"},
{"Sunao Shader/[Stencil]/Read","7362334fb65c850469785caac3918093"},
{"Sunao Shader/[Stencil]/Write","a95ac57a344b931459880f4ca527efc4"},
{"Sunao Shader/Transparent","0b073aeeaec66294aa00c57784f4a0bb"},
{"Sunao Shader/[Stencil Outline]/Transparent","cd2723fb285798b4b801e483a793b3c3"},
{"UnityChanToonShader/NoOutline/ToonColor_DoubleShadeWithFeather","96d4d9f975e6c8849bd1a5c06acfae84"},
{"UnityChanToonShader/NoOutline/ToonColor_DoubleShadeWithFeather_Clipping","ccd13b7f8710b264ea8bd3bc4f51f9e4"},
{"UnityChanToonShader/NoOutline/ToonColor_DoubleShadeWithFeather_Clipping_StencilMask","9c3978743d5db18448a8b945c723a6eb"},
{"UnityChanToonShader/NoOutline/ToonColor_DoubleShadeWithFeather_Clipping_StencilOut","d7da29588857e774bb0650f1fae494c6"},
{"UnityChanToonShader/NoOutline/ToonColor_DoubleShadeWithFeather_StencilMask","315897103223dab42a0746aa65ec251a"},
{"UnityChanToonShader/NoOutline/ToonColor_DoubleShadeWithFeather_StencilOut","2e5cc2da6af713844956264245e092e4"},
{"UnityChanToonShader/NoOutline/ToonColor_DoubleShadeWithFeather_TransClipping","369d674ae1ba36249bb00e2f73b0cd10"},
{"UnityChanToonShader/NoOutline/ToonColor_DoubleShadeWithFeather_TransClipping_StencilMask","8600b2bec3ae31145afa80084df20c61"},
{"UnityChanToonShader/NoOutline/ToonColor_DoubleShadeWithFeather_TransClipping_StencilOut","43d0eeb4c46f52841b0941e99ac9b16b"},
{"UnityChanToonShader/NoOutline/ToonColor_DoubleShadeWithFeather_Transparent","97b7edb5fc0f5744c9b264c2224a0b1e"},
{"UnityChanToonShader/NoOutline/ToonColor_DoubleShadeWithFeather_Transparent_StencilOut","3b20fc0febd34f94baf0304bf47841d8"},
{"UnityChanToonShader/NoOutline/ToonColor_ShadingGradeMap","af8454e09b3a41448a4140e792059446"},
{"UnityChanToonShader/NoOutline/AngelRing/ToonColor_ShadingGradeMap","295fec4a7029edd4eb9522bef07f41ce"},
{"UnityChanToonShader/NoOutline/AngelRing/ToonColor_ShadingGradeMap_StencilOut","e32270aa38f4b664b90f04cc475fdb81"},
{"UnityChanToonShader/NoOutline/AngelRing/ToonColor_ShadingGradeMap_TransClipping","29a860a3f3c4cec43ab821338e28eac8"},
{"UnityChanToonShader/NoOutline/AngelRing/ToonColor_ShadingGradeMap_TransClipping_StencilOut","d5d9c1f4718235248ad37448b0c74c68"},
{"UnityChanToonShader/NoOutline/ToonColor_ShadingGradeMap_StencilMask","6439813c08a1f8947bb0ca6599499dd7"},
{"UnityChanToonShader/NoOutline/ToonColor_ShadingGradeMap_StencilOut","b39692f1382224b4cbe21c12ae51c639"},
{"UnityChanToonShader/NoOutline/ToonColor_ShadingGradeMap_TransClipping","cd7e85b59edbb7740841003baeb510b5"},
{"UnityChanToonShader/NoOutline/ToonColor_ShadingGradeMap_TransClipping_StencilMask","6b4b6d07944415f44b1fc2f0fc24535f"},
{"UnityChanToonShader/NoOutline/ToonColor_ShadingGradeMap_TransClipping_StencilOut","31c75b34739dfc64fb57bf49005e942d"},
{"UnityChanToonShader/NoOutline/ToonColor_ShadingGradeMap_Transparent","7737ca8c4e3939f4086a6e08f93c2ebd"},
{"UnityChanToonShader/NoOutline/ToonColor_ShadingGradeMap_Transparent_StencilOut","be27d4be45de7dd4ab2e69c992876edb"},
{"UnityChanToonShader/Toon_DoubleShadeWithFeather","9baf30ce95c751649b14d96da3a4b4d5"},
{"UnityChanToonShader/Toon_DoubleShadeWithFeather_Clipping","345def18d0906d544b7d12b050937392"},
{"UnityChanToonShader/Toon_DoubleShadeWithFeather_Clipping_StencilMask","7a735f9b121d96349b6da0a077299424"},
{"UnityChanToonShader/Toon_DoubleShadeWithFeather_Clipping_StencilOut","ed7fba947f3bccb4cbc78f55d7a56a70"},
{"UnityChanToonShader/Mobile/Toon_DoubleShadeWithFeather","1d10c7840eb6ba74c889a27f14ba6081"},
{"UnityChanToonShader/Mobile/Toon_DoubleShadeWithFeather_Clipping","88791c14394118d42a5e176b433af322"},
{"UnityChanToonShader/Mobile/Toon_DoubleShadeWithFeather_Clipping_StencilMask","41f4ee183cb66ad40bc74a9f8f944974"},
{"UnityChanToonShader/Mobile/Toon_DoubleShadeWithFeather_StencilMask","dec01cbdbc5b8da4ca8671815cda1557"},
{"UnityChanToonShader/Mobile/Toon_DoubleShadeWithFeather_StencilOut","55e8b9eeaaff205469365133fe7bc744"},
{"UnityChanToonShader/Mobile/Toon_DoubleShadeWithFeather_TransClipping","d4c592285a93c3844aafdaafffc07ec7"},
{"UnityChanToonShader/Mobile/Toon_DoubleShadeWithFeather_TransClipping_StencilMask","100d373b596f44d49ac9bb944d671d32"},
{"UnityChanToonShader/Toon_DoubleShadeWithFeather_StencilMask","036bc90bfe3475b4c9fadb85d0520621"},
{"UnityChanToonShader/Toon_DoubleShadeWithFeather_StencilOut","0a1e4c9dcc0e9ea4db38ae9cb5059608"},
{"UnityChanToonShader/Toon_DoubleShadeWithFeather_TransClipping","e8e7d781c3155254b9ea8956c5bd1218"},
{"UnityChanToonShader/Toon_DoubleShadeWithFeather_TransClipping_StencilMask","79add09e32e5c4541980118f6c4045b6"},
{"UnityChanToonShader/Toon_DoubleShadeWithFeather_TransClipping_StencilOut","fb47be5a840097b45bac228446468ef3"},
{"UnityChanToonShader/Helper/Toon_OutlineObject","42a47eda2ed77084c9136507eadb8641"},
{"UnityChanToonShader/Helper/Toon_OutlineObject_StencilOut","2e2edd12fbf6bcb4ea1f34c17ee42df5"},
{"UnityChanToonShader/Toon_ShadingGradeMap","ca035891872022e4f80c952b3916e450"},
{"UnityChanToonShader/AngelRing/Toon_ShadingGradeMap","9aadc53d7cdc63f4898ea042aa9d853b"},
{"UnityChanToonShader/Mobile/AngelRing/Toon_ShadingGradeMap","23e399973d807464fb195291a44a614c"},
{"UnityChanToonShader/Mobile/AngelRing/Toon_ShadingGradeMap_StencilOut","8d33e4e4084e5af449f3e762fecce3c9"},
{"UnityChanToonShader/AngelRing/Toon_ShadingGradeMap_StencilOut","415f07ab6fd766048ac6f8c2f2b406a9"},
{"UnityChanToonShader/AngelRing/Toon_ShadingGradeMap_TransClipping","b2a70923168ea0c40a3051a013c93a8a"},
{"UnityChanToonShader/AngelRing/Toon_ShadingGradeMap_TransClipping_StencilOut","d1e11a558d143f14c864edf263332764"},
{"UnityChanToonShader/Mobile/Toon_ShadingGradeMap","f90e11a40dcf4f745ae6b21b857943fa"},
{"UnityChanToonShader/Mobile/Toon_ShadingGradeMap_StencilMask","206c554c8b0c60041a9d242385f543d3"},
{"UnityChanToonShader/Mobile/Toon_ShadingGradeMap_StencilOut","cfc201757f2519c4bb6ef9265a046582"},
{"UnityChanToonShader/Mobile/Toon_ShadingGradeMap_TransClipping","cce1da34c52aff745adf0222f56a356c"},
{"UnityChanToonShader/Mobile/Toon_ShadingGradeMap_TransClipping_StencilMask","e88039bab21b7894e918126e8fce5d1b"},
{"UnityChanToonShader/Toon_ShadingGradeMap_StencilMask","aa2e05ed58ca15441bd0989f008da78b"},
{"UnityChanToonShader/Toon_ShadingGradeMap_StencilOut","923058fda1b61544b93d91eeee772086"},
{"UnityChanToonShader/Toon_ShadingGradeMap_TransClipping","aebd33b74ef849a4882b4a8d55f0f0c9"},
{"UnityChanToonShader/Toon_ShadingGradeMap_TransClipping_StencilMask","0a05dd221bacbb448afac3d63e6bd833"},
{"UnityChanToonShader/Toon_ShadingGradeMap_TransClipping_StencilOut","67212ac11ff43b04a833d3986b997a9f"},
{"UnityChanToonShader/Tessellation/NoOutline/ToonColor_DoubleShadeWithFeather_Clipping","5b8a1502578ed764c9880a7be65c9672"},
{"UnityChanToonShader/Tessellation/NoOutline/ToonColor_DoubleShadeWithFeather_Clipping_StencilMask","682e6e6cf60a51040ade19437a3f53e2"},
{"UnityChanToonShader/Tessellation/NoOutline/ToonColor_DoubleShadeWithFeather_Clipping_StencilOut","148d1eca2cf299e4eb949d15c4cf95ee"},
{"UnityChanToonShader/Tessellation/NoOutline/ToonColor_DoubleShadeWithFeather","e987cf9cca0941042aa68d1dd51ee20f"},
{"UnityChanToonShader/Tessellation/NoOutline/ToonColor_DoubleShadeWithFeather_StencilMask","97df86a7afe06ef41b2a2c242b10593e"},
{"UnityChanToonShader/Tessellation/NoOutline/ToonColor_DoubleShadeWithFeather_StencilOut","b179fb8a87955a347b5f594a18b43475"},
{"UnityChanToonShader/Tessellation/NoOutline/ToonColor_DoubleShadeWithFeather_TransClipping","60fe384b76fb67d40bc7e38411073dd6"},
{"UnityChanToonShader/Tessellation/NoOutline/ToonColor_DoubleShadeWithFeather_TransClipping_StencilMask","4a20b66d106d3f5409f759b5193ecdc2"},
{"UnityChanToonShader/Tessellation/NoOutline/ToonColor_DoubleShadeWithFeather_TransClipping_StencilOut","a7842aa9522c7584cae2169b8e1ddb86"},
{"UnityChanToonShader/Tessellation/NoOutline/ToonColor_DoubleShadeWithFeather_Transparent","0cb6c9e6216a91e4a9d38cd2acb4ccb6"},
{"UnityChanToonShader/Tessellation/NoOutline/ToonColor_DoubleShadeWithFeather_Transparent_StencilOut","f28bba8b2f259bb40b697d91849c8794"},
{"UnityChanToonShader/Tessellation/NoOutline/AngelRing/ToonColor_ShadingGradeMap","4876871966ca2344793e439d7391d7b0"},
{"UnityChanToonShader/Tessellation/NoOutline/AngelRing/ToonColor_ShadingGradeMap_StencilOut","7c48bdc9fed28c14b8ad0748673b1369"},
{"UnityChanToonShader/Tessellation/NoOutline/AngelRing/ToonColor_ShadingGradeMap_TransClipping","d3fb22770ec830b43bdb5ccb973e6f76"},
{"UnityChanToonShader/Tessellation/NoOutline/AngelRing/ToonColor_ShadingGradeMap_TransClipping_StencilOut","11e8f1e181e558a47a387492d3ecdb88"},
{"UnityChanToonShader/Tessellation/NoOutline/ToonColor_ShadingGradeMap","01494e58d87212f44ab51d29caea84e4"},
{"UnityChanToonShader/Tessellation/NoOutline/ToonColor_ShadingGradeMap_StencilMask","24c20b8ed5be113499b40f4e3b6b03e6"},
{"UnityChanToonShader/Tessellation/NoOutline/ToonColor_ShadingGradeMap_StencilOut","9cf7e8eb46e9128438d50adf7a841de6"},
{"UnityChanToonShader/Tessellation/NoOutline/ToonColor_ShadingGradeMap_TransClipping","3c39a77fda28b5043a7a17c7877cf7b2"},
{"UnityChanToonShader/Tessellation/NoOutline/ToonColor_ShadingGradeMap_TransClipping_StencilMask","bf840a439c33c8b4a99d52e6c3d8511f"},
{"UnityChanToonShader/Tessellation/NoOutline/ToonColor_ShadingGradeMap_TransClipping_StencilOut","8eff803eae89c994fae3acf2f686fafa"},
{"UnityChanToonShader/Tessellation/NoOutline/ToonColor_ShadingGradeMap_Transparent","0959cb8822a344c4da890457e668fdc9"},
{"UnityChanToonShader/Tessellation/NoOutline/ToonColor_ShadingGradeMap_Transparent_StencilOut","6d115cf94d14d1842a56dfff76b57f42"},
{"UnityChanToonShader/Tessellation/Toon_DoubleShadeWithFeather_Clipping","f0b2fc9b8a189134da9c7d24f361caf4"},
{"UnityChanToonShader/Tessellation/Toon_DoubleShadeWithFeather_Clipping_StencilMask","8c94ee3046ef0574f87f6b658b4e4691"},
{"UnityChanToonShader/Tessellation/Toon_DoubleShadeWithFeather_Clipping_StencilOut","c4aed8662ca0f194284f3ab649e66d23"},
{"UnityChanToonShader/Tessellation/Toon_DoubleShadeWithFeather","1f248db3b28fc5f44aabd7aca618bd1e"},
{"UnityChanToonShader/Tessellation/Light/Toon_DoubleShadeWithFeather","a3214384442742648aa664ef0039d397"},
{"UnityChanToonShader/Tessellation/Light/Toon_DoubleShadeWithFeather_StencilMask","3073cd2564e4cde45a19c05e0012d22a"},
{"UnityChanToonShader/Tessellation/Light/Toon_DoubleShadeWithFeather_StencilOut","7e7690a767a07da4f943439680e70db8"},
{"UnityChanToonShader/Tessellation/Toon_DoubleShadeWithFeather_StencilMask","08c65988dc25d9f44b791fcc18fb543a"},
{"UnityChanToonShader/Tessellation/Toon_DoubleShadeWithFeather_StencilOut","f937ea4ce96dfbe448afc0fb671198e5"},
{"UnityChanToonShader/Tessellation/Toon_DoubleShadeWithFeather_TransClipping","3fb99ac3775edeb4aa9530db5a614c92"},
{"UnityChanToonShader/Tessellation/Toon_DoubleShadeWithFeather_TransClipping_StencilMask","9855f226cd8152d4e99085272aceede6"},
{"UnityChanToonShader/Tessellation/Toon_DoubleShadeWithFeather_TransClipping_StencilOut","2a0d4af863770404faee6488b86fe3c9"},
{"UnityChanToonShader/Tessellation/Helper/Toon_OutlineObject","1847c44f729b68e49ba63610abdf9132"},
{"UnityChanToonShader/Tessellation/Helper/Toon_OutlineObject_StencilOut","06cae78b869a3234bab02eeb52197e1c"},
{"UnityChanToonShader/Tessellation/AngelRing/Toon_ShadingGradeMap","3a1af221400a61a4b94bae19aa79da2b"},
{"UnityChanToonShader/Tessellation/Light/AngelRing/Toon_ShadingGradeMap","a1449ab672051624ca3160737b630f5e"},
{"UnityChanToonShader/Tessellation/Light/AngelRing/Toon_ShadingGradeMap_StencilOut","79d3dc54c32b69b42be17c48d33575f2"},
{"UnityChanToonShader/Tessellation/AngelRing/Toon_ShadingGradeMap_StencilOut","18c9172cdf36a344f9aca9bbc0e7002d"},
{"UnityChanToonShader/Tessellation/AngelRing/Toon_ShadingGradeMap_TransClipping","54a94f776a43a074c8c2d205bb934005"},
{"UnityChanToonShader/Tessellation/AngelRing/Toon_ShadingGradeMap_TransClipping_StencilOut","d496a1c70c797ad43836d5bfff575b5f"},
{"UnityChanToonShader/Tessellation/Toon_ShadingGradeMap","183ea557143786346b1bfc862ad22636"},
{"UnityChanToonShader/Tessellation/Light/Toon_ShadingGradeMap","356dd5af8f0d40e41b647d3d0a0555c1"},
{"UnityChanToonShader/Tessellation/Light/Toon_ShadingGradeMap_StencilMask","ffadecfbd9e31f840ba4109fea0f0436"},
{"UnityChanToonShader/Tessellation/Light/Toon_ShadingGradeMap_StencilOut","98ac5d198a471494da681b7b8d1e1727"},
{"UnityChanToonShader/Tessellation/Toon_ShadingGradeMap_StencilMask","0d799eb857c0e2c45bbdfb2c033d33e6"},
{"UnityChanToonShader/Tessellation/Toon_ShadingGradeMap_StencilOut","e667137c8b6fd3d4390fc364b2e5c70b"},
{"UnityChanToonShader/Tessellation/Toon_ShadingGradeMap_TransClipping","feba437d8ff93f745a78828529e9a272"},
{"UnityChanToonShader/Tessellation/Toon_ShadingGradeMap_TransClipping_StencilMask","8d1395a9f4bfad44d8fddd0f2af19b1e"},
{"UnityChanToonShader/Tessellation/Toon_ShadingGradeMap_TransClipping_StencilOut","08c6bb334aed21c4198cf46b71ebca2d"},
{"UniGLTF/UniUnlit","8c17b56f4bf084c47872edcb95237e4a"},
{"UnlitWF/Debug/WF_DebugView","c7e5995223250464cac205689e058693"},
{"UnlitWF/WF_FakeFur_TransCutout","58bb80b63bec29d4384e105c53ca6970"},
{"UnlitWF/WF_FakeFur_Transparent","2210f95a2274e9d4faf8a14dac933fdb"},
{"UnlitWF/WF_Gem_Opaque","c0f75d3ed420fd144a74722588d3bc21"},
{"UnlitWF/WF_Gem_Transparent","21f6eaa1dd1f25c4cb29a42c4ff5d98f"},
{"UnlitWF/Custom/WF_UnToon_Custom_GhostTransparent","4ba701b07ccc81e4aae7f053bf332eab"},
{"UnlitWF/Custom/WF_UnToon_Custom_LameOnly_Transparent","f3f80636c64e389498b3b19e2ee218da"},
{"UnlitWF/Custom/WF_UnToon_Custom_OffsetOutline_Opaque","90cac9ec3b2a7524eb99b36ab87f25f1"},
{"UnlitWF/Custom/WF_UnToon_Custom_PowerCap_Outline_Opaque","871fd7a51a8ea3e4980c3fe7b8347619"},
{"UnlitWF/Custom/WF_UnToon_Custom_Tess_PowerCap_Opaque","58ccf9c912b226146a25726b8a1f04db"},
{"Hidden/UnlitWF/WF_UnToon_Hidden","af51615040dcdad4cb01c29ea34dbb03"},
{"UnlitWF/UnToon_Mobile/WF_UnToon_Mobile_Opaque","4bd76f6599a5b8e4d88d81300fb74c37"},
{"UnlitWF/UnToon_Mobile/WF_UnToon_Mobile_OutlineOnly_Opaque","d279a88eda1ae0e4c89e92539639eb16"},
{"UnlitWF/UnToon_Mobile/WF_UnToon_Mobile_OutlineOnly_TransCutout","e0b93fdad2eeedf42baccbc0975cdd1d"},
{"UnlitWF/UnToon_Mobile/WF_UnToon_Mobile_TransCutout","af3422dc9372a89449a9f44d409d9714"},
{"UnlitWF/UnToon_Mobile/WF_UnToon_Mobile_Transparent","0a7a6cdca16a38548a5d81aca8d4e3ba"},
{"UnlitWF/UnToon_Mobile/WF_UnToon_Mobile_TransparentOverlay","4e4be4aab63a2bd4fbcea2390ae92fdf"},
{"UnlitWF/WF_UnToon_Opaque","a3678756e883b9349ac22fce33313139"},
{"UnlitWF/UnToon_Outline/WF_UnToon_OutlineOnly_Opaque","4eef00f52cc21b04e9e34e4caefa6bbf"},
{"UnlitWF/UnToon_Outline/WF_UnToon_OutlineOnly_TransCutout","64bf3ca653a7b274fab3e8a87016bfb0"},
{"UnlitWF/UnToon_Outline/WF_UnToon_OutlineOnly_Transparent","660abd485057f4740ac9050f7ab3237d"},
{"UnlitWF/UnToon_Outline/WF_UnToon_OutlineOnly_Transparent_MaskOut","3c07b964e541eef45bc195a029b878b3"},
{"UnlitWF/UnToon_Outline/WF_UnToon_Outline_Opaque","a5ae7f40ac53e274ea0bc1262e1f6895"},
{"UnlitWF/UnToon_Outline/WF_UnToon_Outline_TransCutout","ab4eb87c406a22f46887cf72178e2685"},
{"UnlitWF/UnToon_Outline/WF_UnToon_Outline_Transparent","5523e041d29d259439fa14bd131f5c82"},
{"UnlitWF/UnToon_Outline/WF_UnToon_Outline_Transparent3Pass","5498b01615002d948bea7542f55e0c07"},
{"UnlitWF/UnToon_Outline/WF_UnToon_Outline_Transparent_MaskOut","9350854c6e88f3f4eb873d2f94ff3328"},
{"UnlitWF/UnToon_Outline/WF_UnToon_Outline_Transparent_MaskOut_Blend","ad88000744b4fb241835ba6ec106caf4"},
{"UnlitWF/UnToon_PowerCap/WF_UnToon_PowerCap_Opaque","0733cfc88032e8d4eafce250263c497c"},
{"UnlitWF/UnToon_PowerCap/WF_UnToon_PowerCap_TransCutout","2cf66b0706c40744baab089297afa895"},
{"UnlitWF/UnToon_PowerCap/WF_UnToon_PowerCap_Transparent","747bf283d686334469fb662b2fc4a5c2"},
{"UnlitWF/UnToon_PowerCap/WF_UnToon_PowerCap_Transparent3Pass","d242cb83664caae4f957030870dd801d"},
{"UnlitWF/UnToon_Tessellation/WF_UnToon_Tess_Opaque","dd3a683002b3a6f43bdb6c97bd0985c1"},
{"UnlitWF/UnToon_Tessellation/WF_UnToon_Tess_TransCutout","94ee7f8988740fd4887f8b1ce41f0c1c"},
{"UnlitWF/UnToon_Tessellation/WF_UnToon_Tess_Transparent","3bde56820d1aece41bd22966876a061c"},
{"UnlitWF/UnToon_Tessellation/WF_UnToon_Tess_Transparent3Pass","78d2e3fa0b8eb674aa9cf9e048f79c93"},
{"UnlitWF/WF_UnToon_TransCutout","8c7888a4ac175584f81e0b6e7d4af5a7"},
{"UnlitWF/WF_UnToon_Transparent","15212414cba0c7a4aac92d94a4ae8750"},
{"UnlitWF/WF_UnToon_Transparent3Pass","d1e7b0a18e221a1409ad59065ec157e4"},
{"UnlitWF/WF_UnToon_Transparent_Mask","2efe527cfcbf0e1408b67463225f552f"},
{"UnlitWF/WF_UnToon_Transparent_MaskOut","0b53cf0bcd0f9db4fa9d1297d255d06d"},
{"UnlitWF/WF_UnToon_Transparent_MaskOut_Blend","d01a5c313ada49e488b2ef8c6b00f56d"},
{"UnlitWF/UnToon_TriShade/WF_UnToon_TriShade_Opaque","a220e3e0675cc3f4f817a485688788d6"},
{"UnlitWF/UnToon_TriShade/WF_UnToon_TriShade_TransCutout","2d294f328149d944eb0899b452ff879c"},
{"UnlitWF/UnToon_TriShade/WF_UnToon_TriShade_Transparent","1435581bcf13e7a47b5bf5636f8d8252"},
{"UnlitWF/UnToon_TriShade/WF_UnToon_TriShade_Transparent3Pass","e7263331a8ee0a04aa4a271fc1fef104"},
{"UnlitWF/UnToon_TriShade/WF_UnToon_TriShade_Transparent_Mask","0299954f2a9b0994f8c9587945948766"},
{"UnlitWF/UnToon_TriShade/WF_UnToon_TriShade_Transparent_MaskOut","06e9294a93df4474cac2f4157b5e1d1d"},
{"UnlitWF/UnToon_TriShade/WF_UnToon_TriShade_Transparent_MaskOut_Blend","dfb821bc7afadc14591e4338a8ec865f"},
{"Xiexe/Toon2.0/XSToon2.0_Outlined","956a7ff9ce5a1cf4c8735b173dfac4bc"},
{"Xiexe/Toon2.0/XSToon2.0","85c615217d617204cb497ae6838b8bae"},
{"Xiexe/Toon2.0/XSToonStenciler","39f23e8c24d1e864096d29da0407b88e"},
{"Hidden/Poi/TexturePacker","71129bd3774e04d48827a25fc98d45a7"},
{"Hidden/Poi/TextureUnpacker","245e67c21ccaa9a43ad7e84d1c7bb5fc"},
{"Thry/Example 1","8a38f752c293b5548b674637c2a6f99a"},
{"Thry/Example 2","0b436e0db169bde429124bf491f28cef"},
{".poiyomi/Extras/StencilInvis","a49dd2fba12886c499261512c6eaaa80"},
{".poiyomi/Extras/MasterScanner","add1d40d10695a24b9e91e172ccb9525"},
{".poiyomi/• Poiyomi Toon •","917b37092bae034459c28c00a3a19b54"},

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