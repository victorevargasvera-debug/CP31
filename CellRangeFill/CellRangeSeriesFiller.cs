using System;
using System.Collections.Generic;
using System.Globalization;
using Infragistics.Windows.DataPresenter;
using Motorola.CommonCPS.UI.CellRangeFill.Constraints;
using Motorola.CommonCPS.UI.CellRangeFill.UndoRedo;
using Motorola.CommonCPS.UI.CellRangeSelect;

namespace Motorola.CommonCPS.UI.CellRangeFill
{
	// Token: 0x0200001A RID: 26
	public abstract class CellRangeSeriesFiller<TValue> : global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFiller
	{
		// Token: 0x0600008F RID: 143 RVA: 0x00009D58 File Offset: 0x00007F58
		public CellRangeSeriesFiller(string name, bool autoCorrect) : this(name, global::Motorola.CommonCPS.UI.CellRangeFill.FillErrorAction.Abort, autoCorrect, global::Motorola.CommonCPS.UI.CellRangeFill.FillRolloverAction.Stop, global::Motorola.CommonCPS.UI.CellRangeFill.FillReadonlyAction.Increment)
		{
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00009D70 File Offset: 0x00007F70
		public CellRangeSeriesFiller(string name, global::Motorola.CommonCPS.UI.CellRangeFill.FillErrorAction errorAction, bool autoCorrect, global::Motorola.CommonCPS.UI.CellRangeFill.FillRolloverAction rolloverAction, global::Motorola.CommonCPS.UI.CellRangeFill.FillReadonlyAction readonlyAction) : base(name, global::Motorola.CommonCPS.UI.CellRangeFill.FillOperation.FillSeries, errorAction, autoCorrect)
		{
			this.a = rolloverAction;
			this.b = readonlyAction;
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00009D98 File Offset: 0x00007F98
		public global::Motorola.CommonCPS.UI.CellRangeFill.FillRolloverAction RolloverAction
		{
			get
			{
				short num = (short)1291124737;
				if (num != 0)
				{
				}
				num = (short)1435205637;
				short num2 = num;
				num = (short)1649311749;
				switch (num2 == num)
				{
				default:
				{
					num = (short)46989312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)165085184;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000092 RID: 146 RVA: 0x00009E44 File Offset: 0x00008044
		public global::Motorola.CommonCPS.UI.CellRangeFill.FillReadonlyAction ReadonlyAction
		{
			get
			{
				short num = (short)1695091379;
				short num2 = num;
				num = (short)801114803;
				switch (num2 == num)
				{
				}
				num = (short)807206912;
				short num3 = num;
				num = (short)1065746433;
				if (num != 0)
				{
				}
				num = (short)1097793536;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x06000093 RID: 147
		protected abstract bool TryParseValue(string value, out TValue parsedValue);

		// Token: 0x06000094 RID: 148
		protected abstract TValue ParseValue(string value);

		// Token: 0x06000095 RID: 149
		protected abstract bool TryDoIncrement(TValue oldValue, out TValue newValue);

		// Token: 0x06000096 RID: 150
		protected abstract TValue DoIncrement(TValue value);

		// Token: 0x06000097 RID: 151
		protected abstract bool TryDoIncrement(TValue oldValue, int count, out TValue newValue);

		// Token: 0x06000098 RID: 152
		protected abstract TValue DoIncrement(TValue value, int count);

		// Token: 0x06000099 RID: 153 RVA: 0x00009EF4 File Offset: 0x000080F4
		protected override void DoFillCore(global::Infragistics.Windows.DataPresenter.DataRecordCollection records, global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange range, global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.UI.CellRangeSelect.CellPosition> rangeIterator, object anchorValue, global::Motorola.CommonCPS.UI.CellRangeFill.ICellValueSetter setter, global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint constraint, global::System.Type setCellValueTaskType)
		{
			int a_ = 16;
			short num = (short)868286464;
			switch (num)
			{
			default:
			{
				num = (short)1243807748;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						string text;
						TValue oldValue;
						if (!this.TryParseValue(text, out oldValue))
						{
							num = (short)1013841921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.ContainerTask containerTask = new global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.ContainerTask(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("釖냘럚뇜￞닠蛢韤軦賨飪췬鳮藰鋲蟴菶郸闺髼\udffe怀眂┄簆㤈瘊ⴌ笎縐㌒瘔爖甘眚㴜洞䀠䴢䈤䈦न瀪嘬Ḯ䰰ἲ临Զ䐸昺ᴼሾ慀ᡂ㹄瑆㑈杊㙌筎ⱐ๒", a_), new object[]
						{
							text,
							range.StartColumn,
							range.StartRow,
							range.EndColumn,
							range.EndRow
						}));
						num = (short)502202370;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_573;
					case 2:
						goto IL_5F3;
					case 3:
						goto IL_A3;
					case 4:
						num = (short)1213071361;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_87;
						}
						continue;
					}
					IL_87:
					if (anchorValue == null)
					{
						num = (short)883818499;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						string text = anchorValue.ToString();
						num = (short)1760559104;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_A3:
				num = (short)1221328896;
				short num3 = num;
				throw new global::System.InvalidOperationException();
				IL_524:
				throw new global::System.InvalidOperationException();
				IL_573:
				goto IL_524;
				IL_5F3:
				try
				{
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.UI.CellRangeSelect.CellPosition> enumerator = rangeIterator.GetEnumerator();
					try
					{
						num = (short)1049690119;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							TValue oldValue;
							TValue tvalue;
							global::Motorola.CommonCPS.UI.CellRangeSelect.CellPosition cellPosition;
							global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.SetCellValueTask setCellValueTask;
							switch (num2)
							{
							case 0:
								num = (short)2099707918;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
							{
								global::Infragistics.Windows.DataPresenter.Cell cell;
								if (!setter.AreValuesEqual(cell, tvalue))
								{
									num = (short)995426304;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_292;
							}
							case 2:
								goto IL_292;
							case 3:
							{
								global::Infragistics.Windows.DataPresenter.Cell cell;
								if (setter.IsEditable(cell))
								{
									num = (short)196673545;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_272;
							}
							case 4:
								if (this.TryDoIncrement(oldValue, out tvalue))
								{
									num = (short)1453588493;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 5:
							{
								global::Infragistics.Windows.DataPresenter.Cell cell;
								if (!setter.AreValuesEqual(cell, tvalue))
								{
									num = (short)823132171;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_272;
							}
							case 6:
								num = (short)281608200;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
								switch (0)
								{
								case 0:
									goto IL_144;
								}
								continue;
							case 8:
								goto IL_442;
							case 9:
								num = (short)1950613509;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 10:
								goto IL_272;
							case 11:
								goto IL_2FA;
							case 13:
							{
								global::Infragistics.Windows.DataPresenter.Cell cell = records[cellPosition.Row].Cells[cellPosition.Column];
								num = (short)2085552131;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 14:
							{
								if (!base.AutoCorrect)
								{
									goto IL_292;
								}
								num = (short)1923762635;
								short num4 = num;
								num = (short)1052527051;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_2FA;
								default:
									num = (short)1996750848;
									if (num != 0)
									{
									}
									num = (short)1045102607;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 15:
							{
								global::Infragistics.Windows.DataPresenter.Cell cell;
								tvalue = this.ParseValue(cell.Value.ToString());
								setCellValueTask.NewValue = tvalue;
								num = (short)1177550850;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 16:
								if (!enumerator.MoveNext())
								{
									num = (short)1245904902;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								cellPosition = enumerator.Current;
								num = (short)503316484;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_149:
							num = (short)820969488;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_144:
							goto IL_149;
							IL_272:
							oldValue = tvalue;
							num = (short)1563623436;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_292:
							global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.CommitManager.AddTask(setCellValueTask);
							num = (short)17891338;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_2FA:
							setCellValueTask = (global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.SetCellValueTask)global::System.Activator.CreateInstance(setCellValueTaskType, new object[]
							{
								records,
								cellPosition,
								setter,
								tvalue,
								global::Motorola.CommonCPS.UI.CellRangeFill.FillOperation.FillSeries,
								range,
								base.AutoCorrect
							});
							global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.ContainerTask containerTask;
							containerTask.AddTask(setCellValueTask);
							num = (short)457244673;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_442:
						return;
					}
					finally
					{
						num = (short)1739390978;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)1054015489;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_4B1;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_479;
								}
								continue;
							}
							IL_479:
							if (enumerator == null)
							{
								break;
							}
							num = (short)407437312;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_4B1:;
					}
				}
				finally
				{
					num = (short)361627650;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.ContainerTask containerTask;
						switch (num2)
						{
						case 0:
							global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoManager.AddTask(containerTask);
							num = (short)1644232705;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_521;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_4E6;
							}
							continue;
						}
						IL_4E6:
						if (containerTask.TaskCount <= 0)
						{
							break;
						}
						num = (short)839122944;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_521:;
				}
				goto IL_524;
			}
			}
		}

		// Token: 0x0400003D RID: 61
		private global::Motorola.CommonCPS.UI.CellRangeFill.FillRolloverAction a;

		// Token: 0x0400003E RID: 62
		private global::Motorola.CommonCPS.UI.CellRangeFill.FillReadonlyAction b;
	}
}
