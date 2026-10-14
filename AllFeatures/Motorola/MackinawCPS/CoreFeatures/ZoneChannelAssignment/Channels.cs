using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment
{
	// Token: 0x0200003A RID: 58
	[global::System.Serializable]
	public class Channels : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06000194 RID: 404 RVA: 0x0001CA3C File Offset: 0x0001AC3C
		public Channels(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0001CA7C File Offset: 0x0001AC7C
		protected Channels(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0001CA94 File Offset: 0x0001AC94
		public override void Init()
		{
			int a_ = 3;
			short num = (short)1242406733;
			short num2 = num;
			num = (short)923508557;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1054801920;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2072772609;
			if (num != 0)
			{
			}
			num = (short)924975104;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蟃껅꧇꓉ꋋꯍ볏ꇑ", a_);
			base.Id = 10114;
			base.UIName = global::CommonResources.AcgResources.ID_CHANNELS;
			base.DataTransferOrder = 3;
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0001CB7C File Offset: 0x0001AD7C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 19;
			short num = (short)194818316;
			short num2 = num;
			num = (short)949334284;
			switch (num2 == num)
			{
			default:
			{
				num = (short)861208576;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)475594752;
			if (num != 0)
			{
			}
			num = (short)554106881;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("韓뻕맗듙닛믝賟釡", a_);
			base.Id = 10114;
			base.UIName = global::CommonResources.AcgResources.ID_CHANNELS;
			base.DataTransferOrder = 3;
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0001CC60 File Offset: 0x0001AE60
		public override void PopulateReferences()
		{
			short num = (short)1298469395;
			short num2 = num;
			num = (short)1942426131;
			switch (num2 == num)
			{
			default:
			{
				num = (short)142737408;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1678966785;
			if (num != 0)
			{
			}
			num = (short)1002831872;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0001CD08 File Offset: 0x0001AF08
		public override void DropReferences()
		{
			short num = (short)1920125458;
			short num2 = num;
			num = (short)564644370;
			switch (num2 == num)
			{
			default:
			{
				num = (short)874577920;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1388969985;
			if (num != 0)
			{
			}
			num = (short)626065408;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0001CDB0 File Offset: 0x0001AFB0
		public override void SetConstraints()
		{
			short num = (short)2120575568;
			short num2 = num;
			num = (short)2130733648;
			switch (num2 == num)
			{
			default:
			{
				num = (short)774569984;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2116026369;
			if (num != 0)
			{
			}
			num = (short)76808192;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0001CE5C File Offset: 0x0001B05C
		public override void SetupDependencies()
		{
			short num = (short)870096258;
			short num2 = num;
			num = (short)1034919298;
			switch (num2 == num)
			{
			default:
			{
				num = (short)988086272;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1609170945;
			if (num != 0)
			{
			}
			num = (short)956170240;
			if (num != 0)
			{
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600019C RID: 412 RVA: 0x0001CF04 File Offset: 0x0001B104
		public bool HasDiffs
		{
			get
			{
				short num = (short)2007211148;
				short num2 = num;
				num = (short)446667916;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1966931968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)521207808;
				if (num != 0)
				{
				}
				num = (short)1003290625;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0001CFB8 File Offset: 0x0001B1B8
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)602144769;
					if (num2 != 0)
					{
					}
					num2 = (short)1590558721;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)800063492;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					if (base.ParentRecset != null)
					{
						num2 = (short)1598160896;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					goto IL_FC;
				case 4:
				{
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1235474101;
					short num3 = num2;
					num2 = (short)1820841653;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)523108352;
						if (num2 != 0)
						{
						}
						num2 = (short)1832648707;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_24;
			}
			IL_FC:
			num2 = (short)439418880;
			short num4 = num2;
			return result;
			IL_24:
			result = null;
			num2 = (short)944701442;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400008B RID: 139
		private global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInnerRecset innerRecset;
	}
}
