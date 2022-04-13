namespace Litio.AutoFixture
{
  public interface IModelBuilder<TModelSource> where TModelSource : class, new()
  {
    TModelDestination Build<TModelDestination>(TModelSource model) where TModelDestination : class, new();
  }
}