using System;
using System.Xml.Serialization;

namespace NPOI.OpenXmlFormats.Wordprocessing
{
	// Token: 0x02000159 RID: 345
	[global::System.Xml.Serialization.XmlType(Namespace = "http://schemas.openxmlformats.org/wordprocessingml/2006/main")]
	[global::System.Serializable]
	public enum ST_Border
	{
		// Token: 0x040008C7 RID: 2247
		nil,
		// Token: 0x040008C8 RID: 2248
		none,
		// Token: 0x040008C9 RID: 2249
		single,
		// Token: 0x040008CA RID: 2250
		thick,
		// Token: 0x040008CB RID: 2251
		@double,
		// Token: 0x040008CC RID: 2252
		dotted,
		// Token: 0x040008CD RID: 2253
		dashed,
		// Token: 0x040008CE RID: 2254
		dotDash,
		// Token: 0x040008CF RID: 2255
		dotDotDash,
		// Token: 0x040008D0 RID: 2256
		triple,
		// Token: 0x040008D1 RID: 2257
		thinThickSmallGap,
		// Token: 0x040008D2 RID: 2258
		thickThinSmallGap,
		// Token: 0x040008D3 RID: 2259
		thinThickThinSmallGap,
		// Token: 0x040008D4 RID: 2260
		thinThickMediumGap,
		// Token: 0x040008D5 RID: 2261
		thickThinMediumGap,
		// Token: 0x040008D6 RID: 2262
		thinThickThinMediumGap,
		// Token: 0x040008D7 RID: 2263
		thinThickLargeGap,
		// Token: 0x040008D8 RID: 2264
		thickThinLargeGap,
		// Token: 0x040008D9 RID: 2265
		thinThickThinLargeGap,
		// Token: 0x040008DA RID: 2266
		wave,
		// Token: 0x040008DB RID: 2267
		doubleWave,
		// Token: 0x040008DC RID: 2268
		dashSmallGap,
		// Token: 0x040008DD RID: 2269
		dashDotStroked,
		// Token: 0x040008DE RID: 2270
		threeDEmboss,
		// Token: 0x040008DF RID: 2271
		threeDEngrave,
		// Token: 0x040008E0 RID: 2272
		outset,
		// Token: 0x040008E1 RID: 2273
		inset,
		// Token: 0x040008E2 RID: 2274
		apples,
		// Token: 0x040008E3 RID: 2275
		archedScallops,
		// Token: 0x040008E4 RID: 2276
		babyPacifier,
		// Token: 0x040008E5 RID: 2277
		babyRattle,
		// Token: 0x040008E6 RID: 2278
		balloons3Colors,
		// Token: 0x040008E7 RID: 2279
		balloonsHotAir,
		// Token: 0x040008E8 RID: 2280
		basicBlackDashes,
		// Token: 0x040008E9 RID: 2281
		basicBlackDots,
		// Token: 0x040008EA RID: 2282
		basicBlackSquares,
		// Token: 0x040008EB RID: 2283
		basicThinLines,
		// Token: 0x040008EC RID: 2284
		basicWhiteDashes,
		// Token: 0x040008ED RID: 2285
		basicWhiteDots,
		// Token: 0x040008EE RID: 2286
		basicWhiteSquares,
		// Token: 0x040008EF RID: 2287
		basicWideInline,
		// Token: 0x040008F0 RID: 2288
		basicWideMidline,
		// Token: 0x040008F1 RID: 2289
		basicWideOutline,
		// Token: 0x040008F2 RID: 2290
		bats,
		// Token: 0x040008F3 RID: 2291
		birds,
		// Token: 0x040008F4 RID: 2292
		birdsFlight,
		// Token: 0x040008F5 RID: 2293
		cabins,
		// Token: 0x040008F6 RID: 2294
		cakeSlice,
		// Token: 0x040008F7 RID: 2295
		candyCorn,
		// Token: 0x040008F8 RID: 2296
		celticKnotwork,
		// Token: 0x040008F9 RID: 2297
		certificateBanner,
		// Token: 0x040008FA RID: 2298
		chainLink,
		// Token: 0x040008FB RID: 2299
		champagneBottle,
		// Token: 0x040008FC RID: 2300
		checkedBarBlack,
		// Token: 0x040008FD RID: 2301
		checkedBarColor,
		// Token: 0x040008FE RID: 2302
		checkered,
		// Token: 0x040008FF RID: 2303
		christmasTree,
		// Token: 0x04000900 RID: 2304
		circlesLines,
		// Token: 0x04000901 RID: 2305
		circlesRectangles,
		// Token: 0x04000902 RID: 2306
		classicalWave,
		// Token: 0x04000903 RID: 2307
		clocks,
		// Token: 0x04000904 RID: 2308
		compass,
		// Token: 0x04000905 RID: 2309
		confetti,
		// Token: 0x04000906 RID: 2310
		confettiGrays,
		// Token: 0x04000907 RID: 2311
		confettiOutline,
		// Token: 0x04000908 RID: 2312
		confettiStreamers,
		// Token: 0x04000909 RID: 2313
		confettiWhite,
		// Token: 0x0400090A RID: 2314
		cornerTriangles,
		// Token: 0x0400090B RID: 2315
		couponCutoutDashes,
		// Token: 0x0400090C RID: 2316
		couponCutoutDots,
		// Token: 0x0400090D RID: 2317
		crazyMaze,
		// Token: 0x0400090E RID: 2318
		creaturesButterfly,
		// Token: 0x0400090F RID: 2319
		creaturesFish,
		// Token: 0x04000910 RID: 2320
		creaturesInsects,
		// Token: 0x04000911 RID: 2321
		creaturesLadyBug,
		// Token: 0x04000912 RID: 2322
		crossStitch,
		// Token: 0x04000913 RID: 2323
		cup,
		// Token: 0x04000914 RID: 2324
		decoArch,
		// Token: 0x04000915 RID: 2325
		decoArchColor,
		// Token: 0x04000916 RID: 2326
		decoBlocks,
		// Token: 0x04000917 RID: 2327
		diamondsGray,
		// Token: 0x04000918 RID: 2328
		doubleD,
		// Token: 0x04000919 RID: 2329
		doubleDiamonds,
		// Token: 0x0400091A RID: 2330
		earth1,
		// Token: 0x0400091B RID: 2331
		earth2,
		// Token: 0x0400091C RID: 2332
		eclipsingSquares1,
		// Token: 0x0400091D RID: 2333
		eclipsingSquares2,
		// Token: 0x0400091E RID: 2334
		eggsBlack,
		// Token: 0x0400091F RID: 2335
		fans,
		// Token: 0x04000920 RID: 2336
		film,
		// Token: 0x04000921 RID: 2337
		firecrackers,
		// Token: 0x04000922 RID: 2338
		flowersBlockPrint,
		// Token: 0x04000923 RID: 2339
		flowersDaisies,
		// Token: 0x04000924 RID: 2340
		flowersModern1,
		// Token: 0x04000925 RID: 2341
		flowersModern2,
		// Token: 0x04000926 RID: 2342
		flowersPansy,
		// Token: 0x04000927 RID: 2343
		flowersRedRose,
		// Token: 0x04000928 RID: 2344
		flowersRoses,
		// Token: 0x04000929 RID: 2345
		flowersTeacup,
		// Token: 0x0400092A RID: 2346
		flowersTiny,
		// Token: 0x0400092B RID: 2347
		gems,
		// Token: 0x0400092C RID: 2348
		gingerbreadMan,
		// Token: 0x0400092D RID: 2349
		gradient,
		// Token: 0x0400092E RID: 2350
		handmade1,
		// Token: 0x0400092F RID: 2351
		handmade2,
		// Token: 0x04000930 RID: 2352
		heartBalloon,
		// Token: 0x04000931 RID: 2353
		heartGray,
		// Token: 0x04000932 RID: 2354
		hearts,
		// Token: 0x04000933 RID: 2355
		heebieJeebies,
		// Token: 0x04000934 RID: 2356
		holly,
		// Token: 0x04000935 RID: 2357
		houseFunky,
		// Token: 0x04000936 RID: 2358
		hypnotic,
		// Token: 0x04000937 RID: 2359
		iceCreamCones,
		// Token: 0x04000938 RID: 2360
		lightBulb,
		// Token: 0x04000939 RID: 2361
		lightning1,
		// Token: 0x0400093A RID: 2362
		lightning2,
		// Token: 0x0400093B RID: 2363
		mapPins,
		// Token: 0x0400093C RID: 2364
		mapleLeaf,
		// Token: 0x0400093D RID: 2365
		mapleMuffins,
		// Token: 0x0400093E RID: 2366
		marquee,
		// Token: 0x0400093F RID: 2367
		marqueeToothed,
		// Token: 0x04000940 RID: 2368
		moons,
		// Token: 0x04000941 RID: 2369
		mosaic,
		// Token: 0x04000942 RID: 2370
		musicNotes,
		// Token: 0x04000943 RID: 2371
		northwest,
		// Token: 0x04000944 RID: 2372
		ovals,
		// Token: 0x04000945 RID: 2373
		packages,
		// Token: 0x04000946 RID: 2374
		palmsBlack,
		// Token: 0x04000947 RID: 2375
		palmsColor,
		// Token: 0x04000948 RID: 2376
		paperClips,
		// Token: 0x04000949 RID: 2377
		papyrus,
		// Token: 0x0400094A RID: 2378
		partyFavor,
		// Token: 0x0400094B RID: 2379
		partyGlass,
		// Token: 0x0400094C RID: 2380
		pencils,
		// Token: 0x0400094D RID: 2381
		people,
		// Token: 0x0400094E RID: 2382
		peopleWaving,
		// Token: 0x0400094F RID: 2383
		peopleHats,
		// Token: 0x04000950 RID: 2384
		poinsettias,
		// Token: 0x04000951 RID: 2385
		postageStamp,
		// Token: 0x04000952 RID: 2386
		pumpkin1,
		// Token: 0x04000953 RID: 2387
		pushPinNote2,
		// Token: 0x04000954 RID: 2388
		pushPinNote1,
		// Token: 0x04000955 RID: 2389
		pyramids,
		// Token: 0x04000956 RID: 2390
		pyramidsAbove,
		// Token: 0x04000957 RID: 2391
		quadrants,
		// Token: 0x04000958 RID: 2392
		rings,
		// Token: 0x04000959 RID: 2393
		safari,
		// Token: 0x0400095A RID: 2394
		sawtooth,
		// Token: 0x0400095B RID: 2395
		sawtoothGray,
		// Token: 0x0400095C RID: 2396
		scaredCat,
		// Token: 0x0400095D RID: 2397
		seattle,
		// Token: 0x0400095E RID: 2398
		shadowedSquares,
		// Token: 0x0400095F RID: 2399
		sharksTeeth,
		// Token: 0x04000960 RID: 2400
		shorebirdTracks,
		// Token: 0x04000961 RID: 2401
		skyrocket,
		// Token: 0x04000962 RID: 2402
		snowflakeFancy,
		// Token: 0x04000963 RID: 2403
		snowflakes,
		// Token: 0x04000964 RID: 2404
		sombrero,
		// Token: 0x04000965 RID: 2405
		southwest,
		// Token: 0x04000966 RID: 2406
		stars,
		// Token: 0x04000967 RID: 2407
		starsTop,
		// Token: 0x04000968 RID: 2408
		stars3d,
		// Token: 0x04000969 RID: 2409
		starsBlack,
		// Token: 0x0400096A RID: 2410
		starsShadowed,
		// Token: 0x0400096B RID: 2411
		sun,
		// Token: 0x0400096C RID: 2412
		swirligig,
		// Token: 0x0400096D RID: 2413
		tornPaper,
		// Token: 0x0400096E RID: 2414
		tornPaperBlack,
		// Token: 0x0400096F RID: 2415
		trees,
		// Token: 0x04000970 RID: 2416
		triangleParty,
		// Token: 0x04000971 RID: 2417
		triangles,
		// Token: 0x04000972 RID: 2418
		tribal1,
		// Token: 0x04000973 RID: 2419
		tribal2,
		// Token: 0x04000974 RID: 2420
		tribal3,
		// Token: 0x04000975 RID: 2421
		tribal4,
		// Token: 0x04000976 RID: 2422
		tribal5,
		// Token: 0x04000977 RID: 2423
		tribal6,
		// Token: 0x04000978 RID: 2424
		twistedLines1,
		// Token: 0x04000979 RID: 2425
		twistedLines2,
		// Token: 0x0400097A RID: 2426
		vine,
		// Token: 0x0400097B RID: 2427
		waveline,
		// Token: 0x0400097C RID: 2428
		weavingAngles,
		// Token: 0x0400097D RID: 2429
		weavingBraid,
		// Token: 0x0400097E RID: 2430
		weavingRibbon,
		// Token: 0x0400097F RID: 2431
		weavingStrips,
		// Token: 0x04000980 RID: 2432
		whiteFlowers,
		// Token: 0x04000981 RID: 2433
		woodwork,
		// Token: 0x04000982 RID: 2434
		xIllusions,
		// Token: 0x04000983 RID: 2435
		zanyTriangles,
		// Token: 0x04000984 RID: 2436
		zigZag,
		// Token: 0x04000985 RID: 2437
		zigZagStitch
	}
}
