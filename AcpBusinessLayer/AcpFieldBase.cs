using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Threading;
using AcpBusinessLayer.Impl;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;

namespace AcpBusinessLayer
{
	// Token: 0x0200000B RID: 11
	[global::System.Serializable]
	public abstract class AcpFieldBase : global::AcpCommonLib.IAcpField, global::AcpCommonLib.IAcpConstraints, global::AcpCommonLib.IAcpCommon, global::System.IComparable, global::System.IDisposable
	{
		// Token: 0x06000093 RID: 147
		internal abstract void DeepCopy(global::AcpCommonLib.IAcpField source);

		// Token: 0x06000094 RID: 148
		internal abstract int CompareToHelper(global::AcpBusinessLayer.AcpFieldBase otherField);

		// Token: 0x06000095 RID: 149
		internal abstract void CreateFieldData(string uiName);

		// Token: 0x06000096 RID: 150 RVA: 0x0000D20C File Offset: 0x0000B40C
		public void FlushUpdateTimer()
		{
			int a_ = 15;
			short num = (short)1983053827;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Delegate delegate2;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
				{
					int num3;
					global::System.Delegate[] invocationList;
					if (num3 >= invocationList.Length)
					{
						goto IL_119;
					}
					global::System.Delegate @delegate = invocationList[num3];
					this.UpdateTimer.Tick -= this.a;
					num3++;
					num = (short)518258693;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_131;
				case 3:
					num = (short)12189697;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_76;
					}
					continue;
				case 4:
				{
					num = (short)31731359;
					short num4 = num;
					num = (short)1604202143;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_119;
					default:
					{
						num = (short)1880752128;
						if (num != 0)
						{
						}
						if (delegate2 == null)
						{
							num = (short)1901527046;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Delegate[] invocationList = delegate2.GetInvocationList();
						int num3 = 0;
						num = (short)1335361543;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 5:
					goto IL_FC;
				case 6:
					return;
				case 7:
					goto IL_FC;
				}
				IL_76:
				num = (short)1388642304;
				short num5 = num;
				if (this.UpdateTimer == null)
				{
					num = (short)2093350912;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				this.UpdateTimer.Stop();
				delegate2 = (global::System.Delegate)typeof(global::System.Windows.Threading.DispatcherTimer).GetField(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("뗠諢蛤賦", a_), global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.NonPublic).GetValue(this.UpdateTimer);
				num = (short)2067464196;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_FC:
				num = (short)971636737;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_119:
				num = (short)1463681026;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_131:
			delegate2 = null;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000D434 File Offset: 0x0000B634
		private void a(object A_0, global::System.EventArgs A_1)
		{
			short num = (short)1328796375;
			short num2 = num;
			num = (short)1058067159;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)844693504;
				if (num != 0)
				{
				}
				object obj = this.lockObject;
				bool flag = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_76;
					}
					int num3;
					for (;;)
					{
						IL_60:
						switch (num3)
						{
						case 0:
							this.UpdateTimer.Tick -= this.a;
							this.UpdateTimer.Stop();
							num = (short)2011496450;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (this.UpdateTimer != null)
							{
								num = (short)454033408;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_F4;
						case 2:
							goto IL_F4;
						case 3:
							goto IL_10B;
						}
						goto IL_76;
						IL_F4:
						num = (short)373030915;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_10B:
					break;
					IL_76:
					global::System.Threading.Monitor.Enter(obj, ref flag);
					this.FirePropertyChangedEvent();
					num = (short)1792868353;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_60;
				}
				finally
				{
					num = (short)1398800384;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_13D;
							}
							continue;
						case 1:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)1588920322;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_172;
						}
						IL_13D:
						if (!flag)
						{
							break;
						}
						num = (short)1683292161;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_172:;
				}
				break;
			}
			}
			num = (short)2136408065;
			if (num != 0)
			{
			}
			num = (short)960954368;
			short num4 = num;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000D618 File Offset: 0x0000B818
		public void SetUITimer()
		{
			short num = (short)127729664;
			short num2 = num;
			object obj = this.lockObject;
			bool flag = false;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_54;
				}
				for (;;)
				{
					IL_3E:
					int num3;
					switch (num3)
					{
					case 0:
						if (this.UpdateTimer != null)
						{
							num = (short)1571422210;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_119;
					case 1:
						goto IL_117;
					case 2:
						this.UpdateTimer.Tick += this.a;
						this.UpdateTimer.Start();
						num = (short)490274817;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_131;
					}
					goto IL_54;
				}
				IL_117:
				goto IL_119;
				IL_131:
				num = (short)1747189761;
				if (num != 0)
				{
				}
				return;
				IL_54:
				global::System.Threading.Monitor.Enter(obj, ref flag);
				num = (short)950423884;
				short num4 = num;
				num = (short)667963724;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_119:
					num = (short)1990721539;
					int num3 = (int)((global::System.IntPtr)num);
					goto IL_3E;
				}
				default:
				{
					num = (short)966131712;
					if (num != 0)
					{
					}
					num = (short)1313079296;
					int num3 = (int)((global::System.IntPtr)num);
					goto IL_3E;
				}
				}
			}
			finally
			{
				num = (short)505282561;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						global::System.Threading.Monitor.Exit(obj);
						num = (short)704053250;
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
						goto IL_1BF;
					}
					IL_18C:
					if (!flag)
					{
						break;
					}
					num = (short)509607936;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1BF:;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000099 RID: 153
		public abstract global::System.Type DataType { get; }

		// Token: 0x0600009A RID: 154 RVA: 0x0000D804 File Offset: 0x0000BA04
		protected AcpFieldBase()
		{
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000D830 File Offset: 0x0000BA30
		protected AcpFieldBase(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel)
		{
			this.Parent = parent;
			parent[uiLabel] = this;
			parent[name, true] = this;
			this.Name = name;
			this.flags = (global::AcpBusinessLayer.AcpFieldBase.FieldFlags.Editable | global::AcpBusinessLayer.AcpFieldBase.FieldFlags.Visible | global::AcpBusinessLayer.AcpFieldBase.FieldFlags.Valid | global::AcpBusinessLayer.AcpFieldBase.FieldFlags.Applicable | global::AcpBusinessLayer.AcpFieldBase.FieldFlags.ForceValid | global::AcpBusinessLayer.AcpFieldBase.FieldFlags.BlockDataTransfer);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000D884 File Offset: 0x0000BA84
		protected AcpFieldBase(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string[] legacyUILabels)
		{
			this.Parent = parent;
			parent[uiLabel] = this;
			parent[name, true] = this;
			this.Name = name;
			foreach (string text in legacyUILabels)
			{
				this.LegacyUINames.Add(text);
				global::AcpCommonLib.AppInfoManager.RegisterLegacyUIName(name, text);
			}
			this.flags = (global::AcpBusinessLayer.AcpFieldBase.FieldFlags.Editable | global::AcpBusinessLayer.AcpFieldBase.FieldFlags.Visible | global::AcpBusinessLayer.AcpFieldBase.FieldFlags.Valid | global::AcpBusinessLayer.AcpFieldBase.FieldFlags.Applicable | global::AcpBusinessLayer.AcpFieldBase.FieldFlags.ForceValid | global::AcpBusinessLayer.AcpFieldBase.FieldFlags.BlockDataTransfer);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000D908 File Offset: 0x0000BB08
		protected internal virtual void FirePropertyChangedEvent()
		{
			int a_ = 3;
			short num = (short)543883264;
			short num2 = num;
			num = (short)1943273473;
			if (num != 0)
			{
			}
			num = (short)2116319122;
			short num3 = num;
			num = (short)18839442;
			switch (num3 == num)
			{
			}
			num = (short)1440219136;
			if (num != 0)
			{
			}
			((global::AcpBusinessLayer.FeatureSection)this.Parent).FirePropertyChanged(this.Name + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("菔뛖뗘껚룜", a_));
			this.UpdateComparison();
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000D9E8 File Offset: 0x0000BBE8
		public void UpdateComparison()
		{
			short num = (short)1539178498;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.AllowsCompare())
					{
						num = (short)476250116;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					goto IL_60;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 3:
					num = (short)975044608;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					global::AcpCommonLib.IAcpField compField = global::AcpCommonLib.Utility.GetCompField(this);
					global::AcpCommonLib.Utility.Compare(this, compField);
					num = (short)1136263173;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
				{
					num = (short)1380974383;
					short num3 = num;
					num = (short)2064777007;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_60;
					default:
						goto IL_EB;
					}
					break;
				}
				case 6:
					if (!global::AcpCommonLib.AppInfoManager.BackgroundDeserializeOpertaion)
					{
						num = (short)666894339;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_41:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
				{
					num = (short)1931149313;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_60:
				num = (short)1030029312;
				short num4 = num;
				num = (short)698810374;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_EB:
			num = (short)1956118529;
			if (num != 0)
			{
			}
			num = (short)248840192;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000DB94 File Offset: 0x0000BD94
		protected internal virtual void FirePropertyChangingEvent()
		{
			int a_ = 2;
			short num = (short)963510272;
			short num2 = num;
			num = (short)496500737;
			if (num != 0)
			{
			}
			num = (short)1707823146;
			short num3 = num;
			num = (short)1186353194;
			switch (num3 == num)
			{
			}
			num = (short)1442775040;
			if (num != 0)
			{
			}
			((global::AcpBusinessLayer.FeatureSection)this.Parent).FirePropertyChanging(this.Name + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("苓럕듗꿙맛", a_));
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x0000DC74 File Offset: 0x0000BE74
		// (set) Token: 0x060000A1 RID: 161 RVA: 0x0000DD24 File Offset: 0x0000BF24
		internal global::AcpBusinessLayer.Impl.AcpFieldImplBase FieldData
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1378353152;
				short num2 = num;
				num = (short)1408484500;
				short num3 = num;
				num = (short)1663485076;
				switch (num3 == num)
				{
				}
				num = (short)1646460928;
				if (num != 0)
				{
				}
				num = (short)1999044609;
				if (num != 0)
				{
				}
				return this.<FieldData>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1956839424;
				short num2 = num;
				num = (short)1559403250;
				short num3 = num;
				num = (short)2121636594;
				switch (num3 == num)
				{
				}
				num = (short)220069889;
				if (num != 0)
				{
				}
				num = (short)30343168;
				if (num != 0)
				{
				}
				this.<FieldData>k__BackingField = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x0000DDD4 File Offset: 0x0000BFD4
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x0000DE88 File Offset: 0x0000C088
		public bool Calling
		{
			get
			{
				short num = (short)1169752064;
				short num2 = num;
				num = (short)988282881;
				if (num != 0)
				{
				}
				num = (short)1709393662;
				short num3 = num;
				num = (short)1728136958;
				switch (num3 == num)
				{
				}
				num = (short)1968439296;
				if (num != 0)
				{
				}
				return (this.flags & global::AcpBusinessLayer.AcpFieldBase.FieldFlags.InConstraint) > global::AcpBusinessLayer.AcpFieldBase.FieldFlags.None;
			}
			set
			{
				short num = (short)98479808;
				short num2 = num;
				num = (short)1997713088;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)978386945;
					if (num != 0)
					{
					}
					num = (short)730857472;
					if (num != 0)
					{
					}
					num = (short)2105409536;
					short num3 = num;
					if (!value)
					{
						this.flags &= ~global::AcpBusinessLayer.AcpFieldBase.FieldFlags.InConstraint;
						return;
					}
					break;
				}
				}
				this.flags |= global::AcpBusinessLayer.AcpFieldBase.FieldFlags.InConstraint;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x0000DF58 File Offset: 0x0000C158
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x0000E010 File Offset: 0x0000C210
		protected bool CallingValueSetter
		{
			get
			{
				short num = (short)1087569920;
				short num2 = num;
				num = (short)43937400;
				short num3 = num;
				num = (short)1346793080;
				switch (num3 == num)
				{
				}
				num = (short)614858752;
				if (num != 0)
				{
				}
				num = (short)424607745;
				if (num != 0)
				{
				}
				return (this.flags & global::AcpBusinessLayer.AcpFieldBase.FieldFlags.InValueConstraint) > global::AcpBusinessLayer.AcpFieldBase.FieldFlags.None;
			}
			set
			{
				short num = (short)765287392;
				short num2 = num;
				num = (short)1339710432;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)531628033;
					if (num != 0)
					{
					}
					num = (short)795607040;
					if (num != 0)
					{
					}
					num = (short)1053687808;
					short num3 = num;
					if (!value)
					{
						this.flags &= ~global::AcpBusinessLayer.AcpFieldBase.FieldFlags.InValueConstraint;
						return;
					}
					break;
				}
				}
				this.flags |= global::AcpBusinessLayer.AcpFieldBase.FieldFlags.InValueConstraint;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x0000E0E0 File Offset: 0x0000C2E0
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x0000E19C File Offset: 0x0000C39C
		public bool SlaveRecRef
		{
			get
			{
				short num = (short)1665662976;
				short num2 = num;
				num = (short)1653335895;
				short num3 = num;
				num = (short)1057417047;
				switch (num3 == num)
				{
				}
				num = (short)2110849025;
				if (num != 0)
				{
				}
				num = (short)1754988544;
				if (num != 0)
				{
				}
				return (this.flags & global::AcpBusinessLayer.AcpFieldBase.FieldFlags.SlaveRecRef) > global::AcpBusinessLayer.AcpFieldBase.FieldFlags.None;
			}
			set
			{
				short num = (short)1546194262;
				short num2 = num;
				num = (short)1989086550;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1213005824;
					if (num != 0)
					{
					}
					if (!value)
					{
						num = (short)585957377;
						if (num != 0)
						{
						}
						this.flags &= ~global::AcpBusinessLayer.AcpFieldBase.FieldFlags.SlaveRecRef;
						return;
					}
					num = (short)1095696384;
					short num3 = num;
					break;
				}
				}
				this.flags |= global::AcpBusinessLayer.AcpFieldBase.FieldFlags.SlaveRecRef;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x0000E270 File Offset: 0x0000C470
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x0000E328 File Offset: 0x0000C528
		public bool EvaluateRecRefs
		{
			get
			{
				short num = (short)173473792;
				short num2 = num;
				num = (short)1779687050;
				short num3 = num;
				num = (short)2101862026;
				switch (num3 == num)
				{
				}
				num = (short)2137849857;
				if (num != 0)
				{
				}
				num = (short)1579220992;
				if (num != 0)
				{
				}
				return (this.flags & global::AcpBusinessLayer.AcpFieldBase.FieldFlags.EvaluateRecRefs) > global::AcpBusinessLayer.AcpFieldBase.FieldFlags.None;
			}
			set
			{
				short num = (short)1128738302;
				short num2 = num;
				num = (short)2140876286;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)488308737;
					if (num != 0)
					{
					}
					num = (short)2034499584;
					if (num != 0)
					{
					}
					num = (short)590413824;
					short num3 = num;
					if (!value)
					{
						this.flags &= ~global::AcpBusinessLayer.AcpFieldBase.FieldFlags.EvaluateRecRefs;
						return;
					}
					break;
				}
				}
				this.flags |= global::AcpBusinessLayer.AcpFieldBase.FieldFlags.EvaluateRecRefs;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000AA RID: 170 RVA: 0x0000E3FC File Offset: 0x0000C5FC
		// (set) Token: 0x060000AB RID: 171 RVA: 0x0000E4B0 File Offset: 0x0000C6B0
		public bool Valid
		{
			get
			{
				short num = (short)1707409408;
				short num2 = num;
				num = (short)595502555;
				short num3 = num;
				num = (short)654288347;
				switch (num3 == num)
				{
				}
				num = (short)1584136192;
				if (num != 0)
				{
				}
				num = (short)1303445505;
				if (num != 0)
				{
				}
				return (this.flags & global::AcpBusinessLayer.AcpFieldBase.FieldFlags.Valid) > global::AcpBusinessLayer.AcpFieldBase.FieldFlags.None;
			}
			set
			{
				int a_ = 18;
				short num = (short)1332019222;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)377487367;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (!global::AcpCommonLib.AppInfoManager.DragOperation)
						{
							num = (short)1989541893;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						if (!this.Applicable)
						{
							num = (short)1900281882;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_305;
					case 3:
						if (!global::AcpCommonLib.AppInfoManager.DragOperation)
						{
							num = (short)1820393497;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FA;
					case 4:
						goto IL_37F;
					case 5:
						num = (short)946733064;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)517013525;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (!global::AcpCommonLib.AppInfoManager.BackgroundDeserializeOpertaion)
						{
							num = (short)1753153560;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FA;
					case 8:
						if (!global::AcpCommonLib.AppInfoManager.BackgroundDeserializeOpertaion)
						{
							num = (short)1877278743;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 9:
						if (this.ValueChanged)
						{
							num = (short)802029581;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 10:
						goto IL_130;
					case 11:
						goto IL_2D9;
					case 12:
						if (!global::AcpCommonLib.AppInfoManager.BackgroundDeserializeOpertaion)
						{
							goto IL_156;
						}
						goto IL_1FA;
					case 13:
						num = (short)1244659713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						this.flags |= global::AcpBusinessLayer.AcpFieldBase.FieldFlags.Valid;
						num = (short)1977417731;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (!this.ForceValid)
						{
							num = (short)1746796564;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FA;
					case 16:
						if (!value)
						{
							num = (short)736034835;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 17:
						global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.UnregisterFieldInReport(this);
						global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.PostFieldsReport();
						num = (short)1147273220;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (!global::AcpCommonLib.AppInfoManager.DragOperation)
						{
							num = (short)1445593088;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FA;
					case 19:
						num = (short)1652752393;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_305;
					case 21:
						if (value)
						{
							num = (short)215089166;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1426915330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						switch (0)
						{
						case 0:
							goto IL_99;
						}
						continue;
					case 23:
					{
						num = (short)1238499328;
						short num3 = num;
						num = (short)705902562;
						short num4 = num;
						num = (short)1565013986;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_156;
						default:
							num = (short)368902144;
							if (num != 0)
							{
							}
							global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.UnregisterFieldInReport(this);
							global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.RegisterFieldInReport(this, string.Empty, true);
							global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.PostFieldsReport();
							num = (short)1296039947;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 24:
						global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.RegisterFieldInReport(this, string.Empty, true);
						global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.PostFieldsReport();
						num = (short)1165230090;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						num = (short)487391244;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						num = (short)1537212431;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_99:
					if (value != this.Valid)
					{
						num = (short)114425862;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1990590480;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_156:
					num = (short)831979537;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_305:
					this.flags &= ~global::AcpBusinessLayer.AcpFieldBase.FieldFlags.Valid;
					num = (short)2097610770;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_130:
				IL_1FA:
				((global::AcpBusinessLayer.FeatureSection)this.Parent).FirePropertyChanged(this.Name + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("믣냥觧蛩藫諭", a_));
				return;
				IL_2D9:
				num = (short)416677889;
				if (num != 0)
				{
				}
				return;
				IL_37F:
				goto IL_1FA;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000AC RID: 172 RVA: 0x0000E9B0 File Offset: 0x0000CBB0
		// (set) Token: 0x060000AD RID: 173 RVA: 0x0000EA64 File Offset: 0x0000CC64
		public bool Editable
		{
			get
			{
				short num = (short)1371930624;
				short num2 = num;
				num = (short)297793806;
				short num3 = num;
				num = (short)370014478;
				switch (num3 == num)
				{
				}
				num = (short)822738945;
				if (num != 0)
				{
				}
				num = (short)136773632;
				if (num != 0)
				{
				}
				return (this.flags & global::AcpBusinessLayer.AcpFieldBase.FieldFlags.Editable) > global::AcpBusinessLayer.AcpFieldBase.FieldFlags.None;
			}
			set
			{
				int a_ = 3;
				short num = (short)594083840;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_3E;
						}
						continue;
					case 1:
						goto IL_CC;
					case 2:
						this.flags |= global::AcpBusinessLayer.AcpFieldBase.FieldFlags.Editable;
						num = (short)1242759171;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)1211395776;
						short num3 = num;
						num = (short)528051904;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							goto IL_12B;
						}
						break;
					}
					}
					IL_3E:
					if (value)
					{
						num = (short)1360461824;
						short num4 = num;
						num = (short)524812290;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)847118337;
						if (num != 0)
						{
						}
						this.flags &= ~global::AcpBusinessLayer.AcpFieldBase.FieldFlags.Editable;
						num = (short)82444289;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_CC:
				goto IL_143;
				IL_12B:
				num = (short)1879703552;
				if (num != 0)
				{
				}
				IL_143:
				((global::AcpBusinessLayer.FeatureSection)this.Parent).FirePropertyChanged(this.Name + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("諔鋖뷘닚꧜뻞菠迢胤", a_));
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000AE RID: 174 RVA: 0x0000EBE0 File Offset: 0x0000CDE0
		// (set) Token: 0x060000AF RID: 175 RVA: 0x0000EC98 File Offset: 0x0000CE98
		public bool Visible
		{
			get
			{
				short num = (short)379125760;
				short num2 = num;
				num = (short)1949825978;
				short num3 = num;
				num = (short)929430458;
				switch (num3 == num)
				{
				}
				num = (short)1799290881;
				if (num != 0)
				{
				}
				num = (short)1805320192;
				if (num != 0)
				{
				}
				return (this.flags & global::AcpBusinessLayer.AcpFieldBase.FieldFlags.Visible) > global::AcpBusinessLayer.AcpFieldBase.FieldFlags.None;
			}
			set
			{
				int a_ = 1;
				short num = (short)572129280;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)451608577;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_67;
						}
						continue;
					case 1:
						goto IL_CD;
					case 2:
						this.flags |= global::AcpBusinessLayer.AcpFieldBase.FieldFlags.Visible;
						num = (short)76349443;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)957661709;
						short num3 = num;
						num = (short)883016205;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							goto IL_12B;
						}
						break;
					}
					}
					IL_67:
					num = (short)938082304;
					short num4 = num;
					if (value)
					{
						num = (short)1054605314;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						this.flags &= ~global::AcpBusinessLayer.AcpFieldBase.FieldFlags.Visible;
						num = (short)568524801;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_CD:
				goto IL_143;
				IL_12B:
				num = (short)175636480;
				if (num != 0)
				{
				}
				IL_143:
				((global::AcpBusinessLayer.FeatureSection)this.Parent).FirePropertyChanged(this.Name + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("賒菔뻖꫘닚뿜돞蓠", a_));
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x0000EE14 File Offset: 0x0000D014
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x0000EED0 File Offset: 0x0000D0D0
		internal bool ForceValid
		{
			get
			{
				short num = (short)385679360;
				short num2 = num;
				num = (short)2068037892;
				short num3 = num;
				num = (short)1150861572;
				switch (num3 == num)
				{
				}
				num = (short)1975910400;
				if (num != 0)
				{
				}
				num = (short)970129409;
				if (num != 0)
				{
				}
				return (this.flags & global::AcpBusinessLayer.AcpFieldBase.FieldFlags.ForceValid) > global::AcpBusinessLayer.AcpFieldBase.FieldFlags.None;
			}
			set
			{
				short num = (short)1235877892;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)245301253;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)2111635456;
						short num3 = num;
						this.flags |= global::AcpBusinessLayer.AcpFieldBase.FieldFlags.ForceValid;
						num = (short)180224007;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_170;
					case 3:
					{
						if (value)
						{
							num = (short)266469377;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)588661298;
						short num4 = num;
						num = (short)766198322;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)377815040;
							if (num != 0)
							{
							}
							num = (short)879951873;
							if (num != 0)
							{
							}
							this.flags &= ~global::AcpBusinessLayer.AcpFieldBase.FieldFlags.ForceValid;
							break;
						}
						num = (short)742522882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						switch (0)
						{
						case 0:
							goto IL_49;
						}
						continue;
					case 5:
						if (!value)
						{
							num = (short)1626865670;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						goto IL_192;
					case 7:
						goto IL_170;
					case 8:
						return;
					}
					IL_49:
					if (value == this.ForceValid)
					{
						num = (short)1715273728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_192;
					IL_170:
					this.Valid = value;
					num = (short)1762459656;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_192:
					num = (short)383909891;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x0000F0D4 File Offset: 0x0000D2D4
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x0000F18C File Offset: 0x0000D38C
		public bool Applicable
		{
			get
			{
				short num = (short)2021785600;
				short num2 = num;
				num = (short)1204530379;
				short num3 = num;
				num = (short)1772334283;
				switch (num3 == num)
				{
				}
				num = (short)709230592;
				if (num != 0)
				{
				}
				num = (short)1875968001;
				if (num != 0)
				{
				}
				return (this.flags & global::AcpBusinessLayer.AcpFieldBase.FieldFlags.Applicable) > global::AcpBusinessLayer.AcpFieldBase.FieldFlags.None;
			}
			set
			{
				int a_ = 15;
				short num = (short)1201799169;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_195;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_45;
						}
						continue;
					case 2:
						this.flags |= global::AcpBusinessLayer.AcpFieldBase.FieldFlags.Applicable;
						num = (short)481296384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (this.ForceValid)
						{
							num = (short)1357185029;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_197;
					case 4:
					{
						num = (short)1461758632;
						short num3 = num;
						num = (short)1143057064;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_B7;
						}
						break;
					}
					case 5:
						this.Valid = true;
						num = (short)2142109700;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_45:
					if (value)
					{
						num = (short)1642266626;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						this.flags &= ~global::AcpBusinessLayer.AcpFieldBase.FieldFlags.Applicable;
						num = (short)855638019;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_B7:
				num = (short)1944518657;
				if (num != 0)
				{
				}
				num = (short)105054208;
				if (num != 0)
				{
				}
				num = (short)1982070784;
				short num4 = num;
				IL_195:
				IL_197:
				((global::AcpBusinessLayer.FeatureSection)this.Parent).FirePropertyChanged(this.Name + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("뻠ꋢ闤韦藨苪軬軮鏰鿲郴", a_));
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x0000F35C File Offset: 0x0000D55C
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x0000F414 File Offset: 0x0000D614
		public bool TieredOut
		{
			get
			{
				short num = (short)822066430;
				short num2 = num;
				num = (short)1207483646;
				switch (num2 == num)
				{
				}
				num = (short)2125987840;
				if (num != 0)
				{
				}
				num = (short)1169620993;
				if (num != 0)
				{
				}
				num = (short)192413696;
				short num3 = num;
				return this.FieldData.TieredOut;
			}
			set
			{
				short num = (short)577376376;
				short num2 = num;
				num = (short)1214451832;
				switch (num2 == num)
				{
				}
				num = (short)934608897;
				if (num != 0)
				{
				}
				num = (short)1113194496;
				if (num != 0)
				{
				}
				num = (short)1983709184;
				short num3 = num;
				this.FieldData.TieredOut = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x0000F4CC File Offset: 0x0000D6CC
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x0000F580 File Offset: 0x0000D780
		public bool DefaultSetByTiering
		{
			get
			{
				short num = (short)1541138829;
				short num2 = num;
				num = (short)1815931277;
				switch (num2 == num)
				{
				}
				num = (short)1358823424;
				if (num != 0)
				{
				}
				num = (short)1471741953;
				if (num != 0)
				{
				}
				num = (short)707919872;
				short num3 = num;
				return this.FieldData.DefaultSetByTiering;
			}
			set
			{
				short num = (short)1292488756;
				short num2 = num;
				num = (short)1936773172;
				switch (num2 == num)
				{
				}
				num = (short)31916033;
				if (num != 0)
				{
				}
				num = (short)200671232;
				if (num != 0)
				{
				}
				num = (short)43646976;
				short num3 = num;
				this.FieldData.DefaultSetByTiering = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x0000F634 File Offset: 0x0000D834
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x0000F6EC File Offset: 0x0000D8EC
		public bool HiddenStatic
		{
			get
			{
				short num = (short)1265586960;
				short num2 = num;
				num = (short)1655657232;
				switch (num2 == num)
				{
				}
				num = (short)671219713;
				if (num != 0)
				{
				}
				num = (short)2123104256;
				if (num != 0)
				{
				}
				num = (short)1430323200;
				short num3 = num;
				return (this.flags & global::AcpBusinessLayer.AcpFieldBase.FieldFlags.HiddenStatic) > global::AcpBusinessLayer.AcpFieldBase.FieldFlags.None;
			}
			set
			{
				short num = (short)405274625;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)521661316;
					short num3 = num;
					num = (short)1298721668;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F5;
					default:
						num = (short)2070675456;
						if (num != 0)
						{
						}
						num = (short)1622212609;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							goto IL_184;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_AA;
							}
							continue;
						case 2:
							goto IL_F0;
						case 3:
							this.flags |= global::AcpBusinessLayer.AcpFieldBase.FieldFlags.HiddenStatic;
							num = (short)1258946564;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.ContainsUIField(this))
							{
								num = (short)1515126784;
								short num4 = num;
								num = (short)647692288;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						IL_AA:
						if (value)
						{
							num = (short)1488650243;
							num2 = (int)((global::System.IntPtr)num);
						}
						else
						{
							this.flags &= ~global::AcpBusinessLayer.AcpFieldBase.FieldFlags.HiddenStatic;
							num = (short)420347906;
							num2 = (int)((global::System.IntPtr)num);
						}
						break;
					}
				}
				IL_F0:
				return;
				IL_F5:
				global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.UnregisterFieldInUIReport(this);
				global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.FieldsReportChanged = true;
				return;
				IL_184:
				goto IL_F5;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000BA RID: 186 RVA: 0x0000F884 File Offset: 0x0000DA84
		// (set) Token: 0x060000BB RID: 187 RVA: 0x0000F938 File Offset: 0x0000DB38
		public bool HiddenDynamic
		{
			get
			{
				short num = (short)2006577928;
				short num2 = num;
				num = (short)464122632;
				switch (num2 == num)
				{
				}
				num = (short)415105025;
				if (num != 0)
				{
				}
				num = (short)423559168;
				if (num != 0)
				{
				}
				num = (short)1653342208;
				short num3 = num;
				return (this.flags & global::AcpBusinessLayer.AcpFieldBase.FieldFlags.HiddenDynamic) > global::AcpBusinessLayer.AcpFieldBase.FieldFlags.None;
			}
			set
			{
				short num = (short)2136043288;
				short num2 = num;
				num = (short)854290200;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1104150528;
					if (num != 0)
					{
					}
					if (value)
					{
						num = (short)2093416449;
						if (num != 0)
						{
						}
						this.flags |= global::AcpBusinessLayer.AcpFieldBase.FieldFlags.HiddenDynamic;
						return;
					}
					break;
				}
				num = (short)1247281152;
				short num3 = num;
				this.flags &= ~global::AcpBusinessLayer.AcpFieldBase.FieldFlags.HiddenDynamic;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0000FA0C File Offset: 0x0000DC0C
		// (set) Token: 0x060000BD RID: 189 RVA: 0x0000FAC8 File Offset: 0x0000DCC8
		public bool HiddenDynamicByApp
		{
			get
			{
				short num = (short)2055077185;
				short num2 = num;
				num = (short)1571290433;
				switch (num2 == num)
				{
				}
				num = (short)88408065;
				if (num != 0)
				{
				}
				num = (short)266993664;
				if (num != 0)
				{
				}
				num = (short)1944059904;
				short num3 = num;
				return (this.flags & global::AcpBusinessLayer.AcpFieldBase.FieldFlags.HiddenDynamicByApp) > global::AcpBusinessLayer.AcpFieldBase.FieldFlags.None;
			}
			set
			{
				short num = (short)398756201;
				short num2 = num;
				num = (short)2025097577;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)472186881;
					if (num != 0)
					{
					}
					num = (short)1143275520;
					if (num != 0)
					{
					}
					if (value)
					{
						this.flags |= global::AcpBusinessLayer.AcpFieldBase.FieldFlags.HiddenDynamicByApp;
						return;
					}
					break;
				}
				num = (short)807993344;
				short num3 = num;
				this.flags &= ~global::AcpBusinessLayer.AcpFieldBase.FieldFlags.HiddenDynamicByApp;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000BE RID: 190 RVA: 0x0000FBA0 File Offset: 0x0000DDA0
		// (set) Token: 0x060000BF RID: 191 RVA: 0x0000FC54 File Offset: 0x0000DE54
		public bool CustomViewVisibility
		{
			get
			{
				short num = (short)1381289035;
				short num2 = num;
				num = (short)2060110923;
				switch (num2 == num)
				{
				}
				num = (short)91095041;
				if (num != 0)
				{
				}
				num = (short)1908932608;
				if (num != 0)
				{
				}
				num = (short)1674248192;
				short num3 = num;
				return this.FieldData.CustomViewVisibility;
			}
			set
			{
				short num = (short)1983796196;
				short num2 = num;
				num = (short)1511019492;
				switch (num2 == num)
				{
				}
				num = (short)1124597760;
				if (num != 0)
				{
				}
				num = (short)861732865;
				if (num != 0)
				{
				}
				num = (short)264830976;
				short num3 = num;
				this.FieldData.CustomViewVisibility = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x0000FD08 File Offset: 0x0000DF08
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x0000FDC0 File Offset: 0x0000DFC0
		public bool BlockDataTransfer
		{
			get
			{
				short num = (short)545605934;
				short num2 = num;
				num = (short)261703982;
				switch (num2 == num)
				{
				}
				num = (short)630652929;
				if (num != 0)
				{
				}
				num = (short)805371904;
				if (num != 0)
				{
				}
				num = (short)1683161088;
				short num3 = num;
				return (this.flags & global::AcpBusinessLayer.AcpFieldBase.FieldFlags.BlockDataTransfer) > global::AcpBusinessLayer.AcpFieldBase.FieldFlags.None;
			}
			internal set
			{
				short num = (short)1785283698;
				short num2 = num;
				num = (short)1928938610;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)744292352;
					if (num != 0)
					{
					}
					if (value)
					{
						num = (short)2120089601;
						if (num != 0)
						{
						}
						this.flags |= global::AcpBusinessLayer.AcpFieldBase.FieldFlags.BlockDataTransfer;
						return;
					}
					break;
				}
				num = (short)971898880;
				short num3 = num;
				this.flags &= ~global::AcpBusinessLayer.AcpFieldBase.FieldFlags.BlockDataTransfer;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x0000FE94 File Offset: 0x0000E094
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x0000FF50 File Offset: 0x0000E150
		public bool UIInvalid
		{
			get
			{
				short num = (short)1459857961;
				short num2 = num;
				num = (short)771664425;
				switch (num2 == num)
				{
				}
				num = (short)1106968577;
				if (num != 0)
				{
				}
				num = (short)961675264;
				if (num != 0)
				{
				}
				num = (short)670892032;
				short num3 = num;
				return (this.flags & global::AcpBusinessLayer.AcpFieldBase.FieldFlags.InvalidUIValue) > global::AcpBusinessLayer.AcpFieldBase.FieldFlags.None;
			}
			set
			{
				short num = (short)139365527;
				short num2 = num;
				num = (short)1213238423;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)209911809;
					if (num != 0)
					{
					}
					num = (short)1422721024;
					if (num != 0)
					{
					}
					if (value)
					{
						this.flags |= global::AcpBusinessLayer.AcpFieldBase.FieldFlags.InvalidUIValue;
						return;
					}
					break;
				}
				num = (short)504627200;
				short num3 = num;
				this.flags &= ~global::AcpBusinessLayer.AcpFieldBase.FieldFlags.InvalidUIValue;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00010024 File Offset: 0x0000E224
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x000100DC File Offset: 0x0000E2DC
		public bool DnDDone
		{
			get
			{
				short num = (short)1549860865;
				if (num != 0)
				{
				}
				num = (short)2097448054;
				short num2 = num;
				num = (short)1789101174;
				switch (num2 == num)
				{
				}
				num = (short)1568604160;
				if (num != 0)
				{
				}
				num = (short)188678144;
				short num3 = num;
				return (this.flags & global::AcpBusinessLayer.AcpFieldBase.FieldFlags.DnDDone) > global::AcpBusinessLayer.AcpFieldBase.FieldFlags.None;
			}
			set
			{
				short num = (short)1214864590;
				short num2 = num;
				num = (short)356801742;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)207421441;
					if (num != 0)
					{
					}
					num = (short)136577024;
					if (num != 0)
					{
					}
					if (value)
					{
						this.flags |= global::AcpBusinessLayer.AcpFieldBase.FieldFlags.DnDDone;
						return;
					}
					break;
				}
				num = (short)2108686336;
				short num3 = num;
				this.flags &= ~global::AcpBusinessLayer.AcpFieldBase.FieldFlags.DnDDone;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x000101B0 File Offset: 0x0000E3B0
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x0001026C File Offset: 0x0000E46C
		public bool UnsupportedValue
		{
			get
			{
				short num = (short)1259318359;
				short num2 = num;
				num = (short)169061463;
				switch (num2 == num)
				{
				}
				num = (short)1447886849;
				if (num != 0)
				{
				}
				num = (short)2001534976;
				if (num != 0)
				{
				}
				num = (short)1786445824;
				short num3 = num;
				return (this.flags & global::AcpBusinessLayer.AcpFieldBase.FieldFlags.UnsupportedValue) > global::AcpBusinessLayer.AcpFieldBase.FieldFlags.None;
			}
			set
			{
				short num = (short)800933141;
				short num2 = num;
				num = (short)1287734549;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)505085953;
					if (num != 0)
					{
					}
					num = (short)1340080128;
					if (num != 0)
					{
					}
					if (value)
					{
						this.flags |= global::AcpBusinessLayer.AcpFieldBase.FieldFlags.UnsupportedValue;
						return;
					}
					break;
				}
				num = (short)712900608;
				short num3 = num;
				this.flags &= ~global::AcpBusinessLayer.AcpFieldBase.FieldFlags.UnsupportedValue;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x00010340 File Offset: 0x0000E540
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x000103F8 File Offset: 0x0000E5F8
		public bool ValidateAcrossRecset
		{
			get
			{
				short num = (short)38578835;
				short num2 = num;
				num = (short)1636018835;
				switch (num2 == num)
				{
				}
				num = (short)554369025;
				if (num != 0)
				{
				}
				num = (short)1932394496;
				if (num != 0)
				{
				}
				num = (short)1029177344;
				short num3 = num;
				return (this.flags & global::AcpBusinessLayer.AcpFieldBase.FieldFlags.AcrossRecset) > global::AcpBusinessLayer.AcpFieldBase.FieldFlags.None;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_24;
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
						for (;;)
						{
							((global::AcpBusinessLayer.Recordset)this.Parent.ParentRecset).MustCalculateValidityAcross = true;
							num2 = (short)2006875921;
							short num3 = num2;
							num2 = (short)210927377;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							case 1:
								goto IL_E4;
							}
							goto Block_2;
						}
						IL_E4:
						num2 = (short)1705967616;
						if (num2 != 0)
						{
						}
						num2 = (short)1281294338;
						num = (int)((global::System.IntPtr)num2);
						continue;
						Block_2:
						num2 = (short)1063780352;
						short num4 = num2;
						goto IL_E4;
					}
					case 1:
						if (this.Parent != null)
						{
							num2 = (short)2014576643;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 2:
						return;
					case 3:
						num2 = (short)1405812740;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						if (this.Parent.ParentRecset != null)
						{
							num2 = (short)98893825;
							if (num2 != 0)
							{
							}
							num2 = (short)1112342528;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					goto IL_24;
				}
				return;
				IL_24:
				this.flags |= global::AcpBusinessLayer.AcpFieldBase.FieldFlags.AcrossRecset;
				num2 = (short)33619969;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00010580 File Offset: 0x0000E780
		// (set) Token: 0x060000CB RID: 203 RVA: 0x00010634 File Offset: 0x0000E834
		public virtual global::AcpCommonLib.StateConstraint IsValid
		{
			get
			{
				short num = (short)1521366278;
				short num2 = num;
				num = (short)808989958;
				switch (num2 == num)
				{
				}
				num = (short)1593442304;
				if (num != 0)
				{
				}
				num = (short)1220345857;
				if (num != 0)
				{
				}
				num = (short)1314193408;
				short num3 = num;
				return this.FieldData.IsValid;
			}
			set
			{
				short num = (short)1740889202;
				short num2 = num;
				num = (short)1861606514;
				switch (num2 == num)
				{
				}
				num = (short)461963264;
				if (num != 0)
				{
				}
				num = (short)1038483457;
				if (num != 0)
				{
				}
				num = (short)666632192;
				short num3 = num;
				((global::AcpBusinessLayer.FeatureNode)this.Parent.Parent).RegisterValidity(this);
				this.FieldData.IsValid = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00010700 File Offset: 0x0000E900
		// (set) Token: 0x060000CD RID: 205 RVA: 0x000107B8 File Offset: 0x0000E9B8
		public global::AcpCommonLib.StateConstraint IsApplicable
		{
			get
			{
				short num = (short)1474741398;
				short num2 = num;
				num = (short)1692451990;
				switch (num2 == num)
				{
				}
				num = (short)144113664;
				if (num != 0)
				{
				}
				num = (short)1092288513;
				if (num != 0)
				{
				}
				num = (short)1431568384;
				short num3 = num;
				return this.FieldData.IsApplicable;
			}
			set
			{
				short num = (short)578671225;
				short num2 = num;
				num = (short)1254478457;
				switch (num2 == num)
				{
				}
				num = (short)1900019713;
				if (num != 0)
				{
				}
				num = (short)794361856;
				if (num != 0)
				{
				}
				num = (short)2004221952;
				short num3 = num;
				((global::AcpBusinessLayer.FeatureNode)this.Parent.Parent).RegisterApplicability(this);
				this.FieldData.IsApplicable = value;
			}
		}

		// Token: 0x060000CE RID: 206
		public abstract global::AcpCommonLib.UndoRedo.UndoableTask CopyValueOf(global::AcpCommonLib.IAcpField source);

		// Token: 0x060000CF RID: 207
		public abstract global::AcpCommonLib.UndoRedo.UndoableTask CopyValue(object sourcevalue);

		// Token: 0x060000D0 RID: 208 RVA: 0x00010884 File Offset: 0x0000EA84
		public bool AddDependentObject(global::AcpCommonLib.IAcpField obj)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				global::AcpBusinessLayer.AcpFieldBase item;
				switch (num)
				{
				case 0:
					this.dependentObjects = new global::System.Collections.Generic.List<global::AcpBusinessLayer.AcpFieldBase>();
					num2 = (short)2023620613;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (this.dependentObjects == null)
					{
						num2 = (short)1467940864;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_7A;
				case 2:
				{
					num2 = (short)1585559350;
					short num3 = num2;
					num2 = (short)42710838;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_46;
					default:
						goto IL_14A;
					}
					break;
				}
				case 3:
					goto IL_46;
				case 4:
					num2 = (short)1528561665;
					if (num2 != 0)
					{
					}
					if (!this.dependentObjects.Contains(item))
					{
						num2 = (short)1269628934;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C8;
				case 5:
					goto IL_7A;
				case 6:
					this.dependentObjects.Add(item);
					result = true;
					num2 = (short)134217735;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_187;
				}
				goto IL_30;
				IL_46:
				if (this.Parent.Parent == obj.Parent.Parent)
				{
					num2 = (short)1678442498;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				num2 = (short)1958150145;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_7A:
				item = (global::AcpBusinessLayer.AcpFieldBase)obj;
				num2 = (short)176619524;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_14A:
			num2 = (short)866779136;
			if (num2 != 0)
			{
			}
			return false;
			IL_187:
			IL_1C8:
			num2 = (short)2102001664;
			short num4 = num2;
			return result;
			IL_30:
			result = false;
			num2 = (short)862388227;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x00010A84 File Offset: 0x0000EC84
		// (set) Token: 0x060000D2 RID: 210 RVA: 0x00010B38 File Offset: 0x0000ED38
		public string Name
		{
			get
			{
				short num = (short)495272214;
				short num2 = num;
				num = (short)1999323414;
				switch (num2 == num)
				{
				}
				num = (short)1699938305;
				if (num != 0)
				{
				}
				num = (short)499843072;
				short num3 = num;
				num = (short)1758789632;
				if (num != 0)
				{
				}
				return this.FieldData.Name;
			}
			internal set
			{
				short num = (short)1857496194;
				short num2 = num;
				num = (short)1218061442;
				switch (num2 == num)
				{
				}
				num = (short)1801453569;
				if (num != 0)
				{
				}
				num = (short)1180106752;
				short num3 = num;
				num = (short)1568210944;
				if (num != 0)
				{
				}
				this.FieldData.Name = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x00010BEC File Offset: 0x0000EDEC
		// (set) Token: 0x060000D4 RID: 212 RVA: 0x00010CA4 File Offset: 0x0000EEA4
		public bool Protected
		{
			get
			{
				short num = (short)423259281;
				short num2 = num;
				num = (short)1967352977;
				switch (num2 == num)
				{
				}
				num = (short)295960576;
				if (num != 0)
				{
				}
				num = (short)1728577536;
				short num3 = num;
				num = (short)597688321;
				if (num != 0)
				{
				}
				return this.FieldData.Protected;
			}
			set
			{
				for (;;)
				{
					short num = (short)1829765120;
					short num2 = num;
					switch (0)
					{
					case 0:
						goto IL_46;
					}
					for (;;)
					{
						IL_34:
						int num3;
						switch (num3)
						{
						case 0:
							((global::AcpBusinessLayer.FeatureNode)this.Parent.Parent).RegisterEditability(this);
							((global::AcpBusinessLayer.FeatureNode)this.Parent.Parent).RegisterValidity(this);
							num = (short)536805377;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							return;
						case 2:
							if (value)
							{
								num = (short)778698753;
								if (num != 0)
								{
								}
								num = (short)515440640;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						break;
					}
					IL_46:
					this.FieldData.Protected = value;
					num = (short)466031058;
					short num4 = num;
					num = (short)1126568402;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)677314560;
						if (num != 0)
						{
						}
						num = (short)1161691138;
						int num3 = (int)((global::System.IntPtr)num);
						goto IL_34;
					}
					}
				}
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x00010DF0 File Offset: 0x0000EFF0
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x00010EA8 File Offset: 0x0000F0A8
		public bool DisableASKRangeValidation
		{
			get
			{
				short num = (short)2096500505;
				short num2 = num;
				num = (short)788074265;
				switch (num2 == num)
				{
				}
				num = (short)1656553473;
				if (num != 0)
				{
				}
				num = (short)1076690944;
				short num3 = num;
				num = (short)1633026048;
				if (num != 0)
				{
				}
				return (this.flags & global::AcpBusinessLayer.AcpFieldBase.FieldFlags.DisableASKRangeValidation) > global::AcpBusinessLayer.AcpFieldBase.FieldFlags.None;
			}
			set
			{
				if (value)
				{
					short num;
					for (;;)
					{
						num = (short)1502543872;
						short num2 = num;
						num = (short)1113967303;
						short num3 = num;
						num = (short)771017415;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_67;
						}
					}
					IL_67:
					num = (short)1825112065;
					if (num != 0)
					{
					}
					num = (short)968622080;
					if (num != 0)
					{
					}
					this.flags |= global::AcpBusinessLayer.AcpFieldBase.FieldFlags.DisableASKRangeValidation;
					return;
				}
				this.flags &= ~global::AcpBusinessLayer.AcpFieldBase.FieldFlags.DisableASKRangeValidation;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00010F7C File Offset: 0x0000F17C
		// (set) Token: 0x060000D8 RID: 216 RVA: 0x00011034 File Offset: 0x0000F234
		public bool NotifyPropertyChanging
		{
			get
			{
				short num = (short)1477465222;
				short num2 = num;
				num = (short)1072583814;
				switch (num2 == num)
				{
				}
				num = (short)974389248;
				if (num != 0)
				{
				}
				num = (short)669384704;
				short num3 = num;
				num = (short)1888157697;
				if (num != 0)
				{
				}
				return (this.flags & global::AcpBusinessLayer.AcpFieldBase.FieldFlags.NotifyPropertyChanging) > global::AcpBusinessLayer.AcpFieldBase.FieldFlags.None;
			}
			set
			{
				if (value)
				{
					short num;
					for (;;)
					{
						num = (short)713228289;
						if (num != 0)
						{
						}
						num = (short)589234176;
						short num2 = num;
						num = (short)391877419;
						short num3 = num;
						num = (short)1566806827;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_8F;
						}
					}
					IL_8F:
					num = (short)1136918528;
					if (num != 0)
					{
					}
					this.flags |= global::AcpBusinessLayer.AcpFieldBase.FieldFlags.NotifyPropertyChanging;
					return;
				}
				this.flags &= ~global::AcpBusinessLayer.AcpFieldBase.FieldFlags.NotifyPropertyChanging;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x0001110C File Offset: 0x0000F30C
		public string UIName
		{
			get
			{
				short num = (short)1604105243;
				short num2 = num;
				num = (short)877311003;
				switch (num2 == num)
				{
				}
				num = (short)1718812673;
				if (num != 0)
				{
				}
				num = (short)1687945216;
				short num3 = num;
				num = (short)367329280;
				if (num != 0)
				{
				}
				return this.FieldData.UIName;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000DA RID: 218 RVA: 0x000111C0 File Offset: 0x0000F3C0
		public global::System.Collections.Generic.ISet<string> LegacyUINames
		{
			get
			{
				short num = (short)417640805;
				short num2 = num;
				num = (short)2114761061;
				switch (num2 == num)
				{
				}
				num = (short)371720193;
				if (num != 0)
				{
				}
				num = (short)986316800;
				short num3 = num;
				num = (short)2004811776;
				if (num != 0)
				{
				}
				return this.FieldData.LegacyUINames;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00011274 File Offset: 0x0000F474
		// (set) Token: 0x060000DC RID: 220 RVA: 0x00011328 File Offset: 0x0000F528
		public string NewUiExpanderAndName
		{
			get
			{
				short num = (short)1944876746;
				short num2 = num;
				num = (short)725841610;
				switch (num2 == num)
				{
				}
				num = (short)1282342913;
				if (num != 0)
				{
				}
				num = (short)1634205696;
				short num3 = num;
				num = (short)145293312;
				if (num != 0)
				{
				}
				return this.FieldData.NewUiExpanderAndName;
			}
			set
			{
				short num = (short)1159945135;
				short num2 = num;
				num = (short)537287599;
				switch (num2 == num)
				{
				}
				num = (short)123404288;
				if (num != 0)
				{
				}
				num = (short)314179584;
				short num3 = num;
				num = (short)243400705;
				if (num != 0)
				{
				}
				this.FieldData.NewUiExpanderAndName = value;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000DD RID: 221 RVA: 0x000113E0 File Offset: 0x0000F5E0
		// (set) Token: 0x060000DE RID: 222 RVA: 0x00011490 File Offset: 0x0000F690
		public global::AcpCommonLib.IAcpFeatureSection Parent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2120975092;
				short num2 = num;
				num = (short)246514420;
				switch (num2 == num)
				{
				}
				num = (short)1849753601;
				if (num != 0)
				{
				}
				num = (short)184418304;
				short num3 = num;
				num = (short)943390720;
				if (num != 0)
				{
				}
				return this.<Parent>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1081108696;
				short num2 = num;
				num = (short)2143316184;
				switch (num2 == num)
				{
				}
				num = (short)2012676096;
				if (num != 0)
				{
				}
				num = (short)942669824;
				short num3 = num;
				num = (short)154009601;
				if (num != 0)
				{
				}
				this.<Parent>k__BackingField = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000DF RID: 223 RVA: 0x00011540 File Offset: 0x0000F740
		public string NewUIExpanderName
		{
			get
			{
				if (!string.IsNullOrEmpty(this.NewUiExpanderAndName))
				{
					short num;
					for (;;)
					{
						num = (short)1657667584;
						short num2 = num;
						num = (short)421558334;
						short num3 = num;
						num = (short)947157054;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_70;
						}
					}
					IL_70:
					num = (short)1249574913;
					if (num != 0)
					{
					}
					num = (short)127664128;
					if (num != 0)
					{
					}
					return this.NewUiExpanderAndName.Split(new char[]
					{
						'\\'
					})[0];
				}
				return null;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x00011614 File Offset: 0x0000F814
		public string NewUIName
		{
			get
			{
				int a_ = 0;
				short num = (short)186122245;
				int num2 = (int)((global::System.IntPtr)num);
				string[] array;
				string[] array2;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1211564033;
						if (num != 0)
						{
						}
						goto IL_FD;
					case 1:
						if (array.Length == 3)
						{
							num = (short)2092630020;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_191;
					case 2:
						if (array2.Length == 2)
						{
							num = (short)193658883;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_177;
					case 3:
						goto IL_FB;
					case 4:
						array2 = this.UIName.Split(new char[]
						{
							'\\'
						});
						num = (short)1191247874;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_45;
						}
						continue;
					}
					IL_45:
					if (!string.IsNullOrEmpty(this.NewUiExpanderAndName))
					{
						num = (short)1699086336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_191;
					IL_FD:
					array = this.NewUiExpanderAndName.Split(new char[]
					{
						'\\'
					});
					num = (short)229769216;
					short num3 = num;
					num = (short)278200321;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_191:
					num = (short)2014384149;
					short num4 = num;
					num = (short)548868117;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FD;
					default:
						goto IL_1C6;
					}
				}
				IL_FB:
				return array[1] + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("軑", a_) + array2[1];
				IL_177:
				return array[1] + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("軑", a_) + array2[0];
				IL_1C6:
				num = (short)1620377600;
				if (num != 0)
				{
				}
				return null;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x00011800 File Offset: 0x0000FA00
		public global::AcpCommonLib.IAcpFeatureSection NewParent
		{
			get
			{
				short num = (short)19398662;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)850984963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_B7;
					case 2:
					{
						num = (short)1584136192;
						short num3 = num;
						if (!string.IsNullOrEmpty(this.NewUiExpanderAndName))
						{
							num = (short)1020329989;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FB;
					}
					case 3:
						if (this.Parent.Parent != null)
						{
							num = (short)11599876;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FB;
					case 4:
						num = (short)1323499522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						enumerator = this.Parent.Parent.FeatureSectionsCollection.GetEnumerator();
						num = (short)541327361;
						if (num != 0)
						{
						}
						num = (short)1593769985;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_40;
						}
						continue;
					}
					IL_40:
					if (this.Parent == null)
					{
						goto IL_FB;
					}
					num = (short)2088697856;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_B7:
				global::AcpCommonLib.IAcpFeatureSection result;
				try
				{
					num = (short)360054790;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)2030108673;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = enumerator.Current;
							num = (short)1109721092;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							num = (short)1448345605;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
							result = acpFeatureSection;
							num = (short)878575619;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_1F8;
						case 4:
						{
							global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
							if (acpFeatureSection.UIName == this.NewUIExpanderName)
							{
								num = (short)1529959713;
								short num4 = num;
								num = (short)1998673185;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_2B0;
								default:
									num = (short)468254720;
									if (num != 0)
									{
									}
									num = (short)622723074;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
							}
							break;
						}
						case 5:
							goto IL_2B0;
						case 6:
							switch (0)
							{
							case 0:
								goto IL_1A9;
							}
							continue;
						}
						IL_1AB:
						num = (short)3276800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1A9:
						goto IL_1AB;
					}
					IL_1F8:
					return result;
					IL_2B0:
					goto IL_FB;
				}
				finally
				{
					num = (short)916520962;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)756350977;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_31B;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_2E6;
							}
							continue;
						}
						IL_2E6:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1189478400;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_31B:;
				}
				return result;
				IL_FB:
				return null;
			}
		}

		// Token: 0x060000E2 RID: 226
		public abstract void ResetToDefault();

		// Token: 0x060000E3 RID: 227
		public abstract void ResetToDefaultWithUndo();

		// Token: 0x060000E4 RID: 228
		public abstract void ResetToDefaultWithUndo(global::AcpCommonLib.UndoRedo.ContainerTask taskContainer);

		// Token: 0x060000E5 RID: 229
		public abstract void ParseValueFrom(string value);

		// Token: 0x060000E6 RID: 230
		public abstract void ParseDefaultValueFrom(string value);

		// Token: 0x060000E7 RID: 231 RVA: 0x00011B48 File Offset: 0x0000FD48
		public void CalculateValidityAcrossRecset()
		{
			short num = (short)1670316034;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					((global::AcpBusinessLayer.Recordset)this.Parent.ParentRecset).CalculateValidityAcrossFor(this.Parent.FeatureSectionId, this.UIName);
					num = (short)1117847552;
					short num3 = num;
					num = (short)1751842817;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_C1;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				goto IL_31;
				IL_41:
				num = (short)549715968;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C1:
				num = (short)146235826;
				short num4 = num;
				num = (short)2007196082;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_41;
				default:
					goto IL_F7;
				}
				IL_31:
				if (this.Parent.ParentRecset != null)
				{
					goto IL_41;
				}
				goto IL_C1;
			}
			IL_F7:
			num = (short)1472987137;
			if (num != 0)
			{
			}
			num = (short)1804337152;
			if (num != 0)
			{
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x00011C8C File Offset: 0x0000FE8C
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x00011D44 File Offset: 0x0000FF44
		public bool IgnoreOnCompare
		{
			get
			{
				short num = (short)629428727;
				short num2 = num;
				num = (short)1905807863;
				switch (num2 == num)
				{
				}
				num = (short)795017216;
				if (num != 0)
				{
				}
				num = (short)2106851328;
				short num3 = num;
				num = (short)426311681;
				if (num != 0)
				{
				}
				return this.FieldData.IgnoreOnCompare;
			}
			set
			{
				short num = (short)819719860;
				short num2 = num;
				num = (short)947383988;
				switch (num2 == num)
				{
				}
				num = (short)1074003969;
				if (num != 0)
				{
				}
				num = (short)480313344;
				short num3 = num;
				num = (short)835452928;
				if (num != 0)
				{
				}
				this.FieldData.IgnoreOnCompare = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000EA RID: 234 RVA: 0x00011DFC File Offset: 0x0000FFFC
		// (set) Token: 0x060000EB RID: 235 RVA: 0x00011EB0 File Offset: 0x000100B0
		public bool IgnoreOnPrint
		{
			get
			{
				short num = (short)419345563;
				short num2 = num;
				num = (short)2083435675;
				switch (num2 == num)
				{
				}
				num = (short)62259201;
				if (num != 0)
				{
				}
				num = (short)1136066560;
				short num3 = num;
				num = (short)328925184;
				if (num != 0)
				{
				}
				return this.FieldData.IgnoreOnPrint;
			}
			set
			{
				short num = (short)1100611585;
				if (num != 0)
				{
				}
				num = (short)1088603286;
				short num2 = num;
				num = (short)1318306966;
				switch (num2 == num)
				{
				}
				num = (short)1456209920;
				short num3 = num;
				num = (short)1277755392;
				if (num != 0)
				{
				}
				this.FieldData.IgnoreOnPrint = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00011F64 File Offset: 0x00010164
		// (set) Token: 0x060000ED RID: 237 RVA: 0x0001201C File Offset: 0x0001021C
		public bool IsMasked
		{
			get
			{
				short num = (short)1119186722;
				short num2 = num;
				num = (short)1118007074;
				switch (num2 == num)
				{
				}
				num = (short)395575297;
				if (num != 0)
				{
				}
				num = (short)982515712;
				short num3 = num;
				num = (short)671154176;
				if (num != 0)
				{
				}
				return this.FieldData.IsMasked;
			}
			set
			{
				short num = (short)24444929;
				if (num != 0)
				{
				}
				num = (short)1442200983;
				short num2 = num;
				num = (short)974011799;
				switch (num2 == num)
				{
				}
				num = (short)944046080;
				short num3 = num;
				num = (short)1581318144;
				if (num != 0)
				{
				}
				this.FieldData.IsMasked = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000EE RID: 238 RVA: 0x000120D0 File Offset: 0x000102D0
		public global::AcpCommonLib.IAcpFeatureNode ParentNode
		{
			get
			{
				if (this.Parent != null)
				{
					short num;
					for (;;)
					{
						num = (short)1858863104;
						short num2 = num;
						num = (short)2014798901;
						short num3 = num;
						num = (short)1792238645;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_6A;
						}
					}
					IL_6A:
					num = (short)986316801;
					if (num != 0)
					{
					}
					num = (short)1780219904;
					if (num != 0)
					{
					}
					return this.Parent.Parent;
				}
				return null;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000EF RID: 239 RVA: 0x00012190 File Offset: 0x00010390
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x00012240 File Offset: 0x00010440
		public bool _HasDiffs
		{
			get
			{
				short num = (short)1630311899;
				short num2 = num;
				num = (short)1696830939;
				switch (num2 == num)
				{
				}
				num = (short)2021326849;
				if (num != 0)
				{
				}
				num = (short)1118502912;
				short num3 = num;
				num = (short)1484062720;
				if (num != 0)
				{
				}
				return this.hasDiffs;
			}
			set
			{
				int a_ = 2;
				short num = (short)1565720577;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (this.hasDiffs)
						{
							num = (short)1369374733;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_71;
						}
						continue;
					case 2:
						goto IL_4F0;
					case 3:
						if (this.Parent.Parent != null)
						{
							num = (short)67698692;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
					{
						num = (short)796327937;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator = this.Parent.Parent.FeatureSectionsCollection.GetEnumerator();
						num = (short)2071658505;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_448;
					case 6:
						try
						{
							num = (short)1962934272;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1D3;
									}
									continue;
								case 1:
									goto IL_3C3;
								case 2:
									goto IL_2D7;
								case 3:
									num = (short)1002569742;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_33E;
								case 5:
									goto IL_33E;
								case 6:
									((global::AcpBusinessLayer.FeatureSection)this.Parent).FirePropertyChanged(this.Name + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("诓黕맗꧙飛럝蛟蓡韣", a_));
									num = (short)658112514;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)523436033;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = enumerator.Current;
									num = (short)264830988;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									num = (short)2111111178;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
									((global::AcpBusinessLayer.FeatureSection)acpFeatureSection).DiffCount.Decrement(this.Name);
									num = (short)2072641541;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
									if (((global::AcpBusinessLayer.FeatureSection)acpFeatureSection).DiffCount.Value > 0)
									{
										num = (short)1486159881;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									((global::AcpBusinessLayer.FeatureSection)acpFeatureSection).FirePropertyChanged(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("鳓럕ꯗ黙뗛룝蛟釡", a_));
									num = (short)180224004;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
								{
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
									if (acpFeatureSection != this.Parent)
									{
										num = (short)1421541382;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3C3;
								}
								case 12:
									if (this.NewParent != null)
									{
										num = (short)1768161283;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 13:
									goto IL_3DA;
								case 14:
								{
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection;
									if (acpFeatureSection == this.NewParent)
									{
										num = (short)1591869448;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_256:
								num = (short)1629159431;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1D3:
								goto IL_256;
								IL_33E:
								num = (short)1628307467;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3C3:
								num = (short)767819789;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2D7:
							IL_3DA:
							return;
						}
						finally
						{
							num = (short)394985474;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)161742849;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_445;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_40F;
									}
									continue;
								}
								IL_40F:
								if (enumerator == null)
								{
									break;
								}
								num = (short)12386304;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_445:;
						}
						goto IL_448;
					case 7:
						if (!string.IsNullOrEmpty(this.NewUiExpanderAndName))
						{
							num = (short)1022361605;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_866;
					case 8:
						if (!string.IsNullOrEmpty(this.NewUiExpanderAndName))
						{
							num = (short)777781262;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpBusinessLayer.FeatureSection)this.Parent).DiffCount.Decrement(this.Name);
						num = (short)235077634;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						try
						{
							num = (short)720044039;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_721;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection2;
									((global::AcpBusinessLayer.FeatureSection)acpFeatureSection2).DiffCount.Increment(this.Name);
									num = (short)683278342;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection2;
									if (acpFeatureSection2 == this.NewParent)
									{
										num = (short)1303117825;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_726;
								case 4:
									num = (short)284622850;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									((global::AcpBusinessLayer.FeatureSection)this.Parent).FirePropertyChanged(this.Name + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("诓黕맗꧙飛럝蛟蓡韣", a_));
									num = (short)275841024;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection2;
									if (acpFeatureSection2 != this.Parent)
									{
										num = (short)1425408005;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_726;
								}
								case 7:
									switch (0)
									{
									case 0:
										goto IL_585;
									}
									continue;
								case 8:
									if (!enumerator.MoveNext())
									{
										num = (short)427032579;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_649;
								case 9:
									if (this.NewParent != null)
									{
										num = (short)1092091908;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 10:
									goto IL_73D;
								}
								IL_5C0:
								num = (short)2022401973;
								short num3 = num;
								num = (short)317614005;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
								{
									IL_649:
									global::AcpCommonLib.IAcpFeatureSection acpFeatureSection2 = enumerator.Current;
									num = (short)792330249;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								default:
									num = (short)340393984;
									if (num != 0)
									{
									}
									num = (short)679542792;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_585:
								goto IL_5C0;
								IL_726:
								num = (short)912261130;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_721:
							IL_73D:
							return;
						}
						finally
						{
							num = (short)1502478336;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_772;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)543555586;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_7A6;
								}
								IL_772:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2066284545;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_7A6:;
						}
						goto IL_7A9;
					case 10:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator = this.Parent.Parent.FeatureSectionsCollection.GetEnumerator();
						num = (short)2090663942;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_7A9;
					case 12:
						if (!value)
						{
							num = (short)1600258059;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 13:
						num = (short)1652228108;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						num = (short)663814159;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (this.Parent.Parent != null)
						{
							num = (short)1516830730;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 16:
						this.hasDiffs = true;
						num = (short)500301831;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_71:
					if (!this.hasDiffs && value)
					{
						num = (short)526188560;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)339804160;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_448:
					num = (short)1308033027;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7A9:
					this.hasDiffs = false;
					num = (short)528547840;
					short num4 = num;
					num = (short)187957256;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_4F0:
				return;
				IL_866:
				((global::AcpBusinessLayer.FeatureSection)this.Parent).DiffCount.Increment(this.Name);
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00012B04 File Offset: 0x00010D04
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x00012BBC File Offset: 0x00010DBC
		public bool KeyNameField
		{
			get
			{
				short num = (short)1046741013;
				short num2 = num;
				num = (short)943521813;
				switch (num2 == num)
				{
				}
				num = (short)1344602112;
				if (num != 0)
				{
				}
				num = (short)1194131456;
				short num3 = num;
				num = (short)672071681;
				if (num != 0)
				{
				}
				return this.FieldData.KeyNameField;
			}
			set
			{
				short num = (short)413794305;
				if (num != 0)
				{
				}
				num = (short)925711853;
				short num2 = num;
				num = (short)1070546413;
				switch (num2 == num)
				{
				}
				num = (short)1447559168;
				short num3 = num;
				num = (short)541917184;
				if (num != 0)
				{
				}
				this.FieldData.KeyNameField = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x00012C70 File Offset: 0x00010E70
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x00012D24 File Offset: 0x00010F24
		public global::AcpCommonLib.StateConstraint IsVisible
		{
			get
			{
				short num = (short)100588401;
				short num2 = num;
				num = (short)1231608689;
				switch (num2 == num)
				{
				}
				num = (short)386203649;
				if (num != 0)
				{
				}
				num = (short)1544749056;
				short num3 = num;
				num = (short)1675231232;
				if (num != 0)
				{
				}
				return this.FieldData.IsVisible;
			}
			set
			{
				short num = (short)301337882;
				short num2 = num;
				num = (short)1026755866;
				switch (num2 == num)
				{
				}
				num = (short)918683649;
				if (num != 0)
				{
				}
				num = (short)758120448;
				short num3 = num;
				num = (short)386924544;
				if (num != 0)
				{
				}
				((global::AcpBusinessLayer.FeatureNode)this.Parent.Parent).RegisterVisibility(this);
				this.FieldData.IsVisible = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x00012DEC File Offset: 0x00010FEC
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x00012EA0 File Offset: 0x000110A0
		public global::AcpCommonLib.StateConstraint IsEditable
		{
			get
			{
				short num = (short)445451165;
				short num2 = num;
				num = (short)1991445405;
				switch (num2 == num)
				{
				}
				num = (short)1830944768;
				if (num != 0)
				{
				}
				num = (short)109051904;
				short num3 = num;
				num = (short)1986723841;
				if (num != 0)
				{
				}
				return this.FieldData.IsEditable;
			}
			set
			{
				short num = (short)1363378326;
				short num2 = num;
				num = (short)6258838;
				switch (num2 == num)
				{
				}
				num = (short)1937702913;
				if (num != 0)
				{
				}
				num = (short)1518141440;
				short num3 = num;
				num = (short)1217724416;
				if (num != 0)
				{
				}
				((global::AcpBusinessLayer.FeatureNode)this.Parent.Parent).RegisterEditability(this);
				this.FieldData.IsEditable = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x00012F6C File Offset: 0x0001116C
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x00013024 File Offset: 0x00011224
		public global::AcpCommonLib.ValueSetterConstraint ValueSetter
		{
			get
			{
				short num = (short)1392915534;
				short num2 = num;
				num = (short)567489614;
				switch (num2 == num)
				{
				}
				num = (short)2027290624;
				if (num != 0)
				{
				}
				num = (short)1620049920;
				short num3 = num;
				num = (short)2110390273;
				if (num != 0)
				{
				}
				return this.FieldData.ValueSetter;
			}
			set
			{
				short num = (short)154009608;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int num3;
					global::System.Delegate[] invocationList;
					bool flag;
					switch (num2)
					{
					case 0:
						goto IL_14A;
					case 1:
						goto IL_21A;
					case 2:
						if (num3 >= invocationList.Length)
						{
							goto IL_97;
						}
						num = (short)1182531588;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_75;
					case 4:
						if (((global::AcpCommonLib.ValueSetterConstraint)invocationList[num3]).Method == value.Method)
						{
							num = (short)310312971;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3++;
						num = (short)830013449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (!flag)
						{
							num = (short)630784007;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21A;
					case 6:
						goto IL_14A;
					case 7:
					{
						global::AcpBusinessLayer.Impl.AcpFieldImplBase fieldData = this.FieldData;
						fieldData.ValueSetter = (global::AcpCommonLib.ValueSetterConstraint)global::System.Delegate.Combine(fieldData.ValueSetter, value);
						num = (short)1859321857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						switch (0)
						{
						case 0:
							goto IL_54;
						}
						continue;
					case 9:
						goto IL_7A;
					case 10:
						goto IL_7A;
					case 11:
						flag = true;
						num = (short)818348032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_54:
					if (this.FieldData.ValueSetter == null)
					{
						num = (short)2068905987;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					flag = false;
					invocationList = this.FieldData.ValueSetter.GetInvocationList();
					num3 = 0;
					num = (short)1999699978;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7A:
					num = (short)2143879170;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_97:
					num = (short)556138502;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_21A:
					num = (short)2106503665;
					short num4 = num;
					num = (short)955953649;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_97;
					default:
						goto IL_251;
					}
					IL_14A:
					num = (short)947453952;
					short num5 = num;
					num = (short)1625358341;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_75:
				this.FieldData.ValueSetter = value;
				return;
				IL_251:
				num = (short)344195073;
				if (num != 0)
				{
				}
				num = (short)1622867968;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000132C0 File Offset: 0x000114C0
		internal void SetSecurityValueSetter(global::AcpCommonLib.ValueSetterConstraint valueSetter)
		{
			short num = (short)1317882518;
			short num2 = num;
			num = (short)2124040854;
			switch (num2 == num)
			{
			}
			num = (short)401801217;
			if (num != 0)
			{
			}
			num = (short)1425211392;
			short num3 = num;
			num = (short)1006632960;
			if (num != 0)
			{
			}
			global::AcpBusinessLayer.Impl.AcpFieldImplBase fieldData = this.FieldData;
			fieldData.ValueSetter = (global::AcpCommonLib.ValueSetterConstraint)global::System.Delegate.Combine(fieldData.ValueSetter, valueSetter);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00013384 File Offset: 0x00011584
		internal virtual void ValidityHelper()
		{
			int a_ = 19;
			short num = (short)203030528;
			switch (num)
			{
			default:
			{
				num = (short)216727565;
				int num2 = (int)((global::System.IntPtr)num);
				bool flag2;
				for (;;)
				{
					global::AcpCommonLib.StateConstraint isValid;
					int num3;
					switch (num2)
					{
					case 0:
						goto IL_28C;
					case 1:
					{
						bool flag = true;
						num = (short)784990208;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)311296012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (isValid != null)
						{
							num = (short)1196752906;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_384;
					case 4:
						goto IL_1D5;
					case 5:
						num = (short)2000551937;
						if (num != 0)
						{
						}
						((global::AcpBusinessLayer.FeatureSection)this.Parent).CurrentField = this;
						num = (short)1023410187;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_347;
					case 7:
						goto IL_347;
					case 8:
						if (this.IsValid != null)
						{
							num = (short)997064709;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3FC;
					case 9:
						return;
					case 10:
						num = (short)597622788;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_187;
					case 12:
					{
						object obj;
						if (obj.ToString().Equals(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("ꛤ裦蟨飪駬鷮郰髲鯴菶뇸黺釼迾搀焂⬄匆笈戊樌栎琐愒䌔瘖甘爚礜倞传漢䨤䘦䴨䈪䌬䠮", a_)))
						{
							num = (short)2104098817;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28C;
					}
					case 13:
						switch (0)
						{
						case 0:
							goto IL_9D;
						}
						continue;
					case 14:
						goto IL_384;
					case 15:
					{
						object[] customAttributes;
						if (num3 >= customAttributes.Length)
						{
							num = (short)336003086;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						object obj = customAttributes[num3];
						num = (short)1382678546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						num = (short)516133039;
						short num4 = num;
						num = (short)1927581871;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1D5;
						default:
						{
							num = (short)824639488;
							if (num != 0)
							{
							}
							isValid = this.IsValid;
							bool flag = false;
							num = (short)1295777795;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 17:
					{
						object[] customAttributes = isValid.Method.GetCustomAttributes(true);
						num3 = 0;
						num = (short)1156644871;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
					{
						object obj;
						if (obj != null)
						{
							num = (short)1449525250;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28C;
					}
					case 19:
					{
						bool flag;
						if (!flag)
						{
							num = (short)873398272;
							short num5 = num;
							num = (short)1989148681;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AF;
					}
					}
					IL_9D:
					if (global::AcpBusinessLayer.AcpDocument.PageOnLoading)
					{
						num = (short)478085136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2AF;
					IL_1D5:
					if (isValid.Method != null)
					{
						num = (short)1581711377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_384;
					IL_28C:
					num3++;
					num = (short)65208326;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2AF:
					flag2 = global::AcpBusinessLayer.AcpConstraints.AcpValidilityRules(this);
					num = (short)194052104;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_347:
					num = (short)416874511;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_384:
					num = (short)567607315;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_187:
				this.Valid = (this.Applicable && flag2 && this.IsValid(this.Parent));
				return;
				IL_3FC:
				this.Valid = flag2;
				return;
			}
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000FB RID: 251
		internal abstract string ValueString { get; }

		// Token: 0x060000FC RID: 252
		internal abstract void ParseValueHelper(string value);

		// Token: 0x060000FD RID: 253 RVA: 0x00013794 File Offset: 0x00011994
		protected virtual void VisibilityHelper()
		{
			short num = (short)2047768470;
			short num2 = num;
			num = (short)1605007254;
			switch (num2 == num)
			{
			}
			num = (short)1401159681;
			if (num != 0)
			{
			}
			num = (short)221970432;
			short num3 = num;
			num = (short)1984364544;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0001383C File Offset: 0x00011A3C
		public void CalculateValidityWithDep()
		{
			short num = (short)1958674432;
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
					goto IL_24E;
				case 2:
					goto IL_2E1;
				case 3:
				{
					global::System.Collections.Generic.List<global::AcpBusinessLayer.AcpFieldBase>.Enumerator enumerator = this.dependentObjects.GetEnumerator();
					num = (short)1810038795;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					if (this.ForceValid)
					{
						num = (short)1651113989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2E1;
				case 5:
				{
					num = (short)1307049984;
					short num3 = num;
					this.ValidityHelper();
					num = (short)1584857090;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					num = (short)117964809;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_221;
				case 8:
					num = (short)861208577;
					if (num != 0)
					{
					}
					if (this.dependentObjects != null)
					{
						num = (short)1908801539;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9B;
				case 9:
					if (global::AcpBusinessLayer.AcpDocument.Closing)
					{
						num = (short)1701117962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.Calling = true;
					num = (short)1822162948;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_113;
				case 11:
					try
					{
						num = (short)1288486193;
						short num4 = num;
						num = (short)1008450865;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_1CC:
							num = (short)31719426;
							num2 = (int)((global::System.IntPtr)num);
							break;
						default:
							num = (short)1815937024;
							if (num != 0)
							{
							}
							num = (short)1891368963;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						for (;;)
						{
							switch (num2)
							{
							case 1:
								goto IL_1CC;
							case 2:
								goto IL_20E;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_197;
								}
								continue;
							case 4:
							{
								global::System.Collections.Generic.List<global::AcpBusinessLayer.AcpFieldBase>.Enumerator enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)1540030465;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpBusinessLayer.AcpFieldBase acpFieldBase = enumerator.Current;
								acpFieldBase.CalculateApplicability();
								acpFieldBase.CalculateValidity();
								num = (short)391577600;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_199:
							num = (short)157876228;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_197:
							goto IL_199;
						}
						IL_20E:
						goto IL_9B;
					}
					finally
					{
						global::System.Collections.Generic.List<global::AcpBusinessLayer.AcpFieldBase>.Enumerator enumerator;
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_221;
				case 12:
					if (this.EvaluateRecRefs)
					{
						num = (short)1789263879;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_347;
				}
				IL_58:
				if (!this.Calling)
				{
					num = (short)962658310;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_9B:
				num = (short)605749260;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_221:
				((global::AcpBusinessLayer.FeatureNode)this.Parent.Parent).InvokeRecRefValidities();
				num = (short)1471414273;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2E1:
				num = (short)1202520072;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_113:
			return;
			IL_24E:
			IL_347:
			this.Calling = false;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00013BA8 File Offset: 0x00011DA8
		public virtual void CalculateValidity()
		{
			short num = (short)788498716;
			short num2 = num;
			num = (short)230328604;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_B5:
				if (global::AcpBusinessLayer.AcpDocument.Closing)
				{
					num = (short)600899589;
					num3 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)891682816;
					num3 = (int)((global::System.IntPtr)num);
				}
				break;
			case 1:
				goto IL_5F;
			default:
			{
				num = (short)1385693184;
				short num4 = num;
				goto IL_5F;
			}
			}
			for (;;)
			{
				IL_93:
				switch (num3)
				{
				case 0:
					if (this.ForceValid)
					{
						num = (short)1145896961;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					num = (short)634519553;
					if (num != 0)
					{
					}
					num = (short)110886918;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_B5;
					}
					continue;
				case 3:
					return;
				case 4:
					this.ValidityHelper();
					num = (short)862978051;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					return;
				case 6:
					if (this.Applicable)
					{
						num = (short)1614807044;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				goto IL_B5;
			}
			return;
			IL_5F:
			num = (short)1293221888;
			if (num != 0)
			{
			}
			num = (short)857145346;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_93;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00013D48 File Offset: 0x00011F48
		public virtual void CalculateApplicability()
		{
			short num;
			for (;;)
			{
				num = (short)835780608;
				short num2 = num;
				num = (short)805240835;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						if (!global::AcpBusinessLayer.AcpDocument.Closing)
						{
							num = (short)1178599426;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						goto IL_EC;
					case 2:
						((global::AcpBusinessLayer.FeatureSection)this.Parent).CurrentField = this;
						this.Applicable = this.IsApplicable(this.Parent);
						num = (short)445710337;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_61;
						}
						continue;
					case 4:
						num = (short)885522433;
						if (num != 0)
						{
						}
						num = (short)1448214528;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_61:
					if (this.IsApplicable == null)
					{
						return;
					}
					num = (short)136183812;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_EC:
				num = (short)1498477736;
				short num4 = num;
				num = (short)1161688232;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_121;
				}
			}
			IL_121:
			num = (short)1064435712;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00013EC8 File Offset: 0x000120C8
		public void CalculateVisibility()
		{
			short num = (short)974651395;
			int num2 = (int)((global::System.IntPtr)num);
			bool flag;
			bool flag2;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.IsVisible != null)
					{
						num = (short)2113470466;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_230;
				case 1:
					goto IL_159;
				case 2:
					goto IL_12E;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_4C;
					}
					continue;
				case 4:
				{
					num = (short)1603207168;
					short num3 = num;
					num = (short)2131034113;
					if (num != 0)
					{
					}
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						goto IL_230;
					}
					num = (short)1682878790;
					short num4 = num;
					num = (short)813216070;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_12E;
					default:
						num = (short)435224576;
						if (num != 0)
						{
						}
						num = (short)584581128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					return;
				case 6:
					if (!flag)
					{
						num = (short)1951399943;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.HiddenDynamicByApp = false;
					num = (short)1354563585;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					this.HiddenDynamicByApp = true;
					num = (short)1991442441;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					((global::AcpBusinessLayer.FeatureSection)this.Parent).CurrentField = this;
					flag = this.IsVisible(this.Parent);
					num = (short)1226637318;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_8A;
				}
				IL_4C:
				if (global::AcpBusinessLayer.AcpDocument.Closing)
				{
					num = (short)1683816453;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				this.VisibilityHelper();
				flag2 = global::AcpBusinessLayer.AcpConstraints.AcpVisibilityRules(this);
				num = (short)1555234816;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_12E:
				num = (short)1982398468;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_8A:
			IL_130:
			this.Visible = (flag2 && flag);
			return;
			IL_159:
			goto IL_130;
			IL_230:
			this.Visible = flag2;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0001410C File Offset: 0x0001230C
		public void CalculateEditability()
		{
			bool flag;
			for (;;)
			{
				IL_00:
				short num = (short)545587201;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1107361792;
						short num3 = num;
						((global::AcpBusinessLayer.FeatureSection)this.Parent).CurrentField = this;
						num = (short)1715666946;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						num = (short)1589442061;
						short num4 = num;
						num = (short)994637325;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)745865216;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_92;
							}
							continue;
						}
						break;
					}
					case 2:
						num = (short)1227227137;
						if (num != 0)
						{
						}
						if (this.IsEditable == new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysEditable))
						{
							num = (short)1735983107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)894631943;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						this.Editable = this.IsEditable(this.Parent);
						num = (short)371785732;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						return;
					case 5:
						if (this.IsEditable != null)
						{
							num = (short)1201930240;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_209;
					case 6:
						return;
					case 7:
						goto IL_C4;
					}
					IL_92:
					if (global::AcpBusinessLayer.AcpDocument.Closing)
					{
						num = (short)1767899142;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						flag = global::AcpBusinessLayer.AcpConstraints.AcpEditabilityRules(this);
						num = (short)647036933;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
			return;
			IL_C4:
			this.Editable = (flag && this.IsEditable(this.Parent));
			return;
			IL_209:
			this.Editable = flag;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0001432C File Offset: 0x0001252C
		public void CallConstraints()
		{
			short num = (short)180224004;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				IL_1F:
				switch (num2)
				{
				case 0:
					goto IL_1BE;
				case 1:
					goto IL_8F;
				case 2:
					while (this.ValidateAcrossRecset)
					{
						num = (short)63560498;
						short num3 = num;
						num = (short)1296096050;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)225378304;
							if (num != 0)
							{
							}
							num = (short)1456078848;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1F;
						}
					}
					goto IL_224;
				case 3:
					if (global::AcpBusinessLayer.AcpDocument.PageOnLoading)
					{
						num = (short)1258553353;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)640876551;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				case 5:
					num = (short)799080451;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					this.CalculateVisibility();
					num = (short)22020097;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (this.IsVisible != null)
					{
						num = (short)189988870;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8F;
				case 8:
					this.CalculateEditability();
					num = (short)1220935690;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_108;
				case 10:
					goto IL_10A;
				case 11:
					if (this.IsEditable != null)
					{
						num = (short)339410952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10A;
				}
				IL_55:
				if (!global::AcpBusinessLayer.AcpDocument.Closing)
				{
					num = (short)1604190213;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_8F:
				num = (short)82706443;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_10A:
				this.CalculateApplicability();
				num = (short)318242816;
				short num4 = num;
				num = (short)1555628034;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_108:
			return;
			IL_1BE:
			this.CalculateValidityAcrossRecset();
			return;
			IL_224:
			num = (short)945684481;
			if (num != 0)
			{
			}
			this.CalculateValidity();
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0001458C File Offset: 0x0001278C
		internal void CallConstraintsX()
		{
			short num = (short)8981932;
			short num2 = num;
			num = (short)57937324;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_140:
				num = (short)1142947844;
				num3 = (int)((global::System.IntPtr)num);
				break;
			case 1:
				goto IL_5E;
			default:
			{
				num = (short)1245642752;
				short num4 = num;
				goto IL_5E;
			}
			}
			for (;;)
			{
				IL_91:
				switch (num3)
				{
				case 0:
					if (global::AcpBusinessLayer.AcpDocument.Closing)
					{
						num = (short)1535901697;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.Calling = true;
					this.Parent.Parent.CallConstraints();
					this.Calling = false;
					this.CalculateValidityWithDep();
					num = (short)1684602886;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_195;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_B3;
					}
					continue;
				case 3:
					return;
				case 4:
					this.CalculateValidityAcrossRecset();
					num = (short)125566979;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)2093285376;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_110;
				}
				IL_B3:
				if (this.Calling)
				{
					return;
				}
				num = (short)1487536133;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_110:
			num = (short)692125697;
			if (num != 0)
			{
			}
			if (this.ValidateAcrossRecset)
			{
				goto IL_140;
			}
			return;
			IL_195:
			return;
			IL_5E:
			num = (short)1570897920;
			if (num != 0)
			{
			}
			num = (short)1863057410;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_91;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00014750 File Offset: 0x00012950
		public string Path(string delimiter)
		{
			for (;;)
			{
				IL_00:
				short num = (short)819068928;
				short num2 = num;
				num = (short)266010625;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_BC;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_65;
						}
						continue;
					case 2:
					{
						num = (short)1837957121;
						if (num != 0)
						{
						}
						if (this.NewParent == null)
						{
							goto IL_89;
						}
						num = (short)1348534559;
						short num4 = num;
						num = (short)429523231;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)757923840;
							if (num != 0)
							{
							}
							num = (short)370671620;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						if (this.Parent != null)
						{
							num = (short)1415643136;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A5;
					case 4:
						goto IL_187;
					case 5:
						num = (short)915013634;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_65:
					if (!string.IsNullOrEmpty(this.NewUiExpanderAndName))
					{
						num = (short)1256718341;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_89:
					num = (short)1085014019;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
			IL_BC:
			return this.Parent.Path(delimiter) + delimiter + this.UIName;
			IL_187:
			return this.NewParent.Path(delimiter) + delimiter + this.NewUIName;
			IL_1A5:
			return this.UIName;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00014908 File Offset: 0x00012B08
		public void CalculateVisibility(bool allFields)
		{
			short num = (short)352201059;
			short num2 = num;
			num = (short)90319203;
			switch (num2 == num)
			{
			}
			num = (short)1363738624;
			if (num != 0)
			{
			}
			num = (short)398393344;
			short num3 = num;
			num = (short)1650458625;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000149BC File Offset: 0x00012BBC
		public void CalculateEditability(bool allFields)
		{
			short num = (short)1276042300;
			short num2 = num;
			num = (short)1187306556;
			switch (num2 == num)
			{
			}
			num = (short)744554497;
			if (num != 0)
			{
			}
			num = (short)1894580224;
			short num3 = num;
			num = (short)175570944;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00014A6C File Offset: 0x00012C6C
		// (set) Token: 0x06000109 RID: 265 RVA: 0x00014B20 File Offset: 0x00012D20
		public global::AcpCommonLib.DifferentiatedUserViewType DifferentiatedUserView
		{
			get
			{
				short num = (short)97923668;
				short num2 = num;
				num = (short)2096312916;
				switch (num2 == num)
				{
				}
				num = (short)119930881;
				if (num != 0)
				{
				}
				num = (short)492306432;
				short num3 = num;
				num = (short)672006144;
				if (num != 0)
				{
				}
				return this.FieldData.DifferentiatedUserView;
			}
			set
			{
				short num = (short)213806844;
				short num2 = num;
				num = (short)178089724;
				switch (num2 == num)
				{
				}
				num = (short)1348534273;
				if (num != 0)
				{
				}
				num = (short)1123418112;
				short num3 = num;
				num = (short)886767616;
				if (num != 0)
				{
				}
				this.FieldData.DifferentiatedUserView = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x0600010A RID: 266 RVA: 0x00014BD4 File Offset: 0x00012DD4
		// (set) Token: 0x0600010B RID: 267 RVA: 0x00014C8C File Offset: 0x00012E8C
		public int GuiVersion
		{
			get
			{
				short num = (short)1454497765;
				short num2 = num;
				num = (short)328720357;
				switch (num2 == num)
				{
				}
				num = (short)1505361921;
				if (num != 0)
				{
				}
				num = (short)1346174976;
				short num3 = num;
				num = (short)2096234496;
				if (num != 0)
				{
				}
				return this.FieldData.GuiVersion;
			}
			set
			{
				short num = (short)1162836671;
				short num2 = num;
				num = (short)1538620095;
				switch (num2 == num)
				{
				}
				num = (short)543817728;
				if (num != 0)
				{
				}
				num = (short)847642624;
				short num3 = num;
				num = (short)1069940737;
				if (num != 0)
				{
				}
				this.FieldData.GuiVersion = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00014D40 File Offset: 0x00012F40
		// (set) Token: 0x0600010D RID: 269 RVA: 0x00014DF8 File Offset: 0x00012FF8
		public int DataTransferOrder
		{
			get
			{
				short num = (short)746746526;
				short num2 = num;
				num = (short)2085843614;
				switch (num2 == num)
				{
				}
				num = (short)1962803200;
				if (num != 0)
				{
				}
				num = (short)813826048;
				short num3 = num;
				num = (short)882900993;
				if (num != 0)
				{
				}
				return this.FieldData.DataTransferOrder;
			}
			set
			{
				this.FieldData.DataTransferOrder = value;
				((global::AcpBusinessLayer.FeatureSection)this.Parent).RegisterForDataTransfer(this, value);
				short num;
				if (value > 0)
				{
					num = (short)1640883141;
					short num2 = num;
					num = (short)938337221;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)213843968;
						short num3 = num;
						num = (short)319946752;
						if (num != 0)
						{
						}
						this.BlockDataTransfer = false;
						return;
					}
					}
				}
				num = (short)1751187457;
				if (num != 0)
				{
				}
				this.BlockDataTransfer = true;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00014ED4 File Offset: 0x000130D4
		// (set) Token: 0x0600010F RID: 271 RVA: 0x00014F88 File Offset: 0x00013188
		public int FieldId
		{
			get
			{
				short num = (short)1148387329;
				if (num != 0)
				{
				}
				num = (short)1470235290;
				short num2 = num;
				num = (short)772539034;
				switch (num2 == num)
				{
				}
				num = (short)272367616;
				short num3 = num;
				num = (short)1284898816;
				if (num != 0)
				{
				}
				return this.FieldData.FieldId;
			}
			set
			{
				short num = (short)403930240;
				short num2 = num;
				num = (short)1573026944;
				switch (num2 == num)
				{
				}
				num = (short)1526136833;
				if (num != 0)
				{
				}
				num = (short)2096234496;
				short num3 = num;
				num = (short)1699348480;
				if (num != 0)
				{
				}
				this.FieldData.FieldId = value;
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00015040 File Offset: 0x00013240
		public void RepairRecRefs()
		{
			short num = (short)522302815;
			short num2 = num;
			num = (short)1698018655;
			switch (num2 == num)
			{
			}
			num = (short)1261699073;
			if (num != 0)
			{
			}
			num = (short)1609695232;
			short num3 = num;
			num = (short)1912864768;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000111 RID: 273 RVA: 0x000150E8 File Offset: 0x000132E8
		internal virtual void CallValueSetter(global::AcpCommonLib.UndoRedo.ContainerTask containerTask)
		{
			short num = (short)24194810;
			short num2 = num;
			num = (short)331886330;
			switch (num2 == num)
			{
			}
			num = (short)1256718336;
			if (num != 0)
			{
			}
			num = (short)1421410304;
			short num3 = num;
			num = (short)1656291329;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00015190 File Offset: 0x00013390
		public int CompareTo(object obj)
		{
			short num = (short)135245213;
			short num2 = num;
			num = (short)1287499165;
			switch (num2 == num)
			{
			}
			num = (short)1459486721;
			if (num != 0)
			{
			}
			num = (short)510853120;
			short num3 = num;
			num = (short)193134592;
			if (num != 0)
			{
			}
			global::AcpBusinessLayer.AcpFieldBase otherField = obj as global::AcpBusinessLayer.AcpFieldBase;
			return this.CompareToHelper(otherField);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00015244 File Offset: 0x00013444
		internal global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> GetAllDependents()
		{
			short num = (short)1838381374;
			short num2 = num;
			num = (short)876247358;
			switch (num2 == num)
			{
			}
			num = (short)1526988801;
			if (num != 0)
			{
			}
			num = (short)1307705344;
			short num3 = num;
			num = (short)50659328;
			if (num != 0)
			{
			}
			global::AcpBusinessLayer.AcpFieldBase.<GetAllDependents>d__187 <GetAllDependents>d__ = new global::AcpBusinessLayer.AcpFieldBase.<GetAllDependents>d__187(-2);
			<GetAllDependents>d__.<>4__this = this;
			return <GetAllDependents>d__;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x000152FC File Offset: 0x000134FC
		private void a()
		{
			short num = (short)1514668032;
			switch (num)
			{
			default:
			{
				num = (short)1649213440;
				short num2 = num;
				num = (short)528482305;
				if (num != 0)
				{
				}
				num = (short)645201921;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						num = (short)1008402435;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_B6;
						}
						continue;
					case 2:
						try
						{
							num = (short)350642961;
							short num4 = num;
							num = (short)165307153;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_321:
								num = (short)77004801;
								num3 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)1152712704;
								if (num != 0)
								{
								}
								num = (short)780009475;
								num3 = (int)((global::System.IntPtr)num);
								break;
							}
							for (;;)
							{
								switch (num3)
								{
								case 0:
									num = (short)1997275138;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)240254976;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.AcpFieldBase acpFieldBase = (global::AcpBusinessLayer.AcpFieldBase)enumerator.Current;
									global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField> list;
									list.Add(acpFieldBase);
									bool flag = this == acpFieldBase;
									num = (short)1669267460;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_36E;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_2F0;
									}
									continue;
								}
								break;
							}
							IL_2F0:
							goto IL_321;
							IL_36E:
							goto IL_F9;
						}
						finally
						{
							num = (short)438042626;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator;
								switch (num3)
								{
								case 0:
									enumerator.Dispose();
									num = (short)927596545;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_3DA;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_3A5;
									}
									continue;
								}
								IL_3A5:
								if (enumerator == null)
								{
									break;
								}
								num = (short)158793728;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_3DA:;
						}
						return;
						IL_F9:
						num = (short)1840185349;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField> list;
						if (list.Count > 2)
						{
							num = (short)236322820;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 4:
					{
						global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField> list;
						global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField>.Enumerator enumerator2 = list.GetEnumerator();
						num = (short)135135239;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						bool flag;
						if (flag)
						{
							num = (short)734658560;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 6:
						goto IL_D5;
					case 7:
						goto IL_F7;
					}
					IL_B6:
					if (this.dependentObjects == null)
					{
						num = (short)477036550;
						num3 = (int)((global::System.IntPtr)num);
					}
					else
					{
						global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField> list = new global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField>();
						bool flag = false;
						list.Add(this);
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator = this.GetAllDependents().GetEnumerator();
						num = (short)202375170;
						num3 = (int)((global::System.IntPtr)num);
					}
				}
				IL_D5:
				return;
				IL_F7:
				try
				{
					num = (short)361693187;
					num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 1:
							num = (short)2030764034;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_215;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_1A6;
							}
							continue;
						case 4:
						{
							global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField>.Enumerator enumerator2;
							if (!enumerator2.MoveNext())
							{
								num = (short)1161166849;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpField acpField = enumerator2.Current;
							num = (short)2015232000;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_1A8:
						num = (short)1292173316;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_1A6:
						goto IL_1A8;
					}
					IL_215:
					return;
				}
				finally
				{
					global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField>.Enumerator enumerator2;
					((global::System.IDisposable)enumerator2).Dispose();
				}
				return;
			}
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0001571C File Offset: 0x0001391C
		internal int GetFlags()
		{
			short num = (short)1215430656;
			short num2 = num;
			num = (short)1387746417;
			short num3 = num;
			num = (short)1005147249;
			switch (num3 == num)
			{
			}
			num = (short)1098711040;
			if (num != 0)
			{
			}
			num = (short)602734593;
			if (num != 0)
			{
			}
			return (int)this.flags;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x000157CC File Offset: 0x000139CC
		internal virtual global::AcpCommonLib.UndoRedo.UndoableTask CreateSetValueTask(string newValue)
		{
			short num = (short)1194524673;
			if (num != 0)
			{
			}
			num = (short)2118210878;
			short num2 = num;
			num = (short)1090344254;
			global::AcpBusinessLayer.UndoRedo.SetValueTask setValueTask;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)568459264;
				short num3 = num;
				num = (short)491782144;
				if (num != 0)
				{
				}
				setValueTask = new global::AcpBusinessLayer.UndoRedo.SetValueTask(this, newValue);
				if (this.ValueSetter == null)
				{
					return setValueTask;
				}
				break;
			}
			}
			global::AcpCommonLib.UndoRedo.ContainerTask containerTask = new global::AcpCommonLib.UndoRedo.ContainerTask(setValueTask.ToString());
			containerTask.AddTask(setValueTask);
			this.CallValueSetter(containerTask);
			return containerTask;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000158A4 File Offset: 0x00013AA4
		public bool AllowsCompare()
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (!this.HiddenStatic)
					{
						num2 = (short)1984364545;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 1:
					goto IL_61;
				case 2:
				{
					if (this is global::AcpCommonLib.IAcpPointerField)
					{
						return false;
					}
					num2 = (short)1270798506;
					short num3 = num2;
					num2 = (short)2007161002;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_61;
					default:
						num2 = (short)1745616896;
						if (num2 != 0)
						{
						}
						num2 = (short)937492485;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					num2 = (short)1115881473;
					if (num2 != 0)
					{
					}
					num2 = (short)1858273282;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (!this.IgnoreOnCompare)
					{
						num2 = (short)503709699;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 5:
					return true;
				}
				goto IL_28;
				IL_61:
				num2 = (short)787808256;
				short num4 = num2;
				num2 = (short)834076676;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_28:
			num2 = (short)1398472704;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00015A30 File Offset: 0x00013C30
		public bool AllowsDataTransfer()
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return true;
				case 1:
					if (this.Editable)
					{
						num2 = (short)1226899458;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 2:
				{
					num2 = (short)1669440586;
					short num3 = num2;
					num2 = (short)1550820426;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_143;
					case 1:
						break;
					default:
					{
						num2 = (short)1223229440;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)427294720;
					if (num2 != 0)
					{
					}
					num2 = (short)683081734;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					if (!(this is global::AcpCommonLib.IAcpPointerField))
					{
						num2 = (short)931594240;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 4:
					goto IL_143;
				case 5:
					if (!this.BlockDataTransfer)
					{
						num2 = (short)1875640327;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 6:
					if (!this.HiddenStatic)
					{
						num2 = (short)1793851396;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 7:
					num2 = (short)183500803;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_30;
				IL_143:
				num2 = (short)244449285;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_30:
			num2 = (short)462880769;
			if (num2 != 0)
			{
			}
			num2 = (short)1079574529;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00015BF8 File Offset: 0x00013DF8
		public bool AllowsCopy()
		{
			short num = (short)1021537068;
			short num2 = num;
			num = (short)2142726956;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1287192576;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_6C;
				}
				int num3;
				for (;;)
				{
					IL_56:
					switch (num3)
					{
					case 0:
						if (this.AllowsDataTransfer())
						{
							num = (short)722468865;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 1:
						num = (short)790167555;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_12D;
					case 3:
						if (!(this is global::AcpBusinessLayer.AcpKeyField))
						{
							num = (short)760741890;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					goto IL_6C;
				}
				IL_12D:
				break;
				IL_6C:
				num = (short)1805778944;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_56;
			}
			}
			num = (short)1893662720;
			short num4 = num;
			num = (short)690749441;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00015D38 File Offset: 0x00013F38
		public bool AllowsRestore()
		{
			short num = (short)549575448;
			short num2 = num;
			num = (short)1476188952;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_C8:
				num = (short)275251200;
				short num3 = num;
				num = (short)1971781635;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			default:
				num = (short)2052521984;
				if (num != 0)
				{
				}
				num = (short)88997888;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				bool flag;
				switch (num4)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_85;
					}
					continue;
				case 1:
					if (!flag)
					{
						num = (short)851050498;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 2:
					goto IL_C8;
				case 3:
					return true;
				case 4:
					num = (short)44105729;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_85:
				global::AcpBusinessLayer.AcpListField acpListField = this as global::AcpBusinessLayer.AcpListField;
				flag = false;
				if (acpListField != null && acpListField.SerializeItems)
				{
					flag = true;
				}
				if (!this.AllowsCopy())
				{
					return false;
				}
				num = (short)734068737;
				if (num != 0)
				{
				}
				num = (short)1288765444;
				num4 = (int)((global::System.IntPtr)num);
			}
			return true;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00015EB0 File Offset: 0x000140B0
		public bool AllowFillUpFillDown()
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num2 = (short)784007172;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_211;
				case 1:
					if (this.KeyNameField)
					{
						num2 = (short)1663762443;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_211;
				case 2:
					num2 = (short)1698496517;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_247;
				case 4:
				{
					num2 = (short)1872297984;
					short num3 = num2;
					num2 = (short)732364801;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					if (!(this is global::AcpCommonLib.IAcpPointerField))
					{
						num2 = (short)1283522566;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 6:
					num2 = (short)217186313;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (!(this is global::AcpBusinessLayer.AcpNumericKeyField))
					{
						num2 = (short)1152909313;
						if (num2 != 0)
						{
						}
						num2 = (short)840630274;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 8:
					return true;
				case 9:
					if (!(this is global::AcpBusinessLayer.AcpVoiceFileField))
					{
						num2 = (short)244252680;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 10:
					if (!(this is global::AcpBusinessLayer.AcpKeyField))
					{
						num2 = (short)129105923;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 11:
					return false;
				}
				goto IL_40;
				IL_211:
				num2 = (short)587399178;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_40:
			num2 = (short)235032229;
			short num4 = num2;
			num2 = (short)1042239141;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_247:
				num2 = (short)1981677575;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1509556224;
				if (num2 != 0)
				{
				}
				num2 = (short)1362165760;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0001610C File Offset: 0x0001430C
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)891027456;
			short num2 = num;
			num = (short)553844737;
			if (num != 0)
			{
			}
			num = (short)847886055;
			short num3 = num;
			num = (short)1088206567;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1095958528;
				if (num != 0)
				{
				}
				object obj = this.lockObject;
				bool flag = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_DF;
					}
					int num4;
					for (;;)
					{
						IL_B1:
						switch (num4)
						{
						case 0:
							goto IL_190;
						case 1:
							goto IL_1F8;
						case 2:
							if (this.isDisposeInProgress)
							{
								num = (short)871497731;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)2073493508;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							num = (short)545325056;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (!this.disposedValue)
							{
								num = (short)337117189;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1F8;
						case 5:
							num = (short)9699334;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							if (disposing)
							{
								num = (short)1755119624;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_155;
						case 7:
							goto IL_217;
						case 8:
							this.isDisposeInProgress = true;
							this.FlushUpdateTimer();
							this.UpdateTimer = null;
							num = (short)1454047241;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							goto IL_155;
						}
						goto IL_DF;
						IL_155:
						this.disposedValue = true;
						num = (short)1840054273;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_1F8:
						this.isDisposeInProgress = false;
						num = (short)1586954247;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_190:
					IL_217:
					break;
					IL_DF:
					global::System.Threading.Monitor.Enter(obj, ref flag);
					num = (short)1875181570;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_B1;
				}
				finally
				{
					num = (short)1190658048;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_249;
							}
							continue;
						case 1:
							goto IL_27D;
						case 2:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)1186594817;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_249:
						if (!flag)
						{
							break;
						}
						num = (short)859504642;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_27D:;
				}
				break;
			}
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000163B8 File Offset: 0x000145B8
		public void Dispose()
		{
			short num = (short)1226506240;
			short num2 = num;
			num = (short)829489153;
			if (num != 0)
			{
			}
			num = (short)218639784;
			short num3 = num;
			num = (short)1236217256;
			switch (num3 == num)
			{
			}
			num = (short)621477888;
			if (num != 0)
			{
			}
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x04000013 RID: 19
		internal global::System.Collections.Generic.List<global::AcpBusinessLayer.AcpFieldBase> dependentObjects;

		// Token: 0x04000014 RID: 20
		protected global::AcpBusinessLayer.AcpFieldBase.FieldFlags flags;

		// Token: 0x04000015 RID: 21
		private readonly object lockObject = new object();

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Threading.DispatcherTimer UpdateTimer = new global::System.Windows.Threading.DispatcherTimer(global::System.Windows.Threading.DispatcherPriority.ApplicationIdle);

		// Token: 0x04000018 RID: 24
		internal bool ValueChanged;

		// Token: 0x0400001A RID: 26
		private bool hasDiffs;

		// Token: 0x0400001B RID: 27
		private bool disposedValue;

		// Token: 0x0400001C RID: 28
		private bool isDisposeInProgress;

		// Token: 0x0200000C RID: 12
		[global::System.Flags]
		protected internal enum FieldFlags
		{
			// Token: 0x0400001E RID: 30
			None = 0,
			// Token: 0x0400001F RID: 31
			Attached = 1,
			// Token: 0x04000020 RID: 32
			Editable = 2,
			// Token: 0x04000021 RID: 33
			Visible = 4,
			// Token: 0x04000022 RID: 34
			Valid = 8,
			// Token: 0x04000023 RID: 35
			Applicable = 16,
			// Token: 0x04000024 RID: 36
			InConstraint = 32,
			// Token: 0x04000025 RID: 37
			SecurityEditable = 64,
			// Token: 0x04000026 RID: 38
			ShowLeadingZeros = 128,
			// Token: 0x04000027 RID: 39
			ForceValid = 256,
			// Token: 0x04000028 RID: 40
			ShowHexValue = 512,
			// Token: 0x04000029 RID: 41
			HiddenStatic = 1024,
			// Token: 0x0400002A RID: 42
			HiddenDynamic = 2048,
			// Token: 0x0400002B RID: 43
			CustomViewVisibility = 4096,
			// Token: 0x0400002C RID: 44
			BlockDataTransfer = 8192,
			// Token: 0x0400002D RID: 45
			HasSpecialRange = 16384,
			// Token: 0x0400002E RID: 46
			InvalidUIValue = 32768,
			// Token: 0x0400002F RID: 47
			DnDDone = 65536,
			// Token: 0x04000030 RID: 48
			AcrossRecset = 131072,
			// Token: 0x04000031 RID: 49
			EvaluateRecRefs = 262144,
			// Token: 0x04000032 RID: 50
			SlaveRecRef = 524288,
			// Token: 0x04000033 RID: 51
			InValueConstraint = 1048576,
			// Token: 0x04000034 RID: 52
			HiddenDynamicByApp = 2097152,
			// Token: 0x04000035 RID: 53
			UnsupportedValue = 4194304,
			// Token: 0x04000036 RID: 54
			DisableASKRangeValidation = 8388608,
			// Token: 0x04000037 RID: 55
			SkipValidation = 16777216,
			// Token: 0x04000038 RID: 56
			NotifyPropertyChanging = 33554432
		}
	}
}
