using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.NonGUIFeature
{
	// Token: 0x02000446 RID: 1094
	[global::System.Serializable]
	public class NonGUISection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06009392 RID: 37778 RVA: 0x008AE9D4 File Offset: 0x008ACBD4
		public NonGUISection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06009393 RID: 37779 RVA: 0x008AE9F0 File Offset: 0x008ACBF0
		protected NonGUISection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06009394 RID: 37780 RVA: 0x008AEA08 File Offset: 0x008ACC08
		public override void Init()
		{
			int a_ = 4;
			short num = (short)1800208385;
			if (num != 0)
			{
			}
			num = (short)1751646208;
			short num2 = num;
			num = (short)605600792;
			short num3 = num;
			num = (short)258915352;
			switch (num3 == num)
			{
			}
			num = (short)1816264704;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("评꣆ꟈ諌髎飐蛔닖뫘꿚드냞迠", a_);
			base.Id = 0;
			base.UIName = global::CommonResources.AcgResources.ID_NONGUISECTION;
			base.DataTransferOrder = 2147483646;
		}

		// Token: 0x06009395 RID: 37781 RVA: 0x008AEAEC File Offset: 0x008ACCEC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 13;
			short num = (short)957218816;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1189281793;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				case 1:
				{
					num = (short)213843968;
					short num3 = num;
					goto IL_BF;
				}
				case 2:
					goto IL_81;
				}
				IL_62:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)476905474;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_BF;
				IL_81:
				num = (short)584187905;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_BF:
				num = (short)566582029;
				short num4 = num;
				num = (short)121854733;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_81;
				default:
					goto IL_F4;
				}
			}
			IL_F4:
			num = (short)1719468032;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胍뿏병陸釕跗鏙ﳛ距藟臡郣迥蟧蓩", a_);
			base.Id = 0;
			base.UIName = global::CommonResources.AcgResources.ID_NONGUISECTION;
			base.DataTransferOrder = 2147483646;
		}

		// Token: 0x06009396 RID: 37782 RVA: 0x008AEC34 File Offset: 0x008ACE34
		public override void PopulateReferences()
		{
			short num = (short)1121910785;
			if (num != 0)
			{
			}
			num = (short)1593966592;
			short num2 = num;
			num = (short)1053398711;
			short num3 = num;
			num = (short)867604151;
			switch (num3 == num)
			{
			}
			num = (short)257884160;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009397 RID: 37783 RVA: 0x008AECE0 File Offset: 0x008ACEE0
		public override void DropReferences()
		{
			short num = (short)733068841;
			short num2 = num;
			num = (short)1872477737;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1375010816;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1742798849;
			if (num != 0)
			{
			}
			num = (short)2139947008;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009398 RID: 37784 RVA: 0x008AED8C File Offset: 0x008ACF8C
		public override void SetConstraints()
		{
			short num = (short)1397524248;
			short num2 = num;
			num = (short)1550223128;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2141061120;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1029963777;
			if (num != 0)
			{
			}
			num = (short)1186267136;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009399 RID: 37785 RVA: 0x008AEE34 File Offset: 0x008AD034
		public override void SetupDependencies()
		{
			short num = (short)742579069;
			short num2 = num;
			num = (short)2001853309;
			switch (num2 == num)
			{
			default:
			{
				num = (short)42795008;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1382154241;
			if (num != 0)
			{
			}
			num = (short)1516240896;
			if (num != 0)
			{
			}
		}

		// Token: 0x17004A66 RID: 19046
		// (get) Token: 0x0600939A RID: 37786 RVA: 0x008AEEE0 File Offset: 0x008AD0E0
		public bool HasDiffs
		{
			get
			{
				short num = (short)772112131;
				short num2 = num;
				num = (short)453869315;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1918500864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2006908929;
				if (num != 0)
				{
				}
				num = (short)537919488;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600939B RID: 37787 RVA: 0x008AEF90 File Offset: 0x008AD190
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			int num;
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)721794017;
						short num3 = num2;
						num2 = (short)1040757729;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_26;
						default:
							num2 = (short)1935933440;
							if (num2 != 0)
							{
							}
							num2 = (short)962920451;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						if (base.ParentRecset != null)
						{
							num2 = (short)1049821184;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 2:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)1224671236;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						num2 = (short)1600847873;
						if (num2 != 0)
						{
						}
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)212664322;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 4:
						goto IL_82;
					}
					goto IL_24;
				}
				IL_82:
				num2 = (short)960888832;
				short num4 = num2;
				return result;
			}
			}
			IL_24:
			result = null;
			IL_26:
			num2 = (short)1652752385;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
