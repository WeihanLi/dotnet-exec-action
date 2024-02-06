# dotnet-exec-action

## Intro

Github action for [dotnet-exec](https://github.com/WeihanLi/dotnet-exec)

This is a github action for executing C# scripts with dotnet-exec easily without setting up the dotnet environment

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
  uses: WeihanLi/dotnet-exec-action@0.17.0
  with:
    script: "./build/build.cs" # script text or script path
    options: "--web --debug" # optional
    arguments: "target=test" # optional
```
