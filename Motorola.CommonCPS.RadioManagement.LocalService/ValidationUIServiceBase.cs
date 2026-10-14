using System;
using System.Collections.Generic;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000049 RID: 73
	public abstract class ValidationUIServiceBase : global::Motorola.CommonCPS.RadioManagement.LocalService.IValidationUIServiceBase
	{
		// Token: 0x060002B8 RID: 696 RVA: 0x00048EC8 File Offset: 0x000470C8
		protected ValidationUIServiceBase(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServiceContainer serviceContainer)
		{
			this._serviceContainer = serviceContainer;
		}

		// Token: 0x060002B9 RID: 697
		public abstract bool ValidateWhenEditRadioColumn(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase oldDevice, object newValue, string editedFieldName, out global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.DeviceFieldType, object>> fieldValues, out global::Motorola.CommonCPS.Server.EntityModel.Radio ValidateRadio, out string error);

		// Token: 0x060002BA RID: 698
		public abstract bool ValidateRadioAlias(string alias, out string error);

		// Token: 0x060002BB RID: 699
		public abstract bool ValidateAllRadioFields(global::Motorola.CommonCPS.Server.EntityModel.Radio radioBase, global::System.Collections.Generic.Dictionary<string, string> errorList);

		// Token: 0x060002BC RID: 700
		public abstract bool ValidateRadioWithMVOForImportCSV(global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest CSVRequest, global::Motorola.CommonCPS.Server.EntityModel.Radio radioBase, global::System.Collections.Generic.Dictionary<string, string> tempErrorList);

		// Token: 0x060002BD RID: 701
		public abstract bool ValidateSerialNumber(string serialNumber, out string error);

		// Token: 0x060002BE RID: 702
		public abstract bool ValidateNewRadio(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radio, out string error);

		// Token: 0x060002BF RID: 703
		public abstract bool FoundInvalidDVRS(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRODVRSFileDto DVRSFile, long DVRSHashCode);

		// Token: 0x060002C0 RID: 704 RVA: 0x00048EE4 File Offset: 0x000470E4
		public bool ValidateWhenEditTemplateColumn(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase oldTemplate, object newValue, string editedFieldName, out global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.TemplateFieldType, object>> fieldValues, out string error)
		{
			int a_ = 18;
			switch (0)
			{
			case 0:
				goto IL_A9;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_13:
				string text;
				switch (num)
				{
				case 0:
					if (oldTemplate is global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROTemplate)
					{
						num2 = (short)993132548;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_32C;
				case 1:
					num2 = (short)48037905;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (text != null)
					{
						num2 = (short)1956052993;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_20E;
				case 3:
					fieldValues.Add((newValue != null) ? new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.TemplateFieldType, object>(global::Motorola.CommonCPS.Server.CommonDBConstants.TemplateFieldType.DVRSFile, ((global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRODVRSFileDto)newValue).Uuid) : new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.TemplateFieldType, object>(global::Motorola.CommonCPS.Server.CommonDBConstants.TemplateFieldType.DVRSFile, global::System.Guid.Empty));
					num2 = (short)88145928;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)93519875;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (newValue != null)
					{
						num2 = (short)555024410;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_36D;
				case 6:
					goto IL_20E;
				case 7:
					if (this._serviceContainer.TemplateService.GetTemplateByName(text) == null)
					{
						num2 = (short)1359544336;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					error = global::Motorola.CommonCPS.ResourceRepository.Resources.Template_Name_duplicated;
					num2 = (short)268304397;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					goto IL_32C;
				case 9:
					goto IL_1E4;
				case 10:
					return result;
				case 11:
					num2 = (short)1799487506;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					if (!(editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("漫䄭崯弱儳堵䰷䤹", a_)))
					{
						num2 = (short)1567752222;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)739180576;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					goto IL_32C;
				case 14:
					if (string.Equals(oldTemplate.Comments, newValue as string, global::System.StringComparison.Ordinal))
					{
						num2 = (short)88014875;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3B4;
				case 15:
					goto IL_32C;
				case 16:
					fieldValues.Add(new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.TemplateFieldType, object>(global::Motorola.CommonCPS.Server.CommonDBConstants.TemplateFieldType.Name, newValue));
					num2 = (short)1212678164;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					if (text.Trim() == string.Empty)
					{
						num2 = (short)764280860;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_20E;
				case 18:
					if (!(editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("栫砭戯愱爳張吷弹", a_)))
					{
						num2 = (short)1473576994;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)600702976;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					goto IL_32C;
				case 20:
					goto IL_32C;
				case 21:
					if (!string.IsNullOrEmpty(error))
					{
						num2 = (short)925106198;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 22:
					result = false;
					num2 = (short)1793589258;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 23:
					if (string.IsNullOrEmpty(error))
					{
						num2 = (short)1973813283;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_32C;
				case 24:
					return true;
				case 25:
					if (!(editedFieldName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("戫伭崯圱", a_)))
					{
						num2 = (short)239403019;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1646002181;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 26:
					newValue = (newValue as string).Trim();
					num2 = (short)630718497;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 27:
					return true;
				case 28:
					error = global::Motorola.CommonCPS.ResourceRepository.Resources.TemplateNameFormatError;
					num2 = (short)1315438598;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 29:
					num2 = (short)1842610178;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 30:
					num2 = (short)54525977;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 31:
					if (string.IsNullOrEmpty(text))
					{
						num2 = (short)1339031581;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_20E;
				case 32:
					num2 = (short)396886017;
					if (num2 != 0)
					{
					}
					if (newValue != null)
					{
						num2 = (short)422510601;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3B4;
				case 33:
					if (string.Equals(oldTemplate.Name, newValue as string, global::System.StringComparison.Ordinal))
					{
						num2 = (short)177340440;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_36D;
				case 34:
				{
					num2 = (short)1647157586;
					short num3 = num2;
					num2 = (short)1604755794;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E4;
					default:
						num2 = (short)312934400;
						if (num2 != 0)
						{
						}
						num2 = (short)1142095891;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 35:
					num2 = (short)1220739079;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_A9;
				IL_1E4:
				newValue = (newValue as string).Trim();
				num2 = (short)1855586318;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_20E:
				num2 = (short)391381015;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_32C:
				num2 = (short)1708720149;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_36D:
				text = (newValue as string);
				num2 = (short)1549533215;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_3B4:
				fieldValues.Add(new global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.TemplateFieldType, object>(global::Motorola.CommonCPS.Server.CommonDBConstants.TemplateFieldType.Comment, newValue));
				num2 = (short)464846863;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_A9:
			result = true;
			error = null;
			fieldValues = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.CommonDBConstants.TemplateFieldType, object>>();
			num2 = (short)2085683200;
			short num4 = num2;
			num2 = (short)1259864076;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00049568 File Offset: 0x00047768
		public virtual void ValidateDeviceModel(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase d)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			string empty;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1898577921;
					if (num2 != 0)
					{
					}
					num2 = (short)1733951488;
					short num3 = num2;
					for (;;)
					{
						d.SerialNumberError = empty;
						num2 = (short)1592215779;
						short num4 = num2;
						num2 = (short)672549091;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_A4;
						}
					}
					IL_A4:
					num2 = (short)950730752;
					if (num2 != 0)
					{
					}
					num2 = (short)1565589507;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					if (!this.ValidateSerialNumber(d.SerialNumber, out empty))
					{
						num2 = (short)1496383488;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
					if (d.IsSerialNumberEditable)
					{
						num2 = (short)1414987780;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					return;
				case 4:
					num2 = (short)130220033;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			return;
			IL_24:
			this.CheckDeviceModelEditable(d);
			empty = string.Empty;
			num2 = (short)644153346;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x000496E0 File Offset: 0x000478E0
		public virtual void CheckDeviceModelEditable(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase d)
		{
			short num = (short)334561281;
			if (num != 0)
			{
			}
			num = (short)1391678823;
			short num2 = num;
			num = (short)1268864359;
			switch (num2 == num)
			{
			}
			num = (short)422510592;
			if (num != 0)
			{
			}
			num = (short)1269563392;
			short num3 = num;
			d.IsSerialNumberEditable = this.ValidateSerialNumberEditable(d);
			d.IsRadioAliasEditable = this.ValidateRadioAliasEditable(d);
			d.IsGroupNameEditable = this.ValidateGroupNameEditable(d);
			d.IsCommentEditable = this.ValidateCommentEditable(d);
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x000497BC File Offset: 0x000479BC
		public virtual void ValidateTemplateModel(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase template)
		{
			short num = (short)1672156329;
			short num2 = num;
			num = (short)1528239273;
			switch (num2 == num)
			{
			}
			num = (short)219545601;
			if (num != 0)
			{
			}
			num = (short)774832128;
			if (num != 0)
			{
			}
			num = (short)1782644736;
			short num3 = num;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00049868 File Offset: 0x00047A68
		public virtual void ValidateDVRSHashDVRSFile(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase template)
		{
			short num = (short)777051062;
			short num2 = num;
			num = (short)244505526;
			switch (num2 == num)
			{
			}
			num = (short)224395265;
			if (num != 0)
			{
			}
			num = (short)1769668608;
			if (num != 0)
			{
			}
			num = (short)1455751168;
			short num3 = num;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00049914 File Offset: 0x00047B14
		public bool IsJobNotRunning(global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus)
		{
			short num = (short)1541067490;
			short num2 = num;
			num = (short)86889186;
			switch (num2 == num)
			{
			}
			num = (short)1186725889;
			if (num != 0)
			{
			}
			num = (short)899743744;
			if (num != 0)
			{
			}
			num = (short)1262026752;
			short num3 = num;
			return this._serviceContainer.RadioService.IsJobNotRunning(jobStatus);
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x000499D0 File Offset: 0x00047BD0
		public bool CanCreateJob(global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus)
		{
			short num = (short)759351894;
			short num2 = num;
			num = (short)1716046422;
			switch (num2 == num)
			{
			}
			num = (short)1886322689;
			if (num != 0)
			{
			}
			num = (short)544210944;
			if (num != 0)
			{
			}
			num = (short)920190976;
			short num3 = num;
			return this._serviceContainer.RadioService.CanCreateJob(jobStatus);
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x00049A8C File Offset: 0x00047C8C
		public bool IsRadioSwitchoverRequired(global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? jobStatus, global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus? cruncherStatus)
		{
			short num = (short)308019201;
			if (num != 0)
			{
			}
			num = (short)1695925202;
			short num2 = num;
			num = (short)2059453394;
			switch (num2 == num)
			{
			}
			num = (short)1253703680;
			if (num != 0)
			{
			}
			num = (short)1074200576;
			short num3 = num;
			return this._serviceContainer.RadioService.IsRadioSwitchoverRequired(jobStatus, cruncherStatus);
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00049B48 File Offset: 0x00047D48
		public bool IsJobProcessingState(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radio)
		{
			short num = (short)194445313;
			if (num != 0)
			{
			}
			num = (short)1822470475;
			short num2 = num;
			num = (short)995799371;
			switch (num2 == num)
			{
			}
			num = (short)616562688;
			if (num != 0)
			{
			}
			num = (short)2078998528;
			short num3 = num;
			return this._serviceContainer.RadioService.IsJobProcessingState(radio.ToEntity());
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00049C08 File Offset: 0x00047E08
		public bool CanDeleteRadio(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> radios)
		{
			short num = (short)260112385;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> enumerator = radios.GetEnumerator();
			bool result;
			try
			{
				num = (short)501219331;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)459997188;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase;
						if (!this.CanCreateJob(radioBase.JobStatus))
						{
							num = (short)1963720709;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_104;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_73;
						}
						continue;
					case 4:
						goto IL_122;
					case 5:
						result = false;
						num = (short)389152770;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1159856128;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = enumerator.Current;
						num = (short)156041217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_75:
					num = (short)548012038;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_73:
					goto IL_75;
				}
				IL_104:
				goto IL_1DF;
				IL_122:
				return true;
			}
			finally
			{
				num = (short)948436994;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1DC;
					case 1:
					{
						num = (short)418659789;
						short num3 = num;
						num = (short)358628813;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1DC;
						default:
							num = (short)1438121984;
							if (num != 0)
							{
							}
							enumerator.Dispose();
							num = (short)2106851328;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_157;
						}
						continue;
					}
					IL_157:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1933312001;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1DC:;
			}
			IL_1DF:
			num = (short)2069102592;
			short num4 = num;
			return result;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00049E30 File Offset: 0x00048030
		public bool CanSelectMVO(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> selectedItems)
		{
			short num = (short)448922963;
			short num2 = num;
			num = (short)2089354579;
			switch (num2 == num)
			{
			}
			num = (short)506658817;
			if (num != 0)
			{
			}
			num = (short)947716096;
			if (num != 0)
			{
			}
			num = (short)1364066304;
			short num3 = num;
			return true;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00049EDC File Offset: 0x000480DC
		protected bool CheckDevicesIsTheSameModel(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> selectedDevices)
		{
			short num = (short)1953824772;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				string a;
				int num3;
				switch (num2)
				{
				case 0:
					if (!string.Equals(a, selectedDevices[num3].ModelNumber.Substring(0, 1), global::System.StringComparison.CurrentCultureIgnoreCase))
					{
						num = (short)1666580482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num3++;
					num = (short)710213639;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return true;
				case 2:
					goto IL_DE;
				case 3:
					goto IL_159;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 5:
					goto IL_6F;
				case 6:
					num = (short)1717501953;
					if (num != 0)
					{
					}
					if (num3 >= selectedDevices.Count)
					{
						num = (short)474087425;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)861995008;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_159;
				}
				IL_45:
				if (string.IsNullOrEmpty(selectedDevices[0].ModelNumber))
				{
					num = (short)164036613;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				a = selectedDevices[0].ModelNumber.Substring(0, 1);
				num3 = 1;
				num = (short)585105411;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_159:
				num = (short)1823997958;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_6F:
			num = (short)278265856;
			short num4 = num;
			return false;
			IL_DE:
			num = (short)1013859272;
			short num5 = num;
			num = (short)89277384;
			switch ((num5 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return true;
			default:
				num = (short)991494144;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0004A0DC File Offset: 0x000482DC
		protected bool ValidateSerialNumberEditable(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase d)
		{
			short num = (short)1029570561;
			if (num != 0)
			{
			}
			num = (short)1981539655;
			short num2 = num;
			num = (short)1260315975;
			switch (num2 == num)
			{
			}
			num = (short)2047868928;
			if (num != 0)
			{
			}
			num = (short)2055602176;
			short num3 = num;
			return this.EditableBeforeReading(d);
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0004A188 File Offset: 0x00048388
		protected bool ValidateRadioAliasEditable(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase d)
		{
			while (!this.CanCreateJob(d.JobStatus))
			{
				short num = (short)856162304;
				short num2 = num;
				num = (short)1502886793;
				short num3 = num;
				num = (short)880229257;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)36700160;
					if (num != 0)
					{
					}
					num = (short)742195201;
					if (num != 0)
					{
					}
					return false;
				}
			}
			bool? isOutOfSync = d.IsOutOfSync;
			bool flag = true;
			return !(isOutOfSync.GetValueOrDefault() == flag & isOutOfSync != null);
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0004A264 File Offset: 0x00048464
		protected bool ValidateCommentEditable(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase d)
		{
			short num = (short)1618365777;
			short num2 = num;
			num = (short)1057967441;
			switch (num2 == num)
			{
			}
			num = (short)138149889;
			if (num != 0)
			{
			}
			num = (short)354156544;
			if (num != 0)
			{
			}
			num = (short)883556352;
			short num3 = num;
			return this.IsJobNotRunning(d.JobStatus);
		}

		// Token: 0x060002CF RID: 719 RVA: 0x0004A318 File Offset: 0x00048518
		protected bool ValidateGroupNameEditable(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase d)
		{
			short num = (short)155106075;
			short num2 = num;
			num = (short)1898494747;
			switch (num2 == num)
			{
			}
			num = (short)286982145;
			if (num != 0)
			{
			}
			num = (short)1892745216;
			if (num != 0)
			{
			}
			num = (short)2122645504;
			short num3 = num;
			return this.CanCreateJob(d.JobStatus);
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0004A3CC File Offset: 0x000485CC
		protected bool EditableBeforeReading(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase d)
		{
			short num = (short)1628438529;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_14D;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 2:
					if (this.CanCreateJob(d.JobStatus))
					{
						num = (short)1298202624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 3:
				{
					num = (short)1983064349;
					short num3 = num;
					num = (short)497821981;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num = (short)1009713152;
						short num4 = num;
						num = (short)1767702529;
						if (num != 0)
						{
						}
						num = (short)1877016576;
						if (num != 0)
						{
						}
						num = (short)1386348546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				}
				IL_34:
				if (global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.HasMVO(d))
				{
					return false;
				}
				num = (short)952893443;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_14D:
			bool? isOutOfSync = d.IsOutOfSync;
			bool flag = true;
			return !(isOutOfSync.GetValueOrDefault() == flag & isOutOfSync != null);
		}

		// Token: 0x04000076 RID: 118
		protected readonly global::Motorola.CommonCPS.RadioManagement.SharedServices.IServiceContainer _serviceContainer;
	}
}
