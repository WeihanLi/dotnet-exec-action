// https://docs.github.com/en/rest/releases/releases#get-the-latest-release

const string previousRelease = "0.17.0";

HttpHelper.HttpClient.DefaultRequestHeaders.TryAddWithoutValidation("Authorization", $"Bearer {Environment.GetEnvironmentVariable("GITHUB_TOKEN")}");
HttpHelper.HttpClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/vnd.github+json");
HttpHelper.HttpClient.DefaultRequestHeaders.TryAddWithoutValidation("X-GitHub-Api-Version", "2022-11-28");

var releaseCheckUrl = "https://api.github.com/repos/WeihanLi/dotnet-exec/releases/latest";
var release = await HttpHelper.HttpClient.GetFromJsonAsync<Release>(releaseCheckUrl);

if (release.Name is previousRelease)
{
    return 0;
}

return 1;

public sealed record Release(string Name, string Body);
