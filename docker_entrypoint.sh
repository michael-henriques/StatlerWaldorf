#!/bin/bash
cd /pipeline/source/app/StatlerWaldorf.TeamService/publish/
dotnet StatlerWaldorf.TeamService.dll --server.urls=http://0.0.0.0:${PORT-"8080"}