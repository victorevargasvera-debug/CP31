using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Buttons
{
	// Token: 0x02000412 RID: 1042
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06008EAF RID: 36527 RVA: 0x0086AB48 File Offset: 0x00868D48
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06008EB0 RID: 36528 RVA: 0x0086AB88 File Offset: 0x00868D88
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06008EB1 RID: 36529 RVA: 0x0086ABA0 File Offset: 0x00868DA0
		public override void Init()
		{
			int a_ = 13;
			short num = (short)980353024;
			short num2 = num;
			num = (short)517341185;
			if (num != 0)
			{
			}
			num = (short)1786478013;
			short num3 = num;
			num = (short)121077181;
			switch (num3 == num)
			{
			}
			num = (short)155123712;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("觍뗏병뇓ꓕ맗뛙", a_);
			base.Id = 10091;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008EB2 RID: 36530 RVA: 0x0086AC88 File Offset: 0x00868E88
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 0;
			short num = (short)947257344;
			short num2 = num;
			num = (short)1205927937;
			if (num != 0)
			{
			}
			num = (short)932719401;
			short num3 = num;
			num = (short)342305577;
			switch (num3 == num)
			{
			}
			num = (short)1135411200;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蛀ꛂꯄꋆ믈꫊ꇌ", a_);
			base.Id = 10091;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06008EB3 RID: 36531 RVA: 0x0086AD70 File Offset: 0x00868F70
		public override void PopulateReferences()
		{
			short num = (short)23592960;
			short num2 = num;
			num = (short)1531154177;
			short num3 = num;
			num = (short)195858177;
			switch (num3 == num)
			{
			}
			num = (short)1394081793;
			if (num != 0)
			{
			}
			num = (short)1834418176;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008EB4 RID: 36532 RVA: 0x0086AE1C File Offset: 0x0086901C
		public override void DropReferences()
		{
			short num = (short)708247552;
			short num2 = num;
			num = (short)427939263;
			short num3 = num;
			num = (short)1658967487;
			switch (num3 == num)
			{
			}
			num = (short)1063518209;
			if (num != 0)
			{
			}
			num = (short)1277689856;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008EB5 RID: 36533 RVA: 0x0086AEC8 File Offset: 0x008690C8
		public override void SetConstraints()
		{
			short num = (short)821428224;
			short num2 = num;
			num = (short)362035912;
			short num3 = num;
			num = (short)720583368;
			switch (num3 == num)
			{
			}
			num = (short)1546780673;
			if (num != 0)
			{
			}
			num = (short)627441664;
			if (num != 0)
			{
			}
		}

		// Token: 0x06008EB6 RID: 36534 RVA: 0x0086AF74 File Offset: 0x00869174
		public override void SetupDependencies()
		{
			short num = (short)1702232064;
			short num2 = num;
			num = (short)1638154180;
			short num3 = num;
			num = (short)1155743684;
			switch (num3 == num)
			{
			}
			num = (short)1276182529;
			if (num != 0)
			{
			}
			num = (short)55312384;
			if (num != 0)
			{
			}
		}

		// Token: 0x1700480D RID: 18445
		// (get) Token: 0x06008EB7 RID: 36535 RVA: 0x0086B020 File Offset: 0x00869220
		public bool HasDiffs
		{
			get
			{
				short num = (short)826277888;
				short num2 = num;
				num = (short)1846629170;
				short num3 = num;
				num = (short)1209881394;
				switch (num3 == num)
				{
				}
				num = (short)1473576960;
				if (num != 0)
				{
				}
				num = (short)501678081;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x06008EB8 RID: 36536 RVA: 0x0086B0CC File Offset: 0x008692CC
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (base.ParentRecset != null)
					{
						num2 = (short)282394625;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_140;
				case 1:
					num2 = (short)576323587;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)2018377729;
					if (num2 != 0)
					{
					}
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1709637636;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1366491138;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_140;
				case 4:
					goto IL_D4;
				}
				goto IL_24;
			}
			IL_D4:
			IL_140:
			num2 = (short)1859911680;
			short num3 = num2;
			return result;
			IL_24:
			num2 = (short)2010464632;
			short num4 = num2;
			num2 = (short)678969720;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			default:
			{
				num2 = (short)1169358848;
				if (num2 != 0)
				{
				}
				result = null;
				num2 = (short)1318322176;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x04004777 RID: 18295
		private global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset innerRecset;
	}
}
