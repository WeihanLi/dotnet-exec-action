# dotnet-exec-action

## Intro

Github action for [dotnet-exec](https://github.com/WeihanLi/dotnet-exec)

This is a github action for executing C# scripts with dotnet-exec easily

## Arguments

### script

**Required**, the the script to be executed

### arguments

**Optional**, the arguments to be passed to the script

## Example usage

```yaml
- name: dotnet-exec
  uses: WeihanLi/dotnet-exec-action@0.1.0
  with:
    script: "./build/build.cs"
    arguments: "target=test"
```
