namespace Gestai.Backend.Stock.App.Exeptions;

public class MethodNotAllowedException : Exception
{
  public MethodNotAllowedException() : base("unsuported http method")
  {

  }
}