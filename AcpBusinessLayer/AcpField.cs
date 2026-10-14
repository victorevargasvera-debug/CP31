using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using AcpBusinessLayer.Impl;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using AcpCommonResources;
using AcpUtility;

namespace AcpBusinessLayer
{
	// Token: 0x0200000A RID: 10
	[global::System.Diagnostics.DebuggerDisplay("Name={UIName}, Value={Value}")]
	[global::System.Serializable]
	public class AcpField<TDBType> : global::AcpBusinessLayer.AcpFieldBase where TDBType : global::System.IComparable
	{
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000073 RID: 115 RVA: 0x0000A79C File Offset: 0x0000899C
		// (set) Token: 0x06000074 RID: 116 RVA: 0x0000A854 File Offset: 0x00008A54
		public virtual TDBType DefaultValue
		{
			get
			{
				short num = (short)2032858110;
				short num2 = num;
				num = (short)678687742;
				switch (num2 == num)
				{
				}
				num = (short)249167872;
				if (num != 0)
				{
				}
				num = (short)1406140416;
				short num3 = num;
				num = (short)324337665;
				if (num != 0)
				{
				}
				return ((global::AcpBusinessLayer.Impl.AcpFieldImpl<TDBType>)base.FieldData).DefaultValue;
			}
			set
			{
				short num = (short)559561382;
				short num2 = num;
				num = (short)604191398;
				switch (num2 == num)
				{
				}
				num = (short)1406533633;
				if (num != 0)
				{
				}
				num = (short)220200960;
				short num3 = num;
				num = (short)1067384832;
				if (num != 0)
				{
				}
				((global::AcpBusinessLayer.Impl.AcpFieldImpl<TDBType>)base.FieldData).DefaultValue = value;
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000A90C File Offset: 0x00008B0C
		protected AcpField()
		{
		}

		// Token: 0x06000076 RID: 118 RVA: 0x0000A920 File Offset: 0x00008B20
		public AcpField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel) : base(parent, name, uiLabel)
		{
			this.dataValue = default(TDBType);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000A944 File Offset: 0x00008B44
		public AcpField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string[] legacyUILabels) : base(parent, name, uiLabel, legacyUILabels)
		{
			this.dataValue = default(TDBType);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000A968 File Offset: 0x00008B68
		public AcpField(TDBType value, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel) : this(parent, name, uiLabel)
		{
			TDBType tdbtype = value;
			if (!base.DefaultSetByTiering)
			{
				goto IL_54;
			}
			IL_42:
			tdbtype = this.DefaultValue;
			IL_54:
			try
			{
				bool flag = global::AcpCommonLib.ConstraintManager.Suspend();
				this.Value = tdbtype;
				if (flag)
				{
					global::AcpCommonLib.ConstraintManager.Resume();
				}
				goto IL_16;
			}
			catch (global::System.NullReferenceException)
			{
				this.dataValue = tdbtype;
				goto IL_16;
			}
			goto IL_42;
			IL_16:
			if (!global::AcpCommonLib.AppInfoManager.DndOperation)
			{
				this.DefaultValue = tdbtype;
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x0000A9DC File Offset: 0x00008BDC
		public AcpField(TDBType value, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string[] legacyUILabels) : this(parent, name, uiLabel, legacyUILabels)
		{
			TDBType tdbtype = value;
			if (!base.DefaultSetByTiering)
			{
				goto IL_56;
			}
			IL_44:
			tdbtype = this.DefaultValue;
			IL_56:
			try
			{
				bool flag = global::AcpCommonLib.ConstraintManager.Suspend();
				this.Value = tdbtype;
				if (flag)
				{
					global::AcpCommonLib.ConstraintManager.Resume();
				}
				goto IL_18;
			}
			catch (global::System.NullReferenceException)
			{
				this.dataValue = tdbtype;
				goto IL_18;
			}
			goto IL_44;
			IL_18:
			if (!global::AcpCommonLib.AppInfoManager.DndOperation)
			{
				this.DefaultValue = tdbtype;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600007A RID: 122 RVA: 0x0000AA54 File Offset: 0x00008C54
		// (set) Token: 0x0600007B RID: 123 RVA: 0x0000AB04 File Offset: 0x00008D04
		public virtual TDBType Value
		{
			get
			{
				short num = (short)1067343213;
				short num2 = num;
				num = (short)92495213;
				switch (num2 == num)
				{
				}
				num = (short)1464270849;
				if (num != 0)
				{
				}
				num = (short)119799808;
				short num3 = num;
				num = (short)999030784;
				if (num != 0)
				{
				}
				return this.dataValue;
			}
			set
			{
				short num = (short)980287495;
				int num2 = (int)((global::System.IntPtr)num);
				global::AcpCommonLib.UndoRedo.UndoableTask undoableTask;
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						TDBType value2;
						if (!value2.Equals(value))
						{
							num = (short)1566507013;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 1:
					{
						TDBType value2 = this.Value;
						num = (short)741146624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_12F;
					case 3:
					{
						if (!global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo)
						{
							this.SetValue(value);
							num = (short)783810570;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1351195593;
						short num3 = num;
						num = (short)1368169417;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_117;
						default:
							num = (short)93519872;
							if (num != 0)
							{
							}
							num = (short)1156775940;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						undoableTask = new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<TDBType>(this, value);
						num = (short)1737949193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_1EE;
					case 6:
						if (this.Value != null)
						{
							num = (short)1304428545;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EE;
					case 7:
						switch (0)
						{
						case 0:
							goto IL_50;
						}
						continue;
					case 8:
						num = (short)252706822;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (base.ValueSetter != null)
						{
							goto IL_117;
						}
						goto IL_1E7;
					case 10:
						goto IL_1A1;
					}
					IL_50:
					num = (short)1044447233;
					if (num != 0)
					{
					}
					num = (short)1573584896;
					short num4 = num;
					if (!base.UIInvalid)
					{
						num = (short)985464840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1EE;
					IL_117:
					num = (short)1464598530;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1EE:
					num = (short)1435631619;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_12F:
				global::AcpCommonLib.UndoRedo.ContainerTask containerTask = new global::AcpCommonLib.UndoRedo.ContainerTask(undoableTask.ToString());
				containerTask.AddTask(undoableTask);
				this.CallValueSetter(containerTask);
				global::AcpCommonLib.UndoRedo.UndoManager.AddTask(containerTask);
				base.SetUITimer();
				return;
				IL_1A1:
				return;
				IL_1E7:
				global::AcpCommonLib.UndoRedo.UndoManager.AddTask(undoableTask);
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600007C RID: 124 RVA: 0x0000AD88 File Offset: 0x00008F88
		internal override string ValueString
		{
			get
			{
				if (this.Value != null)
				{
					short num = (short)370909919;
					short num2 = num;
					num = (short)1611834079;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)80478209;
						if (num != 0)
						{
						}
						num = (short)1679687680;
						if (num != 0)
						{
						}
						num = (short)967311360;
						short num3 = num;
						TDBType value = this.Value;
						return value.ToString();
					}
					}
				}
				return string.Empty;
			}
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000AE5C File Offset: 0x0000905C
		internal override void ParseValueHelper(string value)
		{
			short num = (short)671387476;
			short num2 = num;
			num = (short)1841401684;
			switch (num2 == num)
			{
			}
			num = (short)824246272;
			if (num != 0)
			{
			}
			num = (short)28573696;
			short num3 = num;
			num = (short)2034106369;
			if (num != 0)
			{
			}
			this.Value = this.a(value);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000AF14 File Offset: 0x00009114
		internal override void CallValueSetter(global::AcpCommonLib.UndoRedo.ContainerTask containerTask)
		{
			short num = (short)359727106;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_51;
				case 1:
					goto IL_127;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 3:
				{
					if (!base.CallingValueSetter)
					{
						goto IL_12C;
					}
					num = (short)2098069504;
					short num3 = num;
					num = (short)1190996960;
					short num4 = num;
					num = (short)1324952544;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_51;
					default:
						num = (short)290193408;
						if (num != 0)
						{
						}
						num = (short)1686568961;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_34:
				if (base.ValueSetter != null)
				{
					num = (short)1824456704;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_51:
				num = (short)1784283139;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_53:
			num = (short)947912705;
			if (num != 0)
			{
			}
			return;
			IL_127:
			goto IL_53;
			IL_12C:
			base.CallingValueSetter = true;
			base.ValueSetter(base.Parent, containerTask);
			base.CallingValueSetter = false;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000B070 File Offset: 0x00009270
		public virtual void SetValue(TDBType newValue)
		{
			short num = (short)1155727360;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_C3;
				}
				global::AcpCommonLib.Document document;
				for (;;)
				{
					IL_28:
					string oldKey;
					bool oldKeyPresent;
					switch (num2)
					{
					case 0:
						if (document != null)
						{
							num = (short)1328283674;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						num = (short)1247870977;
						if (num != 0)
						{
						}
						if (base.KeyNameField)
						{
							num = (short)1400832010;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						num = (short)37290015;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (((global::AcpBusinessLayer.FeatureSection)base.Parent).FeatureSectionName != null)
						{
							num = (short)1697185799;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_64D;
					case 4:
						num = (short)531562532;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1378877461;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (base.NotifyPropertyChanging)
						{
							num = (short)1851392015;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27A;
					case 7:
					{
						global::AcpBusinessLayer.FeatureNode featureNode;
						oldKey = featureNode.ReferenceKey;
						oldKeyPresent = this.PreKeyMapUpdate();
						num = (short)1753546763;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						base.CallConstraintsX();
						num = (short)1086783521;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)2131886108;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)1238368256;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_64D;
					case 12:
						if (document != null)
						{
							num = (short)1513816098;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_607;
					case 13:
						num = (short)1719336963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						this.PostKeyMapUpdate(oldKey, oldKeyPresent);
						num = (short)1990918162;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						this.FirePropertyChangingEvent();
						num = (short)1253572624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_27A;
					case 17:
					{
						global::AcpBusinessLayer.Recordset recordset;
						document = recordset.ContainerDoc;
						num = (short)1235812364;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						return;
					case 19:
					{
						global::AcpBusinessLayer.Recordset recordset;
						if (recordset != null)
						{
							num = (short)479985681;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_607;
					}
					case 20:
					{
						global::AcpBusinessLayer.FeatureNode featureNode;
						global::AcpBusinessLayer.Recordset recordset = (global::AcpBusinessLayer.Recordset)featureNode.Parent;
						num = (short)1523580947;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						if (((global::AcpBusinessLayer.FeatureSection)base.Parent).FeatureSectionName != null)
						{
							num = (short)523763726;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 22:
						if (document.ModificationLogEnabled)
						{
							num = (short)814153752;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_607;
					case 23:
						goto IL_607;
					case 24:
						goto IL_396;
					case 25:
						num = (short)381222939;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						num = (short)1138491421;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						if (newValue.CompareTo(this.dataValue) != 0)
						{
							num = (short)2055208980;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_607;
					case 28:
						if (newValue != null)
						{
							num = (short)568918041;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_607;
					case 29:
					{
						num = (short)2099118080;
						short num3 = num;
						if (document.IsOpen)
						{
							num = (short)1049362437;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 30:
						if (base.KeyNameField)
						{
							num = (short)502071300;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_64D;
					case 31:
						if (document.IsOpen)
						{
							num = (short)813957133;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_64D;
					case 32:
					{
						global::AcpBusinessLayer.FeatureNode featureNode;
						if (featureNode != null)
						{
							num = (short)112459785;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_607;
					}
					case 33:
						goto IL_56B;
					case 34:
						num = (short)123731990;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						if (!global::AcpCommonLib.ConstraintManager.Suspended)
						{
							num = (short)1919156232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_56B;
					case 36:
						if (document != null)
						{
							num = (short)676724738;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_64D;
					}
					goto IL_C3;
					IL_27A:
					this.dataValue = newValue;
					num = (short)801636387;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_56B:
					this.FirePropertyChangedEvent();
					this.ValueChanged = true;
					num = (short)476643329;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_607:
					oldKeyPresent = false;
					oldKey = string.Empty;
					num = (short)45809694;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_64D:
					num = (short)1010368518;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_396:
				document.AddToModificationLog(this.BuildModificationLog(this.dataValue, newValue));
				goto IL_4BA;
				IL_C3:
				num = (short)1390173248;
				short num4 = num;
				num = (short)1734630464;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_4BA:
					num = (short)723582999;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				default:
				{
					num = (short)462553088;
					if (num != 0)
					{
					}
					global::AcpBusinessLayer.FeatureNode featureNode = (global::AcpBusinessLayer.FeatureNode)base.Parent.Parent;
					document = null;
					num = (short)2048196640;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				}
				break;
			}
			}
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000B70C File Offset: 0x0000990C
		public static implicit operator TDBType(global::AcpBusinessLayer.AcpField<TDBType> obj)
		{
			short num = (short)1599413656;
			short num2 = num;
			num = (short)92216728;
			switch (num2 == num)
			{
			}
			num = (short)93257729;
			if (num != 0)
			{
			}
			num = (short)384696320;
			short num3 = num;
			num = (short)490078208;
			if (num != 0)
			{
			}
			return obj.dataValue;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000B7BC File Offset: 0x000099BC
		public override global::AcpCommonLib.UndoRedo.UndoableTask CopyValueOf(global::AcpCommonLib.IAcpField source)
		{
			short num = (short)916848640;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4F;
				}
				global::AcpBusinessLayer.UndoRedo.ModifyDataTask<TDBType> modifyDataTask;
				TDBType value2;
				for (;;)
				{
					IL_28:
					TDBType value;
					switch (num2)
					{
					case 0:
					{
						num = (short)404081526;
						short num3 = num;
						num = (short)1745603446;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_109;
						default:
							num = (short)1108934657;
							if (num != 0)
							{
							}
							num = (short)1587412992;
							if (num != 0)
							{
							}
							goto IL_C0;
						}
						break;
					}
					case 1:
						goto IL_104;
					case 2:
						if (this.Value != null)
						{
							num = (short)840237059;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C0;
					case 3:
						goto IL_109;
					case 4:
						if (!base.UIInvalid)
						{
							num = (short)1804926981;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C0;
					case 5:
						num = (short)832634882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (base.ValueSetter != null)
						{
							num = (short)1456734209;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return modifyDataTask;
					case 7:
						if (!value.Equals(value2))
						{
							num = (short)354025472;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return modifyDataTask;
					}
					goto IL_4F;
					IL_C0:
					modifyDataTask = new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<TDBType>(this, value2);
					num = (short)758579206;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_109:
					value = this.Value;
					num = (short)1763180551;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_104:
				global::AcpCommonLib.UndoRedo.ContainerTask containerTask = new global::AcpCommonLib.UndoRedo.ContainerTask(modifyDataTask.ToString());
				containerTask.AddTask(modifyDataTask);
				this.CallValueSetter(containerTask);
				return containerTask;
				IL_4F:
				value2 = ((global::AcpBusinessLayer.AcpField<TDBType>)source).Value;
				modifyDataTask = null;
				num = (short)377552896;
				short num4 = num;
				num = (short)2043543556;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000B9FC File Offset: 0x00009BFC
		public override global::AcpCommonLib.UndoRedo.UndoableTask CopyValue(object sourcevalue)
		{
			short num = (short)1766391808;
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
				TDBType tdbtype;
				global::AcpBusinessLayer.UndoRedo.ModifyDataTask<TDBType> modifyDataTask;
				for (;;)
				{
					IL_27:
					TDBType value;
					switch (num2)
					{
					case 0:
						num = (short)1257635846;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_FD;
					case 2:
						if (!value.Equals(tdbtype))
						{
							num = (short)791478276;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return modifyDataTask;
					case 3:
						if (!base.UIInvalid)
						{
							num = (short)466223104;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BA;
					case 4:
					{
						num = (short)1181829213;
						short num3 = num;
						num = (short)720652381;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_102;
						default:
							num = (short)243138560;
							if (num != 0)
							{
							}
							goto IL_BA;
						}
						break;
					}
					case 5:
						if (base.ValueSetter != null)
						{
							num = (short)377618433;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return modifyDataTask;
					case 6:
						if (this.Value != null)
						{
							num = (short)1828257799;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BA;
					case 7:
						goto IL_102;
					}
					goto IL_4E;
					IL_BA:
					modifyDataTask = new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<TDBType>(this, tdbtype);
					num = (short)1867972613;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_102:
					value = this.Value;
					num = (short)1697251329;
					if (num != 0)
					{
					}
					num = (short)325320706;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_FD:
				global::AcpCommonLib.UndoRedo.ContainerTask containerTask = new global::AcpCommonLib.UndoRedo.ContainerTask(modifyDataTask.ToString());
				containerTask.AddTask(modifyDataTask);
				this.CallValueSetter(containerTask);
				return containerTask;
				IL_4E:
				tdbtype = (TDBType)((object)sourcevalue);
				modifyDataTask = null;
				num = (short)157548544;
				short num4 = num;
				num = (short)703987715;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000BC34 File Offset: 0x00009E34
		internal override void DeepCopy(global::AcpCommonLib.IAcpField source)
		{
			short num = (short)257987741;
			short num2 = num;
			num = (short)1484559517;
			switch (num2 == num)
			{
			}
			num = (short)1310654464;
			short num3 = num;
			num = (short)1830223872;
			if (num != 0)
			{
			}
			num = (short)1850671105;
			if (num != 0)
			{
			}
			this.SetValue(((global::AcpBusinessLayer.AcpField<TDBType>)source).Value);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000BCF0 File Offset: 0x00009EF0
		public override void ResetToDefault()
		{
			short num = (short)28405437;
			short num2 = num;
			num = (short)174157501;
			switch (num2 == num)
			{
			}
			num = (short)1479147520;
			short num3 = num;
			num = (short)147062785;
			if (num != 0)
			{
			}
			num = (short)234881024;
			if (num != 0)
			{
			}
			this.Value = this.DefaultValue;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000BDA4 File Offset: 0x00009FA4
		public override void ResetToDefaultWithUndo()
		{
			short num = (short)1623588866;
			int num2 = (int)((global::System.IntPtr)num);
			global::AcpCommonLib.UndoRedo.UndoableTask undoableTask;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_18E;
				case 1:
					if (this.Value != null)
					{
						num = (short)336134144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_48;
					}
					continue;
				case 3:
					goto IL_149;
				case 4:
					num = (short)1607663617;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					return;
				case 6:
					if (base.ValueSetter != null)
					{
						num = (short)1509294083;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::AcpCommonLib.UndoRedo.UndoManager.AddTask(undoableTask);
					num = (short)1865613317;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					TDBType value;
					if (value.CompareTo(this.DefaultValue) != 0)
					{
						num = (short)1888223240;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 8:
				{
					num = (short)955056129;
					if (num != 0)
					{
					}
					undoableTask = new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<TDBType>(this, this.DefaultValue);
					num = (short)1314586624;
					short num3 = num;
					num = (short)1825177606;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_48:
				num = (short)438642570;
				short num4 = num;
				num = (short)1384654730;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_18E:
					TDBType value = this.Value;
					num = (short)1687617543;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				default:
					num = (short)470417408;
					if (num != 0)
					{
					}
					if (!global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo)
					{
						return;
					}
					num = (short)245301252;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_149:
			global::AcpCommonLib.UndoRedo.ContainerTask containerTask = new global::AcpCommonLib.UndoRedo.ContainerTask(undoableTask.ToString());
			containerTask.AddTask(undoableTask);
			this.CallValueSetter(containerTask);
			global::AcpCommonLib.UndoRedo.UndoManager.AddTask(containerTask);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000BFDC File Offset: 0x0000A1DC
		public override void ResetToDefaultWithUndo(global::AcpCommonLib.UndoRedo.ContainerTask taskContainer)
		{
			short num = (short)522911745;
			if (num != 0)
			{
			}
			num = (short)771686402;
			int num2 = (int)((global::System.IntPtr)num);
			global::AcpCommonLib.UndoRedo.UndoableTask undoableTask;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1B4;
				case 1:
					if (this.Value != null)
					{
						num = (short)141688832;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_71;
					}
					continue;
				case 3:
					goto IL_16F;
				case 4:
					num = (short)1810759681;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					return;
				case 6:
					if (base.ValueSetter != null)
					{
						num = (short)1022296067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					taskContainer.AddTask(undoableTask);
					num = (short)1632174085;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					TDBType value;
					if (value.CompareTo(this.DefaultValue) != 0)
					{
						num = (short)480772104;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 8:
				{
					num = (short)1759576064;
					short num3 = num;
					undoableTask = new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<TDBType>(this, this.DefaultValue);
					num = (short)12386310;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_71:
				num = (short)410241908;
				short num4 = num;
				num = (short)1107348340;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_1B4:
					TDBType value = this.Value;
					num = (short)306118663;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				default:
					num = (short)168165376;
					if (num != 0)
					{
					}
					if (taskContainer == null)
					{
						return;
					}
					num = (short)786759684;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_16F:
			global::AcpCommonLib.UndoRedo.ContainerTask containerTask = new global::AcpCommonLib.UndoRedo.ContainerTask(undoableTask.ToString());
			containerTask.AddTask(undoableTask);
			this.CallValueSetter(containerTask);
			taskContainer.AddTask(containerTask);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000C214 File Offset: 0x0000A414
		public override void ParseValueFrom(string value)
		{
			short num = (short)1105660815;
			short num2 = num;
			num = (short)1309281167;
			switch (num2 == num)
			{
			}
			num = (short)1772683264;
			short num3 = num;
			num = (short)1181876225;
			if (num != 0)
			{
			}
			num = (short)2003501056;
			if (num != 0)
			{
			}
			this.Value = this.a(value);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000C2C8 File Offset: 0x0000A4C8
		public override void ParseDefaultValueFrom(string value)
		{
			short num = (short)1705705473;
			if (num != 0)
			{
			}
			num = (short)1064901327;
			short num2 = num;
			num = (short)110631631;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1214185472;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)659030016;
			if (num != 0)
			{
			}
			this.DefaultValue = this.a(value);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000C380 File Offset: 0x0000A580
		private TDBType a(string A_0)
		{
			int a_ = 16;
			short num;
			for (;;)
			{
				num = (short)1084358656;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_3A;
						}
						continue;
					case 1:
						goto IL_92;
					case 2:
						goto IL_217;
					}
					IL_3A:
					num = (short)2021851136;
					short num3 = num;
					if (this.DataType == typeof(string))
					{
						num = (short)185335809;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1783037954;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_92:
				num = (short)1726587125;
				short num4 = num;
				num = (short)1151246581;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_C7;
				}
			}
			IL_C7:
			num = (short)307625984;
			if (num != 0)
			{
			}
			IL_1C8:
			return (TDBType)((object)A_0);
			IL_217:
			try
			{
				switch (0)
				{
				case 0:
					goto IL_102;
				}
				int num2;
				global::System.Reflection.MethodInfo method;
				TDBType result;
				for (;;)
				{
					IL_EC:
					switch (num2)
					{
					case 0:
						result = (TDBType)((object)method.Invoke(null, new object[]
						{
							A_0
						}));
						num = (short)1379729410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (method != null)
						{
							num = (short)2077622272;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1914175491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_199;
					case 3:
						goto IL_1B5;
					}
					goto IL_102;
				}
				IL_199:
				return result;
				IL_1B5:
				goto IL_1CF;
				IL_102:
				base.UnsupportedValue = false;
				method = this.DataType.GetMethod(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("닡藣铥鯧迩", a_), new global::System.Type[]
				{
					typeof(string)
				});
				num = (short)198115329;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_EC;
			}
			catch (global::System.Exception)
			{
				base.UnsupportedValue = true;
				return this.Value;
			}
			goto IL_1C8;
			IL_1CF:
			num = (short)578027521;
			if (num != 0)
			{
			}
			return default(TDBType);
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600008A RID: 138 RVA: 0x0000C5BC File Offset: 0x0000A7BC
		public override global::System.Type DataType
		{
			get
			{
				short num = (short)1031012353;
				if (num != 0)
				{
				}
				num = (short)1136169451;
				short num2 = num;
				num = (short)1546490347;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1436614656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1310916608;
				if (num != 0)
				{
				}
				return typeof(TDBType);
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000C670 File Offset: 0x0000A870
		public override string ToString()
		{
			while (this.Value == null)
			{
				short num = (short)213516288;
				short num2 = num;
				num = (short)1593347176;
				short num3 = num;
				num = (short)913083496;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1795751936;
					if (num != 0)
					{
					}
					num = (short)1729036289;
					if (num != 0)
					{
					}
					return string.Empty;
				}
			}
			TDBType value = this.Value;
			return value.ToString();
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000C744 File Offset: 0x0000A944
		internal override int CompareToHelper(global::AcpBusinessLayer.AcpFieldBase otherField)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			TDBType value;
			short num2;
			global::AcpBusinessLayer.AcpField<TDBType> acpField;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_ED;
				case 1:
					goto IL_EB;
				case 2:
					if (string.IsNullOrEmpty(value.ToString()))
					{
						num2 = (short)1179582468;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1F5;
				case 3:
				{
					num2 = (short)1568079872;
					short num3 = num2;
					if (this.Value != null)
					{
						num2 = (short)1019936768;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1B2;
				}
				case 4:
				{
					num2 = (short)931730321;
					short num4 = num2;
					num2 = (short)577049489;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_ED;
					default:
						num2 = (short)357040128;
						if (num2 != 0)
						{
						}
						num2 = (short)172556289;
						if (num2 != 0)
						{
						}
						goto IL_1B2;
					}
					break;
				}
				case 5:
					if (string.IsNullOrEmpty(value.ToString()))
					{
						num2 = (short)461897729;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return 1;
				case 6:
					if (acpField.Value != null)
					{
						num2 = (short)1048182791;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return 0;
				case 7:
					value = acpField.Value;
					num2 = (short)1581121541;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_30;
				IL_ED:
				value = this.Value;
				num2 = (short)1380188162;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1B2:
				num2 = (short)474021894;
				num = (int)((global::System.IntPtr)num2);
			}
			return 0;
			IL_EB:
			return 0;
			IL_1F5:
			value = this.Value;
			return value.CompareTo(acpField.Value);
			IL_30:
			acpField = (global::AcpBusinessLayer.AcpField<TDBType>)otherField;
			num2 = (short)645529603;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000C968 File Offset: 0x0000AB68
		protected string BuildModificationLog(TDBType oldValue, TDBType newValue)
		{
			int a_ = 2;
			short num = (short)1539705457;
			short num2 = num;
			num = (short)720570993;
			string text;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1425473536;
				short num3 = num;
				num = (short)824115200;
				if (num != 0)
				{
				}
				text = global::AcpCommonResources.AcpResources.Edited_Msg.AcpStringFormat(new object[]
				{
					global::System.DateTime.Now.ToString(),
					global::AcpBusinessLayer.UndoRedo.SetValueTask.b("", a_) + base.UIName + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("", a_),
					global::AcpBusinessLayer.UndoRedo.SetValueTask.b("", a_) + ((oldValue != null) ? oldValue.ToString() : global::AcpBusinessLayer.UndoRedo.SetValueTask.b("뫓ꏕ듗뛙", a_)) + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("", a_),
					global::AcpBusinessLayer.UndoRedo.SetValueTask.b("", a_) + ((newValue != null) ? newValue.ToString() : global::AcpBusinessLayer.UndoRedo.SetValueTask.b("뫓ꏕ듗뛙", a_)) + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("", a_)
				});
				try
				{
					num = (short)234749953;
					if (num != 0)
					{
					}
					text = string.Concat(new string[]
					{
						text,
						global::AcpBusinessLayer.UndoRedo.SetValueTask.b("", a_),
						global::AcpCommonResources.AcpResources.At_Id,
						global::AcpBusinessLayer.UndoRedo.SetValueTask.b("", a_),
						base.Parent.Path(global::AcpBusinessLayer.UndoRedo.SetValueTask.b("裓", a_)),
						global::AcpBusinessLayer.UndoRedo.SetValueTask.b("", a_)
					});
				}
				catch (global::System.NullReferenceException)
				{
				}
				break;
			}
			}
			return text;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000CB80 File Offset: 0x0000AD80
		internal override void CreateFieldData(string uiName)
		{
			short num = (short)112945778;
			short num2 = num;
			num = (short)1878878834;
			switch (num2 == num)
			{
			}
			num = (short)313065472;
			short num3 = num;
			num = (short)1504706561;
			if (num != 0)
			{
			}
			num = (short)880148480;
			if (num != 0)
			{
			}
			base.FieldData = new global::AcpBusinessLayer.Impl.AcpFieldImpl<TDBType>(uiName);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000CC34 File Offset: 0x0000AE34
		internal virtual void ResetToDefaultNoConstraints()
		{
			short num = (short)1049692764;
			short num2 = num;
			num = (short)2069695068;
			switch (num2 == num)
			{
			}
			num = (short)304742400;
			short num3 = num;
			num = (short)609943553;
			if (num != 0)
			{
			}
			num = (short)207290368;
			if (num != 0)
			{
			}
			this.dataValue = this.DefaultValue;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000CCE8 File Offset: 0x0000AEE8
		internal void SetValueNoConstraints(TDBType value)
		{
			short num = (short)1137029188;
			short num2 = num;
			num = (short)1475391556;
			switch (num2 == num)
			{
			}
			num = (short)1727987712;
			short num3 = num;
			num = (short)1897660416;
			if (num != 0)
			{
			}
			num = (short)506789889;
			if (num != 0)
			{
			}
			this.dataValue = value;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000CD9C File Offset: 0x0000AF9C
		protected bool PreKeyMapUpdate()
		{
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			short num;
			global::AcpBusinessLayer.Recordset recordset;
			global::AcpBusinessLayer.FeatureNode item;
			for (;;)
			{
				IL_0A:
				num = (short)1603665920;
				short num2 = num;
				int num3;
				switch (num3)
				{
				case 0:
					if (recordset.KeysToNode != null)
					{
						num = (short)395051011;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 1:
					if (recordset != null)
					{
						num = (short)1710489602;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 2:
					num = (short)370606081;
					if (num != 0)
					{
					}
					item = (global::AcpBusinessLayer.FeatureNode)base.Parent.Parent;
					num = (short)2093613056;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_14E;
				case 4:
					goto IL_167;
				}
				goto IL_4D;
			}
			IL_14E:
			goto IL_150;
			IL_167:
			bool flag = recordset.KeysToNode.Contains(item);
			if (flag)
			{
				recordset.KeysToNode.Remove(item);
			}
			return flag;
			IL_4D:
			recordset = (base.Parent.ParentRecset as global::AcpBusinessLayer.Recordset);
			num = (short)599633879;
			short num4 = num;
			num = (short)583249879;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_150:
				num = (short)1125122052;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			default:
			{
				num = (short)1324744704;
				if (num != 0)
				{
				}
				num = (short)2032140289;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000CF34 File Offset: 0x0000B134
		protected void PostKeyMapUpdate(string oldKey, bool oldKeyPresent)
		{
			int num;
			short num2;
			global::AcpBusinessLayer.Recordset recordset;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					global::AcpBusinessLayer.FeatureNode featureNode;
					string text;
					switch (num)
					{
					case 0:
						if (featureNode.ReferenceKey != null)
						{
							num2 = (short)1345323014;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_190;
					case 1:
						if (recordset != null)
						{
							num2 = (short)168493056;
							short num3 = num2;
							num2 = (short)1640431623;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 2:
						if (recordset.RecsetId == 2300)
						{
							num2 = (short)1652555785;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1DE;
					case 3:
						recordset.MoveNodeBasedOnKey(featureNode);
						num2 = (short)1239023624;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						if (!recordset.KeysToNode.Contains(text))
						{
							num2 = (short)1445068810;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_190;
					case 5:
						if (recordset.PositionBased)
						{
							num2 = (short)1097990147;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 6:
						goto IL_D2;
					case 7:
						featureNode = (global::AcpBusinessLayer.FeatureNode)base.Parent.Parent;
						num2 = (short)1547763712;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 8:
						return;
					case 9:
					{
						num2 = (short)129835068;
						short num4 = num2;
						num2 = (short)323166268;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_51;
						default:
							num2 = (short)861143040;
							if (num2 != 0)
							{
							}
							text = global::System.IO.Path.GetFileNameWithoutExtension(text);
							num2 = (short)1040056331;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 10:
						try
						{
							recordset.KeysToNode.Add(featureNode);
							goto IL_190;
						}
						catch (global::System.ArgumentException)
						{
							base.ForceValid = false;
							goto IL_190;
						}
						goto IL_D2;
					case 11:
						num2 = (short)453574657;
						if (num2 != 0)
						{
						}
						goto IL_1DE;
					}
					goto IL_40;
					IL_D2:
					text = featureNode.ReferenceKey;
					num2 = (short)1415839746;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_190:
					this.FirePropertyChangedEvent();
					recordset.RaiseReferenceKeyChanged(featureNode);
					num2 = (short)545128453;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_1DE:
					num2 = (short)2057502724;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
			}
			IL_40:
			recordset = (base.Parent.ParentRecset as global::AcpBusinessLayer.Recordset);
			IL_51:
			num2 = (short)1023737857;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000012 RID: 18
		private TDBType dataValue;
	}
}
