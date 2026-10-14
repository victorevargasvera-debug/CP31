using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AcpCommonLib;
using AcpCommonLib.FieldsReport;
using AcpCommonLib.UndoRedo;

namespace AcpBusinessLayer.UndoRedo
{
	// Token: 0x0200004C RID: 76
	public class AddRecordContainerTask : global::AcpCommonLib.UndoRedo.ContainerTask
	{
		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x00067DAC File Offset: 0x00065FAC
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x00067E5C File Offset: 0x0006605C
		protected global::AcpBusinessLayer.FeatureNode[] Records
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)188022784;
				short num2 = num;
				num = (short)211100083;
				short num3 = num;
				num = (short)334242227;
				switch (num3 == num)
				{
				}
				num = (short)1102315521;
				if (num != 0)
				{
				}
				num = (short)1882259456;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1577254912;
				short num2 = num;
				num = (short)159449089;
				if (num != 0)
				{
				}
				num = (short)302177821;
				short num3 = num;
				num = (short)1852104221;
				switch (num3 == num)
				{
				}
				num = (short)1856176128;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00067F0C File Offset: 0x0006610C
		internal AddRecordContainerTask(string description) : base(description)
		{
			this.a = new global::System.Collections.Generic.List<global::AcpBusinessLayer.AcpRecRefField>();
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00067F2C File Offset: 0x0006612C
		internal void PopulateRecRefFieldTasks(global::AcpBusinessLayer.FeatureNode record)
		{
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.AcpRecRefField> enumerator = record.RecRefFields.GetEnumerator();
			short num;
			try
			{
				num = (short)49217536;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_4E;
						}
						continue;
					case 1:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1554317317;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpBusinessLayer.AcpRecRefField acpRecRefField = enumerator.Current;
						global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask task = new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(acpRecRefField, acpRecRefField.UIValue);
						base.AddTask(task);
						num = (short)427687942;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_116;
					case 3:
					{
						global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
						this.a.Add(acpRecRefField);
						num = (short)1296236548;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						num = (short)1547304962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
						if (!acpRecRefField.Valid)
						{
							num = (short)1547763715;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_A0:
					num = (short)1498152961;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4E:
					goto IL_A0;
				}
				IL_116:;
			}
			finally
			{
				num = (short)747675458;
				short num3 = num;
				num = (short)1973002050;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1185611776;
					if (num != 0)
					{
					}
					num = (short)1430716418;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_1CA;
						case 1:
							enumerator.Dispose();
							num = (short)91029504;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_196;
							}
							continue;
						}
						IL_196:
						if (enumerator == null)
						{
							break;
						}
						num = (short)239075329;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				}
				IL_1CA:;
			}
			num = (short)1360265217;
			if (num != 0)
			{
			}
			num = (short)175964160;
			short num4 = num;
			this.a(record);
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x0006817C File Offset: 0x0006637C
		private void a(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)1801388032;
			short num2 = num;
			num = (short)1568997376;
			switch (num)
			{
			default:
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator = A_0.FeatureSectionsCollectionByOrder.GetEnumerator();
					try
					{
						num = (short)1804992513;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 1:
								switch (0)
								{
								case 0:
									goto IL_9C;
								}
								continue;
							case 2:
								goto IL_36F;
							case 3:
								num = (short)788987906;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								try
								{
									num = (short)1549271040;
									num3 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num3)
										{
										case 0:
											switch (0)
											{
											case 0:
												goto IL_EC;
											}
											continue;
										case 2:
											goto IL_206;
										case 3:
										{
											global::AcpCommonLib.IAcpField acpField;
											global::AcpBusinessLayer.AcpRecRefField acpRecRefField = (global::AcpBusinessLayer.AcpRecRefField)acpField;
											base.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(acpRecRefField, acpRecRefField.UIValue));
											num = (short)1422000135;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 4:
										{
											global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator2;
											if (!enumerator2.MoveNext())
											{
												num = (short)1138032645;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::AcpCommonLib.IAcpField acpField = enumerator2.Current;
											num = (short)1522663432;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 5:
											num = (short)2110652418;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 6:
										{
											global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
											this.a.Add(acpRecRefField);
											num = (short)1505034241;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 7:
										{
											global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
											if (!acpRecRefField.Valid)
											{
												num = (short)527433734;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										case 8:
										{
											global::AcpCommonLib.IAcpField acpField;
											if (acpField is global::AcpBusinessLayer.AcpRecRefField)
											{
												num = (short)1446576131;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										}
										}
										IL_12C:
										num = (short)1291059204;
										num3 = (int)((global::System.IntPtr)num);
										continue;
										IL_EC:
										goto IL_12C;
									}
									IL_206:
									goto IL_318;
								}
								finally
								{
									num = (short)1459224578;
									num3 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator2;
										switch (num3)
										{
										case 0:
											goto IL_275;
										case 1:
											enumerator2.Dispose();
											num = (short)1103626240;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											switch (0)
											{
											case 0:
												goto IL_23E;
											}
											continue;
										}
										IL_23E:
										if (enumerator2 == null)
										{
											break;
										}
										num = (short)685441025;
										num3 = (int)((global::System.IntPtr)num);
									}
									IL_275:;
								}
								break;
								IL_318:
								num = (short)235864070;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
							{
								global::AcpBusinessLayer.FeatureSection featureSection;
								this.a(featureSection.EmbeddedRecset);
								num = (short)128253952;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
							{
								global::AcpBusinessLayer.FeatureSection featureSection;
								if (featureSection.HasEmbeddedRecset)
								{
									num = (short)886046725;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 7:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1444937731;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpBusinessLayer.FeatureSection featureSection = (global::AcpBusinessLayer.FeatureSection)enumerator.Current;
								global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator2 = featureSection.FieldsCollectionByOrder.GetEnumerator();
								num = (short)880607236;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_278:
							num = (short)133890055;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_9C:
							goto IL_278;
						}
						IL_36F:;
					}
					finally
					{
						num = (short)1941045250;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								goto IL_3D8;
							case 1:
								enumerator.Dispose();
								num = (short)1551433728;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_3A3;
								}
								continue;
							}
							IL_3A3:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1562116097;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_3D8:;
					}
					num = (short)612849182;
					short num4 = num;
					num = (short)1482774046;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_411;
					}
				}
				IL_411:
				num = (short)1471938561;
				if (num != 0)
				{
				}
				num = (short)949944320;
				if (num != 0)
				{
				}
				return;
			}
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0006860C File Offset: 0x0006680C
		private void a(global::AcpCommonLib.IAcpRecordset A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			int num5;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1593634261;
					short num3 = num2;
					num2 = (short)1421733333;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_58;
					default:
					{
						num2 = (short)1242759168;
						short num4 = num2;
						num2 = (short)309854208;
						if (num2 != 0)
						{
						}
						num2 = (short)1284243457;
						if (num2 != 0)
						{
						}
						goto IL_3A;
					}
					}
					break;
				}
				case 1:
				{
					if (num5 >= A_0.Count)
					{
						goto IL_58;
					}
					global::AcpCommonLib.IAcpFeatureNode a_ = A_0[num5];
					this.a(a_);
					num5++;
					num2 = (short)630980608;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					return;
				case 3:
					goto IL_3A;
				}
				goto IL_20;
				IL_3A:
				num2 = (short)1042743297;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_58:
				num2 = (short)1464401922;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_20:
			num5 = 0;
			num2 = (short)799932419;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00068754 File Offset: 0x00066954
		public override void Do()
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
			short num2;
			int num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_235;
				case 1:
					goto IL_111;
				case 2:
					goto IL_111;
				case 3:
					if (!acpRecRefField.Valid)
					{
						num2 = (short)231604231;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_9A;
				case 4:
					goto IL_190;
				case 5:
					goto IL_235;
				case 6:
					this.a.RemoveAt(num3);
					goto IL_7C;
				case 7:
					global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.RegisterFieldInReport(acpRecRefField, string.Empty, true);
					global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.FieldsReportChanged = true;
					num2 = (short)256573445;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
				{
					if (num3 >= 0)
					{
						acpRecRefField = this.a[num3];
						num2 = (short)984285194;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)797266085;
					short num4 = num2;
					num2 = (short)1739935909;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7C;
					default:
						num2 = (short)1824129024;
						if (num2 != 0)
						{
						}
						num2 = (short)1571749892;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 9:
					num2 = (short)1444478979;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (!global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.ContainsField(acpRecRefField))
					{
						num2 = (short)311427072;
						short num5 = num2;
						num2 = (short)463339529;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_9A;
				case 11:
					if (acpRecRefField.Valid)
					{
						num2 = (short)612761606;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_235;
				}
				goto IL_40;
				IL_7C:
				num2 = (short)1768816640;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_9A:
				num2 = (short)1624113163;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_111:
				num2 = (short)482017288;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_235:
				num3--;
				num2 = (short)1413349377;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_190:
			num2 = (short)1267597313;
			if (num2 != 0)
			{
			}
			return;
			IL_40:
			base.Do();
			acpRecRefField = null;
			num3 = this.a.Count - 1;
			num2 = (short)1506017282;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x000689EC File Offset: 0x00066BEC
		public override void Undo()
		{
			short num = (short)1044905984;
			switch (num)
			{
			default:
			{
				base.Undo();
				global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.FieldsReport.FieldsReportInfo> enumerator = global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.Fields.GetEnumerator();
				try
				{
					num = (short)1907163142;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						int num3;
						global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
						switch (num2)
						{
						case 0:
						{
							global::AcpCommonLib.FieldsReport.FieldsReportInfo fieldsReportInfo;
							if (fieldsReportInfo.Field is global::AcpBusinessLayer.AcpRecRefField)
							{
								num = (short)1040842771;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_42F;
						}
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)320274445;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.FieldsReport.FieldsReportInfo fieldsReportInfo = enumerator.Current;
							global::AcpBusinessLayer.FeatureNode[] records = this.Records;
							num3 = 0;
							num = (short)1388380162;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_232;
						case 3:
							num = (short)727318533;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							num = (short)84738055;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							global::AcpCommonLib.FieldsReport.FieldsReportInfo fieldsReportInfo;
							if (fieldsReportInfo.FieldType == global::AcpCommonLib.FieldInfoType.Field)
							{
								num = (short)691994644;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_42F;
						}
						case 6:
							switch (0)
							{
							case 0:
								goto IL_19C;
							}
							continue;
						case 7:
						{
							global::AcpBusinessLayer.FeatureNode featureNode;
							if (acpRecRefField.Parent.ParentRecset.ParentSection.Parent == featureNode)
							{
								num = (short)474218507;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_42F;
						}
						case 8:
						{
							global::AcpBusinessLayer.FeatureNode[] records;
							if (num3 >= records.Length)
							{
								num = (short)1904672782;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpBusinessLayer.FeatureNode featureNode = records[num3];
							num = (short)138346513;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							if (acpRecRefField.Parent.ParentRecset.IsEmbeddedRecset)
							{
								num = (short)48562180;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_42F;
						case 10:
							goto IL_491;
						case 11:
							goto IL_452;
						case 12:
							goto IL_42F;
						case 13:
							num = (short)141426698;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
						{
							global::AcpBusinessLayer.FeatureNode featureNode;
							if (acpRecRefField.Parent.Parent != featureNode)
							{
								num = (short)812580880;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_452;
						}
						case 16:
							num = (short)852361225;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
						{
							global::AcpCommonLib.FieldsReport.FieldsReportInfo fieldsReportInfo;
							if (fieldsReportInfo.Field != null)
							{
								num = (short)1486815235;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_42F;
						}
						case 18:
							goto IL_232;
						case 19:
						{
							num = (short)2106195969;
							if (num != 0)
							{
							}
							global::AcpCommonLib.FieldsReport.FieldsReportInfo fieldsReportInfo;
							acpRecRefField = (global::AcpBusinessLayer.AcpRecRefField)fieldsReportInfo.Field;
							num = (short)869007375;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 20:
							num = (short)103677952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_19C;
						IL_232:
						num = (short)77856776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_26D:
						num = (short)414187521;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_19C:
						goto IL_26D;
						IL_42F:
						num3++;
						num = (short)1280966674;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_452:
						this.a.Add(acpRecRefField);
						num = (short)1856831500;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_491:
					goto IL_110;
				}
				finally
				{
					num = (short)331939841;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_550;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_4CA;
							}
							continue;
						case 2:
						{
							num = (short)1939652519;
							short num4 = num;
							num = (short)1312145319;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1984495616;
								if (num != 0)
								{
								}
								enumerator.Dispose();
								num = (short)1957232640;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_4CA:
						if (enumerator == null)
						{
							break;
						}
						num = (short)672727042;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_550:;
				}
				goto IL_553;
				for (;;)
				{
					IL_110:
					using (global::System.Collections.Generic.List<global::AcpBusinessLayer.AcpRecRefField>.Enumerator enumerator2 = this.a.GetEnumerator())
					{
						num = (short)139853824;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_72;
								}
								continue;
							case 1:
								goto IL_FD;
							case 2:
								num = (short)181665793;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								if (!enumerator2.MoveNext())
								{
									num = (short)1861550082;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpBusinessLayer.AcpRecRefField field = enumerator2.Current;
								global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.UnregisterFieldInReport(field);
								global::AcpCommonLib.AppInfoManager.InvalidFieldsReport.FieldsReportChanged = true;
								num = (short)1903165443;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_74:
							num = (short)2046623748;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_72:
							goto IL_74;
						}
						IL_FD:
						break;
					}
				}
				IL_553:
				num = (short)1009844224;
				short num5 = num;
				return;
			}
			}
		}

		// Token: 0x0400014F RID: 335
		private global::System.Collections.Generic.List<global::AcpBusinessLayer.AcpRecRefField> a;

		// Token: 0x04000150 RID: 336
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::AcpBusinessLayer.FeatureNode[] b;
	}
}
