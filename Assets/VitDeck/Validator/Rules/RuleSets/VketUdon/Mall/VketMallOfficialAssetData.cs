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
                #region Mall

                "82e13d2a938694aedb5dbb01bd3ecf07", //Assets/VketMallShaderPack/MMS3/LICENSE
"8dd7c14dadb834c4e8324f7d08c5674e", //Assets/VketMallShaderPack/MMS3/MMS3.shader
"128f4720891e8914ab7e6673099df0f0", //Assets/VketMallShaderPack/MMS3/MMS3_Cutout.shader
"fbaec084851cef64fbd877b3b15716cb", //Assets/VketMallShaderPack/MMS3/MMS3_Outline.shader
"f889d00a055a0488e9ecbf22c558ae76", //Assets/VketMallShaderPack/MMS3/MMS3_Stencil_Reader.shader
"f55508f2ed8cc477f9574099971bc4eb", //Assets/VketMallShaderPack/MMS3/MMS3_Stencil_Writer.shader
"fda424b70f79d4e5488e1cc3ee100a95", //Assets/VketMallShaderPack/MMS3/MMS3_Transparent.shader
"ece969dbfb97d446ba8f8358a78789b5", //Assets/VketMallShaderPack/MMS3/Shade_Matcap1.psd
"2a5e8a5d481e3574b8274fa7ce4bdc2d", //Assets/VketMallShaderPack/MToon-3.6/LICENSE
"1021e7e6d453b9f4fb2f46a130425deb", //Assets/VketMallShaderPack/MToon-3.6/README.md
"a9bc101fb0471f94a8f99fd242fdd934", //Assets/VketMallShaderPack/MToon-3.6/MToon/MToon.asmdef
"24156f9da0724eb5a159f36c69a7d90a", //Assets/VketMallShaderPack/MToon-3.6/MToon/Editor/EditorEnums.cs
"531922bb16b74a00b81445116c49b09c", //Assets/VketMallShaderPack/MToon-3.6/MToon/Editor/EditorUtils.cs
"dddf8398e965f254cae2d7519d7f67d2", //Assets/VketMallShaderPack/MToon-3.6/MToon/Editor/MToon.Editor.asmdef
"8b43baa9f62f04748bb167ad186f1b1a", //Assets/VketMallShaderPack/MToon-3.6/MToon/Editor/MToonInspector.cs
"1a97144e4ad27a04aafd70f7b915cedb", //Assets/VketMallShaderPack/MToon-3.6/MToon/Resources/Shaders/MToon.shader
"ef6682d138947ed4fbc8fbecfe75cd28", //Assets/VketMallShaderPack/MToon-3.6/MToon/Resources/Shaders/MToonCore.cginc
"084281ffd8b1b8e4a8605725d3b0760b", //Assets/VketMallShaderPack/MToon-3.6/MToon/Resources/Shaders/MToonSM3.cginc
"17d4e0f990fbc794ab41e4fcc196d559", //Assets/VketMallShaderPack/MToon-3.6/MToon/Resources/Shaders/MToonSM4.cginc
"9a3fb070d7eb4114b5cf387e2cd60391", //Assets/VketMallShaderPack/MToon-3.6/MToon/Scripts/Enums.cs
"2849b99d94074fcf9e10c5ca3eab15a8", //Assets/VketMallShaderPack/MToon-3.6/MToon/Scripts/MToonDefinition.cs
"9d2012c170a74b3db0002f7ecda53622", //Assets/VketMallShaderPack/MToon-3.6/MToon/Scripts/Utils.cs
"6724aa45c8c349fabd5954a531301aa8", //Assets/VketMallShaderPack/MToon-3.6/MToon/Scripts/UtilsGetter.cs
"b24a672e82874c9fbfef9c2b2dfdab42", //Assets/VketMallShaderPack/MToon-3.6/MToon/Scripts/UtilsSetter.cs
"4702d4b2c1414cc08b4382c3762eebab", //Assets/VketMallShaderPack/MToon-3.6/MToon/Scripts/UtilsVersion.cs
"e30857b716beae5479b313fde1a5efaf", //Assets/VketMallShaderPack/Toon/Editor/CopyMaterialParameter.cs
"cad15f56be91b744aaf8e22339bc598c", //Assets/VketMallShaderPack/Toon/Editor/RemoveUnusedMaterialProperties.cs
"a9775daf5f793f64e98ccd6c4a61bbc8", //Assets/VketMallShaderPack/Toon/Editor/RemoveUnusedShaderKeywordsFromUTS2Material.cs
"e403ef4b1d56fce47b49ec46981d9fcb", //Assets/VketMallShaderPack/Toon/Editor/UTS2GUI.cs
"4c57a42f315f467488f69755e6a7d42c", //Assets/VketMallShaderPack/Toon/Shader/README.txt
"96d4d9f975e6c8849bd1a5c06acfae84", //Assets/VketMallShaderPack/Toon/Shader/ToonColor_DoubleShadeWithFeather.shader
"ccd13b7f8710b264ea8bd3bc4f51f9e4", //Assets/VketMallShaderPack/Toon/Shader/ToonColor_DoubleShadeWithFeather_Clipping.shader
"9c3978743d5db18448a8b945c723a6eb", //Assets/VketMallShaderPack/Toon/Shader/ToonColor_DoubleShadeWithFeather_Clipping_StencilMask.shader
"d7da29588857e774bb0650f1fae494c6", //Assets/VketMallShaderPack/Toon/Shader/ToonColor_DoubleShadeWithFeather_Clipping_StencilOut.shader
"315897103223dab42a0746aa65ec251a", //Assets/VketMallShaderPack/Toon/Shader/ToonColor_DoubleShadeWithFeather_StencilMask.shader
"2e5cc2da6af713844956264245e092e4", //Assets/VketMallShaderPack/Toon/Shader/ToonColor_DoubleShadeWithFeather_StencilOut.shader
"369d674ae1ba36249bb00e2f73b0cd10", //Assets/VketMallShaderPack/Toon/Shader/ToonColor_DoubleShadeWithFeather_TransClipping.shader
"8600b2bec3ae31145afa80084df20c61", //Assets/VketMallShaderPack/Toon/Shader/ToonColor_DoubleShadeWithFeather_TransClipping_StencilMask.shader
"43d0eeb4c46f52841b0941e99ac9b16b", //Assets/VketMallShaderPack/Toon/Shader/ToonColor_DoubleShadeWithFeather_TransClipping_StencilOut.shader
"97b7edb5fc0f5744c9b264c2224a0b1e", //Assets/VketMallShaderPack/Toon/Shader/ToonColor_DoubleShadeWithFeather_Transparent.shader
"3b20fc0febd34f94baf0304bf47841d8", //Assets/VketMallShaderPack/Toon/Shader/ToonColor_DoubleShadeWithFeather_Transparent_StencilOut.shader
"af8454e09b3a41448a4140e792059446", //Assets/VketMallShaderPack/Toon/Shader/ToonColor_ShadingGradeMap.shader
"295fec4a7029edd4eb9522bef07f41ce", //Assets/VketMallShaderPack/Toon/Shader/ToonColor_ShadingGradeMap_AngelRing.shader
"e32270aa38f4b664b90f04cc475fdb81", //Assets/VketMallShaderPack/Toon/Shader/ToonColor_ShadingGradeMap_AngelRing_StencilOut.shader
"29a860a3f3c4cec43ab821338e28eac8", //Assets/VketMallShaderPack/Toon/Shader/ToonColor_ShadingGradeMap_AngelRing_TransClipping.shader
"d5d9c1f4718235248ad37448b0c74c68", //Assets/VketMallShaderPack/Toon/Shader/ToonColor_ShadingGradeMap_AngelRing_TransClipping_StencilOut.shader
"6439813c08a1f8947bb0ca6599499dd7", //Assets/VketMallShaderPack/Toon/Shader/ToonColor_ShadingGradeMap_StencilMask.shader
"b39692f1382224b4cbe21c12ae51c639", //Assets/VketMallShaderPack/Toon/Shader/ToonColor_ShadingGradeMap_StencilOut.shader
"cd7e85b59edbb7740841003baeb510b5", //Assets/VketMallShaderPack/Toon/Shader/ToonColor_ShadingGradeMap_TransClipping.shader
"6b4b6d07944415f44b1fc2f0fc24535f", //Assets/VketMallShaderPack/Toon/Shader/ToonColor_ShadingGradeMap_TransClipping_StencilMask.shader
"31c75b34739dfc64fb57bf49005e942d", //Assets/VketMallShaderPack/Toon/Shader/ToonColor_ShadingGradeMap_TransClipping_StencilOut.shader
"7737ca8c4e3939f4086a6e08f93c2ebd", //Assets/VketMallShaderPack/Toon/Shader/ToonColor_ShadingGradeMap_Transparent.shader
"be27d4be45de7dd4ab2e69c992876edb", //Assets/VketMallShaderPack/Toon/Shader/ToonColor_ShadingGradeMap_Transparent_StencilOut.shader
"9baf30ce95c751649b14d96da3a4b4d5", //Assets/VketMallShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather.shader
"345def18d0906d544b7d12b050937392", //Assets/VketMallShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_Clipping.shader
"7a735f9b121d96349b6da0a077299424", //Assets/VketMallShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_Clipping_StencilMask.shader
"ed7fba947f3bccb4cbc78f55d7a56a70", //Assets/VketMallShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_Clipping_StencilOut.shader
"1d10c7840eb6ba74c889a27f14ba6081", //Assets/VketMallShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_Mobile.shader
"88791c14394118d42a5e176b433af322", //Assets/VketMallShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_Mobile_Clipping.shader
"41f4ee183cb66ad40bc74a9f8f944974", //Assets/VketMallShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_Mobile_Clipping_StencilMask.shader
"dec01cbdbc5b8da4ca8671815cda1557", //Assets/VketMallShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_Mobile_StencilMask.shader
"55e8b9eeaaff205469365133fe7bc744", //Assets/VketMallShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_Mobile_StencilOut.shader
"d4c592285a93c3844aafdaafffc07ec7", //Assets/VketMallShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_Mobile_TransClipping.shader
"100d373b596f44d49ac9bb944d671d32", //Assets/VketMallShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_Mobile_TransClipping_StencilMask.shader
"036bc90bfe3475b4c9fadb85d0520621", //Assets/VketMallShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_StencilMask.shader
"0a1e4c9dcc0e9ea4db38ae9cb5059608", //Assets/VketMallShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_StencilOut.shader
"e8e7d781c3155254b9ea8956c5bd1218", //Assets/VketMallShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_TransClipping.shader
"79add09e32e5c4541980118f6c4045b6", //Assets/VketMallShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_TransClipping_StencilMask.shader
"fb47be5a840097b45bac228446468ef3", //Assets/VketMallShaderPack/Toon/Shader/Toon_DoubleShadeWithFeather_TransClipping_StencilOut.shader
"42a47eda2ed77084c9136507eadb8641", //Assets/VketMallShaderPack/Toon/Shader/Toon_OutlineObject.shader
"2e2edd12fbf6bcb4ea1f34c17ee42df5", //Assets/VketMallShaderPack/Toon/Shader/Toon_OutlineObject_StencilOut.shader
"ca035891872022e4f80c952b3916e450", //Assets/VketMallShaderPack/Toon/Shader/Toon_ShadingGradeMap.shader
"9aadc53d7cdc63f4898ea042aa9d853b", //Assets/VketMallShaderPack/Toon/Shader/Toon_ShadingGradeMap_AngelRing.shader
"23e399973d807464fb195291a44a614c", //Assets/VketMallShaderPack/Toon/Shader/Toon_ShadingGradeMap_AngelRing_Mobile.shader
"8d33e4e4084e5af449f3e762fecce3c9", //Assets/VketMallShaderPack/Toon/Shader/Toon_ShadingGradeMap_AngelRing_Mobile_StencilOut.shader
"415f07ab6fd766048ac6f8c2f2b406a9", //Assets/VketMallShaderPack/Toon/Shader/Toon_ShadingGradeMap_AngelRing_StencilOut.shader
"b2a70923168ea0c40a3051a013c93a8a", //Assets/VketMallShaderPack/Toon/Shader/Toon_ShadingGradeMap_AngelRing_TransClipping.shader
"d1e11a558d143f14c864edf263332764", //Assets/VketMallShaderPack/Toon/Shader/Toon_ShadingGradeMap_AngelRing_TransClipping_StencilOut.shader
"f90e11a40dcf4f745ae6b21b857943fa", //Assets/VketMallShaderPack/Toon/Shader/Toon_ShadingGradeMap_Mobile.shader
"206c554c8b0c60041a9d242385f543d3", //Assets/VketMallShaderPack/Toon/Shader/Toon_ShadingGradeMap_Mobile_StencilMask.shader
"cfc201757f2519c4bb6ef9265a046582", //Assets/VketMallShaderPack/Toon/Shader/Toon_ShadingGradeMap_Mobile_StencilOut.shader
"cce1da34c52aff745adf0222f56a356c", //Assets/VketMallShaderPack/Toon/Shader/Toon_ShadingGradeMap_Mobile_TransClipping.shader
"e88039bab21b7894e918126e8fce5d1b", //Assets/VketMallShaderPack/Toon/Shader/Toon_ShadingGradeMap_Mobile_TransClipping_StencilMask.shader
"aa2e05ed58ca15441bd0989f008da78b", //Assets/VketMallShaderPack/Toon/Shader/Toon_ShadingGradeMap_StencilMask.shader
"923058fda1b61544b93d91eeee772086", //Assets/VketMallShaderPack/Toon/Shader/Toon_ShadingGradeMap_StencilOut.shader
"aebd33b74ef849a4882b4a8d55f0f0c9", //Assets/VketMallShaderPack/Toon/Shader/Toon_ShadingGradeMap_TransClipping.shader
"0a05dd221bacbb448afac3d63e6bd833", //Assets/VketMallShaderPack/Toon/Shader/Toon_ShadingGradeMap_TransClipping_StencilMask.shader
"67212ac11ff43b04a833d3986b997a9f", //Assets/VketMallShaderPack/Toon/Shader/Toon_ShadingGradeMap_TransClipping_StencilOut.shader
"80bd7ce6cad775a4e9de24e18eb5e61e", //Assets/VketMallShaderPack/Toon/Shader/UCTS_DoubleShadeWithFeather.cginc
"ec7b5c1d006f6be49b412bcd7a789c78", //Assets/VketMallShaderPack/Toon/Shader/UCTS_Outline.cginc
"eca315d4d2d36194b8be3cf2a6869762", //Assets/VketMallShaderPack/Toon/Shader/UCTS_ShadingGradeMap.cginc
"ae8d06deb98501947846000ba6cd3ab2", //Assets/VketMallShaderPack/Toon/Shader/UCTS_ShadowCaster.cginc
"5b8a1502578ed764c9880a7be65c9672", //Assets/VketMallShaderPack/Toon/Shader/Tess/ToonColor_DoubleShadeWithFeather_Clipping_Tess.shader
"682e6e6cf60a51040ade19437a3f53e2", //Assets/VketMallShaderPack/Toon/Shader/Tess/ToonColor_DoubleShadeWithFeather_Clipping_Tess_StencilMask.shader
"148d1eca2cf299e4eb949d15c4cf95ee", //Assets/VketMallShaderPack/Toon/Shader/Tess/ToonColor_DoubleShadeWithFeather_Clipping_Tess_StencilOut.shader
"e987cf9cca0941042aa68d1dd51ee20f", //Assets/VketMallShaderPack/Toon/Shader/Tess/ToonColor_DoubleShadeWithFeather_Tess.shader
"97df86a7afe06ef41b2a2c242b10593e", //Assets/VketMallShaderPack/Toon/Shader/Tess/ToonColor_DoubleShadeWithFeather_Tess_StencilMask.shader
"b179fb8a87955a347b5f594a18b43475", //Assets/VketMallShaderPack/Toon/Shader/Tess/ToonColor_DoubleShadeWithFeather_Tess_StencilOut.shader
"60fe384b76fb67d40bc7e38411073dd6", //Assets/VketMallShaderPack/Toon/Shader/Tess/ToonColor_DoubleShadeWithFeather_TransClipping_Tess.shader
"4a20b66d106d3f5409f759b5193ecdc2", //Assets/VketMallShaderPack/Toon/Shader/Tess/ToonColor_DoubleShadeWithFeather_TransClipping_Tess_StencilMask.shader
"a7842aa9522c7584cae2169b8e1ddb86", //Assets/VketMallShaderPack/Toon/Shader/Tess/ToonColor_DoubleShadeWithFeather_TransClipping_Tess_StencilOut.shader
"0cb6c9e6216a91e4a9d38cd2acb4ccb6", //Assets/VketMallShaderPack/Toon/Shader/Tess/ToonColor_DoubleShadeWithFeather_Transparent_Tess.shader
"f28bba8b2f259bb40b697d91849c8794", //Assets/VketMallShaderPack/Toon/Shader/Tess/ToonColor_DoubleShadeWithFeather_Transparent_Tess_StencilOut.shader
"4876871966ca2344793e439d7391d7b0", //Assets/VketMallShaderPack/Toon/Shader/Tess/ToonColor_ShadingGradeMap_AngelRing_Tess.shader
"7c48bdc9fed28c14b8ad0748673b1369", //Assets/VketMallShaderPack/Toon/Shader/Tess/ToonColor_ShadingGradeMap_AngelRing_Tess_StencilOut.shader
"d3fb22770ec830b43bdb5ccb973e6f76", //Assets/VketMallShaderPack/Toon/Shader/Tess/ToonColor_ShadingGradeMap_AngelRing_Tess_TransClipping.shader
"11e8f1e181e558a47a387492d3ecdb88", //Assets/VketMallShaderPack/Toon/Shader/Tess/ToonColor_ShadingGradeMap_AngelRing_TransClipping_Tess_StencilOut.shader
"01494e58d87212f44ab51d29caea84e4", //Assets/VketMallShaderPack/Toon/Shader/Tess/ToonColor_ShadingGradeMap_Tess.shader
"24c20b8ed5be113499b40f4e3b6b03e6", //Assets/VketMallShaderPack/Toon/Shader/Tess/ToonColor_ShadingGradeMap_Tess_StencilMask.shader
"9cf7e8eb46e9128438d50adf7a841de6", //Assets/VketMallShaderPack/Toon/Shader/Tess/ToonColor_ShadingGradeMap_Tess_StencilOut.shader
"3c39a77fda28b5043a7a17c7877cf7b2", //Assets/VketMallShaderPack/Toon/Shader/Tess/ToonColor_ShadingGradeMap_TransClipping_Tess.shader
"bf840a439c33c8b4a99d52e6c3d8511f", //Assets/VketMallShaderPack/Toon/Shader/Tess/ToonColor_ShadingGradeMap_TransClipping_Tess_StencilMask.shader
"8eff803eae89c994fae3acf2f686fafa", //Assets/VketMallShaderPack/Toon/Shader/Tess/ToonColor_ShadingGradeMap_TransClipping_Tess_StencilOut.shader
"0959cb8822a344c4da890457e668fdc9", //Assets/VketMallShaderPack/Toon/Shader/Tess/ToonColor_ShadingGradeMap_Transparent_Tess.shader
"6d115cf94d14d1842a56dfff76b57f42", //Assets/VketMallShaderPack/Toon/Shader/Tess/ToonColor_ShadingGradeMap_Transparent_Tess_StencilOut.shader
"f0b2fc9b8a189134da9c7d24f361caf4", //Assets/VketMallShaderPack/Toon/Shader/Tess/Toon_DoubleShadeWithFeather_Clipping_Tess.shader
"8c94ee3046ef0574f87f6b658b4e4691", //Assets/VketMallShaderPack/Toon/Shader/Tess/Toon_DoubleShadeWithFeather_Clipping_Tess_StencilMask.shader
"c4aed8662ca0f194284f3ab649e66d23", //Assets/VketMallShaderPack/Toon/Shader/Tess/Toon_DoubleShadeWithFeather_Clipping_Tess_StencilOut.shader
"1f248db3b28fc5f44aabd7aca618bd1e", //Assets/VketMallShaderPack/Toon/Shader/Tess/Toon_DoubleShadeWithFeather_Tess.shader
"a3214384442742648aa664ef0039d397", //Assets/VketMallShaderPack/Toon/Shader/Tess/Toon_DoubleShadeWithFeather_Tess_Light.shader
"3073cd2564e4cde45a19c05e0012d22a", //Assets/VketMallShaderPack/Toon/Shader/Tess/Toon_DoubleShadeWithFeather_Tess_Light_StencilMask.shader
"7e7690a767a07da4f943439680e70db8", //Assets/VketMallShaderPack/Toon/Shader/Tess/Toon_DoubleShadeWithFeather_Tess_Light_StencilOut.shader
"08c65988dc25d9f44b791fcc18fb543a", //Assets/VketMallShaderPack/Toon/Shader/Tess/Toon_DoubleShadeWithFeather_Tess_StencilMask.shader
"f937ea4ce96dfbe448afc0fb671198e5", //Assets/VketMallShaderPack/Toon/Shader/Tess/Toon_DoubleShadeWithFeather_Tess_StencilOut.shader
"3fb99ac3775edeb4aa9530db5a614c92", //Assets/VketMallShaderPack/Toon/Shader/Tess/Toon_DoubleShadeWithFeather_TransClipping_Tess.shader
"9855f226cd8152d4e99085272aceede6", //Assets/VketMallShaderPack/Toon/Shader/Tess/Toon_DoubleShadeWithFeather_TransClipping_Tess_StencilMask.shader
"2a0d4af863770404faee6488b86fe3c9", //Assets/VketMallShaderPack/Toon/Shader/Tess/Toon_DoubleShadeWithFeather_TransClipping_Tess_StencilOut.shader
"1847c44f729b68e49ba63610abdf9132", //Assets/VketMallShaderPack/Toon/Shader/Tess/Toon_OutlineObject_Tess.shader
"06cae78b869a3234bab02eeb52197e1c", //Assets/VketMallShaderPack/Toon/Shader/Tess/Toon_OutlineObject_Tess_StencilOut.shader
"3a1af221400a61a4b94bae19aa79da2b", //Assets/VketMallShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_AngelRing_Tess.shader
"a1449ab672051624ca3160737b630f5e", //Assets/VketMallShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_AngelRing_Tess_Light.shader
"79d3dc54c32b69b42be17c48d33575f2", //Assets/VketMallShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_AngelRing_Tess_Light_StencilOut.shader
"18c9172cdf36a344f9aca9bbc0e7002d", //Assets/VketMallShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_AngelRing_Tess_StencilOut.shader
"54a94f776a43a074c8c2d205bb934005", //Assets/VketMallShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_AngelRing_TransClipping_Tess.shader
"d496a1c70c797ad43836d5bfff575b5f", //Assets/VketMallShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_AngelRing_TransClipping_Tess_StencilOut.shader
"183ea557143786346b1bfc862ad22636", //Assets/VketMallShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_Tess.shader
"356dd5af8f0d40e41b647d3d0a0555c1", //Assets/VketMallShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_Tess_Light.shader
"ffadecfbd9e31f840ba4109fea0f0436", //Assets/VketMallShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_Tess_Light_StencilMask.shader
"98ac5d198a471494da681b7b8d1e1727", //Assets/VketMallShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_Tess_Light_StencilOut.shader
"0d799eb857c0e2c45bbdfb2c033d33e6", //Assets/VketMallShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_Tess_StencilMask.shader
"e667137c8b6fd3d4390fc364b2e5c70b", //Assets/VketMallShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_Tess_StencilOut.shader
"feba437d8ff93f745a78828529e9a272", //Assets/VketMallShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_TransClipping_Tess.shader
"8d1395a9f4bfad44d8fddd0f2af19b1e", //Assets/VketMallShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_TransClipping_Tess_StencilMask.shader
"08c6bb334aed21c4198cf46b71ebca2d", //Assets/VketMallShaderPack/Toon/Shader/Tess/Toon_ShadingGradeMap_TransClipping_Tess_StencilOut.shader
"6d04fc34e9717d34d9589f39decf8333", //Assets/VketMallShaderPack/Toon/Shader/Tess/UCTS_DoubleShadeWithFeather_tess.cginc
"c139664fde6401f45a09b0f32279484b", //Assets/VketMallShaderPack/Toon/Shader/Tess/UCTS_Outline_Tess.cginc
"ad7807131760d5544843d7424e535b75", //Assets/VketMallShaderPack/Toon/Shader/Tess/UCTS_ShadingGradeMap_tess.cginc
"6261ac20c5dfa024a98d6ce3921bab70", //Assets/VketMallShaderPack/Toon/Shader/Tess/UCTS_ShadowCaster_Tess.cginc
"13aee1e1f6c49d94fa292dca9910126e", //Assets/VketMallShaderPack/Toon/Shader/Tess/UCTS_Tess.cginc
"00999fd020bde754ab4ae5f8a5205844", //Assets/VketMallShaderPack/UniUnlit/LICENSE.md
"8c17b56f4bf084c47872edcb95237e4a", //Assets/VketMallShaderPack/UniUnlit/Resources/UniUnlit.shader
"b8bbbd51c2e41dd4bbcb0da1b7a48808", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/LICENSE
"4ebc920fe2745624bbed02e79a222e3d", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/README.txt
"f9bd228ff6fb34948a32cc6fd10d7d5b", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/version.json
"b71e250f3c9f9a54cac228148bc800f7", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Editor/WF_Common.cs
"6b1a45934e0846141979f322772dc3b8", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Editor/WF_DebugViewEditor.cs
"052a5a21704733543a9cbbf6369ca43c", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Editor/WF_Dictionary.cs
"3ca4c3d3a4488214db9818862a2eff69", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Editor/WF_MiscUtil.cs
"4f0275352c196ca4d864b6611897bfd7", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Editor/WF_ShaderCustomEditor.cs
"e3269783b9ab81e4f85d813345bc1a7e", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Editor/WF_ShaderToolWindow.cs
"16f6ecebfe3bedf48922ade8760ef404", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Editor/WF_VersionCheck.cs
"2a4dc116efeb0db4192f11f17d555b87", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Logo/README.txt
"c02ebf9b7a5d66c4ead5f94ef99b20c8", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Logo/UnlitWF繝ｭ繧ｴ_1024.png
"54ed4f64546b23741987a94ff9769567", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Logo/UnlitWF繝ｭ繧ｴ_256.png
"b8e19d3beb8c169458f9b150a00f40ec", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Logo/UnlitWF繝ｭ繧ｴ_512.png
"81bd216f29ecf2f46b29029ec01f55a3", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Matcaps/README.txt
"80b684ec03e5e1c40943d9eb0e0d32f4", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Matcaps/CubeMap/HDRIHaven_lythwood_room_1k_32.hdr
"55f94f02873c1bb4bb1f43eed973a999", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Matcaps/CubeMap/README.txt
"0c90f262b70f7634ea0fb53f2912f537", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Matcaps/Noise邏�譚�/noise_繝ｩ繝ｳ繝�繝�(邊�)_1024.png
"c7e5995223250464cac205689e058693", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_DebugView.shader
"c0f75d3ed420fd144a74722588d3bc21", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_Gem_Opaque.shader
"21f6eaa1dd1f25c4cb29a42c4ff5d98f", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_Gem_Transparent.shader
"4ba701b07ccc81e4aae7f053bf332eab", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Custom_GhostTransparent.shader
"f3f80636c64e389498b3b19e2ee218da", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Custom_LameOnly_Transparent.shader
"90cac9ec3b2a7524eb99b36ab87f25f1", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Custom_OffsetOutline_Opaque.shader
"871fd7a51a8ea3e4980c3fe7b8347619", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Custom_PowerCap_Outline_Opaque.shader
"58ccf9c912b226146a25726b8a1f04db", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Custom_Tess_PowerCap_Opaque.shader
"af51615040dcdad4cb01c29ea34dbb03", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Hidden.shader
"4bd76f6599a5b8e4d88d81300fb74c37", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Mobile_Opaque.shader
"d279a88eda1ae0e4c89e92539639eb16", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Mobile_OutlineOnly_Opaque.shader
"e0b93fdad2eeedf42baccbc0975cdd1d", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Mobile_OutlineOnly_TransCutout.shader
"af3422dc9372a89449a9f44d409d9714", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Mobile_TransCutout.shader
"0a7a6cdca16a38548a5d81aca8d4e3ba", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Mobile_Transparent.shader
"4e4be4aab63a2bd4fbcea2390ae92fdf", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Mobile_TransparentOverlay.shader
"a3678756e883b9349ac22fce33313139", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Opaque.shader
"4eef00f52cc21b04e9e34e4caefa6bbf", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_OutlineOnly_Opaque.shader
"64bf3ca653a7b274fab3e8a87016bfb0", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_OutlineOnly_TransCutout.shader
"660abd485057f4740ac9050f7ab3237d", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_OutlineOnly_Transparent.shader
"3c07b964e541eef45bc195a029b878b3", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_OutlineOnly_Transparent_MaskOut.shader
"a5ae7f40ac53e274ea0bc1262e1f6895", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Outline_Opaque.shader
"ab4eb87c406a22f46887cf72178e2685", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Outline_TransCutout.shader
"5523e041d29d259439fa14bd131f5c82", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Outline_Transparent.shader
"5498b01615002d948bea7542f55e0c07", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Outline_Transparent3Pass.shader
"9350854c6e88f3f4eb873d2f94ff3328", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Outline_Transparent_MaskOut.shader
"ad88000744b4fb241835ba6ec106caf4", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Outline_Transparent_MaskOut_Blend.shader
"0733cfc88032e8d4eafce250263c497c", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_PowerCap_Opaque.shader
"2cf66b0706c40744baab089297afa895", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_PowerCap_TransCutout.shader
"747bf283d686334469fb662b2fc4a5c2", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_PowerCap_Transparent.shader
"d242cb83664caae4f957030870dd801d", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_PowerCap_Transparent3Pass.shader
"dd3a683002b3a6f43bdb6c97bd0985c1", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Tess_Opaque.shader
"94ee7f8988740fd4887f8b1ce41f0c1c", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Tess_TransCutout.shader
"3bde56820d1aece41bd22966876a061c", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Tess_Transparent.shader
"78d2e3fa0b8eb674aa9cf9e048f79c93", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Tess_Transparent3Pass.shader
"8c7888a4ac175584f81e0b6e7d4af5a7", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_TransCutout.shader
"15212414cba0c7a4aac92d94a4ae8750", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Transparent.shader
"d1e7b0a18e221a1409ad59065ec157e4", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Transparent3Pass.shader
"2efe527cfcbf0e1408b67463225f552f", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Transparent_Mask.shader
"0b53cf0bcd0f9db4fa9d1297d255d06d", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Transparent_MaskOut.shader
"d01a5c313ada49e488b2ef8c6b00f56d", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_Transparent_MaskOut_Blend.shader
"a220e3e0675cc3f4f817a485688788d6", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_TriShade_Opaque.shader
"2d294f328149d944eb0899b452ff879c", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_TriShade_TransCutout.shader
"1435581bcf13e7a47b5bf5636f8d8252", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_TriShade_Transparent.shader
"e7263331a8ee0a04aa4a271fc1fef104", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_TriShade_Transparent3Pass.shader
"0299954f2a9b0994f8c9587945948766", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_TriShade_Transparent_Mask.shader
"06e9294a93df4474cac2f4157b5e1d1d", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_TriShade_Transparent_MaskOut.shader
"dfb821bc7afadc14591e4338a8ec865f", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/Unlit_WF_UnToon_TriShade_Transparent_MaskOut_Blend.shader
"0380b1621ab524c43aeb10eba3346ea6", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_Common.cginc
"578346e318940304389ae3dda992ac86", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_Common_BuiltinRP.cginc
"2762fae01792d2745ad5d02376392d52", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_Common_LightweightRP.cginc
"ef1a901a2feeb0a45859ecc184e2e3e2", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_FakeFur.cginc
"b892a7ae3359eb0428b2f8aebf24d314", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_FakeFur_Uniform.cginc
"45af0d16a1af0a947b445e08dd6dead4", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_Gem.cginc
"34a1cdb7cd82cd045a521aa2db90ba27", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_Gem_Uniform.cginc
"77ee5292cc4f46649a13611c8d76c85b", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_INPUT_FakeFur.cginc
"e33666b113c868d41bfa058f5bc50d9c", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_INPUT_Gem.cginc
"be668f2e5a5e4ef46838001f79babcef", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_INPUT_UnToon.cginc
"22546fe6fb0bed84e8db3fc80b0b2302", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_UnToon.cginc
"93e68367384c3bd42a3a37868cc25554", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_UnToon_DepthOnly.cginc
"8e439fa11883d4b429904a7fc398851e", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_UnToon_Function.cginc
"afa8b2842288b044b9cdccd7508670a7", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_UnToon_LineCanceller.cginc
"074195645f64a224d9482cb666563c89", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_UnToon_Meta.cginc
"bf91baf439ae72542bd718eb51378f5a", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_UnToon_PowerCap.cginc
"ad9922cd501663b4cbfbef594d1b22d0", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_UnToon_ShadowCaster.cginc
"95ae3c73098e55148862b3125c46785e", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_UnToon_Tessellation.cginc
"bad784f674c77404f8234c8d284656d2", //Assets/VketMallShaderPack/Unlit_WF_ShaderSuite/Shaders/WF_UnToon_Uniform.cginc

