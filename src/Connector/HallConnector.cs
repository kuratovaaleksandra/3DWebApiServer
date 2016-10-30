using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Models;
using Data.ViewModels;
using System.IO.Ports;
using Data.Types;
using Connector.Connectors;
using Com;

namespace Connector
{
	public class HallConnector
	{
		/// <summary>
		/// Коннектор к устройствам
		/// </summary>
		private IConnector _connector;

		/// <summary>
		/// Создает объект подключения к холлу
		/// </summary>
		/// <param name="type">Type.</param>
		public HallConnector(ConnectionType type, object data)
		{
			if (type == ConnectionType.Com)
			{
				string port = (string)data;
				_connector = new ComConnector(port);
			}
			else if (type == ConnectionType.Radio)
			{
				throw new NotImplementedException();
			}
			else
				throw new Exception("Ошибка типа подключения");
		}

		/// <summary>
		/// Включает устройство
		/// </summary>
		/// <returns><c>true</c>, if device was enabled, <c>false</c> otherwise.</returns>
		/// <param name="value">value.</param>
		public bool Post(string value)
		{
			return _connector.Send(value);
		}

		/// <summary>
		/// Выключает устройство
		/// </summary>
		/// <returns><c>true</c>, if device was disabled, <c>false</c> otherwise.</returns>
		/// <param name="value">Device.</param>
		public async Task<bool> Get(string value)
		{
			return await Task.Run(() => { return true; });
		}

		/// <summary>
		/// Gets the device status.
		/// </summary>
		/// <returns>The device status.</returns>
		/// <param name="device">Device. Если Null, то возвращает статусы всех устройств</param>
		public async Task<IEnumerable<DeviceStatusViewModel>> GetDeviceStatus(Device device = null)
		{
			Device[] devices = {
				new Device { Id = "1", Name = "Лампа"},
				new Device { Id = "2", Name = "Вентелятор"}
   			};


			if (device == null)
				return await Task.Run(() =>
			{
				return new List<DeviceStatusViewModel>() {
					new DeviceStatusViewModel { Device = devices[0], Status = true},
					new DeviceStatusViewModel { Device = devices[1], Status = true}
				};
			});
			else
				return await Task.Run(() =>
				{
					return new List<DeviceStatusViewModel>() {
							new DeviceStatusViewModel { Device = devices[0], Status = true},
							new DeviceStatusViewModel { Device = devices[1], Status = true}
					};
				});
		}
	}
}