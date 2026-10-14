using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Keypad
{
	// Token: 0x020002FF RID: 767
	[global::System.Serializable]
	public class Keypad : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x06007AB3 RID: 31411 RVA: 0x006FD924 File Offset: 0x006FBB24
		public Keypad(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 8;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("苈껊듌뿎냐럒", a_);
			base.UIName = global::CommonResources.AcgResources.ID_KEYPAD;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("裈ꟊꇌ觎듐닒ꇔꋖꯘ뻚껜ꋠ賢裤韦蛨藪裬臮藰꿲ꟴ零鷸鋺鋼\udffe䐀焂戄栆月搊怌明爐怒㔔吖瘘甚笜瘞䘠嘢圤䘦崨䈪䈬䄮洰瀲娴夶䴸䤺刼匾㉀ὂไ≆え㭊ⱌ⭎൐ᡒご⹖⥘㩚㥜煞ᥠɢࡤ୦", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.Keypad.General(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x06007AB4 RID: 31412 RVA: 0x006FD990 File Offset: 0x006FBB90
		protected Keypad(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 19;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("鿓돕ꇗ꫙뷛뫝", a_);
			base.UIName = global::CommonResources.AcgResources.ID_KEYPAD;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("闓뫕듗鳙맛뿝铟韡難菥鯧퇩꿫臭鷯英鯳飵鷷铹裻ꋽ勿持怃漅朇⨉䤋簍眏紑稓礕甗猙缛洝\u001f愡䬣䠥丧䌩䬫嬭䈯匱䀳張圷吹总紽⼿ⱁぃ㑅❇♉㽋ቍ᭏㝑ⵓ♕㥗㹙[ᕝ՟᭡ᑣݥ౧䑩ᑫ཭ᵯṱ", a_);
		}

		// Token: 0x17003F02 RID: 16130
		// (get) Token: 0x06007AB5 RID: 31413 RVA: 0x006FD9E4 File Offset: 0x006FBBE4
		public global::Motorola.MackinawCPS.CoreFeatures.Keypad.General General
		{
			get
			{
				short num = (short)1002591739;
				short num2 = num;
				num = (short)221402619;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1160708096;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1557659649;
				if (num != 0)
				{
				}
				num = (short)1989148672;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.Keypad.General)base[10710];
			}
		}

		// Token: 0x06007AB6 RID: 31414 RVA: 0x006FDA9C File Offset: 0x006FBC9C
		public static global::AcpCommonLib.IAcpFeatureNode GetKeypad()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::AcpCommonLib.IAcpFeatureNode result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					IL_52:
					result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4109)[0];
					num2 = (short)1946091521;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)1864302593;
					if (num2 != 0)
					{
					}
					goto IL_FA;
				case 2:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)1350828032;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::AcpCommonLib.FeatureManager.GetFeature(4109)[0];
					num2 = (short)152240131;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					num2 = (short)390529024;
					short num3 = num2;
					goto IL_FA;
				}
				}
				goto IL_20;
				IL_FA:
				num2 = (short)1356962714;
				short num4 = num2;
				num2 = (short)1506778010;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_52;
				default:
					goto IL_131;
				}
			}
			IL_131:
			num2 = (short)2021785600;
			if (num2 != 0)
			{
			}
			return result;
			IL_20:
			result = null;
			num2 = (short)570359810;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
