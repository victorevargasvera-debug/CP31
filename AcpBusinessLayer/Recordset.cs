using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using System.Xml;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using AcpCommonResources;
using AcpUtility;

namespace AcpBusinessLayer
{
	// Token: 0x02000037 RID: 55
	[global::System.Diagnostics.DebuggerDisplay("Name={RecordsetName}, Count={Count}")]
	public abstract class Recordset : global::System.Collections.ObjectModel.ObservableCollection<global::AcpBusinessLayer.FeatureNode>, global::AcpCommonLib.IAcpRecordset, global::AcpCommonLib.IAcpConstraints, global::AcpCommonLib.IAcpCommon, global::System.IDisposable, global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x060003CC RID: 972 RVA: 0x0004E8A0 File Offset: 0x0004CAA0
		static Recordset()
		{
			short num = (short)1844841469;
			short num2 = num;
			num = (short)42667005;
			switch (num2 == num)
			{
			default:
			{
				num = (short)510263296;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)710082561;
			if (num != 0)
			{
			}
			num = (short)1005977600;
			if (num != 0)
			{
			}
			global::AcpBusinessLayer.Recordset.b = new global::System.Collections.Generic.Dictionary<global::System.Guid, int>();
			global::AcpBusinessLayer.Recordset.ParentNodeBeingAdded = false;
			global::AcpUtility.AssemblyValidator.IsCallerAuthorized();
		}

		// Token: 0x060003CD RID: 973
		public abstract global::AcpBusinessLayer.FeatureNode CreateDefaultRecord();

		// Token: 0x060003CE RID: 974 RVA: 0x0004E960 File Offset: 0x0004CB60
		public global::AcpBusinessLayer.FeatureNode CreateDefaultRecordHelper()
		{
			short num = (short)163708929;
			int num2 = (int)((global::System.IntPtr)num);
			global::AcpBusinessLayer.FeatureNode result;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1658126336;
					short num3 = num;
					global::AcpCommonLib.ConstraintManager.Resume();
					num = (short)174653441;
					if (num != 0)
					{
					}
					num = (short)1387790338;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 2:
					return result;
				}
				IL_31:
				bool flag = global::AcpCommonLib.ConstraintManager.Suspend();
				result = this.CreateDefaultRecord();
				if (!flag)
				{
					break;
				}
				num = (short)300015837;
				short num4 = num;
				num = (short)96067805;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return result;
				default:
					num = (short)266469376;
					if (num != 0)
					{
					}
					num = (short)1793130496;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			return result;
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060003CF RID: 975 RVA: 0x0004EA80 File Offset: 0x0004CC80
		internal global::AcpBusinessLayer.DifferenceCount DiffCount
		{
			get
			{
				short num = (short)1220001698;
				short num2 = num;
				num = (short)1964097442;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2043740160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)77201408;
				if (num != 0)
				{
				}
				num = (short)817889281;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0004EB30 File Offset: 0x0004CD30
		protected Recordset()
		{
			this.l = true;
			base..ctor();
			this.c();
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x0004EB50 File Offset: 0x0004CD50
		protected Recordset(string name) : this(name, false, false, null)
		{
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x0004EB68 File Offset: 0x0004CD68
		protected Recordset(string name, string keySeed) : this(name, false, false, keySeed)
		{
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x0004EB80 File Offset: 0x0004CD80
		protected Recordset(string name, bool canBeEmpty, bool positionBased) : this(name, canBeEmpty, positionBased, null)
		{
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x0004EB98 File Offset: 0x0004CD98
		protected Recordset(string name, bool canBeEmpty, bool positionBased, string keySeed) : this(name, canBeEmpty, positionBased, false, keySeed)
		{
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x0004EBB4 File Offset: 0x0004CDB4
		protected Recordset(string name, bool canBeEmpty, bool positionBased, bool hasTemplateNode) : this(name, canBeEmpty, positionBased, hasTemplateNode, null)
		{
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x0004EBD0 File Offset: 0x0004CDD0
		protected Recordset(string name, bool canBeEmpty, bool positionBased, bool hasTemplateNode, string keySeed)
		{
			this.l = true;
			base..ctor();
			this.UIName = name;
			this.RecordsetName = name;
			this.CanBeEmpty = canBeEmpty;
			this.PositionBased = positionBased;
			this.Max = 1024;
			this.c = base.GetType().GUID;
			this.KeySeed = keySeed;
			this.lastId = 0;
			this.CumulativeMax = 0;
			if (!global::AcpCommonLib.FeatureManager.IsInitialized)
			{
				this.DefaultRecordCount = 0;
			}
			if (this.CanBeEmpty && !global::AcpCommonLib.AppInfoManager.InitializingDefaultDoc)
			{
				this.Min = 0;
			}
			else
			{
				this.Min = 1;
				this.AddRecord(this.CreateDefaultRecordHelper());
				this._IsEmpty = false;
			}
			while (this.Count < this.DefaultRecordCount)
			{
				this.AddRecord(this.CreateDefaultRecordHelper());
			}
			if (!hasTemplateNode)
			{
				if (this.Count != 0)
				{
					goto IL_EA;
				}
			}
			this.CalculateHiddenStatic = true;
			this.TemplateNode = this.CreateDefaultRecord();
			IL_EA:
			this.c();
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x0004ECD0 File Offset: 0x0004CED0
		private void c()
		{
			short num = (short)59450006;
			short num2 = num;
			num = (short)601170582;
			switch (num2 == num)
			{
			default:
			{
				num = (short)784465920;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)349503489;
			if (num != 0)
			{
			}
			num = (short)230490112;
			if (num != 0)
			{
			}
			this.a = new global::AcpBusinessLayer.DifferenceCount();
			this.a.CountChanged += this.a;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x0004ED9C File Offset: 0x0004CF9C
		private void a(object A_0, global::AcpBusinessLayer.DifferenceCountChangedEventArgs A_1)
		{
			int a_ = 14;
			short num = (short)72351745;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_75;
			}
			int num2;
			for (;;)
			{
				IL_3B:
				switch (num2)
				{
				case 0:
					return;
				case 1:
					if (this.ParentSection != null)
					{
						num = (short)334757894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_157;
				case 2:
					goto IL_270;
				case 3:
					if (this.ParentSection != null)
					{
						num = (short)701890565;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					num = (short)865730572;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)929890304;
					short num3 = num;
					((global::AcpBusinessLayer.FeatureSection)this.ParentSection).DiffCount.Decrement(A_1.Name);
					num = (short)1351155712;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					goto IL_1C9;
				case 7:
					if (A_1.Action == global::AcpBusinessLayer.DifferenceCountChangedAction.Decrement)
					{
						num = (short)427360264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 8:
					num = (short)1520500747;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)517210115;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					num = (short)1258527292;
					short num4 = num;
					num = (short)2029165116;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_270;
					default:
						num = (short)104136704;
						if (num != 0)
						{
						}
						if (A_1.Action == global::AcpBusinessLayer.DifferenceCountChangedAction.Increment)
						{
							num = (short)778371076;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_157;
					}
					break;
				}
				case 11:
					if (this.DiffCount.Value == 0)
					{
						num = (short)841547785;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 12:
					if (this.DiffCount.Value == 1)
					{
						num = (short)1038614530;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_157;
				}
				goto IL_75;
				IL_157:
				num = (short)1129775111;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_270:
				num = (short)806879233;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1C9:
			((global::AcpBusinessLayer.FeatureSection)this.ParentSection).DiffCount.Increment(A_1.Name);
			return;
			IL_75:
			this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("꣟菡韣ꋥ臧賩諫鷭", a_)));
			num = (short)1368850442;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_3B;
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x0004F078 File Offset: 0x0004D278
		internal static void ResetMaxPools()
		{
			short num = (short)1339150072;
			short num2 = num;
			num = (short)1376177912;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2048327680;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)462159872;
			if (num != 0)
			{
			}
			num = (short)1993015297;
			if (num != 0)
			{
			}
			global::AcpBusinessLayer.Recordset.b.Clear();
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060003DA RID: 986 RVA: 0x0004F130 File Offset: 0x0004D330
		// (set) Token: 0x060003DB RID: 987 RVA: 0x0004F1E0 File Offset: 0x0004D3E0
		public bool LastRecordInOperation
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2040364261;
				short num2 = num;
				num = (short)876575973;
				switch (num2 == num)
				{
				default:
				{
					num = (short)648806400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)273088513;
				if (num != 0)
				{
				}
				num = (short)1657733120;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			internal set
			{
				short num = (short)1144928793;
				short num2 = num;
				num = (short)111622681;
				switch (num2 == num)
				{
				default:
				{
					num = (short)48300032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2125070336;
				if (num != 0)
				{
				}
				num = (short)1255473153;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060003DC RID: 988 RVA: 0x0004F294 File Offset: 0x0004D494
		// (set) Token: 0x060003DD RID: 989 RVA: 0x0004F344 File Offset: 0x0004D544
		public bool NotFirstNoLastAddOnMultiAddOperation
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1280117254;
				short num2 = num;
				num = (short)1217464838;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1691418624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1820131329;
				if (num != 0)
				{
				}
				num = (short)960626688;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			internal set
			{
				short num = (short)81692481;
				short num2 = num;
				num = (short)1635682113;
				switch (num2 == num)
				{
				default:
				{
					num = (short)477495296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)759889921;
				if (num != 0)
				{
				}
				num = (short)1928462336;
				if (num != 0)
				{
				}
				this.f = value;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060003DE RID: 990 RVA: 0x0004F3F4 File Offset: 0x0004D5F4
		// (set) Token: 0x060003DF RID: 991 RVA: 0x0004F4A4 File Offset: 0x0004D6A4
		protected int Id
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1758310971;
				short num2 = num;
				num = (short)762032699;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2042101760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)303693825;
				if (num != 0)
				{
				}
				num = (short)79560704;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)733741057;
				if (num != 0)
				{
				}
				num = (short)24444928;
				short num2 = num;
				num = (short)122686623;
				short num3 = num;
				num = (short)262474911;
				switch (num3 == num)
				{
				}
				num = (short)444923904;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060003E0 RID: 992 RVA: 0x0004F554 File Offset: 0x0004D754
		// (set) Token: 0x060003E1 RID: 993 RVA: 0x0004F604 File Offset: 0x0004D804
		public global::AcpBusinessLayer.ReferencedNodeCollection KeysToNode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2002845696;
				short num2 = num;
				num = (short)1720943501;
				short num3 = num;
				num = (short)1586922381;
				switch (num3 == num)
				{
				}
				num = (short)1472987136;
				if (num != 0)
				{
				}
				num = (short)169869313;
				if (num != 0)
				{
				}
				return this.h;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1296891904;
				short num2 = num;
				num = (short)1885995009;
				if (num != 0)
				{
				}
				num = (short)165127262;
				short num3 = num;
				num = (short)1014080606;
				switch (num3 == num)
				{
				}
				num = (short)1534459904;
				if (num != 0)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x0004F6B0 File Offset: 0x0004D8B0
		internal void InitKeysToNode()
		{
			short num = (short)530317312;
			short num2 = num;
			num = (short)143156121;
			short num3 = num;
			num = (short)523789209;
			switch (num3 == num)
			{
			}
			num = (short)507183105;
			if (num != 0)
			{
			}
			num = (short)1608908800;
			if (num != 0)
			{
			}
			this.HasKeyField = true;
			this.KeysToNode = new global::AcpBusinessLayer.ReferencedNodeCollection(this);
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x0004F76C File Offset: 0x0004D96C
		// (set) Token: 0x060003E4 RID: 996 RVA: 0x0004F81C File Offset: 0x0004DA1C
		public string KeySeed
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)252706816;
				short num2 = num;
				num = (short)1514657428;
				short num3 = num;
				num = (short)850515604;
				switch (num3 == num)
				{
				}
				num = (short)1589968897;
				if (num != 0)
				{
				}
				num = (short)1909325824;
				if (num != 0)
				{
				}
				return this.i;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1427111936;
				short num2 = num;
				num = (short)704732347;
				short num3 = num;
				num = (short)330128571;
				switch (num3 == num)
				{
				}
				num = (short)1924923393;
				if (num != 0)
				{
				}
				num = (short)482869248;
				if (num != 0)
				{
				}
				this.i = value;
			}
		}

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x060003E5 RID: 997 RVA: 0x0004F8D0 File Offset: 0x0004DAD0
		// (remove) Token: 0x060003E6 RID: 998 RVA: 0x0004FA08 File Offset: 0x0004DC08
		public event global::System.EventHandler ReferenceKeyChanged
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
				global::System.EventHandler eventHandler;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_39;
					case 1:
						return;
					case 2:
					{
						num2 = (short)1685716993;
						if (num2 != 0)
						{
						}
						global::System.EventHandler eventHandler2;
						if (eventHandler == eventHandler2)
						{
							num2 = (short)948109313;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_39;
					}
					}
					goto IL_1C;
					IL_39:
					num2 = (short)1308884992;
					short num3 = num2;
					num2 = (short)1667559659;
					short num4 = num2;
					num2 = (short)48689387;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num2 = (short)584777728;
						if (num2 != 0)
						{
						}
						global::System.EventHandler eventHandler2 = eventHandler;
						global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.j, value2, eventHandler2);
						num2 = (short)1744961538;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				eventHandler = this.j;
				num2 = (short)352256000;
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
				global::System.EventHandler eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_39;
					case 1:
						return;
					case 2:
					{
						global::System.EventHandler eventHandler2;
						if (eventHandler == eventHandler2)
						{
							num2 = (short)574750721;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_39;
					}
					}
					goto IL_1C;
					IL_39:
					num2 = (short)33685504;
					short num3 = num2;
					num2 = (short)1071342674;
					short num4 = num2;
					num2 = (short)1456038994;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num2 = (short)982384640;
						if (num2 != 0)
						{
						}
						global::System.EventHandler eventHandler2 = eventHandler;
						global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.j, value2, eventHandler2);
						num2 = (short)985595905;
						if (num2 != 0)
						{
						}
						num2 = (short)906362882;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				eventHandler = this.j;
				num2 = (short)1075642368;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x0004FB40 File Offset: 0x0004DD40
		internal void RaiseReferenceKeyChanged(global::AcpBusinessLayer.FeatureNode node)
		{
			short num = (short)1672347648;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					continue;
				case 1:
					if (this.j != null)
					{
						num = (short)696451075;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					num = (short)859766785;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)797310981;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					return;
				case 5:
					if (base.Contains(node))
					{
						num = (short)685244422;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 6:
				{
					num = (short)1056402169;
					short num3 = num;
					num = (short)822569721;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4C;
					default:
					{
						num = (short)915275776;
						short num4 = num;
						num = (short)783220737;
						if (num != 0)
						{
						}
						num = (short)45285376;
						if (num != 0)
						{
						}
						this.j(node, new global::System.EventArgs());
						num = (short)498597892;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				}
				goto IL_40;
				IL_4C:
				num = (short)1116667906;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_40:
				if (this.Count > 0)
				{
					goto IL_4C;
				}
				break;
			}
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x0004FCF4 File Offset: 0x0004DEF4
		internal global::AcpBusinessLayer.FeatureNode InternalAddRecord()
		{
			short num = (short)42663936;
			short num2 = num;
			num = (short)539164673;
			if (num != 0)
			{
			}
			num = (short)893928943;
			short num3 = num;
			num = (short)230966767;
			switch (num3 == num)
			{
			}
			num = (short)669712384;
			if (num != 0)
			{
			}
			global::AcpBusinessLayer.FeatureNode featureNode = this.CreateDefaultRecordHelper();
			this.AddRecord(featureNode);
			return featureNode;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x0004FDAC File Offset: 0x0004DFAC
		internal bool CheckKeyFieldForDup(string key)
		{
			short num = (short)1212481537;
			if (num != 0)
			{
			}
			num = (short)1394098359;
			short num2 = num;
			num = (short)990134455;
			bool result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			case 1:
				break;
			default:
			{
				num = (short)135331840;
				short num3 = num;
				break;
			}
			}
			num = (short)2025324544;
			if (num != 0)
			{
			}
			result = false;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = base.GetEnumerator();
			try
			{
				num = (short)1891172354;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						num = (short)744816647;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1BB;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_F2;
						}
						continue;
					case 3:
						num = (short)505544712;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						global::AcpBusinessLayer.FeatureNode featureNode;
						if (featureNode.KeyField != null)
						{
							num = (short)1389297667;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						result = true;
						num = (short)761200641;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1226506240;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
						num = (short)513277956;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_1D7;
					case 8:
					{
						global::AcpBusinessLayer.FeatureNode featureNode;
						if (featureNode.ReferenceKey == key)
						{
							num = (short)1999503365;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_12F:
					num = (short)596115462;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_F2:
					goto IL_12F;
				}
				IL_1BB:
				IL_1D7:;
			}
			finally
			{
				num = (short)1946025984;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_20A;
						}
						continue;
					case 1:
						goto IL_240;
					case 2:
						enumerator.Dispose();
						num = (short)1881145345;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_20A:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1085014018;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_240:;
			}
			return result;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0005001C File Offset: 0x0004E21C
		internal void ValidateReferenceKey(string key)
		{
			short num = (short)994483029;
			short num2 = num;
			num = (short)270900053;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1726545920;
				short num3 = num;
				num = (short)1905262592;
				if (num != 0)
				{
				}
				num = (short)1333264385;
				if (num != 0)
				{
				}
				bool flag = false;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = base.GetEnumerator();
				try
				{
					num = (short)82182151;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							num = (short)26214406;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_2F7;
						case 3:
						{
							if (flag)
							{
								num = (short)575012868;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpBusinessLayer.FeatureNode featureNode;
							featureNode.KeyField.ForceValid = (key.Length <= featureNode.KeyField.MaxLength);
							featureNode.KeyField.CalculateValidity();
							num = (short)1502937099;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							global::AcpBusinessLayer.FeatureNode featureNode;
							featureNode.KeyField.ForceValid = false;
							num = (short)1562181645;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::AcpBusinessLayer.FeatureNode featureNode;
							this.KeysToNode.Add(featureNode);
							num = (short)1160970252;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
						{
							global::AcpBusinessLayer.FeatureNode featureNode;
							if (featureNode.ReferenceKey == key)
							{
								num = (short)1643249672;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 7:
							switch (0)
							{
							case 0:
								goto IL_107;
							}
							continue;
						case 8:
							num = (short)1111293955;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)782303246;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
							num = (short)1672609802;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
						{
							global::AcpBusinessLayer.FeatureNode featureNode;
							if (featureNode.KeyField != null)
							{
								num = (short)1687355392;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 11:
						{
							global::AcpBusinessLayer.FeatureNode featureNode;
							if (!this.KeysToNode.Contains(featureNode))
							{
								num = (short)896925701;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_14E;
						}
						case 12:
							goto IL_14E;
						case 13:
							goto IL_235;
						case 14:
							num = (short)218759169;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_107;
						IL_14E:
						flag = true;
						num = (short)704053250;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_1D4:
						num = (short)1881407497;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_107:
						goto IL_1D4;
					}
					IL_235:
					IL_2F7:;
				}
				finally
				{
					num = (short)1941962752;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_329;
							}
							continue;
						case 1:
							goto IL_35E;
						case 2:
							enumerator.Dispose();
							num = (short)198311937;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_329:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1989017602;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_35E:;
				}
				break;
			}
			}
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x000503A8 File Offset: 0x0004E5A8
		private void d(global::AcpBusinessLayer.FeatureNode A_0)
		{
			int a_ = 1;
			short num = (short)1311244288;
			switch (num)
			{
			default:
			{
				num = (short)390070316;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::AcpBusinessLayer.AcpDocument acpDocument;
					bool flag;
					global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator;
					string text;
					global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator2;
					bool flag2;
					bool markForUndo;
					switch (num2)
					{
					case 0:
						goto IL_80B;
					case 1:
						num = (short)751501345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return;
					case 3:
						if (this.HasKeyField)
						{
							num = (short)1155203137;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3BC;
					case 4:
						goto IL_D6A;
					case 5:
						if (A_0.Parent.Count == 0)
						{
							num = (short)2108555310;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						goto IL_2E5;
					case 7:
						goto IL_3BC;
					case 8:
					{
						num = (short)1771013989;
						short num3 = num;
						num = (short)508528485;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_D95;
						default:
							num = (short)775487488;
							if (num != 0)
							{
							}
							this.c(1);
							this.IncrementCumulativeMax(A_0);
							num = (short)736690238;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 9:
						goto IL_612;
					case 10:
						acpDocument.OpenFromFileNew = false;
						num = (short)166330368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_DD7;
					case 12:
						if (this.ContainerDoc == null)
						{
							num = (short)1644625975;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F0D;
					case 13:
					{
						num = (short)1837694976;
						short num4 = num;
						this.ContainerDoc.AddToModificationLog(this.c(A_0.FeatureName));
						num = (short)123404342;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						flag = false;
						goto IL_78C;
					case 15:
						num = (short)2033057810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (!this.HasEmbeddedRecset)
						{
							num = (short)597426203;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DD7;
					case 17:
						try
						{
							num = (short)1554513920;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_487;
									}
									continue;
								case 2:
									if (!global::AcpBusinessLayer.Recordset.ParentNodeBeingAdded)
									{
										num = (short)2096103429;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
									num = (short)966000646;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2022637571;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.Recordset recordset = (global::AcpBusinessLayer.Recordset)enumerator.Current;
									recordset.ContainerDoc = this.ContainerDoc;
									num = (short)1039204354;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::AcpBusinessLayer.Recordset recordset;
									recordset.c(recordset.Count);
									num = (short)1683619841;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_558;
								}
								IL_4D9:
								num = (short)1130561540;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_487:
								goto IL_4D9;
							}
							IL_558:
							goto IL_34F;
						}
						finally
						{
							num = (short)153419777;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)904462338;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_58F;
									}
									continue;
								case 2:
									goto IL_5C8;
								}
								IL_58F:
								if (enumerator == null)
								{
									break;
								}
								num = (short)193134592;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5C8:;
						}
						goto IL_5CB;
						IL_34F:
						num = (short)837877798;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (global::AcpCommonLib.FeatureManager.ActiveDocument != null)
						{
							num = (short)1031798812;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_80B;
					case 19:
						num = (short)893780027;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
					{
						global::AcpBusinessLayer.AcpNumericKeyField acpNumericKeyField;
						if (acpNumericKeyField.NumericValue != 0)
						{
							num = (short)1093074980;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_866;
					}
					case 21:
						this.HasKeyField = true;
						this.KeysToNode = new global::AcpBusinessLayer.ReferencedNodeCollection(this);
						num = (short)732889094;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (this.KeysToNode == null)
						{
							num = (short)289734677;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E5;
					case 23:
						if (!this.KeysToNode.Contains(text))
						{
							num = (short)1678442566;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = this.GenerateKeyValue(A_0);
						num = (short)949420099;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						goto IL_B1D;
					case 25:
						goto IL_D95;
					case 26:
						try
						{
							num = (short)138215427;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)1741815816;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField = enumerator2.Current as global::AcpBusinessLayer.AcpRecRefField;
									num = (short)1400307721;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
									if (acpRecRefField.ReferencedNode.KeyField != null)
									{
										num = (short)2104426500;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									num = (short)1579220993;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_BAE;
									}
									continue;
								case 4:
								{
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
									acpRecRefField.ReferencedNode.KeyField.AddRecordReference(acpRecRefField);
									num = (short)849215495;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
									if (acpRecRefField.ReferencedNode != null)
									{
										num = (short)1125253122;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									num = (short)104857605;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									num = (short)1663434762;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
									if (acpRecRefField != null)
									{
										num = (short)663224326;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
									goto IL_CF8;
								}
								IL_C34:
								num = (short)368967680;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_BAE:
								goto IL_C34;
							}
							IL_CF8:
							goto IL_64C;
						}
						finally
						{
							num = (short)959578113;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator2.Dispose();
									num = (short)1918369794;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_D2F;
									}
									continue;
								case 2:
									goto IL_D67;
								}
								IL_D2F:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)2108293120;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_D67:;
						}
						goto IL_D6A;
						IL_64C:
						num = (short)738263043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						this.HasEmbeddedRecset = A_0.HasEmbeddedRecset;
						num = (short)757071883;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						num = (short)101908540;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						if (A_0.Parent.CanBeEmpty)
						{
							num = (short)2069364777;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 30:
						if (acpDocument != null)
						{
							num = (short)1267793989;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AD6;
					case 31:
						if (A_0.KeyField != null)
						{
							num = (short)1002766361;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E5;
					case 32:
						this.ContainerDoc.ModificationLogEnabled = true;
						num = (short)417988615;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						flag = this.ContainerDoc.ModificationLogEnabled;
						goto IL_78C;
					case 34:
						if (flag2)
						{
							num = (short)731709472;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3BC;
					case 35:
						goto IL_866;
					case 36:
						goto IL_3FC;
					case 37:
						if (A_0.KeyField.Value == null)
						{
							num = (short)1676148771;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3BC;
					case 38:
						if (this.ContainerDoc.ModificationLogEnabled)
						{
							num = (short)1166475277;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AD6;
					case 39:
						num = (short)1409876031;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						if (this.ContainerDoc != null)
						{
							num = (short)599261199;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_80B;
					case 41:
						goto IL_5CB;
					case 42:
						global::AcpCommonLib.UndoRedo.UndoManager.StopUndoRedo();
						num = (short)77725720;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						if (!global::AcpCommonLib.AppInfoManager.DragOperation)
						{
							num = (short)1971191847;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E1C;
					case 44:
						switch (0)
						{
						case 0:
							goto IL_16C;
						}
						continue;
					case 45:
						if (flag2)
						{
							num = (short)155713586;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_612;
					case 46:
						A_0.Parent._IsEmpty = false;
						num = (short)1442643970;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						if (markForUndo)
						{
							num = (short)1229586474;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B1D;
					case 48:
						goto IL_F0D;
					case 49:
						goto IL_1B2;
					case 50:
						this.ContainerDoc.ModificationLogEnabled = false;
						num = (short)1115619337;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
						if (!acpDocument.OpenFromFileNew)
						{
							num = (short)2056323076;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AD6;
					case 52:
						if (!this.HasKeyField)
						{
							num = (short)1305346119;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E5;
					case 53:
						if (global::AcpCommonLib.FeatureManager.ActiveDocument != null)
						{
							num = (short)1587478547;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E1C;
					case 54:
						goto IL_AD6;
					case 55:
						num = (short)1861222453;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
						goto IL_941;
					case 57:
						num = (short)836239380;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
						if (markForUndo)
						{
							num = (short)1582825538;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_941;
					case 59:
						if (!global::AcpCommonLib.FeatureManager.ActiveDocument.IsOpen)
						{
							num = (short)546897968;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E1C;
					case 60:
						if (global::AcpCommonLib.FeatureManager.ActiveDocument.IsOpen)
						{
							num = (short)1271595018;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_80B;
					case 61:
						goto IL_97D;
					case 62:
						goto IL_E1C;
					case 63:
						if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugConfigurationMode)
						{
							num = (short)1152581640;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E1C;
					case 64:
					{
						global::AcpBusinessLayer.AcpNumericKeyField acpNumericKeyField;
						if (acpNumericKeyField != null)
						{
							num = (short)1634795577;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3FC;
					}
					case 65:
					{
						global::AcpBusinessLayer.AcpNumericKeyField acpNumericKeyField = A_0.KeyField as global::AcpBusinessLayer.AcpNumericKeyField;
						num = (short)1680867392;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 66:
						global::AcpCommonLib.UndoRedo.UndoManager.StartUndoRedo();
						num = (short)660406328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
						goto IL_97D;
					case 68:
						if (this.ContainerDoc != null)
						{
							num = (short)675545089;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1441202190;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
						num = (short)530645043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 70:
						A_0.KeyField.SetValueNoConstraints(text);
						num = (short)201719866;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 71:
						num = (short)1372651551;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_16C:
					if (A_0 == null)
					{
						num = (short)80347137;
						if (num != 0)
						{
						}
						num = (short)763887665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					A_0.Parent = this;
					num = (short)1180696628;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E5:
					enumerator2 = A_0.AllFields.GetEnumerator();
					num = (short)129040410;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3BC:
					num = (short)1782579216;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3FC:
					num = (short)461570085;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5CB:
					num = (short)329580549;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_612:
					text = this.GenerateKeyValue(A_0);
					num = (short)1199439933;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_78C:
					flag2 = flag;
					num = (short)1000407087;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_80B:
					num = (short)1603141662;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_866:
					markForUndo = global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo;
					num = (short)1060700228;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_941:
					num = (short)387514402;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_97D:
					num = (short)1728446487;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AD6:
					num = (short)1569914909;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B1D:
					num = (short)933298221;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D6A:
					enumerator = A_0.EmbeddedRecordsets.GetEnumerator();
					num = (short)1328021521;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D95:
					num = (short)612499478;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DD7:
					A_0.Deleted = false;
					num = (short)437911564;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E1C:
					acpDocument = (this.ContainerDoc as global::AcpBusinessLayer.AcpDocument);
					num = (short)466092072;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F0D:
					num = (short)1179844651;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1B2:
				throw new global::System.ArgumentNullException(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("ꇒ냔듖", a_));
			}
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00051358 File Offset: 0x0004F558
		protected virtual void OnFinishedAddRecord()
		{
			short num = (short)1494562237;
			short num2 = num;
			num = (short)1547908541;
			switch (num2 == num)
			{
			default:
			{
				num = (short)573767680;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2053963777;
			if (num != 0)
			{
			}
			num = (short)402915328;
			if (num != 0)
			{
			}
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00051404 File Offset: 0x0004F604
		protected virtual void OnFinishedRemoveRecord()
		{
			short num = (short)982453358;
			short num2 = num;
			num = (short)2130578542;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2142437376;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)688914432;
			if (num != 0)
			{
			}
			num = (short)418250753;
			if (num != 0)
			{
			}
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x000514AC File Offset: 0x0004F6AC
		public virtual void OnFinishedMoveRecord()
		{
			short num = (short)680893111;
			short num2 = num;
			num = (short)174430903;
			switch (num2 == num)
			{
			default:
			{
				num = (short)980811776;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1766785025;
			if (num != 0)
			{
			}
			num = (short)372375552;
			if (num != 0)
			{
			}
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00051554 File Offset: 0x0004F754
		protected virtual void OnFinishedAddRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)279863388;
			short num2 = num;
			num = (short)1387421788;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1112080384;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)329908225;
			if (num != 0)
			{
			}
			num = (short)1434648576;
			if (num != 0)
			{
			}
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x000515FC File Offset: 0x0004F7FC
		protected virtual void OnFinishedRemoveRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1668352373;
			short num2 = num;
			num = (short)936708469;
			switch (num2 == num)
			{
			default:
			{
				num = (short)162594816;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)215941120;
			if (num != 0)
			{
			}
			num = (short)1771831297;
			if (num != 0)
			{
			}
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x000516A4 File Offset: 0x0004F8A4
		protected virtual void OnFinishedMoveRecord(global::AcpCommonLib.IAcpFeatureNode draggedRecord, global::AcpCommonLib.IAcpFeatureNode targetRecord)
		{
			short num = (short)1481448758;
			short num2 = num;
			num = (short)1394941238;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1173028864;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)115212288;
			if (num != 0)
			{
			}
			num = (short)1648164865;
			if (num != 0)
			{
			}
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x0005174C File Offset: 0x0004F94C
		public void FinishedMoveRecord(int oldIndex, int newIndex)
		{
			short num = (short)1903776626;
			short num2 = num;
			num = (short)2135774066;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1857290240;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2098593793;
			if (num != 0)
			{
			}
			num = (short)1833959424;
			if (num != 0)
			{
			}
			this.OnFinishedMoveRecord((global::AcpBusinessLayer.FeatureNode)this[oldIndex], (global::AcpBusinessLayer.FeatureNode)this[newIndex]);
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00051814 File Offset: 0x0004FA14
		public virtual void IncrementCumulativeMax(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1563974870;
			short num2 = num;
			num = (short)1627020502;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2119630848;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1002962945;
			if (num != 0)
			{
			}
			num = (short)88211456;
			if (num != 0)
			{
			}
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x000518BC File Offset: 0x0004FABC
		public virtual void DecrementCumulativeMax(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1590468711;
			short num2 = num;
			num = (short)1280417895;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1918500864;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)524681217;
			if (num != 0)
			{
			}
			num = (short)667811840;
			if (num != 0)
			{
			}
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00051968 File Offset: 0x0004FB68
		private void c(int A_0)
		{
			short num = (short)761397250;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)255328260;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_18F;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 3:
					goto IL_E4;
				case 4:
				{
					if (!global::AcpBusinessLayer.Recordset.b.ContainsKey(this.c))
					{
						num = (short)287113217;
						if (num != 0)
						{
						}
						num = (short)1760755713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::AcpBusinessLayer.Recordset.b[this.c] = global::AcpBusinessLayer.Recordset.b[this.c] + A_0;
					num = (short)1883665743;
					short num3 = num;
					num = (short)1899787599;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E9;
					default:
						num = (short)1917190144;
						if (num != 0)
						{
						}
						num = (short)1100939267;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_39:
				if (this.MaxPool <= 0)
				{
					break;
				}
				num = (short)1742143488;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E4:
			return;
			IL_E9:
			num = (short)218693632;
			short num4 = num;
			global::AcpBusinessLayer.Recordset.b[this.c] = A_0;
			return;
			IL_18F:
			goto IL_E9;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x00051B0C File Offset: 0x0004FD0C
		public virtual string GenerateKeyValue(global::AcpBusinessLayer.FeatureNode node)
		{
			int a_ = 5;
			short num = (short)791478272;
			short num2 = num;
			num = (short)1151795201;
			int num3 = (int)((global::System.IntPtr)num);
			string result;
			for (;;)
			{
				switch (num3)
				{
				case 0:
				{
					if (!string.IsNullOrEmpty(this.UIName))
					{
						num = (short)44892172;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					string recordsetName = this.RecordsetName;
					string str = global::AcpBusinessLayer.UndoRedo.SetValueTask.b("", a_);
					int num4 = this.lastId + 1;
					this.lastId = num4;
					result = recordsetName + str + num4.ToString();
					num = (short)452460562;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					switch (0)
					{
					case 0:
						goto IL_B1;
					}
					continue;
				case 2:
					if (!string.IsNullOrEmpty(this.KeySeed))
					{
						num = (short)1638403;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1174077440;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					string keySeed = this.KeySeed;
					string str2 = global::AcpBusinessLayer.UndoRedo.SetValueTask.b("", a_);
					int num4 = this.lastId + 1;
					this.lastId = num4;
					result = keySeed + str2 + num4.ToString();
					num = (short)1614020629;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
				{
					int num4 = this.lastId + 1;
					this.lastId = num4;
					result = num4.ToString();
					num = (short)1415577608;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					num = (short)980680724;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					return result;
				case 7:
					if (node.KeyField is global::AcpBusinessLayer.AcpNumericKeyField)
					{
						num = (short)2114977796;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1936982018;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					return result;
				case 9:
					goto IL_3A0;
				case 10:
					goto IL_35A;
				case 11:
					num = (short)2127757334;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
				{
					string uiname = this.UIName;
					string str3 = global::AcpBusinessLayer.UndoRedo.SetValueTask.b("", a_);
					int num4 = this.lastId + 1;
					this.lastId = num4;
					result = uiname + str3 + num4.ToString();
					num = (short)134348806;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 13:
					if (this.SingleInstance)
					{
						num = (short)1875836945;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1521352711;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (this.Max != this.Min)
					{
						num = (short)980746249;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_46D;
				case 15:
				{
					if (node.KeyField.BlockDataTransfer)
					{
						goto IL_46D;
					}
					num = (short)1559252896;
					short num5 = num;
					num = (short)1441484704;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_19F;
					default:
						num = (short)1080492032;
						if (num != 0)
						{
						}
						num = (short)207749131;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 16:
					goto IL_19F;
				case 17:
					result = node.FeatureName;
					num = (short)1933967370;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					goto IL_337;
				case 19:
					num = (short)1158676481;
					if (num != 0)
					{
					}
					num = (short)1615659023;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					if (node.KeyField != null)
					{
						num = (short)190382099;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_46D;
				case 21:
					goto IL_2E9;
				case 22:
					if (node.KeyField.Editable)
					{
						num = (short)662831120;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_46D;
				}
				IL_B1:
				if (global::AcpCommonLib.AppInfoManager.DndOrImportOperation)
				{
					num = (short)1483276293;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_46D;
				IL_19F:
				num = (short)907083790;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_46D:
				num = (short)926744589;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_2E9:
			IL_337:
			IL_35A:
			return result;
			IL_3A0:
			return this.GenerateRandomKeyValue(node);
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00051FC8 File Offset: 0x000501C8
		public virtual string GenerateRandomKeyValue(global::AcpBusinessLayer.FeatureNode node)
		{
			short num = (short)1776222208;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6A;
				}
				int num3;
				string text;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_B7;
					case 1:
						if (node.KeyField is global::AcpBusinessLayer.AcpNumericKeyField)
						{
							num = (short)2126577676;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)475136008;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (num3 < text.Length)
						{
							num = (short)780468231;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return text;
					case 3:
						if (!string.IsNullOrEmpty(this.UIName))
						{
							num = (short)1142751241;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = this.RecordsetName.Length;
						num = (short)360185866;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (string.IsNullOrEmpty(text))
						{
							num = (short)1288044557;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return text;
					case 5:
						num3 = this.KeySeed.Length;
						goto IL_32D;
					case 6:
						return text;
					case 7:
						text = text.Substring(0, num3);
						num = (short)1780154374;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (!string.IsNullOrEmpty(this.KeySeed))
						{
							num = (short)997982213;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1446445059;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num3 = this.UIName.Length;
						num = (short)1583808523;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						num = (short)1345340794;
						short num4 = num;
						num = (short)423118202;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_32D;
						default:
							num = (short)297271296;
							if (num != 0)
							{
							}
							goto IL_B7;
						}
						break;
					}
					case 11:
						goto IL_B7;
					case 12:
						text = new global::System.Random().Next().ToString();
						num = (short)1581383694;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						num = (short)1964834816;
						short num5 = num;
						text = global::System.Guid.NewGuid().ToString();
						num = (short)1996554241;
						if (num != 0)
						{
						}
						num = (short)1636040706;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_B7;
					}
					goto IL_6A;
					IL_B7:
					num = (short)830668804;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_32D:
					num = (short)2036596736;
					num2 = (int)((global::System.IntPtr)num);
				}
				return text;
				IL_6A:
				text = "";
				num3 = 1;
				num = (short)1897594881;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00052320 File Offset: 0x00050520
		private void c(global::AcpBusinessLayer.FeatureNode A_0)
		{
			short num = (short)1754202112;
			switch (num)
			{
			default:
			{
				num = (short)1365311498;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
					switch (num2)
					{
					case 0:
						num = (short)443023383;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						this.KeysToNode.DeleteItem(A_0);
						num = (short)200212496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)1681522691;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (!global::AcpBusinessLayer.Recordset.ParentNodeBeingAdded)
						{
							num = (short)1806368773;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_35E;
					case 4:
					{
						num = (short)1788542976;
						short num3 = num;
						try
						{
							num = (short)1678835718;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
									if (acpRecRefField != null)
									{
										num = (short)1549533189;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									goto IL_280;
								case 3:
								{
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
									if (acpRecRefField.ReferencedNode != null)
									{
										num = (short)353697799;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)637206536;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField = enumerator.Current as global::AcpBusinessLayer.AcpRecRefField;
									num = (short)1658257408;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)434896899;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_182;
									}
									continue;
								case 7:
								{
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
									acpRecRefField.ReferencedNode.KeyField.RemoveRecordReference(acpRecRefField);
									num = (short)982253570;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									num = (short)1331167233;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1E6:
								num = (short)544735236;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_182:
								goto IL_1E6;
							}
							IL_280:
							goto IL_52F;
						}
						finally
						{
							num = (short)1432158209;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2EE;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2B7;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)405274624;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2B7:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1661599746;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2EE:;
						}
						goto IL_2F1;
						IL_52F:
						num = (short)860618765;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_791;
					case 6:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2 = A_0.FeatureSectionsCollection.GetEnumerator();
						num = (short)97910805;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (A_0.HasEmbeddedRecset)
						{
							num = (short)1198194694;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F1;
					case 8:
						if (global::AcpCommonLib.AppInfoManager.AppMode != global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
						{
							num = (short)1896022018;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F1;
					case 9:
						goto IL_35E;
					case 10:
						switch (0)
						{
						case 0:
							goto IL_A6;
						}
						continue;
					case 11:
						return;
					case 12:
						if (A_0.Parent.CanBeEmpty)
						{
							num = (short)585957398;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 13:
						num = (short)514195457;
						if (num != 0)
						{
						}
						if (this.ContainerDoc != null)
						{
							num = (short)1610809344;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E2;
					case 14:
						this.ContainerDoc.AddToModificationLog(this.b(A_0.FeatureName));
						num = (short)310575122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (A_0.Parent.Count == 0)
						{
							num = (short)1881669649;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 16:
						if (!global::AcpBusinessLayer.AcpDocument.Closing)
						{
							num = (short)219480083;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4DD;
					case 17:
						A_0.Parent._IsEmpty = true;
						num = (short)235929611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_3E2;
					case 19:
						A_0.KeyField.NodeDeleted();
						num = (short)1698234388;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_4DD;
					case 21:
						try
						{
							num = (short)121241604;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)815792134;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = enumerator2.Current;
									num = (short)99024901;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_6D4;
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
									((global::AcpBusinessLayer.Recordset)acpFeatureSection.EmbeddedRecset).a(acpFeatureSection.EmbeddedRecset.Count);
									num = (short)2009530371;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_611;
									}
									continue;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
									if (acpFeatureSection.HasEmbeddedRecset)
									{
										num = (short)1897463810;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									num = (short)315031553;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_64E:
								num = (short)1520107520;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_611:
								goto IL_64E;
							}
							IL_6D4:
							goto IL_2F1;
						}
						finally
						{
							num = (short)1182007402;
							short num4 = num;
							num = (short)820183146;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_75B:
								num = (short)2087518210;
								num2 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)303824896;
								if (num != 0)
								{
								}
								num = (short)1238237185;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_78E;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_758;
									}
									continue;
								case 2:
									enumerator2.Dispose();
									num = (short)1037762560;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							IL_758:
							if (enumerator2 != null)
							{
								goto IL_75B;
							}
							IL_78E:;
						}
						goto IL_791;
					case 22:
						num = (short)98435087;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (this.ContainerDoc.ModificationLogEnabled)
						{
							num = (short)635174926;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E2;
					}
					IL_A6:
					if (this.HasKeyField)
					{
						num = (short)1136328705;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4DD;
					IL_2F1:
					num = (short)1759903756;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_35E:
					num = (short)1429536775;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3E2:
					num = (short)1708785672;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4DD:
					enumerator = A_0.AllFields.GetEnumerator();
					num = (short)1084162052;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_791:
					this.a(1);
					this.DecrementCumulativeMax(A_0);
					num = (short)1087176713;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00052B20 File Offset: 0x00050D20
		private void b(int A_0)
		{
			short num = (short)1373437952;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_66;
				}
				global::System.Collections.Generic.HashSet<global::AcpBusinessLayer.FeatureNode> hashSet;
				for (;;)
				{
					IL_27:
					int num4;
					global::AcpBusinessLayer.FeatureNode featureNode;
					bool flag;
					switch (num2)
					{
					case 0:
					{
						if (A_0 < 0)
						{
							num = (short)748617739;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)691994624;
						short num3 = num;
						num4 = this.Count - 1;
						num = (short)1759641605;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						try
						{
							num = (short)361431042;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_466;
								case 1:
									num = (short)169017344;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_3EF;
									}
									continue;
								case 3:
								{
									global::System.Collections.Generic.HashSet<global::AcpBusinessLayer.FeatureNode>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)274530305;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									enumerator.Current.CallConstraints();
									num = (short)626786308;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_3F1:
								num = (short)1976107011;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3EF:
								goto IL_3F1;
							}
							IL_466:
							return;
						}
						finally
						{
							global::System.Collections.Generic.HashSet<global::AcpBusinessLayer.FeatureNode>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_476;
					case 2:
						flag = (featureNode.ReferencingNodes != null);
						goto IL_4B1;
					case 3:
					{
						global::System.Collections.Generic.HashSet<global::AcpBusinessLayer.FeatureNode>.Enumerator enumerator = hashSet.GetEnumerator();
						num = (short)134938625;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						return;
					case 5:
						goto IL_304;
					case 6:
						if (num4 < A_0)
						{
							num = (short)1303642115;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23B;
					case 7:
						num = (short)1978531841;
						if (num != 0)
						{
						}
						flag = (null != null);
						goto IL_4B1;
					case 8:
						goto IL_304;
					case 9:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = featureNode.ReferencingNodes.GetEnumerator();
						num = (short)968032269;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						num = (short)62521351;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)24903684;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (featureNode == null)
						{
							num = (short)1740636170;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_476;
					case 13:
						goto IL_C4;
						try
						{
							for (;;)
							{
								IL_C4:
								num = (short)721616898;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_1CC;
									case 1:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)615907332;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpBusinessLayer.FeatureNode item = enumerator2.Current;
										hashSet.Add(item);
										num = (short)1136787459;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										switch (0)
										{
										case 0:
											goto IL_FE;
										}
										continue;
									case 4:
										num = (short)2050293760;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_129:
									num = (short)537343911;
									short num5 = num;
									num = (short)1821390759;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_C4;
									default:
										num = (short)1837957120;
										if (num != 0)
										{
										}
										num = (short)666107905;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_FE:
									goto IL_129;
								}
							}
							IL_1CC:
							goto IL_A3;
						}
						finally
						{
							num = (short)1557921793;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
								switch (num2)
								{
								case 0:
									goto IL_238;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_203;
									}
									continue;
								case 2:
									enumerator2.Dispose();
									num = (short)1183252480;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_203:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)52887554;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_238:;
						}
						goto IL_23B;
					}
					goto IL_66;
					IL_A3:
					num4--;
					num = (short)1130823688;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4B1:
					if (flag)
					{
						num = (short)1927806985;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A3;
					IL_23B:
					featureNode = (global::AcpBusinessLayer.FeatureNode)this[num4];
					this.KeysToNode.UpdateKey(featureNode);
					num = (short)2080571404;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_304:
					num = (short)561315846;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_476:
					num = (short)2071199746;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_66:
				hashSet = new global::System.Collections.Generic.HashSet<global::AcpBusinessLayer.FeatureNode>();
				num = (short)1801650176;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00053034 File Offset: 0x00051234
		private void a(int A_0)
		{
			short num = (short)1703346180;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (global::AcpBusinessLayer.Recordset.b.ContainsKey(this.c))
					{
						num = (short)185139206;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
				{
					num = (short)675014492;
					short num3 = num;
					num = (short)2038949724;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_182;
					default:
						num = (short)1815412736;
						if (num != 0)
						{
						}
						num = (short)1817051136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					return;
				case 3:
					num = (short)295305217;
					if (num != 0)
					{
					}
					if (this.MaxPool > 0)
					{
						goto IL_182;
					}
					return;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_40;
					}
					continue;
				case 5:
					num = (short)700841987;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					global::AcpBusinessLayer.Recordset.b[this.c] = global::AcpBusinessLayer.Recordset.b[this.c] - A_0;
					num = (short)645005314;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_40:
				if (this.MaxPool != 2147483647)
				{
					num = (short)1897660421;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_182:
				num = (short)1208745984;
				short num4 = num;
				num = (short)1192558593;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x0005320C File Offset: 0x0005140C
		private string c(string A_0)
		{
			int a_ = 11;
			short num = (short)569691467;
			short num2 = num;
			num = (short)1532742987;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_106:
				num = (short)244187138;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1204420608;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_72;
				}
				break;
			}
			string text;
			for (;;)
			{
				IL_60:
				switch (num3)
				{
				case 0:
					goto IL_19F;
				case 1:
					goto IL_FB;
				case 2:
					text = string.Concat(new string[]
					{
						text,
						global::AcpBusinessLayer.UndoRedo.SetValueTask.b("﷜", a_),
						global::AcpCommonResources.AcpResources.At_Id,
						global::AcpBusinessLayer.UndoRedo.SetValueTask.b("ￜ", a_),
						this.ParentSection.Path(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("臜", a_)),
						global::AcpBusinessLayer.UndoRedo.SetValueTask.b("ￜ", a_)
					});
					num = (short)816250880;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_72;
			}
			IL_FB:
			if (this.IsEmbeddedRecset)
			{
				goto IL_106;
			}
			goto IL_1C8;
			IL_19F:
			num = (short)564723713;
			if (num != 0)
			{
			}
			IL_1C8:
			num = (short)636223488;
			short num4 = num;
			return text;
			IL_72:
			text = global::System.DateTime.Now.ToString() + global::AcpCommonResources.AcpResources.Added_To_RS_Info.AcpStringFormat(new object[]
			{
				global::AcpBusinessLayer.UndoRedo.SetValueTask.b("ￜ", a_) + A_0 + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("ￜ", a_),
				global::AcpBusinessLayer.UndoRedo.SetValueTask.b("ￜ", a_) + this.RecordsetName + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("ￜ", a_)
			});
			num = (short)1345519617;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_60;
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x0005340C File Offset: 0x0005160C
		private string b(string A_0)
		{
			int a_ = 3;
			short num = (short)1903378929;
			short num2 = num;
			num = (short)74269169;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_12B:
				num = (short)1356464130;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1336279041;
				if (num != 0)
				{
				}
				num = (short)875560960;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_96;
				}
				break;
			}
			string text;
			for (;;)
			{
				IL_84:
				switch (num3)
				{
				case 0:
					goto IL_1C5;
				case 1:
					goto IL_120;
				case 2:
					text = string.Concat(new string[]
					{
						text,
						global::AcpBusinessLayer.UndoRedo.SetValueTask.b("", a_),
						global::AcpCommonResources.AcpResources.At_Id,
						global::AcpBusinessLayer.UndoRedo.SetValueTask.b("", a_),
						this.ParentSection.Path(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("觔", a_)),
						global::AcpBusinessLayer.UndoRedo.SetValueTask.b("", a_)
					});
					num = (short)447938560;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_96;
			}
			IL_120:
			if (this.IsEmbeddedRecset)
			{
				goto IL_12B;
			}
			return text;
			IL_1C5:
			num = (short)285081600;
			short num4 = num;
			return text;
			IL_96:
			text = global::System.DateTime.Now.ToString() + global::AcpCommonResources.AcpResources.Deleted_To_RS_Info.AcpStringFormat(new object[]
			{
				global::AcpBusinessLayer.UndoRedo.SetValueTask.b("", a_) + A_0 + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("", a_),
				global::AcpBusinessLayer.UndoRedo.SetValueTask.b("", a_) + this.RecordsetName + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("", a_)
			});
			num = (short)1617428481;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_84;
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x0005360C File Offset: 0x0005180C
		internal void InsertRecord(int index, global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)849084416;
			short num2 = num;
			num = (short)624396260;
			short num3 = num;
			num = (short)619349988;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_1A8:
				num = (short)1089863683;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)323092481;
				if (num != 0)
				{
				}
				num = (short)11862016;
				if (num != 0)
				{
				}
				num = (short)1918304257;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					goto IL_18D;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_DF;
					}
					continue;
				case 2:
					goto IL_F9;
				case 3:
					if (this.HasKeyField)
					{
						num = (short)800260101;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E5;
				case 4:
					goto IL_16F;
				case 5:
					num = (short)1272905735;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					this.KeysToNode.Add((global::AcpBusinessLayer.FeatureNode)record);
					num = (short)1350893572;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (!this.KeysToNode.Contains(record.ReferenceKey))
					{
						num = (short)126615558;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_16F;
				}
				IL_DF:
				if (record == null)
				{
					num = (short)1659305986;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_18F;
				IL_16F:
				this.b(index);
				num = (short)770375680;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_F9:
			throw new global::System.ArgumentNullException(global::AcpCommonResources.AcpResources.Record_Id);
			IL_18D:
			goto IL_1E5;
			IL_18F:
			this.d((global::AcpBusinessLayer.FeatureNode)record);
			base.Insert(index, (global::AcpBusinessLayer.FeatureNode)record);
			goto IL_1A8;
			IL_1E5:
			record.PopulateReferences();
			this.OnFinishedAddRecord();
			this.OnFinishedAddRecord(record);
			this.CanAdd = true;
			this.CanDelete = true;
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00053820 File Offset: 0x00051A20
		internal void SetupDependencies()
		{
			short num;
			for (;;)
			{
				num = (short)1597308928;
				short num2 = num;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = base.GetEnumerator();
				try
				{
					num = (short)864878592;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_6A;
							}
							continue;
						case 1:
							num = (short)373227523;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_B4;
						case 3:
							goto IL_104;
						case 4:
							if (!enumerator.MoveNext())
							{
								num = (short)1046282241;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							enumerator.Current.SetupDependencies();
							num = (short)1862467586;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6A;
						IL_B4:
						num = (short)522649604;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_6A:
						num = (short)2135359489;
						if (num != 0)
						{
						}
						goto IL_B4;
					}
					IL_104:;
				}
				finally
				{
					num = (short)470745088;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_137;
							}
							continue;
						case 1:
							goto IL_16A;
						case 2:
							enumerator.Dispose();
							num = (short)412942337;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_137:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1596129282;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_16A:;
				}
				num = (short)961818447;
				short num4 = num;
				num = (short)604778319;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_1A2;
				}
			}
			IL_1A2:
			num = (short)937164800;
			if (num != 0)
			{
			}
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x000539F8 File Offset: 0x00051BF8
		internal void SetConstraints()
		{
			short num;
			for (;;)
			{
				num = (short)1124597760;
				short num2 = num;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = base.GetEnumerator();
				try
				{
					num = (short)148373504;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_69;
							}
							continue;
						case 1:
							num = (short)15466499;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_D7;
						case 4:
							if (!enumerator.MoveNext())
							{
								num = (short)360710145;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							enumerator.Current.SetConstraints();
							num = (short)1196621826;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_8C:
						num = (short)157220868;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_69:
						goto IL_8C;
					}
					IL_D7:;
				}
				finally
				{
					num = (short)651296768;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_109;
							}
							continue;
						case 1:
							goto IL_13D;
						case 2:
							enumerator.Dispose();
							num = (short)1944584193;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_109:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1012137986;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_13D:;
				}
				num = (short)1997025482;
				short num4 = num;
				num = (short)1712730314;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_176;
				}
			}
			IL_176:
			num = (short)1595146241;
			if (num != 0)
			{
			}
			num = (short)1892548608;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00053BC8 File Offset: 0x00051DC8
		internal void PopulateReferences()
		{
			short num;
			for (;;)
			{
				num = (short)924516352;
				short num2 = num;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = base.GetEnumerator();
				try
				{
					num = (short)26673152;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_6A;
							}
							continue;
						case 1:
							num = (short)712507395;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_D8;
						case 4:
							if (!enumerator.MoveNext())
							{
								num = (short)740622337;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							enumerator.Current.PopulateReferences();
							num = (short)1451229186;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_8D:
						num = (short)1669988356;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_6A:
						goto IL_8D;
					}
					IL_D8:;
				}
				finally
				{
					num = (short)758513664;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_10A;
							}
							continue;
						case 1:
							goto IL_13D;
						case 2:
							enumerator.Dispose();
							num = (short)623575041;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_10A:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1317076994;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_13D:;
				}
				num = (short)676037348;
				short num4 = num;
				num = (short)345604836;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_177;
				}
			}
			IL_177:
			num = (short)1864433665;
			if (num != 0)
			{
			}
			num = (short)113508352;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00053D98 File Offset: 0x00051F98
		public void Initialize()
		{
			short num = (short)1155923968;
			short num2 = num;
			num = (short)1102325179;
			short num3 = num;
			num = (short)1673405883;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)408813568;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = base.GetEnumerator();
				try
				{
					num = (short)1654915072;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_215;
							}
							continue;
						case 2:
							if (!enumerator.MoveNext())
							{
								num = (short)903741444;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current).Parent = this;
							num = (short)622592001;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_286;
						case 4:
							num = (short)267517955;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_217:
						num = (short)1790967810;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_215:
						goto IL_217;
					}
					IL_286:
					goto IL_1D1;
				}
				finally
				{
					num = (short)488243200;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_2BB;
							}
							continue;
						case 1:
							goto IL_2F1;
						case 2:
							enumerator.Dispose();
							num = (short)598147073;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_2BB:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1637941250;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_2F1:;
				}
				break;
				for (;;)
				{
					IL_1D1:
					enumerator = base.GetEnumerator();
					try
					{
						num = (short)1977614336;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_B9;
								}
								continue;
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)220659713;
									if (num != 0)
									{
									}
									num = (short)762183684;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
								featureNode.PopulateReferences();
								featureNode.SetupDependencies();
								featureNode.SetConstraints();
								num = (short)349044737;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								goto IL_164;
							case 4:
								num = (short)954400771;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_BB:
							num = (short)1258487810;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_B9:
							goto IL_BB;
						}
						IL_164:
						break;
					}
					finally
					{
						num = (short)1129185280;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_199;
								}
								continue;
							case 1:
								goto IL_1CE;
							case 2:
								enumerator.Dispose();
								num = (short)1872822273;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_199:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1934950402;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_1CE:;
					}
				}
				break;
			}
			}
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x000540B8 File Offset: 0x000522B8
		public void CallConstraints()
		{
			short num;
			for (;;)
			{
				num = (short)1484128256;
				short num2 = num;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = base.GetEnumerator();
				try
				{
					num = (short)681246720;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_69;
							}
							continue;
						case 1:
							num = (short)1549467651;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_D6;
						case 4:
							if (!enumerator.MoveNext())
							{
								num = (short)1858535425;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							enumerator.Current.CallConstraints();
							num = (short)449445890;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_8C:
						num = (short)1608253444;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_69:
						goto IL_8C;
					}
					IL_D6:;
				}
				finally
				{
					num = (short)1378680832;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_108;
							}
							continue;
						case 1:
							goto IL_13D;
						case 2:
							enumerator.Dispose();
							num = (short)1294073857;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_108:
						if (enumerator == null)
						{
							break;
						}
						num = (short)528154626;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_13D:;
				}
				num = (short)2003429968;
				short num4 = num;
				num = (short)1687022160;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_174;
				}
			}
			IL_174:
			num = (short)1034682369;
			if (num != 0)
			{
			}
			num = (short)543817728;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00054288 File Offset: 0x00052488
		public global::AcpCommonLib.IAcpFeatureNode AddDefaultRecord()
		{
			int num;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				global::AcpBusinessLayer.FeatureNode featureNode;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						bool flag = global::AcpCommonLib.UndoRedo.UndoManager.StopUndoRedo();
						bool flag2 = global::AcpCommonLib.ConstraintManager.Suspend();
						featureNode = this.CreateDefaultRecordHelper();
						if (flag2)
						{
							global::AcpCommonLib.ConstraintManager.Resume();
						}
						if (!flag)
						{
							goto IL_138;
						}
						num2 = (short)153334203;
						short num3 = num2;
						num2 = (short)1793634747;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_28;
						default:
							num2 = (short)1891106816;
							if (num2 != 0)
							{
							}
							num2 = (short)637075457;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
					{
						num2 = (short)814940160;
						short num4 = num2;
						num2 = (short)770572289;
						if (num2 != 0)
						{
						}
						global::AcpCommonLib.UndoRedo.UndoManager.StartUndoRedo();
						num2 = (short)762249218;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 2:
						goto IL_96;
					}
					goto IL_1C;
				}
				IL_96:
				IL_138:
				global::AcpCommonLib.UndoRedo.UndoManager.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(featureNode));
				global::AcpCommonLib.AppInfoManager.AddDefaultRecord = false;
				return featureNode;
			}
			}
			IL_1C:
			global::AcpCommonLib.AppInfoManager.AddDefaultRecord = true;
			global::System.Diagnostics.Stopwatch.StartNew();
			IL_28:
			num2 = (short)199753728;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x000543E0 File Offset: 0x000525E0
		public void AddRecord(global::AcpBusinessLayer.FeatureNode record)
		{
			int a_ = 9;
			short num;
			for (;;)
			{
				num = (short)1992949760;
				short num2 = num;
				num = (short)3342339;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						if (!this.KeysToNode.Contains(record.ReferenceKey))
						{
							num = (short)2000879618;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_120;
					case 1:
						if (this.HasKeyField)
						{
							num = (short)1539899399;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_120;
					case 2:
						this.KeysToNode.Add(record);
						num = (short)1880162309;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_85;
						}
						continue;
					case 4:
						goto IL_9C;
					case 5:
						goto IL_120;
					case 6:
						this.MoveNodeBasedOnKey(record);
						num = (short)1450311688;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)169017345;
						if (num != 0)
						{
						}
						num = (short)469762048;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_203;
					case 9:
						if (this.PositionBased)
						{
							num = (short)355794950;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_260;
					case 10:
						try
						{
							base.Add(record);
							goto IL_C3;
						}
						catch (global::System.ArgumentOutOfRangeException)
						{
							goto IL_C3;
						}
						goto IL_260;
						IL_C3:
						num = (short)128712705;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_85:
					if (record == null)
					{
						num = (short)1780744196;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.d(record);
					num = (short)1220870154;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_120:
					num = (short)136577033;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_203:
				num = (short)1174961319;
				short num4 = num;
				num = (short)222526631;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_237;
				}
			}
			IL_9C:
			throw new global::System.ArgumentNullException(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("꧚룜볞軠釢臤", a_));
			IL_237:
			num = (short)7733248;
			if (num != 0)
			{
			}
			IL_260:
			this.OnFinishedAddRecord();
			this.OnFinishedAddRecord(record);
			this.CanAdd = true;
			this.CanDelete = true;
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00054678 File Offset: 0x00052878
		internal void MoveNodeBasedOnKey(global::AcpBusinessLayer.FeatureNode node)
		{
			short num = (short)1020133376;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				int num3;
				int num4;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 1:
					if (num3 != num4)
					{
						num = (short)1173946371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					goto IL_59;
				case 3:
				{
					num = (short)1243742208;
					short num5 = num;
					num = (short)1079771137;
					if (num != 0)
					{
					}
					num = (short)1383062785;
					short num6 = num;
					num = (short)872406273;
					switch ((num6 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_59;
					default:
						num = (short)1030619136;
						if (num != 0)
						{
						}
						base.Move(num4, num3);
						num = (short)1949892612;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					return;
				}
				IL_39:
				if (base.Contains(node))
				{
					num = (short)1301807106;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_59:
				num3 = this.b(node);
				num4 = this.IndexOf(node);
				num = (short)642842625;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x000547E8 File Offset: 0x000529E8
		public int AddMultipleDefaultRecords(int count)
		{
			short num = (short)1991245824;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6C;
				}
				int num3;
				int num4;
				global::AcpBusinessLayer.FeatureNode[] array2;
				global::AcpBusinessLayer.FeatureNode featureNode;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
					{
						if (num3 >= count)
						{
							num = (short)125960202;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpBusinessLayer.FeatureNode[] array;
						array[num3++] = this.CreateDefaultRecordHelper();
						num = (short)2040201230;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::AcpCommonLib.UndoRedo.UndoManager.StartUndoRedo();
						global::AcpBusinessLayer.FeatureNode[] array;
						global::AcpCommonLib.UndoRedo.UndoManager.AddTask(new global::AcpBusinessLayer.AddMultipleRecordsTask(array));
						num = (short)2145452044;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (num4 >= array2.Length)
						{
							num = (short)846987270;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E2;
					case 3:
						goto IL_315;
					case 4:
					{
						num = (short)2076573696;
						short num5 = num;
						bool flag;
						if (flag)
						{
							num = (short)1804206081;
							if (num != 0)
							{
							}
							num = (short)1009123336;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A9;
					}
					case 5:
						goto IL_2D7;
					case 6:
						goto IL_313;
					case 7:
						goto IL_1A9;
					case 8:
						global::AcpCommonLib.ConstraintManager.Resume();
						num = (short)465960967;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						bool flag2;
						if (flag2)
						{
							num = (short)316342273;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num6 = 0;
						global::AcpBusinessLayer.FeatureNode[] array;
						array2 = array;
						num4 = 0;
						num = (short)30474245;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						num = (short)927072260;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						int num6;
						this.NotFirstNoLastAddOnMultiAddOperation = (num6 != 0 && num6 != count - 1);
						this.AddRecord(featureNode);
						featureNode.Initialize();
						featureNode.CallConstraints();
						num6++;
						num4++;
						num = (short)1615134733;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_26B;
					case 13:
						goto IL_2D7;
					case 14:
						goto IL_315;
					}
					goto IL_6C;
					IL_1A9:
					num = (short)1545601033;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D7:
					num = (short)718274562;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_315:
					num = (short)1340997632;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1E2:
				featureNode = array2[num4];
				goto IL_1E9;
				IL_26B:
				IL_313:
				global::AcpCommonLib.AppInfoManager.AddDefaultRecord = false;
				this.NotFirstNoLastAddOnMultiAddOperation = false;
				return num3;
				IL_6C:
				num = (short)165738890;
				short num7 = num;
				num = (short)884078986;
				switch ((num7 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_1E9:
					num = (short)161021963;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_29;
				default:
				{
					num = (short)1874198528;
					if (num != 0)
					{
					}
					global::AcpCommonLib.AppInfoManager.AddDefaultRecord = true;
					num3 = 0;
					global::System.Diagnostics.Stopwatch.StartNew();
					bool flag2 = global::AcpCommonLib.UndoRedo.UndoManager.StopUndoRedo();
					bool flag = global::AcpCommonLib.ConstraintManager.Suspend();
					global::AcpBusinessLayer.FeatureNode[] array = new global::AcpBusinessLayer.FeatureNode[count];
					this.NotFirstNoLastAddOnMultiAddOperation = false;
					num = (short)858521603;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_29;
				}
				}
				break;
			}
			}
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00054B5C File Offset: 0x00052D5C
		internal void RemoveRecord(global::AcpCommonLib.IAcpFeatureNode record)
		{
			int a_ = 13;
			short num = (short)890175490;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)473212014;
					short num3 = num;
					num = (short)1712432238;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14F;
					default:
						num = (short)1886388224;
						if (num != 0)
						{
						}
						if (global::AcpCommonLib.AppInfoManager.SkipValueSetter)
						{
							num = (short)357629955;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C5;
					}
					break;
				}
				case 1:
					if (this.HasKeyField)
					{
						num = (short)413532170;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_32C;
				case 2:
					num = (short)1836646401;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_A3;
					}
					continue;
				case 3:
					num = (short)819396616;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					this[0].CalculateValidity();
					num = (short)1656029190;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_12B;
				case 6:
					goto IL_2BF;
				case 7:
					goto IL_C9;
				case 8:
					if (!global::AcpCommonLib.AppInfoManager.DropOperation)
					{
						goto IL_14F;
					}
					goto IL_F2;
				case 9:
				{
					if (global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo)
					{
						num = (short)242941957;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					int a_2 = this.IndexOf((global::AcpBusinessLayer.FeatureNode)record);
					base.Remove((global::AcpBusinessLayer.FeatureNode)record);
					this.c((global::AcpBusinessLayer.FeatureNode)record);
					num = (short)659226625;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 10:
				{
					int a_2;
					this.b(a_2);
					num = (short)1825374220;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 11:
				{
					num = (short)2051538944;
					short num4 = num;
					num = (short)848297997;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 12:
					goto IL_32C;
				case 13:
					if (global::AcpCommonLib.Permission.Have(global::AcpCommonLib.Permissions.Undeletable, record.Permissions))
					{
						num = (short)1343094799;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F2;
				case 14:
					goto IL_2C5;
				case 15:
					return;
				case 16:
					if (this.MustCalculateValidityAcross)
					{
						num = (short)1523580947;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3D5;
				case 17:
					if (!global::AcpCommonLib.AppInfoManager.UndoRedoInProgress)
					{
						num = (short)2127757323;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F2;
				case 18:
					if (this.Count > 0)
					{
						num = (short)468779012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3D5;
				case 19:
					num = (short)1234829330;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A3:
				if (this.Count == this.Min)
				{
					num = (short)540934151;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1107623936;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F2:
				num = (short)1594359817;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_14F:
				num = (short)806486030;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2C5:
				num = (short)1202257937;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_32C:
				num = (short)857669648;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C9:
			throw new global::System.InvalidOperationException(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("鳞胠跢诤裦鷨쯪觬諮鷰雲致鋶\ud9f8诺鳼賾甀⌂焄漆氈⬊䀌明缐㌒笔或琘礚砜洞Ġ䰢䌤ܦ嬨个丬䀮䌰圲䘴ᤶ", a_));
			IL_12B:
			global::AcpCommonLib.UndoRedo.UndoManager.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask((global::AcpBusinessLayer.FeatureNode)record));
			return;
			IL_2BF:
			IL_3D5:
			this.ValidateReferenceKey(record.ReferenceKey);
			this.OnFinishedRemoveRecord(record);
			this.CanAdd = true;
			this.CanDelete = true;
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00054F60 File Offset: 0x00053160
		public virtual void RemoveRecordAt(int index)
		{
			int a_ = 13;
			short num = (short)981467136;
			short num2 = num;
			num = (short)2120730154;
			short num3 = num;
			num = (short)780977706;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)259784705;
				if (num != 0)
				{
				}
				num = (short)607584256;
				if (num != 0)
				{
				}
				if (this.Count != this.Min)
				{
					this.RemoveRecordInternal(index, new bool?(true));
					return;
				}
				break;
			}
			throw new global::System.InvalidOperationException(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("鳞胠跢诤裦鷨쯪觬諮鷰雲致鋶\ud9f8诺鳼賾甀⌂焄漆氈⬊䀌明缐㌒笔或琘礚砜洞Ġ䰢䌤ܦ嬨个丬䀮䌰圲䘴ᤶ", a_));
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00055044 File Offset: 0x00053244
		internal void RemoveRecordAtNoMin(int index)
		{
			short num = (short)1151270912;
			short num2 = num;
			num = (short)333869985;
			short num3 = num;
			num = (short)804746145;
			switch (num3 == num)
			{
			}
			num = (short)129499137;
			if (num != 0)
			{
			}
			num = (short)800915456;
			if (num != 0)
			{
			}
			this.RemoveRecordInternal(index, new bool?(true));
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x000550FC File Offset: 0x000532FC
		public int RemoveMultipleRecords(global::AcpBusinessLayer.FeatureNode[] records)
		{
			short num = (short)1740963840;
			short num2 = num;
			num = (short)1577828003;
			short num3 = num;
			num = (short)1103543971;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)548274177;
				if (num != 0)
				{
				}
				num = (short)505806848;
				if (num != 0)
				{
				}
				if (!global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo)
				{
					return 0;
				}
				break;
			}
			global::AcpCommonLib.UndoRedo.UndoManager.AddTask(new global::AcpBusinessLayer.DeleteMultipleRecordsTask(records));
			return records.Length;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x000551BC File Offset: 0x000533BC
		internal void RemoveRecordInternal(int index, bool? CheckPermission = true)
		{
			short num = (short)1387069440;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_92;
				}
				bool? flag;
				bool flag2;
				global::AcpBusinessLayer.FeatureNode featureNode;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						num = (short)306380820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (this.HasKeyField)
						{
							num = (short)948437001;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F0;
					case 2:
						goto IL_40E;
					case 3:
						this[0].CalculateValidity();
						num = (short)227540999;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (this.MustCalculateValidityAcross)
						{
							num = (short)407502860;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_44C;
					case 5:
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)1543700480;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A0;
					case 6:
						if (global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo)
						{
							num = (short)1322516502;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						base.RemoveAt(index);
						num = (short)1812267009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_44C;
					case 8:
						if (this.Count > 0)
						{
							num = (short)192020483;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_44C;
					case 9:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = base.GetEnumerator();
						num = (short)1260912661;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_49B;
					case 11:
						if (this.HasKeyField)
						{
							num = (short)2017591311;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_40E;
					case 12:
						num = (short)2010120200;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_2B3;
					case 14:
						return;
					case 15:
						this.b(index);
						num = (short)1900806146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)2092367895;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (global::AcpCommonLib.Permission.Have(global::AcpCommonLib.Permissions.Undeletable, featureNode.Permissions))
						{
							num = (short)224002062;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A0;
					case 18:
						goto IL_547;
					case 19:
						goto IL_5A9;
					case 20:
						if (global::AcpCommonLib.AppInfoManager.SkipValueSetter)
						{
							num = (short)1692532752;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_547;
					case 21:
						try
						{
							num = (short)24379392;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_173;
									}
									continue;
								case 2:
									num = (short)179044356;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (enumerator.MoveNext())
									{
										global::AcpBusinessLayer.FeatureNode item = enumerator.Current;
										this.KeysToNode.UpdateKey(item);
										num = (short)1299972097;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)570870598;
									short num3 = num;
									num = (short)61066054;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_242;
									default:
										num = (short)384827392;
										if (num != 0)
										{
										}
										num = (short)499253250;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									goto IL_242;
								}
								IL_175:
								num = (short)1862402051;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_173:
								goto IL_175;
							}
							IL_242:
							goto IL_F0;
						}
						finally
						{
							num = (short)230752257;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)908328962;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_27A;
									}
									continue;
								case 2:
									goto IL_2B0;
								}
								IL_27A:
								if (enumerator == null)
								{
									break;
								}
								num = (short)958332928;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2B0:;
						}
						goto IL_2B3;
					case 22:
						num = (short)2020933633;
						if (num != 0)
						{
						}
						global::AcpCommonLib.UndoRedo.UndoManager.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(featureNode));
						num = (short)705363987;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (!global::AcpCommonLib.AppInfoManager.DropOperation)
						{
							num = (short)807075858;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A0;
					case 24:
						if (!global::AcpCommonLib.AppInfoManager.UndoRedoInProgress)
						{
							num = (short)968491021;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A0;
					}
					goto IL_92;
					IL_F0:
					this.c(featureNode);
					num = (short)781975563;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2B3:
					num = (short)1696071697;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_40E:
					num = (short)1518862340;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_44C:
					this.CanAdd = true;
					this.CanDelete = true;
					num = (short)20185088;
					short num4 = num;
					num = (short)1637351434;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4A0:
					num = (short)1217855494;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_547:
					num = (short)358809624;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_49B:
				IL_5A9:
				this.OnFinishedRemoveRecord(featureNode);
				return;
				IL_92:
				featureNode = (global::AcpBusinessLayer.FeatureNode)this[index];
				flag = CheckPermission;
				flag2 = true;
				num = (short)1057947653;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x000557C0 File Offset: 0x000539C0
		public void RefreshKeyMap()
		{
			short num = (short)413925377;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				switch (num2)
				{
				case 0:
					goto IL_1F5;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				case 2:
					try
					{
						num = (short)39714816;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_B9;
								}
								continue;
							case 1:
								try
								{
									global::AcpBusinessLayer.FeatureNode item;
									this.KeysToNode.Add(item);
									break;
								}
								catch (global::System.ArgumentException)
								{
									break;
								}
								goto IL_173;
							case 2:
								goto IL_173;
							case 3:
							{
								if (enumerator.MoveNext())
								{
									global::AcpBusinessLayer.FeatureNode item = enumerator.Current;
									num = (short)1538785281;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)101074312;
								short num3 = num;
								num = (short)1645495688;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_18A;
								default:
									num = (short)100728832;
									if (num != 0)
									{
									}
									num = (short)260898818;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 4:
								goto IL_18A;
							}
							IL_BB:
							num = (short)1119027203;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_B9:
							goto IL_BB;
							IL_173:
							num = (short)185270276;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_18A:
						return;
					}
					finally
					{
						num = (short)691404801;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)513146882;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_1BF;
								}
								continue;
							case 2:
								goto IL_1F2;
							}
							IL_1BF:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1323565056;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1F2:;
					}
					goto IL_1F5;
				}
				IL_32:
				if (this.KeysToNode != null)
				{
					num = (short)611647488;
					short num4 = num;
					num = (short)886898688;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1F5:
				num = (short)189005825;
				if (num != 0)
				{
				}
				this.KeysToNode.Clear();
				enumerator = base.GetEnumerator();
				num = (short)1542062082;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00055A4C File Offset: 0x00053C4C
		public void RefreshKeyForNode(global::AcpBusinessLayer.FeatureNode node)
		{
			short num = (short)395051008;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)2085224449;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_65;
					}
					continue;
				case 1:
					this.KeysToNode.Add(node);
					num = (short)700383234;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return;
				case 3:
				{
					num = (short)1060976701;
					short num3 = num;
					num = (short)834680893;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)1627521024;
						if (num != 0)
						{
						}
						if (!this.KeysToNode.Contains(node.ReferenceKey))
						{
							num = (short)1406795777;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				case 4:
					this.KeysToNode.Remove(node);
					num = (short)1220739077;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_B1;
				}
				IL_65:
				if (this.KeysToNode.Contains(node))
				{
					num = (short)355729412;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_B1:
				num = (short)1776025600;
				short num4 = num;
				num = (short)537722883;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00055BF0 File Offset: 0x00053DF0
		public void MoveRecord(int oldIndex, int newIndex)
		{
			short num = (short)1797521408;
			short num2 = num;
			num = (short)1318186200;
			short num3 = num;
			num = (short)1131474136;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)2019491840;
				if (num != 0)
				{
				}
				if (this.a(oldIndex, newIndex))
				{
					global::AcpCommonLib.UndoRedo.UndoManager.AddTask(new global::AcpBusinessLayer.UndoRedo.MoveRecordTask((global::AcpBusinessLayer.FeatureNode)this[oldIndex], newIndex));
					return;
				}
				num = (short)1069613057;
				if (num != 0)
				{
				}
				break;
			}
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00055CBC File Offset: 0x00053EBC
		public void MoveRecord(int oldIndex, int newIndex, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1468661760;
			short num2 = num;
			num = (short)169381325;
			short num3 = num;
			num = (short)315919821;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)761921536;
				if (num != 0)
				{
				}
				if (this.a(oldIndex, newIndex))
				{
					num = (short)1392246785;
					if (num != 0)
					{
					}
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.MoveRecordTask((global::AcpBusinessLayer.FeatureNode)this[oldIndex], newIndex));
					return;
				}
				break;
			}
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00055D8C File Offset: 0x00053F8C
		private bool a(int A_0, int A_1)
		{
			short num = (short)139395074;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return false;
				case 1:
					num = (short)731250691;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					num = (short)340262913;
					if (num != 0)
					{
					}
					num = (short)779878400;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_9D;
					}
					continue;
				}
				case 3:
					if (global::AcpCommonLib.Permission.Have(global::AcpCommonLib.Permissions.InsertAfterDisabled, this[A_1].Permissions))
					{
						num = (short)273022981;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BA;
				case 4:
					if (!global::AcpCommonLib.Permission.Have((global::AcpCommonLib.Permissions)6, this[A_0].Permissions))
					{
						num = (short)1111687176;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 5:
					return false;
				case 6:
					goto IL_190;
				case 7:
					if (global::AcpCommonLib.Permission.Have((global::AcpCommonLib.Permissions)6, this[A_1].Permissions))
					{
						num = (short)903544838;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 8:
					num = (short)1238564871;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (global::AcpCommonLib.Permission.Have(global::AcpCommonLib.Permissions.InsertBeforeDisabeled, this[A_1].Permissions))
					{
						num = (short)2028863488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BA;
				}
				IL_9D:
				if (A_0 < A_1)
				{
					num = (short)342556673;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1503016000;
				short num4 = num;
				num = (short)36058176;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1841692672;
					if (num != 0)
					{
					}
					num = (short)1334706185;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_BA:
				num = (short)1796669444;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_190:
			return false;
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x00055FC4 File Offset: 0x000541C4
		// (set) Token: 0x06000412 RID: 1042 RVA: 0x00056074 File Offset: 0x00054274
		public string RecordsetName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)769006728;
				short num2 = num;
				num = (short)1765022856;
				switch (num2 == num)
				{
				}
				num = (short)834797569;
				if (num != 0)
				{
				}
				num = (short)601489408;
				if (num != 0)
				{
				}
				num = (short)607059968;
				short num3 = num;
				return this.k;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1621504164;
				short num2 = num;
				num = (short)1170223268;
				switch (num2 == num)
				{
				}
				num = (short)820314113;
				if (num != 0)
				{
				}
				num = (short)189595648;
				if (num != 0)
				{
				}
				num = (short)872022016;
				short num3 = num;
				this.k = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x00056124 File Offset: 0x00054324
		public int RecsetId
		{
			get
			{
				short num = (short)1153892353;
				if (num != 0)
				{
				}
				num = (short)1654713551;
				short num2 = num;
				num = (short)307096783;
				switch (num2 == num)
				{
				}
				num = (short)1794441216;
				if (num != 0)
				{
				}
				num = (short)1653145600;
				short num3 = num;
				return this.Id;
			}
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x000561D4 File Offset: 0x000543D4
		public new void Clear()
		{
			short num = (short)558694400;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 1:
					return;
				case 2:
				{
					if (this.Count > 0)
					{
						this.RemoveRecordInternal(this.Count - 1, new bool?(false));
						num = (short)83034115;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)893400015;
					short num3 = num;
					num = (short)404566991;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num = (short)1429798913;
						if (num != 0)
						{
						}
						num = (short)1055326208;
						if (num != 0)
						{
						}
						num = (short)532086784;
						short num4 = num;
						num = (short)2124611585;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				}
				IL_37:
				num = (short)1342242818;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_35:
				goto IL_37;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x00056320 File Offset: 0x00054520
		public new int Count
		{
			get
			{
				short num = (short)2026504193;
				if (num != 0)
				{
				}
				num = (short)1176786277;
				short num2 = num;
				num = (short)1924879717;
				switch (num2 == num)
				{
				}
				num = (short)771883008;
				if (num != 0)
				{
				}
				num = (short)986906624;
				short num3 = num;
				return base.Count;
			}
		}

		// Token: 0x170000F7 RID: 247
		public global::AcpCommonLib.IAcpFeatureNode this[int index]
		{
			get
			{
				short num = (short)2058513464;
				short num2 = num;
				num = (short)1055484984;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)352452608;
					if (num != 0)
					{
					}
					num = (short)2132279297;
					if (num != 0)
					{
					}
					if (index >= base.Count)
					{
						num = (short)1789067264;
						short num3 = num;
						return null;
					}
					break;
				}
				return base[index];
			}
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00056490 File Offset: 0x00054690
		public int IndexOf(global::AcpCommonLib.IAcpFeatureNode record)
		{
			short num = (short)1904152125;
			short num2 = num;
			num = (short)374410813;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)741539841;
				if (num != 0)
				{
				}
				num = (short)1342177280;
				if (num != 0)
				{
				}
				if (!base.Contains(record as global::AcpBusinessLayer.FeatureNode))
				{
					num = (short)749731840;
					short num3 = num;
					return -1;
				}
				break;
			}
			return base.IndexOf((global::AcpBusinessLayer.FeatureNode)record);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00056558 File Offset: 0x00054758
		public void CalculateValidity()
		{
			short num = (short)595787776;
			short num2 = num;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = base.GetEnumerator();
			try
			{
				num = (short)297140225;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_15A;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_6B;
						}
						continue;
					case 2:
						if (!enumerator.MoveNext())
						{
							num = (short)1282539524;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpCommonLib.IAcpConstraints)enumerator.Current).CalculateValidity();
						num = (short)1439498243;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)1740919997;
						short num4 = num;
						num = (short)4019389;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)116195328;
							if (num != 0)
							{
							}
							num = (short)751697921;
							if (num != 0)
							{
							}
							break;
						}
						break;
					}
					case 4:
						num = (short)2067202048;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_104:
					num = (short)260440066;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_6B:
					goto IL_104;
				}
				IL_15A:;
			}
			finally
			{
				num = (short)2050359297;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)154599426;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_18C;
						}
						continue;
					case 2:
						goto IL_1C0;
					}
					IL_18C:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1547829248;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1C0:;
			}
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00056744 File Offset: 0x00054944
		public void CalculateApplicability()
		{
			short num = (short)452795935;
			short num2 = num;
			num = (short)175054367;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)929366016;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = base.GetEnumerator();
				try
				{
					num = (short)2017853441;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_FA;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_8C;
							}
							continue;
						case 3:
							num = (short)838533120;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (!enumerator.MoveNext())
							{
								num = (short)1697579011;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							((global::AcpCommonLib.IAcpConstraints)enumerator.Current).CalculateApplicability();
							num = (short)994508802;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_AF:
						num = (short)1397817348;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_8C:
						goto IL_AF;
					}
					IL_FA:;
				}
				finally
				{
					num = (short)710803456;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_130;
							}
							continue;
						case 1:
							goto IL_165;
						case 2:
							enumerator.Dispose();
							num = (short)727121921;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_130:
						if (enumerator == null)
						{
							goto IL_18F;
						}
						num = (short)457179138;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_165:
					num = (short)1349124097;
					if (num != 0)
					{
					}
					IL_18F:;
				}
				break;
			}
			}
			num = (short)1502150656;
			short num4 = num;
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x0005691C File Offset: 0x00054B1C
		public void CalculateVisibility()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1561384490;
					short num3 = num2;
					num2 = (short)280942122;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_236;
					default:
					{
						num2 = (short)508035072;
						if (num2 != 0)
						{
						}
						num2 = (short)195100672;
						short num4 = num2;
						num2 = (short)1720123393;
						if (num2 != 0)
						{
						}
						if (this.TemplateNode != null)
						{
							num2 = (short)1820917763;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					}
					break;
				}
				case 1:
					try
					{
						num2 = (short)2023751681;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_1BE;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_14F;
								}
								continue;
							case 3:
								num2 = (short)944701440;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 4:
								if (!enumerator.MoveNext())
								{
									num2 = (short)820051971;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								((global::AcpCommonLib.IAcpConstraints)enumerator.Current).CalculateVisibility();
								num2 = (short)1480458242;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_173:
							num2 = (short)1636696068;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_14F:
							goto IL_173;
						}
						IL_1BE:
						goto IL_40;
					}
					finally
					{
						num2 = (short)1225392128;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_1F3;
								}
								continue;
							case 1:
								goto IL_228;
							case 2:
								enumerator.Dispose();
								num2 = (short)1154088961;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_1F3:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)357367810;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_228:;
					}
					goto IL_22B;
					IL_40:
					num2 = (short)2068905984;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return;
				case 3:
					goto IL_22B;
				}
				goto IL_20;
				IL_236:
				num2 = (short)118816770;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_22B:
				this.TemplateNode.CalculateVisibility();
				goto IL_236;
			}
			return;
			IL_20:
			enumerator = base.GetEnumerator();
			num2 = (short)1333329921;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00056B88 File Offset: 0x00054D88
		public void CalculateEditability()
		{
			short num = (short)60293121;
			if (num != 0)
			{
			}
			num = (short)1354507540;
			short num2 = num;
			num = (short)150414612;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1664614400;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = base.GetEnumerator();
				try
				{
					num = (short)582746113;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_124;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_B6;
							}
							continue;
						case 3:
							num = (short)458686464;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (!enumerator.MoveNext())
							{
								num = (short)146276355;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							((global::AcpCommonLib.IAcpConstraints)enumerator.Current).CalculateEditability();
							num = (short)429719554;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_DA:
						num = (short)1381302276;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_B6:
						goto IL_DA;
					}
					IL_124:;
				}
				finally
				{
					num = (short)1330905088;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_156;
							}
							continue;
						case 1:
							goto IL_18A;
						case 2:
							enumerator.Dispose();
							num = (short)1169489921;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_156:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1594753026;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_18A:;
				}
				break;
			}
			}
			num = (short)1500643328;
			short num4 = num;
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00056D5C File Offset: 0x00054F5C
		public void CalculateVisibility(bool allFields)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)26020238;
					short num3 = num2;
					num2 = (short)1014696334;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_20F;
					default:
					{
						num2 = (short)1973026816;
						if (num2 != 0)
						{
						}
						num2 = (short)1021050880;
						short num4 = num2;
						if (this.TemplateNode != null)
						{
							num2 = (short)861536259;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					}
					break;
				}
				case 1:
					try
					{
						num2 = (short)170655745;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_195;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_127;
								}
								continue;
							case 3:
								num2 = (short)1952317440;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 4:
								if (!enumerator.MoveNext())
								{
									num2 = (short)59310083;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								enumerator.Current.CalculateVisibility(allFields);
								num2 = (short)489095170;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_14B:
							num2 = (short)69861380;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_127:
							goto IL_14B;
						}
						IL_195:
						goto IL_40;
					}
					finally
					{
						num2 = (short)381485056;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_1CB;
								}
								continue;
							case 1:
								goto IL_200;
							case 2:
								enumerator.Dispose();
								num2 = (short)700776449;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_1CB:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)47579138;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_200:;
					}
					goto IL_203;
					IL_40:
					num2 = (short)1912995840;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_227;
				case 3:
					goto IL_203;
				}
				goto IL_20;
				IL_20F:
				num2 = (short)1864302594;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_203:
				this.TemplateNode.CalculateVisibility(allFields);
				goto IL_20F;
			}
			IL_227:
			num2 = (short)678166529;
			if (num2 != 0)
			{
			}
			return;
			IL_20:
			enumerator = base.GetEnumerator();
			num2 = (short)1754005505;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00056FC8 File Offset: 0x000551C8
		public void CalculateEditability(bool allFields)
		{
			short num = (short)1144100614;
			short num2 = num;
			num = (short)827889414;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)445317121;
				if (num != 0)
				{
				}
				num = (short)1048117248;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = base.GetEnumerator();
				try
				{
					num = (short)1862008833;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_124;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_B6;
							}
							continue;
						case 3:
							num = (short)314310656;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (!enumerator.MoveNext())
							{
								num = (short)1344733187;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							enumerator.Current.CalculateEditability(allFields);
							num = (short)1561460738;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_DB:
						num = (short)144310276;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_B6:
						goto IL_DB;
					}
					IL_124:;
				}
				finally
				{
					num = (short)23330816;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_158;
							}
							continue;
						case 1:
							goto IL_18C;
						case 2:
							enumerator.Dispose();
							num = (short)831913985;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_158:
						if (enumerator == null)
						{
							break;
						}
						num = (short)163119106;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_18C:;
				}
				break;
			}
			}
			num = (short)905707520;
			short num4 = num;
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x000571A0 File Offset: 0x000553A0
		public bool _HasDiffs
		{
			get
			{
				short num = (short)333588744;
				short num2 = num;
				num = (short)1235560712;
				switch (num2 == num)
				{
				}
				num = (short)1932853249;
				if (num != 0)
				{
				}
				num = (short)1422131200;
				if (num != 0)
				{
				}
				num = (short)1038548992;
				short num3 = num;
				return this.DiffCount.Value > 0;
			}
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00057258 File Offset: 0x00055458
		public void ClearHasDiffs()
		{
			short num = (short)1453571595;
			short num2 = num;
			num = (short)1919401483;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1938751489;
				if (num != 0)
				{
				}
				num = (short)127074304;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = base.GetEnumerator();
				try
				{
					num = (short)67108865;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_122;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_B3;
							}
							continue;
						case 3:
							num = (short)2034827264;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (!enumerator.MoveNext())
							{
								num = (short)541982723;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current).ClearHasDiffs();
							num = (short)2001207298;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_D6:
						num = (short)1413152772;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_B3:
						goto IL_D6;
					}
					IL_122:;
				}
				finally
				{
					num = (short)436600832;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_154;
							}
							continue;
						case 1:
							goto IL_189;
						case 2:
							enumerator.Dispose();
							num = (short)1280180225;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_154:
						if (enumerator == null)
						{
							break;
						}
						num = (short)771031042;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_189:;
				}
				break;
			}
			}
			num = (short)218890240;
			short num4 = num;
			this.DiffCount.Reset(this.RecordsetName);
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x0005743C File Offset: 0x0005563C
		public bool HasVisibleObjects
		{
			get
			{
				short num = (short)1374490984;
				short num2 = num;
				num = (short)2119111016;
				bool result;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return result;
				case 1:
					break;
				default:
				{
					num = (short)664141824;
					short num3 = num;
					break;
				}
				}
				num = (short)992018433;
				if (num != 0)
				{
				}
				num = (short)1739194368;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = base.GetEnumerator();
				try
				{
					num = (short)677314563;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							if (!enumerator.MoveNext())
							{
								num = (short)1769209860;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1676279810;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_172;
						case 2:
							if (((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current).HasVisibleObjects)
							{
								num = (short)1405157382;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_E7;
							}
							continue;
						case 4:
							num = (short)1396047877;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_18F;
						case 6:
							result = true;
							num = (short)1846083585;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_E9:
						num = (short)85983232;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_E7:
						goto IL_E9;
					}
					IL_172:
					return result;
					IL_18F:
					return false;
				}
				finally
				{
					num = (short)1760493568;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_1C4;
							}
							continue;
						case 1:
							goto IL_1FA;
						case 2:
							enumerator.Dispose();
							num = (short)1332215809;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1C4:
						if (enumerator == null)
						{
							break;
						}
						num = (short)524615682;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_1FA:;
				}
				return result;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x00057658 File Offset: 0x00055858
		// (set) Token: 0x06000422 RID: 1058 RVA: 0x00057708 File Offset: 0x00055908
		public bool _IsEmpty
		{
			get
			{
				short num = (short)636185226;
				short num2 = num;
				num = (short)718301834;
				switch (num2 == num)
				{
				}
				num = (short)1814429696;
				if (num != 0)
				{
				}
				num = (short)842006529;
				if (num != 0)
				{
				}
				num = (short)2005073920;
				short num3 = num;
				return this.l;
			}
			set
			{
				int a_ = 8;
				short num = (short)1748238336;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)222035968;
						short num3 = num;
						switch (0)
						{
						case 0:
							goto IL_63;
						}
						continue;
					}
					case 1:
						goto IL_B8;
					case 2:
						this.l = value;
						this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("鏙꿛鯝跟鋡郣鿥", a_)));
						num = (short)189267969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_63:
					if (this.l == value)
					{
						break;
					}
					num = (short)1823145986;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_B8:
				num = (short)1297220737;
				short num4 = num;
				num = (short)282657921;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_B8;
				default:
					num = (short)129564672;
					if (num != 0)
					{
					}
					num = (short)630259713;
					if (num != 0)
					{
					}
					return;
				}
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x00057844 File Offset: 0x00055A44
		// (set) Token: 0x06000424 RID: 1060 RVA: 0x000578F4 File Offset: 0x00055AF4
		public bool SingleInstance
		{
			get
			{
				short num = (short)446173185;
				short num2 = num;
				num = (short)136843265;
				switch (num2 == num)
				{
				}
				num = (short)626982913;
				if (num != 0)
				{
				}
				num = (short)1394016256;
				if (num != 0)
				{
				}
				num = (short)1857814528;
				short num3 = num;
				return this.d;
			}
			protected set
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
						num2 = (short)1152647169;
						if (num2 != 0)
						{
						}
						num2 = (short)1599152669;
						short num3 = num2;
						num2 = (short)1079190045;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F2;
						default:
							num2 = (short)744357888;
							if (num2 != 0)
							{
							}
							if (this.d)
							{
								num2 = (short)916520962;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_F2;
						}
						break;
					}
					case 1:
						goto IL_F0;
					case 2:
						this.Max = 1;
						this.Min = 1;
						num2 = (short)1869217793;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C;
				}
				IL_F0:
				IL_F2:
				num2 = (short)1483800576;
				short num4 = num2;
				return;
				IL_1C:
				this.d = value;
				num2 = (short)513671168;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x00057A20 File Offset: 0x00055C20
		// (set) Token: 0x06000426 RID: 1062 RVA: 0x00057AD0 File Offset: 0x00055CD0
		public string UIPagePath
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1695738108;
				short num2 = num;
				num = (short)961865980;
				switch (num2 == num)
				{
				}
				num = (short)2052521985;
				if (num != 0)
				{
				}
				num = (short)2143879168;
				if (num != 0)
				{
				}
				num = (short)794689536;
				short num3 = num;
				return this.m;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)42197940;
				short num2 = num;
				num = (short)1592714164;
				switch (num2 == num)
				{
				}
				num = (short)855048192;
				if (num != 0)
				{
				}
				num = (short)401539073;
				if (num != 0)
				{
				}
				num = (short)1068761088;
				short num3 = num;
				this.m = value;
			}
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00057B84 File Offset: 0x00055D84
		public global::AcpCommonLib.IAcpFeatureNode NodeFromId(int nodeId)
		{
			short num = (short)2114268275;
			short num2 = num;
			num = (short)1511926899;
			global::AcpCommonLib.IAcpFeatureNode result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			case 1:
				break;
			default:
			{
				num = (short)638517248;
				short num3 = num;
				break;
			}
			}
			num = (short)864813056;
			if (num != 0)
			{
			}
			num = (short)174260225;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = base.GetEnumerator();
			try
			{
				num = (short)101515267;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)504365060;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
						num = (short)959709186;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_19B;
					case 2:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
						if (acpFeatureNode.NodeId == nodeId)
						{
							num = (short)1447231494;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_10D;
						}
						continue;
					case 4:
						num = (short)1770717189;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_1B7;
					case 6:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
						result = acpFeatureNode;
						num = (short)811859969;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_10F:
					num = (short)1871708160;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_10D:
					goto IL_10F;
				}
				IL_19B:
				return result;
				IL_1B7:
				goto IL_A5;
			}
			finally
			{
				num = (short)783745024;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_1EC;
						}
						continue;
					case 1:
						goto IL_222;
					case 2:
						enumerator.Dispose();
						num = (short)912195585;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_1EC:
					if (enumerator == null)
					{
						break;
					}
					num = (short)977534978;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_222:;
			}
			return result;
			IL_A5:
			throw new global::System.ArgumentException(global::AcpCommonResources.AcpResources.Not_Have_Node.AcpStringFormat(new object[]
			{
				this.RecordsetName,
				nodeId
			}));
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00057DC8 File Offset: 0x00055FC8
		public global::AcpCommonLib.IAcpFeatureNode NodeFromKey(string key)
		{
			short num = (short)1511260160;
			short num2 = num;
			num = (short)1114842027;
			short num3 = num;
			num = (short)1309483947;
			switch (num3 == num)
			{
			}
			num = (short)160104449;
			if (num != 0)
			{
			}
			num = (short)1066467328;
			if (num != 0)
			{
			}
			return this.KeysToNode.LookupHelper(key);
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x00057E7C File Offset: 0x0005607C
		// (set) Token: 0x0600042A RID: 1066 RVA: 0x00057F30 File Offset: 0x00056130
		public bool HasEmbeddedRecset
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1876099072;
				short num2 = num;
				num = (short)1333985281;
				if (num != 0)
				{
				}
				num = (short)436776707;
				short num3 = num;
				num = (short)1471065859;
				switch (num3 == num)
				{
				}
				num = (short)485949440;
				if (num != 0)
				{
				}
				return this.n;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)271187968;
				short num2 = num;
				num = (short)1603573419;
				short num3 = num;
				num = (short)340432555;
				switch (num3 == num)
				{
				}
				num = (short)1210712065;
				if (num != 0)
				{
				}
				num = (short)718864384;
				if (num != 0)
				{
				}
				this.n = value;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x00057FE0 File Offset: 0x000561E0
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x00058090 File Offset: 0x00056290
		public bool IsEmbeddedRecset
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1104740352;
				short num2 = num;
				num = (short)1144848385;
				if (num != 0)
				{
				}
				num = (short)1622551749;
				short num3 = num;
				num = (short)1061825733;
				switch (num3 == num)
				{
				}
				num = (short)1041498112;
				if (num != 0)
				{
				}
				return this.o;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			internal set
			{
				short num = (short)106037248;
				short num2 = num;
				num = (short)472954539;
				short num3 = num;
				num = (short)1771615915;
				switch (num3 == num)
				{
				}
				num = (short)472317952;
				if (num != 0)
				{
				}
				num = (short)1510670337;
				if (num != 0)
				{
				}
				this.o = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x00058140 File Offset: 0x00056340
		// (set) Token: 0x0600042E RID: 1070 RVA: 0x000581F0 File Offset: 0x000563F0
		public bool HasKeyField
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)334036992;
				short num2 = num;
				num = (short)439125082;
				short num3 = num;
				num = (short)164201562;
				switch (num3 == num)
				{
				}
				num = (short)507838464;
				if (num != 0)
				{
				}
				num = (short)1563230209;
				if (num != 0)
				{
				}
				return this.p;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)263651328;
				short num2 = num;
				num = (short)278331377;
				short num3 = num;
				num = (short)1838743537;
				switch (num3 == num)
				{
				}
				num = (short)1928396801;
				if (num != 0)
				{
				}
				num = (short)733151232;
				if (num != 0)
				{
				}
				this.p = value;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x000582A4 File Offset: 0x000564A4
		// (set) Token: 0x06000430 RID: 1072 RVA: 0x00058354 File Offset: 0x00056554
		public global::AcpCommonLib.IAcpFeatureSection ParentSection
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1274806272;
				short num2 = num;
				num = (short)1965948929;
				if (num != 0)
				{
				}
				num = (short)1387251757;
				short num3 = num;
				num = (short)66504749;
				switch (num3 == num)
				{
				}
				num = (short)2108555264;
				if (num != 0)
				{
				}
				return this.q;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1365377024;
				short num2 = num;
				num = (short)622919681;
				if (num != 0)
				{
				}
				num = (short)795101902;
				short num3 = num;
				num = (short)148982478;
				switch (num3 == num)
				{
				}
				num = (short)1878327296;
				if (num != 0)
				{
				}
				this.q = value;
			}
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00058404 File Offset: 0x00056604
		public global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> Search(string token)
		{
			short num = (short)1015480320;
			short num2 = num;
			num = (short)474896782;
			short num3 = num;
			num = (short)322591118;
			switch (num3 == num)
			{
			}
			num = (short)1853554688;
			if (num != 0)
			{
			}
			num = (short)250871809;
			if (num != 0)
			{
			}
			return this.a(token, false);
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x000584B4 File Offset: 0x000566B4
		public global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> SearchAll(string token)
		{
			short num = (short)98631680;
			short num2 = num;
			num = (short)1589287179;
			short num3 = num;
			num = (short)1593809163;
			switch (num3 == num)
			{
			}
			num = (short)1540096000;
			if (num != 0)
			{
			}
			num = (short)575012865;
			if (num != 0)
			{
			}
			return this.a(token, true);
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00058568 File Offset: 0x00056768
		private global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> a(string A_0, bool A_1)
		{
			short num = (short)1627521024;
			short num2 = num;
			num = (short)1034102120;
			short num3 = num;
			num = (short)1696146792;
			switch (num3 == num)
			{
			}
			num = (short)138543105;
			if (num != 0)
			{
			}
			num = (short)1034485760;
			if (num != 0)
			{
			}
			global::AcpBusinessLayer.Recordset.<SearchConditionally>d__141 <SearchConditionally>d__ = new global::AcpBusinessLayer.Recordset.<SearchConditionally>d__141(-2);
			<SearchConditionally>d__.<>4__this = this;
			<SearchConditionally>d__.<>3__token = A_0;
			<SearchConditionally>d__.<>3__searchHiddenStatic = A_1;
			return <SearchConditionally>d__;
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x0005862C File Offset: 0x0005682C
		public bool AddToXml(global::System.Xml.XmlNode node, global::AcpCommonLib.XmlFileType fileType)
		{
			int a_ = 0;
			short num = (short)1421541377;
			if (num != 0)
			{
			}
			num = (short)1386807296;
			switch (num)
			{
			default:
			{
				num = (short)1980825603;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Xml.XmlElement xmlElement;
					bool flag;
					switch (num2)
					{
					case 0:
						goto IL_134;
						try
						{
							for (;;)
							{
								IL_134:
								num = (short)239403010;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
										if (enumerator.MoveNext())
										{
											global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
											num = (short)809435139;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)549345088;
										short num3 = num;
										num = (short)773478208;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_134;
										default:
											num = (short)1138098176;
											if (num != 0)
											{
											}
											num = (short)1519976453;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
										switch (0)
										{
										case 0:
											goto IL_177;
										}
										continue;
									case 3:
									{
										global::AcpBusinessLayer.FeatureNode featureNode;
										if (featureNode.HasVisibleObjects)
										{
											num = (short)1185284100;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 4:
									{
										global::AcpBusinessLayer.FeatureNode featureNode;
										featureNode.AddToXml(xmlElement, fileType);
										num = (short)541655041;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
										num = (short)1344798726;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
										goto IL_289;
									}
									IL_179:
									num = (short)602669056;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_177:
									goto IL_179;
								}
							}
							IL_289:
							goto IL_DE;
						}
						finally
						{
							num = (short)1494679553;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)693043202;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2C0;
									}
									continue;
								case 2:
									goto IL_2F6;
								}
								IL_2C0:
								if (enumerator == null)
								{
									break;
								}
								num = (short)330301440;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2F6:;
						}
						goto IL_2F9;
					case 1:
						if (!flag)
						{
							num = (short)957087750;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 2:
						return true;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_96;
						}
						continue;
					case 4:
						goto IL_DE;
					case 5:
					{
						if (xmlElement.GetAttribute(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("鯑냓", a_)) == global::AcpBusinessLayer.UndoRedo.SetValueTask.b("", a_))
						{
							num = (short)1119420416;
							short num4 = num;
							num = (short)1758986247;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = base.Items.GetEnumerator();
						num = (short)1309212672;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_2F9;
					case 7:
						flag = this.AddTrunkingSystemToXml(xmlElement, fileType);
						num = (short)1216282628;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_96:
					xmlElement = node.OwnerDocument.CreateElement(this.IsEmbeddedRecset ? global::AcpBusinessLayer.UndoRedo.SetValueTask.b("韑맓듕뷗뻙룛믝蓟냡臣藥鯧迩飫", a_) : global::AcpBusinessLayer.UndoRedo.SetValueTask.b("胑뇓뗕ꯗ뿙꣛", a_));
					xmlElement.SetAttribute(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("鳑뗓믕뷗", a_), this.UIName);
					xmlElement.SetAttribute(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("鯑냓", a_), this.Id.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
					flag = true;
					num = (short)384172037;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DE:
					node.AppendChild(xmlElement);
					num = (short)1823539201;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2F9:
					global::AcpBusinessLayer.TrunkingSystemData.PartialXmlExport = true;
					num = (short)1309409282;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
			}
			}
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00058A6C File Offset: 0x00056C6C
		public bool AddTrunkingSystemToXml(global::System.Xml.XmlElement recsetElement, global::AcpCommonLib.XmlFileType fileType)
		{
			short num = (short)2075590656;
			switch (num)
			{
			default:
			{
				num = (short)1554186240;
				short num2 = num;
				bool flag = true;
				global::System.Collections.Generic.IEnumerable<global::AcpBusinessLayer.FeatureNode> items = base.Items;
				global::System.Func<global::AcpBusinessLayer.FeatureNode, bool> predicate = delegate(global::AcpBusinessLayer.FeatureNode item)
				{
					short num8 = (short)144180710;
					short num9 = num8;
					num8 = (short)915408358;
					switch (num9 == num8)
					{
					}
					num8 = (short)900988929;
					if (num8 != 0)
					{
					}
					num8 = (short)1054932992;
					if (num8 != 0)
					{
					}
					num8 = (short)991035392;
					short num10 = num8;
					return item.HasVisibleObjects;
				};
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = items.Where(predicate).GetEnumerator();
					try
					{
						num = (short)1225326595;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							int? num4;
							int? num5;
							global::AcpBusinessLayer.FeatureNode featureNode;
							bool? flag3;
							bool? flag4;
							switch (num3)
							{
							case 0:
								num = (short)1410990098;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								if (num4 != null)
								{
									num = (short)736362503;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_3DE;
							case 2:
							{
								int? num6;
								num5 = num6;
								goto IL_232;
							}
							case 3:
								switch (0)
								{
								case 0:
									goto IL_D8;
								}
								continue;
							case 4:
							{
								num = (short)858276479;
								short num7 = num;
								num = (short)1983595135;
								switch ((num7 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
								{
									num = (short)828768256;
									if (num != 0)
									{
									}
									global::AcpBusinessLayer.AcpField<bool> acpField = featureNode.AllFields.Single(delegate(global::AcpCommonLib.IAcpField field)
									{
										int a_ = 8;
										short num8 = (short)1146091833;
										short num9 = num8;
										num8 = (short)1024981305;
										switch (num9 == num8)
										{
										}
										num8 = (short)1678442497;
										if (num8 != 0)
										{
										}
										num8 = (short)599326720;
										if (num8 != 0)
										{
										}
										num8 = (short)838467584;
										short num10 = num8;
										return field.Name == global::AcpBusinessLayer.UndoRedo.SetValueTask.b("軙껛뗝돟鯡韣ꇥ跧蓩觫鳭釯黱뗳藵鏷꣹駻追痿欁瘃挅氇唉䴋㨍␏⬑␓⼕", a_);
									}) as global::AcpBusinessLayer.AcpField<bool>;
									if (acpField == null)
									{
										bool? flag2 = null;
										num = (short)701169669;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									flag3 = new bool?(acpField.Value);
									goto IL_1B0;
								}
								}
								break;
							}
							case 5:
							{
								bool? flag2;
								flag3 = flag2;
								goto IL_1B0;
							}
							case 7:
								num = (short)1946812435;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
								flag = false;
								num = (short)887029775;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 9:
								if (flag)
								{
									num = (short)293273608;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 10:
								if (flag4 != null)
								{
									num = (short)1937244174;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_3DE;
							case 12:
								num = (short)736886804;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 13:
								featureNode.AddToXml(recsetElement, fileType);
								num = (short)1829240838;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 14:
								num = (short)669450241;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 15:
								num = (short)1826488321;
								if (num != 0)
								{
								}
								break;
							case 16:
							{
								global::AcpBusinessLayer.AcpSimpleRangeField acpSimpleRangeField = featureNode.AllFields.Single(delegate(global::AcpCommonLib.IAcpField field)
								{
									int a_ = 19;
									short num8 = (short)490602497;
									if (num8 != 0)
									{
									}
									num8 = (short)1897232780;
									short num9 = num8;
									num8 = (short)332036492;
									switch (num9 == num8)
									{
									}
									num8 = (short)931332096;
									if (num8 != 0)
									{
									}
									num8 = (short)888995840;
									short num10 = num8;
									return field.Name == global::AcpBusinessLayer.UndoRedo.SetValueTask.b("뇤闦苨룪铬鳮뛰雲鯴鋶诸髺釼곾砀瀂焄戆搈䈊䤌倎倐⨒✔␖‘", a_);
								}) as global::AcpBusinessLayer.AcpSimpleRangeField;
								if (acpSimpleRangeField == null)
								{
									int? num6 = null;
									num = (short)1824391170;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								num5 = new int?(acpSimpleRangeField.Value);
								goto IL_232;
							}
							case 17:
								if (!enumerator.MoveNext())
								{
									num = (short)446300172;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								featureNode = enumerator.Current;
								num = (short)1034551300;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 18:
								if (global::AcpBusinessLayer.TrunkingSystemData.SystemKeyManager.IsUnLimitedASKLoaded(num4.Value, 0, false))
								{
									num = (short)113704973;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1204682761;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 19:
								if (flag4.Value)
								{
									num = (short)1457782784;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_3DE;
							case 20:
								goto IL_45A;
							}
							goto IL_D8;
							IL_1B0:
							flag4 = flag3;
							num = (short)1548877840;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_232:
							num4 = num5;
							num = (short)700776458;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_3DE:
							featureNode.AddToXml(recsetElement, fileType);
							num = (short)1112473611;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_401:
							num = (short)1172897809;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_D8:
							goto IL_401;
						}
						IL_45A:
						break;
					}
					finally
					{
						num = (short)645136385;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								enumerator.Dispose();
								num = (short)1091698690;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_491;
								}
								continue;
							case 2:
								goto IL_4C7;
							}
							IL_491:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1704656896;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_4C7:;
					}
				}
				return flag;
			}
			}
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00058F8C File Offset: 0x0005718C
		public bool ReadFromXml(global::System.Xml.XmlNode node, global::AcpCommonLib.UndoRedo.ContainerTask task, global::AcpCommonLib.XmlFileType fileType, bool importCopyOper, global::System.Collections.Generic.Dictionary<global::AcpCommonLib.IAcpField, string> RecRefsToRepair, global::System.Collections.Generic.Dictionary<global::AcpCommonLib.IAcpField, string> RecRefFieldsOfEmbedRecset)
		{
			int a_ = 5;
			short num = (short)1142554624;
			switch (num)
			{
			default:
			{
				num = (short)1755578387;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int num3;
					global::AcpBusinessLayer.FeatureNode featureNode2;
					int num4;
					int num5;
					int count;
					int num8;
					global::System.Collections.Generic.List<string> list;
					int num10;
					switch (num2)
					{
					case 0:
						num = (short)1161560075;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (this.Count > 0)
						{
							num = (short)315555861;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E3A;
					case 2:
						goto IL_CD7;
					case 3:
					{
						string message = global::AcpCommonResources.AcpResources.Max_Rec_Reached_Add.AcpStringFormat(new object[]
						{
							this.Path(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("诖", a_))
						});
						global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport.RegisterFieldInReport(null, message, false);
						num = (short)523305002;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num3 = 0;
						num = (short)656015427;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_70F;
					case 6:
					{
						if (this.CounterToMax == 0)
						{
							num = (short)779288579;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpBusinessLayer.FeatureNode featureNode = this.CreateDefaultRecordHelper();
						featureNode.CalculateVisibility(true);
						featureNode.CalculateEditability(true);
						global::AcpBusinessLayer.UndoRedo.AddRecordTask task2 = new global::AcpBusinessLayer.UndoRedo.AddRecordTask(featureNode);
						task.AddTask(task2);
						featureNode2 = (global::AcpBusinessLayer.FeatureNode)this.NodeFromId(featureNode.NodeId);
						num = (short)2074280017;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (num4 >= num5)
						{
							num = (short)217120844;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask((global::AcpBusinessLayer.FeatureNode)this[this.Count - 1]));
						num4++;
						num = (short)382599191;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (importCopyOper)
						{
							num = (short)113770508;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2068316170;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						num = (short)516489216;
						short num6 = num;
						string message2 = global::AcpCommonResources.AcpResources.Max_Rec_Reached_Add.AcpStringFormat(new object[]
						{
							this.Path(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("诖", a_))
						});
						global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport.RegisterFieldInReport(null, message2, false);
						num = (short)1367015425;
						if (num != 0)
						{
						}
						num = (short)771358771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						if (this.HasKeyField)
						{
							num = (short)2098069560;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1348730911;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (this.TemplateNode != null)
						{
							num = (short)96469053;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 12:
						num = (short)1623588932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)145162270;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						string value;
						featureNode2 = (global::AcpBusinessLayer.FeatureNode)this.NodeFromKey(value);
						num = (short)1565196305;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
					{
						int num7;
						if (num7 >= count)
						{
							num = (short)1363738637;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpBusinessLayer.FeatureNode)this[num7]).ReadFromXml(node.ChildNodes[num7], task, fileType, importCopyOper, RecRefsToRepair, RecRefFieldsOfEmbedRecset);
						num7++;
						num = (short)1628766265;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						goto IL_88E;
					case 17:
						goto IL_E3A;
					case 18:
						return true;
					case 19:
						switch (0)
						{
						case 0:
							goto IL_1A0;
						}
						continue;
					case 20:
						return true;
					case 21:
						num = (short)1755250727;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (num8 >= count)
						{
							num = (short)1523318834;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1856110665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_B7C;
					case 24:
					{
						num = (short)719518971;
						short num9 = num;
						num = (short)1434385659;
						switch ((num9 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_BB8;
						default:
							num = (short)1708195840;
							if (num != 0)
							{
							}
							this.ClearRecordset(this, task);
							num = (short)1404305441;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 25:
						goto IL_45C;
					case 26:
						if (featureNode2 == null)
						{
							num = (short)381026364;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F66;
					case 27:
						num8 = 0;
						goto IL_BB8;
					case 28:
						if (this.Count <= 0)
						{
							num = (short)2140602368;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 29:
						num = (short)2006974538;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						return true;
					case 31:
						if (!this.SingleInstance)
						{
							num = (short)144441348;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpBusinessLayer.FeatureNode)this[0]).ReadFromXml(node.ChildNodes[0], task, fileType, importCopyOper, RecRefsToRepair, RecRefFieldsOfEmbedRecset);
						num = (short)244318292;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						goto IL_45C;
					case 33:
						goto IL_AA9;
					case 34:
						num = (short)1399717933;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						goto IL_7F0;
					case 36:
						((global::AcpBusinessLayer.FeatureNode)this[0]).ReadFromXml(node.ChildNodes[0], task, fileType, importCopyOper, RecRefsToRepair, RecRefFieldsOfEmbedRecset);
						num = (short)1626210374;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						((global::AcpBusinessLayer.FeatureNode)this[num8]).ReadFromXml(node.ChildNodes[num8], task, fileType, importCopyOper, RecRefsToRepair, RecRefFieldsOfEmbedRecset);
						num = (short)713687075;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
					{
						string message3 = global::AcpCommonResources.AcpResources.Max_Rec_Reached_Add.AcpStringFormat(new object[]
						{
							this.Path(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("诖", a_))
						});
						global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport.RegisterFieldInReport(null, message3, false);
						num = (short)1618935828;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 39:
					{
						string value;
						if (!list.Contains(value))
						{
							num = (short)1618411534;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E3A;
					}
					case 40:
						if (num3 < this.Count)
						{
							num = (short)1389756457;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1054146622;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						((global::AcpBusinessLayer.FeatureNode)this[num3]).ReadFromXml(node.ChildNodes[num3], task, fileType, importCopyOper, RecRefsToRepair, RecRefFieldsOfEmbedRecset);
						num = (short)1482227760;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						goto IL_F66;
					case 43:
						goto IL_384;
					case 44:
						return true;
					case 45:
						if (this.PreDataTransferClearRecordset)
						{
							num = (short)799670349;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_767;
					case 46:
						return true;
					case 47:
						if (num5 >= 0)
						{
							num = (short)2093416475;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5 = global::System.Math.Abs(num5);
						num = (short)896860218;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						goto IL_BD5;
					case 49:
						goto IL_7F0;
					case 50:
						num = (short)1316356114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
						return true;
					case 52:
						num = (short)1178927150;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
					{
						if (this.CounterToMax == 0)
						{
							num = (short)2000355366;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpBusinessLayer.FeatureNode featureNode3 = this.CreateDefaultRecordHelper();
						featureNode3.CalculateVisibility(true);
						featureNode3.CalculateEditability(true);
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(featureNode3));
						((global::AcpBusinessLayer.FeatureNode)this.NodeFromId(featureNode3.NodeId)).ReadFromXml(node.ChildNodes[num8], task, fileType, importCopyOper, RecRefsToRepair, RecRefFieldsOfEmbedRecset);
						num = (short)1443299377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 54:
					{
						if (num10 >= count)
						{
							num = (short)1934557248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						featureNode2 = null;
						string value = node.ChildNodes[num10].Attributes[global::AcpBusinessLayer.UndoRedo.SetValueTask.b("藖볘뷚룜귞蓠跢蛤苦ꋨ軪铬", a_)].Value;
						num = (short)443285505;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 55:
						return true;
					case 56:
						list = new global::System.Collections.Generic.List<string>();
						num10 = 0;
						num = (short)520159275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						goto IL_70F;
					case 58:
						if (num5 > this.CounterToMin)
						{
							num = (short)1263403080;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_88E;
					case 59:
						goto IL_384;
					case 60:
						num = (short)2060976134;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
					{
						global::System.Xml.XmlNode xmlNode = node.ChildNodes[0];
						num = (short)966393939;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 62:
					{
						if (this.CounterToMax == 0)
						{
							num = (short)1795424265;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpBusinessLayer.FeatureNode featureNode4 = this.CreateDefaultRecordHelper();
						featureNode4.CalculateVisibility(true);
						featureNode4.CalculateEditability(true);
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(featureNode4));
						((global::AcpBusinessLayer.FeatureNode)this.NodeFromId(featureNode4.NodeId)).ReadFromXml(node.ChildNodes[num3], task, fileType, importCopyOper, RecRefsToRepair, RecRefFieldsOfEmbedRecset);
						num = (short)1841954882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 63:
					{
						global::System.Xml.XmlNode xmlNode;
						this.TemplateNode.ReadFromXml(xmlNode, task, fileType, importCopyOper, RecRefsToRepair, RecRefFieldsOfEmbedRecset);
						num = (short)689373228;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 64:
						list.Clear();
						num = (short)950927415;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						if (featureNode2 != null)
						{
							num = (short)1222770722;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C41;
					case 66:
						goto IL_BD5;
					case 67:
						goto IL_CD7;
					case 68:
						if (this.PreDataTransferClearRecordset)
						{
							num = (short)1815609368;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AA9;
					case 69:
						goto IL_C41;
					case 70:
						return true;
					case 71:
						goto IL_767;
					case 72:
					{
						num5 = this.CounterToMin;
						string message4 = global::AcpCommonResources.AcpResources.Min_Rec_Reached_Delete.AcpStringFormat(new object[]
						{
							this.Path(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("诖", a_))
						});
						global::AcpCommonLib.AppInfoManager.ImportExportFieldsReport.RegisterFieldInReport(null, message4, false);
						num = (short)2082537488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 73:
						if (num8 < this.Count)
						{
							num = (short)475267109;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)357892149;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						if (fileType != global::AcpCommonLib.XmlFileType.CustomView)
						{
							num = (short)1384054836;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2087649358;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 75:
						if (num3 >= count)
						{
							num = (short)1576927314;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1446772776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 76:
					{
						int num7 = 0;
						num = (short)320667653;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 77:
						this.ClearMyEmbeddedRecsets(featureNode2, task, RecRefFieldsOfEmbedRecset);
						num = (short)730267719;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 78:
						if (this.Count > 0)
						{
							num = (short)1124466724;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1327890460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 79:
						return true;
					case 80:
						goto IL_B7C;
					case 81:
						goto IL_F66;
					case 82:
						num = (short)443285583;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 83:
					{
						global::System.Xml.XmlNode xmlNode;
						if (xmlNode != null)
						{
							num = (short)1804337215;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 84:
						return true;
					}
					IL_1A0:
					if (fileType != global::AcpCommonLib.XmlFileType.ImpExp)
					{
						num = (short)2089746461;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					count = node.ChildNodes.Count;
					num = (short)1320288264;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_384:
					num = (short)2062614582;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_45C:
					num = (short)1822097430;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_70F:
					num = (short)483852303;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_767:
					featureNode2.ReadFromXml(node.ChildNodes[num10], task, fileType, importCopyOper, RecRefsToRepair, RecRefFieldsOfEmbedRecset);
					list.Add(featureNode2.ReferenceKey);
					num = (short)203030597;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7F0:
					num8++;
					num = (short)849281049;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_88E:
					num4 = 0;
					num = (short)521404496;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AA9:
					num5 = count - this.Count;
					num = (short)650510383;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B7C:
					num = (short)222101511;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BB8:
					num = (short)1625554976;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BD5:
					num3++;
					num = (short)380174338;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C41:
					num10++;
					num = (short)958660667;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CD7:
					num = (short)1444085835;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E3A:
					num = (short)159842330;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F66:
					num = (short)1767112769;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
			}
			}
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00059FA8 File Offset: 0x000581A8
		public void ClearMyEmbeddedRecsets(global::AcpCommonLib.IAcpFeatureNode featureNode, global::AcpCommonLib.UndoRedo.ContainerTask task, global::System.Collections.Generic.Dictionary<global::AcpCommonLib.IAcpField, string> RecRefFieldsOfEmbedRecset)
		{
			short num = (short)1354956800;
			switch (num)
			{
			default:
			{
				num = (short)1690894338;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1215889408;
					short num3 = num;
					global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
					switch (num2)
					{
					case 0:
						num = (short)458620929;
						if (num != 0)
						{
						}
						try
						{
							num = (short)1523187713;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::AcpCommonLib.IAcpRecordset embeddedRecset;
								switch (num2)
								{
								case 0:
								{
									global::AcpBusinessLayer.FeatureSection featureSection;
									if (featureSection.EmbeddedRecset != null)
									{
										num = (short)945815569;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_10A;
									}
									continue;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = ((global::AcpBusinessLayer.Recordset)embeddedRecset).GetEnumerator();
									num = (short)2054291472;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::AcpBusinessLayer.FeatureNode featureNode2;
									if (featureNode2.KeyField != null)
									{
										num = (short)1249902601;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4C9;
								}
								case 4:
								{
									global::AcpBusinessLayer.FeatureSection featureSection;
									if (featureSection.EmbeddedRecset.Count > 0)
									{
										num = (short)385286149;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::AcpBusinessLayer.FeatureSection featureSection;
									embeddedRecset = featureSection.EmbeddedRecset;
									global::AcpBusinessLayer.FeatureNode featureNode2 = (global::AcpBusinessLayer.FeatureNode)embeddedRecset[0];
									num = (short)486211592;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									goto IL_615;
								case 8:
									if (embeddedRecset.Count > 0)
									{
										num = (short)1940914187;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4C9;
								case 9:
									num = (short)31981578;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
								{
									global::AcpBusinessLayer.FeatureNode featureNode2;
									if (featureNode2.KeyField.ReferencingFields != null)
									{
										num = (short)664993794;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4C9;
								}
								case 11:
									num = (short)1300955139;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
								{
									global::AcpBusinessLayer.FeatureSection featureSection;
									if (featureSection.HasEmbeddedRecset)
									{
										num = (short)669057037;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 13:
									num = (short)1845559296;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)736362511;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureSection featureSection = (global::AcpBusinessLayer.FeatureSection)enumerator2.Current;
									num = (short)1298792460;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 15:
									num = (short)94175239;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									try
									{
										num = (short)317587460;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												try
												{
													num = (short)1025179652;
													num2 = (int)((global::System.IntPtr)num);
													for (;;)
													{
														switch (num2)
														{
														case 1:
															num = (short)1104674818;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 2:
															goto IL_27D;
														case 3:
														{
															global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpRecRefField> enumerator3;
															if (!enumerator3.MoveNext())
															{
																num = (short)258539521;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															global::AcpBusinessLayer.AcpRecRefField acpRecRefField = enumerator3.Current;
															RecRefFieldsOfEmbedRecset[acpRecRefField] = acpRecRefField.UIValue;
															num = (short)1993867264;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 4:
															switch (0)
															{
															case 0:
																goto IL_1F8;
															}
															continue;
														}
														IL_22A:
														num = (short)716963843;
														num2 = (int)((global::System.IntPtr)num);
														continue;
														IL_1F8:
														goto IL_22A;
													}
													IL_27D:;
												}
												finally
												{
													num = (short)1620574210;
													num2 = (int)((global::System.IntPtr)num);
													for (;;)
													{
														global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpRecRefField> enumerator3;
														switch (num2)
														{
														case 0:
															goto IL_2EA;
														case 1:
															enumerator3.Dispose();
															num = (short)1027145728;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 2:
															switch (0)
															{
															case 0:
																goto IL_2B2;
															}
															continue;
														}
														IL_2B2:
														if (enumerator3 == null)
														{
															break;
														}
														num = (short)1197146113;
														num2 = (int)((global::System.IntPtr)num);
													}
													IL_2EA:;
												}
												break;
											case 1:
												num = (short)1183186946;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												goto IL_346;
											case 3:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)10878977;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpRecRefField> enumerator3 = enumerator.Current.KeyField.ReferencingFields.GetEnumerator();
												num = (short)1575223296;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 4:
												switch (0)
												{
												case 0:
													goto IL_187;
												}
												continue;
											}
											IL_2ED:
											num = (short)769196035;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_187:
											goto IL_2ED;
										}
										IL_346:
										goto IL_4C9;
									}
									finally
									{
										num = (short)1274555775;
										short num4 = num;
										num = (short)2009607551;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											IL_3EC:
											num = (short)649986048;
											num2 = (int)((global::System.IntPtr)num);
											break;
										default:
											num = (short)602931200;
											if (num != 0)
											{
											}
											num = (short)959709186;
											num2 = (int)((global::System.IntPtr)num);
											break;
										}
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_402;
											case 1:
												goto IL_3E3;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_3C9;
												}
												continue;
											}
											IL_3C9:
											if (enumerator == null)
											{
												goto IL_404;
											}
											num = (short)1876688897;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_3E3:
										enumerator.Dispose();
										goto IL_3EC;
										IL_402:
										IL_404:;
									}
									break;
								case 17:
									num = (short)194445316;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_405:
								num = (short)1954217998;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_10A:
								goto IL_405;
								IL_4C9:
								embeddedRecset.ClearRecordset(embeddedRecset, task);
								num = (short)386269190;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_615:
							return;
						}
						finally
						{
							num = (short)1363804162;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_683;
								case 1:
									enumerator2.Dispose();
									num = (short)1798242304;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_64D;
									}
									continue;
								}
								IL_64D:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)1522860033;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_683:;
						}
						goto IL_686;
					case 1:
						goto IL_686;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_7A;
						}
						continue;
					}
					IL_7A:
					if (featureNode != null)
					{
						num = (short)1533542401;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_686:
					enumerator2 = featureNode.FeatureSectionsCollectionByOrder.GetEnumerator();
					num = (short)1403060224;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x0005A6D8 File Offset: 0x000588D8
		public void ClearRecordset(global::AcpCommonLib.IAcpRecordset recset, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num;
			short num2;
			int num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (!global::AcpCommonLib.AppInfoManager.DropOperation)
					{
						num2 = (short)860291076;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_67;
				case 1:
					goto IL_67;
				case 2:
					goto IL_119;
				case 3:
					num2 = (short)1434517514;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_224;
				case 5:
				{
					if (num3 < 0)
					{
						num2 = (short)492109835;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)689158531;
					short num4 = num2;
					num2 = (short)1992407427;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)884736000;
						if (num2 != 0)
						{
						}
						num2 = (short)1438318592;
						short num5 = num2;
						num2 = (short)1098514439;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 6:
					if (global::AcpCommonLib.Permission.Have(global::AcpCommonLib.Permissions.Undeletable, recset[num3].Permissions))
					{
						num2 = (short)1959788547;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_67;
				case 7:
					if (global::AcpCommonLib.AppInfoManager.SkipValueSetter)
					{
						num2 = (short)467009544;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_224;
				case 8:
					num2 = (short)127991808;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_119;
				case 10:
					if (global::AcpCommonLib.AppInfoManager.UndoRedoInProgress)
					{
						num2 = (short)254410753;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_203;
				case 11:
					goto IL_14C;
				case 12:
					goto IL_203;
				}
				goto IL_44;
				IL_67:
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask((global::AcpBusinessLayer.FeatureNode)recset[num3], global::AcpCommonLib.AppInfoManager.DndOrImportOperation));
				num2 = (short)1095041036;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_119:
				num2 = (short)343867397;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_203:
				num3--;
				num2 = (short)1211432969;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_224:
				num2 = (short)221773830;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_14C:
			num2 = (short)1669005313;
			if (num2 != 0)
			{
			}
			return;
			IL_44:
			num3 = recset.Count - 1;
			num2 = (short)811466754;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x0005A97C File Offset: 0x00058B7C
		// (set) Token: 0x0600043A RID: 1082 RVA: 0x0005AA2C File Offset: 0x00058C2C
		public string UIName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)660200466;
				short num2 = num;
				num = (short)1744559122;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1325400064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)574160896;
				if (num != 0)
				{
				}
				num = (short)397279233;
				if (num != 0)
				{
				}
				return this.r;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1379753214;
				short num2 = num;
				num = (short)1572166910;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1686306816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)506593281;
				if (num != 0)
				{
				}
				num = (short)794492928;
				if (num != 0)
				{
				}
				this.r = value;
			}
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x0005AADC File Offset: 0x00058CDC
		public global::AcpCommonLib.IAcpField FieldFromPath(string path, string delimiter)
		{
			short num = (short)1423990408;
			short num2 = num;
			num = (short)264986248;
			switch (num2 == num)
			{
			default:
			{
				num = (short)899547136;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1515585537;
			if (num != 0)
			{
			}
			num = (short)122552320;
			if (num != 0)
			{
			}
			return this.FieldFromPathHelper(path, true, delimiter);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x0005AB90 File Offset: 0x00058D90
		public global::AcpCommonLib.IAcpField FieldFromFavoritePath(string path, string delimiter)
		{
			short num = (short)49743575;
			short num2 = num;
			num = (short)1781270231;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1857945600;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1255014401;
			if (num != 0)
			{
			}
			num = (short)152305664;
			if (num != 0)
			{
			}
			return this.FieldFromPathHelper(path, false, delimiter);
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x0005AC44 File Offset: 0x00058E44
		public void CopyNodesFrom(global::AcpCommonLib.IAcpRecordset source)
		{
			int a_ = 6;
			short num = (short)973012992;
			short num2 = num;
			num = (short)1165033475;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				IL_50:
				switch (num3)
				{
				case 0:
					if (base.GetType() != source.GetType())
					{
						num = (short)917045249;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					goto IL_146;
				case 2:
					goto IL_F6;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					continue;
				}
				IL_66:
				while (source == null)
				{
					num = (short)1448465526;
					short num4 = num;
					num = (short)153212022;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)2040135681;
						if (num != 0)
						{
						}
						num = (short)1472069632;
						if (num != 0)
						{
						}
						num = (short)778895362;
						num3 = (int)((global::System.IntPtr)num);
						goto IL_50;
					}
				}
				num = (short)1592590336;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_F6:
			throw new global::System.ArgumentNullException(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("賗닙맛ﻝ鏟跡釣铥诧迩쳫鳭闯釱蟳鏵賷\udaf9闻跽⃿氁焃樅搇␉", a_));
			IL_146:
			throw new global::System.ArgumentException(global::AcpCommonResources.AcpResources.RS_InCompatible);
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600043E RID: 1086 RVA: 0x0005ADB0 File Offset: 0x00058FB0
		// (set) Token: 0x0600043F RID: 1087 RVA: 0x0005AE64 File Offset: 0x00059064
		public int DataTransferOrder
		{
			get
			{
				short num = (short)1130535647;
				short num2 = num;
				num = (short)2017630943;
				switch (num2 == num)
				{
				default:
				{
					num = (short)243793920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)981860352;
				if (num != 0)
				{
				}
				num = (short)1472921601;
				if (num != 0)
				{
				}
				return this.s;
			}
			set
			{
				short num = (short)26476545;
				if (num != 0)
				{
				}
				num = (short)1782317056;
				short num2 = num;
				num = (short)98840355;
				short num3 = num;
				num = (short)469446435;
				switch (num3 == num)
				{
				}
				num = (short)791871488;
				if (num != 0)
				{
				}
				this.s = value;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x0005AF18 File Offset: 0x00059118
		// (set) Token: 0x06000441 RID: 1089 RVA: 0x0005B0B8 File Offset: 0x000592B8
		public global::AcpCommonLib.Document ContainerDoc
		{
			get
			{
				short num = (short)104726529;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_70;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_3C;
						}
						continue;
					case 2:
					{
						num = (short)1551761408;
						short num3 = num;
						if (this.ParentSection.ParentRecset != null)
						{
							num = (short)423165957;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18B;
					}
					case 3:
						if (this.ParentSection != null)
						{
							num = (short)559218688;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18B;
					case 4:
					{
						num = (short)1796819609;
						short num4 = num;
						num = (short)1264994969;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_70;
						default:
							num = (short)764739585;
							if (num != 0)
							{
							}
							num = (short)561840128;
							if (num != 0)
							{
							}
							num = (short)773652483;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						goto IL_D7;
					}
					IL_3C:
					if (this.IsEmbeddedRecset)
					{
						num = (short)2110652420;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_18B;
					IL_70:
					num = (short)137363458;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_D7:
				return this.ParentSection.ParentRecset.ContainerDoc;
				IL_18B:
				return this.t;
			}
			set
			{
				short num = (short)188088472;
				short num2 = num;
				num = (short)1541079192;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1231552512;
					if (num != 0)
					{
					}
					num = (short)1164771329;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_110;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_7C;
							}
							continue;
						case 2:
							this.t = value;
							num = (short)981598208;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_7C:
						if (this.IsEmbeddedRecset)
						{
							break;
						}
						num = (short)1379860481;
						if (num != 0)
						{
						}
						num = (short)536412160;
						short num4 = num;
						num = (short)642646018;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_110:
					break;
				}
				}
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x0005B1D8 File Offset: 0x000593D8
		// (set) Token: 0x06000443 RID: 1091 RVA: 0x0005B288 File Offset: 0x00059488
		public virtual int Min
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1626931200;
				short num2 = num;
				num = (short)541899230;
				short num3 = num;
				num = (short)1106491870;
				switch (num3 == num)
				{
				}
				num = (short)1546846208;
				if (num != 0)
				{
				}
				num = (short)1137639425;
				if (num != 0)
				{
				}
				return this.u;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1857552384;
				short num2 = num;
				num = (short)1088749569;
				if (num != 0)
				{
				}
				num = (short)1651563262;
				short num3 = num;
				num = (short)411622142;
				switch (num3 == num)
				{
				}
				num = (short)2067988480;
				if (num != 0)
				{
				}
				this.u = value;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x0005B338 File Offset: 0x00059538
		// (set) Token: 0x06000445 RID: 1093 RVA: 0x0005B3E8 File Offset: 0x000595E8
		public virtual int Max
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1727332352;
				short num2 = num;
				num = (short)1968649148;
				short num3 = num;
				num = (short)2010592188;
				switch (num3 == num)
				{
				}
				num = (short)407109633;
				if (num != 0)
				{
				}
				num = (short)1379467264;
				if (num != 0)
				{
				}
				return this.v;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)269549568;
				short num2 = num;
				num = (short)608239617;
				if (num != 0)
				{
				}
				num = (short)1481301206;
				short num3 = num;
				num = (short)1530518742;
				switch (num3 == num)
				{
				}
				num = (short)382205952;
				if (num != 0)
				{
				}
				this.v = value;
			}
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0005B498 File Offset: 0x00059698
		public void SetMax(int newMax)
		{
			short num = (short)1179320320;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7B;
				}
				int num5;
				int num6;
				bool valid;
				for (;;)
				{
					IL_28:
					int num8;
					switch (num2)
					{
					case 0:
					{
						num = (short)335282176;
						short num3 = num;
						num = (short)1904017420;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_242;
					case 2:
						goto IL_200;
					case 3:
					{
						int num4 = newMax;
						num = (short)1332543489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num5 = this.Max;
						num6 = this.Count;
						valid = true;
						num = (short)355729410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						int num4;
						if (num4 >= this.Count)
						{
							num = (short)733741066;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpBusinessLayer.FeatureNode)this[num4]).Valid = false;
						num4++;
						num = (short)1503002640;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_30C;
					case 7:
					{
						num = (short)2123983792;
						short num7 = num;
						num = (short)979200944;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_200;
						default:
							num = (short)736100352;
							if (num != 0)
							{
							}
							goto IL_30C;
						}
						break;
					}
					case 8:
						if (this.Count > this.Max)
						{
							num = (short)441843712;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30C;
					case 9:
						if (this.Count > newMax)
						{
							num = (short)232718339;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3CA;
					case 10:
						goto IL_27F;
					case 11:
						num = (short)272564225;
						if (num != 0)
						{
						}
						goto IL_205;
					case 12:
						if (newMax > this.Count)
						{
							num = (short)144637956;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2066612241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_205;
					case 14:
						num5 = this.Max;
						num6 = newMax;
						valid = true;
						num = (short)440795143;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num = (short)461438985;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_242;
					case 17:
						if (newMax > this.Max)
						{
							num = (short)1517813774;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5 = newMax;
						num6 = this.Max;
						valid = false;
						num = (short)450035718;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (num8 >= num6)
						{
							num = (short)1013841935;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpBusinessLayer.FeatureNode)this[num8]).Valid = valid;
						num8++;
						num = (short)536805389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7B;
					IL_205:
					num = (short)1945174034;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_242:
					num = (short)84541445;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_30C:
					num8 = num5;
					num = (short)900857867;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_200:
					goto IL_30C;
				}
				IL_27F:
				IL_3CA:
				this.Max = newMax;
				this.CanAdd = true;
				return;
				IL_7B:
				valid = false;
				num5 = 0;
				num6 = 0;
				num = (short)1710293000;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0005B880 File Offset: 0x00059A80
		public void SetRecordValidity(global::AcpCommonLib.IAcpFeatureNode record, bool value)
		{
			short num = (short)1923107652;
			short num2 = num;
			num = (short)1499941700;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)99287041;
				if (num != 0)
				{
				}
				num = (short)580190208;
				if (num != 0)
				{
				}
				num = (short)910426113;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_106;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_A3;
						}
						continue;
					case 2:
						((global::AcpBusinessLayer.FeatureNode)record).Valid = value;
						num = (short)341966848;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_A3:
					if (record == null)
					{
						break;
					}
					num = (short)156106752;
					short num4 = num;
					num = (short)1194786818;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_106:
				break;
			}
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000448 RID: 1096 RVA: 0x0005B998 File Offset: 0x00059B98
		public virtual int CounterToMax
		{
			get
			{
				short num = (short)1797783552;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_57;
					}
					int counterToMaxPool;
					int num3;
					for (;;)
					{
						IL_28:
						switch (num2)
						{
						case 0:
							if (counterToMaxPool < num3)
							{
								num = (short)855834628;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_141;
						case 1:
							num = (short)2105802759;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_141;
						case 3:
							goto IL_39B;
						case 4:
							num3 = counterToMaxPool;
							num = (short)133627906;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							if (this.HasEmbeddedRecset)
							{
								num = (short)506920961;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3D9;
						case 6:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator = (this[0] as global::AcpBusinessLayer.FeatureNode).FeatureSectionsCollection.GetEnumerator();
							num = (short)1607663624;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							if (num3 > 0)
							{
								num = (short)1972699142;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3D9;
						case 8:
							try
							{
								num = (short)1789526017;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)112132101;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_1E9;
										}
										continue;
									case 2:
										if (counterToMaxPool < num3)
										{
											num = (short)586743812;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									case 4:
										num3 = counterToMaxPool;
										num = (short)1596129283;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
										goto IL_2DF;
									case 6:
									{
										global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
										counterToMaxPool = (acpFeatureSection.EmbeddedRecset as global::AcpBusinessLayer.Recordset).CounterToMaxPool;
										num = (short)1677262850;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 7:
									{
										global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
										if (acpFeatureSection.HasEmbeddedRecset)
										{
											num = (short)1639645190;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 8:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)1433272320;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = enumerator.Current;
										num = (short)648937479;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_240:
									num = (short)54001672;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_1E9:
									goto IL_240;
								}
								IL_2DF:
								goto IL_3D9;
							}
							finally
							{
								num = (short)67123412;
								short num4 = num;
								num = (short)1672493268;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1404436480;
									if (num != 0)
									{
									}
									num = (short)1061617665;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator;
										switch (num2)
										{
										case 0:
											goto IL_398;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_362;
											}
											continue;
										case 2:
											enumerator.Dispose();
											num = (short)957415424;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_362:
										if (enumerator == null)
										{
											break;
										}
										num = (short)1314127874;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_398:
									break;
								}
							}
							goto IL_39B;
						case 9:
							if (this.Count > 0)
							{
								num = (short)1373962243;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3D9;
						}
						goto IL_57;
						IL_141:
						num = (short)1354891273;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_39B:
						num = (short)897318917;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_3D9:
					num = (short)1857224705;
					if (num != 0)
					{
					}
					return num3;
					IL_57:
					num = (short)277544960;
					short num5 = num;
					num3 = this.Max - this.Count;
					counterToMaxPool = this.CounterToMaxPool;
					num = (short)1920991232;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				}
			}
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0005BDC4 File Offset: 0x00059FC4
		public virtual int GetCounterToMaxCopiesOf(int index)
		{
			short num = (short)1939079168;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4E;
				}
				int num3;
				int num4;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)328990721;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpBusinessLayer.Recordset recordset;
									if (recordset.Count != 0)
									{
										num = (short)1916469250;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_E4;
									}
									continue;
								case 2:
								{
									global::AcpBusinessLayer.Recordset recordset;
									num3 = recordset.CounterToMaxPool / recordset.Count;
									num = (short)881852422;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)2084962311;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.Recordset recordset = (global::AcpBusinessLayer.Recordset)enumerator.Current;
									num = (short)1214447616;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_213;
								case 6:
									if (num3 < num4)
									{
										num = (short)497352712;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 7:
									num = (short)1577123845;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									num = (short)827392001;
									if (num != 0)
									{
									}
									num4 = num3;
									num = (short)1733099524;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_E6:
								num = (short)69664771;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E4:
								goto IL_E6;
							}
							IL_213:
							goto IL_39D;
						}
						finally
						{
							num = (short)663749681;
							short num5 = num;
							num = (short)671220785;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1159397376;
								if (num != 0)
								{
								}
								num = (short)189661185;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator;
									switch (num2)
									{
									case 0:
										goto IL_2CF;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_299;
										}
										continue;
									case 2:
										enumerator.Dispose();
										num = (short)1171652608;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_299:
									if (enumerator == null)
									{
										break;
									}
									num = (short)352845826;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_2CF:
								break;
							}
						}
						goto IL_2D2;
					case 1:
						if (this.HasEmbeddedRecset)
						{
							num = (short)1043070981;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39D;
					case 2:
						if (num3 < num4)
						{
							num = (short)525336579;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32A;
					case 3:
						num4 = num3;
						num = (short)2048196615;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator = (this[index] as global::AcpBusinessLayer.FeatureNode).EmbeddedRecordsets.GetEnumerator();
						num = (short)1144586240;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_2D2;
					case 6:
						if (num4 > 0)
						{
							num = (short)1904803844;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39D;
					case 7:
						goto IL_32A;
					}
					goto IL_4E;
					IL_2D2:
					num = (short)337051654;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_32A:
					num = (short)633798657;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_39D:
				num = (short)790167552;
				short num6 = num;
				return num4;
				IL_4E:
				num4 = this.Max - this.Count;
				num3 = this.CounterToMaxPool;
				num = (short)1601175554;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600044A RID: 1098 RVA: 0x0005C1B8 File Offset: 0x0005A3B8
		public int CounterToMaxPool
		{
			get
			{
				short num = (short)1946550274;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1A7;
					case 1:
						num = (short)1828651014;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_45;
						}
						continue;
					case 3:
						num = (short)535494661;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_AB;
					case 5:
					{
						if (this.MaxPool == 2147483647)
						{
							num = (short)1239154688;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)792920064;
						short num3 = num;
						num = (short)68550663;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (global::AcpBusinessLayer.Recordset.b.ContainsKey(this.c))
						{
							num = (short)813039620;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return 0;
					case 7:
						if (this.MaxPool > 0)
						{
							num = (short)501612545;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return 0;
					}
					IL_45:
					if (!this.IsEmbeddedRecset)
					{
						goto IL_1C1;
					}
					num = (short)355467267;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_AB:
				num = (short)610519331;
				short num4 = num;
				num = (short)347392291;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return 0;
				default:
					num = (short)1056374784;
					if (num != 0)
					{
					}
					return this.MaxPool - global::AcpBusinessLayer.Recordset.b[this.c];
				}
				IL_1A7:
				IL_1C1:
				num = (short)931987457;
				if (num != 0)
				{
				}
				return int.MaxValue;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x0005C3B8 File Offset: 0x0005A5B8
		public int CounterToMin
		{
			get
			{
				short num = (short)1347289088;
				short num2 = num;
				num = (short)1099793611;
				short num3 = num;
				num = (short)58229963;
				switch (num3 == num)
				{
				}
				num = (short)1507983361;
				if (num != 0)
				{
				}
				num = (short)6881280;
				if (num != 0)
				{
				}
				return this.Count - this.Min;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x0005C46C File Offset: 0x0005A66C
		// (set) Token: 0x0600044D RID: 1101 RVA: 0x0005C518 File Offset: 0x0005A718
		public bool CanBeEmpty
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)512425984;
				short num2 = num;
				num = (short)598064825;
				short num3 = num;
				num = (short)297647801;
				switch (num3 == num)
				{
				}
				num = (short)657457153;
				if (num != 0)
				{
				}
				num = (short)15794176;
				if (num != 0)
				{
				}
				return this.w;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)568131584;
				short num2 = num;
				num = (short)517734401;
				if (num != 0)
				{
				}
				num = (short)1767915379;
				short num3 = num;
				num = (short)1897676659;
				switch (num3 == num)
				{
				}
				num = (short)1794375680;
				if (num != 0)
				{
				}
				this.w = value;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x0600044E RID: 1102 RVA: 0x0005C5CC File Offset: 0x0005A7CC
		// (set) Token: 0x0600044F RID: 1103 RVA: 0x0005C67C File Offset: 0x0005A87C
		public bool PositionBased
		{
			get
			{
				short num = (short)1916862464;
				short num2 = num;
				num = (short)1095522193;
				short num3 = num;
				num = (short)514021265;
				switch (num3 == num)
				{
				}
				num = (short)971898881;
				if (num != 0)
				{
				}
				num = (short)606994432;
				if (num != 0)
				{
				}
				return this.x;
			}
			private set
			{
				short num = (short)1574567936;
				short num2 = num;
				num = (short)719704162;
				short num3 = num;
				num = (short)37277794;
				switch (num3 == num)
				{
				}
				num = (short)893583361;
				if (num != 0)
				{
				}
				num = (short)1040121856;
				if (num != 0)
				{
				}
				this.x = value;
				this.PreDataTransferClearRecordset = value;
			}
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x0005C734 File Offset: 0x0005A934
		public string Path(string delimiter)
		{
			short num = (short)2038562817;
			if (num != 0)
			{
			}
			if (this.IsEmbeddedRecset)
			{
				num = (short)1460805165;
				short num2 = num;
				num = (short)596975149;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)748421120;
					if (num != 0)
					{
					}
					return this.ParentSection.Path(delimiter) + delimiter + this.UIName;
				}
			}
			num = (short)2075721728;
			short num3 = num;
			return this.UIName;
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x0005C808 File Offset: 0x0005AA08
		// (set) Token: 0x06000452 RID: 1106 RVA: 0x0005C8BC File Offset: 0x0005AABC
		public bool HideRecordsFromTree
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)196149248;
				short num2 = num;
				num = (short)1179782653;
				short num3 = num;
				num = (short)1794969085;
				switch (num3 == num)
				{
				}
				num = (short)1489567745;
				if (num != 0)
				{
				}
				num = (short)651034624;
				if (num != 0)
				{
				}
				return this.y;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)24576000;
				short num2 = num;
				num = (short)1970264645;
				short num3 = num;
				num = (short)363715141;
				switch (num3 == num)
				{
				}
				num = (short)263716865;
				if (num != 0)
				{
				}
				num = (short)267452416;
				if (num != 0)
				{
				}
				this.y = value;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x0005C96C File Offset: 0x0005AB6C
		// (set) Token: 0x06000454 RID: 1108 RVA: 0x0005CCAC File Offset: 0x0005AEAC
		public bool HiddenStatic
		{
			get
			{
				short num = (short)908394497;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)287571969;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1AB;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_F7;
									}
									continue;
								case 2:
									num = (short)1659699200;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)6815746;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)690618372;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
									if (!((global::AcpBusinessLayer.AcpFieldBase)enumerator.Current).HiddenStatic)
									{
										num = (short)1666973702;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_117;
								case 6:
									this.CalculateHiddenStatic = false;
									result = false;
									num = (short)1216348165;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_15B:
								num = (short)1711538179;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F7:
								goto IL_15B;
							}
							IL_117:
							return result;
							IL_1AB:
							goto IL_2D7;
						}
						finally
						{
							num = (short)708554752;
							short num3 = num;
							num = (short)320974848;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1055719424;
								if (num != 0)
								{
								}
								num = (short)1699479553;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
									switch (num2)
									{
									case 0:
										goto IL_25C;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_229;
										}
										continue;
									case 2:
										enumerator.Dispose();
										num = (short)399179776;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_229:
									if (enumerator == null)
									{
										break;
									}
									num = (short)435159042;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_25C:
								break;
							}
						}
						goto IL_25F;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_40;
						}
						continue;
					case 2:
						goto IL_25F;
					case 3:
						if (this.TemplateNode != null)
						{
							num = (short)484114434;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_298;
					case 4:
						if (this.CalculateHiddenStatic)
						{
							num = (short)1603993606;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_298;
					case 5:
						num = (short)1484193793;
						if (num != 0)
						{
						}
						num = (short)232652803;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						this.TemplateNode.CalculateVisibility(true);
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator = this.TemplateNode.AllFields.GetEnumerator();
						num = (short)768933888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_40:
					num = (short)1952645120;
					short num4 = num;
					if (!this.z)
					{
						num = (short)1629421573;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_25F:
					num = (short)405471236;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_298:
				return this.z;
				IL_2D7:
				this.HiddenStatic = true;
				this.CalculateHiddenStatic = false;
				return true;
			}
			set
			{
				short num = (short)232783873;
				if (num != 0)
				{
				}
				num = (short)1862794747;
				short num2 = num;
				num = (short)1961295355;
				switch (num2 == num)
				{
				default:
				{
					num = (short)361431040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)779747328;
				if (num != 0)
				{
				}
				this.z = value;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000455 RID: 1109 RVA: 0x0005CD5C File Offset: 0x0005AF5C
		// (set) Token: 0x06000456 RID: 1110 RVA: 0x0005CE10 File Offset: 0x0005B010
		public bool CalculateHiddenStatic
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)888996767;
				short num2 = num;
				num = (short)1034945439;
				switch (num2 == num)
				{
				}
				num = (short)1140654080;
				short num3 = num;
				num = (short)215875584;
				if (num != 0)
				{
				}
				num = (short)1999962113;
				if (num != 0)
				{
				}
				return this.aa;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)113534667;
				short num2 = num;
				num = (short)1671128779;
				switch (num2 == num)
				{
				}
				num = (short)1240530944;
				short num3 = num;
				num = (short)607780864;
				if (num != 0)
				{
				}
				num = (short)1022885889;
				if (num != 0)
				{
				}
				this.aa = value;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x0005CEC0 File Offset: 0x0005B0C0
		// (set) Token: 0x06000458 RID: 1112 RVA: 0x0005CF70 File Offset: 0x0005B170
		public bool PreDataTransferClearRecordset
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)60870376;
				short num2 = num;
				num = (short)1860816616;
				switch (num2 == num)
				{
				}
				num = (short)1051918336;
				short num3 = num;
				num = (short)631111681;
				if (num != 0)
				{
				}
				num = (short)784465920;
				if (num != 0)
				{
				}
				return this.ab;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)27356558;
				short num2 = num;
				num = (short)105344398;
				switch (num2 == num)
				{
				}
				num = (short)2138374144;
				short num3 = num;
				num = (short)1251213313;
				if (num != 0)
				{
				}
				num = (short)1685127168;
				if (num != 0)
				{
				}
				this.ab = value;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x0005D020 File Offset: 0x0005B220
		public virtual int MaxPool
		{
			get
			{
				short num = (short)1545852673;
				short num2 = num;
				num = (short)1707005697;
				switch (num2 == num)
				{
				}
				num = (short)1460797440;
				short num3 = num;
				num = (short)539820033;
				if (num != 0)
				{
				}
				num = (short)301662208;
				if (num != 0)
				{
				}
				return int.MaxValue;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x0005D0D0 File Offset: 0x0005B2D0
		// (set) Token: 0x0600045B RID: 1115 RVA: 0x0005D180 File Offset: 0x0005B380
		public virtual int CumulativeMax
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1374312062;
				short num2 = num;
				num = (short)1220826750;
				switch (num2 == num)
				{
				}
				num = (short)1603010560;
				short num3 = num;
				num = (short)1505558529;
				if (num != 0)
				{
				}
				num = (short)1925709824;
				if (num != 0)
				{
				}
				return this.ac;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)165561866;
				short num2 = num;
				num = (short)954942986;
				switch (num2 == num)
				{
				}
				num = (short)1295908864;
				short num3 = num;
				num = (short)1463156737;
				if (num != 0)
				{
				}
				num = (short)201064448;
				if (num != 0)
				{
				}
				this.ac = value;
			}
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x0005D230 File Offset: 0x0005B430
		public bool AddCopyOf(int index)
		{
			short num = (short)212074496;
			switch (num)
			{
			default:
			{
				num = (short)1900150785;
				if (num != 0)
				{
				}
				num = (short)1519583235;
				int num2 = (int)((global::System.IntPtr)num);
				global::AcpBusinessLayer.UndoRedo.AddCurrentRecordContainerTask addCurrentRecordContainerTask;
				for (;;)
				{
					num = (short)829882368;
					short num3 = num;
					switch (num2)
					{
					case 0:
						num = (short)869138436;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)1126760453;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						try
						{
							num = (short)446627843;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.Dictionary<global::AcpCommonLib.IAcpField, string>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1386020866;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<global::AcpCommonLib.IAcpField, string> keyValuePair = enumerator.Current;
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField = keyValuePair.Key as global::AcpBusinessLayer.AcpRecRefField;
									addCurrentRecordContainerTask.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(acpRecRefField, keyValuePair.Value));
									num = (short)1893924865;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
									if (acpRecRefField.ValueSetter != null)
									{
										num = (short)132055045;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									num = (short)1719074822;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_200;
									}
									continue;
								case 5:
								{
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
									acpRecRefField.ValueSetter(acpRecRefField.Parent, addCurrentRecordContainerTask);
									num = (short)19202052;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_2F2;
								}
								IL_202:
								num = (short)974454784;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_200:
								goto IL_202;
							}
							IL_2F2:
							goto IL_167;
						}
						finally
						{
							global::System.Collections.Generic.Dictionary<global::AcpCommonLib.IAcpField, string>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_305;
					case 3:
						IL_59:
						switch (0)
						{
						case 0:
							goto IL_AF;
						}
						continue;
					case 4:
						if (index >= 0)
						{
							num = (short)19464193;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_305;
					case 5:
						if (index < this.Count)
						{
							num = (short)614531078;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_305;
					case 6:
					{
						global::AcpCommonLib.AppInfoManager.AddDefaultRecord = false;
						global::AcpCommonLib.AppInfoManager.AddCopyOperation = true;
						global::AcpBusinessLayer.Recordset.ParentNodeBeingAdded = true;
						global::System.Collections.Generic.Dictionary<global::AcpCommonLib.IAcpField, string> dictionary = new global::System.Collections.Generic.Dictionary<global::AcpCommonLib.IAcpField, string>();
						global::AcpCommonLib.UndoRedo.UndoManager.StopUndoRedo();
						addCurrentRecordContainerTask = new global::AcpBusinessLayer.UndoRedo.AddCurrentRecordContainerTask(((global::AcpBusinessLayer.FeatureNode)this[index]).DeepCopy(dictionary));
						global::System.Collections.Generic.Dictionary<global::AcpCommonLib.IAcpField, string>.Enumerator enumerator = dictionary.GetEnumerator();
						num = (short)1522139138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_AF:
					if (global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo)
					{
						num = (short)2056060928;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_305:
					num = (short)346459133;
					short num4 = num;
					num = (short)541363197;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_59;
					default:
						goto IL_33B;
					}
				}
				IL_167:
				global::AcpCommonLib.UndoRedo.UndoManager.AddTask(addCurrentRecordContainerTask);
				global::AcpBusinessLayer.Recordset.ParentNodeBeingAdded = false;
				global::AcpCommonLib.AppInfoManager.AddCopyOperation = false;
				return true;
				IL_33B:
				num = (short)607780864;
				if (num != 0)
				{
				}
				return false;
			}
			}
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0005D5AC File Offset: 0x0005B7AC
		private void b()
		{
			int num;
			short num2;
			int num3;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						try
						{
							num2 = (short)1479213060;
							num = (int)((global::System.IntPtr)num2);
							for (;;)
							{
								global::AcpBusinessLayer.Recordset recordset;
								switch (num)
								{
								case 0:
									if (num3 == 0)
									{
										num2 = (short)1141768199;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									goto IL_187;
								case 2:
									goto IL_187;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator;
									if (!enumerator.MoveNext())
									{
										num2 = (short)798425093;
										num = (int)((global::System.IntPtr)num2);
										continue;
									}
									recordset = (global::AcpBusinessLayer.Recordset)enumerator.Current;
									num2 = (short)251854848;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_185;
									}
									continue;
								case 5:
									num2 = (short)1501233158;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case 6:
									goto IL_281;
								case 7:
									global::AcpBusinessLayer.Recordset.b[recordset.c] = 0;
									num2 = (short)1086062594;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_185;
								IL_187:
								global::AcpBusinessLayer.Recordset.b[recordset.c] = global::AcpBusinessLayer.Recordset.b[recordset.c] + recordset.Count;
								num2 = (short)1366228993;
								num = (int)((global::System.IntPtr)num2);
								continue;
								IL_1C4:
								num2 = (short)1553858563;
								num = (int)((global::System.IntPtr)num2);
								continue;
								IL_185:
								goto IL_1C4;
							}
							IL_281:
							goto IL_41;
						}
						finally
						{
							num2 = (short)304283648;
							num = (int)((global::System.IntPtr)num2);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator;
								switch (num)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_2B6;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num2 = (short)1322450946;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case 2:
									goto IL_2EC;
								}
								IL_2B6:
								if (enumerator == null)
								{
									break;
								}
								num2 = (short)742916097;
								num = (int)((global::System.IntPtr)num2);
							}
							IL_2EC:;
						}
						goto IL_2EF;
						IL_41:
						num3++;
						num2 = (short)144179202;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						goto IL_100;
					case 2:
						goto IL_100;
					case 3:
					{
						if (num3 >= this.Count)
						{
							num2 = (short)158072836;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator = (this[num3] as global::AcpBusinessLayer.FeatureNode).EmbeddedRecordsets.GetEnumerator();
						num2 = (short)308315436;
						short num4 = num2;
						num2 = (short)1338148140;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_26;
						default:
							num2 = (short)475856897;
							if (num2 != 0)
							{
							}
							num2 = (short)1196490752;
							if (num2 != 0)
							{
							}
							num2 = (short)2057306112;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 4:
						goto IL_13C;
					}
					goto IL_24;
					IL_100:
					num2 = (short)1138491395;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_13C:
				IL_2EF:
				num2 = (short)429195264;
				short num5 = num2;
				return;
			}
			}
			IL_24:
			num3 = 0;
			IL_26:
			num2 = (short)1913454593;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0005D8F0 File Offset: 0x0005BAF0
		public bool AddMultipleCopiesOf(int count, int index)
		{
			short num = (short)961871872;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_52;
				}
				global::AcpBusinessLayer.UndoRedo.AddMultipleCurrRecordsContainerTask addMultipleCurrRecordsContainerTask;
				for (;;)
				{
					IL_27:
					global::AcpBusinessLayer.FeatureNode[] array;
					global::System.Collections.Generic.Dictionary<global::AcpCommonLib.IAcpField, string> dictionary;
					int num3;
					bool notFirstNoLastAddOnMultiAddOperation;
					switch (num2)
					{
					case 0:
					{
						addMultipleCurrRecordsContainerTask = new global::AcpBusinessLayer.UndoRedo.AddMultipleCurrRecordsContainerTask(array);
						global::System.Collections.Generic.Dictionary<global::AcpCommonLib.IAcpField, string>.Enumerator enumerator = dictionary.GetEnumerator();
						num = (short)943587335;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (num3 != 0)
						{
							goto IL_247;
						}
						notFirstNoLastAddOnMultiAddOperation = false;
						goto IL_334;
					case 2:
						if (array[num3] == null)
						{
							goto IL_36E;
						}
						goto IL_2C5;
					case 3:
						return false;
					case 4:
					{
						num = (short)889389056;
						short num4 = num;
						goto IL_2C5;
					}
					case 5:
					{
						if (count <= 0)
						{
							num = (short)236060675;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = -1;
						global::System.DateTime now = global::System.DateTime.Now;
						array = new global::AcpBusinessLayer.FeatureNode[count];
						this.NotFirstNoLastAddOnMultiAddOperation = false;
						global::AcpBusinessLayer.Recordset.ParentNodeBeingAdded = true;
						dictionary = new global::System.Collections.Generic.Dictionary<global::AcpCommonLib.IAcpField, string>();
						global::AcpCommonLib.UndoRedo.UndoManager.StopUndoRedo();
						num = (short)1770979332;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						if (++num3 >= count)
						{
							num = (short)369098752;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1861494171;
						short num5 = num;
						num = (short)1632445851;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_36E;
						default:
							num = (short)196673536;
							if (num != 0)
							{
							}
							num = (short)1989738497;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						try
						{
							num = (short)829489155;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.Dictionary<global::AcpCommonLib.IAcpField, string>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)172556290;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<global::AcpCommonLib.IAcpField, string> keyValuePair = enumerator.Current;
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField = keyValuePair.Key as global::AcpBusinessLayer.AcpRecRefField;
									addMultipleCurrRecordsContainerTask.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(acpRecRefField, keyValuePair.Value));
									num = (short)540016644;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
									acpRecRefField.ValueSetter(acpRecRefField.Parent, addMultipleCurrRecordsContainerTask);
									num = (short)1105199109;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)750059526;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_148;
									}
									continue;
								case 4:
								{
									global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
									if (acpRecRefField.ValueSetter != null)
									{
										num = (short)794165249;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									goto IL_234;
								}
								IL_14A:
								num = (short)1592131584;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_148:
								goto IL_14A;
							}
							IL_234:
							goto IL_3B6;
						}
						finally
						{
							global::System.Collections.Generic.Dictionary<global::AcpCommonLib.IAcpField, string>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_247;
					case 8:
						goto IL_387;
					}
					goto IL_52;
					IL_2C5:
					num = (short)1752891398;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_334:
					this.NotFirstNoLastAddOnMultiAddOperation = notFirstNoLastAddOnMultiAddOperation;
					array[num3] = ((global::AcpBusinessLayer.FeatureNode)this[index]).DeepCopy(dictionary);
					num = (short)767361026;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_247:
					notFirstNoLastAddOnMultiAddOperation = (num3 != count - 1);
					goto IL_334;
					IL_36E:
					num = (short)293732360;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_387:
				num = (short)1537474561;
				if (num != 0)
				{
				}
				return false;
				IL_3B6:
				global::AcpCommonLib.UndoRedo.UndoManager.AddTask(addMultipleCurrRecordsContainerTask);
				global::AcpBusinessLayer.Recordset.ParentNodeBeingAdded = false;
				this.NotFirstNoLastAddOnMultiAddOperation = false;
				global::AcpCommonLib.AppInfoManager.AddCopyOperation = false;
				return true;
				IL_52:
				global::AcpCommonLib.AppInfoManager.AddDefaultRecord = false;
				global::AcpCommonLib.AppInfoManager.AddCopyOperation = true;
				num = (short)1813839877;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0005DCEC File Offset: 0x0005BEEC
		internal global::AcpCommonLib.IAcpField FieldFromPathHelper(string path, bool absolute, string delimiter)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (this.TemplateNode != null)
					{
						num2 = (short)2059403268;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_186;
				case 1:
				{
					num2 = (short)382992385;
					if (num2 != 0)
					{
					}
					num2 = (short)736448308;
					short num3 = num2;
					num2 = (short)1255952180;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_69;
					default:
						num2 = (short)401211392;
						if (num2 != 0)
						{
						}
						acpFeatureNode = (this[0] as global::AcpBusinessLayer.FeatureNode);
						num2 = (short)1101594629;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_69;
				case 3:
					goto IL_122;
				case 4:
					acpFeatureNode = this.TemplateNode;
					acpFeatureNode.Parent = this;
					num2 = (short)1063583747;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_184;
				}
				goto IL_28;
				IL_69:
				if (this.Count >= 1)
				{
					num2 = (short)2066087937;
					num = (int)((global::System.IntPtr)num2);
				}
				else
				{
					num2 = (short)84803584;
					num = (int)((global::System.IntPtr)num2);
				}
			}
			IL_122:
			IL_184:
			IL_186:
			global::AcpCommonLib.IAcpField acpField = this.a(path, absolute, delimiter, acpField, (global::AcpBusinessLayer.FeatureNode)acpFeatureNode);
			return acpField;
			IL_28:
			acpField = null;
			acpFeatureNode = null;
			num2 = (short)454950912;
			short num4 = num2;
			num2 = (short)1186070530;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0005DE94 File Offset: 0x0005C094
		private global::AcpCommonLib.IAcpField a(string A_0, bool A_1, string A_2, global::AcpCommonLib.IAcpField A_3, global::AcpBusinessLayer.FeatureNode A_4)
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			int num;
			short num2;
			string[] array2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (this.SingleInstance)
					{
						num2 = (short)357433345;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					string[] array = array2[1].Split(new string[]
					{
						A_2
					}, 2, global::System.StringSplitOptions.None);
					num2 = (short)654114822;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					A_3 = A_4.FieldFromPathHelper(array2[1], A_1, A_2);
					goto IL_206;
				case 2:
					return A_3;
				case 3:
					if (A_4 != null)
					{
						num2 = (short)2039414788;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return A_3;
				case 4:
				{
					string[] array;
					A_3 = A_4.FieldFromPathHelper(array[1], A_1, A_2);
					num2 = (short)1748238338;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					num2 = (short)1573978112;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
				{
					num2 = (short)544412708;
					short num3 = num2;
					num2 = (short)1377834020;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_206;
					default:
						num2 = (short)874577920;
						if (num2 != 0)
						{
						}
						if (A_1)
						{
							num2 = (short)29229064;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_C0;
					}
					break;
				}
				case 7:
					if (array2[0] == this.UIName)
					{
						num2 = (short)1920008197;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return A_3;
				case 8:
				{
					string[] array;
					A_4 = (global::AcpBusinessLayer.FeatureNode)this.NodeFromKey(array[0]);
					num2 = (short)1177681921;
					if (num2 != 0)
					{
					}
					num2 = (short)1087176713;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 9:
					goto IL_C0;
				case 10:
					return A_3;
				}
				goto IL_3C;
				IL_C0:
				num2 = (short)937951235;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_206:
				num2 = (short)1564999690;
				num = (int)((global::System.IntPtr)num2);
			}
			return A_3;
			IL_3C:
			array2 = A_0.Split(new string[]
			{
				A_2
			}, 2, global::System.StringSplitOptions.None);
			num2 = (short)1952120832;
			short num4 = num2;
			num2 = (short)1299709959;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x0005E118 File Offset: 0x0005C318
		private int b(global::AcpBusinessLayer.FeatureNode A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
			}
			int num;
			int num2;
			short num3;
			int num4;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (num2 >= this.Count)
					{
						num3 = (short)847183873;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)1466564614;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 1:
					return num4;
				case 2:
					if (num2 > 0)
					{
						num3 = (short)515375114;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return num4;
				case 3:
					if (A_0.Parent.IndexOf(A_0) > num2)
					{
						num3 = (short)2134769668;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return num4;
				case 4:
				{
					num3 = (short)741474304;
					short num5 = num3;
					num4++;
					num3 = (short)42860553;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 5:
					num3 = (short)1878982657;
					if (num3 != 0)
					{
					}
					goto IL_18F;
				case 6:
					if (A_0.KeyField.DisplayText.CompareTo(((global::AcpBusinessLayer.FeatureNode)this[num2]).KeyField.DisplayText) < 0)
					{
						num3 = (short)1406992392;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num4 = num2;
					num2++;
					num3 = (short)1596719109;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 7:
				{
					num3 = (short)1728735112;
					short num6 = num3;
					num3 = (short)1466591112;
					switch ((num6 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_ED;
					default:
						num3 = (short)655949824;
						if (num3 != 0)
						{
						}
						goto IL_18F;
					}
					break;
				}
				case 8:
					num3 = (short)532545538;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 9:
					return num4;
				case 10:
					goto IL_ED;
				}
				goto IL_3C;
				IL_ED:
				num3 = (short)1684078595;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_18F:
				num3 = (short)1602420736;
				num = (int)((global::System.IntPtr)num3);
			}
			return num4;
			IL_3C:
			num4 = 0;
			num2 = 0;
			num3 = (short)640614407;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0005E374 File Offset: 0x0005C574
		public void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 11;
			switch (0)
			{
			case 0:
				goto IL_35;
			}
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				int num4;
				switch (num)
				{
				case 0:
				{
					num2 = (short)14286848;
					short num3 = num2;
					info.AddValue(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("觜뫞賠鏢觤蛦鷨軪ꏬ胮闰雲", a_), this.TemplateNode, typeof(global::AcpBusinessLayer.FeatureNode));
					num2 = (short)1041498113;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_297;
				case 2:
					goto IL_295;
				case 3:
					if (this.TemplateNode != null)
					{
						num2 = (short)1724841984;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_297;
				case 4:
					goto IL_2B0;
				case 5:
					if (num4 >= this.Count)
					{
						num2 = (short)867631110;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					info.AddValue(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("鯜뫞胠韢郤闦賨", a_) + num4.ToString(), this[num4], typeof(global::AcpBusinessLayer.FeatureNode));
					num4++;
					num2 = (short)168034306;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					return;
				}
				goto IL_35;
				IL_297:
				num4 = 0;
				num2 = (short)1460404228;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_295:
			IL_2B0:
			goto IL_2F1;
			IL_35:
			info.AddValue(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("远뫞苠郢胤鏦꟨諪胬諮", a_), this.RecordsetName);
			info.AddValue(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("远뫞苠賢韤菦ꫨ蓪飬臮藰", a_), this.Count);
			info.AddValue(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("远뫞苠郢胤鏦ꃨ꿪", a_), this.Id);
			info.AddValue(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("黜뻞迠ꇢ胤ꋦ蓨鯪駬雮", a_), this.CanBeEmpty);
			info.AddValue(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("跜냞鋠諢釤軦蛨藪꿬軮苰雲釴", a_), this.PositionBased);
			info.AddValue(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("郜뛞迠", a_), this.Min);
			info.AddValue(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("郜뻞駠", a_), this.Max);
			info.AddValue(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("釜뻞鋠韢곤菦", a_), this.lastId);
			info.AddValue(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("關뻞鋠럢胤諦駨蟪賬鯮铰", a_), this.TemplateNode != null);
			info.AddValue(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("跜귞蓠꟢蓤鏦裨뿪鿬軮鿰胲鏴鋶诸룺釼髾怀焂圄戆樈搊缌欎成瘒愔", a_), this.PreDataTransferClearRecordset);
			info.AddValue(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("關뛞藠蟢胤触뫨鿪賬鯮飰郲", a_), this.HiddenStatic);
			info.AddValue(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("黜뻞跠胢郤详裨鿪裬꟮飰韲釴鋶韸꣺觼黾甀樂昄", a_), this.CalculateHiddenStatic);
			num2 = (short)741401131;
			short num5 = num2;
			num2 = (short)1737155115;
			switch ((num5 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_2F1:
				num2 = (short)1284833285;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)26345473;
				if (num2 != 0)
				{
				}
				num2 = (short)1495793664;
				if (num2 != 0)
				{
				}
				num2 = (short)1587216387;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0005E6B0 File Offset: 0x0005C8B0
		protected Recordset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 2;
			this.l = true;
			base..ctor();
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("뷓룕뻗뗙", a_));
			}
			this.RecordsetName = info.GetString(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("蛓돕믗꧙맛ꫝ껟菡解菥", a_));
			int @int = info.GetInt32(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("蛓돕믗뗙껛뫝ꏟ跡釣裥鳧", a_));
			this.Id = info.GetInt32(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("蛓돕믗꧙맛ꫝ꧟ꛡ", a_));
			this.CanBeEmpty = info.GetBoolean(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("韓럕뛗飙맛鯝跟鋡郣鿥", a_));
			this.PositionBased = info.GetBoolean(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("蓓맕ꯗ동꣛럝迟賡ꛣ蟥鯧迩裫", a_));
			this.Min = info.GetInt32(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("駓뿕뛗", a_));
			this.Max = info.GetInt32(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("駓럕ꃗ", a_));
			this.lastId = info.GetInt32(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("飓럕ꯗ껙闛뫝", a_));
			bool boolean = info.GetBoolean(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("鳓럕ꯗ軙맛돝郟軡藣鋥跧", a_));
			this.PreDataTransferClearRecordset = info.GetBoolean(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("蓓ꓕ뷗黙뷛ꫝ臟뛡難蟥蛧駩諫语苯뇱飳鏵駷裹껻鯽揿洁瘃戅笇漉砋", a_));
			this.HiddenStatic = info.GetBoolean(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("鳓뿕볗뻙맛냝돟雡藣鋥臧觩", a_));
			try
			{
				this.CalculateHiddenStatic = info.GetBoolean(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("韓럕듗맙꧛닝臟雡臣껥臧軩裫语黯ꇱ胳韵賷鏹鿻", a_));
				goto IL_20C;
			}
			catch (global::System.Runtime.Serialization.SerializationException)
			{
				if (boolean || @int == 0)
				{
					this.CalculateHiddenStatic = true;
				}
				goto IL_20C;
			}
			IL_A0:
			global::AcpBusinessLayer.FeatureNode featureNode;
			this.KeysToNode.Add(featureNode);
			goto IL_1EE;
			IL_1DF:
			int num;
			if (num >= @int)
			{
				goto IL_26A;
			}
			featureNode = (global::AcpBusinessLayer.FeatureNode)info.GetValue(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("鋓돕맗껙꧛곝藟", a_) + num.ToString(), typeof(global::AcpBusinessLayer.FeatureNode));
			this.AddRecord(featureNode);
			if (this.KeysToNode != null && !this.KeysToNode.Contains(featureNode.ReferenceKey))
			{
				goto IL_A0;
			}
			IL_1EE:
			num++;
			goto IL_1DF;
			IL_20C:
			if (boolean)
			{
				goto IL_1EB;
			}
			if (@int == 0)
			{
				goto IL_1EB;
			}
			IL_1CA:
			this.c = base.GetType().GUID;
			num = 0;
			goto IL_1DF;
			IL_1EB:
			try
			{
				this.TemplateNode = (global::AcpBusinessLayer.FeatureNode)info.GetValue(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("胓돕뗗꫙냛뿝铟蟡ꫣ觥賧迩", a_), typeof(global::AcpBusinessLayer.FeatureNode));
				goto IL_1CA;
			}
			catch
			{
				this.TemplateNode = this.CreateDefaultRecord();
				goto IL_1CA;
			}
			IL_26A:
			this.c();
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x0005E94C File Offset: 0x0005CB4C
		public void ResetToDefault()
		{
			short num = (short)1523187713;
			if (num != 0)
			{
			}
			num = (short)1671430144;
			short num2 = num;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = base.GetEnumerator();
			try
			{
				num = (short)961216514;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					IL_76:
					switch (num3)
					{
					case 0:
						goto IL_154;
					case 1:
						while (enumerator.MoveNext())
						{
							global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
							((global::AcpCommonLib.IAcpCommon)featureNode).ResetToDefault();
							num = (short)2091628051;
							short num4 = num;
							num = (short)1041872403;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)424345600;
								if (num != 0)
								{
								}
								num = (short)1932787715;
								num3 = (int)((global::System.IntPtr)num);
								goto IL_76;
							}
						}
						num = (short)2037972996;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_90;
						}
						continue;
					case 4:
						num = (short)533659648;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_101:
					num = (short)2026307585;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_90:
					goto IL_101;
				}
				IL_154:;
			}
			finally
			{
				num = (short)1414266881;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)630718466;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_186;
						}
						continue;
					case 2:
						goto IL_1BA;
					}
					IL_186:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1132003328;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1BA:;
			}
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x0005EB28 File Offset: 0x0005CD28
		public void RepairRecRefs()
		{
			short num = (short)1353252865;
			if (num != 0)
			{
			}
			num = (short)1890582528;
			short num2 = num;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = base.GetEnumerator();
			try
			{
				num = (short)139591682;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					IL_76:
					switch (num3)
					{
					case 0:
						goto IL_15D;
					case 1:
						while (enumerator.MoveNext())
						{
							global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
							((global::AcpBusinessLayer.FeatureNode)featureNode).RepairRecRefs();
							num = (short)825019004;
							short num4 = num;
							num = (short)2123418236;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1376845824;
								if (num != 0)
								{
								}
								num = (short)1200553987;
								num3 = (int)((global::System.IntPtr)num);
								goto IL_76;
							}
						}
						num = (short)1484980228;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_90;
						}
						continue;
					case 4:
						num = (short)1891893248;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_10A:
					num = (short)1417347073;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_90:
					goto IL_10A;
				}
				IL_15D:;
			}
			finally
			{
				num = (short)1030619137;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1443627010;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_18F;
						}
						continue;
					case 2:
						goto IL_1C2;
					}
					IL_18F:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1620246528;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1C2:;
			}
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0005ED18 File Offset: 0x0005CF18
		public void SubscribeToPropertyChangedEvent(global::System.ComponentModel.PropertyChangedEventHandler eventHandler)
		{
			short num = (short)766125299;
			short num2 = num;
			num = (short)2078811379;
			switch (num2 == num)
			{
			}
			num = (short)1553203201;
			if (num != 0)
			{
			}
			num = (short)1919549440;
			if (num != 0)
			{
			}
			num = (short)530055168;
			short num3 = num;
			this.PropertyChanged += eventHandler;
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0005EDC8 File Offset: 0x0005CFC8
		public void UnSubscribeFromPropertyChangedEvent(global::System.ComponentModel.PropertyChangedEventHandler eventHandler)
		{
			short num = (short)1523684464;
			short num2 = num;
			num = (short)154440816;
			switch (num2 == num)
			{
			}
			num = (short)1414856705;
			if (num != 0)
			{
			}
			num = (short)971636736;
			if (num != 0)
			{
			}
			num = (short)1457061888;
			short num3 = num;
			this.PropertyChanged -= eventHandler;
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x0005EE7C File Offset: 0x0005D07C
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x0005EF2C File Offset: 0x0005D12C
		public global::AcpBusinessLayer.FeatureNode TemplateNode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)272695297;
				if (num != 0)
				{
				}
				num = (short)2033479159;
				short num2 = num;
				num = (short)1082158583;
				switch (num2 == num)
				{
				}
				num = (short)925892608;
				if (num != 0)
				{
				}
				num = (short)794034176;
				short num3 = num;
				return this.ad;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)182447582;
				short num2 = num;
				num = (short)1975512542;
				switch (num2 == num)
				{
				}
				num = (short)934019073;
				if (num != 0)
				{
				}
				num = (short)818085888;
				if (num != 0)
				{
				}
				num = (short)990904320;
				short num3 = num;
				this.ad = value;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x0005EFE0 File Offset: 0x0005D1E0
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x0005F08C File Offset: 0x0005D28C
		internal bool MustCalculateValidityAcross
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)723582977;
				if (num != 0)
				{
				}
				num = (short)2102545863;
				short num2 = num;
				num = (short)190926279;
				switch (num2 == num)
				{
				}
				num = (short)641269760;
				if (num != 0)
				{
				}
				num = (short)932839424;
				short num3 = num;
				return this.ae;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1317661844;
				short num2 = num;
				num = (short)1273425044;
				switch (num2 == num)
				{
				}
				num = (short)895156225;
				if (num != 0)
				{
				}
				num = (short)604569600;
				if (num != 0)
				{
				}
				num = (short)1067450368;
				short num3 = num;
				this.ae = value;
			}
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x0005F13C File Offset: 0x0005D33C
		internal void CalculateValidityAcrossFor(int sectionId, string uIName)
		{
			short num = (short)767557632;
			short num2 = num;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = base.GetEnumerator();
			try
			{
				num = (short)1433862146;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					IL_50:
					switch (num3)
					{
					case 0:
						goto IL_16C;
					case 1:
						while (enumerator.MoveNext())
						{
							global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
							((global::AcpBusinessLayer.AcpFieldBase)featureNode[sectionId][uIName]).CalculateValidity();
							num = (short)274813710;
							short num4 = num;
							num = (short)765154062;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)671547393;
								if (num != 0)
								{
								}
								num = (short)430505984;
								if (num != 0)
								{
								}
								num = (short)1125777411;
								num3 = (int)((global::System.IntPtr)num);
								goto IL_50;
							}
						}
						num = (short)1853751300;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_6A;
						}
						continue;
					case 4:
						num = (short)640483328;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_118:
					num = (short)1255735297;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_6A:
					goto IL_118;
				}
				IL_16C:;
			}
			finally
			{
				num = (short)1020985345;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1843462146;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_19F;
						}
						continue;
					case 2:
						goto IL_1D3;
					}
					IL_19F:
					if (enumerator == null)
					{
						break;
					}
					num = (short)165412864;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1D3:;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x0005F33C File Offset: 0x0005D53C
		// (set) Token: 0x0600046E RID: 1134 RVA: 0x0005F494 File Offset: 0x0005D694
		public bool CanAdd
		{
			get
			{
				short num = (short)1294139393;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1533476864;
					short num3 = num;
					switch (num2)
					{
					case 0:
						return false;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_5D;
						}
						continue;
					case 2:
					{
						num = (short)1150187868;
						short num4 = num;
						num = (short)313686364;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_115;
						default:
							goto IL_BC;
						}
						break;
					}
					case 3:
						goto IL_115;
					}
					IL_5D:
					if (global::AcpCommonLib.Permission.Have(global::AcpCommonLib.Permissions.AddCurrentDisabled, this.Permissions))
					{
						num = (short)552271874;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)219676675;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_115:
					if (!global::AcpCommonLib.Permission.Have(global::AcpCommonLib.Permissions.AddDefaultDisabled, this.Permissions))
					{
						goto IL_142;
					}
					num = (short)683081728;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_BC:
				num = (short)840761345;
				if (num != 0)
				{
				}
				num = (short)1854865408;
				if (num != 0)
				{
				}
				return false;
				IL_142:
				return this.CounterToMax > 0;
			}
			private set
			{
				int a_ = 17;
				short num = (short)1677948976;
				short num2 = num;
				num = (short)693270576;
				switch (num2 == num)
				{
				}
				num = (short)471400449;
				if (num != 0)
				{
				}
				num = (short)1715077120;
				if (num != 0)
				{
				}
				num = (short)2144337920;
				short num3 = num;
				this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("ꃢ蓤触꣨迪觬", a_)));
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x0005F560 File Offset: 0x0005D760
		// (set) Token: 0x06000470 RID: 1136 RVA: 0x0005F610 File Offset: 0x0005D810
		public bool CanDelete
		{
			get
			{
				short num = (short)1075867334;
				short num2 = num;
				num = (short)23293638;
				switch (num2 == num)
				{
				}
				num = (short)1184104448;
				if (num != 0)
				{
				}
				num = (short)1270022145;
				if (num != 0)
				{
				}
				num = (short)1647443968;
				short num3 = num;
				return this.CounterToMin > 0;
			}
			private set
			{
				int a_ = 1;
				short num = (short)789019151;
				short num2 = num;
				num = (short)1130723855;
				switch (num2 == num)
				{
				}
				num = (short)1046347776;
				if (num != 0)
				{
				}
				num = (short)152829953;
				if (num != 0)
				{
				}
				num = (short)1562771456;
				short num3 = num;
				this.OnPropertyChanged(new global::System.ComponentModel.PropertyChangedEventArgs(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("郒듔맖鷘뻚뇜뫞闠蛢", a_)));
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x0005F6D8 File Offset: 0x0005D8D8
		// (set) Token: 0x06000472 RID: 1138 RVA: 0x0005F788 File Offset: 0x0005D988
		public virtual int DefaultRecordCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2034861184;
				short num2 = num;
				num = (short)1077707904;
				switch (num2 == num)
				{
				}
				num = (short)1047527424;
				if (num != 0)
				{
				}
				num = (short)539164673;
				if (num != 0)
				{
				}
				num = (short)1483997184;
				short num3 = num;
				return this.af;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1437174939;
				short num2 = num;
				num = (short)2086177947;
				switch (num2 == num)
				{
				}
				num = (short)64946177;
				if (num != 0)
				{
				}
				num = (short)307625984;
				if (num != 0)
				{
				}
				num = (short)20971520;
				short num3 = num;
				this.af = value;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x0005F838 File Offset: 0x0005DA38
		public global::System.Collections.Generic.IEnumerable<global::AcpBusinessLayer.AcpRecRefField> RecRefFields
		{
			get
			{
				short num = (short)1797013594;
				short num2 = num;
				num = (short)1590444122;
				switch (num2 == num)
				{
				}
				num = (short)701693953;
				if (num != 0)
				{
				}
				num = (short)155713536;
				if (num != 0)
				{
				}
				num = (short)1447624704;
				short num3 = num;
				global::AcpBusinessLayer.Recordset.<get_RecRefFields>d__242 <get_RecRefFields>d__ = new global::AcpBusinessLayer.Recordset.<get_RecRefFields>d__242(-2);
				<get_RecRefFields>d__.<>4__this = this;
				return <get_RecRefFields>d__;
			}
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x0005F8F0 File Offset: 0x0005DAF0
		internal void FindNewFieldsInEmbeddedRecset_ImpExp(global::System.Collections.Generic.List<string> xmlEmbedRecsetFieldNameList, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField>> ConsumerNodes)
		{
			short num = (short)89456640;
			switch (num)
			{
			default:
			{
				num = (short)1654063105;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_9C;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_52;
						}
						continue;
					case 2:
						try
						{
							num = (short)1867776003;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)501940230;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (!flag)
									{
										num = (short)1871904768;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_60F;
								case 2:
									num = (short)1753153541;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_11A;
									}
									continue;
								case 5:
									goto IL_764;
								case 6:
									goto IL_746;
								case 7:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField> list;
									ConsumerNodes.Add(featureNode.ReferenceKey, list);
									num = (short)1844969476;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									if (featureNode.KeyField != null)
									{
										num = (short)797573127;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)357695490;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
									global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField> list = new global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField>();
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2 = featureNode.FeatureSectionsCollectionByOrder.GetEnumerator();
									num = (short)1877999626;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									try
									{
										num = (short)663814146;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_59C;
											case 1:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)1501822980;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator3 = ((global::AcpBusinessLayer.FeatureSection)enumerator2.Current).FieldsCollectionByOrder.GetEnumerator();
												num = (short)1905655811;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
												switch (0)
												{
												case 0:
													goto IL_15A;
												}
												continue;
											case 3:
												try
												{
													num = (short)1305935879;
													num2 = (int)((global::System.IntPtr)num);
													for (;;)
													{
														global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator3;
														global::AcpCommonLib.IAcpField acpField;
														switch (num2)
														{
														case 1:
															try
															{
																num = (short)2054225924;
																num2 = (int)((global::System.IntPtr)num);
																for (;;)
																{
																	switch (num2)
																	{
																	case 0:
																		goto IL_35D;
																	case 1:
																		goto IL_37A;
																	case 2:
																	{
																		string item;
																		if (xmlEmbedRecsetFieldNameList.Contains(item))
																		{
																			num = (short)931463174;
																			num2 = (int)((global::System.IntPtr)num);
																			continue;
																		}
																		break;
																	}
																	case 3:
																	{
																		global::System.Collections.Generic.IEnumerator<string> enumerator4;
																		if (!enumerator4.MoveNext())
																		{
																			num = (short)1581187077;
																			num2 = (int)((global::System.IntPtr)num);
																			continue;
																		}
																		string item = enumerator4.Current;
																		num = (short)1796145154;
																		num2 = (int)((global::System.IntPtr)num);
																		continue;
																	}
																	case 4:
																		switch (0)
																		{
																		case 0:
																			goto IL_2C7;
																		}
																		continue;
																	case 5:
																		num = (short)1140064257;
																		num2 = (int)((global::System.IntPtr)num);
																		continue;
																	case 6:
																	{
																		bool flag2 = true;
																		num = (short)359989248;
																		num2 = (int)((global::System.IntPtr)num);
																		continue;
																	}
																	}
																	IL_2C9:
																	num = (short)1599340547;
																	num2 = (int)((global::System.IntPtr)num);
																	continue;
																	IL_2C7:
																	goto IL_2C9;
																}
																IL_35D:
																IL_37A:
																goto IL_21C;
															}
															finally
															{
																num = (short)1235812353;
																num2 = (int)((global::System.IntPtr)num);
																for (;;)
																{
																	global::System.Collections.Generic.IEnumerator<string> enumerator4;
																	switch (num2)
																	{
																	case 0:
																		enumerator4.Dispose();
																		num = (short)1463484418;
																		num2 = (int)((global::System.IntPtr)num);
																		continue;
																	case 1:
																		switch (0)
																		{
																		case 0:
																			goto IL_3B1;
																		}
																		continue;
																	case 2:
																		goto IL_3EB;
																	}
																	IL_3B1:
																	if (enumerator4 == null)
																	{
																		break;
																	}
																	num = (short)2131165184;
																	num2 = (int)((global::System.IntPtr)num);
																}
																IL_3EB:;
															}
															goto IL_3EE;
															IL_21C:
															num = (short)975372296;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 2:
															goto IL_480;
														case 3:
														{
															flag = true;
															global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField> list;
															list.Add(acpField);
															num = (short)1723400192;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 4:
															if (!enumerator3.MoveNext())
															{
																num = (short)851902470;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															goto IL_3EE;
														case 5:
															if (!xmlEmbedRecsetFieldNameList.Contains(acpField.UIName))
															{
																num = (short)102367241;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															break;
														case 6:
															num = (short)567869442;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 7:
															switch (0)
															{
															case 0:
																goto IL_1DF;
															}
															continue;
														case 8:
														{
															bool flag2;
															if (!flag2)
															{
																num = (short)137756675;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															break;
														}
														case 9:
														{
															bool flag2 = false;
															global::System.Collections.Generic.IEnumerator<string> enumerator4 = (acpField as global::AcpBusinessLayer.AcpFieldBase).LegacyUINames.GetEnumerator();
															num = (short)1371340801;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														}
														IL_1E1:
														num = (short)890699780;
														num2 = (int)((global::System.IntPtr)num);
														continue;
														IL_1DF:
														goto IL_1E1;
														IL_3EE:
														acpField = enumerator3.Current;
														num = (short)1835597829;
														num2 = (int)((global::System.IntPtr)num);
													}
													IL_480:;
												}
												finally
												{
													num = (short)1832583170;
													num2 = (int)((global::System.IntPtr)num);
													for (;;)
													{
														global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator3;
														switch (num2)
														{
														case 0:
														{
															num = (short)1015675098;
															short num3 = num;
															num = (short)1302395098;
															switch ((num3 == num) ? 1 : 0)
															{
															case 0:
															case 2:
																break;
															default:
																num = (short)1880883200;
																if (num != 0)
																{
																}
																enumerator3.Dispose();
																num = (short)1443102721;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															break;
														}
														case 1:
															goto IL_540;
														case 2:
															switch (0)
															{
															case 0:
																goto IL_4B8;
															}
															continue;
														}
														IL_4B8:
														if (enumerator3 == null)
														{
															break;
														}
														num = (short)2059337728;
														num2 = (int)((global::System.IntPtr)num);
													}
													IL_540:;
												}
												break;
											case 4:
												num = (short)574488576;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_543:
											num = (short)556204033;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_15A:
											goto IL_543;
										}
										IL_59C:
										goto IL_68E;
									}
									finally
									{
										num = (short)647626754;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
											switch (num2)
											{
											case 0:
												enumerator2.Dispose();
												num = (short)1479868417;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												goto IL_60C;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_5D3;
												}
												continue;
											}
											IL_5D3:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)1007943680;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_60C:;
									}
									goto IL_60F;
									IL_68E:
									num = (short)1062273025;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_11A;
								IL_60F:
								num = (short)323092488;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_64D:
								num = (short)107610121;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_11A:
								goto IL_64D;
							}
							IL_746:
							IL_764:
							return;
						}
						finally
						{
							num = (short)1278083074;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)546111489;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_7D2;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_79C;
									}
									continue;
								}
								IL_79C:
								if (enumerator == null)
								{
									break;
								}
								num = (short)352321536;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_7D2:;
						}
						goto IL_7D5;
					}
					IL_52:
					num = (short)852688896;
					short num4 = num;
					if (xmlEmbedRecsetFieldNameList.Count == 0)
					{
						num = (short)1092550656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_7D5:
					flag = false;
					enumerator = base.GetEnumerator();
					num = (short)140443650;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_9C:
				num = (short)1310851073;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00060160 File Offset: 0x0005E360
		public void UpdateNewFieldsInEmbeddedRecset_ImpExpDnD(global::AcpCommonLib.UndoRedo.ContainerTask task, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField>> ConsumerNodes)
		{
			short num = (short)550305792;
			switch (num)
			{
			default:
			{
				num = (short)603062272;
				short num2 = num;
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = null;
				using (global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField>>.Enumerator enumerator = ConsumerNodes.GetEnumerator())
				{
					num = (short)2035089417;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							num = (short)1508376584;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField>> keyValuePair;
							acpFeatureNode = this.NodeFromKey(keyValuePair.Key);
							num = (short)1111359492;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2 = acpFeatureNode.FeatureSectionsCollectionByOrder.GetEnumerator();
							num = (short)927268869;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							if (acpFeatureNode != null)
							{
								num = (short)1003028482;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 4:
							goto IL_4FA;
						case 5:
							try
							{
								num = (short)697958404;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										goto IL_40B;
									case 1:
									{
										IL_1C0:
										global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)489684992;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpBusinessLayer.FeatureSection featureSection = (global::AcpBusinessLayer.FeatureSection)enumerator2.Current;
										global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField> value;
										global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField>.Enumerator enumerator3 = value.GetEnumerator();
										num = (short)1955790850;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										try
										{
											num = (short)624099339;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
												global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
												switch (num3)
												{
												case 0:
													if (acpRecRefField != null)
													{
														num = (short)213254151;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												case 2:
													num = (short)1635319818;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 3:
													goto IL_2F0;
												case 4:
													acpRecRefField.ValueSetter(acpRecRefField.Parent, task);
													num = (short)64946177;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 5:
												{
													global::AcpCommonLib.IAcpField acpField;
													task.AddTask(acpFieldBase.CopyValueOf(acpField));
													num = (short)597098499;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 6:
													if (acpRecRefField.ValueSetter != null)
													{
														num = (short)1896873988;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												case 7:
													num = (short)2139750406;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 8:
												{
													global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField>.Enumerator enumerator3;
													if (!enumerator3.MoveNext())
													{
														num = (short)1240858626;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::AcpCommonLib.IAcpField acpField = enumerator3.Current;
													global::AcpBusinessLayer.FeatureSection featureSection;
													acpFieldBase = (featureSection[acpField.UIName] as global::AcpBusinessLayer.AcpFieldBase);
													num = (short)1325137929;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 9:
													if (acpFieldBase != null)
													{
														num = (short)1851326469;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_2F0;
												case 10:
													goto IL_3F8;
												case 11:
													switch (0)
													{
													case 0:
														goto IL_270;
													}
													continue;
												}
												goto IL_270;
												IL_2F0:
												acpRecRefField = (acpFieldBase as global::AcpBusinessLayer.AcpRecRefField);
												num = (short)1667629056;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_330:
												num = (short)747372552;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_270:
												goto IL_330;
											}
											IL_3F8:
											break;
										}
										finally
										{
											global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField>.Enumerator enumerator3;
											((global::System.IDisposable)enumerator3).Dispose();
										}
										goto IL_40B;
									case 3:
										goto IL_423;
									case 4:
										switch (0)
										{
										case 0:
											goto IL_157;
										}
										continue;
									}
									IL_15C:
									num = (short)1909914161;
									short num4 = num;
									num = (short)1458108977;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_1C0;
									default:
										num = (short)842006528;
										if (num != 0)
										{
										}
										num = (short)2063138817;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_157:
									goto IL_15C;
									IL_40B:
									num = (short)489881603;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_423:;
							}
							finally
							{
								num = (short)1255342082;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
									switch (num3)
									{
									case 0:
										enumerator2.Dispose();
										num = (short)678559745;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_48E;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_457;
										}
										continue;
									}
									IL_457:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)1395982336;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_48E:;
							}
							break;
						case 6:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)149684224;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField>> keyValuePair = enumerator.Current;
							global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField> value = keyValuePair.Value;
							num = (short)731250695;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							if (this.Count > 0)
							{
								num = (short)2011758593;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4FA;
						case 8:
							goto IL_54A;
						case 9:
							switch (0)
							{
							case 0:
								goto IL_A1;
							}
							continue;
						}
						IL_491:
						num = (short)1518141446;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_A1:
						goto IL_491;
						IL_4FA:
						num = (short)810811395;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_54A:;
				}
				num = (short)2069233665;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0006073C File Offset: 0x0005E93C
		public void FindNewFieldsInEmbeddedRecset_DnD(global::AcpCommonLib.IAcpRecordset producerEmbedddedRecset, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField>> ConsumerFields)
		{
			short num = (short)1553465344;
			switch (num)
			{
			default:
			{
				num = (short)593494016;
				short num2 = num;
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = null;
				bool flag = false;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = ((global::AcpBusinessLayer.Recordset)producerEmbedddedRecset).GetEnumerator();
				try
				{
					num = (short)609026058;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							if (acpFeatureNode.ReferenceKey != null)
							{
								num = (short)1037107209;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 1:
							if (!flag)
							{
								num = (short)1364983811;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1215430656;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							num = (short)591265803;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							num = (short)830341135;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)289275911;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
							num = (short)707919884;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							try
							{
								num = (short)282066950;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1456013313;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpBusinessLayer.FeatureSection featureSection = (global::AcpBusinessLayer.FeatureSection)enumerator2.Current;
										global::AcpBusinessLayer.FeatureNode featureNode;
										global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = featureNode[featureSection.FeatureSectionId];
										num = (short)1758396420;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										goto IL_627;
									case 2:
										try
										{
											num = (short)1542062090;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												global::AcpCommonLib.IAcpField acpField;
												switch (num3)
												{
												case 1:
												{
													global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
													if (acpFieldBase.HiddenStatic)
													{
														num = (short)1332150276;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												}
												case 2:
												{
													global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
													if (acpFieldBase != null)
													{
														num = (short)1341194248;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													break;
												}
												case 3:
													num = (short)2085224457;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 4:
													goto IL_49C;
												case 5:
												{
													global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator3;
													if (!enumerator3.MoveNext())
													{
														num = (short)1733689347;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													acpField = enumerator3.Current;
													global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
													global::AcpBusinessLayer.AcpFieldBase acpFieldBase = acpFeatureSection[acpField.UIName] as global::AcpBusinessLayer.AcpFieldBase;
													num = (short)69337094;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 6:
												{
													global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
													if (acpFieldBase != null)
													{
														num = (short)213319687;
														num3 = (int)((global::System.IntPtr)num);
														continue;
													}
													goto IL_49C;
												}
												case 7:
													num = (short)1218641922;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 8:
													num = (short)844627969;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 9:
													goto IL_5B5;
												case 10:
													switch (0)
													{
													case 0:
														goto IL_460;
													}
													continue;
												}
												goto IL_460;
												IL_49C:
												flag = true;
												global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField> list;
												list.Add(acpField);
												num = (short)859504640;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_55E:
												num = (short)548339717;
												num3 = (int)((global::System.IntPtr)num);
												continue;
												IL_460:
												goto IL_55E;
											}
											IL_5B5:
											break;
										}
										finally
										{
											num = (short)1461125122;
											num3 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator3;
												switch (num3)
												{
												case 0:
													enumerator3.Dispose();
													num = (short)1678508033;
													num3 = (int)((global::System.IntPtr)num);
													continue;
												case 1:
													goto IL_624;
												case 2:
													switch (0)
													{
													case 0:
														goto IL_5EC;
													}
													continue;
												}
												IL_5EC:
												if (enumerator3 == null)
												{
													break;
												}
												num = (short)435945472;
												num3 = (int)((global::System.IntPtr)num);
											}
											IL_624:;
										}
										goto IL_627;
									case 3:
									{
										global::AcpBusinessLayer.FeatureSection featureSection;
										global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator3 = featureSection.FieldsCollectionByOrder.GetEnumerator();
										num = (short)1362558978;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
									{
										global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
										if (acpFeatureSection != null)
										{
											num = (short)1562640387;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 5:
										goto IL_63F;
									case 6:
										switch (0)
										{
										case 0:
											goto IL_350;
										}
										continue;
									}
									IL_3CC:
									num = (short)528089088;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_350:
									goto IL_3CC;
									IL_627:
									num = (short)1854603269;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_63F:
								goto IL_233;
							}
							finally
							{
								for (;;)
								{
									num = (short)1978073089;
									num3 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2;
										switch (num3)
										{
										case 0:
											enumerator2.Dispose();
											num = (short)972816386;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_678;
											}
											continue;
										case 2:
											goto IL_6B3;
										}
										IL_678:
										if (enumerator2 == null)
										{
											goto IL_701;
										}
										num = (short)1334378496;
										num3 = (int)((global::System.IntPtr)num);
									}
									IL_6B3:
									num = (short)775416543;
									short num4 = num;
									num = (short)1744038623;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										goto IL_6E9;
									}
								}
								IL_6E9:
								num = (short)2116878336;
								if (num != 0)
								{
								}
								IL_701:;
							}
							goto IL_702;
							IL_233:
							num = (short)1993801729;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_702;
						case 8:
						{
							global::AcpBusinessLayer.FeatureNode featureNode;
							acpFeatureNode = this.NodeFromKey(featureNode.ReferenceKey);
							num = (short)1442971665;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
						{
							global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField> list;
							ConsumerFields.Add(acpFeatureNode.ReferenceKey, list);
							num = (short)1658585090;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							switch (0)
							{
							case 0:
								goto IL_C8;
							}
							continue;
						case 11:
							goto IL_189;
						case 12:
						{
							global::AcpBusinessLayer.FeatureNode featureNode;
							if (featureNode.KeyField != null)
							{
								num = (short)1464336388;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1CF;
						}
						case 13:
							if (acpFeatureNode != null)
							{
								num = (short)1394802702;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 14:
						{
							global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField> list = new global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField>();
							global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator2 = acpFeatureNode.FeatureSectionsCollectionByOrder.GetEnumerator();
							num = (short)165937153;
							if (num != 0)
							{
							}
							num = (short)915800070;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 15:
							if (this.Count > 0)
							{
								num = (short)2021523464;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1CF;
						case 16:
							goto IL_71A;
						case 17:
							goto IL_1CF;
						}
						IL_18E:
						num = (short)1230438405;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_C8:
						goto IL_18E;
						IL_1CF:
						num = (short)1832648717;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_702:
						num = (short)2113732624;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_189:
					IL_71A:;
				}
				finally
				{
					num = (short)119013377;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1580335106;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_74F;
							}
							continue;
						case 2:
							goto IL_785;
						}
						IL_74F:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1964310528;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_785:;
				}
				return;
			}
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x00060F20 File Offset: 0x0005F120
		// (set) Token: 0x06000478 RID: 1144 RVA: 0x00060FD0 File Offset: 0x0005F1D0
		public global::AcpCommonLib.Permissions Permissions
		{
			get
			{
				short num = (short)1409941504;
				short num2 = num;
				num = (short)1748631553;
				if (num != 0)
				{
				}
				num = (short)1366372648;
				short num3 = num;
				num = (short)485110056;
				switch (num3 == num)
				{
				}
				num = (short)1045823488;
				if (num != 0)
				{
				}
				return this.ag;
			}
			set
			{
				short num = (short)663748608;
				short num2 = num;
				num = (short)1643071226;
				short num3 = num;
				num = (short)1567180538;
				switch (num3 == num)
				{
				}
				num = (short)1660420097;
				if (num != 0)
				{
				}
				num = (short)431292416;
				if (num != 0)
				{
				}
				this.ag = value;
				this.CanAdd = true;
				this.CanDelete = true;
			}
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x0006108C File Offset: 0x0005F28C
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)1228472323;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_207;
				case 1:
					this.ai = true;
					this.a();
					goto IL_13F;
				case 2:
				{
					global::AcpBusinessLayer.FeatureNode templateNode = this.TemplateNode;
					if (templateNode == null)
					{
						num = (short)1537015815;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					templateNode.Dispose();
					num = (short)329777157;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				case 4:
					num = (short)2073755656;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_1E6;
				case 6:
					goto IL_75;
				case 7:
					goto IL_1E6;
				case 8:
					if (disposing)
					{
						num = (short)1844248577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E6;
				case 9:
					goto IL_7A;
				case 10:
				{
					global::AcpBusinessLayer.DifferenceCount diffCount = this.DiffCount;
					if (diffCount == null)
					{
						num = (short)947847177;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					diffCount.Dispose();
					num = (short)1262354444;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 11:
					if (!this.ah)
					{
						num = (short)1679425540;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_207;
				case 12:
					goto IL_7A;
				}
				IL_58:
				if (this.ai)
				{
					num = (short)271712262;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1993474059;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7A:
				num = (short)2117140482;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_13F:
				num = (short)1034158090;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_207:
				num = (short)1378392525;
				short num3 = num;
				num = (short)2002819533;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_13F;
				default:
					goto IL_23D;
				}
				IL_1E6:
				this.ah = true;
				num = (short)1489305600;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_75:
			num = (short)1057357824;
			short num4 = num;
			return;
			IL_23D:
			num = (short)1331757056;
			if (num != 0)
			{
			}
			num = (short)213712897;
			if (num != 0)
			{
			}
			this.ai = false;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00061318 File Offset: 0x0005F518
		private void a()
		{
			short num = (short)1840840705;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				switch (num2)
				{
				case 0:
					goto IL_1FC;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 2:
					try
					{
						num = (short)1816854529;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 1:
								switch (0)
								{
								case 0:
									goto IL_97;
								}
								continue;
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)905445381;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)263973621;
								short num3 = num;
								num = (short)1530391285;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_130;
								default:
									num = (short)1440415744;
									if (num != 0)
									{
									}
									num = (short)601030660;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 4:
								goto IL_130;
							case 5:
								num = (short)788791302;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								goto IL_190;
							}
							IL_99:
							num = (short)689176578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_97:
							goto IL_99;
							IL_130:
							global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
							if (featureNode == null)
							{
								num = (short)543752192;
								num2 = (int)((global::System.IntPtr)num);
							}
							else
							{
								featureNode.Dispose();
								num = (short)1171259395;
								num2 = (int)((global::System.IntPtr)num);
							}
						}
						IL_190:
						goto IL_24D;
					}
					finally
					{
						num = (short)1062535169;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)304742402;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_1C5;
								}
								continue;
							case 2:
								goto IL_1F9;
							}
							IL_1C5:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1086652416;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1F9:;
					}
					goto IL_1FC;
				}
				IL_31:
				if (base.Items != null)
				{
					num = (short)1845624832;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_1FC:
				num = (short)452001793;
				if (num != 0)
				{
				}
				enumerator = base.Items.GetEnumerator();
				num = (short)528154626;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_24D:
			num = (short)1582432256;
			short num4 = num;
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x000615B8 File Offset: 0x0005F7B8
		public void Dispose()
		{
			short num = (short)762904576;
			short num2 = num;
			num = (short)1133800815;
			short num3 = num;
			num = (short)2143907183;
			switch (num3 == num)
			{
			}
			num = (short)587202561;
			if (num != 0)
			{
			}
			num = (short)850198528;
			if (num != 0)
			{
			}
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x040000FF RID: 255
		private global::AcpBusinessLayer.DifferenceCount a;

		// Token: 0x04000100 RID: 256
		private static global::System.Collections.Generic.Dictionary<global::System.Guid, int> b;

		// Token: 0x04000101 RID: 257
		public static bool ParentNodeBeingAdded;

		// Token: 0x04000102 RID: 258
		private global::System.Guid c;

		// Token: 0x04000103 RID: 259
		protected internal int lastId;

		// Token: 0x04000104 RID: 260
		private bool d;

		// Token: 0x04000105 RID: 261
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool e;

		// Token: 0x04000106 RID: 262
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool f;

		// Token: 0x04000107 RID: 263
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int g;

		// Token: 0x04000108 RID: 264
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::AcpBusinessLayer.ReferencedNodeCollection h;

		// Token: 0x04000109 RID: 265
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string i;

		// Token: 0x0400010A RID: 266
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler j;

		// Token: 0x0400010B RID: 267
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string k;

		// Token: 0x0400010C RID: 268
		private bool l;

		// Token: 0x0400010D RID: 269
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string m;

		// Token: 0x0400010E RID: 270
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool n;

		// Token: 0x0400010F RID: 271
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool o;

		// Token: 0x04000110 RID: 272
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool p;

		// Token: 0x04000111 RID: 273
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::AcpCommonLib.IAcpFeatureSection q;

		// Token: 0x04000112 RID: 274
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string r;

		// Token: 0x04000113 RID: 275
		private int s;

		// Token: 0x04000114 RID: 276
		private global::AcpCommonLib.Document t;

		// Token: 0x04000115 RID: 277
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int u;

		// Token: 0x04000116 RID: 278
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int v;

		// Token: 0x04000117 RID: 279
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool w;

		// Token: 0x04000118 RID: 280
		private bool x;

		// Token: 0x04000119 RID: 281
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool y;

		// Token: 0x0400011A RID: 282
		private bool z;

		// Token: 0x0400011B RID: 283
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool aa;

		// Token: 0x0400011C RID: 284
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool ab;

		// Token: 0x0400011D RID: 285
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int ac;

		// Token: 0x0400011E RID: 286
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::AcpBusinessLayer.FeatureNode ad;

		// Token: 0x0400011F RID: 287
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool ae;

		// Token: 0x04000120 RID: 288
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int af;

		// Token: 0x04000121 RID: 289
		private global::AcpCommonLib.Permissions ag;

		// Token: 0x04000122 RID: 290
		private bool ah;

		// Token: 0x04000123 RID: 291
		private bool ai;
	}
}
