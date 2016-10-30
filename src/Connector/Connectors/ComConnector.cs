using System;
using System.Threading.Tasks;
using Com;

namespace Connector.Connectors
{
	/// <summary>
	/// Описывает соединение через Com порт устройства
	/// </summary>
	public class ComConnector : IConnector
	{
		/// <summary>
		/// Соm порт для подключения
		/// </summary>
		private string _port;

		public ComConnector(string port)
		{
			_port = port;
		}

		/// <summary>
		/// Отправляет сообщение на Com порт
		/// </summary>
		/// <param name="message">Message.</param>
		public bool Send(string message)
		{
			var send = new SendData();
			if (send.Send(_port, message))
				return true;
			return false;
		}
	}
}