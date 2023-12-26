namespace Gestai.Backend.Estoque.App.Exeptions;

public class MethodNotAllowedException : Exception
{
  public MethodNotAllowedException() : base("unsuported http method")
  {

  }
}