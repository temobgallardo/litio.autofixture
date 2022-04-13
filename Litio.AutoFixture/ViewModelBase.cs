using System;
using System.Collections.Generic;
using System.Text;

namespace Litio.AutoFixture
{
  public abstract class ViewModelBase
  {
    protected IViewModelCommonProperties _viewModelProps;

    public ViewModelBase(IViewModelCommonProperties viewModelCommonProperties)
    {
      _viewModelProps = viewModelCommonProperties;
    }

    protected void ExecuteAndHandle(Action action)
    {
      try
      {
        action?.Invoke();
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex.ToString());
      }
    
  }
}
