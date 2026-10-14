using System;
using System.Runtime.CompilerServices;
using System.Threading;
using AcpBusinessLayer.UndoRedo;

namespace AcpBusinessLayer
{
	// Token: 0x0200002A RID: 42
	public class DifferenceCount : global::System.IDisposable
	{
		// Token: 0x06000314 RID: 788 RVA: 0x0003C034 File Offset: 0x0003A234
		internal DifferenceCount()
		{
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0003C048 File Offset: 0x0003A248
		internal DifferenceCount(int count)
		{
			int a_ = 6;
			base..ctor();
			if (count < 0)
			{
				throw new global::System.ArgumentOutOfRangeException(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("믗뗙꧛냝铟", a_));
			}
			this.a = count;
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000316 RID: 790 RVA: 0x0003C088 File Offset: 0x0003A288
		// (remove) Token: 0x06000317 RID: 791 RVA: 0x0003C1C0 File Offset: 0x0003A3C0
		public event global::AcpBusinessLayer.DifferenceCountChangedEventHandler CountChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_45;
				}
				short num;
				global::AcpBusinessLayer.DifferenceCountChangedEventHandler differenceCountChangedEventHandler;
				for (;;)
				{
					IL_0A:
					num = (short)2076966912;
					short num2 = num;
					int num3;
					global::AcpBusinessLayer.DifferenceCountChangedEventHandler differenceCountChangedEventHandler2;
					switch (num3)
					{
					case 0:
						return;
					case 1:
						goto IL_D6;
					case 2:
						if (differenceCountChangedEventHandler == differenceCountChangedEventHandler2)
						{
							num = (short)2123497472;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D6;
					}
					goto IL_45;
					IL_D6:
					differenceCountChangedEventHandler2 = differenceCountChangedEventHandler;
					global::AcpBusinessLayer.DifferenceCountChangedEventHandler value2 = (global::AcpBusinessLayer.DifferenceCountChangedEventHandler)global::System.Delegate.Combine(differenceCountChangedEventHandler2, value);
					differenceCountChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::AcpBusinessLayer.DifferenceCountChangedEventHandler>(ref this.c, value2, differenceCountChangedEventHandler2);
					num = (short)1411645442;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_45:
				differenceCountChangedEventHandler = this.c;
				num = (short)94391973;
				short num4 = num;
				num = (short)1596477093;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_0A;
				default:
				{
					num = (short)1867251713;
					if (num != 0)
					{
					}
					num = (short)993722368;
					if (num != 0)
					{
					}
					num = (short)1559560193;
					int num3 = (int)((global::System.IntPtr)num);
					goto IL_0A;
				}
				}
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_46;
				}
				short num;
				global::AcpBusinessLayer.DifferenceCountChangedEventHandler differenceCountChangedEventHandler;
				for (;;)
				{
					IL_0A:
					num = (short)93192192;
					short num2 = num;
					int num3;
					global::AcpBusinessLayer.DifferenceCountChangedEventHandler differenceCountChangedEventHandler2;
					switch (num3)
					{
					case 0:
						return;
					case 1:
						goto IL_AF;
					case 2:
						if (differenceCountChangedEventHandler == differenceCountChangedEventHandler2)
						{
							num = (short)1185021952;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AF;
					}
					goto IL_46;
					IL_AF:
					num = (short)1323433985;
					if (num != 0)
					{
					}
					differenceCountChangedEventHandler2 = differenceCountChangedEventHandler;
					global::AcpBusinessLayer.DifferenceCountChangedEventHandler value2 = (global::AcpBusinessLayer.DifferenceCountChangedEventHandler)global::System.Delegate.Remove(differenceCountChangedEventHandler2, value);
					differenceCountChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::AcpBusinessLayer.DifferenceCountChangedEventHandler>(ref this.c, value2, differenceCountChangedEventHandler2);
					num = (short)574291970;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_46:
				differenceCountChangedEventHandler = this.c;
				num = (short)1991068689;
				short num4 = num;
				num = (short)68832273;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_0A;
				default:
				{
					num = (short)1914699776;
					if (num != 0)
					{
					}
					num = (short)2038300673;
					int num3 = (int)((global::System.IntPtr)num);
					goto IL_0A;
				}
				}
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000318 RID: 792 RVA: 0x0003C2F8 File Offset: 0x0003A4F8
		internal int Value
		{
			get
			{
				short num = (short)470511578;
				short num2 = num;
				num = (short)1382641626;
				switch (num2 == num)
				{
				}
				num = (short)1373765633;
				if (num != 0)
				{
				}
				num = (short)2048917504;
				if (num != 0)
				{
				}
				num = (short)777388032;
				short num3 = num;
				return this.a;
			}
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0003C3A4 File Offset: 0x0003A5A4
		internal void Increment(string name)
		{
			switch (0)
			{
			case 0:
				goto IL_46;
			}
			short num;
			for (;;)
			{
				IL_0A:
				num = (short)933822464;
				short num2 = num;
				int num3;
				switch (num3)
				{
				case 0:
					return;
				case 1:
					num = (short)126025729;
					if (num != 0)
					{
					}
					if (this.c != null)
					{
						num = (short)1871839234;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					this.c(this, new global::AcpBusinessLayer.DifferenceCountChangedEventArgs(name, global::AcpBusinessLayer.DifferenceCountChangedAction.Increment));
					num = (short)2039676928;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_46;
			}
			return;
			IL_46:
			this.a++;
			num = (short)1520138831;
			short num4 = num;
			num = (short)462191183;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			default:
			{
				num = (short)1896153088;
				if (num != 0)
				{
				}
				num = (short)54853633;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0003C4DC File Offset: 0x0003A6DC
		internal void Decrement(string name)
		{
			switch (0)
			{
			case 0:
				goto IL_45;
			}
			short num;
			for (;;)
			{
				IL_0A:
				num = (short)368443392;
				short num2 = num;
				int num3;
				switch (num3)
				{
				case 0:
					return;
				case 1:
					if (this.c != null)
					{
						num = (short)747765762;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					this.c(this, new global::AcpBusinessLayer.DifferenceCountChangedEventArgs(name, global::AcpBusinessLayer.DifferenceCountChangedAction.Decrement));
					num = (short)2090991616;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_45;
			}
			return;
			IL_45:
			num = (short)298975233;
			if (num != 0)
			{
			}
			this.a--;
			num = (short)1747006256;
			short num4 = num;
			num = (short)1230517040;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			default:
			{
				num = (short)726663168;
				if (num != 0)
				{
				}
				num = (short)1642725377;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0003C610 File Offset: 0x0003A810
		internal void Reset(string name)
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			short num;
			for (;;)
			{
				IL_0A:
				num = (short)1271463936;
				short num2 = num;
				int num3;
				switch (num3)
				{
				case 0:
					goto IL_F9;
				case 1:
					if (this.c != null)
					{
						num = (short)949878786;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FB;
				case 2:
					this.c(this, new global::AcpBusinessLayer.DifferenceCountChangedEventArgs(name, global::AcpBusinessLayer.DifferenceCountChangedAction.Reset));
					num = (short)294453248;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_44;
			}
			IL_F9:
			IL_FB:
			num = (short)1955921921;
			if (num != 0)
			{
			}
			return;
			IL_44:
			this.a = 0;
			num = (short)246519210;
			short num4 = num;
			num = (short)1809225130;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			default:
			{
				num = (short)3145728;
				if (num != 0)
				{
				}
				num = (short)765001729;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0003C740 File Offset: 0x0003A940
		protected virtual void Dispose(bool disposing)
		{
			int a_ = 2;
			short num = (short)148570112;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)256049153;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_6D;
					}
					continue;
				case 1:
					return;
				case 2:
				{
					num = (short)1423663449;
					short num3 = num;
					num = (short)926179673;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1207697408;
						if (num != 0)
						{
						}
						if (disposing)
						{
							num = (short)981729283;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8E;
					}
					break;
				}
				case 3:
				{
					num = (short)1360986112;
					short num4 = num;
					global::AcpBusinessLayer.MemoryUtility.RemoveEventHandler(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("韓맕귗듙꣛鷝裟菡諣臥跧軩", a_), typeof(global::AcpBusinessLayer.DifferenceCount), this);
					num = (short)972357637;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					num = (short)1888616450;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_8E;
				}
				IL_6D:
				if (!this.b)
				{
					num = (short)268566532;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_8E:
				this.b = true;
				num = (short)306905089;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0003C8E4 File Offset: 0x0003AAE4
		public void Dispose()
		{
			short num = (short)1004487817;
			short num2 = num;
			num = (short)1879327881;
			switch (num2 == num)
			{
			}
			num = (short)425132033;
			if (num != 0)
			{
			}
			num = (short)366149632;
			if (num != 0)
			{
			}
			num = (short)1739980800;
			short num3 = num;
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x040000AB RID: 171
		private int a;

		// Token: 0x040000AC RID: 172
		private bool b;

		// Token: 0x040000AD RID: 173
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::AcpBusinessLayer.DifferenceCountChangedEventHandler c;
	}
}
