using System.Text;

namespace EHR
{
    class ConsoleLogger
    {
        private StringBuilder sb = new StringBuilder();

        internal void AddStatus(string status)
        {
            sb.AppendLine(status);
        }
        public string GetStatus()
        {
            return sb.ToString();
        }


    }
}