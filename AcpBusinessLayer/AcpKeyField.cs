using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using AcpCommonResources;
using AcpUtility;

namespace AcpBusinessLayer
{
	// Token: 0x02000011 RID: 17
	[global::System.Serializable]
	public class AcpKeyField : global::AcpBusinessLayer.AcpStringField
	{
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000163 RID: 355 RVA: 0x0001A45C File Offset: 0x0001865C
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::AcpBusinessLayer.AcpRecRefField> ReferencingFields
		{
			get
			{
				if (this.referencingFields != null)
				{
					short num;
					for (;;)
					{
						num = (short)1558970368;
						short num2 = num;
						num = (short)2086120951;
						short num3 = num;
						num = (short)358723063;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_6B;
						}
					}
					IL_6B:
					num = (short)824180737;
					if (num != 0)
					{
					}
					num = (short)990511104;
					if (num != 0)
					{
					}
					return this.referencingFields.AsReadOnly();
				}
				return null;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000164 RID: 356 RVA: 0x0001A520 File Offset: 0x00018720
		public global::System.Collections.Generic.IEnumerable<global::AcpBusinessLayer.FeatureNode> ReferencingNodes
		{
			get
			{
				short num = (short)2112618497;
				if (num != 0)
				{
				}
				num = (short)1296507248;
				short num2 = num;
				num = (short)909123952;
				switch (num2 == num)
				{
				}
				num = (short)1512701952;
				short num3 = num;
				num = (short)39518208;
				if (num != 0)
				{
				}
				global::AcpBusinessLayer.AcpKeyField.<get_ReferencingNodes>d__6 <get_ReferencingNodes>d__ = new global::AcpBusinessLayer.AcpKeyField.<get_ReferencingNodes>d__6(-2);
				<get_ReferencingNodes>d__.<>4__this = this;
				return <get_ReferencingNodes>d__;
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0001A5D8 File Offset: 0x000187D8
		public AcpKeyField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel) : this(parent, name, uiLabel, int.MaxValue)
		{
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0001A5F4 File Offset: 0x000187F4
		public AcpKeyField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, string[] legacyUILabels) : this(parent, name, uiLabel, int.MaxValue, legacyUILabels)
		{
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0001A614 File Offset: 0x00018814
		public AcpKeyField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, int maxLength) : base(parent, name, uiLabel, maxLength)
		{
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0001A62C File Offset: 0x0001882C
		public AcpKeyField(global::AcpBusinessLayer.FeatureSection parent, string name, string uiLabel, int maxLength, string[] legacyUILabels) : base(parent, name, uiLabel, maxLength, legacyUILabels)
		{
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0001A648 File Offset: 0x00018848
		internal void AddRecordReference(global::AcpBusinessLayer.AcpRecRefField field)
		{
			short num = (short)1667039237;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1714618127;
					short num3 = num;
					num = (short)1042743055;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						num = (short)252968960;
						if (num != 0)
						{
						}
						goto IL_D5;
					}
					break;
				}
				case 1:
					this.referencingFields.Add(field);
					num = (short)470155266;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return;
				case 3:
					if (!this.referencingFields.Contains(field))
					{
						num = (short)945618945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
				{
					num = (short)1958215680;
					short num4 = num;
					this.referencingFields = new global::System.Collections.Generic.List<global::AcpBusinessLayer.AcpRecRefField>();
					num = (short)1060831232;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					goto IL_14;
				}
				goto IL_3C;
				IL_14:
				switch (0)
				{
				case 0:
					IL_3C:
					num = (short)1058013185;
					if (num != 0)
					{
					}
					if (this.referencingFields != null)
					{
						goto IL_D5;
					}
					num = (short)1296236548;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				continue;
				IL_D5:
				num = (short)330301443;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0001A7E0 File Offset: 0x000189E0
		internal void RemoveRecordReference(global::AcpBusinessLayer.AcpRecRefField field)
		{
			short num = (short)119275524;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (this.referencingFields.Contains(field))
					{
						num = (short)534708227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					num = (short)608960512;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return;
				case 3:
				{
					num = (short)1503021702;
					short num3 = num;
					num = (short)1761561222;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)912916480;
						if (num != 0)
						{
						}
						this.referencingFields.Remove(field);
						num = (short)914554882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				}
				IL_39:
				num = (short)1965621248;
				short num4 = num;
				num = (short)1254359041;
				if (num != 0)
				{
				}
				if (this.referencingFields == null)
				{
					break;
				}
				num = (short)249495553;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600016B RID: 363 RVA: 0x0001A950 File Offset: 0x00018B50
		internal string DisplayText
		{
			get
			{
				short num = (short)530648261;
				short num2 = num;
				num = (short)1720257733;
				switch (num2 == num)
				{
				}
				num = (short)1278279681;
				if (num != 0)
				{
				}
				num = (short)315490304;
				short num3 = num;
				num = (short)38666240;
				if (num != 0)
				{
				}
				return this.Value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600016C RID: 364 RVA: 0x0001AA04 File Offset: 0x00018C04
		public bool IsReferenced
		{
			get
			{
				if (this.referencingFields != null)
				{
					short num;
					for (;;)
					{
						num = (short)1918238720;
						short num2 = num;
						num = (short)293066648;
						short num3 = num;
						num = (short)1066129304;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_69;
						}
					}
					IL_69:
					num = (short)2088828928;
					if (num != 0)
					{
					}
					num = (short)2059206657;
					if (num != 0)
					{
					}
					return this.referencingFields.Count > 0;
				}
				return false;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600016D RID: 365 RVA: 0x0001AAC8 File Offset: 0x00018CC8
		// (set) Token: 0x0600016E RID: 366 RVA: 0x0001AB78 File Offset: 0x00018D78
		public override string Value
		{
			get
			{
				short num = (short)92964528;
				short num2 = num;
				num = (short)556631728;
				switch (num2 == num)
				{
				}
				num = (short)453771264;
				if (num != 0)
				{
				}
				num = (short)833421312;
				short num3 = num;
				num = (short)750649345;
				if (num != 0)
				{
				}
				return base.Value;
			}
			set
			{
				short num = (short)1343291392;
				switch (num)
				{
				default:
				{
					num = (short)225640470;
					int num2 = (int)((global::System.IntPtr)num);
					global::AcpCommonLib.UndoRedo.UndoableTask undoableTask;
					for (;;)
					{
						string referenceKey;
						bool flag;
						switch (num2)
						{
						case 0:
							if (this.Value != value)
							{
								num = (short)639041540;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 1:
							if (!global::AcpCommonLib.AppInfoManager.UnpackOperation)
							{
								num = (short)1124270081;
								if (num != 0)
								{
								}
								num = (short)459407373;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_49C;
						case 2:
						{
							num = (short)430868045;
							short num3 = num;
							num = (short)1788905037;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_475;
							default:
								num = (short)2015363072;
								if (num != 0)
								{
								}
								if (global::AcpCommonLib.UndoRedo.UndoManager.MarkForUndo)
								{
									num = (short)891682825;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1282080795;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							if (!global::AcpCommonLib.AppInfoManager.DndOperation)
							{
								num = (short)204079133;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_49C;
						case 4:
							num = (short)1568342034;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							global::AcpBusinessLayer.FeatureNode featureNode = base.Parent.Parent as global::AcpBusinessLayer.FeatureNode;
							referenceKey = featureNode.ReferenceKey;
							flag = base.PreKeyMapUpdate();
							base.Value = value;
							if (flag)
							{
								global::AcpBusinessLayer.Recordset recordset;
								recordset.ValidateReferenceKey(referenceKey);
							}
							string text = featureNode.ReferenceKey;
							num = (short)228655129;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
						{
							global::AcpBusinessLayer.Recordset recordset;
							if (recordset.CheckKeyFieldForDup(value))
							{
								num = (short)1936457754;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_49C;
						}
						case 7:
							goto IL_2D9;
						case 8:
							num = (short)292028419;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							undoableTask = new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<string>(this, value);
							num = (short)1865613340;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
						{
							string text = global::System.IO.Path.GetFileNameWithoutExtension(text);
							num = (short)908132373;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
							base.ForceValid = false;
							num = (short)554500115;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							if (!global::AcpCommonLib.AppInfoManager.ImportCopyOperation)
							{
								num = (short)1224802318;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_49C;
						case 13:
							num = (short)1212481542;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							num = (short)462356481;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							goto IL_5E5;
						case 16:
							goto IL_20E;
						case 17:
						{
							global::AcpBusinessLayer.Recordset recordset;
							if (recordset != null)
							{
								num = (short)649199624;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_49C;
						}
						case 18:
						{
							if (value.Length == 0)
							{
								num = (short)1968373775;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpBusinessLayer.Recordset recordset = base.Parent.ParentRecset as global::AcpBusinessLayer.Recordset;
							num = (short)227541009;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 19:
							goto IL_299;
						case 20:
							goto IL_5A5;
						case 21:
							goto IL_254;
						case 22:
							switch (0)
							{
							case 0:
								goto IL_BD;
							}
							continue;
						case 23:
							num = (short)1473576960;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 24:
						{
							global::AcpBusinessLayer.Recordset recordset;
							string text;
							if (recordset.KeysToNode.Contains(text))
							{
								num = (short)945815563;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_299;
						}
						case 25:
						{
							global::AcpBusinessLayer.Recordset recordset;
							if (recordset.RecsetId == 2300)
							{
								goto IL_475;
							}
							goto IL_254;
						}
						case 26:
							goto IL_441;
						case 27:
						{
							global::AcpBusinessLayer.Recordset recordset;
							if (recordset == null)
							{
								num = (short)641990656;
								short num4 = num;
								num = (short)1826357268;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)365232133;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 28:
							if (base.ValueSetter != null)
							{
								num = (short)992542736;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_12C;
						case 29:
							num = (short)1132199948;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_BD:
						if (value != null)
						{
							num = (short)645398551;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
						IL_254:
						num = (short)1402601496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_299:
						base.PostKeyMapUpdate(referenceKey, flag);
						base.ForceValid &= (value.Length <= base.MaxLength);
						num = (short)419758087;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_475:
						num = (short)629080074;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_49C:
						num = (short)287309826;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_12C:
					global::AcpCommonLib.UndoRedo.UndoManager.AddTask(undoableTask);
					return;
					IL_20E:
					global::AcpCommonLib.UndoRedo.ContainerTask containerTask = new global::AcpCommonLib.UndoRedo.ContainerTask(undoableTask.ToString());
					containerTask.AddTask(undoableTask);
					this.CallValueSetter(containerTask);
					global::AcpCommonLib.UndoRedo.UndoManager.AddTask(containerTask);
					return;
					IL_2D9:
					return;
					IL_441:
					string message = global::AcpCommonResources.AcpResources.Duplicate_Msg.AcpStringFormat(new object[]
					{
						base.UIName
					});
					global::AcpCommonLib.AppInfoManager.StatusMsgReport.PostMessage(global::AcpCommonLib.StatusMsgType.Error, message);
					base.SetUITimer();
					return;
					IL_5A5:
					base.Value = value;
					return;
					IL_5E5:
					base.SetUITimer();
					return;
				}
				}
			}
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0001B170 File Offset: 0x00019370
		internal void NodeDeleted()
		{
			short num = (short)1951596551;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				int num3;
				global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
				switch (num2)
				{
				case 0:
					if (num3 < 0)
					{
						num = (short)328400907;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					acpRecRefField = this.referencingFields[num3];
					num = (short)1643446282;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (acpRecRefField.Applicable)
					{
						num = (short)1243676677;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_78;
				case 2:
					num = (short)661323777;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_17D;
				case 4:
					goto IL_17D;
				case 5:
					goto IL_221;
				case 6:
				{
					num = (short)740023582;
					short num4 = num;
					num = (short)1340333342;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_221;
					default:
						num = (short)79495168;
						if (num != 0)
						{
						}
						num = (short)411828225;
						if (num != 0)
						{
						}
						goto IL_78;
					}
					break;
				}
				case 7:
					switch (0)
					{
					case 0:
						goto IL_54;
					}
					continue;
				case 8:
					goto IL_1BA;
				case 9:
					return;
				case 10:
					if (acpRecRefField.ReferencedNode != null)
					{
						num = (short)2132279298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1BA;
				case 11:
					return;
				}
				IL_54:
				if (this.referencingFields == null)
				{
					num = (short)362086409;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)696057856;
				short num5 = num;
				num3 = this.referencingFields.Count - 1;
				num = (short)1217593347;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_78:
				acpRecRefField.ReferencedNodeDeleted();
				num = (short)863961096;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_17D:
				num = (short)698089472;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1BA:
				this.referencingFields.Remove(acpRecRefField);
				num3--;
				num = (short)319029252;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_221:
				acpRecRefField.CalculateApplicability();
				num = (short)1397424134;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0001B3F0 File Offset: 0x000195F0
		internal override void DeepCopy(global::AcpCommonLib.IAcpField source)
		{
			short num = (short)273874944;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 1:
					return;
				case 2:
				{
					num = (short)1747849712;
					short num3 = num;
					num = (short)1810436592;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6E;
					default:
						num = (short)1339424769;
						if (num != 0)
						{
						}
						num = (short)1153499136;
						if (num != 0)
						{
						}
						base.DeepCopy(source);
						num = (short)421986305;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_30;
				IL_6E:
				num = (short)614137858;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_30:
				num = (short)882638848;
				short num4 = num;
				if (((global::AcpBusinessLayer.FeatureNode)base.ParentNode).bAddCurrentOnParent)
				{
					goto IL_6E;
				}
				break;
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0001B514 File Offset: 0x00019714
		protected override void Dispose(bool disposing)
		{
			short num = (short)1973288965;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_164;
				case 1:
					if (disposing)
					{
						num = (short)472383495;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_164;
				case 2:
					num = (short)1302331393;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_182;
				case 4:
					return;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 6:
					if (!this.disposedValue)
					{
						num = (short)851181570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C2;
				case 7:
				{
					num = (short)954847789;
					short num3 = num;
					num = (short)1877856813;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)1592590337;
						if (num != 0)
						{
						}
						num = (short)1902051328;
						if (num != 0)
						{
						}
						this.isDisposeInProgress = true;
						num = (short)1020657664;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_44:
				num = (short)862322688;
				short num4 = num;
				if (this.isDisposeInProgress)
				{
					num = (short)1322123268;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1878589446;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_164:
				this.disposedValue = true;
				num = (short)1181417475;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_182:
			IL_1C2:
			this.isDisposeInProgress = false;
			base.Dispose(disposing);
		}

		// Token: 0x04000042 RID: 66
		private global::System.Collections.Generic.List<global::AcpBusinessLayer.AcpRecRefField> referencingFields;

		// Token: 0x04000043 RID: 67
		private bool disposedValue;

		// Token: 0x04000044 RID: 68
		private bool isDisposeInProgress;
	}
}
