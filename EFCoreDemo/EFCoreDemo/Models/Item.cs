using System;

namespace EFCoreDemo.Models
{
    public class Item
    {
		public string Id { get; set; }

		public string Text { get; set; }
        public string Description { get; set; }

		public ItemCategory Category { get; set; }
	}

	public enum ItemCategory
	{
		Shopping,
		Work,
		Private
	}
}