using System;
using System.Collections.Generic;
using System.Globalization;
using Infragistics.Windows.DataPresenter;
using Motorola.CommonCPS.UI.CellRangeFill.Constraints;
using Motorola.CommonCPS.UI.CellRangeFill.UndoRedo;
using Motorola.CommonCPS.UI.CellRangeSelect;

namespace Motorola.CommonCPS.UI.CellRangeFill
{
	// Token: 0x02000003 RID: 3
	public class CellRangeCopyFiller : global::Motorola.CommonCPS.UI.CellRangeFill.CellRangeFiller
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		public CellRangeCopyFiller() : this(null)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002130 File Offset: 0x00000330
		public CellRangeCopyFiller(string name) : base(name, global::Motorola.CommonCPS.UI.CellRangeFill.FillOperation.FillCopy)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002148 File Offset: 0x00000348
		protected override void DoFillCore(global::Infragistics.Windows.DataPresenter.DataRecordCollection records, global::Motorola.CommonCPS.UI.CellRangeSelect.CellRange range, global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.UI.CellRangeSelect.CellPosition> rangeIterator, object anchorValue, global::Motorola.CommonCPS.UI.CellRangeFill.ICellValueSetter setter, global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.ICellValueConstraint constraint, global::System.Type setCellValueTaskType)
		{
			int a_ = 19;
			short num = (short)78249984;
			short num2 = num;
			num = (short)1265765332;
			short num3 = num;
			num = (short)2127694804;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)874184704;
				if (num != 0)
				{
				}
				num = (short)838598657;
				if (num != 0)
				{
				}
				num = (short)1189937152;
				switch (num)
				{
				}
				break;
			}
			global::System.IFormatProvider currentCulture = global::System.Globalization.CultureInfo.CurrentCulture;
			string format = global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("駙돛껝駟싡鿣훥闧쫩飫臭탯釱釳髵铷\udaf9軻鿽滿攁愃★匇焉㴋猍㰏椑☓欕䔗㨙ㄛ㸝笟夡ᜣ嬥Ч儩ᠫ匭洯", a_);
			object[] array = new object[5];
			int num4 = 0;
			object obj;
			if (anchorValue == null)
			{
				obj = global::Motorola.CommonCPS.UI.CellRangeFill.Constraints.MultiCellValueConstraint.b("닛ꯝ賟軡\udae3", a_);
				goto IL_410;
			}
			IL_3F7:
			obj = anchorValue.ToString();
			IL_410:
			array[num4] = obj;
			array[1] = range.StartColumn;
			array[2] = range.StartRow;
			array[3] = range.EndColumn;
			array[4] = range.EndRow;
			global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.ContainerTask containerTask = new global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.ContainerTask(string.Format(currentCulture, format, array));
			try
			{
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.UI.CellRangeSelect.CellPosition> enumerator = rangeIterator.GetEnumerator();
				try
				{
					num = (short)1312489472;
					int num5 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.CommonCPS.UI.CellRangeSelect.CellPosition cellPosition;
						switch (num5)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_12B;
							}
							continue;
						case 1:
							if (!enumerator.MoveNext())
							{
								num = (short)241041410;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2D4;
						case 2:
							num = (short)669974532;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							try
							{
								switch (0)
								{
								case 0:
									goto IL_195;
								}
								global::Infragistics.Windows.DataPresenter.Cell cell;
								for (;;)
								{
									IL_176:
									switch (num5)
									{
									case 0:
										if (setter.IsEditable(cell))
										{
											num = (short)873725953;
											num5 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_2A4;
									case 1:
										num = (short)878379011;
										num5 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
									{
										global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.SetCellValueTask task = (global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.SetCellValueTask)global::System.Activator.CreateInstance(setCellValueTaskType, new object[]
										{
											records,
											cellPosition,
											setter,
											anchorValue,
											global::Motorola.CommonCPS.UI.CellRangeFill.FillOperation.FillCopy,
											range,
											base.AutoCorrect
										});
										containerTask.AddTask(task);
										global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.CommitManager.AddTask(task);
										num = (short)545587204;
										num5 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										if (!setter.AreValuesEqual(cell, anchorValue))
										{
											num = (short)2048196610;
											num5 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_2A4;
									case 4:
										goto IL_2A4;
									case 5:
										goto IL_2BC;
									}
									goto IL_195;
									IL_2A4:
									num = (short)968032261;
									num5 = (int)((global::System.IntPtr)num);
								}
								IL_2BC:
								break;
								IL_195:
								cell = records[cellPosition.Row].Cells[cellPosition.Column];
								num = (short)1247477760;
								num5 = (int)((global::System.IntPtr)num);
								goto IL_176;
							}
							catch (global::System.Exception)
							{
								if (base.ErrorAction == global::Motorola.CommonCPS.UI.CellRangeFill.FillErrorAction.Abort)
								{
									throw;
								}
								break;
							}
							goto IL_2D4;
						case 4:
							goto IL_313;
						}
						IL_130:
						num = (short)646905857;
						num5 = (int)((global::System.IntPtr)num);
						continue;
						IL_12B:
						goto IL_130;
						IL_2D4:
						cellPosition = enumerator.Current;
						num = (short)444399619;
						num5 = (int)((global::System.IntPtr)num);
					}
					IL_313:
					return;
				}
				finally
				{
					num = (short)377094144;
					int num5 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num5)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_34A;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)1761673218;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_380;
						}
						IL_34A:
						if (enumerator == null)
						{
							break;
						}
						num = (short)923009025;
						num5 = (int)((global::System.IntPtr)num);
					}
					IL_380:;
				}
			}
			finally
			{
				num = (short)115671040;
				int num5 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num5)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_3B7;
						}
						continue;
					case 1:
						global::Motorola.CommonCPS.UI.CellRangeFill.UndoRedo.UndoManager.AddTask(containerTask);
						num = (short)846528514;
						num5 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_3F4;
					}
					IL_3B7:
					if (containerTask.TaskCount <= 0)
					{
						break;
					}
					num = (short)682950657;
					num5 = (int)((global::System.IntPtr)num);
				}
				IL_3F4:;
			}
			goto IL_3F7;
		}
	}
}
