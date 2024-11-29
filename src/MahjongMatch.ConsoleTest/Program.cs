﻿using System;
using MahjongMatch.Concepts;
using MahjongMatch.Generating;

Puzzle pattern = [
	// Layer 0
	[
		new(default, new(1, 3)),
		new(default, new(1, 7)),
		new(default, new(3, 1)),
		new(default, new(3, 3)),
		new(default, new(3, 7)),
		new(default, new(3, 9)),
		new(default, new(5, 3)),
		new(default, new(5, 7)),
		new(default, new(7, 3)),
		new(default, new(7, 7)),
		new(default, new(10, 3)),
		new(default, new(10, 7)),
		new(default, new(12, 3)),
		new(default, new(12, 7)),
		new(default, new(13, 1)),
		new(default, new(13, 9)),
		new(default, new(14, 3)),
		new(default, new(14, 7))
	],

	// Layer 1
	[
		new(default, new(1, 2)),
		new(default, new(1, 4)),
		new(default, new(1, 6)),
		new(default, new(1, 8)),
		new(default, new(3, 0)),
		new(default, new(3, 2)),
		new(default, new(3, 4)),
		new(default, new(3, 6)),
		new(default, new(3, 8)),
		new(default, new(3, 10)),
		new(default, new(5, 2)),
		new(default, new(5, 4)),
		new(default, new(5, 6)),
		new(default, new(5, 8)),
		new(default, new(7, 2)),
		new(default, new(7, 4)),
		new(default, new(7, 6)),
		new(default, new(7, 8)),
		new(default, new(9, 3)),
		new(default, new(9, 7)),
		new(default, new(11, 2)),
		new(default, new(11, 4)),
		new(default, new(11, 6)),
		new(default, new(11, 8)),
		new(default, new(13, 0)),
		new(default, new(13, 2)),
		new(default, new(13, 4)),
		new(default, new(13, 6)),
		new(default, new(13, 8)),
		new(default, new(13, 10)),
		new(default, new(15, 3)),
		new(default, new(15, 7))
	],

	// Layer 2
	[
		new(default, new(0, 2)),
		new(default, new(0, 4)),
		new(default, new(0, 6)),
		new(default, new(0, 8)),
		new(default, new(2, 0)),
		new(default, new(2, 2)),
		new(default, new(2, 4)),
		new(default, new(2, 6)),
		new(default, new(2, 8)),
		new(default, new(2, 10)),
		new(default, new(4, 0)),
		new(default, new(4, 2)),
		new(default, new(4, 4)),
		new(default, new(4, 6)),
		new(default, new(4, 8)),
		new(default, new(4, 10)),
		new(default, new(6, 2)),
		new(default, new(6, 4)),
		new(default, new(6, 6)),
		new(default, new(6, 8)),
		new(default, new(8, 2)),
		new(default, new(8, 4)),
		new(default, new(8, 6)),
		new(default, new(8, 8)),
		new(default, new(10, 2)),
		new(default, new(10, 4)),
		new(default, new(10, 6)),
		new(default, new(10, 8)),
		new(default, new(12, 0)),
		new(default, new(12, 2)),
		new(default, new(12, 4)),
		new(default, new(12, 6)),
		new(default, new(12, 8)),
		new(default, new(12, 10)),
		new(default, new(14, 0)),
		new(default, new(14, 2)),
		new(default, new(14, 4)),
		new(default, new(14, 6)),
		new(default, new(14, 8)),
		new(default, new(14, 10)),
		new(default, new(16, 2)),
		new(default, new(16, 4)),
		new(default, new(16, 6)),
		new(default, new(16, 8))
	]
];
Console.WriteLine(pattern.ToString());

var generator = new Generator();
Console.WriteLine(generator.Generate(pattern));
