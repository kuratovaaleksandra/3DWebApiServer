using System;
using System.Threading.Tasks;

namespace Connector.Connectors
{
	public interface IConnector
	{
		/// <summary>
		/// Connect the specified message.
		/// </summary>
		/// <param name="message">Message.</param>
		bool Send(string message);
	}
}