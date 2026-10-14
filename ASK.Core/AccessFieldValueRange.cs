using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ASK.Core
{
	// Token: 0x02000008 RID: 8
	[global::System.Serializable]
	public class AccessFieldValueRange : global::System.ICloneable, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x06000023 RID: 35 RVA: 0x0000404C File Offset: 0x0000224C
		public AccessFieldValueRange()
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00004074 File Offset: 0x00002274
		public AccessFieldValueRange(int field_id, uint? min, uint? max)
		{
			this.m_fieldID = field_id;
			this.m_min = min;
			this.m_max = max;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000040B0 File Offset: 0x000022B0
		// (set) Token: 0x06000026 RID: 38 RVA: 0x00004160 File Offset: 0x00002360
		public int FieldID
		{
			get
			{
				short num = (short)359487151;
				short num2 = num;
				num = (short)798512815;
				switch (num2 == num)
				{
				}
				num = (short)1234370560;
				if (num != 0)
				{
				}
				num = (short)84213761;
				if (num != 0)
				{
				}
				num = (short)10092544;
				short num3 = num;
				return this.m_fieldID;
			}
			set
			{
				short num = (short)1764367521;
				short num2 = num;
				num = (short)100670625;
				switch (num2 == num)
				{
				}
				num = (short)146538496;
				if (num != 0)
				{
				}
				num = (short)1317273601;
				if (num != 0)
				{
				}
				num = (short)1723203584;
				short num3 = num;
				this.m_fieldID = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00004214 File Offset: 0x00002414
		// (set) Token: 0x06000028 RID: 40 RVA: 0x000042C4 File Offset: 0x000024C4
		public uint? Minimum
		{
			get
			{
				short num = (short)1228951594;
				short num2 = num;
				num = (short)1903972394;
				switch (num2 == num)
				{
				}
				num = (short)457572353;
				if (num != 0)
				{
				}
				num = (short)387514368;
				if (num != 0)
				{
				}
				num = (short)186056704;
				short num3 = num;
				return this.m_min;
			}
			set
			{
				int a_ = 8;
				short num = (short)647147143;
				short num2 = num;
				num = (short)891989639;
				switch (num2 == num)
				{
				}
				num = (short)425525248;
				if (num != 0)
				{
				}
				num = (short)593756161;
				if (num != 0)
				{
				}
				num = (short)788725760;
				short num3 = num;
				this.m_min = value;
				this.FirePropertyChanged(global::ASK.Core.StatusMsg.b("ृ⽅♇⍉⅋㭍㵏", a_));
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00004394 File Offset: 0x00002594
		// (set) Token: 0x0600002A RID: 42 RVA: 0x00004444 File Offset: 0x00002644
		public uint? Maximum
		{
			get
			{
				short num = (short)289518339;
				short num2 = num;
				num = (short)926462723;
				switch (num2 == num)
				{
				}
				num = (short)1042481152;
				if (num != 0)
				{
				}
				num = (short)509280257;
				if (num != 0)
				{
				}
				num = (short)1432158208;
				short num3 = num;
				return this.m_max;
			}
			set
			{
				int a_ = 15;
				short num = (short)574814445;
				short num2 = num;
				num = (short)777648365;
				switch (num2 == num)
				{
				}
				num = (short)814219265;
				if (num != 0)
				{
				}
				num = (short)593428480;
				if (num != 0)
				{
				}
				num = (short)341442560;
				short num3 = num;
				this.m_max = value;
				this.FirePropertyChanged(global::ASK.Core.StatusMsg.b("يⱌ㝎㡐㹒⁔㩖", a_));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00004510 File Offset: 0x00002710
		// (set) Token: 0x0600002C RID: 44 RVA: 0x000045C0 File Offset: 0x000027C0
		public bool IsValid
		{
			get
			{
				short num = (short)628686849;
				if (num != 0)
				{
				}
				num = (short)757621642;
				short num2 = num;
				num = (short)2102879114;
				switch (num2 == num)
				{
				}
				num = (short)1720123392;
				if (num != 0)
				{
				}
				num = (short)761069568;
				short num3 = num;
				return this.m_IsValid;
			}
			set
			{
				int a_ = 8;
				short num = (short)1818495339;
				short num2 = num;
				num = (short)1100417387;
				switch (num2 == num)
				{
				}
				num = (short)1032585217;
				if (num != 0)
				{
				}
				num = (short)1871052800;
				if (num != 0)
				{
				}
				num = (short)100270080;
				short num3 = num;
				this.m_IsValid = value;
				this.FirePropertyChanged(global::ASK.Core.StatusMsg.b("ൃ㕅ṇ⭉⁋❍㑏", a_));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002D RID: 45 RVA: 0x0000468C File Offset: 0x0000288C
		// (set) Token: 0x0600002E RID: 46 RVA: 0x0000473C File Offset: 0x0000293C
		public string ErrorMsg
		{
			get
			{
				short num = (short)1403980977;
				short num2 = num;
				num = (short)1207241905;
				switch (num2 == num)
				{
				}
				num = (short)571867137;
				if (num != 0)
				{
				}
				num = (short)900071424;
				if (num != 0)
				{
				}
				num = (short)1495138304;
				short num3 = num;
				return this.m_ErrorMsg;
			}
			set
			{
				int a_ = 8;
				short num = (short)597624488;
				short num2 = num;
				num = (short)1393231528;
				switch (num2 == num)
				{
				default:
				{
					num = (short)362545152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)420413441;
				if (num != 0)
				{
				}
				num = (short)771358720;
				if (num != 0)
				{
				}
				this.m_ErrorMsg = value;
				this.FirePropertyChanged(global::ASK.Core.StatusMsg.b("Ń㑅㩇╉㹋͍⍏㕑", a_));
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600002F RID: 47 RVA: 0x00004808 File Offset: 0x00002A08
		// (remove) Token: 0x06000030 RID: 48 RVA: 0x00004940 File Offset: 0x00002B40
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_0A:
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num)
					{
					case 0:
					{
						num2 = (short)1583369760;
						short num3 = num2;
						num2 = (short)1195265568;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_B0;
						default:
							num2 = (short)1455947776;
							if (num2 != 0)
							{
							}
							num2 = (short)1501233153;
							if (num2 != 0)
							{
							}
							goto IL_B0;
						}
						break;
					}
					case 1:
					{
						num2 = (short)986120192;
						short num4 = num2;
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num2 = (short)1027997698;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_B0;
					}
					case 2:
						return;
					}
					goto IL_1C;
					IL_B0:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
					num2 = (short)39845889;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				propertyChangedEventHandler = this.PropertyChanged;
				num2 = (short)2033975296;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_0A:
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num)
					{
					case 0:
					{
						num2 = (short)1006492662;
						short num3 = num2;
						num2 = (short)121560054;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_AA;
						default:
							num2 = (short)1758789632;
							if (num2 != 0)
							{
							}
							goto IL_AA;
						}
						break;
					}
					case 1:
					{
						num2 = (short)852230144;
						short num4 = num2;
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num2 = (short)1003159554;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_AA;
					}
					case 2:
						return;
					}
					goto IL_1C;
					IL_AA:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
					num2 = (short)1541275649;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				num2 = (short)94830593;
				if (num2 != 0)
				{
				}
				propertyChangedEventHandler = this.PropertyChanged;
				num2 = (short)234815488;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00004A74 File Offset: 0x00002C74
		public void FirePropertyChanged(string name)
		{
			short num = (short)1542062080;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 1:
					num = (short)1497563137;
					if (num != 0)
					{
					}
					this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(name));
					num = (short)1283915778;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)564461568;
					short num3 = num;
					goto IL_CD;
				}
				}
				goto IL_30;
				IL_3B:
				num = (short)1559625729;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_CD:
				num = (short)563290037;
				short num4 = num;
				num = (short)447225781;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_3B;
				default:
					goto IL_101;
				}
				IL_30:
				if (this.PropertyChanged != null)
				{
					goto IL_3B;
				}
				goto IL_CD;
			}
			IL_101:
			num = (short)957153280;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00004B98 File Offset: 0x00002D98
		public object Clone()
		{
			short num = (short)350420993;
			if (num != 0)
			{
			}
			num = (short)853803008;
			short num2 = num;
			num = (short)943200352;
			short num3 = num;
			num = (short)2071533664;
			switch (num3 == num)
			{
			}
			num = (short)1849950208;
			if (num != 0)
			{
			}
			return (global::ASK.Core.AccessFieldValueRange)base.MemberwiseClone();
		}

		// Token: 0x0400000B RID: 11
		private int m_fieldID;

		// Token: 0x0400000C RID: 12
		private uint? m_min;

		// Token: 0x0400000D RID: 13
		private uint? m_max;

		// Token: 0x0400000E RID: 14
		private bool m_IsValid = true;

		// Token: 0x0400000F RID: 15
		private string m_ErrorMsg = string.Empty;
	}
}