"ebc8de035ba5d6c419b38c68f06d18b8", //Assets/VketAssets/VketPrefabs/LICENSE.txt
"8ac885989b081be499135bd5e73437ce", //Assets/VketAssets/VketPrefabs/version.txt
"9ade6bede296164498060af8ff1eb032", //Assets/VketAssets/VketPrefabs/AudioVolumeSample/vket6_booth_samplemusic_-14lufs_-3db.ogg
"eb66d914c41e316449694dde067708f6", //Assets/VketAssets/VketPrefabs/PrefabAssets/Scripts/VketMallUdonControl.cs
"6893d5acfbed8d544856d8eb7cc11133", //Assets/VketAssets/VketPrefabs/VketPickup/AnimationOverrideEmpty.overrideController
"ba410268b82f1d940aedd0d418541c83", //Assets/VketAssets/VketPrefabs/VketPickup/VketFollowPickup.prefab
"6d1e9170d4533ed448e46b707a3ee47a", //Assets/VketAssets/VketPrefabs/VketPickup/VketPickup.prefab
"3ffeb968a1d1ed244b45c026bb22f30b", //Assets/VketAssets/VketPrefabs/VketPickup/Animations/ModeController.controller
"be21e07eff32d7e4fbbf7babfed27d88", //Assets/VketAssets/VketPrefabs/VketPickup/Animations/PickupAnimation.fbx
"ab981b08fcfada8458fc2ec950e16e17", //Assets/VketAssets/VketPrefabs/VketPickup/Scripts/VketFollowPickup.asset
"57498a849a57d5e44bb3fea02cfabbad", //Assets/VketAssets/VketPrefabs/VketPickup/Scripts/VketFollowPickup.cs
"fc11049e6474c5e47bc42f47d1a8efca", //Assets/VketAssets/VketPrefabs/VketPickup/Scripts/VketPickup.asset
"b5d9b5598ab43f64e8aca7422be14f5c", //Assets/VketAssets/VketPrefabs/VketPickup/Scripts/VketPickup.cs
"f29d54e013551c04c907cfe68520b996", //Assets/VketAssets/VketPrefabs/ItemTeleportMarker/ItemTeleportMarker.prefab
"d518776ec98e79640b97fbd20f474b05", //Assets/VketAssets/VketPrefabs/ItemTeleportMarker/Scripts/ItemTeleportMarker.cs


                #endregion
            };
            guids.AddRange(addGuids);
            return guids.ToArray();
        }

        public override Dictionary<string, string> GetAllowedShaders()
        {
            return new Dictionary<string, string>()
            {
             {"MMS3/Mnmrshader3","8dd7c14dadb834c4e8324f7d08c5674e"},
{"MMS3/Mnmrshader3_Cutout","128f4720891e8914ab7e6673099df0f0"},
{"MMS3/Mnmrshader3_Outline","fbaec084851cef64fbd877b3b15716cb"},
{"MMS3/Stencil/MMS3_Reader ","f889d00a055a0488e9ecbf22c558ae76"},
{"MMS3/Stencil/MMS3_Writer","f55508f2ed8cc477f9574099971bc4eb"},
{"MMS3/Mnmrshader3_Transparent","fda424b70f79d4e5488e1cc3ee100a95"},
{"VRM/MToon","1a97144e4ad27a04aafd70f7b915cedb"},
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