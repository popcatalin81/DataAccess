namespace iQuarc.DataAccess
{
	public interface IEntityEntry<out T>
		where T : class
	{
		T Entity { get; }
		EntityEntryStates State { get; }
		object GetOriginalValue(string propertyName);
		void SetOriginalValue(string propertyName, object value);
	}

	public interface IEntityEntry
	{
		object Entity { get; }
		EntityEntryStates State { get; }
		object GetOriginalValue(string propertyName);
		IEntityEntry<T> Convert<T>() where T : class;
		void SetOriginalValue(string propertyName, object value);
	}
}