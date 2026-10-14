using System;
using System.Collections;
using System.Globalization;

namespace DevAge.ComponentModel.Validator
{
	// Token: 0x02000287 RID: 647
	internal interface IValidator
	{
		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x060020FE RID: 8446
		// (set) Token: 0x060020FF RID: 8447
		bool AllowNull { get; set; }

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06002100 RID: 8448
		// (set) Token: 0x06002101 RID: 8449
		string NullString { get; set; }

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06002102 RID: 8450
		// (set) Token: 0x06002103 RID: 8451
		string NullDisplayString { get; set; }

		// Token: 0x06002104 RID: 8452
		bool IsNullString(string p_str);

		// Token: 0x06002105 RID: 8453
		object ObjectToValue(object p_Object);

		// Token: 0x06002106 RID: 8454
		object ValueToObject(object p_Value, global::System.Type p_ReturnObjectType);

		// Token: 0x06002107 RID: 8455
		string ValueToString(object p_Value);

		// Token: 0x06002108 RID: 8456
		object StringToValue(string p_str);

		// Token: 0x06002109 RID: 8457
		bool IsStringConversionSupported();

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x0600210A RID: 8458
		// (set) Token: 0x0600210B RID: 8459
		bool AllowStringConversion { get; set; }

		// Token: 0x0600210C RID: 8460
		string ValueToDisplayString(object p_Value);

		// Token: 0x0600210D RID: 8461
		bool IsValidValue(object p_Value);

		// Token: 0x0600210E RID: 8462
		bool IsValidObject(object p_Object);

		// Token: 0x0600210F RID: 8463
		bool IsValidObject(object p_Object, out object p_ValueConverted);

		// Token: 0x06002110 RID: 8464
		bool IsValidString(string p_strValue);

		// Token: 0x06002111 RID: 8465
		bool IsValidString(string p_strValue, out object p_ValueConverted);

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06002112 RID: 8466
		// (set) Token: 0x06002113 RID: 8467
		object MinimumValue { get; set; }

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06002114 RID: 8468
		// (set) Token: 0x06002115 RID: 8469
		object MaximumValue { get; set; }

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06002116 RID: 8470
		global::System.Type ValueType { get; }

		// Token: 0x14000090 RID: 144
		// (add) Token: 0x06002117 RID: 8471
		// (remove) Token: 0x06002118 RID: 8472
		event global::DevAge.ComponentModel.ConvertingObjectEventHandler ConvertingObjectToValue;

		// Token: 0x14000091 RID: 145
		// (add) Token: 0x06002119 RID: 8473
		// (remove) Token: 0x0600211A RID: 8474
		event global::DevAge.ComponentModel.ConvertingObjectEventHandler ConvertingValueToObject;

		// Token: 0x14000092 RID: 146
		// (add) Token: 0x0600211B RID: 8475
		// (remove) Token: 0x0600211C RID: 8476
		event global::DevAge.ComponentModel.ConvertingObjectEventHandler ConvertingValueToDisplayString;

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x0600211D RID: 8477
		// (set) Token: 0x0600211E RID: 8478
		object DefaultValue { get; set; }

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x0600211F RID: 8479
		// (set) Token: 0x06002120 RID: 8480
		global::System.Collections.ICollection StandardValues { get; set; }

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x06002121 RID: 8481
		// (set) Token: 0x06002122 RID: 8482
		bool StandardValuesExclusive { get; set; }

		// Token: 0x06002123 RID: 8483
		bool IsInStandardValues(object p_Value);

		// Token: 0x06002124 RID: 8484
		object StandardValueAtIndex(int p_Index);

		// Token: 0x06002125 RID: 8485
		int StandardValuesIndexOf(object p_StandardValue);

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x06002126 RID: 8486
		// (set) Token: 0x06002127 RID: 8487
		global::System.Globalization.CultureInfo CultureInfo { get; set; }

		// Token: 0x14000093 RID: 147
		// (add) Token: 0x06002128 RID: 8488
		// (remove) Token: 0x06002129 RID: 8489
		event global::System.EventHandler Changed;
	}
}
