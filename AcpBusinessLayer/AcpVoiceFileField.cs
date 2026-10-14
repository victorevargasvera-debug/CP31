using System;
using System.IO;
using ACPVoiceAnnouncementLib;

namespace AcpBusinessLayer
{
	// Token: 0x02000025 RID: 37
	[global::System.Serializable]
	public class AcpVoiceFileField : global::AcpBusinessLayer.AcpField<global::AcpBusinessLayer.AcpVoiceFileStruct>
	{
		// Token: 0x06000301 RID: 769 RVA: 0x0003B290 File Offset: 0x00039490
		protected AcpVoiceFileField()
		{
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0003B2A4 File Offset: 0x000394A4
		public AcpVoiceFileField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel) : base(parent, name, uiLabel)
		{
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0003B2BC File Offset: 0x000394BC
		public override void SetValue(global::AcpBusinessLayer.AcpVoiceFileStruct newValue)
		{
			short num;
			try
			{
				num = (short)1014628363;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)920190979;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_223;
					case 2:
						if (this.VoiceData != null)
						{
							num = (short)864288777;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_122;
					case 3:
						if (base.ParentNode != null)
						{
							num = (short)110821377;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_122;
					case 4:
						num = (short)1187250178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)567607306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (this.VoiceData != null)
						{
							num = (short)961347597;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_33D;
					case 7:
						num = (short)358678529;
						if (num != 0)
						{
						}
						goto IL_122;
					case 8:
						if (base.ParentNode != null)
						{
							num = (short)815529989;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_33D;
					case 9:
						((global::AcpBusinessLayer.Recordset)base.Parent.ParentRecset).DecrementCumulativeMax(base.ParentNode);
						num = (short)675872775;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (base.Parent.ParentRecset != null)
						{
							num = (short)518717454;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_33D;
					case 11:
						switch (0)
						{
						case 0:
							goto IL_70;
						}
						continue;
					case 12:
						if (base.Parent != null)
						{
							num = (short)1819017232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_33D;
					case 13:
						((global::AcpBusinessLayer.Recordset)base.Parent.ParentRecset).IncrementCumulativeMax(base.ParentNode);
						num = (short)1129054226;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						num = (short)579060155;
						short num3 = num;
						num = (short)2048180667;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_223;
						default:
							num = (short)1927610368;
							if (num != 0)
							{
							}
							num = (short)279707654;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 15:
						if (base.Parent.ParentRecset != null)
						{
							num = (short)1531248644;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_122;
					case 16:
						num = (short)132710408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_354;
					case 18:
						goto IL_33D;
					}
					IL_70:
					if (base.Parent != null)
					{
						num = (short)992477184;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_122:
					base.SetValue(newValue);
					num = (short)901513228;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_223:
					num = (short)99287055;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_33D:
					num = (short)336920593;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_354:;
			}
			catch
			{
			}
			num = (short)1249116160;
			short num4 = num;
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0003B668 File Offset: 0x00039868
		public override string ToString()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			string result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)792526849;
					if (num2 != 0)
					{
					}
					num2 = (short)1131365775;
					short num3 = num2;
					num2 = (short)779437455;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
					{
						num2 = (short)129630208;
						short num4 = num2;
						num2 = (short)305135616;
						if (num2 != 0)
						{
						}
						if (this.Value.voiceData != null)
						{
							num2 = (short)1028980737;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					}
					break;
				}
				case 1:
					result = global::AcpBusinessLayer.VAUtilities.ByteArrayToStr(this.Value.voiceData.GetBuffer(), (int)this.Value.voiceData.Length);
					num2 = (short)1745420290;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return result;
				}
				goto IL_1C;
			}
			return result;
			IL_1C:
			result = string.Empty;
			num2 = (short)726269952;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0003B7B0 File Offset: 0x000399B0
		static AcpVoiceFileField()
		{
			short num = (short)1357754619;
			short num2 = num;
			num = (short)359510267;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2045837312;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)844103681;
			if (num != 0)
			{
			}
			num = (short)1702625280;
			if (num != 0)
			{
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000306 RID: 774 RVA: 0x0003B85C File Offset: 0x00039A5C
		// (set) Token: 0x06000307 RID: 775 RVA: 0x0003B910 File Offset: 0x00039B10
		public global::System.IO.MemoryStream VoiceData
		{
			get
			{
				short num = (short)2037972993;
				if (num != 0)
				{
				}
				num = (short)274268160;
				short num2 = num;
				num = (short)1458259871;
				short num3 = num;
				num = (short)83183519;
				switch (num3 == num)
				{
				}
				num = (short)1016594432;
				if (num != 0)
				{
				}
				return this.Value.voiceData;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				short num2;
				global::AcpBusinessLayer.AcpVoiceFileStruct value2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)559926583;
						short num3 = num2;
						num2 = (short)153799991;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14D;
						default:
							num2 = (short)1837170688;
							if (num2 != 0)
							{
							}
							value.WriteTo(value2.voiceData);
							num2 = (short)657391619;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
					{
						if (value2.voiceData != null)
						{
							num2 = (short)1161560064;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)961085440;
						short num4 = num2;
						value2.voiceData = new global::System.IO.MemoryStream();
						value.WriteTo(value2.voiceData);
						num2 = (short)44892162;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 2:
						goto IL_101;
					case 3:
						goto IL_14D;
					}
					goto IL_20;
				}
				IL_101:
				num2 = (short)1531510785;
				if (num2 != 0)
				{
				}
				IL_14D:
				value2.hashcode = value2.GetHashCode();
				value2.compressionType = global::ACPVoiceAnnouncementLib.MotVoiceFileCompressionCode.AMR;
				value2.compressionParam = 6;
				base.SetValueNoConstraints(value2);
				return;
				IL_20:
				value2 = this.Value;
				num2 = (short)1780875265;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000308 RID: 776 RVA: 0x0003BA94 File Offset: 0x00039C94
		public global::ACPVoiceAnnouncementLib.MotVoiceFileCompressionCode CompressionType
		{
			get
			{
				short num = (short)113442817;
				if (num != 0)
				{
				}
				num = (short)862643765;
				short num2 = num;
				num = (short)205907509;
				switch (num2 == num)
				{
				}
				num = (short)1108672512;
				if (num != 0)
				{
				}
				num = (short)684261376;
				short num3 = num;
				return this.Value.compressionType;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000309 RID: 777 RVA: 0x0003BB4C File Offset: 0x00039D4C
		public int CompressionParam
		{
			get
			{
				short num = (short)2060713985;
				if (num != 0)
				{
				}
				num = (short)1188572831;
				short num2 = num;
				num = (short)1641295519;
				switch (num2 == num)
				{
				}
				num = (short)1545601024;
				if (num != 0)
				{
				}
				num = (short)1873870848;
				short num3 = num;
				return this.Value.compressionParam;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600030A RID: 778 RVA: 0x0003BC00 File Offset: 0x00039E00
		public uint Hashcode
		{
			get
			{
				short num = (short)209904646;
				short num2 = num;
				num = (short)2123097094;
				switch (num2 == num)
				{
				}
				num = (short)1088028673;
				if (num != 0)
				{
				}
				num = (short)1762852864;
				if (num != 0)
				{
				}
				num = (short)1971191808;
				short num3 = num;
				return this.Value.hashcode;
			}
		}
	}
}
