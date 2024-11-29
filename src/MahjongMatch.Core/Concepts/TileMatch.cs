namespace MahjongMatch.Concepts;

/// <summary>
/// Represents a match of a puzzle.
/// </summary>
/// <param name="Tile1">Indicates the tile 1.</param>
/// <param name="Tile2">Indicates the tile 2.</param>
public readonly record struct TileMatch(PuzzleTile Tile1, PuzzleTile Tile2) : IEqualityOperators<TileMatch, TileMatch, bool>;
