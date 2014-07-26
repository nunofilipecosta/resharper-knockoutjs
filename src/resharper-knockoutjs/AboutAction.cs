using System.Windows.Forms;
using JetBrains.ActionManagement;
using JetBrains.Application.DataContext;

namespace resharper_knockoutjs
{
  [ActionHandler("resharper-knockoutjs.About")]
  public class AboutAction : IActionHandler
  {
    public bool Update(IDataContext context, ActionPresentation presentation, DelegateUpdate nextUpdate)
    {
      // return true or false to enable/disable this action
      return true;
    }

    public void Execute(IDataContext context, DelegateExecute nextExecute)
    {
      MessageBox.Show(
        "resharper-knockoutjs\nNuno Costa\n\nresharper-knockoutjs",
        "About resharper-knockoutjs",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information);
    }
  }
}