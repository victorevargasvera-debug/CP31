using System;
using AcpCommonLib.UndoRedo;

namespace AcpCommonLib
{
	// Token: 0x0200001A RID: 26
	public interface IAcpField : global::AcpCommonLib.IAcpConstraints, global::AcpCommonLib.IAcpCommon, global::System.IComparable, global::System.IDisposable
	{
		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000D4 RID: 212
		// (set) Token: 0x060000D5 RID: 213
		bool Editable { get; set; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000D6 RID: 214
		// (set) Token: 0x060000D7 RID: 215
		bool Valid { get; set; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000D8 RID: 216
		// (set) Token: 0x060000D9 RID: 217
		bool Visible { get; set; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000DA RID: 218
		// (set) Token: 0x060000DB RID: 219
		bool Applicable { get; set; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000DC RID: 220
		// (set) Token: 0x060000DD RID: 221
		bool TieredOut { get; set; }

		// Token: 0x060000DE RID: 222
		global::AcpCommonLib.UndoRedo.UndoableTask CopyValueOf(global::AcpCommonLib.IAcpField source);

		// Token: 0x060000DF RID: 223
		global::AcpCommonLib.UndoRedo.UndoableTask CopyValue(object sourcevalue);

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060000E0 RID: 224
		// (set) Token: 0x060000E1 RID: 225
		global::AcpCommonLib.StateConstraint IsApplicable { get; set; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060000E2 RID: 226
		// (set) Token: 0x060000E3 RID: 227
		global::AcpCommonLib.StateConstraint IsValid { get; set; }

		// Token: 0x060000E4 RID: 228
		bool AddDependentObject(global::AcpCommonLib.IAcpField obj);

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000E5 RID: 229
		string Name { get; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000E6 RID: 230
		string UIName { get; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060000E7 RID: 231
		string NewUiExpanderAndName { get; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060000E8 RID: 232
		string NewUIName { get; }

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060000E9 RID: 233
		// (set) Token: 0x060000EA RID: 234
		global::AcpCommonLib.IAcpFeatureSection Parent { get; set; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060000EB RID: 235
		global::AcpCommonLib.IAcpFeatureSection NewParent { get; }

		// Token: 0x060000EC RID: 236
		string Path(string delimiter);

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060000ED RID: 237
		global::System.Type DataType { get; }

		// Token: 0x060000EE RID: 238
		void ParseValueFrom(string value);

		// Token: 0x060000EF RID: 239
		void ParseDefaultValueFrom(string value);

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060000F0 RID: 240
		// (set) Token: 0x060000F1 RID: 241
		bool CustomViewVisibility { get; set; }

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060000F2 RID: 242
		// (set) Token: 0x060000F3 RID: 243
		global::AcpCommonLib.DifferentiatedUserViewType DifferentiatedUserView { get; set; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060000F4 RID: 244
		// (set) Token: 0x060000F5 RID: 245
		int DataTransferOrder { get; set; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060000F6 RID: 246
		bool BlockDataTransfer { get; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060000F7 RID: 247
		// (set) Token: 0x060000F8 RID: 248
		bool Protected { get; set; }

		// Token: 0x060000F9 RID: 249
		void ResetToDefaultWithUndo();

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060000FA RID: 250
		// (set) Token: 0x060000FB RID: 251
		int FieldId { get; set; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060000FC RID: 252
		// (set) Token: 0x060000FD RID: 253
		bool IgnoreOnCompare { get; set; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060000FE RID: 254
		// (set) Token: 0x060000FF RID: 255
		bool IsMasked { get; set; }

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000100 RID: 256
		global::AcpCommonLib.IAcpFeatureNode ParentNode { get; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000101 RID: 257
		// (set) Token: 0x06000102 RID: 258
		bool _HasDiffs { get; set; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000103 RID: 259
		// (set) Token: 0x06000104 RID: 260
		bool KeyNameField { get; set; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000105 RID: 261
		bool HiddenStatic { get; }

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000106 RID: 262
		// (set) Token: 0x06000107 RID: 263
		bool IgnoreOnPrint { get; set; }
	}
}
