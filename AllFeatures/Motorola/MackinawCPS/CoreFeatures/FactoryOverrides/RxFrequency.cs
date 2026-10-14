using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.FactoryOverrides
{
	// Token: 0x02000452 RID: 1106
	[global::System.Serializable]
	public class RxFrequency : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060093E4 RID: 37860 RVA: 0x008B63BC File Offset: 0x008B45BC
		public RxFrequency(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxFrequencyListInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x060093E5 RID: 37861 RVA: 0x008B63FC File Offset: 0x008B45FC
		protected RxFrequency(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060093E6 RID: 37862 RVA: 0x008B6414 File Offset: 0x008B4614
		public override void Init()
		{
			int a_ = 19;
			short num = (short)970354465;
			short num2 = num;
			num = (short)846491425;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1448804352;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)274595840;
			if (num != 0)
			{
			}
			num = (short)1848836097;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蛓껕鳙껛믝釟韡臣裥诧鏩", a_);
			base.Id = 10905;
			base.UIName = global::CommonResources.AcgResources.ID_RXFREQUENCY;
			base.DataTransferOrder = 11;
		}

		// Token: 0x060093E7 RID: 37863 RVA: 0x008B64F8 File Offset: 0x008B46F8
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 5;
			short num = (short)1676236730;
			short num2 = num;
			num = (short)1166170042;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1623326720;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1713700865;
			if (num != 0)
			{
			}
			num = (short)8781824;
			if (num != 0)
			{
			}
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("铅냇請볍뗏ꏑꇓ돕뛗맙ꗛ", a_);
			base.Id = 10905;
			base.UIName = global::CommonResources.AcgResources.ID_RXFREQUENCY;
			base.DataTransferOrder = 11;
		}

		// Token: 0x060093E8 RID: 37864 RVA: 0x008B65DC File Offset: 0x008B47DC
		public override void PopulateReferences()
		{
			short num = (short)1123942401;
			if (num != 0)
			{
			}
			num = (short)866516992;
			short num2 = num;
			num = (short)250812924;
			short num3 = num;
			num = (short)703011324;
			switch (num3 == num)
			{
			}
			num = (short)437583872;
			if (num != 0)
			{
			}
		}

		// Token: 0x060093E9 RID: 37865 RVA: 0x008B6688 File Offset: 0x008B4888
		public override void DropReferences()
		{
			short num = (short)156237825;
			if (num != 0)
			{
			}
			num = (short)1092222976;
			short num2 = num;
			num = (short)398287119;
			short num3 = num;
			num = (short)132145423;
			switch (num3 == num)
			{
			}
			num = (short)1371078656;
			if (num != 0)
			{
			}
		}

		// Token: 0x060093EA RID: 37866 RVA: 0x008B6734 File Offset: 0x008B4934
		public override void SetConstraints()
		{
			short num = (short)1915002247;
			short num2 = num;
			num = (short)333749639;
			switch (num2 == num)
			{
			default:
			{
				num = (short)477954048;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1764687873;
			if (num != 0)
			{
			}
			num = (short)462094336;
			if (num != 0)
			{
			}
		}

		// Token: 0x060093EB RID: 37867 RVA: 0x008B67DC File Offset: 0x008B49DC
		public override void SetupDependencies()
		{
			short num = (short)458892584;
			short num2 = num;
			num = (short)94381352;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1248133120;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1060306945;
			if (num != 0)
			{
			}
			num = (short)1938358272;
			if (num != 0)
			{
			}
		}

		// Token: 0x17004A7B RID: 19067
		// (get) Token: 0x060093EC RID: 37868 RVA: 0x008B6884 File Offset: 0x008B4A84
		public bool HasDiffs
		{
			get
			{
				short num = (short)1587794016;
				short num2 = num;
				num = (short)111988832;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1150746624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1124466688;
				if (num != 0)
				{
				}
				num = (short)523501569;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x060093ED RID: 37869 RVA: 0x008B6934 File Offset: 0x008B4B34
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num2;
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
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)442188309;
						short num3 = num2;
						num2 = (short)824918549;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)1253376000;
							if (num2 != 0)
							{
							}
							num2 = (short)2008875011;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						goto IL_B4;
					case 2:
					{
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)116785152;
						short num4 = num2;
						num2 = (short)663027713;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 3:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)2012872706;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 4:
						if (base.ParentRecset != null)
						{
							num2 = (short)678821888;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				IL_24:
				result = null;
				num2 = (short)461504516;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_B4:
			num2 = (short)1247608833;
			if (num2 != 0)
			{
			}
			return result;
		}

		// Token: 0x040049DD RID: 18909
		private global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxFrequencyListInnerRecset innerRecset;
	}
}
