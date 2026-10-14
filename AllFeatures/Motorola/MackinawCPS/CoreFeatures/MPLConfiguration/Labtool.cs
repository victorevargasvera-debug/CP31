using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.MPLConfiguration
{
	// Token: 0x02000537 RID: 1335
	[global::System.Serializable]
	public class Labtool : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600B1F3 RID: 45555 RVA: 0x00A53744 File Offset: 0x00A51944
		public Labtool(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600B1F4 RID: 45556 RVA: 0x00A53760 File Offset: 0x00A51960
		protected Labtool(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600B1F5 RID: 45557 RVA: 0x00A53778 File Offset: 0x00A51978
		public override void Init()
		{
			int a_ = 15;
			short num = (short)115193372;
			short num2 = num;
			num = (short)641709596;
			switch (num2 == num)
			{
			}
			num = (short)1244004353;
			if (num != 0)
			{
			}
			num = (short)85065728;
			if (num != 0)
			{
			}
			num = (short)1617625088;
			short num3 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鳏돑뛓ꋕ럗뗙냛", a_);
			base.Id = 10195;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOL;
			base.DataTransferOrder = 3;
		}

		// Token: 0x0600B1F6 RID: 45558 RVA: 0x00A5385C File Offset: 0x00A51A5C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 3;
			short num = (short)2132685796;
			short num2 = num;
			num = (short)1743598564;
			switch (num2 == num)
			{
			}
			num = (short)1540816897;
			if (num != 0)
			{
			}
			num = (short)972750848;
			if (num != 0)
			{
			}
			num = (short)981139456;
			short num3 = num;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("裃Ʂ꫇뻉ꏋꇍ볏", a_);
			base.Id = 10195;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOL;
			base.DataTransferOrder = 3;
		}

		// Token: 0x0600B1F7 RID: 45559 RVA: 0x00A5393C File Offset: 0x00A51B3C
		public override void PopulateReferences()
		{
			short num = (short)172949505;
			if (num != 0)
			{
			}
			num = (short)2086720158;
			short num2 = num;
			num = (short)1879757470;
			switch (num2 == num)
			{
			}
			num = (short)1653538816;
			if (num != 0)
			{
			}
			num = (short)274268160;
			short num3 = num;
		}

		// Token: 0x0600B1F8 RID: 45560 RVA: 0x00A539E4 File Offset: 0x00A51BE4
		public override void DropReferences()
		{
			short num = (short)232914945;
			if (num != 0)
			{
			}
			num = (short)1350000638;
			short num2 = num;
			num = (short)1134059518;
			switch (num2 == num)
			{
			}
			num = (short)123142144;
			if (num != 0)
			{
			}
			num = (short)1890385920;
			short num3 = num;
		}

		// Token: 0x0600B1F9 RID: 45561 RVA: 0x00A53A8C File Offset: 0x00A51C8C
		public override void SetConstraints()
		{
			short num = (short)1373447349;
			short num2 = num;
			num = (short)663954613;
			switch (num2 == num)
			{
			}
			num = (short)159252481;
			if (num != 0)
			{
			}
			num = (short)1698627584;
			if (num != 0)
			{
			}
			num = (short)165150720;
			short num3 = num;
		}

		// Token: 0x0600B1FA RID: 45562 RVA: 0x00A53B34 File Offset: 0x00A51D34
		public override void SetupDependencies()
		{
			short num = (short)1696335367;
			short num2 = num;
			num = (short)730531335;
			switch (num2 == num)
			{
			}
			num = (short)1269825537;
			if (num != 0)
			{
			}
			num = (short)720961536;
			if (num != 0)
			{
			}
			num = (short)1230831616;
			short num3 = num;
		}

		// Token: 0x17005939 RID: 22841
		// (get) Token: 0x0600B1FB RID: 45563 RVA: 0x00A53BE0 File Offset: 0x00A51DE0
		public bool HasDiffs
		{
			get
			{
				short num = (short)1552613377;
				if (num != 0)
				{
				}
				num = (short)681413110;
				short num2 = num;
				num = (short)1655933430;
				switch (num2 == num)
				{
				}
				num = (short)1753153536;
				if (num != 0)
				{
				}
				num = (short)1741094912;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x0600B1FC RID: 45564 RVA: 0x00A53C90 File Offset: 0x00A51E90
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)331808772;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)1931345921;
					if (num2 != 0)
					{
					}
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)808058880;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
				{
					num2 = (short)1293746176;
					short num3 = num2;
					num2 = (short)673972225;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					if (base.ParentRecset != null)
					{
						num2 = (short)731512834;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					goto IL_D4;
				}
				break;
			}
			IL_24:
			result = null;
			num2 = (short)1155272062;
			short num4 = num2;
			num2 = (short)1497959806;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_D4:
				break;
			default:
			{
				num2 = (short)2048196608;
				if (num2 != 0)
				{
				}
				num2 = (short)282001411;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
			return result;
		}
	}
}
