require = function() end


local filepath = triggerServerEvent == nil and "Dist/Server/manifest.lua" or "Dist/Client/manifest.lua"
local file = fileOpen(filepath)
local content = fileRead(file, fileGetSize(file))
fileClose(file)
local result = loadstring(content)
result()()

if triggerServerEvent == nil then
	ServerTest.Program.Main()
else
	ClientTest.Program.Main()
end