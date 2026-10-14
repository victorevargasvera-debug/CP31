using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories
{
	// Token: 0x02000316 RID: 790
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06007C10 RID: 31760 RVA: 0x0071B890 File Offset: 0x00719A90
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06007C11 RID: 31761 RVA: 0x0071B8D0 File Offset: 0x00719AD0
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06007C12 RID: 31762 RVA: 0x0071B8E8 File Offset: 0x00719AE8
		public override void Init()
		{
			int a_ = 7;
			short num = (short)54660445;
			short num2 = num;
			num = (short)1368722781;
			switch (num2 == num)
			{
			}
			num = (short)1114505216;
			short num3 = num;
			num = (short)431030272;
			if (num != 0)
			{
			}
			num = (short)1713569793;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("过꿉ꋋꯍꋏ돑룓", a_);
			base.Id = 10231;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06007C13 RID: 31763 RVA: 0x0071B9CC File Offset: 0x00719BCC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 6;
			short num = (short)504334040;
			short num2 = num;
			num = (short)386369240;
			switch (num2 == num)
			{
			}
			num = (short)1746468864;
			short num3 = num;
			num = (short)822935553;
			if (num != 0)
			{
			}
			num = (short)654049280;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胆곈ꗊ꣌뷎냐뿒", a_);
			base.Id = 10231;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06007C14 RID: 31764 RVA: 0x0071BAB0 File Offset: 0x00719CB0
		public override void PopulateReferences()
		{
			short num = (short)1240601308;
			short num2 = num;
			num = (short)828642012;
			switch (num2 == num)
			{
			}
			num = (short)7929856;
			short num3 = num;
			num = (short)952500225;
			if (num != 0)
			{
			}
			num = (short)94240768;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007C15 RID: 31765 RVA: 0x0071BB58 File Offset: 0x00719D58
		public override void DropReferences()
		{
			short num = (short)437583873;
			if (num != 0)
			{
			}
			num = (short)1564962648;
			short num2 = num;
			num = (short)922316632;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1515716608;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1028653056;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007C16 RID: 31766 RVA: 0x0071BC04 File Offset: 0x00719E04
		public override void SetConstraints()
		{
			short num = (short)1044694414;
			short num2 = num;
			num = (short)1368049038;
			switch (num2 == num)
			{
			}
			num = (short)818282496;
			short num3 = num;
			num = (short)1935147008;
			if (num != 0)
			{
			}
			num = (short)185073665;
			if (num != 0)
			{
			}
		}

		// Token: 0x06007C17 RID: 31767 RVA: 0x0071BCA8 File Offset: 0x00719EA8
		public override void SetupDependencies()
		{
			short num = (short)942731194;
			short num2 = num;
			num = (short)97251258;
			switch (num2 == num)
			{
			}
			num = (short)626786304;
			short num3 = num;
			num = (short)675348480;
			if (num != 0)
			{
			}
			num = (short)103022593;
			if (num != 0)
			{
			}
		}

		// Token: 0x17003FA0 RID: 16288
		// (get) Token: 0x06007C18 RID: 31768 RVA: 0x0071BD54 File Offset: 0x00719F54
		public bool HasDiffs
		{
			get
			{
				short num = (short)949854589;
				short num2 = num;
				num = (short)829727101;
				switch (num2 == num)
				{
				}
				num = (short)1532559360;
				short num3 = num;
				num = (short)1117061121;
				if (num != 0)
				{
				}
				num = (short)228130816;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06007C19 RID: 31769 RVA: 0x0071BE00 File Offset: 0x0071A000
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
				{
					if (base.ParentRecset == null)
					{
						return result;
					}
					num2 = (short)1079260306;
					short num3 = num2;
					num2 = (short)1443378322;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D5;
					default:
						num2 = (short)2122252288;
						if (num2 != 0)
						{
						}
						num2 = (short)1359413250;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_D5;
				case 3:
					num2 = (short)1859649537;
					if (num2 != 0)
					{
					}
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1587085316;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1639383040;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
				IL_D5:
				num2 = (short)704118787;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1988558848;
			short num4 = num2;
			num2 = (short)193069057;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04003731 RID: 14129
		private global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerRecset innerRecset;
	}
}
