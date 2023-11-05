
# Quick Reference

- Source Repository: [GitHub](https://github.com/dekoeky/configuration-checker)

- Report Issues: [GitHub](https://github.com/dekoeky/configuration-checker/issues)

# What does configuration-visualization do?

This image was created as a non-production tool for testing container configuration. More specifically, [.NET Configuration](https://learn.microsoft.com/en-us/dotnet/core/extensions/configuration).

This image can be used to visualize the configuration provided for a docker container, using a simple web page.

# How to use this image?

```console
docker run -d --name configuration-visualizer -p 8080:80 dekoeky/configuration-visualization
```

# LICENSE
For licensing information please refer to the 
[GitHub Repository](https://github.com/dekoeky/configuration-checker/blob/develop/LICENSE)