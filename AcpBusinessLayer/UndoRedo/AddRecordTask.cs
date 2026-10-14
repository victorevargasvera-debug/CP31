using System;
using System.Collections.Generic;
using AcpCommonLib;
using AcpCommonLib.FieldsReport;
using AcpCommonResources;
using AcpUtility;

namespace AcpBusinessLayer.UndoRedo
{
	// Token: 0x02000050 RID: 80
	public class AddRecordTask : global::AcpBusinessLayer.UndoRedo.RecordTaskBase
	{
		// Token: 0x060004ED RID: 1261 RVA: 0x000695D0 File Offset: 0x000677D0
		protected AddRecordTask()
		{
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x000695E4 File Offset: 0x000677E4
		public AddRecordTask(global::AcpBusinessLayer.FeatureNode rec)
		{
			int a_ = 8;
			base..ctor();
			this.record = rec;
			base.Description = global::AcpCommonResources.AcpResources.Add.AcpStringFormat(new object[]
			{
				global::AcpBusinessLayer.UndoRedo.SetValueTask.b("龎ﻛ", a_) + rec.FeatureName + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("", a_)
			});
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00069648 File Offset: 0x00067848
		internal AddRecordTask(global::AcpBusinessLayer.FeatureNode rec, bool isCurrentAdd)
		{
			int a_ = 6;
			base..ctor();
			this.record = rec;
			this.a = isCurrentAdd;
			base.Description = global::AcpBusinessLayer.UndoRedo.SetValueTask.b("駗뻙룛ﻝꏟ跡铣鿥죧ꗩ諫컭틯", a_) + rec.FeatureName + global::AcpBusinessLayer.UndoRedo.SetValueTask.b("𧻓", a_);
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x000696A0 File Offset: 0x000678A0
		public override void Do()
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
					num2 = (short)891027456;
					short num3 = num2;
					try
					{
						num2 = (short)79888390;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								num2 = (short)211484683;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 1:
								num2 = (short)691208195;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								num2 = (short)82706440;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 3:
								if (!this.a)
								{
									num2 = (short)5373962;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							case 4:
							{
								global::AcpCommonLib.IAcpCommon acpCommon;
								if (acpCommon is global::AcpCommonLib.IAcpFeatureNode)
								{
									num2 = (short)961085449;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 6:
								switch (0)
								{
								case 0:
									goto IL_F9;
								}
								continue;
							case 7:
							{
								global::AcpCommonLib.IAcpCommon acpCommon;
								if (!global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.ContainsUIField((global::AcpCommonLib.IAcpField)acpCommon))
								{
									num2 = (short)459079695;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 8:
								goto IL_309;
							case 9:
							{
								global::AcpCommonLib.IAcpCommon acpCommon;
								global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.RegisterFieldInReport((global::AcpCommonLib.IAcpFeatureNode)acpCommon, global::AcpCommonResources.AcpResources.Extra_Record);
								global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.FieldsReportChanged = true;
								num2 = (short)690225164;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 10:
								goto IL_1F7;
							case 11:
							{
								global::AcpCommonLib.IAcpCommon acpCommon;
								if (acpCommon is global::AcpBusinessLayer.AcpRecRefField)
								{
									num2 = (short)535035905;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_1F7;
							}
							case 13:
							{
								global::AcpCommonLib.IAcpCommon acpCommon;
								if (acpCommon is global::AcpCommonLib.IAcpField)
								{
									num2 = (short)1975189504;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								num2 = (short)913571844;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 14:
							{
								global::System.Collections.Generic.List<global::AcpCommonLib.IAcpCommon>.Enumerator enumerator;
								if (!enumerator.MoveNext())
								{
									num2 = (short)1000341506;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								global::AcpCommonLib.IAcpCommon acpCommon = enumerator.Current;
								num2 = (short)84148237;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 15:
							{
								global::AcpCommonLib.IAcpCommon acpCommon;
								global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.RegisterFieldInReport((global::AcpCommonLib.IAcpField)acpCommon, string.Empty, true);
								global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.FieldsReportChanged = true;
								num2 = (short)1854734341;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							}
							IL_1B7:
							num2 = (short)1351614478;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_F9:
							goto IL_1B7;
							IL_1F7:
							num2 = (short)2091515911;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_309:
						goto IL_3DE;
					}
					finally
					{
						global::System.Collections.Generic.List<global::AcpCommonLib.IAcpCommon>.Enumerator enumerator;
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_31C;
				}
				case 1:
					if (this.invalidFieds != null)
					{
						num2 = (short)447086594;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3DE;
				case 2:
					goto IL_31C;
				}
				goto IL_1C;
				for (;;)
				{
					IL_31C:
					global::System.Collections.Generic.List<global::AcpCommonLib.IAcpCommon>.Enumerator enumerator = this.invalidFieds.GetEnumerator();
					num2 = (short)1756356231;
					short num4 = num2;
					num2 = (short)1280695943;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_35C;
					}
				}
				IL_35C:
				num2 = (short)378863617;
				if (num2 != 0)
				{
				}
				num2 = (short)1378942976;
				if (num2 != 0)
				{
				}
				num2 = (short)521469952;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_3DE:
			base.Do();
			return;
			IL_1C:
			((global::AcpBusinessLayer.Recordset)this.record.Parent).AddRecord(this.record);
			this.record.Initialize();
			this.record.CallConstraints();
			this.record.Deleted = false;
			num2 = (short)80543745;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00069AB0 File Offset: 0x00067CB0
		public override void Undo()
		{
			short num = (short)1896611840;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3E;
				}
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.List<global::AcpCommonLib.IAcpCommon>.Enumerator enumerator;
					global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.FieldsReport.FieldsReportInfo> enumerator2;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1299775494;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpCommon acpCommon;
									global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.UnregisterFieldInReport((global::AcpCommonLib.IAcpField)acpCommon);
									global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.FieldsReportChanged = true;
									num = (short)861405187;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::AcpCommonLib.IAcpCommon acpCommon;
									if (acpCommon is global::AcpCommonLib.IAcpFeatureNode)
									{
										num = (short)1303314440;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									num = (short)802422789;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_28B;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_148;
									}
									continue;
								case 7:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)832045060;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpCommon acpCommon = enumerator.Current;
									num = (short)1258618889;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::AcpCommonLib.IAcpCommon acpCommon;
									global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.UnregisterFieldInReport((global::AcpCommonLib.IAcpFeatureNode)acpCommon);
									global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.FieldsReportChanged = true;
									num = (short)1941635074;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
								{
									global::AcpCommonLib.IAcpCommon acpCommon;
									if (acpCommon is global::AcpCommonLib.IAcpField)
									{
										num = (short)1330118656;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)469106689;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_14A:
								num = (short)21299207;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_148:
								goto IL_14A;
							}
							IL_28B:
							goto IL_882;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_29E;
					case 1:
						if (this.invalidFieds == null)
						{
							num = (short)1843134466;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_856;
					case 2:
						goto IL_29E;
					case 3:
						try
						{
							num = (short)922288128;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::AcpCommonLib.FieldsReport.FieldsReportInfo fieldsReportInfo;
								global::AcpCommonLib.IAcpField field;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_373;
									}
									continue;
								case 1:
									if (fieldsReportInfo.Node.Parent.IsEmbeddedRecset)
									{
										num = (short)262340632;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 2:
									if (field.Parent.ParentRecset.IsEmbeddedRecset)
									{
										num = (short)1492320268;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
									if (fieldsReportInfo.FieldType == global::AcpCommonLib.FieldInfoType.Field)
									{
										num = (short)1447690265;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_569;
								case 4:
									num = (short)1095368733;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									if (fieldsReportInfo.Node.Parent.ParentSection.Parent == this.record)
									{
										num = (short)1459421212;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 6:
									if (fieldsReportInfo.FieldType == global::AcpCommonLib.FieldInfoType.Record)
									{
										num = (short)238223364;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 7:
									goto IL_795;
								case 8:
									goto IL_61C;
								case 9:
									if (!this.a)
									{
										num = (short)969408520;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_569;
								case 10:
									if (!enumerator2.MoveNext())
									{
										num = (short)611188759;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									fieldsReportInfo = enumerator2.Current;
									num = (short)1704329235;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									num = (short)350814210;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									num = (short)466288660;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									if (fieldsReportInfo.Field is global::AcpBusinessLayer.AcpRecRefField)
									{
										num = (short)1390805008;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_61C;
								case 15:
									if (field.Parent.Parent != this.record)
									{
										num = (short)1805189131;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5AB;
								case 16:
									num = (short)188874761;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									num = (short)1090912257;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 19:
									if (fieldsReportInfo.Field != null)
									{
										num = (short)1630208027;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_569;
								case 20:
									if (field.Parent.ParentRecset.ParentSection.Parent == this.record)
									{
										num = (short)1787953178;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 21:
									num = (short)991821830;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 22:
									if (fieldsReportInfo.Node != null)
									{
										num = (short)149815317;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 23:
									num = (short)1221459975;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 24:
									num = (short)1468530693;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 25:
									num = (short)82771982;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 26:
									goto IL_5AB;
								case 27:
									num = (short)1947533315;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 28:
									goto IL_4E5;
								case 29:
									if (fieldsReportInfo.Node != this.record)
									{
										num = (short)1352597522;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4E5;
								}
								goto IL_373;
								IL_4E5:
								this.invalidFieds.Add(fieldsReportInfo.Node);
								num = (short)1410400273;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_569:
								num = (short)617480214;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5AB:
								this.invalidFieds.Add(field);
								num = (short)187498509;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_61C:
								field = fieldsReportInfo.Field;
								num = (short)1165885455;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6AF:
								num = (short)629800970;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_373:
								goto IL_6AF;
							}
							IL_795:;
						}
						finally
						{
							num = (short)1313538049;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_853;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_7CC;
									}
									continue;
								case 2:
								{
									num = (short)589068460;
									short num3 = num;
									num = (short)7764140;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)747438080;
										if (num != 0)
										{
										}
										enumerator2.Dispose();
										num = (short)731971584;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_7CC:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)1475674114;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_853:;
						}
						goto IL_856;
					}
					goto IL_3E;
					IL_29E:
					this.invalidFieds = new global::System.Collections.Generic.List<global::AcpCommonLib.IAcpCommon>();
					enumerator2 = global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.Fields.GetEnumerator();
					num = (short)528351235;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_856:
					enumerator = this.invalidFieds.GetEnumerator();
					num = (short)1421213696;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_882:
				this.record.Deleted = true;
				base.Undo();
				return;
				IL_3E:
				num = (short)168558592;
				short num4 = num;
				global::AcpBusinessLayer.Recordset recordset = this.record.Parent as global::AcpBusinessLayer.Recordset;
				int index = recordset.IndexOf(this.record);
				recordset.RemoveRecordInternal(index, new bool?(false));
				num = (short)1442381825;
				if (num != 0)
				{
				}
				num = (short)1748369409;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x04000153 RID: 339
		public global::System.Collections.Generic.List<global::AcpCommonLib.IAcpCommon> invalidFieds;

		// Token: 0x04000154 RID: 340
		private bool a;
	}
}
