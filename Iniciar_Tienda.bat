@echo off
title Impulsa Store Manizales
echo ===================================================
echo   Impulsa Store Manizales - Edicion Sneakers & Moda
echo ===================================================
echo Iniciando aplicacion...
if exist ImpulsaStore.exe (
    start "" ImpulsaStore.exe
) else (
    start "" index.html
)
exit
