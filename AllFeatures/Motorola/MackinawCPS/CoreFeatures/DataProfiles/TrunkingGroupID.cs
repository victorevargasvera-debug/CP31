using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DataProfiles
{
	// Token: 0x02000513 RID: 1299
	[global::System.Serializable]
	public class TrunkingGroupID : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600B0E4 RID: 45284 RVA: 0x00A40BD8 File Offset: 0x00A3EDD8
		public TrunkingGroupID(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x0600B0E5 RID: 45285 RVA: 0x00A40C18 File Offset: 0x00A3EE18
		protected TrunkingGroupID(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600B0E6 RID: 45286 RVA: 0x00A40C30 File Offset: 0x00A3EE30
		public override void Init()
		{
			int a_ = 8;
			short num = (short)358895931;
			short num2 = num;
			num = (short)1367167291;
			switch (num2 == num)
			{
			default:
			{
				num = (short)835977216;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)808779776;
			if (num != 0)
			{
			}
			num = (short)115736577;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鷈맊료ꇎ뫐뫒믔냖律鳚꿜냞铠鏢엤껦귨", a_);
			base.Id = 10505;
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGGROUPID;
			base.DataTransferOrder = 6;
		}

		// Token: 0x0600B0E7 RID: 45287 RVA: 0x00A40D14 File Offset: 0x00A3EF14
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 19;
			short num = (short)1257373559;
			short num2 = num;
			num = (short)103350135;
			switch (num2 == num)
			{
			default:
			{
				num = (short)91947008;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1271857153;
			if (num != 0)
			{
			}
			num = (short)729612288;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胓ꓕ귗듙럛럝軟藡쓣ꇥ髧藩駫黭탯믱냳", a_);
			base.Id = 10505;
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGGROUPID;
			base.DataTransferOrder = 6;
		}

		// Token: 0x0600B0E8 RID: 45288 RVA: 0x00A40DF8 File Offset: 0x00A3EFF8
		public override void PopulateReferences()
		{
			short num = (short)1980983977;
			short num2 = num;
			num = (short)988048041;
			switch (num2 == num)
			{
			default:
			{
				num = (short)301400064;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1496580096;
			if (num != 0)
			{
			}
			num = (short)867500033;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600B0E9 RID: 45289 RVA: 0x00A40EA0 File Offset: 0x00A3F0A0
		public override void DropReferences()
		{
			short num = (short)1742324918;
			short num2 = num;
			num = (short)81249462;
			switch (num2 == num)
			{
			default:
			{
				num = (short)591134720;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)537657345;
			if (num != 0)
			{
			}
			num = (short)1029439488;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600B0EA RID: 45290 RVA: 0x00A40F48 File Offset: 0x00A3F148
		public override void SetConstraints()
		{
			short num = (short)1752860097;
			short num2 = num;
			num = (short)833390017;
			switch (num2 == num)
			{
			default:
			{
				num = (short)788463616;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1006436353;
			if (num != 0)
			{
			}
			num = (short)1286209536;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600B0EB RID: 45291 RVA: 0x00A40FF0 File Offset: 0x00A3F1F0
		public override void SetupDependencies()
		{
			short num = (short)921665189;
			short num2 = num;
			num = (short)100302501;
			switch (num2 == num)
			{
			default:
			{
				num = (short)8978432;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)60686337;
			if (num != 0)
			{
			}
			num = (short)1564409856;
			if (num != 0)
			{
			}
		}

		// Token: 0x170058DC RID: 22748
		// (get) Token: 0x0600B0EC RID: 45292 RVA: 0x00A41098 File Offset: 0x00A3F298
		public bool HasDiffs
		{
			get
			{
				short num = (short)1514434639;
				short num2 = num;
				num = (short)23031887;
				switch (num2 == num)
				{
				default:
				{
					num = (short)55967744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1680932864;
				if (num != 0)
				{
				}
				num = (short)1913126913;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600B0ED RID: 45293 RVA: 0x00A41148 File Offset: 0x00A3F348
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)1640400807;
			short num2 = num;
			num = (short)1211926439;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_CC:
				num = (short)2090074113;
				if (num != 0)
				{
				}
				num = (short)853344258;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
			{
				num = (short)1464270848;
				short num4 = num;
				num = (short)382533632;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_97;
				}
				break;
			}
			}
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_7D:
				switch (num3)
				{
				case 0:
					goto IL_CC;
				case 1:
					if (base.ParentRecset != null)
					{
						num = (short)1330970624;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)1253113860;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 3:
					return result;
				case 4:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)165609475;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_97;
			}
			return result;
			IL_97:
			result = null;
			num = (short)973799425;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_7D;
		}

		// Token: 0x040053F1 RID: 21489
		private global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInnerRecset innerRecset;
	}
}
