using System;

namespace Data.Models
{
	/// <summary>
	/// Описывает свойства устройства
	/// </summary>
	public class Device
	{
		/// <summary>
		/// Идентификатор устройства
		/// </summary>
		/// <value>The identifier.</value>
		public string Id { get; set; }

		/// <summary>
		/// Имя устройства
		/// </summary>
		/// <value>The name.</value>
		public string Name { get; set; }
	}
}