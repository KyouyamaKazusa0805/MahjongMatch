namespace MahjongMatch.Concepts;

public partial class Layer
{
	/// <summary>
	/// Represents an enumerator type that can iterate on each coordinate.
	/// </summary>
	/// <param name="_layer">The layer.</param>
	public ref struct CoordinateEnumerator(Layer _layer) : IEnumerator<Coordinate>, IEnumerable<Coordinate>
	{
		/// <summary>
		/// Indicates the current index.
		/// </summary>
		private int _index = -1;


		/// <inheritdoc/>
		public readonly Coordinate Current => _layer._coordinates[_index];

		/// <inheritdoc/>
		readonly object IEnumerator.Current => Current;


#pragma warning disable CS0809
		/// <inheritdoc cref="Span{T}.Equals(object?)"/>
		[DoesNotReturn]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("This method is not supported.", true)]
		public override readonly bool Equals([NotNullWhen(true)] object? obj) => throw new NotSupportedException();

		/// <inheritdoc cref="Span{T}.Equals(object?)"/>
		[DoesNotReturn]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("This method is not supported.", true)]
		public override readonly int GetHashCode() => throw new NotSupportedException();

		/// <inheritdoc cref="Span{T}.Equals(object?)"/>
		[DoesNotReturn]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("This method is not supported.", true)]
		public override readonly string ToString() => throw new NotSupportedException();
#pragma warning restore CS0809

		/// <inheritdoc/>
		public bool MoveNext() => ++_index < _layer.Count;

		/// <inheritdoc cref="IEnumerable{T}.GetEnumerator"/>
		public readonly CoordinateEnumerator GetEnumerator() => this;

		/// <inheritdoc/>
		readonly void IDisposable.Dispose() { }

		/// <inheritdoc/>
		[DoesNotReturn]
		readonly void IEnumerator.Reset() => throw new NotImplementedException();

		/// <inheritdoc/>
		readonly IEnumerator IEnumerable.GetEnumerator() => _layer._coordinates.GetEnumerator();

		/// <inheritdoc/>
		readonly IEnumerator<Coordinate> IEnumerable<Coordinate>.GetEnumerator() => _layer._coordinates.GetEnumerator();
	}
}
