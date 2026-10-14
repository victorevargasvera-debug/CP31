using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x0200036D RID: 877
	[global::System.Serializable]
	public class ControlHeadO9 : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x06008255 RID: 33365 RVA: 0x00796F34 File Offset: 0x00795134
		public ControlHeadO9(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 0;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("苀곂ꯄ돆믈꓊ꇌ駐뛒듔돖律﷜郞\ud8e0", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONTROLHEADO9;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("胀꿂꧄臆곈꫊만뫎ꏐ뛒ꛔ高듚냜꿞軠跢胤触鷨럪뿬軮闰髲髴ퟶ본觺髼郾漀氂栄渆樈砊ⴌ䰎縐紒猔縖縘渚漜縞唠䨢䨤䤦用株䈬䄮䔰䄲娴嬶䨸机縼倾⽀㝂㝄⡆╈歊Ռ⩎ぐ㝒畔穖祘ᑚ摜͞≠ౢ୤፦᭨ѪŬ❮ᑰቲᅴ㡶䁸啺ռṾ", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.General(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Data(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButton(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButton(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelector(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtons(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtons(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOList(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOList(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsExpander(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.Labtool(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x06008256 RID: 33366 RVA: 0x00797018 File Offset: 0x00795218
		protected ControlHeadO9(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 19;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("韓맕뛗껙껛뇝賟싡곣菥觧軩쳫쏭탯뷱췳", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONTROLHEADO9;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("闓뫕듗鳙맛뿝铟韡難菥鯧퇩꿫臭鷯英鯳飵鷷铹裻ꋽ勿持怃漅朇⨉䤋簍眏紑稓礕甗猙缛洝\u001f愡䬣䠥丧䌩䬫嬭䈯匱䀳張圷吹总紽⼿ⱁぃ㑅❇♉㽋ቍፏ㵑㩓≕⩗㕙せ繝⡟ݡգɥ䡧䝩䱫Ⅽ䥯⹱㝳᥵ᙷ๹๻ᅽ쪁얉떋ꂍ煉歹", a_);
		}

		// Token: 0x17004266 RID: 16998
		// (get) Token: 0x06008257 RID: 33367 RVA: 0x0079706C File Offset: 0x0079526C
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.General General
		{
			get
			{
				short num = (short)729808896;
				short num2 = num;
				num = (short)1862000018;
				short num3 = num;
				num = (short)662756754;
				switch (num3 == num)
				{
				}
				num = (short)1194524673;
				if (num != 0)
				{
				}
				num = (short)1355808768;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.General)base[10626];
			}
		}

		// Token: 0x17004267 RID: 16999
		// (get) Token: 0x06008258 RID: 33368 RVA: 0x00797128 File Offset: 0x00795328
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Data ControlHeadO9Data
		{
			get
			{
				short num = (short)1060700160;
				short num2 = num;
				num = (short)513820477;
				short num3 = num;
				num = (short)522864445;
				switch (num3 == num)
				{
				}
				num = (short)1739784193;
				if (num != 0)
				{
				}
				num = (short)1825832960;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Data)base[10611];
			}
		}

		// Token: 0x17004268 RID: 17000
		// (get) Token: 0x06008259 RID: 33369 RVA: 0x007971E4 File Offset: 0x007953E4
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButton TopFunctionProgrammableButton
		{
			get
			{
				short num = (short)845152256;
				short num2 = num;
				num = (short)406824997;
				short num3 = num;
				num = (short)494381093;
				switch (num3 == num)
				{
				}
				num = (short)282722305;
				if (num != 0)
				{
				}
				num = (short)1638400000;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButton)base[10616];
			}
		}

		// Token: 0x17004269 RID: 17001
		// (get) Token: 0x0600825A RID: 33370 RVA: 0x0079729C File Offset: 0x0079549C
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButton BottomFunctionProgrammableButton
		{
			get
			{
				short num = (short)1702887424;
				short num2 = num;
				num = (short)203221835;
				short num3 = num;
				num = (short)1915743051;
				switch (num3 == num)
				{
				}
				num = (short)891355137;
				if (num != 0)
				{
				}
				num = (short)913309696;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButton)base[10618];
			}
		}

		// Token: 0x1700426A RID: 17002
		// (get) Token: 0x0600825B RID: 33371 RVA: 0x00797358 File Offset: 0x00795558
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelector ResponseSelector
		{
			get
			{
				short num = (short)431292416;
				short num2 = num;
				num = (short)2019957134;
				short num3 = num;
				num = (short)16718222;
				switch (num3 == num)
				{
				}
				num = (short)985595904;
				if (num != 0)
				{
				}
				num = (short)1250361345;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ResponseSelector)base[10624];
			}
		}

		// Token: 0x1700426B RID: 17003
		// (get) Token: 0x0600825C RID: 33372 RVA: 0x00797414 File Offset: 0x00795614
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtons DirectionalButtons
		{
			get
			{
				short num = (short)2110521344;
				short num2 = num;
				num = (short)22532089;
				short num3 = num;
				num = (short)245813241;
				switch (num3 == num)
				{
				}
				num = (short)853344257;
				if (num != 0)
				{
				}
				num = (short)346161152;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtons)base[10609];
			}
		}

		// Token: 0x1700426C RID: 17004
		// (get) Token: 0x0600825D RID: 33373 RVA: 0x007974CC File Offset: 0x007956CC
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtons PASirenButtons
		{
			get
			{
				short num = (short)987234304;
				short num2 = num;
				num = (short)1866166830;
				short num3 = num;
				num = (short)92697134;
				switch (num3 == num)
				{
				}
				num = (short)1133707264;
				if (num != 0)
				{
				}
				num = (short)2111242241;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.PASirenButtons)base[10743];
			}
		}

		// Token: 0x1700426D RID: 17005
		// (get) Token: 0x0600825E RID: 33374 RVA: 0x00797588 File Offset: 0x00795788
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOList RelayPatternBCOList
		{
			get
			{
				short num = (short)1476329472;
				short num2 = num;
				num = (short)1601859415;
				short num3 = num;
				num = (short)2064150359;
				switch (num3 == num)
				{
				}
				num = (short)462159873;
				if (num != 0)
				{
				}
				num = (short)291831808;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOList)base[10620];
			}
		}

		// Token: 0x1700426E RID: 17006
		// (get) Token: 0x0600825F RID: 33375 RVA: 0x00797644 File Offset: 0x00795844
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOList ConsolidatedActionBCOList
		{
			get
			{
				short num = (short)1149566976;
				short num2 = num;
				num = (short)373620737;
				if (num != 0)
				{
				}
				num = (short)182103367;
				short num3 = num;
				num = (short)479898951;
				switch (num3 == num)
				{
				}
				num = (short)1155989504;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOList)base[10622];
			}
		}

		// Token: 0x1700426F RID: 17007
		// (get) Token: 0x06008260 RID: 33376 RVA: 0x00797700 File Offset: 0x00795900
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsExpander O9NavigationControlsExpander
		{
			get
			{
				short num = (short)1473380352;
				short num2 = num;
				num = (short)1465751120;
				short num3 = num;
				num = (short)1226937936;
				switch (num3 == num)
				{
				}
				num = (short)249626624;
				if (num != 0)
				{
				}
				num = (short)1262223361;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9NavigationControlsExpander)base[10731];
			}
		}

		// Token: 0x17004270 RID: 17008
		// (get) Token: 0x06008261 RID: 33377 RVA: 0x007977B8 File Offset: 0x007959B8
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.Labtool Labtool
		{
			get
			{
				short num = (short)1678180352;
				short num2 = num;
				num = (short)143936626;
				short num3 = num;
				num = (short)2033339506;
				switch (num3 == num)
				{
				}
				num = (short)1398669312;
				if (num != 0)
				{
				}
				num = (short)1599995905;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.Labtool)base[10628];
			}
		}

		// Token: 0x06008262 RID: 33378 RVA: 0x00797870 File Offset: 0x00795A70
		public static global::AcpCommonLib.IAcpFeatureNode GetControlHeadO9()
		{
			short num = (short)904372636;
			short num2 = num;
			num = (short)704160156;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_B0:
				num = (short)1514340355;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
			{
				num = (short)173539328;
				short num4 = num;
				num = (short)1041235968;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_92;
				}
				break;
			}
			}
			global::AcpCommonLib.IAcpFeatureNode result;
			for (;;)
			{
				IL_7C:
				switch (num3)
				{
				case 0:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						goto IL_B0;
					}
					result = global::AcpCommonLib.FeatureManager.GetFeature(4003)[0];
					num = (short)446234625;
					if (num != 0)
					{
					}
					num = (short)708444162;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return result;
				case 2:
					return result;
				case 3:
					result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4003)[0];
					num = (short)1153105921;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_92;
			}
			return result;
			IL_92:
			result = null;
			num = (short)660275200;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_7C;
		}
	}
}
