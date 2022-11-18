using System;
using System.Linq;

namespace Nager.Country.Translation
{
	public static class TranslationProviderExtension
	{
		///<inheritdoc/>
		public static ILanguageTranslation? GetLanguageByNameConsiderTranslation(
			this ITranslationProvider translationProvider,
			string languageName)
		{
			var languages = translationProvider.GetLanguages();

			foreach (var language in languages)
			{
				if (language.CommonName.Equals(languageName, StringComparison.OrdinalIgnoreCase))
				{
					return language;
				}

				if (language.OfficialName.Equals(languageName, StringComparison.OrdinalIgnoreCase))
				{
					return language;
				}

				if (language.Translations.Any(translation => translation.Name.Equals(languageName, StringComparison.OrdinalIgnoreCase)))
				{
					return language;
				}
			}

			return null;
		}
	}
}
