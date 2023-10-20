using Microsoft.Windows.ApplicationModel.Resources;

namespace BpostImportCalculator.Helpers
{
	public static class ResourceExtention
	{
		private static readonly ResourceLoader _resourceLoader = new();

		public static string GetLocalized(this string resourceKey)
		{
			return _resourceLoader.GetString(resourceKey);
		}
	}
}
