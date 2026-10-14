using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO9
{
	// Token: 0x0200036E RID: 878
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008263 RID: 33379 RVA: 0x007979C4 File Offset: 0x00795BC4
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06008264 RID: 33380 RVA: 0x00797A04 File Offset: 0x00795C04
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008265 RID: 33381 RVA: 0x00797A1C File Offset: 0x00795C1C
		public override void Init()
		{
			int a_ = 3;
			short num = (short)833093632;
			short num2 = num;
			num = (short)687198988;
			short num3 = num;
			num = (short)658494220;
			switch (num3 == num)
			{
			}
			num = (short)1377763328;
			if (num != 0)
			{
			}
			num = (short)858128385;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("菃ꏅꛇ꿉뻋꿍볏", a_);
			base.Id = 10626;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008266 RID: 33382 RVA: 0x00797B00 File Offset: 0x00795D00
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 4;
			short num = (short)1631911936;
			short num2 = num;
			num = (short)38778045;
			short num3 = num;
			num = (short)703444157;
			switch (num3 == num)
			{
			}
			num = (short)371064833;
			if (num != 0)
			{
			}
			num = (short)784793600;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("苄ꋆꟈ껊뿌껎뷐", a_);
			base.Id = 10626;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008267 RID: 33383 RVA: 0x00797BE4 File Offset: 0x00795DE4
		public override void PopulateReferences()
		{
			short num = (short)2022440960;
			short num2 = num;
			num = (short)1246353259;
			short num3 = num;
			num = (short)1206900587;
			switch (num3 == num)
			{
			}
			num = (short)998440960;
			if (num != 0)
			{
			}
			num = (short)1953955841;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008268 RID: 33384 RVA: 0x00797C90 File Offset: 0x00795E90
		public override void DropReferences()
		{
			short num = (short)643432448;
			short num2 = num;
			num = (short)616012505;
			short num3 = num;
			num = (short)371956441;
			switch (num3 == num)
			{
			}
			num = (short)1169358848;
			if (num != 0)
			{
			}
			num = (short)1281425409;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008269 RID: 33385 RVA: 0x00797D38 File Offset: 0x00795F38
		public override void SetConstraints()
		{
			short num = (short)906690560;
			short num2 = num;
			num = (short)178880885;
			short num3 = num;
			num = (short)1127317877;
			switch (num3 == num)
			{
			}
			num = (short)570163201;
			if (num != 0)
			{
			}
			num = (short)1466630144;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600826A RID: 33386 RVA: 0x00797DE0 File Offset: 0x00795FE0
		public override void SetupDependencies()
		{
			short num = (short)505610240;
			short num2 = num;
			num = (short)264832408;
			short num3 = num;
			num = (short)1494877592;
			switch (num3 == num)
			{
			}
			num = (short)1430847489;
			if (num != 0)
			{
			}
			num = (short)696582144;
			if (num != 0)
			{
			}
		}

		// Token: 0x17004271 RID: 17009
		// (get) Token: 0x0600826B RID: 33387 RVA: 0x00797E88 File Offset: 0x00796088
		public bool HasDiffs
		{
			get
			{
				short num = (short)114556928;
				short num2 = num;
				num = (short)837561110;
				short num3 = num;
				num = (short)960637718;
				switch (num3 == num)
				{
				}
				num = (short)1942683649;
				if (num != 0)
				{
				}
				num = (short)909574144;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600826C RID: 33388 RVA: 0x00797F38 File Offset: 0x00796138
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)1006920035;
			short num2 = num;
			num = (short)1078616419;
			global::AcpCommonLib.IAcpRecordset result;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_83:
				if (base.ParentRecset == null)
				{
					return result;
				}
				num = (short)1462829060;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)816644096;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_6D;
				}
				break;
			}
			for (;;)
			{
				IL_53:
				switch (num3)
				{
				case 0:
					goto IL_83;
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)747831296;
						short num4 = num;
						num = (short)1920335874;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 2:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)180879363;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_CB;
				case 4:
					num = (short)1155727361;
					if (num != 0)
					{
					}
					num = (short)762839041;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_6D;
			}
			IL_CB:
			return result;
			IL_6D:
			result = null;
			num = (short)1621950464;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_53;
		}

		// Token: 0x04003E43 RID: 15939
		private global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerRecset innerRecset;
	}
}
