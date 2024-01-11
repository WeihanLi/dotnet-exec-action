# dotnet-exec-action

## Intro

Github action for [dotnet-exec](https://github.com/WeihanLi/dotnet-exec)

This is a github action for executing C# scripts with dotnet-exec easily without setting up the dotnet environment

## Arguments

### script

**Required**, the script to be executed

### arguments

**Optional**, the command-line arguments to be passed to the script

## Example usage

```yaml
- name: dotnet-exec script
  uses: WeihanLi/dotnet-exec-action@0.1.0
  with:
    script: "./build/build.cs" # script text or script path
    arguments: "target=test" # optional
```
