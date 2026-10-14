using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Motorola.CommonCPS.RadioManagement.ActivityBuilderLib
{
	// Token: 0x0200000B RID: 11
	public abstract class ItemBase : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00005264 File Offset: 0x00003464
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00005314 File Offset: 0x00003514
		[global::System.ComponentModel.Browsable(false)]
		public bool Expanded
		{
			get
			{
				short num = (short)1952691764;
				short num2 = num;
				num = (short)27506228;
				switch (num2 == num)
				{
				}
				num = (short)1542914049;
				if (num != 0)
				{
				}
				num = (short)1598423040;
				short num3 = num;
				num = (short)210042880;
				if (num != 0)
				{
				}
				return this._expanded;
			}
			set
			{
				int a_ = 19;
				short num = (short)528047374;
				short num2 = num;
				num = (short)2008636686;
				switch (num2 == num)
				{
				}
				num = (short)1563164672;
				if (num != 0)
				{
				}
				num = (short)1179648000;
				short num3 = num;
				num = (short)489029633;
				if (num != 0)
				{
				}
				this._expanded = value;
				this.NotifyChanged(new string[]
				{
					global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("\udca3횥즧쒩좫쮭풯", a_)
				});
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000022 RID: 34 RVA: 0x000053E8 File Offset: 0x000035E8
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00005498 File Offset: 0x00003698
		[global::System.ComponentModel.Browsable(false)]
		public bool Selected
		{
			get
			{
				short num = (short)378209609;
				short num2 = num;
				num = (short)42075465;
				switch (num2 == num)
				{
				}
				num = (short)1649410049;
				if (num != 0)
				{
				}
				num = (short)229310464;
				short num3 = num;
				num = (short)997654528;
				if (num != 0)
				{
				}
				return this._selected;
			}
			set
			{
				int a_ = 0;
				short num = (short)926652514;
				short num2 = num;
				num = (short)1882364002;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2146041856;
					if (num != 0)
					{
					}
					num = (short)1928200193;
					if (num != 0)
					{
					}
					num = (short)686030849;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_12F;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_AB;
							}
							continue;
						case 2:
						{
							num = (short)754122752;
							short num4 = num;
							this._selected = value;
							this.NotifyChanged(new string[]
							{
								global::Motorola.CommonCPS.RadioManagement.ActivityBuilderLib.SignatureHelper.b("\udc8eﾒﺚ列", a_)
							});
							num = (short)118423552;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_AB:
						if (this._selected == value)
						{
							break;
						}
						num = (short)76480514;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_12F:
					break;
				}
				}
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000024 RID: 36 RVA: 0x000055D8 File Offset: 0x000037D8
		// (remove) Token: 0x06000025 RID: 37 RVA: 0x0000570C File Offset: 0x0000390C
		[global::System.ComponentModel.Browsable(false)]
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num = (short)985505021;
				short num2 = num;
				num = (short)183213309;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_6E:
					num = (short)1869545473;
					if (num != 0)
					{
					}
					num = (short)1402667009;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)687865856;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_67;
					}
					break;
				}
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num3)
					{
					case 0:
						goto IL_FA;
					case 1:
						goto IL_AA;
					case 2:
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num = (short)1477574656;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AA;
					}
					goto IL_67;
					IL_AA:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
					num = (short)340852738;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_FA:
				num = (short)836632576;
				short num4 = num;
				return;
				IL_67:
				propertyChangedEventHandler = this.PropertyChanged;
				goto IL_6E;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num = (short)920242679;
				short num2 = num;
				num = (short)456116727;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_6E:
					num = (short)1703149569;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)149356544;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_67;
					}
					break;
				}
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler;
				for (;;)
				{
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
					switch (num3)
					{
					case 0:
						goto IL_CE;
					case 1:
						goto IL_84;
					case 2:
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num = (short)235732992;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_84;
					}
					goto IL_67;
					IL_84:
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.PropertyChanged, value2, propertyChangedEventHandler2);
					num = (short)688652290;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_CE:
				num = (short)58982400;
				short num4 = num;
				num = (short)1476001793;
				if (num != 0)
				{
				}
				return;
				IL_67:
				propertyChangedEventHandler = this.PropertyChanged;
				goto IL_6E;
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x0000583C File Offset: 0x00003A3C
		[global::System.ComponentModel.Browsable(false)]
		public virtual void NotifyChanged(params string[] propertyNames)
		{
			switch (0)
			{
			case 0:
				goto IL_6A;
			}
			short num;
			int num3;
			int num5;
			for (;;)
			{
				IL_0A:
				num = (short)556693446;
				short num2 = num;
				num = (short)1861842886;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1332936704;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						return;
					case 1:
					{
						num = (short)423297024;
						short num4 = num;
						goto IL_AE;
					}
					case 2:
						goto IL_AC;
					case 3:
					{
						if (num5 >= propertyNames.Length)
						{
							num = (short)1329987584;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						string propertyName = propertyNames[num5];
						this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
						num5++;
						num = (short)122421249;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_6A;
				}
				IL_AE:
				num = (short)1237450755;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_AC:
				goto IL_AE;
			}
			return;
			IL_6A:
			num5 = 0;
			num = (short)490995713;
			if (num != 0)
			{
			}
			num = (short)708509698;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000598C File Offset: 0x00003B8C
		protected virtual void OnPropertyChanged(global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			short num = (short)170460434;
			short num2 = num;
			num = (short)1312621842;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1631584256;
				if (num != 0)
				{
				}
				num = (short)77594625;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_10F;
					case 1:
						num = (short)1538129921;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A5;
						}
						continue;
					case 2:
					{
						num = (short)869990400;
						short num4 = num;
						this.PropertyChanged(this, e);
						num = (short)1175912448;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_A5:
					if (this.PropertyChanged == null)
					{
						break;
					}
					num = (short)534904834;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_10F:
				break;
			}
			}
		}

		// Token: 0x0400001D RID: 29
		private bool _expanded;

		// Token: 0x0400001E RID: 30
		private bool _selected;

		// Token: 0x0400001F RID: 31
		[global::System.ComponentModel.Browsable(false)]
		public string GuidId = global::System.Guid.NewGuid().ToString();
	}
}
