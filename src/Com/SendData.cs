using System;
using System.IO.Ports;


namespace Com
{
	public class SendData
	{
		/// <summary>
		///     Подключение к COM-порту, и отпрака данных
		/// </summary>
		/// <param name="port">Порт.</param>
		/// <param name="data">Данные.</param>
		public bool Send(string port, string data)
		{
			try
			{
				var serialPort = new SerialPort();

				serialPort.PortName = port;         
				serialPort.BaudRate = 9600;              
				serialPort.Parity = Parity.None;        
				serialPort.DataBits = 8;                  
				serialPort.StopBits = StopBits.One;      

				serialPort.Open();
				serialPort.Write(data);
				serialPort.Close(); 

				return true;
			}
			catch (Exception exe)
			{
				return false;
			}
		}
	}
}