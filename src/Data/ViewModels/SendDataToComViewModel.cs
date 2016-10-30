using System;

namespace Data.ViewModels
{
	public class SendDataToComViewModel
	{
		/// <summary>
		/// Идентификатор устройства
		/// </summary>
		/// <value>The device identifier.</value>
		public string DeviceId { get; set; }
		/// <summary>
		/// Данные для устройства
		/// </summary>
		/// <value>The value.</value>
		public string Value { get; set; }
	}
}