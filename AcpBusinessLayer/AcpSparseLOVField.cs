using System;
using System.Collections.Generic;
using System.Windows.Data;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;

namespace AcpBusinessLayer
{
	// Token: 0x02000022 RID: 34
	[global::System.Serializable]
	public class AcpSparseLOVField : global::AcpBusinessLayer.AcpListField
	{
		// Token: 0x060002D8 RID: 728 RVA: 0x00038278 File Offset: 0x00036478
		private AcpSparseLOVField()
		{
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0003828C File Offset: 0x0003648C
		public AcpSparseLOVField(global::System.Windows.Data.IValueConverter converter, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string[] items) : base(parent, name, uiLabel, items)
		{
			base.Converter = converter;
			this.UIValue = items[0];
		}

		// Token: 0x060002DA RID: 730 RVA: 0x000382B8 File Offset: 0x000364B8
		public AcpSparseLOVField(global::System.Windows.Data.IValueConverter converter, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string[] items, string[] legacyUILabels) : base(parent, name, uiLabel, items, legacyUILabels)
		{
			base.Converter = converter;
			this.UIValue = items[0];
		}

		// Token: 0x060002DB RID: 731 RVA: 0x000382E4 File Offset: 0x000364E4
		public AcpSparseLOVField(int value, global::System.Windows.Data.IValueConverter converter, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string[] items) : base(value, parent, name, uiLabel, items)
		{
			base.Converter = converter;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00038308 File Offset: 0x00036508
		public AcpSparseLOVField(int value, global::System.Windows.Data.IValueConverter converter, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string[] items, string[] legacyUILabels) : base(value, parent, name, uiLabel, items, legacyUILabels)
		{
			base.Converter = converter;
		}

		// Token: 0x060002DD RID: 733 RVA: 0x0003832C File Offset: 0x0003652C
		public AcpSparseLOVField(int value, global::System.Windows.Data.IValueConverter converter, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, bool sortItems, string[] items) : base(value, parent, name, uiLabel, sortItems, items)
		{
			base.Converter = converter;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00038350 File Offset: 0x00036550
		public AcpSparseLOVField(int value, global::System.Windows.Data.IValueConverter converter, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, bool sortItems, string[] items, string[] legacyUILabels) : base(value, parent, name, uiLabel, sortItems, items, legacyUILabels)
		{
			base.Converter = converter;
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0003836C File Offset: 0x0003656C
		public AcpSparseLOVField(global::System.Windows.Data.IValueConverter converter, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, bool serializeItems) : base(parent, name, uiLabel, serializeItems)
		{
			base.Converter = converter;
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0003838C File Offset: 0x0003658C
		public AcpSparseLOVField(int value, global::System.Windows.Data.IValueConverter converter, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, bool serializeItems) : base(value, parent, name, uiLabel, serializeItems)
		{
			base.Converter = converter;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x000383B0 File Offset: 0x000365B0
		public AcpSparseLOVField(global::System.Windows.Data.IValueConverter converter, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string[] items, bool serializeItems) : base(parent, name, uiLabel, items, serializeItems)
		{
			base.Converter = converter;
			this.UIValue = items[0];
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x000383DC File Offset: 0x000365DC
		public AcpSparseLOVField(global::System.Windows.Data.IValueConverter converter, global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string[] items, bool serializeItems, string[] legacyUILabels) : base(parent, name, uiLabel, items, serializeItems, legacyUILabels)
		{
			base.Converter = converter;
			this.UIValue = items[0];
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060002E3 RID: 739 RVA: 0x0003840C File Offset: 0x0003660C
		// (set) Token: 0x060002E4 RID: 740 RVA: 0x000384BC File Offset: 0x000366BC
		public override int Value
		{
			get
			{
				short num = (short)203620352;
				short num2 = num;
				num = (short)348653770;
				short num3 = num;
				num = (short)1199376586;
				switch (num3 == num)
				{
				}
				num = (short)1905459201;
				if (num != 0)
				{
				}
				num = (short)42729472;
				if (num != 0)
				{
				}
				return this.currentValue;
			}
			set
			{
				short num = (short)1688069744;
				short num2 = num;
				num = (short)1176954480;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1966931968;
					short num3 = num;
					num = (short)447152128;
					if (num != 0)
					{
					}
					if (!global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo)
					{
						this.SetValue(value);
						return;
					}
					break;
				}
				}
				num = (short)606339073;
				if (num != 0)
				{
				}
				global::AcpCommonLib.UndoRedo.UndoManager.AddTask(this.GetModifyDataTask(value));
			}
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x00038580 File Offset: 0x00036780
		public new global::AcpCommonLib.UndoRedo.UndoableTask GetModifyDataTask(int newValue)
		{
			short num = (short)714407936;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_98;
				}
				global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int> modifyDataTask;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator;
				string strB;
				for (;;)
				{
					IL_28:
					num = (short)1452212224;
					short num3 = num;
					num = (short)544800769;
					if (num != 0)
					{
					}
					global::AcpBusinessLayer.UndoRedo.SetRefRecsetTask setRefTask;
					switch (num2)
					{
					case 0:
						if (!base.UnsupportedValue)
						{
							num = (short)1863974915;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return modifyDataTask;
					case 1:
					{
						try
						{
							num = (short)1299120129;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1145110534;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.ListItem listItem = enumerator.Current;
									num = (short)1567031304;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_21F;
									}
									continue;
								case 2:
									goto IL_2FF;
								case 3:
									base.UnsupportedValue = true;
									num = (short)1571880962;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::AcpBusinessLayer.ListItem listItem;
									if (!listItem.ItemVisibility)
									{
										num = (short)1597374467;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									num = (short)1684865028;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									num = (short)130482183;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_31C;
								case 8:
								{
									global::AcpBusinessLayer.ListItem listItem;
									if (listItem.ItemName.CompareTo(strB) == 0)
									{
										num = (short)1209401349;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_25A:
								num = (short)1763508224;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_21F:
								goto IL_25A;
							}
							IL_2FF:
							IL_31C:
							goto IL_E9;
						}
						finally
						{
							num = (short)1550254080;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_354;
									}
									continue;
								case 1:
									goto IL_38A;
								case 2:
									enumerator.Dispose();
									num = (short)1829109761;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_354:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1283194882;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_38A:;
						}
						goto IL_38D;
						IL_E9:
						num = (short)876386934;
						short num4 = num;
						num = (short)194484854;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3D1;
						default:
							num = (short)924712960;
							if (num != 0)
							{
							}
							num = (short)233832448;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						if (base.ValueSetter != null)
						{
							num = (short)1437794308;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return modifyDataTask;
					case 3:
						num = (short)1726218245;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_3CC;
					case 5:
						setRefTask = ((this.buddyRecRefField != null) ? new global::AcpBusinessLayer.UndoRedo.SetRefRecsetTask(this.buddyRecRefField, this.buddyRecsets[(string)base.Converter.Convert(newValue, null, base.Parent, null)]) : null);
						goto IL_38D;
					}
					goto IL_98;
					IL_38D:
					modifyDataTask = new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(this, newValue, setRefTask);
					num = (short)864550914;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3CC:
				IL_3D1:
				global::AcpCommonLib.UndoRedo.ContainerTask containerTask = new global::AcpCommonLib.UndoRedo.ContainerTask(modifyDataTask.ToString());
				containerTask.AddTask(modifyDataTask);
				this.CallValueSetter(containerTask);
				return containerTask;
				IL_98:
				modifyDataTask = null;
				base.UnsupportedValue = false;
				strB = (string)base.Converter.Convert(newValue, null, base.Parent, null);
				enumerator = this.Items.GetEnumerator();
				num = (short)1160314881;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x0003899C File Offset: 0x00036B9C
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x00038A84 File Offset: 0x00036C84
		public override string UIValue
		{
			get
			{
				short num = (short)1928134657;
				if (num != 0)
				{
				}
				num = (short)1522663424;
				short num2 = num;
				num = (short)1006543273;
				short num3 = num;
				num = (short)1675338153;
				string result;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)210960384;
					if (num != 0)
					{
					}
					result = string.Empty;
					try
					{
						result = (string)base.Converter.Convert(this.Value, null, base.Parent, null);
					}
					catch (global::System.Exception)
					{
					}
					break;
				}
				return result;
			}
			set
			{
				short num = (short)1173159936;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1934098433;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_57;
						}
						continue;
					case 1:
					{
						num = (short)1213804;
						short num3 = num;
						num = (short)342066540;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)737607680;
							if (num != 0)
							{
							}
							try
							{
								this.Value = (int)base.Converter.ConvertBack(value, null, base.Parent, null);
								return;
							}
							catch (global::System.Exception)
							{
								return;
							}
							goto IL_C2;
						}
						break;
					}
					case 2:
						return;
					}
					IL_57:
					if (value == null)
					{
						num = (short)1920008192;
						short num4 = num;
						num = (short)1392377858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_C2:
					num = (short)1411776513;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00038BCC File Offset: 0x00036DCC
		public void SetBuddyRecRefField(global::AcpBusinessLayer.AcpRecRefField field, global::System.Collections.Generic.List<global::AcpBusinessLayer.Recordset> refRecsets, global::System.Collections.Generic.List<string> resourceStrings)
		{
			short num = (short)1659043841;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_62;
			}
			int num2;
			for (;;)
			{
				IL_30:
				int num3;
				switch (num2)
				{
				case 0:
					if (num3 >= this.Items.Count)
					{
						num = (short)240386056;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1294270467;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_2A3;
				case 2:
					goto IL_36D;
				case 3:
					if (resourceStrings.Contains(this.Items[num3].ItemName))
					{
						num = (short)1143209994;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.buddyRecsets[this.Items[num3].ItemName] = null;
					num = (short)1578434561;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (refRecsets.Count > 1)
					{
						num = (short)771883017;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3AF;
				case 5:
					goto IL_36D;
				case 6:
					try
					{
						num = (short)750452739;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_1E6;
							case 1:
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpRecRefSlaveItem> enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)1147994116;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								enumerator.Current.SlaveField.HasSiblingRecset = true;
								num = (short)1558052866;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								switch (0)
								{
								case 0:
									goto IL_16F;
								}
								continue;
							case 4:
								num = (short)1746272256;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_171:
							num = (short)1573322753;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_16F:
							goto IL_171;
						}
						IL_1E6:
						goto IL_3AF;
					}
					finally
					{
						num = (short)1271529473;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpRecRefSlaveItem> enumerator;
							switch (num2)
							{
							case 0:
								goto IL_2A0;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_21B;
								}
								continue;
							case 2:
							{
								enumerator.Dispose();
								num = (short)1498632133;
								short num4 = num;
								num = (short)1973047237;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_2A2;
								default:
									num = (short)1408368640;
									if (num != 0)
									{
									}
									num = (short)319225856;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							IL_21B:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1731002370;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_2A0:
						IL_2A2:;
					}
					goto IL_2A3;
				case 7:
					goto IL_2A3;
				case 8:
					goto IL_3AD;
				case 9:
				{
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpRecRefSlaveItem> enumerator = field.SlaveFields.GetEnumerator();
					num = (short)2621446;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 10:
				{
					num = (short)1698365440;
					short num5 = num;
					int index = resourceStrings.IndexOf(this.Items[num3].ItemName);
					this.buddyRecsets[this.Items[num3].ItemName] = refRecsets[index];
					num = (short)1138360327;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_62;
				IL_2A3:
				num3++;
				num = (short)70909954;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_36D:
				num = (short)1704001536;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3AF:
				num3 = 0;
				num = (short)884670469;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_3AD:
			this.buddyRecRefField.SetRecset(this.buddyRecsets[this.UIValue]);
			return;
			IL_62:
			this.buddyRecRefField = field;
			this.buddyRecsets = new global::System.Collections.Generic.Dictionary<string, global::AcpBusinessLayer.Recordset>();
			num = (short)1308884996;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_30;
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060002E9 RID: 745 RVA: 0x00038FD0 File Offset: 0x000371D0
		public global::System.Collections.Generic.IEnumerable<int> Values
		{
			get
			{
				short num = (short)1539702785;
				if (num != 0)
				{
				}
				num = (short)1320435516;
				short num2 = num;
				num = (short)335757116;
				switch (num2 == num)
				{
				}
				num = (short)1557331968;
				if (num != 0)
				{
				}
				num = (short)1181351936;
				short num3 = num;
				global::AcpBusinessLayer.AcpSparseLOVField.<get_Values>d__23 <get_Values>d__ = new global::AcpBusinessLayer.AcpSparseLOVField.<get_Values>d__23(-2);
				<get_Values>d__.<>4__this = this;
				return <get_Values>d__;
			}
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00039088 File Offset: 0x00037288
		public override void SetValue(int newValue)
		{
			switch (0)
			{
			case 0:
				goto IL_48;
			}
			int num;
			global::AcpBusinessLayer.FeatureNode featureNode;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (featureNode != null)
					{
						num2 = (short)1601437708;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_237;
				case 1:
				{
					global::AcpCommonLib.Document containerDoc;
					containerDoc.AddToModificationLog(base.BuildModificationLog(this.currentValue, newValue));
					num2 = (short)2085027844;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
				{
					global::AcpBusinessLayer.Recordset recordset;
					if (recordset != null)
					{
						num2 = (short)492109837;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_237;
				}
				case 3:
				{
					global::AcpCommonLib.Document containerDoc;
					if (containerDoc.ModificationLogEnabled)
					{
						num2 = (short)1323958273;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_237;
				}
				case 4:
					goto IL_237;
				case 5:
					goto IL_15C;
				case 6:
				{
					num2 = (short)347342229;
					short num3 = num2;
					num2 = (short)1844905365;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13F;
					default:
						num2 = (short)1766719488;
						if (num2 != 0)
						{
						}
						if (newValue != this.currentValue)
						{
							num2 = (short)813826057;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_237;
					}
					break;
				}
				case 7:
					goto IL_13F;
				case 8:
					num2 = (short)1118896131;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
				{
					num2 = (short)331612161;
					if (num2 != 0)
					{
					}
					global::AcpBusinessLayer.Recordset recordset = (global::AcpBusinessLayer.Recordset)featureNode.Parent;
					num2 = (short)2059206658;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 10:
					if (!global::AcpCommonLib.ConstraintManager.Suspended)
					{
						num2 = (short)126812167;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2BD;
				case 11:
				{
					global::AcpCommonLib.Document containerDoc;
					if (containerDoc != null)
					{
						num2 = (short)1845559304;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_237;
				}
				case 12:
				{
					num2 = (short)2110193664;
					short num4 = num2;
					num2 = (short)1079115782;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 13:
				{
					global::AcpBusinessLayer.Recordset recordset;
					global::AcpCommonLib.Document containerDoc = recordset.ContainerDoc;
					num2 = (short)89194507;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_48;
				IL_13F:
				base.CallConstraintsX();
				num2 = (short)83165189;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_237:
				this.currentValue = newValue;
				this.ValueChanged = true;
				num2 = (short)2135097354;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_15C:
			IL_2BD:
			this.FirePropertyChangedEvent();
			return;
			IL_48:
			featureNode = (global::AcpBusinessLayer.FeatureNode)base.Parent.Parent;
			num2 = (short)383909888;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00039358 File Offset: 0x00037558
		internal void ReplaceAt(int index, int value)
		{
			short num = (short)1487789570;
			short num2 = num;
			num = (short)909630978;
			switch (num2 == num)
			{
			}
			num = (short)627638272;
			if (num != 0)
			{
			}
			num = (short)703463425;
			if (num != 0)
			{
			}
			num = (short)1087504384;
			short num3 = num;
			base.RemoveItemAt(index);
			this.AddValue(value);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00039410 File Offset: 0x00037610
		public void AddValue(int value)
		{
			short num = (short)1151467521;
			if (num != 0)
			{
			}
			num = (short)1641260850;
			short num2 = num;
			num = (short)1796843314;
			switch (num2 == num)
			{
			}
			num = (short)489422848;
			if (num != 0)
			{
			}
			num = (short)1256849408;
			short num3 = num;
			base.AddItemHelper((string)base.Converter.Convert(value, null, base.Parent, null));
			this.currentValue = value;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x000394E8 File Offset: 0x000376E8
		public override void CalculateItemsValidity()
		{
			short num = (short)1562705923;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)636813313;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator;
				switch (num2)
				{
				case 0:
					goto IL_24C;
				case 1:
					num = (short)1100808194;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (base.Converter != null)
					{
						num = (short)1535377408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_60;
					}
					continue;
				case 4:
					try
					{
						num = (short)1273430019;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_18E;
							case 2:
								num = (short)9109504;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_EA;
								}
								continue;
							case 4:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)798818306;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpBusinessLayer.ListItem listItem = enumerator.Current;
								listItem.ItemValidity = base.IsIndexValid(base.Parent, (int)base.Converter.ConvertBack(listItem.ItemName, null, base.ConverterParameterObject, null));
								num = (short)298582017;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_13F:
							num = (short)758841348;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_EA:
							goto IL_13F;
						}
						IL_18E:
						return;
					}
					finally
					{
						num = (short)43974657;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_249;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_1C4;
								}
								continue;
							case 2:
							{
								enumerator.Dispose();
								num = (short)1165097286;
								short num3 = num;
								num = (short)15006022;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_24B;
								default:
									num = (short)226820096;
									if (num != 0)
									{
									}
									num = (short)367591424;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							IL_1C4:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1828257794;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_249:
						IL_24B:;
					}
					goto IL_24C;
				}
				IL_60:
				if (base.IsIndexValid != null)
				{
					num = (short)2103705600;
					short num4 = num;
					num = (short)79495169;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_24C:
				((global::AcpBusinessLayer.FeatureSection)base.Parent).CurrentField = this;
				enumerator = this.Items.GetEnumerator();
				num = (short)679215108;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060002EE RID: 750 RVA: 0x000397C4 File Offset: 0x000379C4
		public override global::AcpCommonLib.UndoRedo.UndoableTask CopyValueOf(global::AcpCommonLib.IAcpField source)
		{
			for (;;)
			{
				IL_00:
				short num = (short)825425924;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_14A;
					case 1:
					{
						num = (short)122988120;
						short num3 = num;
						num = (short)1142924888;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						case 1:
							break;
						default:
						{
							num = (short)1904869376;
							short num4 = num;
							break;
						}
						}
						num = (short)81526784;
						if (num != 0)
						{
						}
						string uivalue = (source as global::AcpBusinessLayer.AcpSparseLOVField).UIValue;
						num = (short)1668808707;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)296747013;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (this.UIValue != null)
						{
							num = (short)1940586498;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FA;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_3C;
						}
						continue;
					case 5:
					{
						string uivalue;
						if (!this.UIValue.Equals(uivalue))
						{
							num = (short)468516864;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_193;
					}
					}
					IL_3C:
					num = (short)1710489601;
					if (num != 0)
					{
					}
					if (this.buddyRecRefField == null)
					{
						goto IL_19B;
					}
					num = (short)1921712129;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_FA:
			return this.GetModifyDataTask(((global::AcpBusinessLayer.AcpSparseLOVField)source).Value);
			IL_14A:
			goto IL_FA;
			IL_193:
			return base.CopyValueOf(source);
			IL_19B:
			return base.CopyValueOf(source);
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00039974 File Offset: 0x00037B74
		public override void ResetToDefaultWithUndo()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			int value;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
					if (value.CompareTo(this.DefaultValue) != 0)
					{
						num2 = (short)1182793728;
						short num3 = num2;
						num2 = (short)366542850;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
				{
					num2 = (short)156762113;
					if (num2 != 0)
					{
					}
					global::AcpCommonLib.UndoRedo.UndoManager.AddTask(this.GetModifyDataTask(this.DefaultValue));
					num2 = (short)879079458;
					short num4 = num2;
					num2 = (short)1535225890;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1774256128;
						if (num2 != 0)
						{
						}
						num2 = (short)2112880640;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			value = this.Value;
			num2 = (short)1524105217;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00039AA8 File Offset: 0x00037CA8
		public override void ResetToDefaultWithUndo(global::AcpCommonLib.UndoRedo.ContainerTask taskContainer)
		{
			for (;;)
			{
				IL_00:
				short num = (short)1789198339;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1184366593;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						taskContainer.AddTask(this.GetModifyDataTask(this.DefaultValue));
						base.SetUITimer();
						num = (short)588840964;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)27681587;
						short num3 = num;
						num = (short)719348531;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num = (short)1870790656;
							if (num != 0)
							{
							}
							int value = this.Value;
							num = (short)1725038594;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
					{
						int value;
						if (value.CompareTo(this.DefaultValue) != 0)
						{
							num = (short)1214382080;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 3:
						switch (0)
						{
						case 0:
							goto IL_60;
						}
						continue;
					case 4:
						return;
					}
					IL_60:
					if (taskContainer == null)
					{
						return;
					}
					num = (short)896466944;
					short num4 = num;
					num = (short)1822752769;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x04000098 RID: 152
		private int currentValue;

		// Token: 0x04000099 RID: 153
		private global::System.Collections.Generic.Dictionary<string, global::AcpBusinessLayer.Recordset> buddyRecsets;

		// Token: 0x0400009A RID: 154
		private global::AcpBusinessLayer.AcpRecRefField buddyRecRefField;
	}
}
