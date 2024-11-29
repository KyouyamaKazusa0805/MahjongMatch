namespace MahjongMatch.Generating;

/// <summary>
/// Provides a generator.
/// </summary>
public readonly ref struct Generator()
{
	/// <summary>
	/// Indicates all possible tiles.
	/// </summary>
	private static readonly Tile[] Tiles = [
		Tile.Bamboo(1), Tile.Bamboo(1), Tile.Bamboo(1), Tile.Bamboo(1),
		Tile.Bamboo(2), Tile.Bamboo(2), Tile.Bamboo(2), Tile.Bamboo(2),
		Tile.Bamboo(3), Tile.Bamboo(3), Tile.Bamboo(3), Tile.Bamboo(3),
		Tile.Bamboo(4), Tile.Bamboo(4), Tile.Bamboo(4), Tile.Bamboo(4),
		Tile.Bamboo(5), Tile.Bamboo(5), Tile.Bamboo(5), Tile.Bamboo(5),
		Tile.Bamboo(6), Tile.Bamboo(6), Tile.Bamboo(6), Tile.Bamboo(6),
		Tile.Bamboo(7), Tile.Bamboo(7), Tile.Bamboo(7), Tile.Bamboo(7),
		Tile.Bamboo(8), Tile.Bamboo(8), Tile.Bamboo(8), Tile.Bamboo(8),
		Tile.Bamboo(9), Tile.Bamboo(9), Tile.Bamboo(9), Tile.Bamboo(9),
		Tile.Character(1), Tile.Character(1), Tile.Character(1), Tile.Character(1),
		Tile.Character(2), Tile.Character(2), Tile.Character(2), Tile.Character(2),
		Tile.Character(3), Tile.Character(3), Tile.Character(3), Tile.Character(3),
		Tile.Character(4), Tile.Character(4), Tile.Character(4), Tile.Character(4),
		Tile.Character(5), Tile.Character(5), Tile.Character(5), Tile.Character(5),
		Tile.Character(6), Tile.Character(6), Tile.Character(6), Tile.Character(6),
		Tile.Character(7), Tile.Character(7), Tile.Character(7), Tile.Character(7),
		Tile.Character(8), Tile.Character(8), Tile.Character(8), Tile.Character(8),
		Tile.Character(9), Tile.Character(9), Tile.Character(9), Tile.Character(9),
		Tile.Dot(1), Tile.Dot(1), Tile.Dot(1), Tile.Dot(1),
		Tile.Dot(2), Tile.Dot(2), Tile.Dot(2), Tile.Dot(2),
		Tile.Dot(3), Tile.Dot(3), Tile.Dot(3), Tile.Dot(3),
		Tile.Dot(4), Tile.Dot(4), Tile.Dot(4), Tile.Dot(4),
		Tile.Dot(5), Tile.Dot(5), Tile.Dot(5), Tile.Dot(5),
		Tile.Dot(6), Tile.Dot(6), Tile.Dot(6), Tile.Dot(6),
		Tile.Dot(7), Tile.Dot(7), Tile.Dot(7), Tile.Dot(7),
		Tile.Dot(8), Tile.Dot(8), Tile.Dot(8), Tile.Dot(8),
		Tile.Dot(9), Tile.Dot(9), Tile.Dot(9), Tile.Dot(9),
		Tile.Wind(1), Tile.Wind(1), Tile.Wind(1), Tile.Wind(1),
		Tile.Wind(2), Tile.Wind(2), Tile.Wind(2), Tile.Wind(2),
		Tile.Wind(3), Tile.Wind(3), Tile.Wind(3), Tile.Wind(3),
		Tile.Wind(4), Tile.Wind(4), Tile.Wind(4), Tile.Wind(4),
		Tile.Wrigley(1), Tile.Wrigley(1), Tile.Wrigley(1), Tile.Wrigley(1),
		Tile.Wrigley(2), Tile.Wrigley(2), Tile.Wrigley(2), Tile.Wrigley(2),
		Tile.Wrigley(3), Tile.Wrigley(3), Tile.Wrigley(3), Tile.Wrigley(3),
		Tile.Flower(1), Tile.Flower(2), Tile.Flower(3), Tile.Flower(4),
		Tile.Season(1), Tile.Flower(2), Tile.Flower(3), Tile.Flower(4)
	];

	/// <summary>
	/// The start indices of different tiles.
	/// </summary>
	private static readonly Dictionary<Tile, int> TilesStartIndices = new()
	{
		{ Tile.Bamboo(1), 0 },
		{ Tile.Bamboo(2), 4 },
		{ Tile.Bamboo(3), 8 },
		{ Tile.Bamboo(4), 12 },
		{ Tile.Bamboo(5), 16 },
		{ Tile.Bamboo(6), 20 },
		{ Tile.Bamboo(7), 24 },
		{ Tile.Bamboo(8), 28 },
		{ Tile.Bamboo(9), 32 },
		{ Tile.Character(1), 36 },
		{ Tile.Character(2), 40 },
		{ Tile.Character(3), 44 },
		{ Tile.Character(4), 48 },
		{ Tile.Character(5), 52 },
		{ Tile.Character(6), 56 },
		{ Tile.Character(7), 60 },
		{ Tile.Character(8), 64 },
		{ Tile.Character(9), 68 },
		{ Tile.Dot(1), 72 },
		{ Tile.Dot(2), 76 },
		{ Tile.Dot(3), 80 },
		{ Tile.Dot(4), 84 },
		{ Tile.Dot(5), 88 },
		{ Tile.Dot(6), 92 },
		{ Tile.Dot(7), 96 },
		{ Tile.Dot(8), 100 },
		{ Tile.Dot(9), 104 },
		{ Tile.Wind(1), 108 },
		{ Tile.Wind(2), 112 },
		{ Tile.Wind(3), 116 },
		{ Tile.Wind(4), 120 },
		{ Tile.Wrigley(1), 124 },
		{ Tile.Wrigley(2), 128 },
		{ Tile.Wrigley(3), 132 },
		{ Tile.Flower(1), 136 },
		{ Tile.Season(1), 140 }
	};


	/// <summary>
	/// Indicates the backing random number generator.
	/// </summary>
	private readonly Random _random = new();


#pragma warning disable CS0809
	/// <inheritdoc cref="Span{T}.Equals(object?)"/>
	[DoesNotReturn]
	[Obsolete("This method is not supported.", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override bool Equals(object? obj) => throw new NotSupportedException();

	/// <inheritdoc cref="Span{T}.Equals(object?)"/>
	[DoesNotReturn]
	[Obsolete("This method is not supported.", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override int GetHashCode() => throw new NotSupportedException();

	/// <inheritdoc cref="Span{T}.Equals(object?)"/>
	[DoesNotReturn]
	[Obsolete("This method is not supported.", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public override string ToString() => throw new NotSupportedException();
#pragma warning restore CS0809

	/// <summary>
	/// Try to generate a puzzle via the pattern.
	/// </summary>
	/// <param name="pattern">
	/// The pattern; although the target type is <see cref="Puzzle"/>, it may not require any tiles predefined.
	/// </param>
	/// <param name="cancellationToken">The cancellation token that can cancel the current operation.</param>
	/// <returns>The puzzle; or <see langword="null"/> if cancelled.</returns>
	public Puzzle Generate(Puzzle pattern, CancellationToken cancellationToken = default)
	{
		var elementsCount = pattern.ItemsCount;
		var positionsMarker = new BitArray(elementsCount);
		var fullTilesMarker = new BitArray(144);
		var tilesMarker = new BitArray(36);
		var tileKeys = TilesStartIndices.Keys.ToArray();
		while (true)
		{
			positionsMarker.SetAll(true);
			fullTilesMarker.SetAll(true);
			tilesMarker.SetAll(true);

			var result = pattern.Clone();
			var resultEntry = result.EnumerateTiles();
			while (positionsMarker.GetCardinality() != 0)
			{
				// Randomly select two tiles.
				var validPositionIndices = getIndices(positionsMarker);
				var validTileIndices = getIndices(tilesMarker);
				int pos1, pos2, selectedTileIndex;
				do
				{
					pos1 = _random.Next(0, validPositionIndices.Length);
					pos2 = _random.Next(0, validPositionIndices.Length);
				} while (pos1 == pos2);
				do
				{
					selectedTileIndex = validTileIndices[_random.Next(0, validTileIndices.Length)];
				} while (!tilesMarker[selectedTileIndex]);

				resultEntry[pos1] = Tiles[TilesStartIndices[tileKeys[selectedTileIndex]]];
				resultEntry[pos2] = Tiles[TilesStartIndices[tileKeys[selectedTileIndex]]];

				positionsMarker[pos1] = false;
				positionsMarker[pos2] = false;
				fullTilesMarker[
					fullTilesMarker[TilesStartIndices[tileKeys[selectedTileIndex]]]
						? TilesStartIndices[tileKeys[selectedTileIndex]]
						: TilesStartIndices[tileKeys[selectedTileIndex]] + 2
				] = false;
				fullTilesMarker[
					fullTilesMarker[TilesStartIndices[tileKeys[selectedTileIndex]] + 1]
						? TilesStartIndices[tileKeys[selectedTileIndex]] + 1
						: TilesStartIndices[tileKeys[selectedTileIndex]] + 3
				] = false;
				if (!fullTilesMarker[TilesStartIndices[tileKeys[selectedTileIndex]]]
					&& !fullTilesMarker[TilesStartIndices[tileKeys[selectedTileIndex]] + 1]
					&& !fullTilesMarker[TilesStartIndices[tileKeys[selectedTileIndex]] + 2]
					&& !fullTilesMarker[TilesStartIndices[tileKeys[selectedTileIndex]] + 3])
				{
					tilesMarker[selectedTileIndex] = false;
				}
			}

			// Check validity.
			if (true)
			{
				return result;
			}

			if (cancellationToken.IsCancellationRequested)
			{
				return null!;
			}
		}


		static ReadOnlySpan<int> getIndices(BitArray array)
		{
			var result = new List<int>(array.GetCardinality());
			for (var i = 0; i < array.Length; i++)
			{
				if (array[i])
				{
					result.Add(i);
				}
			}
			return result.AsSpan();
		}
	}
}
