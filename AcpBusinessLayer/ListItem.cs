using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Media.Imaging;
using AcpBusinessLayer.UndoRedo;

namespace AcpBusinessLayer
{
	// Token: 0x02000016 RID: 22
	public class ListItem : global::System.ComponentModel.INotifyPropertyChanged, global::System.IDisposable
	{
		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00029310 File Offset: 0x00027510
		// (set) Token: 0x0600021B RID: 539 RVA: 0x000293C0 File Offset: 0x000275C0
		internal global::AcpBusinessLayer.AcpListField parent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1110966273;
				if (num != 0)
				{
				}
				num = (short)1421321971;
				short num2 = num;
				num = (short)969516787;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1133903872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)185860096;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1168375809;
				if (num != 0)
				{
				}
				num = (short)671540206;
				short num2 = num;
				num = (short)527885294;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1169752064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)543096832;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00029470 File Offset: 0x00027670
		public ListItem(global::AcpBusinessLayer.AcpListField parent, string name) : this(parent, name, true, true, false)
		{
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00029488 File Offset: 0x00027688
		public ListItem(global::AcpBusinessLayer.AcpListField parent, string name, bool valid, bool visible) : this(parent, name, valid, visible, false)
		{
		}

		// Token: 0x0600021E RID: 542 RVA: 0x000294A4 File Offset: 0x000276A4
		public ListItem(global::AcpBusinessLayer.AcpListField parent, string name, bool valid, bool visible, bool temp)
		{
			this.a = name;
			this.b = valid;
			this.c = visible;
			this.parent = parent;
			this.Temporary = temp;
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600021F RID: 543 RVA: 0x000294DC File Offset: 0x000276DC
		// (set) Token: 0x06000220 RID: 544 RVA: 0x0002958C File Offset: 0x0002778C
		public virtual string ItemName
		{
			get
			{
				short num = (short)2125551060;
				short num2 = num;
				num = (short)786126292;
				switch (num2 == num)
				{
				}
				num = (short)1140129792;
				short num3 = num;
				num = (short)1625489409;
				if (num != 0)
				{
				}
				num = (short)1566310400;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				int a_ = 11;
				short num = (short)1502339825;
				short num2 = num;
				num = (short)207086321;
				switch (num2 == num)
				{
				}
				num = (short)863174656;
				short num3 = num;
				num = (short)1694367744;
				if (num != 0)
				{
				}
				num = (short)1928658945;
				if (num != 0)
				{
				}
				this.a = value;
				this.OnPropertyChanged(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("铜ꯞ蓠転ꯤ蛦蓨軪", a_));
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000221 RID: 545 RVA: 0x00029658 File Offset: 0x00027858
		// (set) Token: 0x06000222 RID: 546 RVA: 0x00029708 File Offset: 0x00027908
		public virtual bool ItemValidity
		{
			get
			{
				short num = (short)195267376;
				short num2 = num;
				num = (short)1628015408;
				switch (num2 == num)
				{
				}
				num = (short)2064711680;
				short num3 = num;
				num = (short)201981953;
				if (num != 0)
				{
				}
				num = (short)1429733376;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				int a_ = 10;
				short num = (short)1834680321;
				if (num != 0)
				{
				}
				num = (short)1824385667;
				short num2 = num;
				num = (short)1543563907;
				switch (num2 == num)
				{
				default:
				{
					num = (short)647626752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1151991808;
				if (num != 0)
				{
				}
				this.b = value;
				this.OnPropertyChanged(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("闛ꫝ藟迡닣蟥蓧菩裫蟭蓯诱", a_));
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000223 RID: 547 RVA: 0x000297D4 File Offset: 0x000279D4
		// (set) Token: 0x06000224 RID: 548 RVA: 0x000298A4 File Offset: 0x00027AA4
		public bool ItemVisibility
		{
			get
			{
				if (this.parent.SerializeItems)
				{
					short num = (short)312474107;
					short num2 = num;
					num = (short)1777203707;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)452067328;
						if (num != 0)
						{
						}
						num = (short)1875705856;
						short num3 = num;
						break;
					}
					}
					num = (short)1436155905;
					if (num != 0)
					{
					}
					return this.c;
				}
				return this.parent.GetItemVisibility(this);
			}
			set
			{
				if (this.parent.SerializeItems)
				{
					short num = (short)1613440171;
					short num2 = num;
					num = (short)2146968747;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1490550784;
						if (num != 0)
						{
						}
						num = (short)923795456;
						short num3 = num;
						num = (short)475660289;
						if (num != 0)
						{
						}
						break;
					}
					}
					this.c = value;
					return;
				}
				this.parent.SetItemVisibility(this, value);
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000225 RID: 549 RVA: 0x00029974 File Offset: 0x00027B74
		// (set) Token: 0x06000226 RID: 550 RVA: 0x00029A24 File Offset: 0x00027C24
		internal bool Temporary
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)682474251;
				short num2 = num;
				num = (short)1206237963;
				switch (num2 == num)
				{
				}
				num = (short)968753152;
				short num3 = num;
				num = (short)1796472832;
				if (num != 0)
				{
				}
				num = (short)709361665;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1291490333;
				short num2 = num;
				num = (short)1114346525;
				switch (num2 == num)
				{
				}
				num = (short)729219072;
				short num3 = num;
				num = (short)1112932353;
				if (num != 0)
				{
				}
				num = (short)353042432;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000227 RID: 551 RVA: 0x00029AD4 File Offset: 0x00027CD4
		// (set) Token: 0x06000228 RID: 552 RVA: 0x00029B84 File Offset: 0x00027D84
		public global::System.Windows.Media.Imaging.BitmapImage ItemImage
		{
			get
			{
				short num = (short)1938172256;
				short num2 = num;
				num = (short)211429728;
				switch (num2 == num)
				{
				}
				num = (short)192020480;
				short num3 = num;
				num = (short)1439956993;
				if (num != 0)
				{
				}
				num = (short)1906311168;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				int a_ = 12;
				short num = (short)374690908;
				short num2 = num;
				num = (short)315315292;
				switch (num2 == num)
				{
				}
				num = (short)1685454848;
				short num3 = num;
				num = (short)789970945;
				if (num != 0)
				{
				}
				num = (short)1763377152;
				if (num != 0)
				{
				}
				this.d = value;
				this.OnPropertyChanged(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("韝铟蟡解꿥藧诩诫语", a_));
			}
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00029C54 File Offset: 0x00027E54
		public override string ToString()
		{
			short num = (short)1897349197;
			short num2 = num;
			num = (short)1629765709;
			switch (num2 == num)
			{
			}
			num = (short)569442304;
			short num3 = num;
			num = (short)2140471297;
			if (num != 0)
			{
			}
			num = (short)1186529280;
			if (num != 0)
			{
			}
			return this.ItemName;
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600022A RID: 554 RVA: 0x00029D04 File Offset: 0x00027F04
		// (remove) Token: 0x0600022B RID: 555 RVA: 0x00029E34 File Offset: 0x00028034
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
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num2 = (short)2101936129;
							if (num2 != 0)
							{
							}
							num2 = (short)979042306;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_62;
					case 1:
						goto IL_62;
					case 2:
					{
						num2 = (short)2125648276;
						short num3 = num2;
						num2 = (short)1993658772;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_62;
						default:
							goto IL_10E;
						}
						break;
					}
					}
					goto IL_1C;
					IL_62:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.h, value2, propertyChangedEventHandler2);
					num2 = (short)871825408;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_10E:
				num2 = (short)577306624;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				num2 = (short)1383989248;
				short num4 = num2;
				propertyChangedEventHandler = this.h;
				num2 = (short)1905197057;
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
						num2 = (short)1476198401;
						if (num2 != 0)
						{
						}
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num2 = (short)860291074;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_63;
					case 1:
						goto IL_63;
					case 2:
					{
						num2 = (short)551973088;
						short num3 = num2;
						num2 = (short)2110091488;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_63;
						default:
							goto IL_113;
						}
						break;
					}
					}
					goto IL_1C;
					IL_63:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.h, value2, propertyChangedEventHandler2);
					num2 = (short)1418723328;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_113:
				num2 = (short)868220928;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				num2 = (short)672530432;
				short num4 = num2;
				propertyChangedEventHandler = this.h;
				num2 = (short)421527553;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00029F6C File Offset: 0x0002816C
		protected void OnPropertyChanged(string info)
		{
			short num = (short)1962737665;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1887240192;
				short num3 = num;
				num = (short)714487825;
				short num4 = num;
				num = (short)11679761;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
					num = (short)271384576;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						num = (short)2120089601;
						if (num != 0)
						{
						}
						this.h(this, new global::System.ComponentModel.PropertyChangedEventArgs(info));
						num = (short)1836515330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_A6;
						}
						continue;
					case 2:
						return;
					}
					IL_A6:
					if (this.h == null)
					{
						return;
					}
					num = (short)441778176;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0002A098 File Offset: 0x00028298
		protected virtual void Dispose(bool disposing)
		{
			int a_ = 13;
			short num = (short)1575682052;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
				{
					num = (short)932494615;
					short num3 = num;
					num = (short)1166589207;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)34209792;
						short num4 = num;
						num = (short)1204092928;
						if (num != 0)
						{
						}
						num = (short)453902337;
						if (num != 0)
						{
						}
						if (disposing)
						{
							num = (short)386465797;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_67;
					}
					}
					break;
				}
				case 2:
					goto IL_67;
				case 3:
					num = (short)740229121;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_46;
					}
					continue;
				case 5:
					global::AcpBusinessLayer.MemoryUtility.RemoveEventHandler(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("连鏠賢闤苦鯨鿪铬곮駰鋲鯴郶鳸鿺", a_), typeof(global::AcpBusinessLayer.ListItem), this);
					num = (short)1317863426;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_46:
				if (!this.e)
				{
					num = (short)1223753731;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_67:
				this.e = true;
				num = (short)2146893824;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600022E RID: 558 RVA: 0x0002A23C File Offset: 0x0002843C
		public void Dispose()
		{
			short num = (short)426988880;
			short num2 = num;
			num = (short)1288983888;
			switch (num2 == num)
			{
			}
			num = (short)1189347328;
			short num3 = num;
			num = (short)275644417;
			if (num != 0)
			{
			}
			num = (short)2134114304;
			if (num != 0)
			{
			}
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x04000067 RID: 103
		private string a;

		// Token: 0x04000068 RID: 104
		private bool b;

		// Token: 0x04000069 RID: 105
		private bool c;

		// Token: 0x0400006A RID: 106
		private global::System.Windows.Media.Imaging.BitmapImage d;

		// Token: 0x0400006B RID: 107
		private bool e;

		// Token: 0x0400006C RID: 108
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::AcpBusinessLayer.AcpListField f;

		// Token: 0x0400006D RID: 109
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool g;

		// Token: 0x0400006E RID: 110
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.ComponentModel.PropertyChangedEventHandler h;
	}
}
