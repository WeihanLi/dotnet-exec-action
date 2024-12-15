# dotnet-exec-action

## Intro

Github action for [dotnet-exec](https://github.com/WeihanLi/dotnet-exec)

This is a Github action for executing C# scripts with dotnet-exec easily without setting up the dotnet sdk

## Arguments

### script

**Required**, the script to be executed

### options

**Optional**, the more options to be used when executing script

### arguments

**Optional**, the command-line arguments to be passed to the script

## Example usage

```yaml
- name: dotnet-exec script
  uses: WeihanLi/dotnet-exec-action@0.25.0
  with:
    script: "./build/build.cs" # script text or script path
    options: "--web --debug" # optional
    arguments: "target=test" # optional
```

- https://github.com/WeihanLi/markdown-nice/blob/master/.github/workflows/docker.yaml#L34
  
