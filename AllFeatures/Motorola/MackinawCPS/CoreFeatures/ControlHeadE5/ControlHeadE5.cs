using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadE5
{
	// Token: 0x020003FD RID: 1021
	[global::System.Serializable]
	public class ControlHeadE5 : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x06008DBD RID: 36285 RVA: 0x0084D1A0 File Offset: 0x0084B3A0
		public ControlHeadE5(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 7;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("诇ꗉꋋ뫍ꋏ뷑룓郗뿙뷛뫝샟쿡쓣ꏥ\udde7", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONTROLHEADE5;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("觇ꛉꃋ裍뗏돑ꃓꏕ꫗뿙꿛ꏟ跡解雥蟧蓩觫胭蓯껱꛳韵鳷鏹鏻\udefd䗿瀁挃椅昇攉愋服猏愑㐓唕眗琙稛眝䜟圡嘣䜥尧䌩䌫䀭氯焱嬳堵䰷䠹医刽㌿ṁ݃⥅♇㹉㹋⅍㱏牑᱓㍕㥗㹙籛獝䁟❡兣㩥⭧թɫᩭɯᵱᡳ㹵ᵷ᭹᡻㭽땿겁ﲃ", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5GeneralExpander(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsExpander(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonExpander(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x06008DBE RID: 36286 RVA: 0x0084D224 File Offset: 0x0084B424
		protected ControlHeadE5(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 1;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("臁ꯃꣅ볇룉ꏋꋍ髑뇓럕볗龎ﻝꗟퟡ", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONTROLHEADE5;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("菁ꣃ꫅軇꿉귋뫍ꗏꃑ뇓ꗕ駙돛돝郟跡諣菥蛧黩냫볭釯雱鷳駵\ud8f7뿹軻駽濿氁欃欅愇椉缋⸍匏紑稓瀕焗紙椛氝䄟嘡䴣䤥䘧瘩漫䄭帯䘱䘳夵吷䤹总紽⼿ⱁぃ㑅❇♉汋ٍ㕏㍑こ癕畗穙ᥛ歝㱟Ⅱୣࡥᱧᡩͫɭ㡯᝱ᕳት㵷佹剻ٽ", a_);
		}

		// Token: 0x170047A3 RID: 18339
		// (get) Token: 0x06008DBF RID: 36287 RVA: 0x0084D278 File Offset: 0x0084B478
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5GeneralExpander E5GeneralExpander
		{
			get
			{
				short num = (short)746455040;
				short num2 = num;
				num = (short)862185693;
				short num3 = num;
				num = (short)1317333213;
				switch (num3 == num)
				{
				}
				num = (short)1286537217;
				if (num != 0)
				{
				}
				num = (short)196476928;
				if (num != 0)
				{
				}
				return base[10902] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5GeneralExpander;
			}
		}

		// Token: 0x170047A4 RID: 18340
		// (get) Token: 0x06008DC0 RID: 36288 RVA: 0x0084D330 File Offset: 0x0084B530
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonExpander E5BottomFunctionButtonExpander
		{
			get
			{
				short num = (short)1599340544;
				short num2 = num;
				num = (short)609653124;
				short num3 = num;
				num = (short)310153604;
				switch (num3 == num)
				{
				}
				num = (short)704315393;
				if (num != 0)
				{
				}
				num = (short)902692864;
				if (num != 0)
				{
				}
				return base[10903] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonExpander;
			}
		}

		// Token: 0x170047A5 RID: 18341
		// (get) Token: 0x06008DC1 RID: 36289 RVA: 0x0084D3E8 File Offset: 0x0084B5E8
		public global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsExpander E5NavigationControlsExpander
		{
			get
			{
				short num = (short)616562688;
				short num2 = num;
				num = (short)1812900030;
				short num3 = num;
				num = (short)1402972350;
				switch (num3 == num)
				{
				}
				num = (short)1162543105;
				if (num != 0)
				{
				}
				num = (short)514064384;
				if (num != 0)
				{
				}
				return base[10896] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsExpander;
			}
		}
	}
}
