using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;

namespace AcpASKLib
{
	// Token: 0x0200000C RID: 12
	[global::System.Serializable]
	public class AccessFieldValueRange : global::System.ICloneable, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x06000023 RID: 35 RVA: 0x000043B4 File Offset: 0x000025B4
		public AccessFieldValueRange()
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000043DC File Offset: 0x000025DC
		public AccessFieldValueRange(int field_id, uint? min, uint? max)
		{
			this.m_fieldID = field_id;
			this.m_min = min;
			this.m_max = max;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00004418 File Offset: 0x00002618
		// (set) Token: 0x06000026 RID: 38 RVA: 0x000044C8 File Offset: 0x000026C8
		public int FieldID
		{
			get
			{
				short num = (short)532702644;
				short num2 = num;
				num = (short)333735348;
				switch (num2 == num)
				{
				}
				num = (short)22020096;
				if (num != 0)
				{
				}
				num = (short)1186725889;
				if (num != 0)
				{
				}
				num = (short)1900347392;
				short num3 = num;
				return this.m_fieldID;
			}
			set
			{
				short num = (short)1007537161;
				short num2 = num;
				num = (short)132893705;
				switch (num2 == num)
				{
				}
				num = (short)1434714112;
				if (num != 0)
				{
				}
				num = (short)201064449;
				if (num != 0)
				{
				}
				num = (short)532021248;
				short num3 = num;
				this.m_fieldID = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00004578 File Offset: 0x00002778
		// (set) Token: 0x06000028 RID: 40 RVA: 0x00004624 File Offset: 0x00002824
		public uint? Minimum
		{
			get
			{
				short num = (short)1851410757;
				short num2 = num;
				num = (short)661276997;
				switch (num2 == num)
				{
				}
				num = (short)100335617;
				if (num != 0)
				{
				}
				num = (short)1313538048;
				if (num != 0)
				{
				}
				num = (short)715718656;
				short num3 = num;
				return this.m_min;
			}
			set
			{
				int a_ = 3;
				short num = (short)1165618856;
				short num2 = num;
				num = (short)191033000;
				switch (num2 == num)
				{
				}
				num = (short)1493696512;
				if (num != 0)
				{
				}
				num = (short)1668874241;
				if (num != 0)
				{
				}
				num = (short)409141248;
				short num3 = num;
				this.m_min = value;
				this.FirePropertyChanged(global::AcpASKLib.SystemKeyLoadedEventArgs.b("ⵟୡ੣ཥէὩū", a_));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000029 RID: 41 RVA: 0x000046F0 File Offset: 0x000028F0
		// (set) Token: 0x0600002A RID: 42 RVA: 0x000047A0 File Offset: 0x000029A0
		public uint? Maximum
		{
			get
			{
				short num = (short)343049568;
				short num2 = num;
				num = (short)1960215904;
				switch (num2 == num)
				{
				}
				num = (short)425984000;
				if (num != 0)
				{
				}
				num = (short)848887809;
				if (num != 0)
				{
				}
				num = (short)1802960896;
				short num3 = num;
				return this.m_max;
			}
			set
			{
				int a_ = 2;
				short num = (short)278411907;
				short num2 = num;
				num = (short)1915370115;
				switch (num2 == num)
				{
				}
				num = (short)1708654593;
				if (num != 0)
				{
				}
				num = (short)803471360;
				if (num != 0)
				{
				}
				num = (short)236912640;
				short num3 = num;
				this.m_max = value;
				this.FirePropertyChanged(global::AcpASKLib.SystemKeyLoadedEventArgs.b("቞`᭢౤੦ᱨ٪", a_));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00004870 File Offset: 0x00002A70
		// (set) Token: 0x0600002C RID: 44 RVA: 0x00004920 File Offset: 0x00002B20
		public bool IsValid
		{
			get
			{
				short num = (short)636157953;
				if (num != 0)
				{
				}
				num = (short)1653196067;
				short num2 = num;
				num = (short)39240995;
				switch (num2 == num)
				{
				}
				num = (short)1389756416;
				if (num != 0)
				{
				}
				num = (short)177537024;
				short num3 = num;
				return this.m_IsValid;
			}
			set
			{
				int a_ = 3;
				short num = (short)370320653;
				short num2 = num;
				num = (short)1861657869;
				switch (num2 == num)
				{
				}
				num = (short)232062977;
				if (num != 0)
				{
				}
				num = (short)1847787520;
				if (num != 0)
				{
				}
				num = (short)1862598656;
				short num3 = num;
				this.m_IsValid = value;
				this.FirePropertyChanged(global::AcpASKLib.SystemKeyLoadedEventArgs.b("⥟ᅡ㉣ݥѧͩ࡫", a_));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600002D RID: 45 RVA: 0x000049EC File Offset: 0x00002BEC
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00004AA0 File Offset: 0x00002CA0
		public string ErrorMsg
		{
			get
			{
				short num = (short)1605977976;
				short num2 = num;
				num = (short)427640696;
				switch (num2 == num)
				{
				}
				num = (short)1991049217;
				if (num != 0)
				{
				}
				num = (short)1374814208;
				if (num != 0)
				{
				}
				num = (short)820379648;
				short num3 = num;
				return this.m_ErrorMsg;
			}
			set
			{
				int a_ = 14;
				short num = (short)1624623502;
				short num2 = num;
				num = (short)755616142;
				switch (num2 == num)
				{
				}
				num = (short)47513601;
				if (num != 0)
				{
				}
				num = (short)455802880;
				if (num != 0)
				{
				}
				num = (short)1995702272;
				short num3 = num;
				this.m_ErrorMsg = value;
				this.FirePropertyChanged(global::AcpASKLib.SystemKeyLoadedEventArgs.b("⹪ὬᵮṰŲ㡴ѶṸ", a_));
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600002F RID: 47 RVA: 0x00004B70 File Offset: 0x00002D70
		// (remove) Token: 0x06000030 RID: 48 RVA: 0x00004CA0 File Offset: 0x00002EA0
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
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num)
					{
					case 0:
					{
						if (propertyChangedEventHandler != propertyChangedEventHandler2)
						{
							goto IL_3A;
						}
						num2 = (short)1107623937;
						if (num2 != 0)
						{
						}
						num2 = (short)1242768481;
						short num3 = num2;
						num2 = (short)96543841;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
						{
							num2 = (short)368967680;
							short num4 = num2;
							num2 = (short)1017970688;
							if (num2 != 0)
							{
							}
							num2 = (short)1694367745;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 1:
						return;
					case 2:
						goto IL_3A;
					}
					goto IL_1C;
					IL_3A:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
					num2 = (short)1370226688;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				propertyChangedEventHandler = this.PropertyChanged;
				num2 = (short)897646594;
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
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num)
					{
					case 0:
					{
						if (propertyChangedEventHandler != propertyChangedEventHandler2)
						{
							goto IL_61;
						}
						num2 = (short)2124085787;
						short num3 = num2;
						num2 = (short)1635449371;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
						{
							num2 = (short)1389625344;
							short num4 = num2;
							num2 = (short)671481856;
							if (num2 != 0)
							{
							}
							num2 = (short)1370292225;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 1:
						return;
					case 2:
						goto IL_61;
					}
					goto IL_1C;
					IL_61:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
					num2 = (short)1747779584;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				num2 = (short)1456144385;
				if (num2 != 0)
				{
				}
				propertyChangedEventHandler = this.PropertyChanged;
				num2 = (short)1703018498;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00004DD8 File Offset: 0x00002FD8
		public void FirePropertyChanged(string name)
		{
			short num = (short)1483079682;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)222175761;
				short num3 = num;
				num = (short)1528177169;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2136080384;
					short num4 = num;
					num = (short)710541312;
					if (num != 0)
					{
					}
					num = (short)851509249;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_ED;
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_CB;
						}
						continue;
					}
					IL_CB:
					if (this.PropertyChanged != null)
					{
						num = (short)856948736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				}
				IL_ED:
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(name));
				num = (short)672530433;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00004F00 File Offset: 0x00003100
		public object Clone()
		{
			short num = (short)894763009;
			if (num != 0)
			{
			}
			num = (short)1814158389;
			short num2 = num;
			num = (short)1794497589;
			switch (num2 == num)
			{
			}
			num = (short)998572032;
			if (num != 0)
			{
			}
			num = (short)395575296;
			short num3 = num;
			return (global::AcpASKLib.AccessFieldValueRange)base.MemberwiseClone();
		}

		// Token: 0x040000D2 RID: 210
		private int m_fieldID;

		// Token: 0x040000D3 RID: 211
		private uint? m_min;

		// Token: 0x040000D4 RID: 212
		private uint? m_max;

		// Token: 0x040000D5 RID: 213
		private bool m_IsValid = true;

		// Token: 0x040000D6 RID: 214
		private string m_ErrorMsg = string.Empty;
	}
}
