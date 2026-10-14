using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml.Serialization;

namespace AcpASKLib
{
	// Token: 0x0200000A RID: 10
	[global::System.Xml.Serialization.XmlType("Field")]
	[global::System.Serializable]
	public class AccessField : global::AcpASKLib.AccessElement, global::AcpASKLib.IAcpSecurity, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00003C9C File Offset: 0x00001E9C
		public AccessField()
		{
			int a_ = 16;
			base..ctor();
			this.mapID = global::AcpASKLib.SystemKeyLoadedEventArgs.b("ⱬ彮䅰䍲", a_);
			this.accessLevel = global::AcpASKLib.AccessLevelType.ReadOnly;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003CD4 File Offset: 0x00001ED4
		public AccessField(string name, string uiName, int id, global::AcpASKLib.AccessElementIDType elemId, global::AcpASKLib.AccessLevelType value)
		{
			int a_ = 6;
			base..ctor(name, uiName, id, elemId);
			this.mapID = global::AcpASKLib.SystemKeyLoadedEventArgs.b("≢啤坦奨", a_);
			this.accessLevel = value;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003D14 File Offset: 0x00001F14
		public AccessField(string name, string uiName, int id, string mapId, global::AcpASKLib.AccessElementIDType elemId, global::AcpASKLib.AccessLevelType value) : base(name, uiName, id, elemId)
		{
			this.mapID = mapId;
			this.accessLevel = value;
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00003D3C File Offset: 0x00001F3C
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00003DE8 File Offset: 0x00001FE8
		[global::System.Xml.Serialization.XmlAttribute]
		public string MapID
		{
			get
			{
				short num = (short)725260525;
				short num2 = num;
				num = (short)150837485;
				switch (num2 == num)
				{
				}
				num = (short)1710555137;
				if (num != 0)
				{
				}
				num = (short)948830208;
				if (num != 0)
				{
				}
				num = (short)1129447424;
				short num3 = num;
				return this.mapID;
			}
			set
			{
				short num = (short)506739554;
				short num2 = num;
				num = (short)236272482;
				switch (num2 == num)
				{
				}
				num = (short)1549926400;
				if (num != 0)
				{
				}
				num = (short)181534721;
				if (num != 0)
				{
				}
				num = (short)1753022464;
				short num3 = num;
				this.mapID = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00003E98 File Offset: 0x00002098
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00003F48 File Offset: 0x00002148
		[global::System.Xml.Serialization.XmlIgnore]
		public global::AcpASKLib.AccessLevelType AccessLevel
		{
			get
			{
				short num = (short)143372403;
				short num2 = num;
				num = (short)464236659;
				switch (num2 == num)
				{
				}
				num = (short)426901505;
				if (num != 0)
				{
				}
				num = (short)1968177152;
				if (num != 0)
				{
				}
				num = (short)1644036096;
				short num3 = num;
				return this.accessLevel;
			}
			set
			{
				int a_ = 9;
				short num = (short)996885512;
				short num2 = num;
				num = (short)680674312;
				switch (num2 == num)
				{
				}
				num = (short)582877185;
				if (num != 0)
				{
				}
				num = (short)817168384;
				if (num != 0)
				{
				}
				num = (short)528416768;
				short num3 = num;
				this.accessLevel = value;
				this.a(global::AcpASKLib.SystemKeyLoadedEventArgs.b("❥୧३५ᵭͯ㹱ᅳuᵷᙹ", a_));
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600001E RID: 30 RVA: 0x00004018 File Offset: 0x00002218
		// (remove) Token: 0x0600001F RID: 31 RVA: 0x00004154 File Offset: 0x00002354
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_90;
				}
				short num;
				int num4;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_0A:
					num = (short)1198584433;
					short num2 = num;
					num = (short)1508504177;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)977207296;
						if (num != 0)
						{
						}
						num = (short)422838272;
						short num3 = num;
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
						switch (num4)
						{
						case 0:
							return;
						case 1:
							goto IL_B1;
						case 2:
							if (propertyChangedEventHandler == propertyChangedEventHandler2)
							{
								num = (short)481165313;
								if (num != 0)
								{
								}
								num = (short)513343488;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_B1;
						}
						goto IL_90;
						IL_B1:
						propertyChangedEventHandler2 = propertyChangedEventHandler;
						global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
						break;
					}
					}
					num = (short)204472322;
					num4 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_90:
				propertyChangedEventHandler = this.PropertyChanged;
				num = (short)239075329;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_B5;
				}
				short num;
				int num4;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					IL_0A:
					num = (short)1092943873;
					if (num != 0)
					{
					}
					num = (short)1063862663;
					short num2 = num;
					num = (short)1419198855;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1304231936;
						short num3 = num;
						num = (short)1070530560;
						if (num != 0)
						{
						}
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
						switch (num4)
						{
						case 0:
							return;
						case 1:
							goto IL_D6;
						case 2:
							if (propertyChangedEventHandler == propertyChangedEventHandler2)
							{
								num = (short)2110652416;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D6;
						}
						goto IL_B5;
						IL_D6:
						propertyChangedEventHandler2 = propertyChangedEventHandler;
						global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
						break;
					}
					}
					num = (short)1893531650;
					num4 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_B5:
				propertyChangedEventHandler = this.PropertyChanged;
				num = (short)386334721;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000428C File Offset: 0x0000248C
		private void a(string A_0)
		{
			short num = (short)771031041;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
				{
					num = (short)1407958601;
					short num3 = num;
					num = (short)693878345;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9F;
					default:
						num = (short)896794624;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_7D;
						}
						continue;
					}
					break;
				}
				case 2:
					goto IL_9F;
				}
				IL_7D:
				if (this.PropertyChanged != null)
				{
					num = (short)1699151874;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_9F:
				num = (short)987168769;
				if (num != 0)
				{
				}
				num = (short)2078539776;
				short num4 = num;
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(A_0));
				num = (short)416743424;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x040000CF RID: 207
		private global::AcpASKLib.AccessLevelType accessLevel;

		// Token: 0x040000D0 RID: 208
		private string mapID;
	}
}
