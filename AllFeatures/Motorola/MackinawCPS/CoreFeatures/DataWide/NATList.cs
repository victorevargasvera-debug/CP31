using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DataWide
{
	// Token: 0x020004E5 RID: 1253
	[global::System.Serializable]
	public class NATList : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600A830 RID: 43056 RVA: 0x009C5028 File Offset: 0x009C3228
		public NATList(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x0600A831 RID: 43057 RVA: 0x009C5068 File Offset: 0x009C3268
		protected NATList(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600A832 RID: 43058 RVA: 0x009C5080 File Offset: 0x009C3280
		public override void Init()
		{
			int a_ = 13;
			short num = (short)1034395860;
			short num2 = num;
			num = (short)1529061588;
			switch (num2 == num)
			{
			}
			num = (short)544866305;
			if (num != 0)
			{
			}
			num = (short)928579584;
			short num3 = num;
			num = (short)1830158336;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胍量蛑髕뇗꧙꣛", a_);
			base.Id = 10067;
			base.UIName = global::CommonResources.AcgResources.ID_NATLIST;
			base.DataTransferOrder = 3;
		}

		// Token: 0x0600A833 RID: 43059 RVA: 0x009C5164 File Offset: 0x009C3364
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 18;
			short num = (short)198283086;
			short num2 = num;
			num = (short)135761742;
			switch (num2 == num)
			{
			}
			num = (short)1790640128;
			if (num != 0)
			{
			}
			num = (short)739966976;
			short num3 = num;
			num = (short)1916076033;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鷒铔菖律韚드곞闠", a_);
			base.Id = 10067;
			base.UIName = global::CommonResources.AcgResources.ID_NATLIST;
			base.DataTransferOrder = 3;
		}

		// Token: 0x0600A834 RID: 43060 RVA: 0x009C524C File Offset: 0x009C344C
		public override void PopulateReferences()
		{
			short num = (short)443810749;
			short num2 = num;
			num = (short)1558709181;
			switch (num2 == num)
			{
			}
			num = (short)2094006273;
			if (num != 0)
			{
			}
			num = (short)250740736;
			short num3 = num;
			num = (short)535166976;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600A835 RID: 43061 RVA: 0x009C52F8 File Offset: 0x009C34F8
		public override void DropReferences()
		{
			short num = (short)156310452;
			short num2 = num;
			num = (short)884349876;
			switch (num2 == num)
			{
			}
			num = (short)874905601;
			if (num != 0)
			{
			}
			num = (short)1103495168;
			short num3 = num;
			num = (short)2028797952;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600A836 RID: 43062 RVA: 0x009C53A0 File Offset: 0x009C35A0
		public override void SetConstraints()
		{
			short num = (short)519568262;
			short num2 = num;
			num = (short)577698694;
			switch (num2 == num)
			{
			}
			num = (short)333643776;
			if (num != 0)
			{
			}
			num = (short)161742848;
			short num3 = num;
			num = (short)1868955649;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600A837 RID: 43063 RVA: 0x009C5448 File Offset: 0x009C3648
		public override void SetupDependencies()
		{
			short num = (short)1235167631;
			short num2 = num;
			num = (short)1658923407;
			switch (num2 == num)
			{
			}
			num = (short)1626406913;
			if (num != 0)
			{
			}
			num = (short)534904832;
			short num3 = num;
			num = (short)343605248;
			if (num != 0)
			{
			}
		}

		// Token: 0x1700547D RID: 21629
		// (get) Token: 0x0600A838 RID: 43064 RVA: 0x009C54F4 File Offset: 0x009C36F4
		public bool HasDiffs
		{
			get
			{
				short num = (short)168416481;
				short num2 = num;
				num = (short)969528545;
				switch (num2 == num)
				{
				}
				num = (short)1984757760;
				if (num != 0)
				{
				}
				num = (short)201392128;
				short num3 = num;
				num = (short)46858241;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x0600A839 RID: 43065 RVA: 0x009C55A4 File Offset: 0x009C37A4
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1911144279;
						short num3 = num2;
						num2 = (short)1773649751;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)991559680;
							if (num2 != 0)
							{
							}
							if (base.ParentRecset.ContainerDoc != null)
							{
								num2 = (short)665518084;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return result;
						}
						break;
					}
					case 1:
						return result;
					case 2:
						if (base.ParentRecset != null)
						{
							num2 = (short)944308224;
							short num4 = num2;
							num2 = (short)370475011;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 3:
						num2 = (short)904658944;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						num2 = (short)611385345;
						if (num2 != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)480182273;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				IL_24:
				result = null;
				num2 = (short)785252354;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			return result;
		}

		// Token: 0x04005133 RID: 20787
		private global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInnerRecset innerRecset;
	}
}
