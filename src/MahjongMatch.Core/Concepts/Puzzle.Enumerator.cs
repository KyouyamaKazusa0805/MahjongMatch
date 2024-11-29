namespace MahjongMatch.Concepts;

public partial class Puzzle
{
	/// <summary>
	/// Represents an enumerator type that can iterate on each layer.
	/// </summary>
	/// <param name="layers">Indicates the layers.</param>
	public ref struct Enumerator(ReadOnlySpan<Layer> layers) : IEnumerator<Layer>
	{
		/// <summary>
		/// Indicates the layers.
		/// </summary>
		private readonly ReadOnlySpan<Layer> _layers = layers;

		/// <summary>
		/// Indicates the index.
		/// </summary>
		private int _index = -1;


		/// <inheritdoc/>
		public readonly Layer Current => _layers[_index];

		/// <inheritdoc/>
		readonly object IEnumerator.Current => Current;


#pragma warning disable CS0809
		/// <inheritdoc cref="Span{T}.Equals(object?)"/>
		[DoesNotReturn]
		[Obsolete("This method is not supported.", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override readonly bool Equals([NotNullWhen(true)] object? obj) => throw new NotSupportedException();

		/// <inheritdoc cref="Span{T}.Equals(object?)"/>
		[DoesNotReturn]
		[Obsolete("This method is not supported.", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override readonly int GetHashCode() => throw new NotSupportedException();

		/// <inheritdoc cref="Span{T}.Equals(object?)"/>
		[DoesNotReturn]
		[Obsolete("This method is not supported.", true)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override readonly string ToString() => throw new NotSupportedException();
#pragma warning restore CS0809

		/// <inheritdoc/>
		public bool MoveNext() => ++_index < _layers.Length;

		/// <inheritdoc/>
		readonly void IDisposable.Dispose() { }

		/// <inheritdoc/>
		[DoesNotReturn]
		readonly void IEnumerator.Reset() => throw new NotImplementedException();
	}
}
