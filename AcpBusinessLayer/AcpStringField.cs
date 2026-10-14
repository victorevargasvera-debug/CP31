using System;
using System.Diagnostics;
using AcpCommonLib;

namespace AcpBusinessLayer
{
	// Token: 0x02000012 RID: 18
	[global::System.Diagnostics.DebuggerDisplay("Name={UIName}, Value={Value}, MaxLength={MaxLength}")]
	[global::System.Serializable]
	public class AcpStringField : global::AcpBusinessLayer.AcpField<string>
	{
		// Token: 0x06000172 RID: 370 RVA: 0x0001B6F4 File Offset: 0x000198F4
		public AcpStringField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel) : this(parent, name, uiLabel, int.MaxValue)
		{
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0001B710 File Offset: 0x00019910
		public AcpStringField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string[] legacyUILabels) : this(parent, name, uiLabel, int.MaxValue, legacyUILabels)
		{
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0001B730 File Offset: 0x00019930
		public AcpStringField(string value, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel) : this(value, parent, name, uiLabel, int.MaxValue)
		{
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0001B750 File Offset: 0x00019950
		public AcpStringField(string value, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string[] legacyUILabels) : this(value, parent, name, uiLabel, int.MaxValue, legacyUILabels)
		{
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0001B770 File Offset: 0x00019970
		public AcpStringField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, int maxLength)
		{
			this.maxLength = int.MaxValue;
			base..ctor(parent, name, uiLabel);
			this.MaxLength = maxLength;
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0001B79C File Offset: 0x0001999C
		public AcpStringField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, int maxLength, string[] legacyUILabels)
		{
			this.maxLength = int.MaxValue;
			base..ctor(parent, name, uiLabel, legacyUILabels);
			this.MaxLength = maxLength;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0001B7C8 File Offset: 0x000199C8
		public AcpStringField(string value, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, int maxLength)
		{
			this.maxLength = int.MaxValue;
			base..ctor(value, parent, name, uiLabel);
			this.MaxLength = maxLength;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0001B7F4 File Offset: 0x000199F4
		public AcpStringField(string value, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, int maxLength, string[] legacyUILabels)
		{
			this.maxLength = int.MaxValue;
			base..ctor(value, parent, name, uiLabel, legacyUILabels);
			this.MaxLength = maxLength;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0001B824 File Offset: 0x00019A24
		protected AcpStringField()
		{
			this.maxLength = int.MaxValue;
			base..ctor();
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600017B RID: 379 RVA: 0x0001B844 File Offset: 0x00019A44
		// (set) Token: 0x0600017C RID: 380 RVA: 0x0001B8F4 File Offset: 0x00019AF4
		public int MaxLength
		{
			get
			{
				short num = (short)2013022302;
				short num2 = num;
				num = (short)115886174;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1467678720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1815674881;
				if (num != 0)
				{
				}
				num = (short)1904541696;
				if (num != 0)
				{
				}
				return this.maxLength;
			}
			set
			{
				short num = (short)936247297;
				if (num != 0)
				{
				}
				num = (short)694091776;
				short num2 = num;
				num = (short)50903780;
				short num3 = num;
				num = (short)779664100;
				switch (num3 == num)
				{
				}
				num = (short)1933770752;
				if (num != 0)
				{
				}
				this.maxLength = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600017D RID: 381 RVA: 0x0001B9A4 File Offset: 0x00019BA4
		// (set) Token: 0x0600017E RID: 382 RVA: 0x0001BA54 File Offset: 0x00019C54
		public override string Value
		{
			get
			{
				short num = (short)1326710785;
				if (num != 0)
				{
				}
				num = (short)1048510464;
				short num2 = num;
				num = (short)1643752679;
				short num3 = num;
				num = (short)1376759015;
				switch (num3 == num)
				{
				}
				num = (short)1488125952;
				if (num != 0)
				{
				}
				return base.Value;
			}
			set
			{
				short num = (short)1962999809;
				if (num != 0)
				{
				}
				num = (short)1476329472;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_58;
						}
						continue;
					case 1:
						goto IL_EB;
					case 2:
						goto IL_10F;
					}
					IL_58:
					if (value != null)
					{
						num = (short)737114987;
						short num3 = num;
						num = (short)1549171563;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_EB;
						case 1:
							break;
						default:
						{
							num = (short)1771438080;
							short num4 = num;
							break;
						}
						}
						num = (short)1399521280;
						if (num != 0)
						{
						}
						num = (short)547225601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_EB:
					base.ForceValid = this.CheckLength(value);
					num = (short)932315138;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_10F:
				base.Value = value;
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0001BB7C File Offset: 0x00019D7C
		protected virtual bool CheckLength(string value)
		{
			short num = (short)1931565200;
			short num2 = num;
			num = (short)2031442064;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1819738112;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2086010881;
			if (num != 0)
			{
			}
			num = (short)606470144;
			if (num != 0)
			{
			}
			return value.Length <= this.MaxLength;
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0001BC38 File Offset: 0x00019E38
		internal override void DeepCopy(global::AcpCommonLib.IAcpField source)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
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
					num2 = (short)983045934;
					short num3 = num2;
					num2 = (short)800528174;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num2 = (short)1056768000;
						if (num2 != 0)
						{
						}
						num2 = (short)12058624;
						short num4 = num2;
						if (this.Value != null)
						{
							num2 = (short)1712062465;
							if (num2 != 0)
							{
							}
							num2 = (short)466157569;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					}
					break;
				}
				case 1:
					base.ForceValid = this.CheckLength(this.Value);
					num2 = (short)1685389314;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			base.DeepCopy(source);
			num2 = (short)1698234368;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000045 RID: 69
		private int maxLength;
	}
}
