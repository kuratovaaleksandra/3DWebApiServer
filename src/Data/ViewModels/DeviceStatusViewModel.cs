using System;
using Data.Models;

namespace Data.ViewModels
{
	public class DeviceStatusViewModel
	{
		/// <summary>
		/// Устройство
		/// </summary>
		/// <value>The device.</value>
		public Device Device {get; set;}

		/// <summary>
		/// Сосотояние устройства
		/// </summary>
		/// <value><c>true</c> if status; otherwise, <c>false</c>.</value>
		public bool Status { get; set; }

		/// <summary>
		/// Описание ошибки
		/// </summary>
		/// <value>The error message.</value>
		public string ErrorMessage { get; set; }
	}
}