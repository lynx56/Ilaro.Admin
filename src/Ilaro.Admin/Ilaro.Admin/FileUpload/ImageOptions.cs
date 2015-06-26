﻿using System.Collections.Generic;

namespace Ilaro.Admin.FileUpload
{
	public class ImageOptions
	{
		public NameCreation NameCreation { get; set; }

		public long MaxFileSize { get; set; }

		public string[] AllowedFileExtensions { get; set; }

		public IList<ImageSettings> Settings { get; set; }

		public bool IsMultiple { get; set; }
	}
}