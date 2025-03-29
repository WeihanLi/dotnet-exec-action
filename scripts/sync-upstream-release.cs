// https://docs.github.com/en/rest/releases/releases#get-the-latest-release
using System.Net.Http.Json;

const string previousRelease = "0.27.0";

HttpHelper.HttpClient.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", $"Bearer {Environment.GetEnvironmentVariable("GITHUB_TOKEN")}");
HttpHelper.HttpClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/vnd.github+json");
HttpHelper.HttpClient.DefaultRequestHeaders.TryAddWithoutValidation("X-GitHub-Api-Version", "2022-11-28");
HttpHelper.HttpClient.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/121.0.0.0 Safari/537.36");

var releaseCheckUrl = "https://api.github.com/repos/WeihanLi/dotnet-exec/releases/latest";
var release = await HttpHelper.HttpClient.GetFromJsonAsync<Release>(releaseCheckUrl);

if (release.TagName is previousRelease)
{
    Console.WriteLine($"No new release found after {previousRelease} release");
    return;
}

Console.WriteLine($"New release found: {release}");
foreach (var file in Directory.GetFiles(Environment.CurrentDirectory, "*", SearchOption.AllDirectories))
{
	var sourceText = File.ReadAllText(file);
	var replacedText = sourceText.Replace(previousRelease, release.Name);
	if (replacedText == sourceText) continue;
	
	await File.WriteAllTextAsync(file, replacedText);
	Console.WriteLine($"file {file} updated");
}

public sealed record Release(string Name, [property: System.Text.Json.Serialization.JsonPropertyName("tag_name")]string TagName, string Body);
