using System;
using System.Linq;
using System.Collections.Generic;
using System.Net;
using System.Web.Http;
using System.Threading.Tasks;
using Data.Types;
using Connector;
using Data.ViewModels;
using Data.Models;
using System.IO.Ports;

namespace DHomeWebApi.Controllers
{
	
	/// <summary>
	/// Описывает контроллер для управления холлом
	/// </summary>
	public class HallController : ApiController
	{

		public List<Device> devices = new List<Device>()
		{
			new Device{ Id = "1", Name = "Люстра"},
			new Device{ Id = "2", Name = "Вентелятор"}
		};

		/// <summary>
		/// Тип подключения к устройствам
		/// </summary>
		ConnectionType _connectionType = ConnectionType.Com;


		HallConnector _connector; // Коннектор для хола


		public HallController()
		{
			string[] avaliblePorts = SerialPort.GetPortNames();
			if (avaliblePorts.Length > 0)
				_connector = new HallConnector(_connectionType, avaliblePorts[0]);
			else
				throw new Exception("Порт не найден");
		}

		public async Task<IEnumerable<DeviceStatusViewModel>> GetAllDevices()
		{
			return await _connector.GetDeviceStatus(null);
		}

	
		public async Task<DeviceStatusViewModel> Post(SendDataToComViewModel data)
		{
			return await Task.Run(() => 
			{
				string query = data.DeviceId + " " + data.Value;
				bool requestResult = _connector.Post(data.Value);

				Device device = devices.FirstOrDefault(x => x.Id == data.DeviceId); // Получаем устройство из списка устройств

				if (device != null) // Если такое устройство существует
				{
					if (requestResult) // Если данные отправили успешно
					{
						//_connector.Get(

						bool status = true;

						return new DeviceStatusViewModel { Device = device, Status = status };
					}
				}
				return new DeviceStatusViewModel { ErrorMessage = "Устройство с таким идентификатором не найденно." };
			});
		}
	}
}

//public Device GetProductById(int id)
//{
//	//var product = devices.FirstOrDefault((p) => p.Id == id);
//	//if (product == null)
//	//{
//	//	throw new HttpResponseException(HttpStatusCode.NotFound);
//	//}
//	//return product;
//}

//public IEnumerable<Device> GetProductsByCategory(string category)
//{
//	return devices.Where(p => string.Equals(p.Name, category,
//			StringComparison.OrdinalIgnoreCase));
//}