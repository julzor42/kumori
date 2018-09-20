#!/bin/bash
dotnet publish -c Release
sudo systemctl restart kumori.service
