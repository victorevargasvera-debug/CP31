using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO5
{
	// Token: 0x020003B0 RID: 944
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600888E RID: 34958 RVA: 0x007F42CC File Offset: 0x007F24CC
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x0600888F RID: 34959 RVA: 0x007F430C File Offset: 0x007F250C
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008890 RID: 34960 RVA: 0x007F4324 File Offset: 0x007F2524
		public override void Init()
		{
			int a_ = 14;
			short num = (short)435355648;
			short num2 = num;
			num = (short)1473220003;
			short num3 = num;
			num = (short)1172540835;
			switch (num3 == num)
			{
			}
			num = (short)1614020609;
			if (num != 0)
			{
			}
			num = (short)1402601472;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("裎듐뷒냔ꗖ룘럚", a_);
			base.Id = 10227;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008891 RID: 34961 RVA: 0x007F4408 File Offset: 0x007F2608
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 10;
			short num = (short)2012741632;
			short num2 = num;
			num = (short)904728120;
			short num3 = num;
			num = (short)1769672248;
			switch (num3 == num)
			{
			}
			num = (short)1394802688;
			if (num != 0)
			{
			}
			num = (short)428867585;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("賊꣌ꇎ듐ꇒ듔믖", a_);
			base.Id = 10227;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008892 RID: 34962 RVA: 0x007F44EC File Offset: 0x007F26EC
		public override void PopulateReferences()
		{
			short num = (short)1194852352;
			short num2 = num;
			num = (short)1175219758;
			short num3 = num;
			num = (short)220294702;
			switch (num3 == num)
			{
			}
			num = (short)1744830465;
			if (num != 0)
			{
			}
			num = (short)1642987520;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008893 RID: 34963 RVA: 0x007F4598 File Offset: 0x007F2798
		public override void DropReferences()
		{
			short num = (short)830537728;
			short num2 = num;
			num = (short)1938427535;
			short num3 = num;
			num = (short)1792020111;
			switch (num3 == num)
			{
			}
			num = (short)256311296;
			if (num != 0)
			{
			}
			num = (short)298188801;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008894 RID: 34964 RVA: 0x007F4640 File Offset: 0x007F2840
		public override void SetConstraints()
		{
			short num = (short)1106378752;
			short num2 = num;
			num = (short)1684892087;
			short num3 = num;
			num = (short)746482103;
			switch (num3 == num)
			{
			}
			num = (short)1133641729;
			if (num != 0)
			{
			}
			num = (short)199622656;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008895 RID: 34965 RVA: 0x007F46EC File Offset: 0x007F28EC
		public override void SetupDependencies()
		{
			short num = (short)1861681152;
			short num2 = num;
			num = (short)1320681473;
			if (num != 0)
			{
			}
			num = (short)774946097;
			short num3 = num;
			num = (short)552385841;
			switch (num3 == num)
			{
			}
			num = (short)2084896768;
			if (num != 0)
			{
			}
		}

		// Token: 0x17004559 RID: 17753
		// (get) Token: 0x06008896 RID: 34966 RVA: 0x007F4794 File Offset: 0x007F2994
		public bool HasDiffs
		{
			get
			{
				short num = (short)451084288;
				short num2 = num;
				num = (short)1709047809;
				if (num != 0)
				{
				}
				num = (short)1255531000;
				short num3 = num;
				num = (short)609280504;
				switch (num3 == num)
				{
				}
				num = (short)1842020352;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06008897 RID: 34967 RVA: 0x007F4840 File Offset: 0x007F2A40
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
					if (base.ParentRecset != null)
					{
						num2 = (short)2027945985;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_139;
				case 1:
				{
					num2 = (short)657132276;
					short num3 = num2;
					num2 = (short)1071057652;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_134;
					default:
						num2 = (short)144441344;
						if (num2 != 0)
						{
						}
						num2 = (short)1641152513;
						if (num2 != 0)
						{
						}
						num2 = (short)1312817154;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)430833668;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_139;
				case 3:
					goto IL_D0;
				case 4:
					goto IL_134;
				}
				goto IL_24;
				IL_134:
				result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
				num2 = (short)1864564739;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_D0:
			IL_139:
			num2 = (short)1685454848;
			short num4 = num2;
			return result;
			IL_24:
			result = null;
			num2 = (short)1456209920;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040040DB RID: 16603
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerRecset innerRecset;
	}
}
