namespace Litio.AutoFixture
{
  public class ViewModelAdapterBase
  {

  }

  public class ViewModelAdapterBase<T> : ViewModelAdapterBase
  {
    public T Model { get; set; }
    public T ModelBuilder { get; set; }
  }
}