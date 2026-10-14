using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using AcpCommonLib.Exceptions;

namespace AcpCommonLib.UndoRedo
{
	// Token: 0x0200002F RID: 47
	public class AcpUndoHelper : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x060001DC RID: 476 RVA: 0x000100A0 File Offset: 0x0000E2A0
		public AcpUndoHelper()
		{
			global::AcpCommonLib.UndoRedo.UndoManager.UndoHelper = this;
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060001DD RID: 477 RVA: 0x000100BC File Offset: 0x0000E2BC
		// (set) Token: 0x060001DE RID: 478 RVA: 0x0001016C File Offset: 0x0000E36C
		public bool CanUndo
		{
			get
			{
				short num = (short)419890564;
				short num2 = num;
				num = (short)517604740;
				switch (num2 == num)
				{
				}
				num = (short)1359872000;
				short num3 = num;
				num = (short)2078146560;
				if (num != 0)
				{
				}
				num = (short)1901461505;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.UndoRedo.UndoManager.CanUndo;
			}
			internal set
			{
				int a_ = 2;
				short num = (short)947036369;
				short num2 = num;
				num = (short)960798929;
				switch (num2 == num)
				{
				}
				num = (short)929562624;
				short num3 = num;
				num = (short)239468545;
				if (num != 0)
				{
				}
				num = (short)816906240;
				if (num != 0)
				{
				}
				this.FirePropertyChanged(global::AcpCommonLib.Exceptions.AcpSecurityException.b("럳韵雷꿹鋻髽濿", a_));
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060001DF RID: 479 RVA: 0x00010234 File Offset: 0x0000E434
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x000102E8 File Offset: 0x0000E4E8
		public bool CanRedo
		{
			get
			{
				short num = (short)464129290;
				short num2 = num;
				num = (short)1801260298;
				switch (num2 == num)
				{
				}
				num = (short)232914944;
				short num3 = num;
				num = (short)1315373057;
				if (num != 0)
				{
				}
				num = (short)762576896;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.UndoRedo.UndoManager.CanRedo;
			}
			internal set
			{
				int a_ = 4;
				short num = (short)981467137;
				if (num != 0)
				{
				}
				num = (short)412068212;
				short num2 = num;
				num = (short)600418676;
				switch (num2 == num)
				{
				default:
				{
					num = (short)309919744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)885522432;
				if (num != 0)
				{
				}
				this.FirePropertyChanged(global::AcpCommonLib.Exceptions.AcpSecurityException.b("뗵駷铹껻鯽擿洁", a_));
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x000103B0 File Offset: 0x0000E5B0
		internal global::System.Collections.Generic.IEnumerable<string> RedoDescriptions
		{
			get
			{
				short num = (short)2099806846;
				short num2 = num;
				num = (short)868778622;
				switch (num2 == num)
				{
				}
				num = (short)2017722368;
				short num3 = num;
				num = (short)363462657;
				if (num != 0)
				{
				}
				num = (short)55312384;
				if (num != 0)
				{
				}
				return new global::AcpCommonLib.UndoRedo.AcpUndoHelper.a(-2);
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x00010464 File Offset: 0x0000E664
		internal global::System.Collections.Generic.IEnumerable<string> UndoDescriptions
		{
			get
			{
				short num = (short)1124489230;
				short num2 = num;
				num = (short)1461147662;
				switch (num2 == num)
				{
				}
				num = (short)82771968;
				short num3 = num;
				num = (short)1849163777;
				if (num != 0)
				{
				}
				num = (short)701169664;
				if (num != 0)
				{
				}
				return new global::AcpCommonLib.UndoRedo.AcpUndoHelper.b(-2);
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060001E3 RID: 483 RVA: 0x00010514 File Offset: 0x0000E714
		// (remove) Token: 0x060001E4 RID: 484 RVA: 0x00010648 File Offset: 0x0000E848
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
						IL_E1:
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num2 = (short)1244921858;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_3A;
					case 1:
						goto IL_3A;
					case 2:
						goto IL_FF;
					}
					goto IL_1C;
					IL_3A:
					num2 = (short)377928880;
					short num3 = num2;
					num2 = (short)1050262704;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E1;
					case 1:
						break;
					default:
					{
						num2 = (short)257032192;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)185860096;
					if (num2 != 0)
					{
					}
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.a, value2, propertyChangedEventHandler2);
					num2 = (short)1529741312;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_FF:
				num2 = (short)556728321;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				propertyChangedEventHandler = this.a;
				num2 = (short)1260847105;
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
					switch (num)
					{
					case 0:
					{
						IL_107:
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
						if (propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num2 = (short)855048194;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_5F;
					}
					case 1:
						num2 = (short)831193089;
						if (num2 != 0)
						{
						}
						goto IL_5F;
					case 2:
						return;
					}
					goto IL_1C;
					IL_5F:
					num2 = (short)771555328;
					short num3 = num2;
					num2 = (short)1211418214;
					short num4 = num2;
					num2 = (short)679200358;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_107;
					default:
					{
						num2 = (short)1068498944;
						if (num2 != 0)
						{
						}
						global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2 = propertyChangedEventHandler;
						global::System.ComponentModel.PropertyChangedEventHandler value2 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.a, value2, propertyChangedEventHandler2);
						num2 = (short)1235812352;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				propertyChangedEventHandler = this.a;
				num2 = (short)1456472065;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x0001077C File Offset: 0x0000E97C
		public void FirePropertyChanged(string name)
		{
			short num = (short)1323565058;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_EF;
				case 1:
					this.a(this, new global::System.ComponentModel.PropertyChangedEventArgs(name));
					num = (short)1309212672;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				num = (short)1809033194;
				short num3 = num;
				num = (short)1777248234;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)332267521;
					if (num != 0)
					{
					}
					num = (short)1601503232;
					if (num != 0)
					{
					}
					if (this.a == null)
					{
						goto IL_F1;
					}
					break;
				}
				num = (short)952893441;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_EF:
			IL_F1:
			num = (short)1568407552;
			short num4 = num;
		}

		// Token: 0x04000098 RID: 152
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.ComponentModel.PropertyChangedEventHandler a;
	}
}
