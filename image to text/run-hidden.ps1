
$exe = Join-Path -Path $PSScriptRoot -ChildPath "bin\Debug\net10.0-windows\image_to_text.exe"
if (-Not (Test-Path $exe)) {
	Write-Error "Executable not found: $exe. Build the project first."
	exit 1
}
Start-Process -FilePath $exe -WindowStyle Hidden -WorkingDirectory (Split-Path $exe)
