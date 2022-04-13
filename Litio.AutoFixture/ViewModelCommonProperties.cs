using System;

namespace Litio.AutoFixture
{
  public class ViewModelCommonProperties : IViewModelCommonProperties
  {
    public ILocalizer Localizer { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
  }
}