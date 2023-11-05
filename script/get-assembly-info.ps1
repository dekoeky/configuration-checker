# Clean old output
dotnet clean -v q
Get-ChildItem -Directory -Recurse .\configuration-visualization -Include bin,obj | Remove-Item -Recurse 

# Update build output
dotnet build -v q

# Get Files Of Interest
$assemblies = Get-ChildItem -File -Recurse -Path .\configuration-visualization\bin  -Include Dekoeky.*.dll, Dekoeky.*.exe

# Get Assembly Info on them
$assemblies | ForEach-Object {
  [pscustomobject]@{
    Name            = $_.Name
    FileVersion     = $_.VersionInfo.FileVersion
    ProductVersion  = $_.VersionInfo.ProductVersion
  }
}