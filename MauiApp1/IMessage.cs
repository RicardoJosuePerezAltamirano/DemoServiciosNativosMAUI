using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1
{
    public interface IMessage
    {
        void ShowMessageAndCatchAction(string Message, Action<string> ToClick);
    }
}
