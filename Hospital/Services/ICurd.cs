namespace Hospital.Services
{
	public interface ICurd <T> where T : class
	{
		public void Add(T e);
		public void Update(T e)	;
		public void delete(Guid id);
		public T getById(Guid id);
	}
}
