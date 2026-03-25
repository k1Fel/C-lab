using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starodubov_PD21
{
    public class MessagePublisher
    {
        public event Action<string> MessagePublished;

        public void PublishMessage(string message)
        {
            MessagePublished?.Invoke(message);
        }
    }
}
