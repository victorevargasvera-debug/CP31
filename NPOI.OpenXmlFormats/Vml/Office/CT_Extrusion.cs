using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Vml.Office
{
	// Token: 0x0200020C RID: 524
	[global::System.ComponentModel.DesignerCategory("code")]
	[global::System.Xml.Serialization.XmlType(Namespace = "urn:schemas-microsoft-com:office:office")]
	[global::System.Xml.Serialization.XmlRoot(Namespace = "urn:schemas-microsoft-com:office:office", IsNullable = true)]
	[global::System.Serializable]
	public class CT_Extrusion
	{
		// Token: 0x06001515 RID: 5397 RVA: 0x000410F7 File Offset: 0x0003F2F7
		public CT_Extrusion()
		{
			this.typeField = global::NPOI.OpenXmlFormats.Vml.Office.ST_ExtrusionType.parallel;
			this.renderField = global::NPOI.OpenXmlFormats.Vml.Office.ST_ExtrusionRender.solid;
			this.planeField = global::NPOI.OpenXmlFormats.Vml.Office.ST_ExtrusionPlane.XY;
		}

		// Token: 0x170007BA RID: 1978
		// (get) Token: 0x06001516 RID: 5398 RVA: 0x00041114 File Offset: 0x0003F314
		// (set) Token: 0x06001517 RID: 5399 RVA: 0x0004111C File Offset: 0x0003F31C
		[global::System.Xml.Serialization.XmlAttribute(Form = global::System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "urn:schemas-microsoft-com:vml")]
		public global::NPOI.OpenXmlFormats.Vml.ST_Ext ext
		{
			get
			{
				return this.extField;
			}
			set
			{
				this.extField = value;
			}
		}

		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06001518 RID: 5400 RVA: 0x00041125 File Offset: 0x0003F325
		[global::System.Xml.Serialization.XmlIgnore]
		public bool extSpecified
		{
			get
			{
				return this.extField > global::NPOI.OpenXmlFormats.Vml.ST_Ext.NONE;
			}
		}

		// Token: 0x170007BC RID: 1980
		// (get) Token: 0x06001519 RID: 5401 RVA: 0x00041130 File Offset: 0x0003F330
		// (set) Token: 0x0600151A RID: 5402 RVA: 0x00041138 File Offset: 0x0003F338
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse on
		{
			get
			{
				return this.onField;
			}
			set
			{
				this.onField = value;
			}
		}

		// Token: 0x170007BD RID: 1981
		// (get) Token: 0x0600151B RID: 5403 RVA: 0x00041141 File Offset: 0x0003F341
		// (set) Token: 0x0600151C RID: 5404 RVA: 0x00041149 File Offset: 0x0003F349
		[global::System.Xml.Serialization.XmlIgnore]
		public bool onSpecified
		{
			get
			{
				return this.onFieldSpecified;
			}
			set
			{
				this.onFieldSpecified = value;
			}
		}

		// Token: 0x170007BE RID: 1982
		// (get) Token: 0x0600151D RID: 5405 RVA: 0x00041152 File Offset: 0x0003F352
		// (set) Token: 0x0600151E RID: 5406 RVA: 0x0004115A File Offset: 0x0003F35A
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Vml.Office.ST_ExtrusionType.parallel)]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_ExtrusionType type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}

		// Token: 0x170007BF RID: 1983
		// (get) Token: 0x0600151F RID: 5407 RVA: 0x00041163 File Offset: 0x0003F363
		// (set) Token: 0x06001520 RID: 5408 RVA: 0x0004116B File Offset: 0x0003F36B
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Vml.Office.ST_ExtrusionRender.solid)]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_ExtrusionRender render
		{
			get
			{
				return this.renderField;
			}
			set
			{
				this.renderField = value;
			}
		}

		// Token: 0x170007C0 RID: 1984
		// (get) Token: 0x06001521 RID: 5409 RVA: 0x00041174 File Offset: 0x0003F374
		// (set) Token: 0x06001522 RID: 5410 RVA: 0x0004117C File Offset: 0x0003F37C
		[global::System.Xml.Serialization.XmlAttribute]
		public string viewpointorigin
		{
			get
			{
				return this.viewpointoriginField;
			}
			set
			{
				this.viewpointoriginField = value;
			}
		}

		// Token: 0x170007C1 RID: 1985
		// (get) Token: 0x06001523 RID: 5411 RVA: 0x00041185 File Offset: 0x0003F385
		// (set) Token: 0x06001524 RID: 5412 RVA: 0x0004118D File Offset: 0x0003F38D
		[global::System.Xml.Serialization.XmlAttribute]
		public string viewpoint
		{
			get
			{
				return this.viewpointField;
			}
			set
			{
				this.viewpointField = value;
			}
		}

		// Token: 0x170007C2 RID: 1986
		// (get) Token: 0x06001525 RID: 5413 RVA: 0x00041196 File Offset: 0x0003F396
		// (set) Token: 0x06001526 RID: 5414 RVA: 0x0004119E File Offset: 0x0003F39E
		[global::System.Xml.Serialization.XmlAttribute]
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Vml.Office.ST_ExtrusionPlane.XY)]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_ExtrusionPlane plane
		{
			get
			{
				return this.planeField;
			}
			set
			{
				this.planeField = value;
			}
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x06001527 RID: 5415 RVA: 0x000411A7 File Offset: 0x0003F3A7
		// (set) Token: 0x06001528 RID: 5416 RVA: 0x000411AF File Offset: 0x0003F3AF
		[global::System.Xml.Serialization.XmlAttribute]
		public float skewangle
		{
			get
			{
				return this.skewangleField;
			}
			set
			{
				this.skewangleField = value;
			}
		}

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06001529 RID: 5417 RVA: 0x000411B8 File Offset: 0x0003F3B8
		// (set) Token: 0x0600152A RID: 5418 RVA: 0x000411C0 File Offset: 0x0003F3C0
		[global::System.Xml.Serialization.XmlIgnore]
		public bool skewangleSpecified
		{
			get
			{
				return this.skewangleFieldSpecified;
			}
			set
			{
				this.skewangleFieldSpecified = value;
			}
		}

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x0600152B RID: 5419 RVA: 0x000411C9 File Offset: 0x0003F3C9
		// (set) Token: 0x0600152C RID: 5420 RVA: 0x000411D1 File Offset: 0x0003F3D1
		[global::System.Xml.Serialization.XmlAttribute]
		public string skewamt
		{
			get
			{
				return this.skewamtField;
			}
			set
			{
				this.skewamtField = value;
			}
		}

		// Token: 0x170007C6 RID: 1990
		// (get) Token: 0x0600152D RID: 5421 RVA: 0x000411DA File Offset: 0x0003F3DA
		// (set) Token: 0x0600152E RID: 5422 RVA: 0x000411E2 File Offset: 0x0003F3E2
		[global::System.Xml.Serialization.XmlAttribute]
		public string foredepth
		{
			get
			{
				return this.foredepthField;
			}
			set
			{
				this.foredepthField = value;
			}
		}

		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x0600152F RID: 5423 RVA: 0x000411EB File Offset: 0x0003F3EB
		// (set) Token: 0x06001530 RID: 5424 RVA: 0x000411F3 File Offset: 0x0003F3F3
		[global::System.Xml.Serialization.XmlAttribute]
		public string backdepth
		{
			get
			{
				return this.backdepthField;
			}
			set
			{
				this.backdepthField = value;
			}
		}

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06001531 RID: 5425 RVA: 0x000411FC File Offset: 0x0003F3FC
		// (set) Token: 0x06001532 RID: 5426 RVA: 0x00041204 File Offset: 0x0003F404
		[global::System.Xml.Serialization.XmlAttribute]
		public string orientation
		{
			get
			{
				return this.orientationField;
			}
			set
			{
				this.orientationField = value;
			}
		}

		// Token: 0x170007C9 RID: 1993
		// (get) Token: 0x06001533 RID: 5427 RVA: 0x0004120D File Offset: 0x0003F40D
		// (set) Token: 0x06001534 RID: 5428 RVA: 0x00041215 File Offset: 0x0003F415
		[global::System.Xml.Serialization.XmlAttribute]
		public float orientationangle
		{
			get
			{
				return this.orientationangleField;
			}
			set
			{
				this.orientationangleField = value;
			}
		}

		// Token: 0x170007CA RID: 1994
		// (get) Token: 0x06001535 RID: 5429 RVA: 0x0004121E File Offset: 0x0003F41E
		// (set) Token: 0x06001536 RID: 5430 RVA: 0x00041226 File Offset: 0x0003F426
		[global::System.Xml.Serialization.XmlIgnore]
		public bool orientationangleSpecified
		{
			get
			{
				return this.orientationangleFieldSpecified;
			}
			set
			{
				this.orientationangleFieldSpecified = value;
			}
		}

		// Token: 0x170007CB RID: 1995
		// (get) Token: 0x06001537 RID: 5431 RVA: 0x0004122F File Offset: 0x0003F42F
		// (set) Token: 0x06001538 RID: 5432 RVA: 0x00041237 File Offset: 0x0003F437
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse lockrotationcenter
		{
			get
			{
				return this.lockrotationcenterField;
			}
			set
			{
				this.lockrotationcenterField = value;
			}
		}

		// Token: 0x170007CC RID: 1996
		// (get) Token: 0x06001539 RID: 5433 RVA: 0x00041240 File Offset: 0x0003F440
		// (set) Token: 0x0600153A RID: 5434 RVA: 0x00041248 File Offset: 0x0003F448
		[global::System.Xml.Serialization.XmlIgnore]
		public bool lockrotationcenterSpecified
		{
			get
			{
				return this.lockrotationcenterFieldSpecified;
			}
			set
			{
				this.lockrotationcenterFieldSpecified = value;
			}
		}

		// Token: 0x170007CD RID: 1997
		// (get) Token: 0x0600153B RID: 5435 RVA: 0x00041251 File Offset: 0x0003F451
		// (set) Token: 0x0600153C RID: 5436 RVA: 0x00041259 File Offset: 0x0003F459
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse autorotationcenter
		{
			get
			{
				return this.autorotationcenterField;
			}
			set
			{
				this.autorotationcenterField = value;
			}
		}

		// Token: 0x170007CE RID: 1998
		// (get) Token: 0x0600153D RID: 5437 RVA: 0x00041262 File Offset: 0x0003F462
		// (set) Token: 0x0600153E RID: 5438 RVA: 0x0004126A File Offset: 0x0003F46A
		[global::System.Xml.Serialization.XmlIgnore]
		public bool autorotationcenterSpecified
		{
			get
			{
				return this.autorotationcenterFieldSpecified;
			}
			set
			{
				this.autorotationcenterFieldSpecified = value;
			}
		}

		// Token: 0x170007CF RID: 1999
		// (get) Token: 0x0600153F RID: 5439 RVA: 0x00041273 File Offset: 0x0003F473
		// (set) Token: 0x06001540 RID: 5440 RVA: 0x0004127B File Offset: 0x0003F47B
		[global::System.Xml.Serialization.XmlAttribute]
		public string rotationcenter
		{
			get
			{
				return this.rotationcenterField;
			}
			set
			{
				this.rotationcenterField = value;
			}
		}

		// Token: 0x170007D0 RID: 2000
		// (get) Token: 0x06001541 RID: 5441 RVA: 0x00041284 File Offset: 0x0003F484
		// (set) Token: 0x06001542 RID: 5442 RVA: 0x0004128C File Offset: 0x0003F48C
		[global::System.Xml.Serialization.XmlAttribute]
		public string rotationangle
		{
			get
			{
				return this.rotationangleField;
			}
			set
			{
				this.rotationangleField = value;
			}
		}

		// Token: 0x170007D1 RID: 2001
		// (get) Token: 0x06001543 RID: 5443 RVA: 0x00041295 File Offset: 0x0003F495
		// (set) Token: 0x06001544 RID: 5444 RVA: 0x0004129D File Offset: 0x0003F49D
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_ColorMode colormode
		{
			get
			{
				return this.colormodeField;
			}
			set
			{
				this.colormodeField = value;
			}
		}

		// Token: 0x170007D2 RID: 2002
		// (get) Token: 0x06001545 RID: 5445 RVA: 0x000412A6 File Offset: 0x0003F4A6
		// (set) Token: 0x06001546 RID: 5446 RVA: 0x000412AE File Offset: 0x0003F4AE
		[global::System.Xml.Serialization.XmlIgnore]
		public bool colormodeSpecified
		{
			get
			{
				return this.colormodeFieldSpecified;
			}
			set
			{
				this.colormodeFieldSpecified = value;
			}
		}

		// Token: 0x170007D3 RID: 2003
		// (get) Token: 0x06001547 RID: 5447 RVA: 0x000412B7 File Offset: 0x0003F4B7
		// (set) Token: 0x06001548 RID: 5448 RVA: 0x000412BF File Offset: 0x0003F4BF
		[global::System.Xml.Serialization.XmlAttribute]
		public string color
		{
			get
			{
				return this.colorField;
			}
			set
			{
				this.colorField = value;
			}
		}

		// Token: 0x170007D4 RID: 2004
		// (get) Token: 0x06001549 RID: 5449 RVA: 0x000412C8 File Offset: 0x0003F4C8
		// (set) Token: 0x0600154A RID: 5450 RVA: 0x000412D0 File Offset: 0x0003F4D0
		[global::System.Xml.Serialization.XmlAttribute]
		public float shininess
		{
			get
			{
				return this.shininessField;
			}
			set
			{
				this.shininessField = value;
			}
		}

		// Token: 0x170007D5 RID: 2005
		// (get) Token: 0x0600154B RID: 5451 RVA: 0x000412D9 File Offset: 0x0003F4D9
		// (set) Token: 0x0600154C RID: 5452 RVA: 0x000412E1 File Offset: 0x0003F4E1
		[global::System.Xml.Serialization.XmlIgnore]
		public bool shininessSpecified
		{
			get
			{
				return this.shininessFieldSpecified;
			}
			set
			{
				this.shininessFieldSpecified = value;
			}
		}

		// Token: 0x170007D6 RID: 2006
		// (get) Token: 0x0600154D RID: 5453 RVA: 0x000412EA File Offset: 0x0003F4EA
		// (set) Token: 0x0600154E RID: 5454 RVA: 0x000412F2 File Offset: 0x0003F4F2
		[global::System.Xml.Serialization.XmlAttribute]
		public string specularity
		{
			get
			{
				return this.specularityField;
			}
			set
			{
				this.specularityField = value;
			}
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x0600154F RID: 5455 RVA: 0x000412FB File Offset: 0x0003F4FB
		// (set) Token: 0x06001550 RID: 5456 RVA: 0x00041303 File Offset: 0x0003F503
		[global::System.Xml.Serialization.XmlAttribute]
		public string diffusity
		{
			get
			{
				return this.diffusityField;
			}
			set
			{
				this.diffusityField = value;
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06001551 RID: 5457 RVA: 0x0004130C File Offset: 0x0003F50C
		// (set) Token: 0x06001552 RID: 5458 RVA: 0x00041314 File Offset: 0x0003F514
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse metal
		{
			get
			{
				return this.metalField;
			}
			set
			{
				this.metalField = value;
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x06001553 RID: 5459 RVA: 0x0004131D File Offset: 0x0003F51D
		// (set) Token: 0x06001554 RID: 5460 RVA: 0x00041325 File Offset: 0x0003F525
		[global::System.Xml.Serialization.XmlIgnore]
		public bool metalSpecified
		{
			get
			{
				return this.metalFieldSpecified;
			}
			set
			{
				this.metalFieldSpecified = value;
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x06001555 RID: 5461 RVA: 0x0004132E File Offset: 0x0003F52E
		// (set) Token: 0x06001556 RID: 5462 RVA: 0x00041336 File Offset: 0x0003F536
		[global::System.Xml.Serialization.XmlAttribute]
		public string edge
		{
			get
			{
				return this.edgeField;
			}
			set
			{
				this.edgeField = value;
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x06001557 RID: 5463 RVA: 0x0004133F File Offset: 0x0003F53F
		// (set) Token: 0x06001558 RID: 5464 RVA: 0x00041347 File Offset: 0x0003F547
		[global::System.Xml.Serialization.XmlAttribute]
		public string facet
		{
			get
			{
				return this.facetField;
			}
			set
			{
				this.facetField = value;
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x06001559 RID: 5465 RVA: 0x00041350 File Offset: 0x0003F550
		// (set) Token: 0x0600155A RID: 5466 RVA: 0x00041358 File Offset: 0x0003F558
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse lightface
		{
			get
			{
				return this.lightfaceField;
			}
			set
			{
				this.lightfaceField = value;
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x0600155B RID: 5467 RVA: 0x00041361 File Offset: 0x0003F561
		// (set) Token: 0x0600155C RID: 5468 RVA: 0x00041369 File Offset: 0x0003F569
		[global::System.Xml.Serialization.XmlIgnore]
		public bool lightfaceSpecified
		{
			get
			{
				return this.lightfaceFieldSpecified;
			}
			set
			{
				this.lightfaceFieldSpecified = value;
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x0600155D RID: 5469 RVA: 0x00041372 File Offset: 0x0003F572
		// (set) Token: 0x0600155E RID: 5470 RVA: 0x0004137A File Offset: 0x0003F57A
		[global::System.Xml.Serialization.XmlAttribute]
		public string brightness
		{
			get
			{
				return this.brightnessField;
			}
			set
			{
				this.brightnessField = value;
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x0600155F RID: 5471 RVA: 0x00041383 File Offset: 0x0003F583
		// (set) Token: 0x06001560 RID: 5472 RVA: 0x0004138B File Offset: 0x0003F58B
		[global::System.Xml.Serialization.XmlAttribute]
		public string lightposition
		{
			get
			{
				return this.lightpositionField;
			}
			set
			{
				this.lightpositionField = value;
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x06001561 RID: 5473 RVA: 0x00041394 File Offset: 0x0003F594
		// (set) Token: 0x06001562 RID: 5474 RVA: 0x0004139C File Offset: 0x0003F59C
		[global::System.Xml.Serialization.XmlAttribute]
		public string lightlevel
		{
			get
			{
				return this.lightlevelField;
			}
			set
			{
				this.lightlevelField = value;
			}
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x06001563 RID: 5475 RVA: 0x000413A5 File Offset: 0x0003F5A5
		// (set) Token: 0x06001564 RID: 5476 RVA: 0x000413AD File Offset: 0x0003F5AD
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse lightharsh
		{
			get
			{
				return this.lightharshField;
			}
			set
			{
				this.lightharshField = value;
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x06001565 RID: 5477 RVA: 0x000413B6 File Offset: 0x0003F5B6
		// (set) Token: 0x06001566 RID: 5478 RVA: 0x000413BE File Offset: 0x0003F5BE
		[global::System.Xml.Serialization.XmlIgnore]
		public bool lightharshSpecified
		{
			get
			{
				return this.lightharshFieldSpecified;
			}
			set
			{
				this.lightharshFieldSpecified = value;
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x06001567 RID: 5479 RVA: 0x000413C7 File Offset: 0x0003F5C7
		// (set) Token: 0x06001568 RID: 5480 RVA: 0x000413CF File Offset: 0x0003F5CF
		[global::System.Xml.Serialization.XmlAttribute]
		public string lightposition2
		{
			get
			{
				return this.lightposition2Field;
			}
			set
			{
				this.lightposition2Field = value;
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x06001569 RID: 5481 RVA: 0x000413D8 File Offset: 0x0003F5D8
		// (set) Token: 0x0600156A RID: 5482 RVA: 0x000413E0 File Offset: 0x0003F5E0
		[global::System.Xml.Serialization.XmlAttribute]
		public string lightlevel2
		{
			get
			{
				return this.lightlevel2Field;
			}
			set
			{
				this.lightlevel2Field = value;
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x0600156B RID: 5483 RVA: 0x000413E9 File Offset: 0x0003F5E9
		// (set) Token: 0x0600156C RID: 5484 RVA: 0x000413F1 File Offset: 0x0003F5F1
		[global::System.Xml.Serialization.XmlAttribute]
		public global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse lightharsh2
		{
			get
			{
				return this.lightharsh2Field;
			}
			set
			{
				this.lightharsh2Field = value;
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x0600156D RID: 5485 RVA: 0x000413FA File Offset: 0x0003F5FA
		// (set) Token: 0x0600156E RID: 5486 RVA: 0x00041402 File Offset: 0x0003F602
		[global::System.Xml.Serialization.XmlIgnore]
		public bool lightharsh2Specified
		{
			get
			{
				return this.lightharsh2FieldSpecified;
			}
			set
			{
				this.lightharsh2FieldSpecified = value;
			}
		}

		// Token: 0x040010D7 RID: 4311
		private global::NPOI.OpenXmlFormats.Vml.ST_Ext extField;

		// Token: 0x040010D8 RID: 4312
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse onField;

		// Token: 0x040010D9 RID: 4313
		private bool onFieldSpecified;

		// Token: 0x040010DA RID: 4314
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_ExtrusionType typeField;

		// Token: 0x040010DB RID: 4315
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_ExtrusionRender renderField;

		// Token: 0x040010DC RID: 4316
		private string viewpointoriginField;

		// Token: 0x040010DD RID: 4317
		private string viewpointField;

		// Token: 0x040010DE RID: 4318
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_ExtrusionPlane planeField;

		// Token: 0x040010DF RID: 4319
		private float skewangleField;

		// Token: 0x040010E0 RID: 4320
		private bool skewangleFieldSpecified;

		// Token: 0x040010E1 RID: 4321
		private string skewamtField;

		// Token: 0x040010E2 RID: 4322
		private string foredepthField;

		// Token: 0x040010E3 RID: 4323
		private string backdepthField;

		// Token: 0x040010E4 RID: 4324
		private string orientationField;

		// Token: 0x040010E5 RID: 4325
		private float orientationangleField;

		// Token: 0x040010E6 RID: 4326
		private bool orientationangleFieldSpecified;

		// Token: 0x040010E7 RID: 4327
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse lockrotationcenterField;

		// Token: 0x040010E8 RID: 4328
		private bool lockrotationcenterFieldSpecified;

		// Token: 0x040010E9 RID: 4329
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse autorotationcenterField;

		// Token: 0x040010EA RID: 4330
		private bool autorotationcenterFieldSpecified;

		// Token: 0x040010EB RID: 4331
		private string rotationcenterField;

		// Token: 0x040010EC RID: 4332
		private string rotationangleField;

		// Token: 0x040010ED RID: 4333
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_ColorMode colormodeField;

		// Token: 0x040010EE RID: 4334
		private bool colormodeFieldSpecified;

		// Token: 0x040010EF RID: 4335
		private string colorField;

		// Token: 0x040010F0 RID: 4336
		private float shininessField;

		// Token: 0x040010F1 RID: 4337
		private bool shininessFieldSpecified;

		// Token: 0x040010F2 RID: 4338
		private string specularityField;

		// Token: 0x040010F3 RID: 4339
		private string diffusityField;

		// Token: 0x040010F4 RID: 4340
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse metalField;

		// Token: 0x040010F5 RID: 4341
		private bool metalFieldSpecified;

		// Token: 0x040010F6 RID: 4342
		private string edgeField;

		// Token: 0x040010F7 RID: 4343
		private string facetField;

		// Token: 0x040010F8 RID: 4344
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse lightfaceField;

		// Token: 0x040010F9 RID: 4345
		private bool lightfaceFieldSpecified;

		// Token: 0x040010FA RID: 4346
		private string brightnessField;

		// Token: 0x040010FB RID: 4347
		private string lightpositionField;

		// Token: 0x040010FC RID: 4348
		private string lightlevelField;

		// Token: 0x040010FD RID: 4349
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse lightharshField;

		// Token: 0x040010FE RID: 4350
		private bool lightharshFieldSpecified;

		// Token: 0x040010FF RID: 4351
		private string lightposition2Field;

		// Token: 0x04001100 RID: 4352
		private string lightlevel2Field;

		// Token: 0x04001101 RID: 4353
		private global::NPOI.OpenXmlFormats.Vml.Office.ST_TrueFalse lightharsh2Field;

		// Token: 0x04001102 RID: 4354
		private bool lightharsh2FieldSpecified;
	}
}
