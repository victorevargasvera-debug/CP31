using System;
using System.Collections.Generic;
using System.Xml;
using AcpCommonLib.UndoRedo;

namespace AcpCommonLib
{
	// Token: 0x0200001C RID: 28
	public interface IAcpRecordset : global::AcpCommonLib.IAcpConstraints, global::AcpCommonLib.IAcpCommon, global::System.IDisposable
	{
		// Token: 0x06000111 RID: 273
		void Initialize();

		// Token: 0x06000112 RID: 274
		void Clear();

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x06000113 RID: 275
		int RecsetId { get; }

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000114 RID: 276
		string RecordsetName { get; }

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000115 RID: 277
		bool SingleInstance { get; }

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000116 RID: 278
		string UIPagePath { get; }

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000117 RID: 279
		int Count { get; }

		// Token: 0x06000118 RID: 280
		global::AcpCommonLib.IAcpFeatureNode AddDefaultRecord();

		// Token: 0x06000119 RID: 281
		int AddMultipleDefaultRecords(int count);

		// Token: 0x0600011A RID: 282
		bool AddMultipleCopiesOf(int count, int index);

		// Token: 0x0600011B RID: 283
		void RemoveRecordAt(int index);

		// Token: 0x0600011C RID: 284
		void MoveRecord(int oldIndex, int newIndex);

		// Token: 0x17000062 RID: 98
		global::AcpCommonLib.IAcpFeatureNode this[int index]
		{
			get;
		}

		// Token: 0x0600011E RID: 286
		int IndexOf(global::AcpCommonLib.IAcpFeatureNode record);

		// Token: 0x0600011F RID: 287
		global::AcpCommonLib.IAcpFeatureNode NodeFromId(int nodeId);

		// Token: 0x06000120 RID: 288
		global::AcpCommonLib.IAcpFeatureNode NodeFromKey(string key);

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000121 RID: 289
		bool HasEmbeddedRecset { get; }

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000122 RID: 290
		bool IsEmbeddedRecset { get; }

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000123 RID: 291
		bool HasKeyField { get; }

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000124 RID: 292
		global::AcpCommonLib.IAcpFeatureSection ParentSection { get; }

		// Token: 0x06000125 RID: 293
		global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> Search(string token);

		// Token: 0x06000126 RID: 294
		global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.IAcpField> SearchAll(string token);

		// Token: 0x06000127 RID: 295
		bool AddToXml(global::System.Xml.XmlNode node, global::AcpCommonLib.XmlFileType fileType);

		// Token: 0x06000128 RID: 296
		bool ReadFromXml(global::System.Xml.XmlNode node, global::AcpCommonLib.UndoRedo.ContainerTask task, global::AcpCommonLib.XmlFileType fileType, bool importCopyOperation, global::System.Collections.Generic.Dictionary<global::AcpCommonLib.IAcpField, string> RecRefsToRepair, global::System.Collections.Generic.Dictionary<global::AcpCommonLib.IAcpField, string> RecRefFieldsOfEmbedRecset);

		// Token: 0x06000129 RID: 297
		void ClearRecordset(global::AcpCommonLib.IAcpRecordset recset, global::AcpCommonLib.UndoRedo.ContainerTask task);

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600012A RID: 298
		// (set) Token: 0x0600012B RID: 299
		string UIName { get; set; }

		// Token: 0x0600012C RID: 300
		global::AcpCommonLib.IAcpField FieldFromPath(string path, string delimiter);

		// Token: 0x0600012D RID: 301
		global::AcpCommonLib.IAcpField FieldFromFavoritePath(string path, string delimiter);

		// Token: 0x0600012E RID: 302
		void CopyNodesFrom(global::AcpCommonLib.IAcpRecordset source);

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600012F RID: 303
		// (set) Token: 0x06000130 RID: 304
		int DataTransferOrder { get; set; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000131 RID: 305
		// (set) Token: 0x06000132 RID: 306
		global::AcpCommonLib.Document ContainerDoc { get; set; }

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000133 RID: 307
		// (set) Token: 0x06000134 RID: 308
		int Min { get; set; }

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000135 RID: 309
		// (set) Token: 0x06000136 RID: 310
		int Max { get; set; }

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000137 RID: 311
		int CounterToMax { get; }

		// Token: 0x06000138 RID: 312
		int GetCounterToMaxCopiesOf(int index);

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000139 RID: 313
		int CounterToMin { get; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600013A RID: 314
		bool CanBeEmpty { get; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600013B RID: 315
		bool PositionBased { get; }

		// Token: 0x0600013C RID: 316
		string Path(string delimiter);

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600013D RID: 317
		// (set) Token: 0x0600013E RID: 318
		bool HideRecordsFromTree { get; set; }

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600013F RID: 319
		// (set) Token: 0x06000140 RID: 320
		bool HiddenStatic { get; set; }

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000141 RID: 321
		// (set) Token: 0x06000142 RID: 322
		bool PreDataTransferClearRecordset { get; set; }

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000143 RID: 323
		bool _HasDiffs { get; }

		// Token: 0x06000144 RID: 324
		void ClearHasDiffs();

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000145 RID: 325
		bool HasVisibleObjects { get; }

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000146 RID: 326
		// (set) Token: 0x06000147 RID: 327
		bool _IsEmpty { get; set; }

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000148 RID: 328
		// (set) Token: 0x06000149 RID: 329
		bool CalculateHiddenStatic { get; set; }

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600014A RID: 330
		// (set) Token: 0x0600014B RID: 331
		global::AcpCommonLib.Permissions Permissions { get; set; }
	}
}
