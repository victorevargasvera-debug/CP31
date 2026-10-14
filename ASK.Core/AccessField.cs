using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml.Serialization;
using ASK.Interface;

namespace ASK.Core
{
	// Token: 0x02000006 RID: 6
	[global::System.Xml.Serialization.XmlType("Field")]
	[global::System.Serializable]
	public class AccessField : global::ASK.Core.AccessElement, global::ASK.Core.IAcpSecurity, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00003934 File Offset: 0x00001B34
		public AccessField()
		{
			int a_ = 12;
			base..ctor();
			this.mapID = global::ASK.Core.StatusMsg.b("े穉籋繍", a_);
			this.accessLevel = global::ASK.Interface.AccessLevelType.ReadOnly;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000396C File Offset: 0x00001B6C
		public AccessField(string name, string uiName, int id, global::ASK.Interface.AccessElementIDType elemId, global::ASK.Interface.AccessLevelType value)
		{
			int a_ = 15;
			base..ctor(name, uiName, id, elemId);
			this.mapID = global::ASK.Core.StatusMsg.b("੊経罎慐", a_);
			this.accessLevel = value;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000039AC File Offset: 0x00001BAC
		public AccessField(string name, string uiName, int id, string mapId, global::ASK.Interface.AccessElementIDType elemId, global::ASK.Interface.AccessLevelType value) : base(name, uiName, id, elemId)
		{
			this.mapID = mapId;
			this.accessLevel = value;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000039D4 File Offset: 0x00001BD4
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00003A88 File Offset: 0x00001C88
		[global::System.Xml.Serialization.XmlAttribute]
		public string MapID
		{
			get
			{
				short num = (short)1056767101;
				short num2 = num;
				num = (short)643366013;
				switch (num2 == num)
				{
				}
				num = (short)1000210433;
				if (num != 0)
				{
				}
				num = (short)1491009536;
				if (num != 0)
				{
				}
				num = (short)1396244480;
				short num3 = num;
				return this.mapID;
			}
			set
			{
				short num = (short)108172536;
				short num2 = num;
				num = (short)1015649528;
				switch (num2 == num)
				{
				}
				num = (short)1337196544;
				if (num != 0)
				{
				}
				num = (short)1171587073;
				if (num != 0)
				{
				}
				num = (short)1714421760;
				short num3 = num;
				this.mapID = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00003B38 File Offset: 0x00001D38
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00003BE8 File Offset: 0x00001DE8
		[global::System.Xml.Serialization.XmlIgnore]
		public global::ASK.Interface.AccessLevelType AccessLevel
		{
			get
			{
				short num = (short)132630707;
				short num2 = num;
				num = (short)1024444595;
				switch (num2 == num)
				{
				}
				num = (short)1570570241;
				if (num != 0)
				{
				}
				num = (short)1934032896;
				if (num != 0)
				{
				}
				num = (short)1936064512;
				short num3 = num;
				return this.accessLevel;
			}
			set
			{
				int a_ = 4;
				short num = (short)306169874;
				short num2 = num;
				num = (short)1098041362;
				switch (num2 == num)
				{
				}
				num = (short)1625227265;
				if (num != 0)
				{
				}
				num = (short)1134690304;
				if (num != 0)
				{
				}
				num = (short)1240334336;
				short num3 = num;
				this.accessLevel = value;
				this.a(global::ASK.Core.StatusMsg.b("Ŀ⅁❃⍅㭇㥉K⭍♏㝑㡓", a_));
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600001E RID: 30 RVA: 0x00003CB4 File Offset: 0x00001EB4
		// (remove) Token: 0x0600001F RID: 31 RVA: 0x00003DEC File Offset: 0x00001FEC
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
					switch (num)
					{
					case 0:
						return;
					case 1:
					{
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num2 = (short)1182203905;
							if (num2 != 0)
							{
							}
							num2 = (short)711786496;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_3A;
					}
					case 2:
						IL_38:
						goto IL_3A;
					}
					goto IL_1C;
					IL_3A:
					num2 = (short)165647174;
					short num3 = num2;
					num2 = (short)722637638;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_38;
					default:
					{
						num2 = (short)1690304512;
						if (num2 != 0)
						{
						}
						num2 = (short)1457389568;
						short num4 = num2;
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2 = propertyChangedEventHandler;
						global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
						num2 = (short)1700659201;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				propertyChangedEventHandler = this.PropertyChanged;
				num2 = (short)57868290;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				short num;
				int num2;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_0A:
					num = (short)596377601;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num = (short)2028142592;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_60;
					}
					case 2:
						IL_5E:
						goto IL_60;
					}
					goto IL_43;
					IL_60:
					num = (short)1614738751;
					short num3 = num;
					num = (short)667022655;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5E;
					default:
					{
						num = (short)1862664192;
						short num4 = num;
						num = (short)18874368;
						if (num != 0)
						{
						}
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2 = propertyChangedEventHandler;
						global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
						num = (short)682491905;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				return;
				IL_43:
				propertyChangedEventHandler = this.PropertyChanged;
				num = (short)1352073218;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003F24 File Offset: 0x00002124
		private void a(string A_0)
		{
			short num = (short)1056964610;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					goto IL_9C;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				if (this.PropertyChanged == null)
				{
					break;
				}
				num = (short)764170201;
				short num3 = num;
				num = (short)1937788889;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)930611200;
					if (num != 0)
					{
					}
					num = (short)1358561281;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_9C:
				num = (short)638058497;
				if (num != 0)
				{
				}
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(A_0));
				num = (short)1835532288;
				short num4 = num;
				num = (short)1633222656;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x04000008 RID: 8
		private global::ASK.Interface.AccessLevelType accessLevel;

		// Token: 0x04000009 RID: 9
		private string mapID;
	}
}
